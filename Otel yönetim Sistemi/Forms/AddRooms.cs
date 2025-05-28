using Otel_yönetim_Sistemi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_yönetim_Sistemi
{
    public partial class AddRooms: Form
    {
        private Controller.roomController _controller = new Controller.roomController();
        string roomNo;
        int price;
        int capacity;
        string status;
        string type;
        List<string> amenities = new List<string>();


        public AddRooms()
        {
            InitializeComponent();
        }

        private void btn_add_amenity_Click(object sender, EventArgs e)
        {
            string amenity = txt_amenity.Text;
            amenities.Add(amenity);
            txt_amenity.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            roomNo = box_room_no.Text;
            price = Int32.Parse(box_price.Text);
            capacity = Int32.Parse(box_capacity.Text);
            status = combo_status.Text;
            type = combo_room_type.Text;

            _controller.addRoom(roomNo, type, price, capacity, status, amenities);
            MessageBox.Show("Room successfully added");
            
            
        }
    }
}
