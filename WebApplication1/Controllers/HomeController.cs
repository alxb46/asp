using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string digit, string digit2, string sing)
        {

            if (sing == "+")
            {
                ViewData["Result"] = int.Parse(digit) + int.Parse(digit2);
            }
            else if (sing == "-")
            {
                ViewData["Result"] = int.Parse(digit) - int.Parse(digit2);
            }
            else if (sing == "*")
            {
                ViewData["Result"] = int.Parse(digit) * int.Parse(digit2);
            }
            else if (sing == "/")
            {
                if(digit2 == "0")
                {
                    ViewData["Result"] = "Ошибка. Нельзя делить на ноль";
                }
                else
                {
                    ViewData["Result"] = int.Parse(digit) / int.Parse(digit2);
                }
              
            }

            return View("Results");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
