using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs;
using Library.Core.DTOs.AddressDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IAddressService : IService<Address, AddressDto>
    {
        Task<CustomResponseDto<List<AddressWithUserDto>>> GetAddressWithUser();
        Task<CustomResponseDto<AddressDto>> AddAsync(AddressCreateDto createDto);
        Task<CustomResponseDto<List<AddressDto>>> AddRangeAsync(List<AddressCreateDto> createDtos);
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(AddressUpdateDto updateDto);
    }
}
