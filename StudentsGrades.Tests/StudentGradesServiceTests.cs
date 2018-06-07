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
            //Arrange - utworzenie obiektu, kt�ry jest odpowiedzialny za testowany element (wszystkie dane wej�ciowe)
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

            //Act - dzia�anie na metodzie/funkcji/klasie testowanej (np. wywo�anie metody)
            var result = serviceUnderTest.Calculate(list);

            //Assert - sprawdzenie, �e zwr�cone przez akcj� warto�ci s� zgodne z oczekiwanymi
            Assert.AreEqual(4.4M, result); //warto�� spodziewana, warto�� otrzymana
        }

        StudentGradesService serviceUnderTest;

        public StudentGradesServiceTests()
        {
            serviceUnderTest = new StudentGradesService();
        }
    }
}
