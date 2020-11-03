using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Nacimientos
    {
        [System.ComponentModel.DisplayName("NUIP")]
        public string Nuip { get; set; }

        [System.ComponentModel.DisplayName("SERIAL")]
        public string Serial { get; set; }

        [System.ComponentModel.DisplayName("NOMBRE")]
        public string Name { get; set; }

        [System.ComponentModel.DisplayName("PRIMER APELLIDO")]
        public string Surname1 { get; set; }

        [System.ComponentModel.DisplayName("SEGUNDO APELLIDO")]
        public string Surname2 { get; set; }

        [System.ComponentModel.DisplayName("SEXO")]
        public string Sex { get; set; }

        [System.ComponentModel.DisplayName("LUGAR DE NACIMIENTO")]
        public int PlaceId { get; set; }

        [System.ComponentModel.DisplayName("TIPO DE SANGRE")]
        public int BloodtypeId { get; set; }

        [System.ComponentModel.DisplayName("HORA DE NACIMIENTO")]
        public TimeSpan? BirthHour { get; set; }

        [System.ComponentModel.DisplayName("FECHA DE NACIMIENTO")]
        public DateTime BirthDate { get; set; }

        [System.ComponentModel.DisplayName("FECHA DE REGISTRO")]
        public DateTime RegDate { get; set; }

        [System.ComponentModel.DisplayName("DOCUMENTO MADRE")]
        public string MomId { get; set; }

        [System.ComponentModel.DisplayName("DOCUMENTO PADRE")]
        public string DadId { get; set; }

        [System.ComponentModel.DisplayName("DOCUMENTO TESTIGO")]
        public string WitnessId { get; set; }

        [System.ComponentModel.DisplayName("USUARIO RELACIONADO")]
        public string RelateduserId { get; set; }

        [System.ComponentModel.DisplayName("NOTARIO")]
        public string NotaryId { get; set; }

        [System.ComponentModel.DisplayName("ANEXO")]
        public int AttachId { get; set; }

        [System.ComponentModel.DisplayName("DESCRIPCIÓN DEL ANEXO")]
        public string AttachDescription { get; set; }

        [System.ComponentModel.DisplayName("RUTA DEL ARCHIVO")]
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
