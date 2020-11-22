using NotariaDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Seeders
{
    class DoctypesSeeder : ISeeder<Doctypes>
    {
        public Doctypes[] Run()
        {
            Doctypes[] seeds =
            {
                new Doctypes { DoctypeId = 1, Description = "CÉDULA"},
                new Doctypes { DoctypeId = 2, Description = "TARJETA DE IDENTIDAD"},
                new Doctypes { DoctypeId = 3, Description = "PASAPORTE"}
            };

            return seeds;
        }
    }
}
