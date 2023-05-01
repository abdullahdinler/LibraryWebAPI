using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs.UserDTOs
{
    public class UserCreateDto
    {
        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}
