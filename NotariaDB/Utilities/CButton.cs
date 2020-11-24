using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NotariaDB.Commands;

namespace NotariaDB.Utilities
{
    class CButton : Button
    {
        private command command;

        public void setCommand(command command)
        {
            this.command = command;
        }

        public void SetBgColorAndImage(Color color, System.Drawing.Bitmap image)
        {
            FormStylist.SetBgColorAndImage(this, color, image);
        }

    }
}
