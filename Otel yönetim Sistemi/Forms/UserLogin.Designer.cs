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
            this.UserLog = new System.Windows.Forms.LinkLabel();
            this.admin = new System.Windows.Forms.RadioButton();
            this.reception = new System.Windows.Forms.RadioButton();
            this.user = new System.Windows.Forms.RadioButton();
            this._login = new System.Windows.Forms.Button();
            this.user_password = new System.Windows.Forms.TextBox();
            this._password = new System.Windows.Forms.Label();
            this.user_email = new System.Windows.Forms.TextBox();
            this._email = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLog
            // 
            this.UserLog.AutoSize = true;
            this.UserLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UserLog.LinkColor = System.Drawing.Color.MidnightBlue;
            this.UserLog.Location = new System.Drawing.Point(138, 413);
            this.UserLog.Name = "UserLog";
            this.UserLog.Size = new System.Drawing.Size(137, 25);
            this.UserLog.TabIndex = 4;
            this.UserLog.TabStop = true;
            this.UserLog.Text = "Hesap Oluştur";
            this.UserLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_register_LinkClicked);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.Black;
            this.admin.Location = new System.Drawing.Point(291, 279);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(77, 24);
            this.admin.TabIndex = 3;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // reception
            // 
            this.reception.AutoSize = true;
            this.reception.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reception.ForeColor = System.Drawing.Color.Black;
            this.reception.Location = new System.Drawing.Point(158, 279);
            this.reception.Name = "reception";
            this.reception.Size = new System.Drawing.Size(117, 24);
            this.reception.TabIndex = 3;
            this.reception.TabStop = true;
            this.reception.Text = "Resepsiyon";
            this.reception.UseVisualStyleBackColor = true;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Black;
            this.user.Location = new System.Drawing.Point(57, 279);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(86, 24);
            this.user.TabIndex = 3;
            this.user.TabStop = true;
            this.user.Text = "Müşteri";
            this.user.UseVisualStyleBackColor = true;
            // 
            // _login
            // 
            this._login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this._login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._login.ForeColor = System.Drawing.Color.White;
            this._login.Location = new System.Drawing.Point(115, 351);
            this._login.Name = "_login";
            this._login.Size = new System.Drawing.Size(187, 42);
            this._login.TabIndex = 2;
            this._login.Text = "Login";
            this._login.UseVisualStyleBackColor = false;
            this._login.Click += new System.EventHandler(this._login_Click);
            // 
            // user_password
            // 
            this.user_password.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_password.Location = new System.Drawing.Point(181, 208);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(187, 28);
            this.user_password.TabIndex = 1;
            // 
            // _password
            // 
            this._password.AutoSize = true;
            this._password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._password.ForeColor = System.Drawing.Color.Black;
            this._password.Location = new System.Drawing.Point(45, 208);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(98, 25);
            this._password.TabIndex = 0;
            this._password.Text = "Password";
            // 
            // user_email
            // 
            this.user_email.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_email.Location = new System.Drawing.Point(181, 156);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(187, 28);
            this.user_email.TabIndex = 1;
            // 
            // _email
            // 
            this._email.AutoSize = true;
            this._email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._email.ForeColor = System.Drawing.Color.Black;
            this._email.Location = new System.Drawing.Point(59, 156);
            this._email.Name = "_email";
            this._email.Size = new System.Drawing.Size(60, 25);
            this._email.TabIndex = 0;
            this._email.Text = "Email";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.DarkGray;
            this.login.Controls.Add(this.label1);
            this.login.Controls.Add(this.UserLog);
            this.login.Controls.Add(this.admin);
            this.login.Controls.Add(this.reception);
            this.login.Controls.Add(this.user);
            this.login.Controls.Add(this._login);
            this.login.Controls.Add(this.user_password);
            this.login.Controls.Add(this._password);
            this.login.Controls.Add(this.user_email);
            this.login.Controls.Add(this._email);
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(22, 25);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(428, 549);
            this.login.TabIndex = 0;
            this.login.TabStop = false;
            this.login.Text = "Login";
            this.login.Enter += new System.EventHandler(this.login_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Otel Yönetim Sistemi";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 606);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _login;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Label _password;
        private System.Windows.Forms.TextBox user_email;
        private System.Windows.Forms.Label _email;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.RadioButton reception;
        private System.Windows.Forms.RadioButton user;
        private System.Windows.Forms.LinkLabel UserLog;
        private System.Windows.Forms.GroupBox login;
        private System.Windows.Forms.Label label1;
    }
}