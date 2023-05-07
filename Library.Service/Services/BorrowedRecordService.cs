using AutoMapper;
using Library.Core.DTOs;
using Library.Core.DTOs.BorrowedRecordDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class BorrowedRecordService : Service<BorrowedRecord, BorrowedRecordDto>, IBorrowedRecordService
    {
        private readonly IBorrowedRecordRepository _borrowedRecordRepository;
        public BorrowedRecordService(IGenericRepository<BorrowedRecord> repository, IUnitOfWork unitOfWork, IMapper mapper, IBorrowedRecordRepository borrowedRecordRepository) : base(repository, unitOfWork, mapper)
        {
            _borrowedRecordRepository = borrowedRecordRepository;
        }

        public async Task<CustomResponseDto<List<BorrowedRecordWithBookDto>>> GetBorrowedRecordsWithBookAsync()
        {
            var entities = await _borrowedRecordRepository.GetBorrowedRecordsWithBookAsync();
            var newDto = _mapper.Map<List<BorrowedRecordWithBookDto>>(entities);
            return CustomResponseDto<List<BorrowedRecordWithBookDto>>.Success(newDto, 200);
        }

        public async Task<CustomResponseDto<List<BorrowedRecordWithBookDto>>> GetBorrowedRecordsWithUserIdAsync(int userId)
        {
            var entity = await _borrowedRecordRepository.GetBorrowedRecordsWithUserIdAsync(userId);
            var newDto = _mapper.Map<List<BorrowedRecordWithBookDto>>(entity);
            return CustomResponseDto<List<BorrowedRecordWithBookDto>>.Success(newDto, 200);
        }

        public async Task<CustomResponseDto<BorrowedRecordDto>> AddAsync(BorrowedRecordCreateDto createDto)
        {
            var entity = _mapper.Map<BorrowedRecord>(createDto);
            await _borrowedRecordRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<BorrowedRecordDto>(entity);
            return CustomResponseDto<BorrowedRecordDto>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<List<BorrowedRecordDto>>> AddRange(List<BorrowedRecordCreateDto> createDtos)
        {
            var entities = _mapper.Map<List<BorrowedRecord>>(createDtos);
            await _borrowedRecordRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            var newDto = _mapper.Map<List<BorrowedRecordDto>>(entities);
            return CustomResponseDto<List<BorrowedRecordDto>>.Success(newDto, 201);
        }

        public async Task<CustomResponseDto<NoContentDto>> Update(BorrowedRecordUpdateDto updateDto)
        {
            var entity = _mapper.Map<BorrowedRecord>(updateDto);
            _borrowedRecordRepository.Update(entity);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }
    }
}
