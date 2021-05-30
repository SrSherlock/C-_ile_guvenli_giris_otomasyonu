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
    public partial class Setting : Form
    {
        SqlConnection baglanti = Form1.baglanti;
        internal static string username { get; set; }
        #region görünüm

        bool move;
        int move_x;
        int move_y;
        bool okay;
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            move_x = e.X;
            move_y = e.Y;
        }

        private void Setting_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Setting_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - move_x, MousePosition.Y - move_y);
            }
        }

        #endregion   
        private void Setting_Load(object sender, EventArgs e)
        {
            label3.Text = username;
            selectmail();
            selectGuard();
        }
        private void selectmail()
        {
            SqlCommand cmd = new SqlCommand(" select email from Login where kullaniciAdi='" + Cryptology.Encryption(username, 2) + "'",baglanti);
            label4.Text = Cryptology.Decryption(cmd.ExecuteScalar().ToString(),2);
            baglanti.Close();
        }
        private void selectGuard()
        {
            SqlCommand cmd = new SqlCommand(" select active from Login where kullaniciAdi='" + Cryptology.Encryption(username, 2) + "'",baglanti);
            baglanti.Open();
            checkBox1.Checked = Convert.ToBoolean(cmd.ExecuteScalar());
            baglanti.Close();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Login set active='"+checkBox1.Checked.ToString().ToLower()+"'where kullaniciAdi='"+ Cryptology.Encryption(username, 2) + "'",baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi...","Program!");
        }
    }
}
