using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Core.DTOs.ReturnedRecordDTOs
{
    public class ReturnedRecordWithUser : ReturnedRecordDto
    {
        public User User { get; set; }
    }
    
}
