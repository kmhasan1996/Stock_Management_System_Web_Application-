﻿using DotNetForever.DatabaseContext.DatabaseContext;
using DotNetForever.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetForever.Repository.Repository
{
    public class CustomerRepository
    {
        public bool Add(Customer customer)
        {
            using (var context = new SMSDbContext())
            {
                context.Customers.Add(customer);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update (Customer customer)
        {
            using (var context = new SMSDbContext())
            {
                Customer model = new Customer();
                model = context.Customers.Find(customer.Id);
                if (model != null)
                {
                    model.Id = customer.Id;
                    model.CustomerId = customer.CustomerId;
                    model.Code = customer.Code;
                    model.Name = customer.Name;
                    model.Address = customer.Address;
                    model.Email = customer.Email;
                    model.Contact = customer.Contact;
                    model.LoyaltyPoint = customer.LoyaltyPoint;
                    model.CategoryId = customer.CategoryId;
                }

                return context.SaveChanges() > 0;
               
            }
        }

        public bool Delete(int id)
        {
            using (var context = new SMSDbContext())
            {
                Customer customer = context.Customers.Find(id);
                context.Customers.Remove(customer);
                return context.SaveChanges() > 0;
            }
        }
        public Customer GetById(int id)
        {
            using (var context = new SMSDbContext())
            {
                return context.Customers.Find(id);
            }
        }

        public List<Customer> GetAll()
        {
            using (var context = new SMSDbContext())
            {
                return context.Customers.ToList();
            }
        }

    }
}
