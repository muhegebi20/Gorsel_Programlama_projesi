using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otel_yonetim_Sistemi.Model;
using Otel_yönetim_Sistemi.Forms;

namespace Otel_yönetim_Sistemi.User_Control
{
    public partial class KullanciYonetimi: UserControl
    {
        private readonly Controller.userController _userController = new Controller.userController();
        public KullanciYonetimi()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = _name.Text;
            string surname = _surname.Text;
            string email = _email.Text;
            string telefon = _telefon.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            var user = new User
            {
                Id = User.Current.Id,
                Name = name,
                Surname = surname,
                Email = email,
                Telefon = telefon
            };

            if (_userController.UpdateUser(user))
            {
                User.Current = _userController.GetUserById(user.Id);
                MessageBox.Show("Kullanıcı bilgileri güncellendi.");
                user_info_datagrid.Rows.Clear();
                LoadUserData();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri güncellenemedi.");
            }

        }
        private void LoadUserData()
        {
            var user = User.Current;
            user_info_datagrid.Rows.Add(user.Id, user.Name, user.Surname, user.Email, user.Telefon);

        }

        private void user_info_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _name.Text = user_info_datagrid.Rows[e.RowIndex].Cells["user_name"].Value.ToString();
            _surname.Text = user_info_datagrid.Rows[e.RowIndex].Cells["user_surname"].Value.ToString();
            _email.Text = user_info_datagrid.Rows[e.RowIndex].Cells["user_email"].Value.ToString();
            _telefon.Text = user_info_datagrid.Rows[e.RowIndex].Cells["user_telefon"].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedRow = user_info_datagrid.CurrentRow.Cells[0].Value.ToString();
            if (selectedRow == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
                return;
            }
            DialogResult result = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (_userController.DeleteUser(selectedRow))
                {
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                    this.FindForm().Hide();
                    UserLogin userLoginForm = new UserLogin();
                    userLoginForm.ShowDialog();
                    this.FindForm().Close();
                    user_info_datagrid.Rows.Clear();
                    LoadUserData();
                }
                else
                {
                    MessageBox.Show("Kullanıcı silinemedi.");
                }
            }
        }
    }
}
