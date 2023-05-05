using AutoMapper;
using Library.Core.DTOs.GenreDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class GenreService : Service<Genre, GenreDto>, IGenreService
    {
        public GenreService(IGenericRepository<Genre> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }
    }
}
