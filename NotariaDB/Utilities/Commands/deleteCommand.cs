using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using NotariaDB;

namespace NotariaDB.Commands
{
    class deleteCommand : command
    {
        public override void execute(SheetGridView hoja) {
            DialogResult answer = hoja.Show("¿Esta seguro que desea eliminar el registro de " + hoja.SelectedRows[0].Cells[2].Value + "?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == hoja.Yes)
            {
                int position = hoja.SelectedRows[0].Index;
                hoja.CurrentCell = null;
                hoja.Rows[position].Visible = false;
            }
        }
    }
}
