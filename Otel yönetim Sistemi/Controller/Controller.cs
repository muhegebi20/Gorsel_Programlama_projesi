using Otel_yönetim_Sistemi.dao;
using Otel_yönetim_Sistemi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Otel_yönetim_Sistemi.Controller
{
    public class Controller
    {
        Repository _repository;

        public Controller()
        {
            _repository = new Repository();
        }

        public void RegisterUser(string username,string email,  string password)
        {
            var newUser = new User
            {
                Username = username,
                Email = email,
                Password = BCrypt.Net.BCrypt.HashPassword(password)
            };
            _repository.RegisterUser(newUser);
        }
        public bool AuthenticateUser(string username, string password, string role)
        {
            var user = new User
            {
                Username = username,
                Password = password
            };
            var foundUser = _repository.AuthenticateUser(user);
            if (foundUser != null && foundUser.Role == role)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
    }
}
