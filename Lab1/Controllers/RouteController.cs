using System.Collections.Generic;
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

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
            if (obj == null || !ModelState.IsValid) RedirectToAction("Index");
            _db.Routes.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? railwayRouteId)
        {
            var obj = _db.Routes.Find(railwayRouteId);

            if (obj == null) return RedirectToAction("Index");

            _db.Routes.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET - EDIT
        public IActionResult Edit(int? railwayRouteId)
        {
            if (railwayRouteId == 0 || railwayRouteId == null) return NotFound();
            var obj = _db.Routes.Find(railwayRouteId);
            if (obj == null) return NotFound();

            return View(obj);
        }


        // POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(RailwayRoute obj)
        {

            if (obj == null || !ModelState.IsValid) return RedirectToAction("Index");
            _db.Routes.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}