namespace Otel_yönetim_Sistemi
{
    partial class AddRooms
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
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.box_room_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_capacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_room_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_amenity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add_amenity = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_status
            // 
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Items.AddRange(new object[] {
            "Available",
            "Occupied"});
            this.combo_status.Location = new System.Drawing.Point(549, 145);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(168, 24);
            this.combo_status.TabIndex = 0;
            // 
            // box_room_no
            // 
            this.box_room_no.Location = new System.Drawing.Point(180, 148);
            this.box_room_no.Multiline = true;
            this.box_room_no.Name = "box_room_no";
            this.box_room_no.Size = new System.Drawing.Size(211, 37);
            this.box_room_no.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room No";
            // 
            // box_price
            // 
            this.box_price.Location = new System.Drawing.Point(180, 202);
            this.box_price.Multiline = true;
            this.box_price.Name = "box_price";
            this.box_price.Size = new System.Drawing.Size(211, 37);
            this.box_price.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // box_capacity
            // 
            this.box_capacity.Location = new System.Drawing.Point(180, 263);
            this.box_capacity.Multiline = true;
            this.box_capacity.Name = "box_capacity";
            this.box_capacity.Size = new System.Drawing.Size(211, 37);
            this.box_capacity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacity";
            // 
            // combo_room_type
            // 
            this.combo_room_type.FormattingEnabled = true;
            this.combo_room_type.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Suite"});
            this.combo_room_type.Location = new System.Drawing.Point(549, 195);
            this.combo_room_type.Name = "combo_room_type";
            this.combo_room_type.Size = new System.Drawing.Size(168, 24);
            this.combo_room_type.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Room Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Room Type";
            // 
            // txt_amenity
            // 
            this.txt_amenity.Location = new System.Drawing.Point(462, 272);
            this.txt_amenity.Multiline = true;
            this.txt_amenity.Name = "txt_amenity";
            this.txt_amenity.Size = new System.Drawing.Size(137, 28);
            this.txt_amenity.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amenities (wifi, breakfast, tv etc.)";
            // 
            // btn_add_amenity
            // 
            this.btn_add_amenity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_add_amenity.ForeColor = System.Drawing.Color.White;
            this.btn_add_amenity.Location = new System.Drawing.Point(614, 263);
            this.btn_add_amenity.Name = "btn_add_amenity";
            this.btn_add_amenity.Size = new System.Drawing.Size(103, 39);
            this.btn_add_amenity.TabIndex = 3;
            this.btn_add_amenity.Text = "ADD";
            this.btn_add_amenity.UseVisualStyleBackColor = false;
            this.btn_add_amenity.Click += new System.EventHandler(this.btn_add_amenity_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(288, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "ADD ROOM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_add_amenity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_amenity);
            this.Controls.Add(this.box_capacity);
            this.Controls.Add(this.box_price);
            this.Controls.Add(this.box_room_no);
            this.Controls.Add(this.combo_room_type);
            this.Controls.Add(this.combo_status);
            this.Name = "AddRooms";
            this.Text = "AddRooms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.TextBox box_room_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox box_capacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_room_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_amenity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add_amenity;
        private System.Windows.Forms.Button button2;
    }
}