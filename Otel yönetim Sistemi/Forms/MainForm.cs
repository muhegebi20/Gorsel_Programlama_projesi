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

namespace Otel_yönetim_Sistemi.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Girisbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin userLogin = new UserLogin();
            userLogin.ShowDialog();
            this.Close();
        }

        private void RazervasyonAraBtn_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = checkin.Value;
            DateTime cikisTarihi = checkout.Value;
            int kisiSayisi = int.Parse(comboBox3.SelectedItem.ToString());

            roomController rc = new roomController();
            var uygunOdalar = rc.getAvailableRooms();

            var filtrelenmisOdalar = uygunOdalar
                .Where(r => r.Capacity >= kisiSayisi)
                .ToList();

            // OPEN RezervasyonAra form and pass the data
            RezervasyonAra rezervasyonAra = new RezervasyonAra(filtrelenmisOdalar);
            rezervasyonAra.ShowDialog();
        }



        private void checkout_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
