﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(WebApplication1Context))]
    [Migration("20240820103302_AddedSearchingViewModel_1")]
    partial class AddedSearchingViewModel_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "F. Scott Fitzgerald",
                            Genre = "Fiction",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780743273565-L.jpg",
                            Price = 10.99m,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "George Orwell",
                            Genre = "Dystopian",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780451524935-L.jpg",
                            Price = 8.99m,
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Harper Lee",
                            Genre = "Classic",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780061120084-L.jpg",
                            Price = 12.99m,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Jane Austen",
                            Genre = "Romance",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780141439518-L.jpg",
                            Price = 9.99m,
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "J.D. Salinger",
                            Genre = "Fiction",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780316769488-L.jpg",
                            Price = 11.99m,
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "J.R.R. Tolkien",
                            Genre = "Fantasy",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780547928227-L.jpg",
                            Price = 14.99m,
                            Title = "The Hobbit"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "Herman Melville",
                            Genre = "Adventure",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1605824499i/55953683.jpg",
                            Price = 13.99m,
                            Title = "Moby Dick"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Leo Tolstoy",
                            Genre = "Historical",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780199232765-L.jpg",
                            Price = 19.99m,
                            Title = "War and Peace"
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Homer",
                            Genre = "Epic",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780140268867-L.jpg",
                            Price = 15.99m,
                            Title = "The Odyssey"
                        },
                        new
                        {
                            BookId = 10,
                            Author = "Fyodor Dostoevsky",
                            Genre = "Psychological",
                            ImageUrl = "https://covers.openlibrary.org/b/isbn/9780140449136-L.jpg",
                            Price = 17.99m,
                            Title = "Crime and Punishment"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
