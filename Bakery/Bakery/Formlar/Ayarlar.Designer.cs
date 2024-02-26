namespace Bakery
{
    partial class Ayarlar
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
            this.btnKullaniciEkleme = new System.Windows.Forms.Button();
            this.btnKullaniciSilme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKullaniciSifreDegistirme = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciEkleme
            // 
            this.btnKullaniciEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciEkleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciEkleme.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciEkleme.Location = new System.Drawing.Point(12, 69);
            this.btnKullaniciEkleme.Name = "btnKullaniciEkleme";
            this.btnKullaniciEkleme.Size = new System.Drawing.Size(302, 59);
            this.btnKullaniciEkleme.TabIndex = 24;
            this.btnKullaniciEkleme.Text = "Kullanıcı Ekleme";
            this.btnKullaniciEkleme.UseVisualStyleBackColor = true;
            this.btnKullaniciEkleme.Click += new System.EventHandler(this.btnKullaniciEkleme_Click);
            // 
            // btnKullaniciSilme
            // 
            this.btnKullaniciSilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciSilme.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciSilme.Location = new System.Drawing.Point(12, 134);
            this.btnKullaniciSilme.Name = "btnKullaniciSilme";
            this.btnKullaniciSilme.Size = new System.Drawing.Size(302, 59);
            this.btnKullaniciSilme.TabIndex = 25;
            this.btnKullaniciSilme.Text = "Kullanıcı Silme";
            this.btnKullaniciSilme.UseVisualStyleBackColor = true;
            this.btnKullaniciSilme.Click += new System.EventHandler(this.btnKullaniciSilme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ayarlar";
            // 
            // btnKullaniciSifreDegistirme
            // 
            this.btnKullaniciSifreDegistirme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciSifreDegistirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciSifreDegistirme.ForeColor = System.Drawing.Color.White;
            this.btnKullaniciSifreDegistirme.Location = new System.Drawing.Point(12, 199);
            this.btnKullaniciSifreDegistirme.Name = "btnKullaniciSifreDegistirme";
            this.btnKullaniciSifreDegistirme.Size = new System.Drawing.Size(302, 59);
            this.btnKullaniciSifreDegistirme.TabIndex = 27;
            this.btnKullaniciSifreDegistirme.Text = "Kullanıcı Şifre Değiştirme\r\n";
            this.btnKullaniciSifreDegistirme.UseVisualStyleBackColor = true;
            this.btnKullaniciSifreDegistirme.Click += new System.EventHandler(this.btnKullaniciSifreDegistirme_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(8, 6);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(53, 33);
            this.btn_geri.TabIndex = 32;
            this.btn_geri.Text = "<----";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(326, 275);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btnKullaniciSifreDegistirme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKullaniciSilme);
            this.Controls.Add(this.btnKullaniciEkleme);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkleme;
        private System.Windows.Forms.Button btnKullaniciSilme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKullaniciSifreDegistirme;
        private System.Windows.Forms.Button btn_geri;
    }
}