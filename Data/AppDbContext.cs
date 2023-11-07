using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }

        private string dbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            dbPath = System.IO.Path.Join(path, "contacts.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite($"Data Source={dbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactEntity>().HasData(
                new ContactEntity() { ContactId = 1, Name = "Adam", Email = "adam@wsei.edu.pl", Phone = "127813268163", Birth = new DateTime(2000, 10, 10), Priority = 1 },
                new ContactEntity() { ContactId = 2, Name = "Ewa", Email = "ewa@wsei.edu.pl", Phone = "293443823478", Birth = new DateTime(1999, 8, 10), Priority = 2 }
            );

            modelBuilder.Entity<EmployeeEntity>().HasData(
                new EmployeeEntity() { EmployeeId = 1, Pesel = "12345678900", Name = "Adam", Surname = "Kowalski", Position = 0, Department = 0, EmploymentDate = new DateTime(2000, 10, 10), SackingDate = new DateTime(2000, 10, 30), },
                new EmployeeEntity() { EmployeeId = 2, Pesel = "00987654321", Name = "Ewa", Surname = "Nowak", Position = 1, Department = 1, EmploymentDate = new DateTime(1999, 8, 10), SackingDate = new DateTime(2003, 8, 9) }
            );
        }
    }
}
