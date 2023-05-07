using AutoMapper;
using Library.Core.DTOs;
using Library.Core.DTOs.ReturnedRecordDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class ReturnedRecordService : Service<ReturnedRecord, ReturnedRecordDto>, IReturnedRecordService
    {
        private readonly IReturnedRecordRepository _returnedRecordRepository;
        public ReturnedRecordService(IGenericRepository<ReturnedRecord> repository, IUnitOfWork unitOfWork, IMapper mapper, IReturnedRecordRepository returnedRecordRepository) : base(repository, unitOfWork, mapper)
        {
            _returnedRecordRepository = returnedRecordRepository;
        }

        public async Task<CustomResponseDto<List<ReturnedRecordWithUser>>> GetReturnedRecordsWithUserIdAsync(int userId)
        {
            var entity = _returnedRecordRepository.GetReturnedRecordsWithUserIdAsync(userId);
            var dto = _mapper.Map<List<ReturnedRecordWithUser>>(entity);
            return CustomResponseDto<List<ReturnedRecordWithUser>>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<List<ReturnedRecordWithBook>>> GetReturnedRecordsWithBookIdAsync(int bookId)
        {
            var entity = await _returnedRecordRepository.GetReturnedRecordsWithBookIdAsync(bookId);
            var dto = _mapper.Map<List<ReturnedRecordWithBook>>(entity);
            return CustomResponseDto<List<ReturnedRecordWithBook>>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<ReturnedRecordCreateDto>> AddAsync(ReturnedRecordCreateDto createDto)
        {
            var entity = _mapper.Map<ReturnedRecord>(createDto);
            await _returnedRecordRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            var dto = _mapper.Map<ReturnedRecordCreateDto>(entity);
            return CustomResponseDto<ReturnedRecordCreateDto>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<List<ReturnedRecordCreateDto>>> AddRangeAsync(List<ReturnedRecordCreateDto> createDtos)
        {
            var entities = _mapper.Map<List<ReturnedRecord>>(createDtos);
            await _returnedRecordRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            var dto = _mapper.Map<List<ReturnedRecordCreateDto>>(entities);
            return CustomResponseDto<List<ReturnedRecordCreateDto>>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<NoContentDto>> UpdateAsync(ReturnedRecordUpdateDto updateDto)
        {
            var entity = _mapper.Map<ReturnedRecord>(updateDto);
            _returnedRecordRepository.Update(entity);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }
    }
}
