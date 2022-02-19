using ProductMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductMVC.Controllers
{
    static IList<Product> ProductList = new List<Product>
    {
        new Product() { ProductId = 101, ProductName = "Harry Potter", Rate = 10.00, Description = "descA", CategoryName = "Books"},
        new Product() { ProductId = 102, ProductName = "Percy Jackson", Rate = 20.00, Description = "descB", CategoryName = "Books"},
        new Product() { ProductId = 103, ProductName = "Pen", Rate = 30.00, Description = "descC", CategoryName = "Stationary"},
        new Product() { ProductId = 104, ProductName = "Marker", Rate = 30.00, Description = "descD", CategoryName = "Stationary"}
    };
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}