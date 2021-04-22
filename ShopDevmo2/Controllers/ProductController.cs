using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopDevmo2.Models;

namespace ShopDevmo2.Controllers
{
    public class ProductController : Controller
    {
        ShopDbContext db = new ShopDbContext();
        // GET: Shop
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category);
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}