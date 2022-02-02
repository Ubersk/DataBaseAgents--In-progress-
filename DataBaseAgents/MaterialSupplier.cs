using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class MaterialSupplier
    {
        public int MaterialId { get; set; }
        public int SupplierId { get; set; }

        public virtual Material Material { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
