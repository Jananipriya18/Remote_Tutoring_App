﻿using dotnetapp.Data;
using dotnetapp.Models;

namespace dotnetapp.Services
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer updatedcustomer, int id)
        {
            var existingCustomer = _context.Customers.Find(id);

            if (existingCustomer != null)
            {
                // Update properties based on your requirements
                existingCustomer.Email = updatedcustomer.Email;
                existingCustomer.CustomerName = updatedcustomer.CustomerName;
                existingCustomer.MobileNumber = updatedcustomer.MobileNumber;

                _context.SaveChanges();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            var CustomerToDelete = _context.Customers.Find(customerId);

            if (CustomerToDelete != null)
            {
                _context.Customers.Remove(CustomerToDelete);
                _context.SaveChanges();
            }
        }
    }
}