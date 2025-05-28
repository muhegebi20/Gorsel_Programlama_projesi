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
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "OtelYonetimDB";

            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
