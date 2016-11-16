﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{

    //public int Id { get; set; }
    //public string Name { get; set; }

    //public DateTime ReleaseDate { get; set; }
    //public Genre Genre { get; set; }
    //public byte GenreId { get; set; }

    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage ="Please select genre for the list.")]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required(ErrorMessage ="Please indicate how many in stock.")]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}