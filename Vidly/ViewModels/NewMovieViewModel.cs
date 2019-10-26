using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFromViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<MovieType> MovieTypes { get; set; }
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";

                return "Add Movie";
            }
        }
    }
}