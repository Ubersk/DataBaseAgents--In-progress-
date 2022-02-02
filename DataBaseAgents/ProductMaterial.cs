using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class ProductMaterial
    {
        public int ProductId { get; set; }
        public int MaterialId { get; set; }
        public double? Count { get; set; }

        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
    }
}
