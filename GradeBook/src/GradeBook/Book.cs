using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        // double[] numbers = new double[] {12.7, 14.8, 15.9};
        // var numbers = new[] {12.7, 14.8, 15.9, 4.1};
        public string Name { get; set; }
        List<double> grades;
        // public List<double> Grades { get => grades; set => grades = value; }
        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }
        public void AddGrade(double grade) => grades.Add(grade);

        public Statistics GetStatistics()
        {
            var stats = new Statistics();
            stats.Average = 0.0;
            stats.High = Double.MinValue;
            stats.Low = Double.MaxValue;
            var sum = 0.0;

            foreach (var grade in grades)
            {
                stats.Low = Math.Min(grade, stats.Low);
                stats.High = Math.Max(grade, stats.High);
                sum += grade;
            }
            stats.Average = sum/grades.Count;
            return stats;
        }
    }
}