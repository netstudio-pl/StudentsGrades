using StudentsGrades.Models;
using StudentsGrades.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace StudentsGrades.Tests.xUnit
{
    public class StudentGradesServiceTests
    {
        [Fact]
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
            Assert.Equal(4.4M, result); //warto�� spodziewana, warto�� otrzymana
        }

        StudentGradesService serviceUnderTest;

        public StudentGradesServiceTests()
        {
            serviceUnderTest = new StudentGradesService();
        }
    }
}
