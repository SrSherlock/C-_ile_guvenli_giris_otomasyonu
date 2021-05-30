using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon
{
    public partial class Form1 : Form
    {  
       public static SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-J97DGL1K;Initial Catalog=phonecall;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
      

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool move;
        int move_x;
        int move_y;
        bool okay;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            move_x = e.X;
            move_y = e.Y;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - move_x, MousePosition.Y - move_y);
            }
            
        }
        #region görünüm

        private void txt_KullanıcıAdı_Enter(object sender, EventArgs e)
        {
            if (txt_KullanıcıAdı.Text=="Username")
            {
                txt_KullanıcıAdı.Text = "";
                txt_KullanıcıAdı.ForeColor = Color.SlateBlue; 
            }
        }

        private void txt_KullanıcıAdı_Leave(object sender, EventArgs e)
        {
            if (txt_KullanıcıAdı.Text =="" )
            {
                txt_KullanıcıAdı.Text = "Username";
                txt_KullanıcıAdı.ForeColor = Color.DarkSlateBlue;
            }
        }

        private void txt_sifre_Enter(object sender, EventArgs e)
        {
            if (txt_sifre.Text == "Password")
            {
                txt_sifre.Text = "";
                txt_sifre.ForeColor = Color.SlateBlue;
                txt_sifre.PasswordChar = '*';
            }
        }
        char? none = null;
        private void txt_sifre_Leave(object sender, EventArgs e)
        {
            if (txt_sifre.Text == "")
            {
                txt_sifre.Text = "Password";
                txt_sifre.ForeColor = Color.DarkSlateBlue;
                txt_sifre.PasswordChar =Convert.ToChar(none);
            }
        }
#endregion
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string kullnaiciAdi = txt_KullanıcıAdı.Text;
            string sifre = txt_sifre.Text;    
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Login",baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (kullnaiciAdi ==Cryptology.Decryption(dr["kullaniciAdi"].ToString().TrimEnd(),2) && sifre == Cryptology.Decryption(dr["sifre"].ToString().TrimEnd(),2))
                {
                    okay = true;
                    Setting.username = kullnaiciAdi;
                    break;
                }
                else
                {
                    okay = false;
                }
            }
            baglanti.Close();
            if (okay)
            {
                //MessageBox.Show("Giriş Başarılı!..","Program");
                SqlCommand cmd_active = new SqlCommand(" select active from Login where kullaniciAdi='"+Cryptology.Encryption(kullnaiciAdi,2)+"'");
                cmd_active.Connection = baglanti;
                baglanti.Open();
                if (Convert.ToBoolean(cmd_active.ExecuteScalar().ToString()))
                {
                    smsCheck.username = kullnaiciAdi;
                    smsCheck sms = new smsCheck();
                    sms.Show();
                }
                else
                {
                    Setting ky_ol = new Setting();
                    ky_ol.Show();
                }
                baglanti.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız. Eksik Yada Hatalı Giriş Yaptınız!..","Program");
            }
        }

        private void linklbl_singup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayıtOl ko = new KayıtOl();
            ko.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
