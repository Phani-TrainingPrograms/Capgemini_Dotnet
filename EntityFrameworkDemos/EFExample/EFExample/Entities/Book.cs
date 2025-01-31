using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFExample.Entities
{
    [Table("BookTable")]
    public class Book
    {
        [Key]public int BookId { get; set; }
        [Required]public string BookTitle { get; set; }
        [Required]public int BookPrice { get; set; }
        [Required]public string BookAuthor { get; set; }
    }

    [Table("AuthorTable")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public string AuthorEmail { get; set; }
    }


    //This class contains APIs to connect and interact with the specified DB
    class BookDbContext : DbContext
    {
        private readonly string _connectionString;

        public BookDbContext()
        {
            this._connectionString = @"Data Source=PHANI-PC\SQLEXPRESS;Initial Catalog=CapgeminiDb;Integrated Security=True;Encrypt=False";
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(this._connectionString);
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

    }

}
