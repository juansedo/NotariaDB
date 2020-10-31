﻿using System;
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

    public class NacRegister
    {
        public string Nuip { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Bloodtype { get; set; }
        public string Place { get; set; }
        public string Birth_date { get; set; }
        public string Reg_date { get; set; }
        public string Attachtype { get; set; }
        public string Attach_description { get; set; }
        public string Dad_id { get; set; }
        public string Mom_id { get; set; }
        public string Witness1_id { get; set; }
        public string Witness2_id { get; set; }
        public string Relateduser_id { get; set; }
        public string Notary { get; set; }
        public string Fileroute { get; set; }

    }
}