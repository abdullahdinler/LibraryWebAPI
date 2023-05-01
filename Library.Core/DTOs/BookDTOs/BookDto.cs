using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs.BookDTOs
{
    public class BookDto : BaseDto
    {
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public string Status { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
