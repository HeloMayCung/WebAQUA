using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebThuySinh.Models
{
    public class AQUADBContext : DbContext
    {
        public AQUADBContext() : base("MyConnectionString") { }
        public DbSet<Customers> Customers { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<ProcessingOrders> ProcessingOrders { get; set; }

        public DbSet<Catagories> Catagories { get; set; }

        public DbSet<Products> Products { get; set; }
    }
}