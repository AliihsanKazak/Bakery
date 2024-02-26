namespace Bakery
{
    partial class PaketServis
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
            this.pktsrvstablo = new System.Windows.Forms.DataGridView();
            this.btnSiparişler = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pktsrvstablo)).BeginInit();
            this.SuspendLayout();
            // 
            // pktsrvstablo
            // 
            this.pktsrvstablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pktsrvstablo.Location = new System.Drawing.Point(197, 26);
            this.pktsrvstablo.Name = "pktsrvstablo";
            this.pktsrvstablo.RowHeadersWidth = 51;
            this.pktsrvstablo.RowTemplate.Height = 24;
            this.pktsrvstablo.Size = new System.Drawing.Size(1136, 412);
            this.pktsrvstablo.TabIndex = 0;
            // 
            // btnSiparişler
            // 
            this.btnSiparişler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparişler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparişler.ForeColor = System.Drawing.Color.White;
            this.btnSiparişler.Location = new System.Drawing.Point(12, 57);
            this.btnSiparişler.Name = "btnSiparişler";
            this.btnSiparişler.Size = new System.Drawing.Size(179, 73);
            this.btnSiparişler.TabIndex = 2;
            this.btnSiparişler.Text = "Siparişleri Göster";
            this.btnSiparişler.UseVisualStyleBackColor = true;
            this.btnSiparişler.Click += new System.EventHandler(this.btnSiparişler_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(12, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(53, 33);
            this.btn_geri.TabIndex = 34;
            this.btn_geri.Text = "<----";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // PaketServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1345, 450);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btnSiparişler);
            this.Controls.Add(this.pktsrvstablo);
            this.Name = "PaketServis";
            this.Text = "PaketServis";
            ((System.ComponentModel.ISupportInitialize)(this.pktsrvstablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pktsrvstablo;
        private System.Windows.Forms.Button btnSiparişler;
        private System.Windows.Forms.Button btn_geri;
    }
}