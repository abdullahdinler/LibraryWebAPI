using Library.Core.DTOs.BorrowedRecordDTOs;
using Library.Core.DTOs.ReturnedRecordDTOs;
using Library.Core.Services;
using Library.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    
    public class ReturnedRecordsController : CustomBaseController
    {
        private readonly IReturnedRecordService _returnedRecordService;

        public ReturnedRecordsController(IReturnedRecordService returnedRecordService)
        {
            _returnedRecordService = returnedRecordService;
        }


        [HttpGet]
        public async Task<IActionResult> GeAll()
        {
            return CreateActionResult(await _returnedRecordService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _returnedRecordService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ReturnedRecordCreateDto dto)
        {
            return CreateActionResult(await _returnedRecordService.AddAsync(dto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ReturnedRecordUpdateDto dto)
        {
            return CreateActionResult(await _returnedRecordService.UpdateAsync(dto));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _returnedRecordService.RemoveAsync(id));
        }

        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetReturnedRecordsWithBookId(int id)
        {
            return CreateActionResult(await _returnedRecordService.GetReturnedRecordsWithBookIdAsync(id));
        }

        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetReturnedRecordsWithUserId(int id)
        {
            return CreateActionResult(await _returnedRecordService.GetReturnedRecordsWithUserIdAsync(id));
        }
    }
}
