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

namespace Otel_yönetim_Sistemi.User_Control
{
    public partial class UserBilGuncelle : UserControl
    {
        private readonly Controller.userController _userController = new Controller.userController();
        public UserBilGuncelle()
        {
            InitializeComponent();
            LoadUserData();
        }

        

        private void LoadUserData()
        {
            // This method should load user data into the DataGridView or other controls.
            // For example, you can fetch users from a database and populate the DataGridView.
            // Example:
            // var users = _userController.GetAllUsers();
            // foreach (var user in users)
            // {
            //     dataGridView1.Rows.Add(user.Id, user.Name, user.Surname, user.Email, user.Telefon);
            // }
            var users = _userController.GetAllUsers();
            if (users == null || users.Count == 0)
            {
                MessageBox.Show("No users found.");
                return;
            }
            foreach (var user in users)
            {
                dataGridView1.Rows.Add(user.Id, user.Email, user.Name, user.Surname, user.Telefon);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _name.Text = dataGridView1.Rows[e.RowIndex].Cells["user_name"].Value.ToString();
            _surname.Text = dataGridView1.Rows[e.RowIndex].Cells["user_surname"].Value.ToString();
            _email.Text = dataGridView1.Rows[e.RowIndex].Cells["user_email"].Value.ToString();
            telefon.Text = dataGridView1.Rows[e.RowIndex].Cells["user_telefon"].Value.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string name = _name.Text;
            string surname = _surname.Text;
            string email = _email.Text;
            string telefon = this.telefon.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            var selectedRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrWhiteSpace(selectedRow))
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçin.");
                return;
            }
            var userId = selectedRow;
            User updateUser = new User
            {
                Id = new MongoDB.Bson.ObjectId(userId),
                Name = name,
                Surname = surname,
                Email = email,
                Telefon = telefon
            };
            bool success = _userController.UpdateUser(updateUser);
            if (success)
            {
                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");
                dataGridView1.Rows.Clear(); // Clear existing rows
                LoadUserData();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri güncellenemedi. Lütfen tekrar deneyin.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            _userController.DeleteUser(selectedRow);
            MessageBox.Show("Kullanıcı başarıyla silindi.");
            dataGridView1.Rows.Clear(); // Clear existing rows
            LoadUserData();
        }
    }
}
