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
using Otel_yonetim_Sistemi.Model;

namespace Otel_yönetim_Sistemi.Forms
{
    public partial class RezervasyonAra : Form
    {
        public RezervasyonAra(List<Room> odalar)
        {
            InitializeComponent();

            // Show filtered room info in the DataGridView
            dataGridViewFaturalar.DataSource = odalar
                .Select(r => new { r.RoomNumber, r.Price })
                .ToList();
        }

        private void Geribtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void dataGridViewFaturalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
