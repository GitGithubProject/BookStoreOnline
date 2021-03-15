using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class ApplicationDbContext : DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        
        public DbSet<Product> Products { get; set; }

        //This change is enough for Entity Framework Core to create a database migration that will allow Order
        //objects to be stored in the database
        public DbSet<Order> Orders { get; set; }
    }
}
