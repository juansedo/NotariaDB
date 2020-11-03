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
                FormStylist.HideColumns(ns, "BloodtypeId", "BirthHour", "NotaryId",
                    "WitnessId", "AttachId", "AttachDescription",
                    "Fileroute", "Attach", "Bloodtype", "Dad", "Mom",
                    "Notary", "Place", "Relateduser", "Witness");

                ms.DataSource = QueryController.getMatSheetData();
                //FormStylist.HideColumns(ms, );

                ds.DataSource = QueryController.getDefSheetData();
                //FormStylist.HideColumns(ds, );

                us.DataSource = QueryController.getUserSheetData();
                FormStylist.HideColumns(us, "Doctype", "Notarios", "DefuncionesRelateduser", "DefuncionesWitness",
                    "MatrimoniosRelateduser1", "MatrimoniosRelateduser2", "MatrimoniosWitness", "NacimientosDad",
                    "NacimientosMom", "NacimientosRelateduser", "NacimientosWitness");
            }
        }
    }
}
