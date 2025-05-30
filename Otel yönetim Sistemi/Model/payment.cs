using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Otel_yonetim_Sistemi.Model
{
    public class Payment
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("reservationId")]
        public ObjectId ReservationId { get; set; }

        [BsonElement("paymentDate")]
        public DateTime PaymentDate { get; set; }

        [BsonElement("amount")]
        public double Amount { get; set; }

        [BsonElement("paymentMethod")]
        public string PaymentMethod { get; set; } // credit_card, cash, wire_transfer

        [BsonElement("paymentStatus")]
        public string PaymentStatus { get; set; } = "pending"; // successful, failed, pending
    }
}
