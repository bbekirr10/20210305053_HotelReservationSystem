using HotelReservationSystem.Class;
using HotelReservationSystem.EntityLayer.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.DataAccessLayer.Context
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=HotelReservationDb; Trusted_Connection=True; TrustServerCertificate=True; ");
        }
    }
}
