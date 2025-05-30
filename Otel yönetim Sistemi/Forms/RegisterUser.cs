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
        private Controller.userController _controller = new Controller.userController();
        public RegisterUser()
        {
            InitializeComponent();


        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string name = _name.Text;
            string password = _password.Text;
            string email = _email.Text;

            if (_controller.UserExists(email))
            {
                MessageBox.Show("Bu e-posta adresi zaten kayıtlı. Lütfen farklı bir e-posta adresi kullanın.");
                return;
            }

            _controller.RegisterUser(name, email, password);

            MessageBox.Show("Kayıt başarılı!");
            this.Hide();
            UserLogin userLoginForm = new UserLogin();
           
            userLoginForm.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserLogin userLoginForm = new UserLogin();
            userLoginForm.ShowDialog();
            this.Close(); 
        }
    }
}
