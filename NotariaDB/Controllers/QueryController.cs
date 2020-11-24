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
            return result;
        }

        public static Models.Usuarios userById(string id)
        {
            using Models.notariadbContext db = new Models.notariadbContext();
            var result = db.Usuarios.Where(s => s.Id == id).ToList();

            if (result.Count() == 0) return null;

            return result.First();
        }
    }
}
