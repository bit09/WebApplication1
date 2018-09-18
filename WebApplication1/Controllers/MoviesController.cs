using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie{Name = "Shrek"},
                new Movie{Name = "Gladiator"},
                new Movie{Name = "Titanic"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movie
            };

            return View(viewModel);
        }

        public ActionResult CustomerList()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Jonas Jonaitis"},
                new Customer {Name = "Petras Petraitis"},
                new Customer {Name = "Kazys Kaziukaitis"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}