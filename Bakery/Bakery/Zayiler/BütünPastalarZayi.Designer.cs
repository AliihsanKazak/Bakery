namespace Bakery.Zayiler
{
    partial class BütünPastalarZayi
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
            this.dtpgün = new System.Windows.Forms.DateTimePicker();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbpasta = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.zayiler_table = new System.Windows.Forms.DataGridView();
            this.btnbpastazayilerigöster = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zayiler_table)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpgün
            // 
            this.dtpgün.Location = new System.Drawing.Point(12, 145);
            this.dtpgün.Name = "dtpgün";
            this.dtpgün.Size = new System.Drawing.Size(212, 22);
            this.dtpgün.TabIndex = 67;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(91, 204);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(132, 22);
            this.txtFiyat.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Fiyat";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(91, 174);
            this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(132, 22);
            this.txtAdet.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Adet";
            // 
            // cmbbpasta
            // 
            this.cmbbpasta.FormattingEnabled = true;
            this.cmbbpasta.Items.AddRange(new object[] {
            "Çikomastik",
            "Bombastik"});
            this.cmbbpasta.Location = new System.Drawing.Point(12, 115);
            this.cmbbpasta.Name = "cmbbpasta";
            this.cmbbpasta.Size = new System.Drawing.Size(212, 24);
            this.cmbbpasta.TabIndex = 58;
            this.cmbbpasta.Text = "Bütün Pastalar";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(11, 233);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(212, 68);
            this.btnEkle.TabIndex = 57;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // zayiler_table
            // 
            this.zayiler_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zayiler_table.Location = new System.Drawing.Point(230, 10);
            this.zayiler_table.Name = "zayiler_table";
            this.zayiler_table.RowHeadersWidth = 51;
            this.zayiler_table.RowTemplate.Height = 24;
            this.zayiler_table.Size = new System.Drawing.Size(690, 291);
            this.zayiler_table.TabIndex = 56;
            // 
            // btnbpastazayilerigöster
            // 
            this.btnbpastazayilerigöster.BackColor = System.Drawing.Color.Silver;
            this.btnbpastazayilerigöster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbpastazayilerigöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbpastazayilerigöster.Location = new System.Drawing.Point(11, 44);
            this.btnbpastazayilerigöster.Name = "btnbpastazayilerigöster";
            this.btnbpastazayilerigöster.Size = new System.Drawing.Size(213, 35);
            this.btnbpastazayilerigöster.TabIndex = 55;
            this.btnbpastazayilerigöster.Text = "Bütün Pasta Zayileri Göster";
            this.btnbpastazayilerigöster.UseVisualStyleBackColor = false;
            this.btnbpastazayilerigöster.Click += new System.EventHandler(this.btnbpastazayilerigöster_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(4, 5);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(53, 33);
            this.btn_geri.TabIndex = 68;
            this.btn_geri.Text = "<----";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // BütünPastalarZayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(932, 312);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.dtpgün);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbpasta);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.zayiler_table);
            this.Controls.Add(this.btnbpastazayilerigöster);
            this.Name = "BütünPastalarZayi";
            this.Text = "BütünPastalarZayi";
            ((System.ComponentModel.ISupportInitialize)(this.zayiler_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpgün;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbpasta;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView zayiler_table;
        private System.Windows.Forms.Button btnbpastazayilerigöster;
        private System.Windows.Forms.Button btn_geri;
    }
}