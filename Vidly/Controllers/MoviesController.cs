using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //Возращаемый тип метода может быть ViewResult проще при Юнит тестах
        public ActionResult Random()
        {
          
            var movies = new List<Movie>
            {
              new Movie{Id=1,Name="Sherk"},
              new Movie{Id=2,Name="Harry Poter"},
              new Movie{Id=3,Name="Avengers"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movies
                
            };
            
            //return RedirectToAction("Index","Home", new { page = 1, sortBy = "name" });
            //return new EmptyResult();
            //return HttpNotFound();
            //return Content("Hellow World");
            return View(viewModel);
            //return new ViewResult(); 
        }

        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }

        //movies метод с необязательными параметрами (нужно чтобы переменные были NUll 
        //стриинг без значения по учмолчанию равен NUll
        public ActionResult Index(int? pageIndex , string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }

        //public ActionResult ByReleasedDate(int year, int month) => Content("year=" + year + "/month=" + month);
        //Attribute rounting один из вариантов кастомного роутинга
        [Route("movies/released/{year}/{month:regex(//d{2}):range(1,12)}")]
        public ActionResult ReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        //public ActionResult ReleaseDate(int? year , int? month)
        //{
        //    if (!year.HasValue)
        //    {
        //        year = 2019;
        //    }
        //    if (!month.HasValue)
        //    {
        //        month = 1;
        //    }
        //    return Content(String.Format(year + "/"+month));
        //}
        public ActionResult Entry(DateTime entryDate)
        {
            string date = entryDate.ToString();
            return Content(String.Format("entrydate={0}",date));
        }
    }
}