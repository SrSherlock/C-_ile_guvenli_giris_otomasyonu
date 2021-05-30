using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace telefon
{
    public partial class KayıtOl : Form
    {
        static public string username { get; set; }
        static  public string pass { get; set; }
        static public string re_pass { get; set; }
        static public string e_mail { get; set; }
        static public string phoneNum { get; set; }
        SqlConnection baglanti = Form1.baglanti;
        public KayıtOl()
        {
            InitializeComponent();
        }
        #region Görünüm
        bool move;
        int move_x;
        int move_y;
        bool okay;
        private void txt_KullanıcıAdı_Enter(object sender, EventArgs e)
        {
            if (txt_KullanıcıAdı.Text == "Username")
            {
                txt_KullanıcıAdı.Text = "";
                txt_KullanıcıAdı.ForeColor = Color.SlateBlue;
            }
        }
        private void txt_KullanıcıAdı_Leave(object sender, EventArgs e)
        {
            if (txt_KullanıcıAdı.Text == "")
            {
                txt_KullanıcıAdı.Text = "Username";
                txt_KullanıcıAdı.ForeColor = Color.DarkSlateBlue;
            }
        }      
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Password")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.SlateBlue;
                textBox1.PasswordChar = '*';
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            char? none = null;
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
                textBox1.ForeColor = Color.DarkSlateBlue;
                textBox1.PasswordChar = Convert.ToChar(none);
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "RE_Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.SlateBlue;
                textBox2.PasswordChar = '*';
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            char? none = null;
            if (textBox2.Text == "")
            {
                textBox2.Text = "RE_Password";
                textBox2.ForeColor = Color.DarkSlateBlue;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "E-Mail")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.SlateBlue;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "E-Mail";
                textBox3.ForeColor = Color.DarkSlateBlue;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Phone Number")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.SlateBlue;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Phone Number";
                textBox4.ForeColor = Color.DarkSlateBlue;
            }
        }
        
        private void AnaMenü_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            move_x = e.X;
            move_y = e.Y;
        }

        private void AnaMenü_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void AnaMenü_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - move_x, MousePosition.Y - move_y);
            }
        }
        #endregion

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            username = txt_KullanıcıAdı.Text;
            pass = textBox1.Text;
            re_pass = textBox2.Text;
            e_mail = textBox3.Text;
            phoneNum = textBox4.Text;
            Email_sorgulama sorgu = new Email_sorgulama();
            sorgu.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {

        }
    }
}
