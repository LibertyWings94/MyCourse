using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCourse.Models.Services.Applications;
using MyCourse.Models.ViewModels;

namespace MyCourse.Controllers
{
   
    public class CoursesController : Controller
    {
        

        public CoursesController()
        {
            
        }

        public IActionResult Index() //Metodo che deve recuperare la List di tutti i corsi
        {
            var courseService = new CourseService(); //Invocazione del servizio
            List<CourseViewModel> courses = courseService.GetCourses(); //Metodo che ritorna la lista di tutti i corsi
            return View(courses);
        }

        public IActionResult Detail(string id) //Metodo che deve recuperare info corsi che hanno id come parametro
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}