using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Context
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Assembly (Library.Repository) içinde olan veya yazdığımız tüm configuration bulup uygulanmasını sağlar.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowedRecord> BorrowedRecords { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public ReturnedRecord ReturnedRecord { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
