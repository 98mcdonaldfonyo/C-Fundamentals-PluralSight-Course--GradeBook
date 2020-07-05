using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
         static void OnGradeAdded(object sender, EventArgs e)
          {
            Console.WriteLine("A Grade was Added ");
          }
        static void Main(string[] args)
        {
            var book = new Book("Mc D's Book");        
            book.GradeAdded += OnGradeAdded;//?multicast delegate
            EnterGrades(book);

            //    book.AddGrade(89.1);
            //    book.AddGrade(90.5);
            //    book.grades.Add(77.5);
            //We need a loop that will allow the user to type in grades and when Q is pressed, the program has to stop

            var stats = book.GetStatisitcs();
            Console.WriteLine(Book.CATREGORY);
            Console.WriteLine($"For the book named : {book.Name}");
            Console.WriteLine($"The low value is :{stats.Low}");
            Console.WriteLine($"The High value is :{stats.High}");
            Console.WriteLine($"The Sum value is :{stats.Sum}");
            Console.WriteLine($"The Aver value is :{stats.Average}");
        }
        public static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Please enter your grades below or letter q to quit");
                var input = Console.ReadLine();
                if (input.Equals("q"))
                {
                    break;
                }
                try
                {
                    var grade = Convert.ToDouble(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)

                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Wrong Format , try again : {ex.Message}");
                }

                finally
                {
                    Console.WriteLine("Show me this regardless !");
                }
            }
        }
    }
}

 

            
  
