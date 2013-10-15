using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie : Medium
    {
        public string Director { get; set; }
        /*
        public int ID { get; set; }
        
        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        //[StringLength(15)]
        public string Rating { get; set; }

        // nk ------------------------------------> 
        public int SciFiVotes { get; set;  }
        public int FantasyVotes { get; set; }

        // [DataType(DataType.Url)]
        // nk <-------------------------------------
         */
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}