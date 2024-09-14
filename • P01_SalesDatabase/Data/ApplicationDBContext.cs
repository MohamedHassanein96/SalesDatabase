using __P01_SalesDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __P01_SalesDatabase.Data
{
    internal class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SalesDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>()
             .Property(b => b.Name)
             .HasMaxLength(50)
             .IsUnicode(true);

        
            modelBuilder.Entity<Customer>()
             .Property(b => b.Name)
             .HasMaxLength(100)
             .IsUnicode(true);


            modelBuilder.Entity<Customer>()
             .Property(b => b.Email)
             .HasMaxLength(80)
             .IsUnicode(true);


            modelBuilder.Entity<Store>()
             .Property(b => b.Name)
             .HasMaxLength(80)
             .IsUnicode(true);

        }

    }
}
