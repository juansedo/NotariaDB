using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Commands
{
    class command
    {
        public virtual void execute(SheetGridView hoja) { }
        public virtual void execute() { }
    }
}
