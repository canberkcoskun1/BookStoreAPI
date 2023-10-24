﻿using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Abstracts.Repositories
{
    public interface ILibraryRepository : IGenericRepository<Library>
    {
        Task<Library> FindLibaryByIdAsync(int id);
        Task<Library> GetLibraryBooksAndUserAsync(int id);
    }
}
