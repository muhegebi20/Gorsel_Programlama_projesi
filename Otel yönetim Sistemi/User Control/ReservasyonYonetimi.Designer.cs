namespace Otel_yönetim_Sistemi.User_Control
{
    partial class ReservasyonYonetimi
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
            this.add_room = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_room_no = new System.Windows.Forms.TextBox();
            this.combo_room_type = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.RoomNu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlFaturalar.SuspendLayout();
            this.tabPageFaturaEkle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlFaturalar
            // 
            this.tabControlFaturalar.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlFaturalar.Controls.Add(this.tabPageFaturaEkle);
            this.tabControlFaturalar.Controls.Add(this.tabPage2);
            this.tabControlFaturalar.Location = new System.Drawing.Point(45, 44);
            this.tabControlFaturalar.Name = "tabControlFaturalar";
            this.tabControlFaturalar.SelectedIndex = 0;
            this.tabControlFaturalar.Size = new System.Drawing.Size(1016, 440);
            this.tabControlFaturalar.TabIndex = 2;
            // 
            // tabPageFaturaEkle
            // 
            this.tabPageFaturaEkle.Controls.Add(this.dateTimePicker2);
            this.tabPageFaturaEkle.Controls.Add(this.dateTimePicker1);
            this.tabPageFaturaEkle.Controls.Add(this.label4);
            this.tabPageFaturaEkle.Controls.Add(this.label3);
            this.tabPageFaturaEkle.Controls.Add(this.label2);
            this.tabPageFaturaEkle.Controls.Add(this.textBox3);
            this.tabPageFaturaEkle.Controls.Add(this.add_room);
            this.tabPageFaturaEkle.Controls.Add(this.label5);
            this.tabPageFaturaEkle.Controls.Add(this.label1);
            this.tabPageFaturaEkle.Controls.Add(this.box_room_no);
            this.tabPageFaturaEkle.Controls.Add(this.combo_room_type);
            this.tabPageFaturaEkle.Location = new System.Drawing.Point(4, 4);
            this.tabPageFaturaEkle.Name = "tabPageFaturaEkle";
            this.tabPageFaturaEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFaturaEkle.Size = new System.Drawing.Size(1008, 411);
            this.tabPageFaturaEkle.TabIndex = 0;
            this.tabPageFaturaEkle.Text = "Reservasyon Ekle";
            this.tabPageFaturaEkle.UseVisualStyleBackColor = true;
            // 
            // add_room
            // 
            this.add_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.add_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_room.ForeColor = System.Drawing.Color.White;
            this.add_room.Location = new System.Drawing.Point(375, 323);
            this.add_room.Name = "add_room";
            this.add_room.Size = new System.Drawing.Size(278, 51);
            this.add_room.TabIndex = 6;
            this.add_room.Text = "Add Rezervasyon";
            this.add_room.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Room No";
            // 
            // box_room_no
            // 
            this.box_room_no.Location = new System.Drawing.Point(263, 88);
            this.box_room_no.Multiline = true;
            this.box_room_no.Name = "box_room_no";
            this.box_room_no.Size = new System.Drawing.Size(211, 37);
            this.box_room_no.TabIndex = 0;
            // 
            // combo_room_type
            // 
            this.combo_room_type.FormattingEnabled = true;
            this.combo_room_type.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Suite"});
            this.combo_room_type.Location = new System.Drawing.Point(636, 101);
            this.combo_room_type.Name = "combo_room_type";
            this.combo_room_type.Size = new System.Drawing.Size(168, 24);
            this.combo_room_type.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservasyon Güncelle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNu,
            this.RoomType,
            this.Username,
            this.In,
            this.Out});
            this.dataGridView1.Location = new System.Drawing.Point(43, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(931, 258);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Username";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(263, 181);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 37);
            this.textBox3.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(581, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Out";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(636, 279);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 37);
            this.textBox1.TabIndex = 35;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(800, 53);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(174, 45);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // RoomNu
            // 
            this.RoomNu.HeaderText = "Room Nu";
            this.RoomNu.MinimumWidth = 6;
            this.RoomNu.Name = "RoomNu";
            this.RoomNu.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.MinimumWidth = 6;
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // In
            // 
            this.In.HeaderText = "In";
            this.In.MinimumWidth = 6;
            this.In.Name = "In";
            this.In.ReadOnly = true;
            // 
            // Out
            // 
            this.Out.HeaderText = "Out";
            this.Out.MinimumWidth = 6;
            this.Out.Name = "Out";
            this.Out.ReadOnly = true;
            // 
            // ReservasyonYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlFaturalar);
            this.Name = "ReservasyonYonetimi";
            this.Size = new System.Drawing.Size(1106, 528);
            this.tabControlFaturalar.ResumeLayout(false);
            this.tabPageFaturaEkle.ResumeLayout(false);
            this.tabPageFaturaEkle.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFaturalar;
        private System.Windows.Forms.TabPage tabPageFaturaEkle;
        private System.Windows.Forms.Button add_room;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_room_no;
        private System.Windows.Forms.ComboBox combo_room_type;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out;
    }
}
