using Otel_yonetim_Sistemi.dao;
using Otel_yonetim_Sistemi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using BCrypt.Net;
using System.Windows.Forms;

namespace Otel_yönetim_Sistemi.Controller
{
    public class userController
    {
        private readonly UserDAO _userDAO;

        public userController()
        {
            //_userDAO = new Repository();
            _userDAO = new UserDAO();
        }

        public void RegisterUser(string name, string email, string password)
        {
            var newUser = new User
            {
                Name = name,
                Email = email,
                Password = BCrypt.Net.BCrypt.HashPassword(password)
            };
            _userDAO.RegisterUser(newUser);
        }
        public bool AuthenticateUser(string email, string password, string role)
        {
            var user = new User
            {
                Email = email,
                Password = password
            };
            var foundUser = _userDAO.AuthenticateUser(user);
            if (foundUser != null && foundUser.Role == role)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UserExists(string email)
        {
            var user = new User
            {
                Email = email
            };
            return _userDAO.UserExists(user);
        }
        public List<User> GetAllUsers()
        {
            var users = _userDAO.GetAllUsers();
            return users.ToList();
        }
        public bool UpdateUser(User user)
        {
            var users = _userDAO.GetAllUsers();
            var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Surname = user.Surname;
                existingUser.Telefon = user.Telefon;
                existingUser.Email = user.Email;
                existingUser.Role = user.Role;
                _userDAO.UpdateUser(existingUser); 
                return true;
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
                return false;
            }
        }
        public User GetUserById(MongoDB.Bson.ObjectId userId)
        {
            var users = _userDAO.GetAllUsers();
            return users.FirstOrDefault(u => u.Id == userId);
        }
        public bool DeleteUser(string userId)
        {
            return _userDAO.DeleteUser(userId);

        }
        public User GetUserByEmail(string email)
        {
            var users = _userDAO.GetAllUsers();
            return users.FirstOrDefault(u => u.Email == email);
        }
    }
}
