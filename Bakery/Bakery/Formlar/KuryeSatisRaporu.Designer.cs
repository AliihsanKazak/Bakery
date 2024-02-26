namespace Bakery.Formlar
{
    partial class KuryeSatisRaporu
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
            this.btn_geri = new System.Windows.Forms.Button();
            this.kuryesr_table = new System.Windows.Forms.DataGridView();
            this.btnKuryeSR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kuryesr_table)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(12, 12);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(53, 33);
            this.btn_geri.TabIndex = 32;
            this.btn_geri.Text = "<----";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // kuryesr_table
            // 
            this.kuryesr_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kuryesr_table.Location = new System.Drawing.Point(183, 12);
            this.kuryesr_table.Name = "kuryesr_table";
            this.kuryesr_table.RowHeadersWidth = 51;
            this.kuryesr_table.RowTemplate.Height = 24;
            this.kuryesr_table.Size = new System.Drawing.Size(737, 429);
            this.kuryesr_table.TabIndex = 34;
            // 
            // btnKuryeSR
            // 
            this.btnKuryeSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKuryeSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKuryeSR.ForeColor = System.Drawing.Color.White;
            this.btnKuryeSR.Location = new System.Drawing.Point(12, 51);
            this.btnKuryeSR.Name = "btnKuryeSR";
            this.btnKuryeSR.Size = new System.Drawing.Size(165, 59);
            this.btnKuryeSR.TabIndex = 35;
            this.btnKuryeSR.Text = "Kurye Satış Raporu";
            this.btnKuryeSR.UseVisualStyleBackColor = true;
            this.btnKuryeSR.Click += new System.EventHandler(this.btnKuryeSR_Click);
            // 
            // KuryeSatisRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.btnKuryeSR);
            this.Controls.Add(this.kuryesr_table);
            this.Controls.Add(this.btn_geri);
            this.Name = "KuryeSatisRaporu";
            this.Text = "KuryeSatisRaporu";
            ((System.ComponentModel.ISupportInitialize)(this.kuryesr_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.DataGridView kuryesr_table;
        private System.Windows.Forms.Button btnKuryeSR;
    }
}