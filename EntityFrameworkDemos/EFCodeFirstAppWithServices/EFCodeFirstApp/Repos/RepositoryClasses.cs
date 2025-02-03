using EFCodeFirstApp.Data;
using EFCodeFirstApp.Entities;

namespace EFCodeFirstApp.Repositories
{
    public interface IBookRepository
    {
        void AddNewBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(Book book); 
        List<Book> GetAllBooks();
    }

    public class BookRepository : IBookRepository
    {
        private readonly BookAuthorDbContext _context;

        public BookRepository(BookAuthorDbContext context)
        {
            this._context = context;
        }

        public void AddNewBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}