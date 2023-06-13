using EFCoreExamples.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExamples.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(local); Database=EcommerceDB; Trusted_Connection=true;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
