using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class Agent
    {
        public Agent()
        {
            AgentPriorityHistories = new HashSet<AgentPriorityHistory>();
            ProductSales = new HashSet<ProductSale>();
            Shops = new HashSet<Shop>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int AgentTypeId { get; set; }
        public string Address { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string DirectorName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public int Priority { get; set; }

        public virtual AgentType AgentType { get; set; }
        public virtual ICollection<AgentPriorityHistory> AgentPriorityHistories { get; set; }
        public virtual ICollection<ProductSale> ProductSales { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
