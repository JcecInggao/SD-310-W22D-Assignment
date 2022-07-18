using System;
using System.Collections.Generic;

namespace SD_310_W22D_Assignment.Models
{
    public partial class Collection
    {
        public Collection()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int? SongId { get; set; }
        public int? UserId { get; set; }

        public virtual Song? Song { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
