using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the movie name")]
        public string Name { get; set; }

        public MovieType MovieType { get; set; }

        [Required(ErrorMessage = "Please choose the ganre")]
        [Display(Name = "Ganre")]
        public byte MovieTypeId { get; set; }


        public string Producer { get; set; }

        [Required(ErrorMessage = "Please enter the duration")]
        public short Duration { get; set; }

       
        public string Country { get; set; }

        
        public byte AccessAge {get;set;}

        [Required(ErrorMessage = "Please enter the rating")]
        public double Rainting { get;set; }
    }
}