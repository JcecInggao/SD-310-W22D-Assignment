﻿using System;
using System.Collections.Generic;

namespace SD_310_W22D_Assignment.Models
{
    public partial class Song
    {
        public Song()
        {
            Collections = new HashSet<Collection>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Artist { get; set; } = null!;

        public virtual ICollection<Collection> Collections { get; set; }
    }
}
