using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs.GenreDTOs;
using Library.Core.Models;

namespace Library.Core.Repositories
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        Task<List<Genre>> GetBookWithGenreIdAsync(int genreId);
        
    }
}
