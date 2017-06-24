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
        public ActionResult Random()
        {
            var movie1 = new Movie() { ID = 1 ,Name = "Captain Fantastic" };
            var customers = new List<Customers>()
            {
                new Customers{ Name = "Hesen"},
                new Customers{ Name = "Ismayil"},
                new Customers{ Name = "Vuqar"},
                new Customers{ Name = "Ilham"},
                new Customers{ Name = "Etibar"}

            };
            var viewModel = new RandomMovieViewModels
            {
                movie = movie1,
                customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }

        //Movies
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content($"{pageIndex} --> {sortBy}");
        }
        

        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month );
        }
    }
}