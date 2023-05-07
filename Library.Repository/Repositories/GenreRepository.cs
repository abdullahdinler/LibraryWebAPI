using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository.Repositories
{
    public class GenreRepository : GenericRepository<Genre> , IGenreRepository
    {
        public GenreRepository(LibraryDbContext context) : base(context)
        {
        }

        public async Task<List<Genre>> GetBookWithGenreIdAsync(int genreId)
        {
            return await _context.Genres.Include(g => g.Books).Where(g => g.Id == genreId).ToListAsync();
        }
    }
}
