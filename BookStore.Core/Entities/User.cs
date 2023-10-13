using BookStore.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class User : IBaseEntity, IDeletable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailAdress { get; set; }
        public string Password { get; set; }
        public string ProfileImg { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt {  get; set; }
        // Library 1-N
        // Books N-N
    }
}
