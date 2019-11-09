using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetForever.Manager.Manager;
using DotNetForever.Web.ViewModels;

namespace DotNetForever.Web.Controllers
{
    public class HomeController : Controller
    {
        ProductManager _productManager=new ProductManager();
        CategoryManager _categoryManager=new CategoryManager();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SideMenu()
        {

            SideMenuViewModel model=new SideMenuViewModel();
            model.ProductCount = _productManager.GetCount();
            model.CategoryCount = _categoryManager.GetCount();
            return PartialView("_SideMenu", model);
        }
    }
}