using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class NacAttaches
    {
        public NacAttaches()
        {
            Nacimientos = new HashSet<Nacimientos>();
        }

        public int AttachId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Nacimientos> Nacimientos { get; set; }
    }
}
