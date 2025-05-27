using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Otel_yönetim_Sistemi.Model
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("username")]
        public string Username { get; set; } 


        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("role")]
        public string Role { get; set; } = "user"; // Varsayılan rol

        // Kişisel Bilgiler
        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;
        [BsonElement("surname")]
        public string Surname { get; set; } = string.Empty;
        [BsonElement("telefon")]
        public string Telefon { get; set; } = string.Empty;
    }
}
