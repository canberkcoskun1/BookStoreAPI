using BookStore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Library : IBaseEntity
    {
        public int Id { get; set; }
    }
}
