using System;
using System.Collections.Generic;
using System.IO;
using NotariaDB.Models;

namespace NotariaDB.Factories
{  
    class UserFactory
    {
        public static List<Usuarios> create()
        {
            List<Usuarios> seeds = new List<Usuarios>();
            using (var reader = new StreamReader(@"D:\test.csv"))
            {
                while (!reader.EndOfStream)
                {
                    String[] user = reader.ReadLine().Split(',');
                    String[] EDate = user[5].Split("/");
                    String[] BDate = user[6].Split("/");
                    seeds.Add(new Usuarios
                    {
                        Id = user[0],
                        DoctypeId = Int32.Parse(user[1]),
                        Name = user[2],
                        Surname = user[3],
                        ExpeditionPlace = user[4],
                        ExpeditionDate = new DateTime(Int32.Parse(EDate[0]), Int32.Parse(EDate[1]), Int32.Parse(EDate[2])),
                        BirthDate = new DateTime(Int32.Parse(BDate[0]), Int32.Parse(BDate[1]), Int32.Parse(BDate[2]))
                    });
                }
            }
            return seeds;
        }
        
    }
}
