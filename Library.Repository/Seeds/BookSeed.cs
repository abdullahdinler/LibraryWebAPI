using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Seeds
{
    internal class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Book 1", AuthorId = 1, GenreId = 1, Cover = "Cover 1", Status = "Status 1", DateAdded = DateTime.Now },
                new Book { Id = 2, Title = "Book 2", AuthorId = 2, GenreId = 2, Cover = "Cover 2", Status = "Status 2", DateAdded = DateTime.Now },
                new Book { Id = 3, Title = "Book 3", AuthorId = 3, GenreId = 3, Cover = "Cover 3", Status = "Status 3", DateAdded = DateTime.Now },
                new Book { Id = 4, Title = "Book 4", AuthorId = 4, GenreId = 4, Cover = "Cover 4", Status = "Status 4", DateAdded = DateTime.Now },
                new Book { Id = 5, Title = "Book 5", AuthorId = 5, GenreId = 5, Cover = "Cover 5", Status = "Status 5", DateAdded = DateTime.Now },
                new Book { Id = 6, Title = "Book 6", AuthorId = 1, GenreId = 1, Cover = "Cover 6", Status = "Status 6", DateAdded = DateTime.Now },
                new Book { Id = 7, Title = "Book 7", AuthorId = 2, GenreId = 2, Cover = "Cover 7", Status = "Status 7", DateAdded = DateTime.Now },
                new Book { Id = 8, Title = "Book 8", AuthorId = 3, GenreId = 3, Cover = "Cover 8", Status = "Status 8", DateAdded = DateTime.Now },
                new Book { Id = 9, Title = "Book 9", AuthorId = 4, GenreId = 4, Cover = "Cover 9", Status = "Status 9", DateAdded = DateTime.Now },
                new Book { Id = 10, Title = "Book 10", AuthorId = 5, GenreId = 5, Cover = "Cover 10", Status = "Status 10", DateAdded = DateTime.Now }

            );
        }
    }
}
