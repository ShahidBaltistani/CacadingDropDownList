using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrossTrainingsLab.Models
{
    public class CrossTrainingsLabContext : DbContext
    {
        public CrossTrainingsLabContext() :base("name=con")
        {

        }

        //public DbSet<User> Users { get; set; }
        //public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}