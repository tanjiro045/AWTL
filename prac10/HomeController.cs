using Microsoft.AspNetCore.Mvc;
using Practical10A.Models;
using System.Diagnostics;

namespace Practical10A.Controllers
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
            Student stud = new Student()
            {
                Id = 1,
                Name = "Sunny",
                Subject = "CS",
                Degree = "MCA"
            };
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student stud)
        {
            return View("DisplayData", stud);
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