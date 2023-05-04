using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;

namespace Library.Repository.Repositories
{
    public class GenreRepository : GenericRepository<Genre> , IGenreRepository
    {
        public GenreRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
