using EFCodeFirstApp.Data;
using EFCodeFirstApp.Entities;
using EFCodeFirstApp.Repositories;
using EFCodeFirstApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

namespace EFCodeFirstApp.ConsoleUi
{
    //Console App needs to include DI package from Nuget:Microsoft.Extensions.DependencyInjection. 
    internal class Program
    {
        private static ServiceProvider ConfigureServices()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<BookAuthorDbContext>()
                .AddScoped<IBookRepository, BookRepository>()
                .AddScoped<BookService>()
                .BuildServiceProvider();
            return serviceProvider;
        }
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            var bookservice = serviceProvider.GetRequiredService<BookService>();
            //bookservice.AddBook(new Entities.Book
            //{
            //    Title = "Oliver Twist",
            //    Price = 350,
            //    BookAuthors = new List<BookAuthor>
            //    {
            //        new BookAuthor{ Author = new Author { AuthorName = "Charles Dickens" } 
            //        }
            //    }
            //});
            var books = bookservice.GetAllBooks();
            foreach(var book in books)
            {
                Console.WriteLine($"Title: {book.Title}");
                foreach(var bkAu in book.BookAuthors)
                {
                    Console.WriteLine($"Author: {bkAu.Author.AuthorName}");
                }
            }
        }
    }
}
