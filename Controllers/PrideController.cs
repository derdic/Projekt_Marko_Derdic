using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class PrideController : Controller
    {
        public IActionResult ListPride()
        {
            return View();
        }
        public IActionResult DetailsPride()
        {
            return View();
        }
    }
}
