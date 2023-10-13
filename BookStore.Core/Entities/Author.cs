using BookStore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Author : IBaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        // BookCount??
        // 1-n Book relationships
    }
}
