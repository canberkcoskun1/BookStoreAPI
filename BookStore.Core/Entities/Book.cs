using BookStore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Book : IBaseEntity
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ISBN { get; set; }
        // Author Relationships
        // Library relationships
        // Genre relationships
        // User Relationships
    }
}
