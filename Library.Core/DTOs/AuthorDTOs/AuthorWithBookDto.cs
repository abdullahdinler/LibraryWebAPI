using Library.Core.Models;

namespace Library.Core.DTOs.AuthorDTOs
{
    public class AuthorWithBookDto : AuthorDto
    {
        public List<Book> Books { get; set; }
    }
}
