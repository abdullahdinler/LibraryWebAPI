using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(LibraryDbContext context) : base(context)
        {
        }


        public async Task<List<Author>> GetAuthorWithBook()
        {
            return await _context.Authors.Include(x => x.Books).ToListAsync();
        }
    }
}
