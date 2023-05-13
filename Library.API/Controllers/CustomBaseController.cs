using Library.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> dto)
        {
            if (dto.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = dto.StatusCode
                };
            }
            return new ObjectResult(dto)
            {
                StatusCode = dto.StatusCode
            };
        }
    }
}
