using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetForever.Manager.Manager;
using DotNetForever.Model.Model;

namespace DotNetForever.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager _productManager=new ProductManager();
            SupplierManager _supplierManager = new SupplierManager();

            //Add
            Product product = new Product()
            {
                CategoryId = 1,
                Code = "0002",
                Name = "Samsung Note5",
                RecorderLevel = 25,
                Description = "Android Mobile"

<<<<<<< HEAD
=======
            //Add
            Product product = new Product()
            {
                CategoryId = 1,
                Code = "0002",
                Name = "Samsung Note5",
                RecorderLevel = 25,
                Description = "Android Mobile"

>>>>>>> bacbe437f093f4f8f7232a231230350ac90aba10
            };

            Console.WriteLine(_productManager.Add(product) ? "Saved" : "Not Saved");



            ////Update
            //Product product = new Product()
            //{
            //    Id = 4,
            //    CategoryId = 1,
            //    Code = "0001",
            //    Name = "LG V30",
            //    RecorderLevel = 30,
            //    Description = "Android Mobile"

            //};

            //Console.WriteLine(_productManager.Update(product) ? "Updated" : "Not Updated");






            //Delete
            //Console.WriteLine(_productManager.Delete(3) ? "Deleted" : "Not Deleted");





            ////GetById
            //Product model = new Product();

            //model = _productManager.GetById(4);

            //if (model != null)
            //{
            //    Console.WriteLine("Record Found");

            //    Console.WriteLine("Code: " + model.Code + "\nName: " + model.Name + "\nReorderLevel: " + model.RecorderLevel + "\nDescription: " + model.Description);
            //}
            //else
            //{
            //    Console.WriteLine("No Records Found");
            //}








            //GetAll
            //List<Product> products = new List<Product>();

            //products = _productManager.GetAll();
            //if (products.Count > 0)
            //{
            //    Console.WriteLine("Records Found");
            //    foreach (var item in products)
            //    {
            //        Console.WriteLine("Id: "+item.Id+"\nCode: " + item.Code + "\nName: " + item.Name + "\nReorderLevel: " + item.RecorderLevel + "\nDescription: " + item.Description+"\n");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No Records Found");
            //}






            Console.ReadKey();
        }
    }
}
