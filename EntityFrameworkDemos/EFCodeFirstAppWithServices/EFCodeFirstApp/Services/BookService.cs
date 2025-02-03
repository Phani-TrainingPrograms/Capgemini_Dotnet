using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstApp.Entities;
using EFCodeFirstApp.Repositories;
namespace EFCodeFirstApp.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository repo)
        {
            this._bookRepository = repo;
        }

        public void AddBook(Book book)
        {
            //Check for any business constraints. 
            this._bookRepository.AddNewBook(book);
        }

        public void RemoveBook(Book book) =>
            this._bookRepository.DeleteBook(book.BookId);


        public List<Book> GetAllBooks() => this._bookRepository.GetAllBooks();
        
        public void UpdateBook(Book book) =>this._bookRepository.UpdateBook(book); 
    }
}
