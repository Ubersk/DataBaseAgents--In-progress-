using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class Material
    {
        public Material()
        {
            MaterialCountHistories = new HashSet<MaterialCountHistory>();
            MaterialSuppliers = new HashSet<MaterialSupplier>();
            ProductMaterials = new HashSet<ProductMaterial>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int CountInPack { get; set; }
        public string Unit { get; set; }
        public double? CountInStock { get; set; }
        public double MinCount { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Image { get; set; }
        public int MaterialTypeId { get; set; }

        public virtual MaterialType MaterialType { get; set; }
        public virtual ICollection<MaterialCountHistory> MaterialCountHistories { get; set; }
        public virtual ICollection<MaterialSupplier> MaterialSuppliers { get; set; }
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }
    }
}
