using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class ReturnedRecord: BaseEntity
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Status { get; set; }

        public User User { get; set; }
        public Book Book { get; set; }

    }
}
