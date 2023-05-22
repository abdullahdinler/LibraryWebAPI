using Library.Core.DTOs.BorrowedRecordDTOs;
using Library.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
   
    public class BorrowedRecordsController : CustomBaseController
    {
        private readonly IBorrowedRecordService _borrowedRecordService;

        public BorrowedRecordsController(IBorrowedRecordService borrowedRecordService)
        {
            _borrowedRecordService = borrowedRecordService;
        }

        [HttpGet]
        public async Task<IActionResult> GeAll()
        {
            return CreateActionResult(await _borrowedRecordService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _borrowedRecordService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(BorrowedRecordCreateDto dto)
        {
            return CreateActionResult(await _borrowedRecordService.AddAsync(dto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(BorrowedRecordUpdateDto dto)
        {
            return CreateActionResult(await _borrowedRecordService.UpdateAsync(dto));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _borrowedRecordService.RemoveAsync(id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBorrowedRecordsWithBook()
        {
            return CreateActionResult(await _borrowedRecordService.GetBorrowedRecordsWithBookAsync());
        }

        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetBorrowedRecordsWithUserId(int id)
        {
            return CreateActionResult(await _borrowedRecordService.GetBorrowedRecordsWithUserIdAsync(id));
        }
    }
}
