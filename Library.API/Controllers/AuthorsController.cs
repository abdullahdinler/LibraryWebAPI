using Library.Core.DTOs.AuthorDTOs;
using Library.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
   
    public class AuthorsController : CustomBaseController
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _authorService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _authorService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(AuthorCreateDto dto)
        {
            return CreateActionResult(await _authorService.AddAsync(dto));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _authorService.RemoveAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> Update(AuthorUpdateDto dto)
        {
            return CreateActionResult(await _authorService.UpdateAsync(dto));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAuthorWithBook()
        {
            return CreateActionResult(await _authorService.GetAuthorWithBook());
        }
    }
}
