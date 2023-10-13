﻿using BookStore.Core.Common;

namespace BookStore.Core.Entities
{
    public class Author : IBaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        // BookCount??
        // 1-n Book relationships
        public virtual ICollection<Book> Books { get; set;}
    }
}
