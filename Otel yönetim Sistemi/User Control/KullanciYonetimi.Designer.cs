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
            this.user_info_datagrid = new System.Windows.Forms.DataGridView();
            this.Kullanci = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._telefon = new System.Windows.Forms.TextBox();
            this._surname = new System.Windows.Forms.TextBox();
            this._email = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.TextBox();
            this._id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.user_info_datagrid)).BeginInit();
            this.Kullanci.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_info_datagrid
            // 
            this.user_info_datagrid.AllowUserToAddRows = false;
            this.user_info_datagrid.AllowUserToDeleteRows = false;
            this.user_info_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_info_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._id,
            this.user_name,
            this.user_surname,
            this.user_email,
            this.user_telefon});
            this.user_info_datagrid.Location = new System.Drawing.Point(359, 51);
            this.user_info_datagrid.Name = "user_info_datagrid";
            this.user_info_datagrid.ReadOnly = true;
            this.user_info_datagrid.RowHeadersWidth = 51;
            this.user_info_datagrid.RowTemplate.Height = 24;
            this.user_info_datagrid.Size = new System.Drawing.Size(681, 70);
            this.user_info_datagrid.TabIndex = 24;
            this.user_info_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_info_datagrid_CellContentClick);
            // 
            // Kullanci
            // 
            this.Kullanci.Controls.Add(this.label3);
            this.Kullanci.Controls.Add(this.label2);
            this.Kullanci.Controls.Add(this.btn_delete);
            this.Kullanci.Controls.Add(this.btn_update);
            this.Kullanci.Controls.Add(this.label1);
            this.Kullanci.Controls.Add(this._telefon);
            this.Kullanci.Controls.Add(this._surname);
            this.Kullanci.Controls.Add(this._email);
            this.Kullanci.Controls.Add(this.lbl_username);
            this.Kullanci.Controls.Add(this._name);
            this.Kullanci.Location = new System.Drawing.Point(61, 39);
            this.Kullanci.Name = "Kullanci";
            this.Kullanci.Size = new System.Drawing.Size(280, 451);
            this.Kullanci.TabIndex = 23;
            this.Kullanci.TabStop = false;
            this.Kullanci.Text = "KULLANICI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(51, 348);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(174, 45);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(51, 288);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(174, 45);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // _telefon
            // 
            this._telefon.Location = new System.Drawing.Point(94, 221);
            this._telefon.Multiline = true;
            this._telefon.Name = "_telefon";
            this._telefon.Size = new System.Drawing.Size(150, 38);
            this._telefon.TabIndex = 2;
            // 
            // _surname
            // 
            this._surname.Location = new System.Drawing.Point(94, 99);
            this._surname.Multiline = true;
            this._surname.Name = "_surname";
            this._surname.Size = new System.Drawing.Size(150, 38);
            this._surname.TabIndex = 2;
            // 
            // _email
            // 
            this._email.Location = new System.Drawing.Point(94, 165);
            this._email.Multiline = true;
            this._email.Name = "_email";
            this._email.Size = new System.Drawing.Size(150, 37);
            this._email.TabIndex = 3;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_username.Location = new System.Drawing.Point(14, 66);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(44, 16);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Name";
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(94, 47);
            this._name.Multiline = true;
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(150, 35);
            this._name.TabIndex = 4;
            // 
            // _id
            // 
            this._id.HeaderText = "ID";
            this._id.MinimumWidth = 6;
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Width = 125;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "Name";
            this.user_name.MinimumWidth = 6;
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Width = 125;
            // 
            // user_surname
            // 
            this.user_surname.HeaderText = "Surname";
            this.user_surname.MinimumWidth = 6;
            this.user_surname.Name = "user_surname";
            this.user_surname.ReadOnly = true;
            this.user_surname.Width = 125;
            // 
            // user_email
            // 
            this.user_email.HeaderText = "Email";
            this.user_email.MinimumWidth = 6;
            this.user_email.Name = "user_email";
            this.user_email.ReadOnly = true;
            this.user_email.Width = 125;
            // 
            // user_telefon
            // 
            this.user_telefon.HeaderText = "Telefon";
            this.user_telefon.MinimumWidth = 6;
            this.user_telefon.Name = "user_telefon";
            this.user_telefon.ReadOnly = true;
            this.user_telefon.Width = 125;
            // 
            // KullanciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.user_info_datagrid);
            this.Controls.Add(this.Kullanci);
            this.Name = "KullanciYonetimi";
            this.Size = new System.Drawing.Size(1106, 528);
            ((System.ComponentModel.ISupportInitialize)(this.user_info_datagrid)).EndInit();
            this.Kullanci.ResumeLayout(false);
            this.Kullanci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView user_info_datagrid;
        private System.Windows.Forms.GroupBox Kullanci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _telefon;
        private System.Windows.Forms.TextBox _surname;
        private System.Windows.Forms.TextBox _email;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_telefon;
    }
}
