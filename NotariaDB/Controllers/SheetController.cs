using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NotariaDB.Controllers
{
    class SheetController
    {
        public void UpdateSheets(NacSheet ns, MatSheet ms, DefSheet ds, UserSheet us)
        {
            using (Models.notariadbContext db = new Models.notariadbContext())
            {
                ns.DataSource = QueryController.getNacSheetData();
                ns.eraseExtraColumns();
                
                ms.DataSource = QueryController.getMatSheetData();
                ms.eraseExtraColumns();

                ds.DataSource = QueryController.getDefSheetData();
                ds.eraseExtraColumns();

                us.DataSource = QueryController.getUserSheetData();
                FormStylist.HideColumns(us, "Doctype", "Notarios", "DefuncionesRelateduser", "DefuncionesWitness",
                    "MatrimoniosRelateduser1", "MatrimoniosRelateduser2", "MatrimoniosWitness", "NacimientosDad",
                    "NacimientosMom", "NacimientosRelateduser", "NacimientosWitness");
            }
        }
    }
}
