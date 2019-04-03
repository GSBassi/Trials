using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random/1

        public ActionResult Index()
        {
            var movies = GetMovies();
            
            return View(movies);
        }

        //public ActionResult Random()
        //{

        //    var movie = new Movie() { Name = "Shrek" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer{Name="Smith" },
        //        new Customer{Name="Steven"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {

        //        Movie = movie,
        //        Customers = customers

        //    };
            
        //    return View(viewModel);
        //}

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}