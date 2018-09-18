using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Movie> Movies { get; set; }
    }
}