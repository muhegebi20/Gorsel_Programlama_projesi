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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Kayitbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarlı","Kayıt Ol");
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void Çıkışbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

    }
}
