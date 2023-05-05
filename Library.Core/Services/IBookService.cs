using Library.Core.DTOs;
using Library.Core.DTOs.BookDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IBookService : IService<Book , BookDto>
    {
        Task<CustomResponseDto<List<BookWithAuthorDto>>> GetBookWithAuthorAsync();
        Task<CustomResponseDto<BookDto>> AddAsync(BookCreateDto createDto);
        Task<CustomResponseDto<List<BookDto>>> AddRange(List<BookCreateDto> createDtos);
        Task<CustomResponseDto<NoContentDto>> Update(BookUpdateDto updateDto);
    }
}
