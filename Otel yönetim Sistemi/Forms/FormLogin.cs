using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otel_yönetim_Sistemi.Forms;

namespace Otel_yönetim_Sistemi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize,"Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose,"Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide , "Hide");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar=true;
            pictureBoxShow.Show();
        }

        private void pictureBoxShow1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow1, "Show");
        }

        private void pictureBoxHide1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide1, "Hide");
        }

        private void pictureBoxShow2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow2, "Show");

        }

        private void pictureBoxHide2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide2, "Hide");

        }

        private void pictureBoxShow1_Click(object sender, EventArgs e)
        {
            pictureBoxShow1.Hide();
            textBoxPassword1.UseSystemPasswordChar = false;
            pictureBoxHide1.Show();
        }

        private void pictureBoxHide1_Click(object sender, EventArgs e)
        {
            pictureBoxHide1.Hide();
            textBoxPassword1.UseSystemPasswordChar = true;
            pictureBoxShow1.Show();
        }

        private void pictureBoxShow2_Click(object sender, EventArgs e)
        {
            pictureBoxShow2.Hide();
            textBoxPassword2.UseSystemPasswordChar = false;
            pictureBoxHide2.Show();
        }

        private void pictureBoxHide2_Click(object sender, EventArgs e)
        {
            pictureBoxHide2.Hide();
            textBoxPassword2.UseSystemPasswordChar = true;
            pictureBoxShow2.Show();
        }

        private void RegisterForm_Click(object sender, EventArgs e)
        {
            groupBoxLogin.Visible = false;
            groupBoxRegister.Visible = true;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            groupBoxRegister.Visible = false;
            groupBoxLogin.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            if (radioButtonAdmin.Checked == true)
            {
                this.Hide();
                AdminHomePage ad = new AdminHomePage();
                ad.UserName = textBoxUsername.Text;
                ad.ShowDialog();
                this.Show();
            }
            else if (radioButtonMüşteri.Checked == true)
            {
                this.Hide();
                MüşteriHomePage mu = new MüşteriHomePage();
                mu.UserName = textBoxUsername.Text;
                mu.ShowDialog();
                this.Show();
            }
            else if (radioButtonResepsiyon.Checked == true)
            {
                this.Hide();
                ResepsiyonHomePage rs = new ResepsiyonHomePage();
                rs.UserName = textBoxUsername.Text;
                rs.ShowDialog();
                this.Show();
            }
        }
    }
}
