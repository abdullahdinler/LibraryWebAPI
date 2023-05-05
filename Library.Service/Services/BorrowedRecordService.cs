using AutoMapper;
using Library.Core.DTOs.BorrowedRecordDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class BorrowedRecordService : Service<BorrowedRecord , BorrowedRecordDto> , IBorrowedRecordService
    {
        public BorrowedRecordService(IGenericRepository<BorrowedRecord> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }
    }
}
