using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotariaDB.Controllers
{
    static class QueryController
    {
        public static List<Models.Nacimientos> getNacSheetData()
        {
            using Models.notariadbContext db = new Models.notariadbContext();
            var result = db.Nacimientos.ToList();
            return result;
        }

        public static List<Models.Matrimonios> getMatSheetData()
        {
            using Models.notariadbContext db = new Models.notariadbContext();
            var result = db.Matrimonios.ToList();
            return result;
        }

        public static List<Models.Defunciones> getDefSheetData()
        {
            using Models.notariadbContext db = new Models.notariadbContext();
            var result = db.Defunciones.ToList();
            return result;
        }

        public static List<Models.Usuarios> getUserSheetData()
        {
            using Models.notariadbContext db = new Models.notariadbContext();
            var result = db.Usuarios.ToList();
                          /*{
                              Documento = user.Id,
                              TipoDeDocumento = user.DoctypeId,
                              Nombre = user.Name,
                              Apellido = user.Surname,
                              LugarExpedición = user.ExpeditionPlace,
                              FechaExpedición = user.ExpeditionDate,
                              FechaNacimiento = user.BirthDate
                          }).ToList();*/
            return result;
        }
    }
}
