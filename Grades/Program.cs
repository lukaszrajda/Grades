using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new GradeBook();

            book.AddGrade(80);
            book.AddGrade(79.5f);
            book.AddGrade(56);

            var stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average grade",stats.AverageGrade);
            WriteResult("Lowest grade",stats.LowestGrade);
            WriteResult("Highest grade",stats.HighestGrade);
            WriteResult("Grade", stats.LetterGrade);
            Console.ReadLine();
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}
