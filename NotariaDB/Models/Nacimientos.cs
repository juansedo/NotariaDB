using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Nacimientos
    {
        public string Nuip { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Sex { get; set; }
        public int PlaceId { get; set; }
        public int BloodtypeId { get; set; }
        public string MomId { get; set; }
        public string DadId { get; set; }
        public string WitnessId { get; set; }
        public string RelateduserId { get; set; }
        public string NotaryId { get; set; }
        public int AttachId { get; set; }
        public string AttachDescription { get; set; }
        public string Fileroute { get; set; }

        public virtual NacAttaches Attach { get; set; }
        public virtual Bloodtypes Bloodtype { get; set; }
        public virtual Usuarios Dad { get; set; }
        public virtual Usuarios Mom { get; set; }
        public virtual Notarios Notary { get; set; }
        public virtual Places Place { get; set; }
        public virtual Usuarios Relateduser { get; set; }
        public virtual Usuarios Witness { get; set; }
    }
}
