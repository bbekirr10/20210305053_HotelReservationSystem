using HotelReservationSystem.Class;
using HotelReservationSystem.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.BusinessLayer.Operations
{
    public class RoomManager
    {
        private readonly HotelDbContext _context;

        public RoomManager(HotelDbContext context)
        {
            _context = context;
        }

        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
       
            var overlappingReservations = _context.Reservations
                .Where(r => r.CheckOutDate > checkIn && r.CheckInDate < checkOut)
                .ToList();
            if (overlappingReservations.Any())
            {
                string message = "Conflicting reservations:\n";
                foreach (var res in overlappingReservations)
                {
                    message += $"Room ID: {res.RoomId}, Login: {res.CheckInDate.ToShortDateString()}, Exit: {res.CheckOutDate.ToShortDateString()}\n";
                }
                MessageBox.Show(message);
   
            }
            else
            {
                MessageBox.Show("There are no conflicting bookings.");
            }

            var reservedRoomIds = overlappingReservations
                .Select(r => r.RoomId)
                .Distinct()
                .ToList();

            return _context.Rooms
                .Where(r => !reservedRoomIds.Contains(r.RoomId))
                .ToList();
        }

        public Room GetRoomById(int roomId)
        {
            return _context.Rooms.FirstOrDefault(r => r.RoomId == roomId);
        }
        public List<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }
        public void AddRoom(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }

        public void DeleteRoom(int roomId)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.RoomId == roomId);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }     
        }


    }
}
