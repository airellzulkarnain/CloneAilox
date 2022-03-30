using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60,MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        [RegularExpression(@"^[A-Z]+[A-Za-z\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; } = string.Empty;
        [Range(20_000, 100_000), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; } = string.Empty;
    }
}
