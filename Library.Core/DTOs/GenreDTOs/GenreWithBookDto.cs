using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Core.DTOs.GenreDTOs
{
    public class GenreWithBookDto : GenreDto
    {
        public List<Book> Books { get; set; }
    }
}
