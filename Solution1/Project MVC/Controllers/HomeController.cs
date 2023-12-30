using Microsoft.AspNetCore.Mvc;
using Project_MVC.Models;
using System.Diagnostics;

namespace Project_MVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {   
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
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
