using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs.AuthorDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IAuthorService : IService<Author, AuthorDto>
    {
    }
}
