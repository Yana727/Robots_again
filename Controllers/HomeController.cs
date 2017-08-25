using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Robots_again.Models;
using System.IO;
using Newtonsoft.Json;
using Robots_again.Services; 

namespace Robots_again.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          var robotList = RobotsServices.Builder(); 
          return View(robotList);
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
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
