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
            RezervasyonAra rezervasyonAra = new RezervasyonAra();
            rezervasyonAra.ShowDialog();
        }
    }
}
