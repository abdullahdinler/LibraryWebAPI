using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Seeds
{
    internal class GenreSeed : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre { Id = 1, Name = "Genre 1" },
                new Genre { Id = 2, Name = "Genre 2" },
                new Genre { Id = 3, Name = "Genre 3" },
                new Genre { Id = 4, Name = "Genre 4" },
                new Genre { Id = 5, Name = "Genre 5" }
            );
        }
    }
}
