using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Class
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public decimal RoomPrice { get; set; }
        public string RoomAvailability { get; set; }
        //public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
