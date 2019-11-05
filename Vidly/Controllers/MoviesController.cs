using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity.Validation;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();   
        }
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(c =>c.MovieType).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.MovieType).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFromViewModel
                {
                    Movie = movie,
                    MovieTypes = _context.MovieTypes.ToList()
                };
                return View("MovieForm",viewModel);
            }
                if (movie.Id == 0)
                    _context.Movies.Add(movie);
                else
                {

                    var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                    movieInDb.Name = movie.Name;
                    movieInDb.Producer = movie.Producer;
                    movieInDb.Rainting = movie.Rainting;
                    movieInDb.MovieTypeId = movie.MovieTypeId;
                    movieInDb.AccessAge = movie.AccessAge;
                    movieInDb.Country = movie.Country;
                    movieInDb.Duration = movie.Duration;

                }


                _context.SaveChanges();

                return RedirectToAction("Index", "Movies");
            
            }

        public ActionResult New()
        {
            var movieTypes = _context.MovieTypes.ToList();
            var viewModel = new MovieFromViewModel
            {
                Movie = new Movie(),
                MovieTypes = movieTypes
               
            };
            return View("MovieForm",viewModel);
        }
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }
            var viewModel = new MovieFromViewModel
            {
                Movie = movie,
                MovieTypes = _context.MovieTypes.ToList()

            };
            return View("MovieForm", viewModel);
        }
    }
}
