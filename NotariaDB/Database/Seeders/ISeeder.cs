using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Seeders
{
    public interface ISeeder<T>
    {
        public T[] Run();
    }
}
