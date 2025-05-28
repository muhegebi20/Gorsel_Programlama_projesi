using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_yönetim_Sistemi.Model
{
    // Models/Room.cs
    public class Room
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; } // Standard, Deluxe, Suite
        public double Price { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; } // Available, Occupied, Maintenance
        public List<string> Amenities { get; set; } // WiFi, TV, MiniBar
    }
}
