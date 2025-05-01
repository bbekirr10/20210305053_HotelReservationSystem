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
    public class ReservationManager
    {
        private readonly HotelDbContext _context;

        public ReservationManager(HotelDbContext context)
        {
            _context = context;
        }
        public List<Reservation> GetAllReservations()
        {

            return _context.Reservations.ToList();
     
        }
        public List<Reservation> GetReservationsByCustomerId(int customerId)
        {
            return _context.Reservations.ToList();
        }


        public Reservation MakeReservation(int roomId, int customerId, DateTime checkIn, DateTime checkOut)
        {
            var reservation = new Reservation
            {
                RoomId = roomId,
                CustomerId = customerId,
                CheckInDate = checkIn,
                CheckOutDate = checkOut,
                Status = "Reservation Confirmed"
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            return reservation;
        }

        public void CancelReservation(int reservationId)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.ReservationId == reservationId);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
            }
        }

        public void AddReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public void UpdateReservation(Reservation reservation)
        {
            _context.Reservations.Update(reservation);
            _context.SaveChanges();
        }
        public void DeleteReservation(int reservationId)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.ReservationId == reservationId);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
            }
        }

        public Reservation GetReservationById(int reservationId)
        {
            return _context.Reservations.FirstOrDefault(r => r.ReservationId == reservationId);
        }



    }
}

