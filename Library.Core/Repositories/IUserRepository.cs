﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Models;

namespace Library.Core.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetUserWithAddress();
    }
}
