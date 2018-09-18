using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class AppContext : DbContext
    {
        public AppContext()
            :base("name=AppConnection")
        {

        }
        public DbSet<Movie> MoviesTable { get; set; }
        public DbSet<Customer> CustomersTable { get; set; }
    }
}