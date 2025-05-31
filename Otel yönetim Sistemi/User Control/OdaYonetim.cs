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
            LoadData();
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

        private void up_btn_update_Click(object sender, EventArgs e)
        {
            roomNumber = up_room_no.Text.Trim();
            roomType = up_room_type.Text.Trim();
            price = Int32.Parse(up_room_price.Text.Trim());
            capacity = Int32.Parse( up_capacity.Text);
            status = up_room_status.Text.Trim();
            var roomId = up_Id.Text.Trim();
            if (string.IsNullOrEmpty(roomId))
            {
                MessageBox.Show("Lütfen güncellenecek istediginiz odayi seciniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _controller.updateRoom(roomId, roomNumber, roomType, price, capacity, status, amenities);
            MessageBox.Show("Successfully updated");
            up_room_no.Text = string.Empty;
            up_room_type.Text = string.Empty;
            up_room_price.Text = string.Empty;
            up_capacity.Text = string.Empty;
            up_room_status.Text = string.Empty;
            LoadData();

        }
        private void LoadData()
        {
            var rooms = _controller.getAllRooms();
            up_datagrid.DataSource = null;
            up_datagrid.DataSource = rooms;
            up_datagrid.Refresh();
        }

        private void up_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Prevent header row issues

            var currentRow = up_datagrid.Rows[e.RowIndex];

            up_Id.Text = currentRow.Cells[0].Value?.ToString();
            up_room_no.Text = currentRow.Cells[1].Value?.ToString();
            up_room_type.Text = currentRow.Cells[2].Value?.ToString();
            up_room_price.Text = currentRow.Cells[3].Value?.ToString();
            up_capacity.Text = currentRow.Cells[4].Value?.ToString();
            up_room_status.Text = currentRow.Cells[5].Value?.ToString();
        }

    }
}
