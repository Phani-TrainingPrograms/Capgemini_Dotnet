using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using EFCodeFirstApp.Entities; //Contains the Models of our data. 

namespace EFCodeFirstApp.Data
{
    public class BookAuthorDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string strCon = @"Data Source=PHANI-PC\SQLEXPRESS;Initial Catalog=CapgeminiDb;Integrated Security=True;Encrypt=False";
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(strCon);
        }

        
    }
}
