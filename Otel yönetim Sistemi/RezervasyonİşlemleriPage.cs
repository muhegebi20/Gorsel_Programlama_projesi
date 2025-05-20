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
    public partial class RezervasyonİşlemleriPage : Form
    {
        public RezervasyonİşlemleriPage()
        {
            InitializeComponent();
        }

        private void İptalbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kaydetbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarlı");
            this.Close();
        }
    }
}
