
namespace telefon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_KullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklbl_forgotten = new System.Windows.Forms.LinkLabel();
            this.linklbl_singup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_KullanıcıAdı
            // 
            this.txt_KullanıcıAdı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txt_KullanıcıAdı.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullanıcıAdı.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_KullanıcıAdı.Location = new System.Drawing.Point(122, 170);
            this.txt_KullanıcıAdı.Multiline = true;
            this.txt_KullanıcıAdı.Name = "txt_KullanıcıAdı";
            this.txt_KullanıcıAdı.Size = new System.Drawing.Size(224, 43);
            this.txt_KullanıcıAdı.TabIndex = 1;
            this.txt_KullanıcıAdı.Text = "Username";
            this.txt_KullanıcıAdı.Enter += new System.EventHandler(this.txt_KullanıcıAdı_Enter);
            this.txt_KullanıcıAdı.Leave += new System.EventHandler(this.txt_KullanıcıAdı_Leave);
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txt_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_sifre.Location = new System.Drawing.Point(122, 219);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(224, 43);
            this.txt_sifre.TabIndex = 2;
            this.txt_sifre.Text = "Password";
            this.txt_sifre.Enter += new System.EventHandler(this.txt_sifre_Enter);
            this.txt_sifre.Leave += new System.EventHandler(this.txt_sifre_Leave);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.Black;
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cikis.Location = new System.Drawing.Point(410, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(44, 36);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_Giris.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Giris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Giris.Location = new System.Drawing.Point(0, 328);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(455, 45);
            this.btn_Giris.TabIndex = 3;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(11, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(11, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şifre :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(10, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 137);
            this.panel1.TabIndex = 7;
            // 
            // linklbl_forgotten
            // 
            this.linklbl_forgotten.ActiveLinkColor = System.Drawing.Color.Goldenrod;
            this.linklbl_forgotten.AutoSize = true;
            this.linklbl_forgotten.LinkColor = System.Drawing.Color.White;
            this.linklbl_forgotten.Location = new System.Drawing.Point(374, 312);
            this.linklbl_forgotten.Name = "linklbl_forgotten";
            this.linklbl_forgotten.Size = new System.Drawing.Size(81, 13);
            this.linklbl_forgotten.TabIndex = 5;
            this.linklbl_forgotten.TabStop = true;
            this.linklbl_forgotten.Text = "Şifremi Unuttum";
            // 
            // linklbl_singup
            // 
            this.linklbl_singup.ActiveLinkColor = System.Drawing.Color.Goldenrod;
            this.linklbl_singup.AutoSize = true;
            this.linklbl_singup.LinkColor = System.Drawing.Color.White;
            this.linklbl_singup.Location = new System.Drawing.Point(183, 265);
            this.linklbl_singup.Name = "linklbl_singup";
            this.linklbl_singup.Size = new System.Drawing.Size(43, 13);
            this.linklbl_singup.TabIndex = 4;
            this.linklbl_singup.TabStop = true;
            this.linklbl_singup.Text = "Kayıt Ol";
            this.linklbl_singup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_singup_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(455, 373);
            this.Controls.Add(this.linklbl_singup);
            this.Controls.Add(this.linklbl_forgotten);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_KullanıcıAdı);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KullanıcıAdı;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklbl_forgotten;
        private System.Windows.Forms.LinkLabel linklbl_singup;
    }
}

