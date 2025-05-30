namespace Otel_yönetim_Sistemi.User_Control
{
    partial class KullanciYonetimi
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
            this.tabControlFaturalar = new System.Windows.Forms.TabControl();
            this.tabPageFaturaEkle = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlFaturalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFaturalar
            // 
            this.tabControlFaturalar.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlFaturalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlFaturalar.Controls.Add(this.tabPageFaturaEkle);
            this.tabControlFaturalar.Controls.Add(this.tabPage2);
            this.tabControlFaturalar.Location = new System.Drawing.Point(45, 44);
            this.tabControlFaturalar.Name = "tabControlFaturalar";
            this.tabControlFaturalar.SelectedIndex = 0;
            this.tabControlFaturalar.Size = new System.Drawing.Size(1016, 440);
            this.tabControlFaturalar.TabIndex = 1;
            // 
            // tabPageFaturaEkle
            // 
            this.tabPageFaturaEkle.Location = new System.Drawing.Point(4, 4);
            this.tabPageFaturaEkle.Name = "tabPageFaturaEkle";
            this.tabPageFaturaEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFaturaEkle.Size = new System.Drawing.Size(1008, 411);
            this.tabPageFaturaEkle.TabIndex = 0;
            this.tabPageFaturaEkle.Text = "Kullanıcı Ekle";
            this.tabPageFaturaEkle.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Faturalar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // KullanciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlFaturalar);
            this.Name = "KullanciYonetimi";
            this.Size = new System.Drawing.Size(1106, 528);
            this.tabControlFaturalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFaturalar;
        private System.Windows.Forms.TabPage tabPageFaturaEkle;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
