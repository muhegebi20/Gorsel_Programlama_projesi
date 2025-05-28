using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Otel_yonetim_Sistemi.Model;
using Otel_yonetim_Sistemi.dao;
using Otel_yönetim_Sistemi.Model;

namespace Otel_yönetim_Sistemi.dao
{
    class RoomDAO
    {
        private readonly Repository _repository;
        public RoomDAO()
        {
            _repository = new Repository();
        }
        public void AddRoom(Room room)
        {
            var rooms = _repository.GetCollection<Room>("rooms");
            rooms.InsertOne(room);
        }
        public void UpdateRoom(Room room) 
        {
            var rooms = _repository.GetCollection<Room>("rooms");
            var filter = Builders<Room>.Filter.Eq(r => r.Id, room.Id);
            rooms.ReplaceOne(filter, room);
        }
        public void DeleteRoom(ObjectId roomId)
        {
            var rooms = _repository.GetCollection<Room>("rooms");
            var filter = Builders<Room>.Filter.Eq(r => r.Id, roomId);
            rooms.DeleteOne(filter);
        }
        public List<Room> GetAllRooms()
        {
            var rooms = _repository.GetCollection<Room>("rooms");
            return rooms.Find(new BsonDocument()).ToList();
        }
        public Room GetRoomById(ObjectId roomId)
        {
            var rooms = _repository.GetCollection<Room>("rooms");
            var filter = Builders<Room>.Filter.Eq(r => r.Id, roomId);
            return rooms.Find(filter).FirstOrDefault();
        }
        public List<Room> GetRoomsByStatus(string status)
        {
            var rooms = _repository.GetCollection<Room>("rooms");
            var filter = Builders<Room>.Filter.Eq(r => r.Status, status);
            return rooms.Find(filter).ToList();
        }

    }
}
