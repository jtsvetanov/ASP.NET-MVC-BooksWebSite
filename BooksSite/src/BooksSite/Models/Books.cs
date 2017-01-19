using System;
using System.ComponentModel.DataAnnotations;

namespace BooksSite.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string Title { get; set; }

        //setting up the display for the date
        [Display(Name = "Date Acquired")]
        [DataType(DataType.Date)]
        //setting up format for Date
       // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
