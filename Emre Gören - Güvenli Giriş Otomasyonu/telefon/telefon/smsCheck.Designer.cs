﻿
namespace telefon
{
    partial class smsCheck
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
            this.btn_dogrula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gmailyaz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_dogrula
            // 
            this.btn_dogrula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btn_dogrula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dogrula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dogrula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dogrula.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_dogrula.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dogrula.Location = new System.Drawing.Point(0, 192);
            this.btn_dogrula.Name = "btn_dogrula";
            this.btn_dogrula.Size = new System.Drawing.Size(472, 45);
            this.btn_dogrula.TabIndex = 13;
            this.btn_dogrula.Text = "Gönder";
            this.btn_dogrula.UseVisualStyleBackColor = false;
            this.btn_dogrula.Click += new System.EventHandler(this.btn_dogrula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(89, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "SMS Doğrulama kodunuz";
            // 
            // txt_gmailyaz
            // 
            this.txt_gmailyaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txt_gmailyaz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gmailyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_gmailyaz.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_gmailyaz.Location = new System.Drawing.Point(122, 82);
            this.txt_gmailyaz.Multiline = true;
            this.txt_gmailyaz.Name = "txt_gmailyaz";
            this.txt_gmailyaz.Size = new System.Drawing.Size(224, 43);
            this.txt_gmailyaz.TabIndex = 11;
            this.txt_gmailyaz.Text = "Doğrulama Kodunuz";
            // 
            // smsCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(472, 237);
            this.Controls.Add(this.btn_dogrula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_gmailyaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "smsCheck";
            this.Text = "smsCheck";
            this.Load += new System.EventHandler(this.smsCheck_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.smsCheck_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.smsCheck_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.smsCheck_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dogrula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gmailyaz;
    }
}