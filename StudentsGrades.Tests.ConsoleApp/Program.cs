using StudentsGrades.Models;
using StudentsGrades.Services;
using System;
using System.Collections.Generic;

namespace StudentsGrades.Test.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Aplikacja do testów manualnych
        /// Oceny 5 w wadze 2 i 4 w wadze 3
        /// ((5x2) + (4x3)) / (2 + 3) = 4,4
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Testy manualne...");

            var list = new List<Grade>
            {
                new Grade
                {
                    Value = 5,
                    Weight = 2
                },
                new Grade
                {
                    Value = 4,
                    Weight = 3
                }

            };

            var studentGradesService = new StudentGradesService();
            var result = studentGradesService.Calculate(list);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
