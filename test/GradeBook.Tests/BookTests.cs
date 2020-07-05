using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrades()
        {
            //arrange my data
            var book=new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act on the behaviours
            var result=book.GetStatisitcs();

            //Assert
            Assert.Equal(85.6,result.Average,1);
            Assert.Equal(90.5,result.High,1);
            Assert.Equal(77.3,result.Low,1);

            //SYMBOLS NOW

            Assert.Equal('B',result.Letter);

            
            
            

        }
    }
}
