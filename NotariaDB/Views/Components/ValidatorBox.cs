using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NotariaDB.Views.Components
{
    class ValidatorBox
    {
        private ValidatorBoxFlyweight _vbf;

        public ValidatorBox(ValidatorBoxFlyweight vb, int tabIndex, System.Drawing.Point location)
        {
            _vbf = vb;

            _vbf.TabIndex = tabIndex;
            _vbf.SetLocation(location);
        }

        public void SetValidationName(string text)
        {
            _vbf.SetValidationName(text);
        }

        public void SetLocation(System.Drawing.Point location)
        {
            _vbf.SetLocation(location);
        }

        public bool GetValid()
        {
            return _vbf.GetValid();
        }

        public bool GetIfNull()
        {
            return _vbf.GetIfNull();
        }

        public string GetText()
        {
            return _vbf.GetText();
        }

        public GroupBox toGroupBox()
        {
            return _vbf;
        }
    }
}
