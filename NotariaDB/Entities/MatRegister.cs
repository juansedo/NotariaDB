using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Entities
{
    public class MatRegister
    {
        public string Id { get; set; }
        public string Name1 { get; set; }
        public string Surname1 { get; set; }
        public string Relateduser1_id { get; set; }
        public string Name2 { get; set; }
        public string Surname2 { get; set; }
        public string Relateduser2_id { get; set; }
        public string Place { get; set; }
        public string Weeding_date { get; set; }
        public string Reg_date { get; set; }

    }
}
