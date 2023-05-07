using Library.Core.DTOs;
using Library.Core.DTOs.GenreDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IGenreService : IService<Genre, GenreDto>
    {
        Task<CustomResponseDto<List<GenreWithBookDto>>> GetBookWithGenreIdAsync(int genreId);
        Task<CustomResponseDto<GenreDto>> AddAsync(GenreCreateDto createDto);
        Task<CustomResponseDto<List<GenreDto>>> AddRangeAsync(List<GenreCreateDto> createDtos);
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(GenreUpdateDto updateDto);
    }
}
