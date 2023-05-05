using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Core.DTOs.BookDTOs
{
    public class BookWithAuthorDto : BookDto
    {
        public Author Author { get; set; }
    }
}
