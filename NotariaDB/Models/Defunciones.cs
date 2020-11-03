using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Defunciones
    {
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RelateduserId { get; set; }
        public string MedicId { get; set; }
        public int PlaceId { get; set; }
        public DateTime DeadDate { get; set; }
        public DateTime RegDate { get; set; }
        public string WitnessId { get; set; }
        public string NotaryId { get; set; }
        public string AttachDescription { get; set; }
        public string Fileroute { get; set; }

        public virtual Medicos Medic { get; set; }
        public virtual Notarios Notary { get; set; }
        public virtual Places Place { get; set; }
        public virtual Usuarios Relateduser { get; set; }
        public virtual Usuarios Witness { get; set; }
    }
}
