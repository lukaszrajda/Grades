using System;
using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        private List<float> gradesList = new List<float>
            {
                60,
                70,
                88.8f
            };

        [TestMethod]
        public void ComputesHighestGrade()
        {
            
            var book = new GradeBook();
            foreach (var grade in gradesList)
            {
                book.AddGrade(grade);
            }
            var stats = book.ComputeStatistics();
            Assert.AreEqual(88.8f, stats.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {

            var book = new GradeBook();
            foreach (var grade in gradesList)
            {
                book.AddGrade(grade);
            }
            var stats = book.ComputeStatistics();
            Assert.AreEqual(60, stats.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {

            var book = new GradeBook();
            foreach (var grade in gradesList)
            {
                book.AddGrade(grade);
            }
            var stats = book.ComputeStatistics();
            Assert.AreEqual(72.93, stats.AverageGrade, 0.01);
        }
    }
}
