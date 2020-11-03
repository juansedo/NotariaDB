using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Medicos
    {
        public Medicos()
        {
            Defunciones = new HashSet<Defunciones>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MedicCard { get; set; }

        public virtual ICollection<Defunciones> Defunciones { get; set; }
    }
}
