using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Models;


namespace Shop.Controllers
{
    public class AdidasController : Controller
    {
        private readonly AppDbContext _db;
        public AdidasController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult ListAdidas()
        {
            return View();
        }

    }
}
