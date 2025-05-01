using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.Class
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerContactInfo { get; set; }
       
       //public ICollection<Reservation> Reservations { get; set; }
    }
}
