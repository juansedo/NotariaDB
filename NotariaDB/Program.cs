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
            Application.Run(new formMain());

            //using(Models.notariadbContext db = new Models.notariadbContext())
            //{
            //    List<Models.Nacimientos> lst = (from d in db.Nacimientos select d).ToList();

            //    foreach (Models.Nacimientos i in lst)
            //    {
            //        System.Diagnostics.Debug.WriteLine(i.Name);
            //    }
            //}
        }
    }
}
