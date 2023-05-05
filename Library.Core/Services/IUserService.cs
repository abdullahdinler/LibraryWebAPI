using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs;
using Library.Core.DTOs.UserDTOs;
using Library.Core.Models;

namespace Library.Core.Services;

public interface IUserService : IService<User, UserDto>
{
    Task<CustomResponseDto<List<UserWithAddressDto>>> GetUserWithAddress();
    Task<CustomResponseDto<NoContentDto>> UpdateAsync(UserUpdateDto updateDto);
    Task<CustomResponseDto<UserDto>> AddAsync(UserCreateDto addDto);
    Task<CustomResponseDto<List<UserDto>>> AddRangeAsync(List<UserCreateDto> addDtos);
}

