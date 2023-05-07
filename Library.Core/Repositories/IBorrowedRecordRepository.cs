using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Core.Repositories
{
    public interface IBorrowedRecordRepository : IGenericRepository<BorrowedRecord>
    {
        Task<List<BorrowedRecord>> GetBorrowedRecordsWithBookAsync();
        Task<List<BorrowedRecord>> GetBorrowedRecordsWithUserIdAsync(int userId);
    }
}
