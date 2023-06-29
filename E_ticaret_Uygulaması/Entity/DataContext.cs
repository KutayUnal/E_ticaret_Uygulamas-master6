using E_ticaret_Uygulaması.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_ticaret_Uygulaması.Entity
{
    public class DataContext:DbContext
    {
        public DataContext():base("dataConntection")
        {
            Database.SetInitializer(new DataInitializer());
            //bu initializeri devreye sokuyoruz
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}