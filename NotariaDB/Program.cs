using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotariaDB
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormNacRegister());

            //using (Models.notariadbContext db = new Models.notariadbContext())
            //{
            //    List<Models.Usuarios> lst = (from d in db.Usuarios select d).ToList();

            //    foreach (Models.Usuarios i in lst)
            //    {
            //        i.Doctype = (from d in db.Doctypes where d.DoctypeId == i.DoctypeId select d).First();
            //        System.Diagnostics.Debug.WriteLine(i.Doctype.Description);
            //    }
            //}
        }
    }
}
