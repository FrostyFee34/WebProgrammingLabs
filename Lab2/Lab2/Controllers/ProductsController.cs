using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly WarehouseContext _db;

        public ProductsController(WarehouseContext db)
        {
            _db = db;
        }
        // GET: ProductsController
        public ActionResult Index()
        {
            IEnumerable<Product> products = _db.Products.Include(x => x.WarehouseCell);
            return View(products);
        }


        // GET: ProductsController/Create
        public ActionResult Create()
        {
            
            ViewData["cells"] = _db.WarehouseCells.ToList();
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
