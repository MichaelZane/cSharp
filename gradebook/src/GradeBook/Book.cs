using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book 
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void ShowStatistics()
        {
           var result = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;
            foreach(var number in grades)
            {
                // if(number > highestGrade) {
                //     highestGrade = number;
                // }
                lowestGrade = Math.Min(number, lowestGrade);
                highestGrade = Math.Max(number, highestGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowestGrade}");
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The highest grade is {highestGrade} "); 
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        //List<double> grades = new List<double>();
        private List<double> grades;
        private string name;
        
    }
}