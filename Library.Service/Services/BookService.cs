using AutoMapper;
using Library.Core.DTOs;
using Library.Core.DTOs.BookDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class BookService : Service<Book, BookDto>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IGenericRepository<Book> repository, IUnitOfWork unitOfWork, IMapper mapper, IBookRepository bookRepository) : base(repository, unitOfWork, mapper)
        {
            _bookRepository = bookRepository;
        }

        public async Task<CustomResponseDto<List<BookWithAuthorDto>>> GetBookWithAuthorAsync()
        {
            var entities = await _bookRepository.GetBookWithAuthor();
            var newDto = _mapper.Map<List<BookWithAuthorDto>>(entities);
            return CustomResponseDto<List<BookWithAuthorDto>>.Success(newDto, 200);
        }

        public async Task<CustomResponseDto<BookDto>> AddAsync(BookCreateDto createDto)
        {
            var entity = _mapper.Map<Book>(createDto);
            await _bookRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<BookDto>(entity);
            return CustomResponseDto<BookDto>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<List<BookDto>>> AddRange(List<BookCreateDto> createDtos)
        {
            var entities = _mapper.Map<List<Book>>(createDtos);
            await _bookRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<List<BookDto>>(entities);
            return CustomResponseDto<List<BookDto>>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(BookUpdateDto updateDto)
        {
            var entity = _mapper.Map<Book>(updateDto);
            _bookRepository.Update(entity);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }
    }
}
