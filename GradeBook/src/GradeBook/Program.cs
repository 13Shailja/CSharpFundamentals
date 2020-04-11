using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("The new student's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();
            Console.WriteLine($"Lowest Grade : {stats.Low}");
            Console.WriteLine($"Highest Grade : {stats.High}");
            Console.WriteLine($"Average : {stats.Average}" );
        }
    }
}
 