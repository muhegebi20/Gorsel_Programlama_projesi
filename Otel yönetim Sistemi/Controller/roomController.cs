using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otel_yönetim_Sistemi.dao;

namespace Otel_yönetim_Sistemi.Controller
{
    class roomController
    {
        private readonly RoomDAO _roomDAO;
        public roomController()
        {
            _roomDAO = new RoomDAO();
        }

        public void addRoom(string roomNumber, string roomType, double price, int capacity, string isAvailable, List<string> amenities)
        {
            var newRoom = new Model.Room
            {
                RoomNumber = roomNumber,
                Type = roomType, 
                Price = price,
                Capacity = capacity,
                Status = isAvailable,
                Amenities = amenities
            };
            _roomDAO.AddRoom(newRoom);
        }
    }
}
