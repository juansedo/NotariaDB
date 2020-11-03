using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Matrimonios
    {
        [System.ComponentModel.DisplayName("SERIAL")]
        public string Serial { get; set; }

        [System.ComponentModel.DisplayName("NOMBRE ESPOSO")]
        public string Name1 { get; set; }

        [System.ComponentModel.DisplayName("APELLIDO ESPOSO")]
        public string Surname1 { get; set; }

        [System.ComponentModel.DisplayName("DOCUMENTO ESPOSO")]
        public string Relateduser1Id { get; set; }

        [System.ComponentModel.DisplayName("NOMBRE ESPOSA")]
        public string Name2 { get; set; }

        [System.ComponentModel.DisplayName("APELLIDO ESPOSA")]
        public string Surname2 { get; set; }

        [System.ComponentModel.DisplayName("DOCUMENTO ESPOSA")]
        public string Relateduser2Id { get; set; }

        [System.ComponentModel.DisplayName("LUGAR DE BODA")]
        public int PlaceId { get; set; }

        [System.ComponentModel.DisplayName("FECHA DE BODA")]
        public DateTime WeedingDate { get; set; }

        [System.ComponentModel.DisplayName("FECHA DE REGISTRO")]
        public DateTime RegDate { get; set; }

        [System.ComponentModel.DisplayName("DOCUMENTO TESTIGO")]
        public string WitnessId { get; set; }

        [System.ComponentModel.DisplayName("NOTARIO")]
        public string NotaryId { get; set; }

        [System.ComponentModel.DisplayName("ANEXO")]
        public int AttachId { get; set; }

        [System.ComponentModel.DisplayName("DESCRIPCIÓN ANEXO")]
        public string AttachDescription { get; set; }

        [System.ComponentModel.DisplayName("RUTA DEL ARCHIVO")]
        public string Fileroute { get; set; }

        public virtual MatAttaches Attach { get; set; }
        public virtual Notarios Notary { get; set; }
        public virtual Places Place { get; set; }
        public virtual Usuarios Relateduser1 { get; set; }
        public virtual Usuarios Relateduser2 { get; set; }
        public virtual Usuarios Witness { get; set; }
    }
}
