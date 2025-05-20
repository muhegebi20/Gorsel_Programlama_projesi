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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Gerişbtn_Click(object sender, EventArgs e)
        {
            if (AdminRadiobtn.Checked == true)
            {
                this.Hide();
                AdminHomePage adminHomePage = new AdminHomePage();
                adminHomePage.ShowDialog();
                this.Close();
            }
            else if (ResepsiyonRadiobtn.Checked == true)
            {
                this.Hide();
                ResepsiyonHomePage resepsiyonHomePage = new ResepsiyonHomePage();
                resepsiyonHomePage.ShowDialog();
                this.Close();
            }
            else if (MüşteriRadiobtn.Checked == true)
            {
                this.Hide();
                MüşteriHomePage müşteriHomePage = new MüşteriHomePage();
                müşteriHomePage.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Boş Bıraktınız","Hata");
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kayıtbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }
    }
}
