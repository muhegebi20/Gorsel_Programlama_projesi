using System;
using System.Windows.Forms;
using MongoDB.Driver;
using Otel_yönetim_Sistemi.Model;

namespace Otel_yönetim_Sistemi.dao
{
    public class Repository
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        public Repository()
        {
            // Replace with your actual MongoDB connection string and database name
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "OtelYonetimDB";

            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(databaseName);
        }

        // Example: Get a collection
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
        public void RegisterUser(User user)
        {
            var users = GetCollection<User>("users");
            users.InsertOne(user);
        }
        public User AuthenticateUser(User user)
        {
            var users = GetCollection<User>("users");
            // First find user by email only
            var filter = Builders<User>.Filter.Eq(u => u.Email, user.Email);
            var foundUser = users.Find(filter).FirstOrDefault();
            
            // If user not found or password doesn't match
            if (foundUser == null || !BCrypt.Net.BCrypt.Verify(user.Password, foundUser.Password))
            {
                return null;
            }
            return foundUser;
        }

    }
}
