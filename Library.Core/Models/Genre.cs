﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
