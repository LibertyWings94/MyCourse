using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.ViewModels;
using MyCourse.Models.ValueTypes;
using MyCourse.Models.Enums;

namespace MyCourse.Models.Services.Applications
{
    public class CourseService
    {
        public List<CourseViewModel> GetCourses()
        {
            var courseList = new List<CourseViewModel>();
            var rand = new Random();

            for (int i = 1; i < 20; i++)
            {
                var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
                var course = new CourseViewModel
                {
                    Id = i,
                    Titolo = $"Corso {i}",
                    Autore = "Paolo Mariano",
                    ImgPath = "/logo.svg",
                    PrezzoFull = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price - 1),
                    PrezzoScontato = new Money(Currency.EUR, price),
                    Rating = rand.Next(10,50)/10.0,
                };

                courseList.Add(course);
            }

            return courseList;
        }
    }
}