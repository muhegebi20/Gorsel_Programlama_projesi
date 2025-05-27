namespace Otel_yönetim_Sistemi.Forms
{
    partial class UserLogin
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
            this.login = new System.Windows.Forms.GroupBox();
            this._email = new System.Windows.Forms.Label();
            this.user_email = new System.Windows.Forms.TextBox();
            this._password = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this._login = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.RadioButton();
            this.reception = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.lnk_register = new System.Windows.Forms.LinkLabel();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login.Controls.Add(this.lnk_register);
            this.login.Controls.Add(this.admin);
            this.login.Controls.Add(this.reception);
            this.login.Controls.Add(this.user);
            this.login.Controls.Add(this._login);
            this.login.Controls.Add(this.user_password);
            this.login.Controls.Add(this._password);
            this.login.Controls.Add(this.user_email);
            this.login.Controls.Add(this._email);
            this.login.Location = new System.Drawing.Point(22, 25);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(387, 413);
            this.login.TabIndex = 0;
            this.login.TabStop = false;
            this.login.Text = "Login";
            // 
            // _email
            // 
            this._email.AutoSize = true;
            this._email.Location = new System.Drawing.Point(50, 101);
            this._email.Name = "_email";
            this._email.Size = new System.Drawing.Size(41, 16);
            this._email.TabIndex = 0;
            this._email.Text = "Email";
            // 
            // user_email
            // 
            this.user_email.Location = new System.Drawing.Point(112, 82);
            this.user_email.Multiline = true;
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(187, 35);
            this.user_email.TabIndex = 1;
            // 
            // _password
            // 
            this._password.AutoSize = true;
            this._password.Location = new System.Drawing.Point(24, 137);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(67, 16);
            this._password.TabIndex = 0;
            this._password.Text = "Password";
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(112, 134);
            this.user_password.Multiline = true;
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(187, 35);
            this.user_password.TabIndex = 1;
            // 
            // _login
            // 
            this._login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this._login.ForeColor = System.Drawing.Color.White;
            this._login.Location = new System.Drawing.Point(112, 257);
            this._login.Name = "_login";
            this._login.Size = new System.Drawing.Size(187, 42);
            this._login.TabIndex = 2;
            this._login.Text = "Login";
            this._login.UseVisualStyleBackColor = false;
            this._login.Click += new System.EventHandler(this._login_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(53, 205);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(71, 20);
            this.user.TabIndex = 3;
            this.user.TabStop = true;
            this.user.Text = "Müşteri";
            this.user.UseVisualStyleBackColor = true;
            // 
            // reception
            // 
            this.reception.AutoSize = true;
            this.reception.Location = new System.Drawing.Point(153, 205);
            this.reception.Name = "reception";
            this.reception.Size = new System.Drawing.Size(101, 20);
            this.reception.TabIndex = 3;
            this.reception.TabStop = true;
            this.reception.Text = "Resepsiyon";
            this.reception.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(259, 205);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(66, 20);
            this.admin.TabIndex = 3;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // lnk_register
            // 
            this.lnk_register.AutoSize = true;
            this.lnk_register.Location = new System.Drawing.Point(137, 328);
            this.lnk_register.Name = "lnk_register";
            this.lnk_register.Size = new System.Drawing.Size(92, 16);
            this.lnk_register.TabIndex = 4;
            this.lnk_register.TabStop = true;
            this.lnk_register.Text = "Hesap Oluştur";
            this.lnk_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_register_LinkClicked);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login;
        private System.Windows.Forms.Button _login;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label _password;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.Label _email;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.RadioButton reception;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.LinkLabel lnk_register;
    }
}