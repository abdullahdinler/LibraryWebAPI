using Library.Core.DTOs.UserDTOs;
using Library.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
   
    public class UsersController : CustomBaseController
    {
       private readonly IUserService _userService;

       public UsersController(IUserService userService)
       {
           _userService = userService;
       }
       [HttpGet]
       public async Task<IActionResult> GetAll()
       {
           return CreateActionResult(await _userService.GetAllAsync());

       }

       [HttpGet("{id:int}")]
       public async Task<IActionResult> GetById(int id)
       {
           return CreateActionResult(await _userService.GetByIdAsync(id));
       }

       [HttpPost]
       public async Task<IActionResult> Save(UserCreateDto dto)
       {
           return CreateActionResult(await _userService.AddAsync(dto));
       }

       [HttpDelete("{id}")]
       public async Task<IActionResult> Remove(int id)
       {
           return CreateActionResult(await _userService.RemoveAsync(id));
       }

       [HttpPut]
       public async Task<IActionResult> Update(UserWithAddressDto dto)
       {
           return CreateActionResult(await _userService.UpdateAsync(dto));
       }

       [HttpGet("[action]")]
       public async Task<IActionResult> GetUserWithAddress()
       {
           return CreateActionResult(await _userService.GetUserWithAddress());
       }
    }
}
