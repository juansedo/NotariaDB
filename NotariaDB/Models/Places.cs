using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Places
    {
        public Places()
        {
            Defunciones = new HashSet<Defunciones>();
            Matrimonios = new HashSet<Matrimonios>();
            Nacimientos = new HashSet<Nacimientos>();
        }

        public int PlaceId { get; set; }
        public int DepartmentId { get; set; }
        public int CityId { get; set; }

        public virtual Cities City { get; set; }
        public virtual Departments Department { get; set; }
        public virtual ICollection<Defunciones> Defunciones { get; set; }
        public virtual ICollection<Matrimonios> Matrimonios { get; set; }
        public virtual ICollection<Nacimientos> Nacimientos { get; set; }
    }
}
