namespace Otel_yönetim_Sistemi.Forms
{
    partial class RezervasyonAra
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
            this.Geribtn = new System.Windows.Forms.Button();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaNU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFaturalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaturalar)).BeginInit();
            this.SuspendLayout();
            // 
            // Geribtn
            // 
            this.Geribtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Geribtn.FlatAppearance.BorderSize = 0;
            this.Geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geribtn.ForeColor = System.Drawing.Color.White;
            this.Geribtn.Location = new System.Drawing.Point(114, 367);
            this.Geribtn.Name = "Geribtn";
            this.Geribtn.Size = new System.Drawing.Size(126, 50);
            this.Geribtn.TabIndex = 10;
            this.Geribtn.Text = "Geri";
            this.Geribtn.UseVisualStyleBackColor = false;
            this.Geribtn.Click += new System.EventHandler(this.Geribtn_Click);
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 6;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            // 
            // OdaNU
            // 
            this.OdaNU.HeaderText = "Oda Numara";
            this.OdaNU.MinimumWidth = 6;
            this.OdaNU.Name = "OdaNU";
            this.OdaNU.ReadOnly = true;
            // 
            // dataGridViewFaturalar
            // 
            this.dataGridViewFaturalar.AllowUserToAddRows = false;
            this.dataGridViewFaturalar.AllowUserToDeleteRows = false;
            this.dataGridViewFaturalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFaturalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaturalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdaNU,
            this.Fiyat});
            this.dataGridViewFaturalar.Location = new System.Drawing.Point(22, 12);
            this.dataGridViewFaturalar.Name = "dataGridViewFaturalar";
            this.dataGridViewFaturalar.ReadOnly = true;
            this.dataGridViewFaturalar.RowHeadersWidth = 51;
            this.dataGridViewFaturalar.Size = new System.Drawing.Size(337, 333);
            this.dataGridViewFaturalar.TabIndex = 9;
            this.dataGridViewFaturalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFaturalar_CellContentClick);
            // 
            // RezervasyonAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 429);
            this.Controls.Add(this.Geribtn);
            this.Controls.Add(this.dataGridViewFaturalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RezervasyonAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaturalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Geribtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaNU;
        private System.Windows.Forms.DataGridView dataGridViewFaturalar;
    }
}