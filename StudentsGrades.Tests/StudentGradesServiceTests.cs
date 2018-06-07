using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentsGrades.Models;
using StudentsGrades.Services;
using System.Collections.Generic;

namespace StudentsGrades.Tests
{
    [TestClass]
    public class StudentGradesServiceTests
    {
        [TestMethod]
        public void Calculate_ShouldReturnCorrectResult()
        {
            //Arrange - utworzenie obiektu, który jest odpowiedzialny za testowany element (wszystkie dane wejœciowe)
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

            //Act - dzia³anie na metodzie/funkcji/klasie testowanej (np. wywo³anie metody)
            var result = serviceUnderTest.Calculate(list);

            //Assert - sprawdzenie, ¿e zwrócone przez akcjê wartoœci s¹ zgodne z oczekiwanymi
            Assert.AreEqual(4.4M, result); //wartoœæ spodziewana, wartoœæ otrzymana
        }

        StudentGradesService serviceUnderTest;

        public StudentGradesServiceTests()
        {
            serviceUnderTest = new StudentGradesService();
        }
    }
}
