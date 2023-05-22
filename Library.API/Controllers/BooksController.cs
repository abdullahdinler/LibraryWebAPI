using Library.Core.DTOs.AddressDTOs;
using Library.Core.DTOs.BookDTOs;
using Library.Core.Services;
using Library.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{

    public class BooksController : CustomBaseController
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _bookService.GetAllAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _bookService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(BookCreateDto dto)
        {
            return CreateActionResult(await _bookService.AddAsync(dto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _bookService.RemoveAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> Update(BookUpdateDto dto)
        {
            return CreateActionResult(await _bookService.UpdateAsync(dto));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBookWithAuthor()
        {
            return CreateActionResult(await _bookService.GetBookWithAuthorAsync());
        }
    }
}
