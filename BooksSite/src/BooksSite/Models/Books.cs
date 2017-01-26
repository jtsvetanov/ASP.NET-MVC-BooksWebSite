using System;
using System.ComponentModel.DataAnnotations;

namespace BooksSite.Models
{
    public class Books
    {
        public int ID { get; set; }

        //adding build in validation
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        //setting up the display for the date
        [Display(Name = "Date Acquired")]
        [DataType(DataType.Date)]
        //[Display(Name = "Release Date"), DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //setting up format for Date
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        //requirenment the genre to start with cap letter
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
