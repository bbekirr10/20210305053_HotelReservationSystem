using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Class
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string Status { get; set; }




    }
}
