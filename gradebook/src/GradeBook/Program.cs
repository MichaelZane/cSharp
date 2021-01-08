using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        { 

            var book = new Book("Mike's Grade Book");
            book.AddGrade(88.1);
            book.AddGrade(90.5);
            book.AddGrade(75.1);
            book.ShowStatistics();            

        }
    }
}
