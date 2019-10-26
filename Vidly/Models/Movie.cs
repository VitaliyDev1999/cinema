using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public MovieType MovieType { get; set; }

        [Required]
        [Display(Name = "Ganre")]
        public byte MovieTypeId { get; set; }

        [Required]
        public string Producer { get; set; }

        [Required]
        public short Duration { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public byte AccessAge {get;set;}

        [Required]
        public float Rainting { get;set; }
    }
}