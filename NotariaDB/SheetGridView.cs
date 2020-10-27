using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace NotariaDB
{
    class SheetGridView : DataGridView
    {

        public SheetGridView(string name = "SGV1")
        {
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeRows = false;
            BackgroundColor = SystemColors.ButtonHighlight;
            Location = new Point(0, 0);
            Name = name;
            Size = new Size(240, 150);
            TabIndex = 0;
            SetupDataGridView();
            //CellContentClick += new DataGridViewCellEventHandler(this.songsDataGridView_CellContentClick);
        }

        private void SetupDataGridView()
        {
            ColumnCount = 5;

            ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Font = new Font(Font, FontStyle.Bold);

            Size = new Size(500, 250);
            Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            CellBorderStyle = DataGridViewCellBorderStyle.Single;
            GridColor = Color.Black;
            RowHeadersVisible = false;

            Columns[0].Name = "Release Date";
            Columns[1].Name = "Track";
            Columns[2].Name = "Title";
            Columns[3].Name = "Artist";
            Columns[4].Name = "Album";
            Columns[4].DefaultCellStyle.Font = new Font(DefaultCellStyle.Font, FontStyle.Italic);

            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            Dock = DockStyle.Fill;

        }
    }
}
