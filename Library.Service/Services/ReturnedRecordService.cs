using AutoMapper;
using Library.Core.DTOs.ReturnedRecordDTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWorks;

namespace Library.Service.Services
{
    public class ReturnedRecordService : Service<ReturnedRecord, ReturnedRecordDto>, IReturnedRecordService
    {
        public ReturnedRecordService(IGenericRepository<ReturnedRecord> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
        }
    }
}
