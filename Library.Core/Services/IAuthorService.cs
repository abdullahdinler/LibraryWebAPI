using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs;
using Library.Core.DTOs.AuthorDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IAuthorService : IService<Author, AuthorDto>
    {
        Task<CustomResponseDto<AuthorDto>> AddAsync(AuthorCreateDto createDto);
        Task<CustomResponseDto<List<AuthorDto>>> AddRangeAsync(AuthorCreateDto createDto);
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(AuthorUpdateDto updateDto);
        Task<CustomResponseDto<List<AuthorWithBookDto>>> GetAuthorWithBook();
    }
}
