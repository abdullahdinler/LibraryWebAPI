using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs.AddressDTOs;
using Library.Core.Models;

namespace Library.Core.DTOs.UserDTOs
{
    public class UserWithAddressDto : UserDto
    {
        public AddressDto Address { get; set; }
    }
}
