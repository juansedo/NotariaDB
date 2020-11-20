using NotariaDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Seeders
{
    class DepartmentsSeeder : ISeeder<Departments>
    {
        public Departments[] Run()
        {
            Departments[] seeds =
            {
                new Departments { Id = 1, Name = "AMAZONAS"},
                new Departments { Id = 2, Name = "ANTIOQUIA"},
                new Departments { Id = 3, Name = "ARAUCA"},
                new Departments { Id = 4, Name = "ATLÁNTICO"},
                new Departments { Id = 5, Name = "BOYACÁ"},
                new Departments { Id = 6, Name = "CALDAS"},
                new Departments { Id = 7, Name = "CAQUETÁ"},
                new Departments { Id = 8, Name = "CASANARE"},
                new Departments { Id = 9, Name = "CAUCA"},
                new Departments { Id = 10, Name = "CESAR"},
                new Departments { Id = 11, Name = "CÓRDOBA"},
                new Departments { Id = 12, Name = "CUNDINAMARCA"},
                new Departments { Id = 13, Name = "CHOCÓ"},
                new Departments { Id = 14, Name = "GUAINÍA"},
                new Departments { Id = 15, Name = "GUAVIARE"},
                new Departments { Id = 16, Name = "HUILA"},
                new Departments { Id = 17, Name = "LA GUAJIRA"},
                new Departments { Id = 18, Name = "MAGDALENA"},
                new Departments { Id = 19, Name = "META"},
                new Departments { Id = 20, Name = "NARIÑO"},
                new Departments { Id = 21, Name = "NORTE DE SANTANDER"},
                new Departments { Id = 22, Name = "PUTUMAYO"},
                new Departments { Id = 23, Name = "QUINDÍO"},
                new Departments { Id = 24, Name = "RISARALDA"},
                new Departments { Id = 25, Name = "SAN ANDRÉS"},
                new Departments { Id = 26, Name = "SANTANDER"},
                new Departments { Id = 27, Name = "SUCRE"},
                new Departments { Id = 28, Name = "TOLIMA"},
                new Departments { Id = 29, Name = "VALLE"},
                new Departments { Id = 30, Name = "VAUPÉS"},
                new Departments { Id = 31, Name = "VICHADA"}
            };

            return seeds;
        }
    }
}
