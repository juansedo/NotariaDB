using NotariaDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Seeders
{
    class NotariosSeeder : ISeeder<Notarios>
    {
        public Notarios[] Run()
        {
            Notarios[] seeds =
            {
                new Notarios{UserId = "98509595", Title = "NOTARIO ÚNICO"},
                new Notarios{UserId = "21979476", Title = "NOTARIA ENCARGADA"}
            };

            return seeds;
        }
    }
}
