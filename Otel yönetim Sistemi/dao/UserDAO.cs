using Otel_yonetim_Sistemi.Model;
using MongoDB.Driver;
using Otel_yonetim_Sistemi.dao;
using System.Collections.Generic;

namespace Otel_yonetim_Sistemi.dao
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
        public void UpdateUser(User user)
        {
            var users = _repository.GetCollection<User>("users");
            var filter = Builders<User>.Filter.Eq(u => u.Id, user.Id);
            users.ReplaceOne(filter, user);
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
        public List<User> GetAllUsers()
        {
            var users = _repository.GetCollection<User>("users");
            return users.Find(_ => true).ToList();
        }
        public bool DeleteUser(string userId)
        {
            var users = _repository.GetCollection<User>("users");
            var filter = Builders<User>.Filter.Eq(u => u.Id, new MongoDB.Bson.ObjectId(userId));
            var result = users.DeleteOne(filter);
            return result.DeletedCount > 0;
        }
    }
}
