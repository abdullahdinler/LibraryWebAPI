using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs;
using Library.Core.DTOs.BorrowedRecordDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IBorrowedRecordService : IService<BorrowedRecord, BorrowedRecordDto>
    {
        Task<CustomResponseDto<List<BorrowedRecordWithBookDto>>> GetBorrowedRecordsWithBookAsync();
        Task<CustomResponseDto<List<BorrowedRecordWithBookDto>>> GetBorrowedRecordsWithUserIdAsync(int userId);
        Task<CustomResponseDto<BorrowedRecordDto>> AddAsync(BorrowedRecordCreateDto createDto);
        Task<CustomResponseDto<List<BorrowedRecordDto>>> AddRange(List<BorrowedRecordCreateDto> createDtos);
        Task<CustomResponseDto<NoContentDto>> Update(BorrowedRecordUpdateDto updateDto);
    }
}
