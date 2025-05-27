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
    public partial class RegisterUser: Form
    {
        private Controller.Controller _controller = new Controller.Controller();
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = _name.Text;
            string password = _password.Text;
            string email = _email.Text;

            _controller.RegisterUser(username, email, password);

            MessageBox.Show("Kayıt başarılı!");
            UserLogin userLoginForm = new UserLogin();
            this.Hide(); // Kayıt formunu gizle
            userLoginForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin userLoginForm = new UserLogin();
            userLoginForm.Show();
            this.Hide(); // Kayıt formunu gizle
        }
    }
}
