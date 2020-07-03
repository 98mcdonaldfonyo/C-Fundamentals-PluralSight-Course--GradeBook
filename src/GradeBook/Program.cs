using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           var book =new Book("Mc D");
           
           book.AddGrade(89.1);
           book.AddGrade(90.5);
           book.grades.Add(77.5);

           var stats=  book.GetStatisitcs();
           Console.WriteLine($"The low value is :{stats.Low}");
           Console.WriteLine($"The High value is :{stats.High}");
           Console.WriteLine($"The Sum value is :{stats.Sum}");
           Console.WriteLine($"The Aver value is :{stats.Average}");

    
        } 

            
    }    
}

