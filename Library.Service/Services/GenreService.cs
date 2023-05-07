using AutoMapper;
using Library.Core.DTOs;
using Library.Core.DTOs.GenreDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class GenreService : Service<Genre, GenreDto>, IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        public GenreService(IGenericRepository<Genre> repository, IUnitOfWork unitOfWork, IMapper mapper, IGenreRepository genreRepository) : base(repository, unitOfWork, mapper)
        {
            _genreRepository = genreRepository;
        }

        public async Task<CustomResponseDto<List<GenreWithBookDto>>> GetBookWithGenreIdAsync(int genreId)
        {
            var entities = await _genreRepository.GetBookWithGenreIdAsync(genreId);
            var newDto = _mapper.Map<List<GenreWithBookDto>>(entities);
            return CustomResponseDto<List<GenreWithBookDto>>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<GenreDto>> AddAsync(GenreCreateDto createDto)
        {
            var entity = _mapper.Map<Genre>(createDto);
            await _genreRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<GenreDto>(entity);
            return CustomResponseDto<GenreDto>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<List<GenreDto>>> AddRangeAsync(List<GenreCreateDto> createDtos)
        {
            var entities = _mapper.Map<List<Genre>>(createDtos);
            await _genreRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<List<GenreDto>>(entities);
            return CustomResponseDto<List<GenreDto>>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(GenreUpdateDto updateDto)
        {
            var entity = _mapper.Map<Genre>(updateDto);
            _genreRepository.Update(entity);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }
    }
}
