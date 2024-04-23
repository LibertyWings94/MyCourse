using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Models.ViewModels
{
    public class LessonViewModel
    {
        public string Titolo { get; set; }
        public TimeSpan Durata { get; set; }

        public TimeSpan TotalCourseDuration
        {
            get => TimeSpan.FromSeconds(Lessons?.Sum(l => l.Duration.TotalSeconds) ?? 0);
        }
    }
}