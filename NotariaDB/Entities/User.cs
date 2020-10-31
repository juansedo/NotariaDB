using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Doctype { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Expedition_place { get; set; }
        public string Expedition_date { get; set; }
        public string Birth_date { get; set; }
    }
}
