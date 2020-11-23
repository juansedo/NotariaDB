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
            return UserFactory.generate();
        }
    }
}
