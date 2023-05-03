using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Seeds
{
    internal class AuthorSeed : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author
                {
                    Id = 1,
                    FirstName = "Author 1",
                    LastName = "Author LastName 1",
                    
                },
                new Author
                {
                    Id = 2,
                    FirstName = "Author 2",
                    LastName = "Author LastName 2"
                   
                },
                new
                {
                    Id = 3,
                    FirstName = "Author 3",
                    LastName = "Author LastName 3"
                   
                },
                new
                {
                    Id = 4,
                    FirstName = "Author 4",
                    LastName = "Author LastName 4"
                   
                },
                new
                {
                    Id = 5,
                    FirstName = "Author 5",
                    LastName = "Author LastName 5"
                   
                }
            );
            
        }
    }
}
