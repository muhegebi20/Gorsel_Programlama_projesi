using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Otel_yonetim_Sistemi.Model
{
    public class Feedback
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("userId")]
        public ObjectId UserId { get; set; }

        [BsonElement("reservationId")]
        public ObjectId ReservationId { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("rating")]
        public int Rating { get; set; } // 1 to 5

        [BsonElement("comment")]
        public string Comment { get; set; }
    }
}
