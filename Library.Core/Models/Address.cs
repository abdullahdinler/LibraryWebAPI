﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class Address : BaseEntity
    {
        public string Addres { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
