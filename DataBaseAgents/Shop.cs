using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class Shop
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public int AgentId { get; set; }

        public virtual Agent Agent { get; set; }
    }
}
