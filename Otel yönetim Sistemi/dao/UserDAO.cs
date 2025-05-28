using Otel_yönetim_Sistemi.Model;
using MongoDB.Driver;

namespace Otel_yönetim_Sistemi.dao
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
