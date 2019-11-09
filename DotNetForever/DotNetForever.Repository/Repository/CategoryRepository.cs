using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetForever.DatabaseContext.DatabaseContext;
using DotNetForever.Model.Model;

namespace DotNetForever.Repository.Repository
{
    public class CategoryRepository
    {
        public List<Category> GetAll()
        {
            using (var context = new SMSDbContext())
            {
                return context.Categories.ToList();

            }
        }
        public int GetCount()
        {
            using (var context = new SMSDbContext())
            {
                return context.Categories.Count();
            }
        }
    }
}
