using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class MatAttaches
    {
        public MatAttaches()
        {
            Matrimonios = new HashSet<Matrimonios>();
        }

        public int AttachId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Matrimonios> Matrimonios { get; set; }
    }
}
