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
using System.Net.Mail;
using System.Net;

namespace telefon
{
    public partial class Email_sorgulama : Form
    {
        SqlConnection baglanti = Form1.baglanti;
        static Random rnd = new Random();
        int rand_code = rnd.Next(100000,999999);
        public Email_sorgulama()
        {
            InitializeComponent();
        }

        private void txt_gmailyaz_Enter(object sender, EventArgs e)
        {
            if (txt_gmailyaz.Text == "Doğrulama Kodunuz")
            {
                txt_gmailyaz.Text = "";
                txt_gmailyaz.ForeColor = Color.SlateBlue;
            }
        }

        private void txt_gmailyaz_Leave(object sender, EventArgs e)
        {
            if (txt_gmailyaz.Text == "")
            {
                txt_gmailyaz.Text = "Doğrulama Kodunuz";
                txt_gmailyaz.ForeColor = Color.DarkSlateBlue;
            }
        }

        private void btn_dogrula_Click(object sender, EventArgs e)
        {
            if (txt_gmailyaz.Text == rand_code.ToString())
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Login (kullaniciAdi,sifre,re_sifre,email,phonenum,active) VALUES ('" + Cryptology.Encryption(KayıtOl.username, 2) + "','" + Cryptology.Encryption(KayıtOl.pass, 2) + "','" + Cryptology.Encryption(KayıtOl.re_pass, 2) + "','" + Cryptology.Encryption(KayıtOl.e_mail, 2) + "','" + Cryptology.Encryption(KayıtOl.phoneNum, 2) + "','false')", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Başarılı Şekilde Yapıldı...");
                this.Close();
            }
            else
            {
                MessageBox.Show("Girilen Doğrulama Kodu Hatalı...","PROGRAM");
            }
            
        }
        private void mailgönder()
        {
            SmtpClient client = new SmtpClient();
            MailMessage message = new MailMessage();
            client.Credentials = new NetworkCredential("SrSherlock38@hotmail.com", "Srkled1453-*?");
            client.Port = 587;
            client.Host = "smtp.live.com"; // smtp.gmail.com + ayarlar 
            client.EnableSsl = true; // gmailde zorunlu
            message.To.Add(KayıtOl.e_mail);
            message.From = new MailAddress("SrSherlock38@hotmail.com","BY Emre GÖREN");
            message.Subject = "...Oturum Açma İsteği...";
            message.Body = "Doğrulama Kodunuz =>" + rand_code + "<html>" +
                "<body>" +
                "<img src=https://info4idea.com/wp-content/uploads/2018/04/c-sharp-visual-studio-logo.jpg width=400 height=400 alt=\"Visual Studio\" > " +
                "<p> <a href = https://www.youtube.com/  > Kanala Gitmek İçin Tıklayınız ! </p>" +
                "</body>" +
                "</html>";
            message.IsBodyHtml = true;
            client.Send(message);
        }

        private void Email_sorgulama_Load(object sender, EventArgs e)
        {
            mailgönder();
        }
    }
}
