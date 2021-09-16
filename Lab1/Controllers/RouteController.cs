using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Controllers
{
    public class RouteController : Controller
    {
        private readonly RailwayContext _db;


        public RouteController(RailwayContext db)
        {
           _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<RailwayRoute> routes = _db.Routes;
            return View(routes);
        }
        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RailwayRoute obj)
        {
            _db.Routes.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
       
        public IActionResult Delete(int? id)
        {
            var obj = _db.Routes.Find(id);

            if (obj == null) return RedirectToAction("Index");

            _db.Routes.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
