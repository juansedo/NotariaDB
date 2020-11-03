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

                ns.DataSource = (from nac in db.Nacimientos select nac).ToList();
                ms.DataSource = (from mat in db.Matrimonios select mat).ToList();
                ds.DataSource = (from def in db.Defunciones select def).ToList();
                us.DataSource = (from user in db.Usuarios
                                 select new
                                 {
                                     id = user.Id,
                                     TipoDeDocumento = user.DoctypeId,
                                     Nombre = user.Name,
                                     Apellido = user.Surname,
                                     LugarExpedición = user.ExpeditionPlace,
                                     FechaExpedición = user.ExpeditionDate,
                                     FechaNacimiento = user.BirthDate
                                 }).ToList();
            }
        }
    }
}
