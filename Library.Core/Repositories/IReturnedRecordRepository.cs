using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs.ReturnedRecordDTOs;
using Library.Core.Models;

namespace Library.Core.Repositories
{
    public interface IReturnedRecordRepository : IGenericRepository<ReturnedRecord>
    {
        Task<List<ReturnedRecord>> GetReturnedRecordsWithUserIdAsync(int userId);
        Task<List<ReturnedRecord>> GetReturnedRecordsWithBookIdAsync(int bookId);
    }
}
