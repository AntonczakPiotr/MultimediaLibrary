using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultimediaLibrary.Models;

namespace MultimediaLibrary.Data
{
    /// <summary>
    /// Mapowanie bazy danych
    /// </summary>
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Supply>().ToTable("Supply");
            modelBuilder.Entity<LibraryCard>().ToTable("LibraryCard");
            modelBuilder.Entity<Activity>().ToTable("Activity");
        }
    }
}
