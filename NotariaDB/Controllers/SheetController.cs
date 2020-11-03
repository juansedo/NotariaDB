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
                ms.DataSource = QueryController.getMatSheetData();
                ds.DataSource = QueryController.getDefSheetData();
                us.DataSource = QueryController.getUserSheetData();

                
            }
        }
    }
}
