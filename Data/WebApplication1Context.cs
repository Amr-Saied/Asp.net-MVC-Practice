using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class WebApplication1Context : IdentityDbContext<IdentityUser>
    {


        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Book> Book { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(

            new Book { BookId = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99m, Genre = "Fiction", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780743273565-L.jpg" },
            new Book { BookId = 2, Title = "1984", Author = "George Orwell", Price = 8.99m, Genre = "Dystopian", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780451524935-L.jpg" },
            new Book { BookId = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 12.99m, Genre = "Classic", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780061120084-L.jpg" },
            new Book { BookId = 4, Title = "Pride and Prejudice", Author = "Jane Austen", Price = 9.99m, Genre = "Romance", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780141439518-L.jpg" },
            new Book { BookId = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 11.99m, Genre = "Fiction", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780316769488-L.jpg" },
            new Book { BookId = 6, Title = "The Hobbit", Author = "J.R.R. Tolkien", Price = 14.99m, Genre = "Fantasy", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780547928227-L.jpg" },
            new Book { BookId = 7, Title = "Moby Dick", Author = "Herman Melville", Price = 13.99m, Genre = "Adventure", ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1605824499i/55953683.jpg" },
            new Book { BookId = 8, Title = "War and Peace", Author = "Leo Tolstoy", Price = 19.99m, Genre = "Historical", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780199232765-L.jpg" },
            new Book { BookId = 9, Title = "The Odyssey", Author = "Homer", Price = 15.99m, Genre = "Epic", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780140268867-L.jpg" },
            new Book { BookId = 10, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Price = 17.99m, Genre = "Psychological", ImageUrl = "https://covers.openlibrary.org/b/isbn/9780140449136-L.jpg" });
            }
    }
}
