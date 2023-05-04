using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;

namespace Library.Repository.Repositories
{
    public class UserRepository : GenericRepository<User> ,IUserRepository
    {
        public UserRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
