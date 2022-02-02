using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class Supplier
    {
        public Supplier()
        {
            MaterialSuppliers = new HashSet<MaterialSupplier>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Inn { get; set; }
        public DateTime StartDate { get; set; }
        public int? QualityRating { get; set; }
        public string SupplierType { get; set; }

        public virtual ICollection<MaterialSupplier> MaterialSuppliers { get; set; }
    }
}
