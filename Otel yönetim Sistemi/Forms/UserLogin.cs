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
    public partial class UserLogin : Form
    {
        string selectedRole = "user"; // Varsayılan rol
        public UserLogin()
        {
            InitializeComponent();
        }

        public string userRole()
        {
            if (admin.Checked)
            {
                selectedRole = "admin";
            }
            else if (reception.Checked)
            {
                selectedRole = "receptionist";
            }
            else if (user.Checked)
            {
                selectedRole = "user";
            }
            return selectedRole;
        }

        private void _login_Click(object sender, EventArgs e)
        {
            string email = user_email.Text;
            string password = user_password.Text;
            selectedRole = userRole();
            string role = selectedRole;
            Controller.userController controller = new Controller.userController();
            if (controller.AuthenticateUser(email, password, role))
            {
                Form nextForm;
                if (role == "admin")
                {
                    nextForm = new AdminHomePage();
                }
                else
                {
                    nextForm = new MusteriHomePage();
                }

                nextForm.FormClosed += (s, args) => this.Close();
                AdminHomePage.UserName = email;
                MusteriHomePage.UserName = email;
                ResepsiyonHomePage.UserName = email;
                MessageBox.Show("Giriş başarılı!");
                nextForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız! Lütfen kullanıcı adı ve şifrenizi kontrol edin.");
            }
        }

        private void lnk_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 
            this.Hide();
            RegisterUser userRegister = new RegisterUser();
            userRegister.ShowDialog();
            this.Close();
        }

        private void login_Enter(object sender, EventArgs e)
        {

        }
    }
}
