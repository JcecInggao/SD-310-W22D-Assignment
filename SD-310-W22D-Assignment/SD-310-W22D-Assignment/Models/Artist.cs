using System;
using System.Collections.Generic;

namespace SD_310_W22D_Assignment.Models
{
    public partial class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Songs { get; set; }
    }
}
