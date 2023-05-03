using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Seeds
{
    internal class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
               new User
               {
                   Id = 1,
                   AddressId = 1,
                   FirstName = "User 1",
                   LastName = "User LastName 1",
                   Email = "mail1@mail.com",
                   Phone = "11111111111",
                   Status = "Status 1"
               },
               new User
               {
                   Id = 2,
                   AddressId = 2,
                   FirstName = "User 2",
                   LastName = "User LastName 2",
                   Email = "mail2@mail.com",
                   Phone = "22222222222",
                   Status = "Status 2"
               },
               new User
               {
                   Id = 3,
                   AddressId = 3,
                   FirstName = "User 3",
                   LastName = "User LastName 3",
                   Email = "mail3@mail.com",
                   Phone = "33333333333",
                   Status = "Status 3"
               },
                new User
                {
                    Id = 4,
                    AddressId = 4,
                    FirstName = "User 4",
                    LastName = "User LastName 4",
                    Email = "mail4@mail.com",
                    Phone = "44444444444",
                    Status = "Status 4"
                },
               new
               {
                   Id = 5,
                   AddressId = 5,
                   FirstName = "User 5",
                   LastName = "User LastName 5",
                   Email = "mail5@mail.com",
                   Phone = "55555555555",
                   Status = "Status 5"
               }
            );
        }
    }
}
