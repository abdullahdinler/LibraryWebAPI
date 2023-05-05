using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Core.DTOs.AddressDTOs
{
    public class AddressWithUserDto : AddressDto
    {
        public List<User> Users { get; set; }
    }
}
