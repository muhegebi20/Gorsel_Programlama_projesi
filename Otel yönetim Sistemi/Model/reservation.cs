using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Otel_yonetim_Sistemi.Model
{
    public class Reservation
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
