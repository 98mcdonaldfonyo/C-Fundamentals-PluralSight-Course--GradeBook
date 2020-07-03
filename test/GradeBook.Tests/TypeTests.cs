using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
        var x= GetInt();
        setInt(ref x);
        Assert.Equal(42,x);//when we pass by value, we get 3 but when we pass by ref we ger 42
            
        }

        private void setInt( ref int x)
        {
            x=42;
        }
        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void StringBehaveLikeValueTypes()
        {
        String name = "McDonald";
       var  upper= MakeUpercase(name);
        Assert.Equal("McDonald",name);
        Assert.Equal("MCDONALD",upper);

        }

        private string MakeUpercase(string param)
        {
            return param.ToUpper();
        }

        [Fact]
         public void CSharpIsPassByRef()
        {           
         var book1= GetBook("Book 1");
         GetBookSetName(ref book1,"New Name");//a type out can be used for Refs
         Assert.Equal("New Name",book1.Name);
        }
        private void GetBookSetName(ref Book book, string name)
        {
           book =new Book(name);
           book.Name=name;
        }
        [Fact]
         public void CSharpIsPassByValue()
        {           
         var book1= GetBook("Book 1");
         GetBookSetName(book1,"New Name");
         Assert.Equal("Book 1",book1.Name);
        }
        private void GetBookSetName(Book book, string name)
        {
           book =new Book(name);
           book.Name=name;
        }



        [Fact]
         public void CanSetNameFromRef()
        {           
         var book1= GetBook("Book 1");
         SetName(book1,"New Book Name");
         Assert.Equal("New Book Name",book1.Name);
        }
        private void SetName(Book book1, string name)
        {
           book1.Name=name;
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {
                      
         var book1= GetBook("Book 1");
         var book2= GetBook("Book 2");
         var book3= GetBook("Book 3");
         var book4= GetBook("Book 4");

         Assert.Equal("Book 1",book1.Name);
         Assert.Equal("Book 2",book2.Name);
         Assert.Equal("Book 3",book3.Name);
         Assert.Equal("Book 4",book4.Name);
         Assert.NotSame(book1,book2);
         
        }
         [Fact]
        public void TwoVarCanRefSameObject()
        {
                      
         var book1= GetBook("Book 1");
         var book2= book1;
         

         Assert.Equal("Book 1",book1.Name);
         Assert.Equal("Book 1",book2.Name);
         //since the object 1 ref object 2
         Assert.Same(book1,book2);
         Assert.True(Object.ReferenceEquals(book1,book2));//values in these variables point to same objects 
  
         
        }

         Book GetBook(String name)
        {
           return new Book(name);
        } 
    
   }
}
