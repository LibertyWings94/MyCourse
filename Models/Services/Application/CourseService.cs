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
        public List<CourseViewModel> GetCourses() //Metodo che recupera la lista di tutti i corsi
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

        public CourseDetailViewModel GetCourse(int id) //Metodo che recupera il corso con un id specifico
        {
            var rand = new Random();
            var price = Convert.ToDecimal(rand.NextDouble() * 10 + 10);
            var course = new CourseDetailViewModel
            {
                Id = id,
                Titolo = $"Corso{id}",
                PrezzoScontato = new Money(Currency.EUR, price),
                PrezzoFull = new Money(Currency.EUR, rand.NextDouble() > 0.5 ? price : price - 1),
                Autore = "Paolo Mariano",
                Rating = rand.Next(10,50)/10.0,
                ImgPath = "/logo.svg",
                Descrizione = $"Descrizione {id}",
                Lezioni = new List<LessonViewModel>()
            };

            for (var i = 1; i <= 5; i++)
            {
                var lezione = new LessonViewModel
                {
                    Titolo = $"Lezione {id}",
                    Durata = TimeSpan.FromSeconds(rand.Next(40,90)),
                };

                course.Lezioni.Add(lezione);
            }

            return course;
        }
    }
}