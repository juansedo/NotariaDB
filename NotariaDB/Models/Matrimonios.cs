using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Matrimonios
    {
        public string Serial { get; set; }
        public string Name1 { get; set; }
        public string Surname1 { get; set; }
        public string Relateduser1Id { get; set; }
        public string Name2 { get; set; }
        public string Surname2 { get; set; }
        public string Relateduser2Id { get; set; }
        public int PlaceId { get; set; }
        public DateTime WeedingDate { get; set; }
        public DateTime RegDate { get; set; }
        public string WitnessId { get; set; }
        public string NotaryId { get; set; }
        public int AttachId { get; set; }
        public string AttachDescription { get; set; }
        public string Fileroute { get; set; }

        public virtual MatAttaches Attach { get; set; }
        public virtual Notarios Notary { get; set; }
        public virtual Places Place { get; set; }
        public virtual Usuarios Relateduser1 { get; set; }
        public virtual Usuarios Relateduser2 { get; set; }
        public virtual Usuarios Witness { get; set; }
    }
}
