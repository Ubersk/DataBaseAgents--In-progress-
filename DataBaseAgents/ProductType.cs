using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double DefectedPercent { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
