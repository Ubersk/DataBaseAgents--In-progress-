using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class MaterialType
    {
        public MaterialType()
        {
            Materials = new HashSet<Material>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double DefectedPercent { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
