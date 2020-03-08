using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // double[] numbers = new double[] {12.7, 14.8, 15.9};
            // var numbers = new[] {12.7, 14.8, 15.9, 4.1};

            var grades = new List<double>() { 12.7, 14.8, 15.9, 4.1 };
            var sum = 0.0;

            foreach(double number in grades)
            {
                sum += number;
            }

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
                Console.WriteLine(sum);
                Console.WriteLine($"Average : {sum/grades.Count:N1}" );
            }
            else
            {
                System.Console.WriteLine("Hello!");
            }
        }
    }
}
 