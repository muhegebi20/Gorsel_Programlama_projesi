using Otel_yonetim_Sistemi.Model;
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
        private Controller.userController _controller = new Controller.userController();
        string selectedRole = "";
        public static MongoDB.Bson.ObjectId _id;
        User currentUser;
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
            if(string.IsNullOrEmpty(selectedRole) || string.IsNullOrEmpty(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Lütfen tum alanlari doldurun.");
                return;
            }
            string role = selectedRole;
            Controller.userController controller = new Controller.userController();
            if (controller.AuthenticateUser(email, password, role))
            {
                currentUser = _controller.GetUserByEmail(email);
                User.Current = currentUser;

                Form nextForm;
                if (role == "admin")
                {
                    nextForm = new AdminHomePage();
                    currentUser = _controller.GetUserByEmail(email);
                }
                else
                {
                    nextForm = new MusteriHomePage();
                currentUser = _controller.GetUserByEmail(email);
                }
                _id = currentUser.Id;
                nextForm.FormClosed += (s, args) => this.Close();
                AdminHomePage.UserName = currentUser.Name;
                MusteriHomePage.UserName = currentUser.Name;
                ResepsiyonHomePage.UserName = currentUser.Name;
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
