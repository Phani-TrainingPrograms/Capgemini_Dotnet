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
            var book = _context.Books.FirstOrDefault((b) =>b.BookId == id);
            if(book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Book not found to delete");
            }
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public void UpdateBook(Book book)
        {
            var found = _context.Books.FirstOrDefault((b) => b.BookId == book.BookId);
            if(found != null)
            {
                found.Title = book.Title;
                found.Price = book.Price;   
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Book not found to update");
            }
        }
    }
}
