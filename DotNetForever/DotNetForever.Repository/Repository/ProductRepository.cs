﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DotNetForever.DatabaseContext.DatabaseContext;
using DotNetForever.Model.Model;

namespace DotNetForever.Repository.Repository
{
    public class ProductRepository
    {
        #region Singleton
        //public static ProductRepository Instance
        //{
        //    get
        //    {
        //        if (ProductRepositoryInstance == null)  ProductRepositoryInstance = new ProductRepository() ;

        //        return ProductRepositoryInstance;
        //    }
        //}
        //private static ProductRepository ProductRepositoryInstance { get; set; }

        //private ProductRepository() { }

        #endregion

        public bool Add(Product product)
        {
            using (var context=new SMSDbContext())
            {
                context.Products.Add(product);
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(Product product)
        {
            using (var context=new SMSDbContext())
            {
                Product model=new Product();
                model = context.Products.Find(product.Id);

                if (model!=null)
                {
                    model.Id = product.Id;
                    model.CategoryId = product.CategoryId;
                    model.Code = product.Code;
                    model.Name = product.Name;
                    model.RecorderLevel = product.RecorderLevel;
                    model.Description = product.Description;
                }
               

                return context.SaveChanges() > 0;
                 //return true;
            }
        }

        public bool Delete(int id)
        {
            using (var context = new SMSDbContext())
            {
                Product product = context.Products.Find(id);
                context.Products.Remove(product);
                return context.SaveChanges() > 0;
            }
        }
        public Product GetById(int id)
        {
            using (var context = new SMSDbContext())
            {
                return context.Products.Find(id);
            }
        }

        public List<Product> GetAll()
        {
            using (var context = new SMSDbContext())
            {
                return context.Products.Include(x => x.Category).ToList();

                //return context.Products.Where(x=>x.Id>9).Include(x=>x.Category).ToList();
            }
        }

        public List<Product> Search(string search)
        {
            using (var context = new SMSDbContext())
            {
                return context.Products.Where(x=>(x.Name.ToLower().Contains(search.ToLower()) || x.Code.Contains(search) || x.Category.Name.Contains(search) )).Include(x => x.Category).ToList();

               
            }
        }

        public int GetCount()
        {
            using (var context=new SMSDbContext())
            {
                return context.Products.Count();
            }
        }

    }
}
