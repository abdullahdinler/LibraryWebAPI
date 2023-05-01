using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs.BookDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IBookService : IService<Book , BookDto>
    {
    }
}
