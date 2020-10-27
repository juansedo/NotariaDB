using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace NotariaDB
{
    class SheetGridView : DataGridView
    {
        public SheetGridView(SheetType s_type, string name = "SGV1")
        {
            Name = name;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            ReadOnly = true;
            BackgroundColor = Color.Gray;

            Location = new Point(0, 0);
            Size = new Size(500, 250);
            Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CellBorderStyle = DataGridViewCellBorderStyle.Single;
            RowHeadersVisible = false;
            GridColor = Color.LightGray;
            DefaultCellStyle.Font = new Font("Century Gothic", 10.25F, FontStyle.Regular, GraphicsUnit.Point);

            applyInitRowStyle();

            applyInitHeaderStyle();

            switch (s_type)
            {
                case SheetType.NAC:
                    ColumnCount = 10;
                    Columns[0].Name = "NUIP";
                    Columns[1].Name = "SERIAL";
                    Columns[2].Name = "APELLIDOS";
                    Columns[3].Name = "NOMBRE";
                    Columns[4].Name = "SEXO";
                    Columns[5].Name = "FECHA NACIMIENTO";
                    Columns[6].Name = "FECHA REGISTRO";
                    Columns[7].Name = "PADRES";
                    Columns[8].Name = "CIUDAD";
                    Columns[9].Name = "DEPARTAMENTO";
                    break;
                case SheetType.MAT:
                    ColumnCount = 5;
                    Columns[0].Name = "SERIAL";
                    Columns[1].Name = "ESPOSO";
                    Columns[2].Name = "ESPOSA";
                    Columns[3].Name = "FECHA BODA";
                    Columns[4].Name = "FECHA REGISTRO";
                    break;
                case SheetType.DEF:
                    ColumnCount = 8;
                    Columns[0].Name = "CÉDULA";
                    Columns[1].Name = "SERIAL";
                    Columns[2].Name = "DIFUNTO";
                    Columns[3].Name = "SEXO";
                    Columns[4].Name = "FECHA MUERTE";
                    Columns[5].Name = "MÉDICO";
                    Columns[6].Name = "CIUDAD";
                    Columns[7].Name = "DEPARTAMENTO";
                    break;
                case SheetType.USER:
                    ColumnCount = 7;
                    Columns[0].Name = "NRO. DOCUMENTO";
                    Columns[1].Name = "TIPO DE DOCUMENTO";
                    Columns[2].Name = "NOMBRE";
                    Columns[3].Name = "APELLIDO";
                    Columns[4].Name = "LUGAR DE EXPEDICIÓN";
                    Columns[5].Name = "FECHA DE EXPEDICIÓN";
                    Columns[6].Name = "FECHA DE NACIMIENTO";
                    break;
            }

            Rows.Add("1", "PRUEBA DE TEXTO");
            Rows.Add("2", "PRUEBA DE TEXTO");

            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            Dock = DockStyle.Fill;
            TabIndex = 0;
        }

        public void applyInitRowStyle()
        {
            AllowUserToResizeRows = false;
            RowTemplate.DefaultCellStyle.BackColor = Color.White;
            RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.GradientActiveCaption;
            RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            RowTemplate.Height = 15;
        }

        public void applyInitHeaderStyle()
        {
            AllowUserToResizeColumns = true;
            EnableHeadersVisualStyles = false;
            ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.GradientActiveCaption;
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            ColumnHeadersDefaultCellStyle.Font = new Font(DefaultCellStyle.Font, FontStyle.Bold);
            ColumnHeadersHeight = 30;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ColumnHeadersHeight = 35;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CellMouseEnter += new DataGridViewCellEventHandler(SheetGridView_CellMouseEnter);
            CellMouseLeave += new DataGridViewCellEventHandler(SheetGridView_CellMouseLeave);
        }

        public void SheetGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
        }

        public void SheetGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

    }

    enum SheetType
    {
        NAC,
        MAT,
        DEF,
        USER
    }
}
