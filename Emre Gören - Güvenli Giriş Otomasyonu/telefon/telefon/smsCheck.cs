using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon
{
    public partial class smsCheck : Form
    {
        SqlConnection baglanti = Form1.baglanti;
        int code = new Random().Next(100000, 99999);
        internal static string username { get; set; }
        public smsCheck()
        {
            InitializeComponent();
        }

        #region görünüm

        bool move;
        int move_x;
        int move_y;
        

        private void smsCheck_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            move_x = e.X;
            move_y = e.Y;
        }

        private void smsCheck_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - move_x, MousePosition.Y - move_y);
            }
        }

        private void smsCheck_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        #endregion
        private void smsCheck_Load(object sender, EventArgs e)
        {
            
           
            SqlCommand cmd = new SqlCommand(" select email from Login where kullaniciAdi='" + Cryptology.Encryption(username, 2) + "'", baglanti);
            cmd.ExecuteNonQuery();          
            sendSMS(cmd.ExecuteScalar().ToString(),code);
            baglanti.Close();
        }
        private void sendSMS(string number,int RandCode)
        {
                String result;
                string apiKey = "NmQ0MzQ2NzY3MzZiNjM2YTc3Njg2MTZiNDY2OTQ5NDI=";
                string numbers = number; // Gerçek telefon numarası
                string message = "Doğrulama Kodu :"+ RandCode;
                string sender = "BY Emre Gören";

                String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
                //refer to parameters to complete correct url string

                StreamWriter myWriter = null;
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

                objRequest.Method = "POST";
                objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
                objRequest.ContentType = "application/x-www-form-urlencoded";
                try
                {
                    myWriter = new StreamWriter(objRequest.GetRequestStream());
                    myWriter.Write(url);
                }
                catch (Exception e)
                {
                return;
                }
                finally
                {
                    myWriter.Close();
                }

                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    // Close and clean up the StreamReader
                    sr.Close();
                }        
        }

        private void btn_dogrula_Click(object sender, EventArgs e)
        {
            if (txt_gmailyaz.Text==code.ToString())
            {
                Setting st = new Setting();
                st.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hata!!","Program");
            }
        }
    }
}
