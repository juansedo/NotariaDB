using NotariaDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Seeders
{
    class BloodtypesSeeder : ISeeder<Bloodtypes>
    {
        public Bloodtypes[] Run()
        {
            Bloodtypes[] seeds =
            {
                new Bloodtypes { BloodtypeId = 1, Name = "A+"},
                new Bloodtypes { BloodtypeId = 2, Name = "A-"},
                new Bloodtypes { BloodtypeId = 3, Name = "B+"},
                new Bloodtypes { BloodtypeId = 4, Name = "B-"},
                new Bloodtypes { BloodtypeId = 5, Name = "O+"},
                new Bloodtypes { BloodtypeId = 6, Name = "O-"},
                new Bloodtypes { BloodtypeId = 7, Name = "AB+"},
                new Bloodtypes { BloodtypeId = 8, Name = "AB-"}
            };

            return seeds;
        }
    }
}
