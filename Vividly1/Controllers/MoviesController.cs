using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vividly1.Models;
using Vividly1.ViewModels;
namespace Vividly1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            var customers = new List<Customer>
            {
                new Customer { Name = "Cong"},
                new Customer { Name = "Umer"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ContentResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}