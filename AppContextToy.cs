using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace shop
{
    class AppContextToy:DbContext
    {
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderOfToy> OrderOfToys { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public AppContextToy() : base("DbConnStr") { }
    }
}