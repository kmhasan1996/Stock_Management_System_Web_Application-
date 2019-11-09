using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetForever.Model.Model;
using DotNetForever.Repository.Repository;

namespace DotNetForever.Manager.Manager
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public int GetCount()
        {
            return _categoryRepository.GetCount();
        }
    }
}
