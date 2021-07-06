using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        PizzaContext db;
        public HomeController(PizzaContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Pizzas.ToList());
        }

        [HttpGet]
        public IActionResult Show(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            return View("InfoProduct");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
