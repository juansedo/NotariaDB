﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotariaDB.Controllers;

namespace NotariaDB.Views
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
            includeDataSheetsToView();
            nacSheetGridView.SelectionChanged += new EventHandler(SheetGridView_SelectionChanged);
            matSheetGridView.SelectionChanged += new EventHandler(SheetGridView_SelectionChanged);
            defSheetGridView.SelectionChanged += new EventHandler(SheetGridView_SelectionChanged);
            userSheetGridView.SelectionChanged += new EventHandler(SheetGridView_SelectionChanged);

            SheetController test = new SheetController();
            test.UpdateSheets(nacSheetGridView, matSheetGridView, defSheetGridView, userSheetGridView);

            applyStyles();
        }

        private void SheetGridView_SelectionChanged(object sender, EventArgs e)
        {
            var sheet = ((SheetGridView)sender);

            if (sheet.SelectedCells.Count > 0)
            {
                int row_index = sheet.SelectedCells[0].RowIndex;
                int col_index = sheet.SelectedCells[0].ColumnIndex;
                string col_name = sheet.Columns[col_index].Name;

                btnPDF.Enabled = sheet.Columns.Contains("Fileroute") ?
                                    sheet.Rows[row_index].Cells["Fileroute"].FormattedValue.ToString() != "" :
                                    false;

                btnUserInfo.Enabled = col_name.Contains("Id");
            }
        }

        void includeDataSheetsToView()
        {
            this.tabPageNAC.Controls.Add(nacSheetGridView);
            this.tabPageMAT.Controls.Add(matSheetGridView);
            this.tabPageDEF.Controls.Add(defSheetGridView);
            this.tabPageUSER.Controls.Add(userSheetGridView);
        }

        void applyStyles()
        {
            FormStylist.SetBgColorAndImage(btnNewRegister, SystemColors.Control, Properties.Resources.NewRegIcon);
            FormStylist.SetBgColorAndImage(btnEditRegister, SystemColors.Control, Properties.Resources.EditRegIcon);
            FormStylist.SetBgColorAndImage(btnDeleteRegister, SystemColors.Control, Properties.Resources.DeleteRegIcon);
            FormStylist.SetBgColorAndImage(btnUserInfo, SystemColors.Control, Properties.Resources.UserIcon);
            FormStylist.SetBgColorAndImage(btnPDF, SystemColors.Control, Properties.Resources.PDFIcon);
            FormStylist.SetBgColorAndImage(btnExcel, SystemColors.Control, Properties.Resources.ExcelIcon);

            toolTip.SetToolTip(btnNewRegister, "Agregar registro");
            toolTip.SetToolTip(btnEditRegister, "Editar registro");
            toolTip.SetToolTip(btnDeleteRegister, "Eliminar registro");
            toolTip.SetToolTip(btnUserInfo, "Información del usuario");
            toolTip.SetToolTip(btnPDF, "Abrir PDF");
            toolTip.SetToolTip(btnExcel, "Exportar a Excel");
        }

        private void btnDeleteRegister_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageNAC)
            {
                int position = userSheetGridView.SelectedRows[0].Index;
                userSheetGridView.CurrentCell = null;
                userSheetGridView.Rows[position].Visible = false;
            }

            if (tabControl.SelectedTab == tabPageMAT)
            {
                int position = userSheetGridView.SelectedRows[0].Index;
                userSheetGridView.CurrentCell = null;
                userSheetGridView.Rows[position].Visible = false;
            }

            if (tabControl.SelectedTab == tabPageDEF)
            {
                int position = userSheetGridView.SelectedRows[0].Index;
                userSheetGridView.CurrentCell = null;
                userSheetGridView.Rows[position].Visible = false;
            }

            if (tabControl.SelectedTab == tabPageUSER)
            {
                DialogResult answer = MessageBox.Show("¿Esta seguro que desea eliminar el registro de " + userSheetGridView.SelectedRows[0].Cells[2].Value + "?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    int position = userSheetGridView.SelectedRows[0].Index;
                    userSheetGridView.CurrentCell = null;
                    userSheetGridView.Rows[position].Visible = false;
                }
                
            }
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
                        Models.Nacimientos reg = form.Register;
                        using(Models.notariadbContext db = new Models.notariadbContext())
                        {
                            db.Add(reg);

                            db.SaveChanges();
                            SheetController test = new SheetController();
                            test.UpdateSheets(nacSheetGridView, matSheetGridView, defSheetGridView, userSheetGridView);
                        }

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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
