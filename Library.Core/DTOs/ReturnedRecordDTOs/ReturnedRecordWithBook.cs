using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Core.DTOs.ReturnedRecordDTOs
{
    public class ReturnedRecordWithBook : ReturnedRecordDto
    {
        public Book Book { get; set; }
    }
}
