using EmployeeSystem.Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSystem.Persistence
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
                empID int
                empName nchar(50)
                empTitle nchar(50)
                empSalary float
                empEmail nchar(50)
                empBirthDate date
                empPhoto varbinary(MAX)
                CountryID int
            */

            modelBuilder.Entity<Employee>()
                .Property(e => e.Id)
                .HasColumnName("empID");

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasColumnName("empName")
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Title)
                .HasColumnName("empTitle")
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasColumnName("empSalary");

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .HasColumnName("empEmail")
                .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                .Property(e => e.BirthDate)
                .HasColumnName("empBirthDate");

            modelBuilder.Entity<Employee>()
                .Property(e => e.Photo)
                .HasColumnName("empPhoto");


            /*
                CountryID int
                CountryName nchar(50)
                CountryCode Ncahr(2)
             */
            modelBuilder.Entity<Country>()
               .Property(c => c.Id)
               .HasColumnName("CountryID");

            modelBuilder.Entity<Country>()
               .Property(c => c.CountryName)
               .HasColumnName("CountryName")
               .HasMaxLength(50);

            modelBuilder.Entity<Country>()
                .Property(c => c.CountryCode)
                .HasColumnName("CountryCode")
                .HasMaxLength(2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
