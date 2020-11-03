using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Doctypes
    {
        public Doctypes()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int DoctypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
