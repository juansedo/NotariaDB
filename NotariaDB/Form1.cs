using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotariaDB.Controllers;

namespace NotariaDB
{
    public partial class formMain : Form
    {
        private NacSheet nacSheetGridView = new NacSheet("nacSheetGridView");
        private MatSheet matSheetGridView = new MatSheet("matSheetGridView");
        private DefSheet defSheetGridView = new DefSheet("defSheetGridView");
        private UserSheet userSheetGridView = new UserSheet("userSheetGridView");

        public formMain()
        {
            InitializeComponent();
            includeDataSheets();

            FormStylist.SetBgColorAndImage(btnNewRegister,      SystemColors.Control, Properties.Resources.NewRegIcon);
            FormStylist.SetBgColorAndImage(btnEditRegister,     SystemColors.Control, Properties.Resources.EditRegIcon);
            FormStylist.SetBgColorAndImage(btnDeleteRegister,   SystemColors.Control, Properties.Resources.DeleteRegIcon);
            FormStylist.SetBgColorAndImage(btnUserInfo,         SystemColors.Control, Properties.Resources.UserIcon);
            FormStylist.SetBgColorAndImage(btnPDF,              SystemColors.Control, Properties.Resources.PDFIcon);
            FormStylist.SetBgColorAndImage(btnExcel,            SystemColors.Control, Properties.Resources.ExcelIcon);

            toolTip.SetToolTip(btnNewRegister, "Agregar registro");
            toolTip.SetToolTip(btnEditRegister, "Editar registro");
            toolTip.SetToolTip(btnDeleteRegister, "Eliminar registro");
            toolTip.SetToolTip(btnUserInfo, "Información del usuario");
            toolTip.SetToolTip(btnPDF, "Abrir PDF");
            toolTip.SetToolTip(btnExcel, "Exportar a Excel");

            SheetController test = new SheetController();
            test.UpdateSheets(nacSheetGridView, matSheetGridView, defSheetGridView, userSheetGridView);
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //tabControl.SelectedTab.Controls[0]
        }

        private void btnNewRegister_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageNAC)
            {
                using (var form = new FormNacRegister())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //Models.Nacimientos reg = form.Register;

                        //DatabaseModel.insert(reg);
                    }
                }
            }

            if (tabControl.SelectedTab == tabPageMAT)
            {
                using (var form = new FormMatRegister())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        
                        //DatabaseModel.insert(reg);
                    }
                }
            }
        }
    }
}
