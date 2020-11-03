using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB
{
    static class FormStylist
    {
        public static void HideColumns(SheetGridView sgv, params string[] column_names)
        {
            List<Action> hide_functions = new List<Action>();

            foreach (string s in column_names)
                hide_functions.Add(() => sgv.Columns[s].Visible = false);

            foreach (Action func in hide_functions) {
                try { func(); }
                catch (Exception ex) { };
            }
        }
        
        public static void SetBgColorAndImage(System.Windows.Forms.Button btn, System.Drawing.Color color, System.Drawing.Bitmap rsc)
        {
            btn.BackColor = color;
            btn.Image = rsc;
        }
    }
}
