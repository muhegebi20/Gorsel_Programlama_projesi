using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_yönetim_Sistemi.Model
{
    class Reservations
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("userId")]
        public ObjectId UserId { get; set; }

        [BsonElement("roomId")]
        public ObjectId RoomId { get; set; }

        [BsonElement("checkInDate")]
        public DateTime CheckInDate { get; set; }

        [BsonElement("checkOutDate")]
        public DateTime CheckOutDate { get; set; }

        [BsonElement("reservationStatus")]
        public string ReservationStatus { get; set; } = "pending"; // confirmed, cancelled, pending
    }
}
