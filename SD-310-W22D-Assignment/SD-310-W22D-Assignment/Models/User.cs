using System;
using System.Collections.Generic;

namespace SD_310_W22D_Assignment.Models
{
    public partial class User
    {
        public User()
        {
            Collections = new HashSet<Collection>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? CollectionId { get; set; }

        public virtual Collection? Collection { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
    }
}
