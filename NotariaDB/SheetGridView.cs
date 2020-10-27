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
            AllowUserToResizeRows = false;
            BackgroundColor = SystemColors.ButtonHighlight;

            ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            Location = new Point(0, 0);
            Size = new Size(500, 250);
            Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GridColor = Color.Black;
            RowHeadersVisible = false;

            Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);

            ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

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

                    break;
                case SheetType.DEF:

                    break;
                case SheetType.USER:

                    break;
            }

            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            Dock = DockStyle.Fill;
            TabIndex = 0;
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
