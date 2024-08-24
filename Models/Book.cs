using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(50, ErrorMessage = "Author cannot be longer than 50 characters")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 1000.00, ErrorMessage = "Price must be between 0.01 and 1000.00")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [StringLength(50, ErrorMessage = "Genre cannot be longer than 50 characters")]
        public string Genre { get; set; }

        [Url(ErrorMessage = "Please enter a valid URL")]
        public string ImageUrl { get; set; }
    }
}
