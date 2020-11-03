using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Notarios
    {
        public Notarios()
        {
            Defunciones = new HashSet<Defunciones>();
            Matrimonios = new HashSet<Matrimonios>();
            Nacimientos = new HashSet<Nacimientos>();
        }

        public string UserId { get; set; }
        public string Title { get; set; }

        public virtual Usuarios User { get; set; }
        public virtual ICollection<Defunciones> Defunciones { get; set; }
        public virtual ICollection<Matrimonios> Matrimonios { get; set; }
        public virtual ICollection<Nacimientos> Nacimientos { get; set; }
    }
}
