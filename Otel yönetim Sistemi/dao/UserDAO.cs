using Otel_yönetim_Sistemi.Model;
using MongoDB.Driver;
<<<<<<< HEAD

namespace Otel_yönetim_Sistemi.dao
=======
using Otel_yonetim_Sistemi.Model;
using Otel_yonetim_Sistemi.dao;

namespace Otel_yonetim_Sistemi.dao
>>>>>>> 81cd984d6953da013656a85a451e098f96441751
{
    public class UserDAO
    {
        private readonly Repository _repository;

        public UserDAO()
        {
            _repository = new Repository();
        }

        public void RegisterUser(User user)
        {
            var users = _repository.GetCollection<User>("users");
            users.InsertOne(user);
        }

        public User AuthenticateUser(User user)
        {
            var users = _repository.GetCollection<User>("users");
            var filter = Builders<User>.Filter.Eq(u => u.Email, user.Email);
            var foundUser = users.Find(filter).FirstOrDefault();
            if (foundUser == null || !BCrypt.Net.BCrypt.Verify(user.Password, foundUser.Password))
            {
                return null;
            }
            return foundUser;
        }

        public bool UserExists(User user)
        {
            var users = _repository.GetCollection<User>("users");
            var filter = Builders<User>.Filter.Eq(u => u.Email, user.Email);
            return users.Find(filter).FirstOrDefault() != null;
        }
    }
}
