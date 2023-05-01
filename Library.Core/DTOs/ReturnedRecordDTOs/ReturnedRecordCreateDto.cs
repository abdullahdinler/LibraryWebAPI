using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs.ReturnedRecordDTOs
{
    public class ReturnedRecordCreateDto
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Status { get; set; }
    }
}
