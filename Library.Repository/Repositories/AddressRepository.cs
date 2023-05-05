using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(LibraryDbContext context) : base(context)
        {
        }

        public async Task<List<Address>> GetAddressWithUserAsync()
        {
            return await _context.Addresses.Include(x => x.Users).ToListAsync();
        }
    }
}
