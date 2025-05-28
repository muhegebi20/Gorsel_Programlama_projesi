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
    public partial class AdminHomePage : Form
    {
        public string UserName;
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void MovePanal(Control btn)
        {
            panelMove.Top = btn.Top;
            panelMove.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDataTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = UserName;
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musun ?","Çıkış Yap",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void buttonMusteriYonetimi_Click(object sender, EventArgs e)
        {
            panelMove.Visible = true;
            MovePanal(buttonMusteriYonetimi);
            userControlFaturaHesapla2.Visible = false;

        }

        private void buttonOdaYonetimi_Click(object sender, EventArgs e)
        {
            panelMove.Visible = true;
            MovePanal(buttonOdaYonetimi);
            userControlFaturaHesapla2.Visible = false;
        }

        private void buttonRezervasyonislemleri_Click(object sender, EventArgs e)
        {
            panelMove.Visible = true;
            MovePanal(buttonRezervasyonislemleri);
            userControlFaturaHesapla2.Visible = false;
        }

        private void buttonFaturaHesapla_Click(object sender, EventArgs e)
        {
            panelMove.Visible = true;
            MovePanal(buttonFaturaHesapla);
            userControlFaturaHesapla2.Visible = true;
        }

        private void buttonRaporlariGoruntule_Click(object sender, EventArgs e)
        {
            panelMove.Visible = true;
            MovePanal(buttonRaporlariGoruntule);
            userControlFaturaHesapla2.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
