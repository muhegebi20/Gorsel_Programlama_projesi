using Otel_yönetim_Sistemi.Controller;
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
using Otel_yonetim_Sistemi.dao;

namespace Otel_yönetim_Sistemi.Forms
{
    public partial class Roomdetails : Form
    {
        private Controller.roomController _controller = new Controller.roomController();

        public Roomdetails()
        {
            InitializeComponent();
        }

        private void Type_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Capacity_ValueChanged(object sender, EventArgs e)
        {

        }
        // Assuming you have a method to fetch room data
        private void LoadRoomData()
        {
            List<Room> roomTable = _controller.getAllRooms(); // Fetch data from DB or other source
            foreach (Room room in roomTable)
            {
                dataGridView1.Rows.Add(room.Type, room.Price, room.Capacity, room.Status);
            }
        }
        private void AddActionButtons()
        {
            // Add Edit button
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(editButton);

            // Add Delete button
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteButton);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Roomdetails_Load(object sender, EventArgs e)
        {

        }
    }
}
