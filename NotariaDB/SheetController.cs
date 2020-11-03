using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NotariaDB.Entities;

namespace NotariaDB
{
    class SheetController
    {
        public void UpdateSheets(NacSheet ns, MatSheet ms, DefSheet ds, UserSheet us)
        {
            //var test = new DatabaseModel();
            using (Models.notariadbContext db = new Models.notariadbContext()) {

                ns.DataSource = (from nac in db.Nacimientos select nac).ToList(); //getDataFromScript(test, ns, "../../../Scripts/get-all-nacimientos.sql");
                ms.DataSource = (from mat in db.Matrimonios select mat).ToList(); //getDataFromScript(test, ms, "../../../Scripts/get-all-matrimonios.sql");
                ds.DataSource = (from def in db.Defunciones select def).ToList(); //getDataFromScript(test, ds, "../../../Scripts/get-all-defunciones.sql");
                us.DataSource = (from user in db.Usuarios select user).ToList(); //getDataFromText(test, us, "SELECT id, d.description AS doctype, name, surname, expedition_place, expedition_date, birth_date FROM usuarios u JOIN doctypes d USING (doctype_id)");
            }
        }

        //private System.Data.DataTable getDataFromScript(DatabaseModel dbm, SheetGridView sgv, string path)
        //{
        //    var sql = System.IO.File.ReadAllText(path);
        //    var result = dbm.query<NacRegister>(sql);

        //    for (int i = 0; i < sgv.Columns.Count && i < result.Columns.Count; i++)
        //    {
        //        sgv.Columns[i].DataPropertyName = result.Columns[i].ColumnName;
        //    }

        //    return result;
        //}

        //private System.Data.DataTable getDataFromText(DatabaseModel dbm, SheetGridView sgv, string text)
        //{
        //    var result = dbm.query<NacRegister>(text);

        //    for (int i = 0; i < sgv.Columns.Count && i < result.Columns.Count; i++) {
        //        sgv.Columns[i].DataPropertyName = result.Columns[i].ColumnName;
        //    }

        //    return result;
        //}
    }
}
