using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vividly1.Models;
using Vividly1.ViewModels;
namespace Vividly1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Customers()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Cong"},
                new Customer { Name = "Umer"}
            };

            RandomMovieViewModel viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }
    }
}