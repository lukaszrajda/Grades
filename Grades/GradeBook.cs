using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        private List<float> grades;
        public string Name;

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            var stats = new GradeStatistics();
            var sum = 0f;
            foreach(var grade in grades)
            {
                stats.HighestGrade = Math.Max(stats.HighestGrade, grade);
                stats.LowestGrade = Math.Min(stats.LowestGrade, grade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count();
            return stats;
        }
    }
}
