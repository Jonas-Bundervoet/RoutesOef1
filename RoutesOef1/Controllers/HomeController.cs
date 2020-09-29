using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoutesOef1.Models;

namespace RoutesOef1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowId(int id)
        {
            return Content($"You wanted id: {id}", "text/plain");
        }
        [Route("home/search/{id:int}")]
        public IActionResult SearchById(int id)
        {
            return Content($"You searched for product id {id}");
        }
        [Route("home/search/{name}")]
        public IActionResult SearchByProductName(string name)
        {
            return Content($"You searched for product name: {name}");
        }
        [Route("home/search/{id:int}/{name}")]
        public IActionResult ShowUserInfo(int id, string name)
        {
            return Content($"UserId: {id}\nUsername: {name}", "text/plain");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
