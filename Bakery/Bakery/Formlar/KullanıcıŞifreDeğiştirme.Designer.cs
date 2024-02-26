namespace Bakery.Formlar
{
    partial class KullanıcıŞifreDeğiştirme
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
            this.btnAra = new System.Windows.Forms.Button();
            this.Kullanici_tablo = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.Şifre = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kullanici_tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Silver;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(12, 98);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(212, 68);
            this.btnAra.TabIndex = 40;
            this.btnAra.Text = "Kullanıcı Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Kullanici_tablo
            // 
            this.Kullanici_tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kullanici_tablo.Location = new System.Drawing.Point(240, 12);
            this.Kullanici_tablo.Name = "Kullanici_tablo";
            this.Kullanici_tablo.RowHeadersWidth = 51;
            this.Kullanici_tablo.RowTemplate.Height = 24;
            this.Kullanici_tablo.Size = new System.Drawing.Size(577, 227);
            this.Kullanici_tablo.TabIndex = 39;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(92, 36);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "ID";
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.Silver;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(12, 172);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(212, 67);
            this.btnDegistir.TabIndex = 36;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(92, 69);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(132, 22);
            this.txtSifre.TabIndex = 42;
            // 
            // Şifre
            // 
            this.Şifre.AutoSize = true;
            this.Şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Şifre.ForeColor = System.Drawing.Color.White;
            this.Şifre.Location = new System.Drawing.Point(11, 71);
            this.Şifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(44, 20);
            this.Şifre.TabIndex = 41;
            this.Şifre.Text = "Şifre";
            // 
            // btn_geri
            // 
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(15, 2);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(53, 33);
            this.btn_geri.TabIndex = 43;
            this.btn_geri.Text = "<----";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // KullanıcıŞifreDeğiştirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(829, 251);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.Şifre);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.Kullanici_tablo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDegistir);
            this.Name = "KullanıcıŞifreDeğiştirme";
            this.Text = "KullanıcıŞifreDeğiştirme";
            ((System.ComponentModel.ISupportInitialize)(this.Kullanici_tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView Kullanici_tablo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label Şifre;
        private System.Windows.Forms.Button btn_geri;
    }
}