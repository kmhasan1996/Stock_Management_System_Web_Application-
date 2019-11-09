﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetForever.DatabaseContext.DatabaseContext;
using DotNetForever.Model.Model;

namespace DotNetForever.Repository.Repository
{
    public class SupplierRepository
    {
        public bool Add(Supplier supplier)
        {
            using (var context = new SMSDbContext())
            {
                context.Suppliers.Add(supplier);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(Supplier supplier)
        {
            using (var context = new SMSDbContext())
            {
                Supplier model = new Supplier();
                model = context.Suppliers.Find(supplier.Id);

                if (model != null)
                {
                    model.Id = supplier.Id;
                    model.Code = supplier.Code;
                    model.Name = supplier.Name;
                    model.Address = supplier.Address;
                    model.Email = supplier.Email;
                    model.Contact = supplier.Contact;
                    model.ContactPerson = supplier.ContactPerson;
                   
                }


                return context.SaveChanges() > 0;
                //return true;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new SMSDbContext())
            {
                Supplier supplier = context.Suppliers.Find(id);
                context.Suppliers.Remove(supplier);
                return context.SaveChanges() > 0;
            }
        }
        public Supplier GetById(int id)
        {
            using (var context = new SMSDbContext())
            {
                return context.Suppliers.Find(id);
            }
        }

        public List<Supplier> GetAll()
        {
            using (var context = new SMSDbContext())
            {
                return context.Suppliers.ToList();
            }
        }
    }
}
