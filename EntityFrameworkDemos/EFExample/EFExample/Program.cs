using EFExample.Entities;

namespace EFExample
{
    //For connecting to SQL server using EF, we need 3 Nuget Packages
    //Microsoft.EntityFrameworkCore
    //Microsoft.EntityFrameworkCore.SqlServer
    //Microsoft.EntityFrameworkCore.Tools

    internal class Program
    {
        //create a function that takes 2 args: int and string
        //The Function should display the string the int no of times. 

        
        static void Main(string[] args)
        {
            //Windows specific APIs dont work in .NET. 
            //ADO.NET does not run in .NET CORE directly. 
            //Call the function here. 

            var context = new BookDbContext();
            //context.Books.Add(new Book { BookTitle = "First Book Example", BookAuthor = "Phaniraj", BookPrice = 500 });
            //context.SaveChanges();

            var book = context.Books.Where(b =>  b.BookId == 1).FirstOrDefault();
            context.Books.Remove(book);
 //           book.BookTitle = "Professional C#";
            context.SaveChanges();
        }
    }
}
