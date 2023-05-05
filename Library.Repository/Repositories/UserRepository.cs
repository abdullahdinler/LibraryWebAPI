using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
{
    public class UserRepository : GenericRepository<User> ,IUserRepository
    {
       
        public UserRepository(LibraryDbContext context) : base(context)
        {
           
        }

        public async Task<List<User>> GetUserWithAddress()
        {
            return await _context.Users.Include(x => x.Address).ToListAsync();
        }
    }
}
