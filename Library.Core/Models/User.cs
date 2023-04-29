using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public Address Address { get; set; }
        public ICollection<BorrowedRecord> BorrowedRecords { get; set; }
        public ICollection<ReturnedRecord> ReturnedRecords { get; set; }

    }
}
