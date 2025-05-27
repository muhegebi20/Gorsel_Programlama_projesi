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
            Controller.Controller controller = new Controller.Controller();
            if (controller.AuthenticateUser(email, password, role))
            {
                MessageBox.Show("Giriş başarılı!");
                // Burada başarılı giriş sonrası yapılacak işlemler
                this.Hide();
                // Örneğin, ana formu açabilirsiniz
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
            }
            else
            {
                MessageBox.Show("Giriş başarısız! Lütfen kullanıcı adı ve şifrenizi kontrol edin.");
            }
        }

        private void lnk_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUser registerUserForm = new RegisterUser();
            registerUserForm.Show();
            this.Hide(); // Giriş formunu gizle
        }
    }
}
