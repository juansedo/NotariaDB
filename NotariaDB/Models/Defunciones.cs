using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Defunciones
    {
        [System.ComponentModel.DisplayName("SERIAL")]
        public string Serial { get; set; }

        [System.ComponentModel.DisplayName("NOMBRE")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("APELLIDO")]
        public string Surname { get; set; }

        [System.ComponentModel.DisplayName("USUARIO RELACIONADO")]
        public string RelateduserId { get; set; }

        [System.ComponentModel.DisplayName("MÉDICO")]
        public string MedicId { get; set; }

        [System.ComponentModel.DisplayName("LUGAR DE MUERTE")]
        public int PlaceId { get; set; }

        [System.ComponentModel.DisplayName("FECHA DE MUERTE")]
        public DateTime DeadDate { get; set; }

        [System.ComponentModel.DisplayName("FECHA DE REGISTRO")]
        public DateTime RegDate { get; set; }

        [System.ComponentModel.DisplayName("DOCUMENTO TESTIGO")]
        public string WitnessId { get; set; }

        [System.ComponentModel.DisplayName("NOTARIO")]
        public string NotaryId { get; set; }

        [System.ComponentModel.DisplayName("DESCRIPCIÓN ANEXO")]
        public string AttachDescription { get; set; }

        [System.ComponentModel.DisplayName("RUTA DEL ARCHIVO")]
        public string Fileroute { get; set; }

        public virtual Medicos Medic { get; set; }
        public virtual Notarios Notary { get; set; }
        public virtual Places Place { get; set; }
        public virtual Usuarios Relateduser { get; set; }
        public virtual Usuarios Witness { get; set; }
    }
}
