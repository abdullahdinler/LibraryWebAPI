using Library.Core.DTOs.BookDTOs;
using Library.Core.DTOs.GenreDTOs;
using Library.Core.Services;
using Library.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    
    public class GenresController : CustomBaseController
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _genreService.GetAllAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _genreService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(GenreCreateDto dto)
        {
            return CreateActionResult(await _genreService.AddAsync(dto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _genreService.RemoveAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> Update(GenreUpdateDto dto)
        {
            return CreateActionResult(await _genreService.UpdateAsync(dto));
        }

        [HttpGet("[action]/{id:int}")]
        public async Task<IActionResult> GetBookWithGenreId(int id)
        {
            return CreateActionResult(await _genreService.GetBookWithGenreIdAsync(id));
        }

    }
}
