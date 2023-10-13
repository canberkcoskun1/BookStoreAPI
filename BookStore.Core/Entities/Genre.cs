using BookStore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Genre : IBaseEntity
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        // Book relationships
        public virtual ICollection<Book> Books { get; set; }
    }
}
