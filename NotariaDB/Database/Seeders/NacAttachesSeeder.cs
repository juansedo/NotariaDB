using NotariaDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Seeders
{
    class NacAttachesSeeder : ISeeder<NacAttaches>
    {
        public NacAttaches[] Run()
        {
            NacAttaches[] seeds =
            {
                new NacAttaches { AttachId = 1, Name = "CERTIFICADO DE NACIDO VIVO" },
                new NacAttaches { AttachId = 2, Name = "CÉDULA DE CIUDADANÍA" },
                new NacAttaches { AttachId = 3, Name = "SENTENCIA JUDICIAL" },
                new NacAttaches { AttachId = 4, Name = "ESCRITURA PÚBLICA" },
                new NacAttaches { AttachId = 5, Name = "SOLICITUD DE CORRECCIÓN" },
                new NacAttaches { AttachId = 6, Name = "ACTA PARROQUIAL" }
            };

            return seeds;
        }
    }
}
