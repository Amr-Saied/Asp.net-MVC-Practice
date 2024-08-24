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
    [Migration("20240819125343_AddBooksImages")]
    partial class AddBooksImages
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
                            ImageUrl = "/images/great-gatsby.jpg",
                            Price = 10.99m,
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "George Orwell",
                            Genre = "Dystopian",
                            ImageUrl = "/images/1984.jpg",
                            Price = 8.99m,
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Harper Lee",
                            Genre = "Classic",
                            ImageUrl = "/images/to-kill-a-mockingbird.jpg",
                            Price = 12.99m,
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Jane Austen",
                            Genre = "Romance",
                            ImageUrl = "/images/pride-and-prejudice.jpg",
                            Price = 9.99m,
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "J.D. Salinger",
                            Genre = "Fiction",
                            ImageUrl = "/images/catcher-in-the-rye.jpg",
                            Price = 11.99m,
                            Title = "The Catcher in the Rye"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "J.R.R. Tolkien",
                            Genre = "Fantasy",
                            ImageUrl = "/images/the-hobbit.jpg",
                            Price = 14.99m,
                            Title = "The Hobbit"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "Herman Melville",
                            Genre = "Adventure",
                            ImageUrl = "/images/moby-dick.jpg",
                            Price = 13.99m,
                            Title = "Moby Dick"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Leo Tolstoy",
                            Genre = "Historical",
                            ImageUrl = "/images/war-and-peace.jpg",
                            Price = 19.99m,
                            Title = "War and Peace"
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Homer",
                            Genre = "Epic",
                            ImageUrl = "/images/the-odyssey.jpg",
                            Price = 15.99m,
                            Title = "The Odyssey"
                        },
                        new
                        {
                            BookId = 10,
                            Author = "Fyodor Dostoevsky",
                            Genre = "Psychological",
                            ImageUrl = "/images/crime-and-punishment.jpg",
                            Price = 17.99m,
                            Title = "Crime and Punishment"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
