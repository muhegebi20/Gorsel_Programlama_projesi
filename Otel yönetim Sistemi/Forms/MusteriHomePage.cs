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
    public partial class MusteriHomePage : Form
    {
        public string UserName;
        public MusteriHomePage()
        {
            InitializeComponent();
        }
        private void MovePanal(Control btn)
        {
            panelMove.Top = btn.Top;
            panelMove.Height = btn.Height;
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musun ?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timer1.Stop();
                this.Close();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDataTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void MüşteriHomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = UserName;
        }

        private void buttonRezervasyonlarımıGoruntule_Click(object sender, EventArgs e)
        {
            panelMove.Visible = true;
            MovePanal(buttonRezervasyonlarimiGoruntule);
            userBilGuncelle1.Visible = false;
            faturaGoruntu1.Visible = false;
            rezervasyonGoruntu1.Visible = true;
        }

        private void buttonFaturalarimiGoruntule_Click(object sender, EventArgs e)
        {
            panelMove.Visible = true;
            MovePanal(buttonFaturalarimiGoruntule);
            userBilGuncelle1.Visible = false;
            faturaGoruntu1.Visible = true;
            rezervasyonGoruntu1.Visible = false;
        }

        private void buttonBilgilerimiGuncelle_Click(object sender, EventArgs e)
        {
            panelMove.Visible = true;
            MovePanal(buttonBilgilerimiGuncelle);
            userBilGuncelle1.Visible = true;
            faturaGoruntu1.Visible = false;
            rezervasyonGoruntu1.Visible = false;
        }
    }
}
