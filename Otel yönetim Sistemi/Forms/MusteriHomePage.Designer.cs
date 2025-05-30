namespace Otel_yönetim_Sistemi.Forms
{
    partial class MusteriHomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriHomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMove = new System.Windows.Forms.Panel();
            this.buttonBilgilerimiGuncelle = new System.Windows.Forms.Button();
            this.buttonFaturalarimiGoruntule = new System.Windows.Forms.Button();
            this.buttonRezervasyonlarimiGoruntule = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelExit = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDataTime = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rezervasyonGoruntu1 = new Otel_yönetim_Sistemi.User_Control.RezervasyonGoruntu();
            this.faturaGoruntu1 = new Otel_yönetim_Sistemi.User_Control.FaturaGoruntu();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kullanciYonetimi1 = new Otel_yönetim_Sistemi.User_Control.KullanciYonetimi();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panelMove);
            this.panel1.Controls.Add(this.buttonBilgilerimiGuncelle);
            this.panel1.Controls.Add(this.buttonFaturalarimiGoruntule);
            this.panel1.Controls.Add(this.buttonRezervasyonlarimiGoruntule);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 670);
            this.panel1.TabIndex = 1;
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.White;
            this.panelMove.Location = new System.Drawing.Point(12, 211);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(11, 57);
            this.panelMove.TabIndex = 0;
            this.panelMove.Visible = false;
            // 
            // buttonBilgilerimiGuncelle
            // 
            this.buttonBilgilerimiGuncelle.FlatAppearance.BorderSize = 0;
            this.buttonBilgilerimiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBilgilerimiGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBilgilerimiGuncelle.ForeColor = System.Drawing.Color.White;
            this.buttonBilgilerimiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBilgilerimiGuncelle.Location = new System.Drawing.Point(28, 366);
            this.buttonBilgilerimiGuncelle.Name = "buttonBilgilerimiGuncelle";
            this.buttonBilgilerimiGuncelle.Size = new System.Drawing.Size(207, 57);
            this.buttonBilgilerimiGuncelle.TabIndex = 3;
            this.buttonBilgilerimiGuncelle.Text = "Bilgilerimi Güncelle";
            this.buttonBilgilerimiGuncelle.UseVisualStyleBackColor = true;
            this.buttonBilgilerimiGuncelle.Click += new System.EventHandler(this.buttonBilgilerimiGuncelle_Click);
            // 
            // buttonFaturalarimiGoruntule
            // 
            this.buttonFaturalarimiGoruntule.FlatAppearance.BorderSize = 0;
            this.buttonFaturalarimiGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaturalarimiGoruntule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFaturalarimiGoruntule.ForeColor = System.Drawing.Color.White;
            this.buttonFaturalarimiGoruntule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFaturalarimiGoruntule.Location = new System.Drawing.Point(28, 286);
            this.buttonFaturalarimiGoruntule.Name = "buttonFaturalarimiGoruntule";
            this.buttonFaturalarimiGoruntule.Size = new System.Drawing.Size(207, 57);
            this.buttonFaturalarimiGoruntule.TabIndex = 2;
            this.buttonFaturalarimiGoruntule.Text = "Faturalarımı Görüntüle";
            this.buttonFaturalarimiGoruntule.UseVisualStyleBackColor = true;
            this.buttonFaturalarimiGoruntule.Click += new System.EventHandler(this.buttonFaturalarimiGoruntule_Click);
            // 
            // buttonRezervasyonlarimiGoruntule
            // 
            this.buttonRezervasyonlarimiGoruntule.FlatAppearance.BorderSize = 0;
            this.buttonRezervasyonlarimiGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRezervasyonlarimiGoruntule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRezervasyonlarimiGoruntule.ForeColor = System.Drawing.Color.White;
            this.buttonRezervasyonlarimiGoruntule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRezervasyonlarimiGoruntule.Location = new System.Drawing.Point(28, 211);
            this.buttonRezervasyonlarimiGoruntule.Name = "buttonRezervasyonlarimiGoruntule";
            this.buttonRezervasyonlarimiGoruntule.Size = new System.Drawing.Size(207, 57);
            this.buttonRezervasyonlarimiGoruntule.TabIndex = 1;
            this.buttonRezervasyonlarimiGoruntule.Text = "Rezervasyonlarımı Görüntüle";
            this.buttonRezervasyonlarimiGoruntule.UseVisualStyleBackColor = true;
            this.buttonRezervasyonlarimiGoruntule.Click += new System.EventHandler(this.buttonRezervasyonlarımıGoruntule_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 192);
            this.panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sistemi";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Otel Yönetim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Otel_yönetim_Sistemi.Properties.Resources.home_icon_silhouette;
            this.pictureBox1.Location = new System.Drawing.Point(71, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.labelUsername);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(260, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1029, 192);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hoş Geldin :";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(137, 132);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(21, 23);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.linkLabelExit);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelDataTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 93);
            this.panel2.TabIndex = 0;
            // 
            // linkLabelExit
            // 
            this.linkLabelExit.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelExit.AutoSize = true;
            this.linkLabelExit.DisabledLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelExit.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelExit.Location = new System.Drawing.Point(897, 57);
            this.linkLabelExit.Name = "linkLabelExit";
            this.linkLabelExit.Size = new System.Drawing.Size(101, 23);
            this.linkLabelExit.TabIndex = 0;
            this.linkLabelExit.TabStop = true;
            this.linkLabelExit.Text = "Çıkış Yap";
            this.linkLabelExit.VisitedLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExit_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Otel_yönetim_Sistemi.Properties.Resources.office_man;
            this.pictureBox2.Location = new System.Drawing.Point(846, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelDataTime
            // 
            this.labelDataTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDataTime.AutoSize = true;
            this.labelDataTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelDataTime.Location = new System.Drawing.Point(22, 59);
            this.labelDataTime.Name = "labelDataTime";
            this.labelDataTime.Size = new System.Drawing.Size(21, 23);
            this.labelDataTime.TabIndex = 0;
            this.labelDataTime.Text = "?";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.kullanciYonetimi1);
            this.panel5.Controls.Add(this.rezervasyonGoruntu1);
            this.panel5.Controls.Add(this.faturaGoruntu1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(260, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1029, 478);
            this.panel5.TabIndex = 3;
            // 
            // rezervasyonGoruntu1
            // 
            this.rezervasyonGoruntu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rezervasyonGoruntu1.Location = new System.Drawing.Point(0, 0);
            this.rezervasyonGoruntu1.Margin = new System.Windows.Forms.Padding(4);
            this.rezervasyonGoruntu1.Name = "rezervasyonGoruntu1";
            this.rezervasyonGoruntu1.Size = new System.Drawing.Size(1029, 478);
            this.rezervasyonGoruntu1.TabIndex = 2;
            this.rezervasyonGoruntu1.Visible = false;
            // 
            // faturaGoruntu1
            // 
            this.faturaGoruntu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faturaGoruntu1.Location = new System.Drawing.Point(0, 0);
            this.faturaGoruntu1.Margin = new System.Windows.Forms.Padding(4);
            this.faturaGoruntu1.Name = "faturaGoruntu1";
            this.faturaGoruntu1.Size = new System.Drawing.Size(1029, 478);
            this.faturaGoruntu1.TabIndex = 1;
            this.faturaGoruntu1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kullanciYonetimi1
            // 
            this.kullanciYonetimi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kullanciYonetimi1.Location = new System.Drawing.Point(0, 0);
            this.kullanciYonetimi1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullanciYonetimi1.Name = "kullanciYonetimi1";
            this.kullanciYonetimi1.Size = new System.Drawing.Size(1029, 478);
            this.kullanciYonetimi1.TabIndex = 3;
            this.kullanciYonetimi1.Visible = false;
            // 
            // MusteriHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 670);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MüşteriHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.Button buttonBilgilerimiGuncelle;
        private System.Windows.Forms.Button buttonFaturalarimiGoruntule;
        private System.Windows.Forms.Button buttonRezervasyonlarimiGoruntule;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelDataTime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private User_Control.FaturaGoruntu faturaGoruntu1;
        private User_Control.RezervasyonGoruntu rezervasyonGoruntu1;
        private User_Control.KullanciYonetimi kullanciYonetimi1;
    }
}