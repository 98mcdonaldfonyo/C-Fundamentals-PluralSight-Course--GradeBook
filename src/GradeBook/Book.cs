using System.Collections.Generic;
using System;
namespace GradeBook
{

        public class Book
        {
            public List<double> grades;
            public string Name;
            public Book(string Name)
            {
            grades=new List<double>(); 
            this.Name=Name;
            }


            public void AddGrade(double grade)
            {

            grades.Add(grade);

            }
            public Statistics GetStatisitcs()//made the class as the type for test purposes
            {
                var result =new Statistics();//have to create an object of the class with properties
                result.Average=0.0;
                result.Sum=0.0;
                // List <double> grades;
                result.High = double.MinValue;
                result.Low=double.MaxValue;
                foreach (var number in grades)
                {
                    result.High=Math.Max(number, result.High);
                    result.Low=Math.Min(number,result.Low);
                    result.Sum+=number;
                }
                result.Average=result.Sum/grades.Count;

                for (int i = 0; i < grades.Count; i++)
                   {
                    result.Sum +=grades[i]; 
                   }
                return result;
            }



        }


}