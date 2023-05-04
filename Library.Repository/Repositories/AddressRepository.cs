using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;

namespace Library.Repository.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
