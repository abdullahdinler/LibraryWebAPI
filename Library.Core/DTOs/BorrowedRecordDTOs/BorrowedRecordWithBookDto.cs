using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Core.DTOs.BorrowedRecordDTOs
{
    public class BorrowedRecordWithBookDto : BorrowedRecordDto
    {
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
