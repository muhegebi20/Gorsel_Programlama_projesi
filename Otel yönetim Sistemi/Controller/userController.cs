using Otel_yönetim_Sistemi.dao;
using Otel_yönetim_Sistemi.Model;
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

        public void RegisterUser(string username,string email,  string password)
        {
            var newUser = new User
            {
                Username = username,
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
    }
}
