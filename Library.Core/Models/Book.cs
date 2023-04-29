using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public string Status { get; set; }
        public DateTime DateAdded { get; set; }

        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public ICollection<BorrowedRecord> BorrowedRecords { get; set; }
        public ICollection<ReturnedRecord> ReturnedRecords { get; set; }

    }
}
