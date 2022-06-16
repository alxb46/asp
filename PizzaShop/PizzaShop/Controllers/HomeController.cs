using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Models;

namespace PizzaShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IWebHostEnvironment _appEnvironment;
    private Context _context;

    public HomeController(ILogger<HomeController> logger, Context context, IWebHostEnvironment appEnvironment)
    {
        _logger = logger;
        _appEnvironment = appEnvironment;
        _context = context;
    }

    [HttpGet]
    [Route("/")]
    public async Task<IActionResult> Menu()
    {
        if (_context != null)
        {
            return View("Home", await _context.Pizzas.Include(p => p.Ingredients).ToListAsync());
        }
        else
        {
            return NotFound();
        }
        
    }

    [Route("/product/{id?}")]
    public async Task<IActionResult> PizzaInfo(int? id)
    {
        if (id == null)
            return NotFound();

        await _context.Pizzas.Include(c => c.Ingredients).LoadAsync();
        await _context.Ingredients.Include(c => c.Pizzas).LoadAsync();

        Pizza? pizza = await _context.Pizzas.FindAsync(id);

        if (pizza == null)
            return NotFound();

        return View("PizzaInfo", pizza);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

