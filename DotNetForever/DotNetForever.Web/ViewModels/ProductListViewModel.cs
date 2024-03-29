﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetForever.Model.Model;

namespace DotNetForever.Web.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public string Search { get; set; }
    }
}