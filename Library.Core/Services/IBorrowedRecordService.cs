using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.DTOs.BorrowedRecordDTOs;
using Library.Core.Models;

namespace Library.Core.Services
{
    public interface IBorrowedRecordService : IService<BorrowedRecord, BorrowedRecordDto>
    {
    }
}
