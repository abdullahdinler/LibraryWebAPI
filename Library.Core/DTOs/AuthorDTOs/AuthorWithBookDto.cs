using Library.Core.DTOs.BookDTOs;
using Library.Core.Models;

namespace Library.Core.DTOs.AuthorDTOs
{
    public class AuthorWithBookDto : AuthorDto
    {
        public List<BookDto> Books { get; set; }
    }
}
