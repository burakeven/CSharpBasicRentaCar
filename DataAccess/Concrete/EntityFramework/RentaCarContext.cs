using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Bu bölüm projeyi veritabanı ile ilişkilendirdiğimiz alandır.
    public class RentaCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentaCar;Trusted_Connection=true;" ); //database'i tanımladık
        }
        public DbSet<Car> Cars { get; set; } //Cars tablosuyla benim yazdığım Car nesnesini eşitledim.
        public DbSet<Brand> Brands { get; set; } //Brands tablosuyla benim yazdığım Brand nesnesini eşitledim.
        public DbSet<Color> Colors { get; set; } // Colors tablosuyla Color nesnesini eşitledim.
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
