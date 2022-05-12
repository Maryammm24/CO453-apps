using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppss.Models;
using ConsoleAppProject.App02;

namespace WebAppss.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DistanceConverter()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BMICalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMICalculator(BMI bmi)
        {
            return View();
        }

        public IActionResult HealthMessage()
        {
            return View();
        }

        public IActionResult StudentMarks()
        {
            return View();
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
}
