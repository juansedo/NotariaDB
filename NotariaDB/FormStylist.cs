using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB
{
    static class FormStylist
    {
        public static void SetBgColorAndImage(System.Windows.Forms.Button btn, System.Drawing.Color color, System.Drawing.Bitmap rsc)
        {
            btn.BackColor = color;
            btn.Image = rsc;
        }
    }
}
