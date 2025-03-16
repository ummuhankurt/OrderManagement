using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using OrderManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.Entities.User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= UMMUHANKURT ;Database=OrderManagementDb;Trusted_Connection=true;TrustServerCertificate=True");
        }
    }
}
