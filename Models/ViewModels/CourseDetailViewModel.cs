using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCourse.Models.ViewModels
{
    public class CourseDetailViewModel: CourseViewModel //classe che estende l'entità corso aggiungendo descrizione e lista di lezioni nella pagina dettaglio
    {
        public string Descrizione { get; set; }
        public List<LessonViewModel> Lezioni { get; set; }

    }
}