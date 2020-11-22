using NotariaDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Seeders
{
    class MatAttachesSeeder : ISeeder<MatAttaches>
    {
        public MatAttaches[] Run()
        {
            MatAttaches[] seeds =
            {
                new MatAttaches { AttachId = 1, Name = "ACTA RELIGIOSA" },
                new MatAttaches { AttachId = 2, Name = "ESCRITURA DE PROTOCOLIZACIÓN" }
            };

            return seeds;
        }
    }
}
