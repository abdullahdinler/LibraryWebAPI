using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs;
using Library.Core.Models;

namespace Library.Core.Repositories
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        Task<List<Author>> GetAuthorWithBook();
    }
}
