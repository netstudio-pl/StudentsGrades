using StudentsGrades.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentsGrades.Services
{
    public class StudentGradesService
    {
        /// <summary>
        /// Metoda obliczająca średnią ważoną przekazanej kolekcji ocen studentów
        /// </summary>
        /// <returns></returns>
        public decimal Calculate(IEnumerable<Grade> grades)
        {
            //obliczam średnią ważoną ocen (korzystam z LINQ i lambda)
            var gradesSum = grades.Sum(g => g.Value * g.Weight); //suma iloczynów ocen i ich wag
            return gradesSum / grades.Sum(g => g.Weight); //podzielona przes sumę wag ocen
        }
    }
}
