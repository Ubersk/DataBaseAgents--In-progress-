using System;
using System.Collections.Generic;

#nullable disable

namespace DataBaseAgents
{
    public partial class AgentType
    {
        public AgentType()
        {
            Agents = new HashSet<Agent>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Agent> Agents { get; set; }
    }
}
