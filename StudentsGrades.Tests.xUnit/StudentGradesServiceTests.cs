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
            Assert.Equal(4.4M, result); //wartoœæ spodziewana, wartoœæ otrzymana
        }

        StudentGradesService serviceUnderTest;

        public StudentGradesServiceTests()
        {
            serviceUnderTest = new StudentGradesService();
        }
    }
}
