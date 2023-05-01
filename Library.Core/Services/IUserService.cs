using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs.UserDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IUserService : IService<User, UserDto>
    {
    }
}
