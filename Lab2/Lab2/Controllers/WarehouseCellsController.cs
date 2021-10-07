using System.Collections.Generic;
using System.Linq;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class WarehouseCellsController : Controller
    {
        private readonly WarehouseContext _db;

        public WarehouseCellsController(WarehouseContext db)
        {
            _db = db;
        }

        // GET: WarehouseCellsController
        public ActionResult Index()
        {
            IEnumerable<WarehouseCell> cells = _db.WarehouseCells;
            return View(cells);
        }


        // GET: WarehouseCellsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WarehouseCellsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WarehouseCell cell)
        {
            _db.WarehouseCells.Add(cell);
            _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

      
    }
}