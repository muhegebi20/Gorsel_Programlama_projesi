using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
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
    }
}
