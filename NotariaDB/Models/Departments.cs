using System;
using System.Collections.Generic;

namespace NotariaDB.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Places = new HashSet<Places>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Places> Places { get; set; }
    }
}
