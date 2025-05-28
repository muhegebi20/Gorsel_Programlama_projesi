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

        // updates room
        public void updateRoom(string roomId, string roomNumber, string roomType, double price, int capacity, string isAvailable, List<string> amenities)
        {
            var updatedRoom = new Model.Room
            {
                Id = new MongoDB.Bson.ObjectId(roomId),
                RoomNumber = roomNumber,
                Type = roomType,
                Price = price,
                Capacity = capacity,
                Status = isAvailable,
                Amenities = amenities
            };
            _roomDAO.UpdateRoom(updatedRoom);
        }

        // deletes a room by its ID
        public void deleteRoom(string roomId)
        {
            _roomDAO.DeleteRoom(new MongoDB.Bson.ObjectId(roomId));
        }

        // retrieves all rooms
        public List<Model.Room> getAllRooms()
        {
            return _roomDAO.GetAllRooms();
        }

        // retrieves a room by its ID
        public Model.Room getRoomById(string roomId)
        {
            return _roomDAO.GetRoomById(new MongoDB.Bson.ObjectId(roomId));
        }

        // retrieves rooms by their status (e.g., Available, Occupied, Maintenance)
        public List<Model.Room> getRoomsByStatus(string status)
        {
            return _roomDAO.GetRoomsByStatus(status);
        }

        // retrieves rooms that are currently available
        public List<Model.Room> getAvailableRooms()
        {
            return _roomDAO.GetRoomsByStatus("Available");
        }
        // retrieves rooms that are currently occupied
        public List<Model.Room> getOccupiedRooms()
        {
            return _roomDAO.GetRoomsByStatus("Occupied");
        }


        // retrieves rooms by type (e.g., Standard, Deluxe, Suite)
        public List<Model.Room> getRoomsByType(string type)
        {
            var allRooms = _roomDAO.GetAllRooms();
            return allRooms.Where(r => r.Type.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // retrieves rooms within a specified price range
        public List<Model.Room> getRoomsByPriceRange(double minPrice, double maxPrice)
        {
            var allRooms = _roomDAO.GetAllRooms();
            return allRooms.Where(r => r.Price >= minPrice && r.Price <= maxPrice).ToList();
        }

    }
}
