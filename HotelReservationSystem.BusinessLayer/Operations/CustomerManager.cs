using HotelReservationSystem.Class;
using HotelReservationSystem.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.BusinessLayer.Operations
{
    public class CustomerManager
    {
        private readonly HotelDbContext _context;

        public CustomerManager(HotelDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerID == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
