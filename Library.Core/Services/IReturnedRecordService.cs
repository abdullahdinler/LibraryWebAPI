using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs;
using Library.Core.DTOs.ReturnedRecordDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IReturnedRecordService : IService<ReturnedRecord, ReturnedRecordDto>
    {
        Task<CustomResponseDto<List<ReturnedRecordWithUser>>> GetReturnedRecordsWithUserIdAsync(int userId);
        Task<CustomResponseDto<List<ReturnedRecordWithBook>>> GetReturnedRecordsWithBookIdAsync(int bookId);
        Task<CustomResponseDto<ReturnedRecordCreateDto>> AddAsync(ReturnedRecordCreateDto createDto);
        Task<CustomResponseDto<List<ReturnedRecordCreateDto>>> AddRangeAsync(List<ReturnedRecordCreateDto> createDtos);
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(ReturnedRecordUpdateDto updateDto);
    }
}
