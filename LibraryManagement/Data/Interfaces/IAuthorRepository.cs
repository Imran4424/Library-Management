﻿using LibraryManagement.Data.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAllWithBooks();

        Author GetWithBooks(int id);
    }
}

