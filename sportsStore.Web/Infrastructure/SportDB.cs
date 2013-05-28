using sportsStore.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sportsStore.Web.Infrastructure
{
    public class SportDB : DbContext, ISportDataSource
    {
        // You can change the connection string in web.config for that
        public SportDB() : base("DefaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Sport> Sports { get; set; }


        IQueryable<Product> ISportDataSource.Products
        {
            get { return Products; }
        }

        IQueryable<Sport> ISportDataSource.Sports
        {
            get { return Sports; }
        }
    }
}