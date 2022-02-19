﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMVC.Models
{
    public class Product
    {
        public int ProductId { get;set }
        public string ProductName { get; set }
        public double Rate { get; set }
        public string Description { get; set }
        public string CategoryName { get; set }
    }
}