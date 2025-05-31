namespace Otel_yönetim_Sistemi.User_Control
{
    partial class UserControlFaturaHesapla
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewFaturalar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKullancıAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageFaturaEkle = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelTutar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlFaturalar = new System.Windows.Forms.TabControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaturalar)).BeginInit();
            this.tabPageFaturaEkle.SuspendLayout();
            this.tabControlFaturalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewFaturalar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxKullancıAra);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Faturalar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFaturalar
            // 
            this.dataGridViewFaturalar.AllowUserToAddRows = false;
            this.dataGridViewFaturalar.AllowUserToDeleteRows = false;
            this.dataGridViewFaturalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewFaturalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFaturalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaturalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewFaturalar.Location = new System.Drawing.Point(49, 144);
            this.dataGridViewFaturalar.Name = "dataGridViewFaturalar";
            this.dataGridViewFaturalar.ReadOnly = true;
            this.dataGridViewFaturalar.RowHeadersWidth = 51;
            this.dataGridViewFaturalar.Size = new System.Drawing.Size(905, 234);
            this.dataGridViewFaturalar.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Kullancı_adı";
            this.Column1.HeaderText = "Kullancı Adı";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gün_Sayısı";
            this.Column2.HeaderText = "Gün Sayısı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Oda_Numara";
            this.Column3.HeaderText = "Oda Numara";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kullancı Ara";
            // 
            // textBoxKullancıAra
            // 
            this.textBoxKullancıAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKullancıAra.Location = new System.Drawing.Point(262, 89);
            this.textBoxKullancıAra.Name = "textBoxKullancıAra";
            this.textBoxKullancıAra.Size = new System.Drawing.Size(185, 32);
            this.textBoxKullancıAra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullancı Adı";
            // 
            // tabPageFaturaEkle
            // 
            this.tabPageFaturaEkle.Controls.Add(this.button1);
            this.tabPageFaturaEkle.Controls.Add(this.textBox3);
            this.tabPageFaturaEkle.Controls.Add(this.labelTutar);
            this.tabPageFaturaEkle.Controls.Add(this.comboBox1);
            this.tabPageFaturaEkle.Controls.Add(this.textBox2);
            this.tabPageFaturaEkle.Controls.Add(this.textBox1);
            this.tabPageFaturaEkle.Controls.Add(this.label3);
            this.tabPageFaturaEkle.Controls.Add(this.label2);
            this.tabPageFaturaEkle.Controls.Add(this.label1);
            this.tabPageFaturaEkle.Location = new System.Drawing.Point(4, 4);
            this.tabPageFaturaEkle.Name = "tabPageFaturaEkle";
            this.tabPageFaturaEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFaturaEkle.Size = new System.Drawing.Size(1008, 406);
            this.tabPageFaturaEkle.TabIndex = 0;
            this.tabPageFaturaEkle.Text = "Fatura Ekle";
            this.tabPageFaturaEkle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(425, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(441, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(185, 32);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0,00";
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTutar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTutar.Location = new System.Drawing.Point(358, 217);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(74, 28);
            this.labelTutar.TabIndex = 6;
            this.labelTutar.Text = "Tutar:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(726, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 31);
            this.comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(441, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 32);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 32);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oda Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gün Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullancı Adı";
            // 
            // tabControlFaturalar
            // 
            this.tabControlFaturalar.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlFaturalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlFaturalar.Controls.Add(this.tabPageFaturaEkle);
            this.tabControlFaturalar.Controls.Add(this.tabPage2);
            this.tabControlFaturalar.Location = new System.Drawing.Point(48, 37);
            this.tabControlFaturalar.Name = "tabControlFaturalar";
            this.tabControlFaturalar.SelectedIndex = 0;
            this.tabControlFaturalar.Size = new System.Drawing.Size(1016, 440);
            this.tabControlFaturalar.TabIndex = 0;
            // 
            // UserControlFaturaHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlFaturalar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlFaturaHesapla";
            this.Size = new System.Drawing.Size(1106, 528);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaturalar)).EndInit();
            this.tabPageFaturaEkle.ResumeLayout(false);
            this.tabPageFaturaEkle.PerformLayout();
            this.tabControlFaturalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageFaturaEkle;
        private System.Windows.Forms.TabControl tabControlFaturalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxKullancıAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewFaturalar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
