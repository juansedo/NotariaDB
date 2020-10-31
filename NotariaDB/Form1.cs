﻿using System;
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
        private NacSheet nacSheetGridView = new NacSheet("nacSheetGridView");
        private MatSheet matSheetGridView = new MatSheet("matSheetGridView");
        private DefSheet defSheetGridView = new DefSheet("defSheetGridView");
        private UserSheet userSheetGridView = new UserSheet("userSheetGridView");

        public formMain()
        {
            InitializeComponent();
            includeDataSheets();

            btnNewRegister.BackColor = SystemColors.Control;
            btnEditRegister.BackColor = SystemColors.Control;
            btnDeleteRegister.BackColor = SystemColors.Control;
            btnUserInfo.BackColor = SystemColors.Control;
            btnPDF.BackColor = SystemColors.Control;
            btnExcel.BackColor = SystemColors.Control;

            btnNewRegister.Image = Properties.Resources.NewRegIcon;
            btnEditRegister.Image = Properties.Resources.EditRegIcon;
            btnDeleteRegister.Image = Properties.Resources.DeleteRegIcon;
            btnUserInfo.Image = Properties.Resources.UserIcon;
            btnPDF.Image = Properties.Resources.PDFIcon;
            btnExcel.Image = Properties.Resources.ExcelIcon;

            toolTip.SetToolTip(btnNewRegister, "Agregar registro");
            toolTip.SetToolTip(btnEditRegister, "Editar registro");
            toolTip.SetToolTip(btnDeleteRegister, "Eliminar registro");
            toolTip.SetToolTip(btnUserInfo, "Información del usuario");
            toolTip.SetToolTip(btnPDF, "Abrir PDF");
            toolTip.SetToolTip(btnExcel, "Exportar a Excel");

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
