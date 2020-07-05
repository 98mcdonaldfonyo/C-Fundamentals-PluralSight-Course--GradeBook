using System.Collections.Generic;
using System;
namespace GradeBook
{
        public delegate void GradeAddedDelegate(object sender,EventArgs args);
       
       public class NamedObject
       {
        public NamedObject(string name)
        {
            Name = name;
        }
          public string Name
            {
                get;
                 set;
            }
       }
       public class Book: NamedObject
        {

           private List<double> grades;
            
            
            public const string CATREGORY="IT";

            public Book(string name):base (name)
            {
            //catergory="";
            grades=new List<double>(); 
            Name=name;
            }

            public void AddGrade(char letter)
            {
                switch(letter)
                {
                    case 'A':
                    AddGrade(90);
                    break;

                    case 'B':
                    AddGrade(80);
                    break;


                    case 'C':
                    AddGrade(70);
                    break;

                    default: //do this when the above cases don't seem to apply
                    AddGrade(0);
                    break;
                }
            }
            public void AddGrade(double grade)
            {
                 if(grade<=100 && grade>=0 )
                {
                    grades.Add(grade);
                    if(GradeAdded!=null)
                    {

                        GradeAdded(this,new EventArgs());

                    }          
                }
                else
                {
                  throw new ArgumentException($"Invalid format {nameof(grade)}");
                }           
            }
            public event  GradeAddedDelegate GradeAdded;
             static void OnGradeAdded(object sender, EventArgs e)
          {
            Console.WriteLine("A Grade was Added ");
          }
            public Statistics GetStatisitcs()//made the class as the type for test purposes
            {
                char[] Letters=new char[]{'A','B','c','D','F'};
                var result =new Statistics();//have to create an object of the class with properties
                result.Average=0.0;
                result.Sum=0.0;
                // List <double> grades;
                result.High = double.MinValue;
                result.Low=double.MaxValue;

                for( var index=0;index<grades.Count;index++)
                {

                    result.High=Math.Max(grades[index], result.High);
                    result.Low=Math.Min(grades[index],result.Low);
                    result.Sum+=grades[index];
                }

                result.Average=result.Sum/grades.Count;
                
                switch(result.Average)
                {

                case var d when d>=90.0:
                result.Letter=Letters[0];
                break;

                case var d when d>=80.0:
                result.Letter=Letters[1];
                break;

                case var d when d>=70.0:
                result.Letter=Letters[2];
                break;

                case var d when d>=60.0:
                result.Letter=Letters[3];
                break;         

                 default :
                result.Letter=Letters[4];
                break;


                }
                return result;
            }

        }
}