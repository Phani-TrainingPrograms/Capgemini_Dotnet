using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstApp.Entities
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string AuthorName { get; set; } = string.Empty;

        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    }

    public class BookAuthor
    {
        [Key]
        public int EntryId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; } = new Book();
        public int AuthorId { get; set; }
        public Author Author { get; set; } = new Author();
    }

    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]public string Title { get; set; }
        [Required]public int Price { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    }
}