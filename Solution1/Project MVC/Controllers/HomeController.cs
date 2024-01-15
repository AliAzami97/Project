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

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }


        //[HttpPost]
        //public JsonResult Contact(IFormCollection Form)
        //{
        //    var name = Form["name"];
        //    return Json(Ok());
        //}

        [HttpPost]
        public JsonResult Contact(Contact Form)
        {
            Console.WriteLine(Form.ToString());
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
