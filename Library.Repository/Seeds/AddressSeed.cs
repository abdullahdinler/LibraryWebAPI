using Library.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Repository.Seeds
{
    internal class AddressSeed : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
                new Address { Id = 1, Addres = "Ev adresi 1" },
                new Address { Id = 2, Addres = "Ev adresi 2" },
                new Address { Id = 3, Addres = "Ev adresi 3" },
                new Address { Id = 4, Addres = "Ev adresi 4" },
                new Address { Id = 5, Addres = "Ev adresi 5" },
                new Address { Id = 6, Addres = "Ev adresi 6" },
                new Address { Id = 7, Addres = "Ev adresi 7" },
                new Address { Id = 8, Addres = "Ev adresi 8" },
                new Address { Id = 9, Addres = "Ev adresi 9" },
                new Address { Id = 10, Addres = "Ev adresi 10" },
                new Address { Id = 11, Addres = "Ev adresi 11" },
                new Address { Id = 12, Addres = "Ev adresi 12" },
                new Address { Id = 13, Addres = "Ev adresi 13" },
                new Address { Id = 14, Addres = "Ev adresi 14" },
                new Address { Id = 15, Addres = "Ev adresi 15" }
            );
        }
    }
}
