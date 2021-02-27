using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class NorthwindContext :DbContext
    {
        //Veri tabanı ve nesnelerimizi ilişkilendirdiğimiz alan
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //String başına @ işareti de konulabilir
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Personel> Personels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("dbo");
            //farklı şemalar için de bu tarz kullanılabilir (çift parametre) 
            modelBuilder.Entity<Personel>().ToTable("Employees", "dbo");
            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");
        }
    }
}
