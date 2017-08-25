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
    public class ProfileController : Controller
    {
        public IActionResult Index(int Id)
        {
            var robotList = RobotsServices.Builder();
            return View(robotList[Id -1]);
        }
    } 
}