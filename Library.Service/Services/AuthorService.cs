using AutoMapper;
using Library.Core.DTOs;
using Library.Core.DTOs.AuthorDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class AuthorService : Service<Author, AuthorDto>, IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IGenericRepository<Author> repository, IUnitOfWork unitOfWork, IMapper mapper, IAuthorRepository authorRepository) : base(repository, unitOfWork, mapper)
        {
            _authorRepository = authorRepository;
        }

        public async Task<CustomResponseDto<AuthorDto>> AddAsync(AuthorCreateDto createDto)
        {
            var entity = _mapper.Map<Author>(createDto);
            await _authorRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<AuthorDto>(entity);
            return CustomResponseDto<AuthorDto>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<List<AuthorDto>>> AddRangeAsync(AuthorCreateDto createDto)
        {
            var entities = _mapper.Map<Author>(createDto);
            await _authorRepository.AddAsync(entities);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<List<AuthorDto>>(entities);
            return CustomResponseDto<List<AuthorDto>>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(AuthorUpdateDto updateDto)
        {
            var entity = _mapper.Map<Author>(updateDto);
            _authorRepository.Update(entity);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<List<AuthorWithBookDto>>> GetAuthorWithBook()
        {
            var entities = await _authorRepository.GetAuthorWithBook();
            var newDto = _mapper.Map<List<AuthorWithBookDto>>(entities);
            return CustomResponseDto<List<AuthorWithBookDto>>.Success(newDto, 200);
        }
    }
}
