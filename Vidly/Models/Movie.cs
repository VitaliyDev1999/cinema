using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public MovieType MovieType { get; set; }

        public string Producer { get; set; }

        public short Duration { get; set; }

        public string Country { get; set; }

        public byte AccessAge {get;set;}

        public float Rainting { get;set; }
    }
}