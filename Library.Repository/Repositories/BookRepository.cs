using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }

        public async Task<List<Book>> GetBookWithAuthor()
        {
            return await _context.Books.Include(x => x.Author).ToListAsync();
        }
    }
}
