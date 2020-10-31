using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotariaDB
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            includeDataSheets();

            btnNewRegister.Image = NotariaDB.Properties.Resources.NewRegIcon;
            btnEditRegister.Image = NotariaDB.Properties.Resources.EditRegIcon;
            btnDeleteRegister.Image = NotariaDB.Properties.Resources.DeleteRegIcon;
            btnUserInfo.Image = NotariaDB.Properties.Resources.UserIcon;
            btnPDF.Image = NotariaDB.Properties.Resources.PDFIcon;
            btnExcel.Image = NotariaDB.Properties.Resources.ExcelIcon;

            toolTip.SetToolTip(btnNewRegister, "Agregar registro");

            SheetController test = new SheetController();
            test.UpdateSheets(nacSheetGridView, matSheetGridView, userSheetGridView);
        }

        void includeDataSheets()
        {
            this.tabPageNAC.Controls.Add(nacSheetGridView);
            this.tabPageMAT.Controls.Add(matSheetGridView);
            this.tabPageDEF.Controls.Add(defSheetGridView);
            this.tabPageUSER.Controls.Add(userSheetGridView);
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
