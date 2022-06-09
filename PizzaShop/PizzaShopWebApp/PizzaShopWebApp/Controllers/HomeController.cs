﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShopWebApp.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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
            ViewData["PizzaId"] = id-1;
            // return View("InfoProduct", db.PizzaIngredients.ToList());
            List<Pizza> pizzas = db.Pizzas.Include(p => p.Ingredients).ToList();
            return View("InfoProduct", pizzas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
