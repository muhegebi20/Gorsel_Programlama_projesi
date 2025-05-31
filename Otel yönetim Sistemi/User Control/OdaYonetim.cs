using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otel_yonetim_Sistemi.Model;
using Otel_yönetim_Sistemi.Model;

namespace Otel_yönetim_Sistemi.User_Control
{
    public partial class OdaYonetim : UserControl
    {
        List<string> amenities = new List<string>();
        string roomNumber;
        string roomType;
        double price;
        int capacity;
        string status;

        private readonly Controller.roomController _controller = new Controller.roomController();

        public OdaYonetim()
        {
            InitializeComponent();
        }

        private void btn_add_amenity_Click(object sender, EventArgs e)
        {
            string amenity = txt_amenity.Text.Trim();
            if (string.IsNullOrEmpty(amenity))
            {
                MessageBox.Show("Lütfen bir olanak giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (amenities.Contains(amenity))
            {
                MessageBox.Show("Bu olanak zaten eklenmiş.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            amenities.Add(amenity);
            all_amenities.Text += string.Format($"{amenity}, ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            price = Int32.Parse(box_price.Text.Trim());
            capacity = Int32.Parse(box_capacity.Text.Trim());
            roomNumber = box_room_no.Text.Trim();
            status = combo_status.Text;
            roomType = combo_room_type.Text;
            

            _controller.addRoom(roomNumber, roomType, price, capacity, status, amenities);
            MessageBox.Show("Successfully added");


            box_capacity.Text = string.Empty;
            box_price.Text = string.Empty;
            box_room_no.Text = string.Empty;
        }
    }
}
