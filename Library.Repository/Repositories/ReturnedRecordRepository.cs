using Library.Core.Models;
using Library.Core.Repositories;
using Library.Repository.Context;

namespace Library.Repository.Repositories
{
    public class ReturnedRecordRepository : GenericRepository<ReturnedRecord>, IReturnedRecordRepository
    {
        public ReturnedRecordRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
