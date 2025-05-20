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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void Çıkışbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void FaturaHebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaturaHesaplamaPage faturaHesaplamaPage = new FaturaHesaplamaPage();
            faturaHesaplamaPage.ShowDialog();
            this.Show();
        }

        private void Rezervasyonİşlemleribtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervasyonİşlemleriPage rezervasyonİşlemleriPage = new RezervasyonİşlemleriPage();
            rezervasyonİşlemleriPage.ShowDialog();
            this.Show();
        }
    }
}
