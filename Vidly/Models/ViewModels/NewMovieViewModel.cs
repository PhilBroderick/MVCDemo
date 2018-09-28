using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "The field Number in Stock must be between 1 and 20.")]
        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
        
        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        public string Title
        {
            get
            {
                return (Id != 0) ? "Edit Movie" : "New Movie";
            }
        }

        public NewMovieViewModel()
        {
            Id = 0;
        }
        public NewMovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}