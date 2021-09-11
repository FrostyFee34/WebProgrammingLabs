using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Lab1.Models;

namespace Lab1.Controllers
{
    public class TicketController : Controller
    {
        private readonly RailwayContext _db;

        public TicketController(RailwayContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Ticket> tickets = _db.Tickets;
            return View(tickets);
        }
        // GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Ticket obj)
        {
            _db.Tickets.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
