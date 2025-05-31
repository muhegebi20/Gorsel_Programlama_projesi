namespace Otel_yönetim_Sistemi.Forms
{
    partial class MainForm
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.RazervasyonAraBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Girisbtn = new System.Windows.Forms.Button();
            this.checkin = new System.Windows.Forms.DateTimePicker();
            this.checkout = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(508, 453);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(154, 31);
            this.comboBox3.TabIndex = 8;
            // 
            // RazervasyonAraBtn
            // 
            this.RazervasyonAraBtn.BackColor = System.Drawing.Color.BlueViolet;
            this.RazervasyonAraBtn.FlatAppearance.BorderSize = 2;
            this.RazervasyonAraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RazervasyonAraBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RazervasyonAraBtn.ForeColor = System.Drawing.Color.White;
            this.RazervasyonAraBtn.Location = new System.Drawing.Point(698, 435);
            this.RazervasyonAraBtn.Name = "RazervasyonAraBtn";
            this.RazervasyonAraBtn.Size = new System.Drawing.Size(134, 49);
            this.RazervasyonAraBtn.TabIndex = 9;
            this.RazervasyonAraBtn.Text = "Ara";
            this.RazervasyonAraBtn.UseVisualStyleBackColor = false;
            this.RazervasyonAraBtn.Click += new System.EventHandler(this.RazervasyonAraBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Giriş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(503, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kişi Sayısı";
            // 
            // Girisbtn
            // 
            this.Girisbtn.BackColor = System.Drawing.Color.DarkViolet;
            this.Girisbtn.FlatAppearance.BorderSize = 2;
            this.Girisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Girisbtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Girisbtn.ForeColor = System.Drawing.Color.White;
            this.Girisbtn.Location = new System.Drawing.Point(819, 27);
            this.Girisbtn.Name = "Girisbtn";
            this.Girisbtn.Size = new System.Drawing.Size(127, 51);
            this.Girisbtn.TabIndex = 14;
            this.Girisbtn.Text = "Giriş Yap";
            this.Girisbtn.UseVisualStyleBackColor = false;
            this.Girisbtn.Click += new System.EventHandler(this.Girisbtn_Click);
            // 
            // checkin
            // 
            this.checkin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkin.Location = new System.Drawing.Point(144, 462);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(130, 22);
            this.checkin.TabIndex = 15;
            // 
            // checkout
            // 
            this.checkout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkout.Location = new System.Drawing.Point(323, 462);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(129, 22);
            this.checkout.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Otel_yönetim_Sistemi.Properties.Resources.Best_Hotel_Website_Designs_yyyy;
            this.ClientSize = new System.Drawing.Size(973, 614);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.Girisbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RazervasyonAraBtn);
            this.Controls.Add(this.comboBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button RazervasyonAraBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Girisbtn;
        private System.Windows.Forms.DateTimePicker checkin;
        private System.Windows.Forms.DateTimePicker checkout;
    }
}