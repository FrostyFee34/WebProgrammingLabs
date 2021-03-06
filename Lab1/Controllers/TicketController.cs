using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lab1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        private readonly RailwayContext _db;

        public TicketController(RailwayContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Ticket> tickets = _db.Tickets.Include(x => x.Route);
            return View(tickets);
        }

        // GET - CREATE
        public async Task<IActionResult> Create(int? railwayRouteId)
        {
            var user = HttpContext.User;
            if (railwayRouteId == null) return RedirectToAction("Index");
            var route = await _db.Routes.FindAsync(railwayRouteId);
            var ticket = new Ticket {RailwayRouteId = (int) railwayRouteId, Route = route};
            return View(ticket);
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket obj)
        {
            var user = HttpContext.User;
            if (obj == null || !ModelState.IsValid) return RedirectToAction("Index");
            _db.Tickets.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? ticketId)
        {
            var obj = _db.Tickets.Find(ticketId);

            if (obj == null) return RedirectToAction("Index");

            _db.Tickets.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}