using NotariaDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using NotariaDB.Factories;


namespace NotariaDB.Seeders
{
    class UsuariosSeeder : ISeeder<Usuarios>
    {
        public Usuarios[] Run()
        {
            Usuarios[] seeds =
            {
                new Usuarios {
                    Id = "1001268575",
                    DoctypeId = 1,
                    Name = "JUAN SEBASTIÁN",
                    Surname = "DÍAZ OSORIO",
                    ExpeditionPlace = "SALGAR",
                    ExpeditionDate = new DateTime(2019,11,25),
                    BirthDate = new DateTime(2001,11,01)
                },
                new Usuarios {
                    Id = "1039760194",
                    DoctypeId = 1,
                    Name = "ANA CRISTINA",
                    Surname = "DÍAZ OSORIO",
                    ExpeditionPlace = "SALGAR",
                    ExpeditionDate = new DateTime(2005,01,01),
                    BirthDate = new DateTime(1992,09,25)
                },
                new Usuarios {
                    Id = "21979476",
                    DoctypeId = 1,
                    Name = "RUTH NELLY",
                    Surname = "OSORIO GARCÍA",
                    ExpeditionPlace = "SALGAR",
                    ExpeditionDate = new DateTime(1990,01,01),
                    BirthDate = new DateTime(1970,05,25)
                },
                new Usuarios {
                    Id = "719912",
                    DoctypeId = 1,
                    Name = "VILEY DE JESÚS",
                    Surname = "DÍAZ GARCÍA",
                    ExpeditionPlace = "SALGAR",
                    ExpeditionDate = new DateTime(1990,01,01),
                    BirthDate = new DateTime(1942,12,18)
                },
                new Usuarios {
                    Id = "98509595",
                    DoctypeId = 1,
                    Name = "JAVIER ALONSO",
                    Surname = "DÍAZ GALLEGO",
                    ExpeditionPlace = "SALGAR",
                    ExpeditionDate = new DateTime(1990,01,01),
                    BirthDate = new DateTime(1970,05,02)
                }
            };

            List<Usuarios> test = UserFactory.create();
            test.AddRange(seeds);
            return test.ToArray();
        }
    }
}
