using Library.Core.DTOs.BookDTOs;
using Library.Core.DTOs.UserDTOs;

namespace Library.Core.DTOs.BorrowedRecordDTOs
{
    public class BorrowedRecordWithBookDto : BorrowedRecordDto
    {
        public UserDto User { get; set; }
        public BookDto Book { get; set; }
    }
}
