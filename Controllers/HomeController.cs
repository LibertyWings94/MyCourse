using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCourse.Models;

namespace MyCourse.Controllers
{
    
    public class HomeController : Controller
    {
       
        public HomeController()
        {
        
        }

        public IActionResult Index()
        {
            //return Content("Sono nella index dell'homepage");
            return View();
        }

       
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}