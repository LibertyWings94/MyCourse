using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCourse.Models.ValueTypes;

namespace MyCourse.Models.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string ImgPath { get; set; }
        public string Autore { get; set; }
        public double Rating { get; set; }
        public Money PrezzoFull { get; set; }
        public Money PrezzoScontato { get; set; }
    }
}