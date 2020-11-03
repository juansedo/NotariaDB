using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Bloodtypes
    {
        public Bloodtypes()
        {
            Nacimientos = new HashSet<Nacimientos>();
        }

        public int BloodtypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Nacimientos> Nacimientos { get; set; }
    }
}
