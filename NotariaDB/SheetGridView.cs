using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace NotariaDB
{
    abstract class SheetGridView : DataGridView
    {
        public SheetGridView(string name)
        {
            defineProperties(name);

            applyInitRowStyle();

            applyInitHeaderStyle();
        }


        private void defineProperties(string name)
        {
            Name = name;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            ReadOnly = true;
            BackgroundColor = Color.Gray;

            Location = new Point(0, 0);
            Size = new Size(500, 250);
            Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left;

            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CellBorderStyle = DataGridViewCellBorderStyle.Single;
            RowHeadersVisible = false;
            GridColor = Color.LightGray;
            DefaultCellStyle.Font = new Font("Century Gothic", 10.25F, FontStyle.Regular, GraphicsUnit.Point);

            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            Dock = DockStyle.Fill;
            TabIndex = 0;
        }

        private void applyInitRowStyle()
        {
            AllowUserToResizeRows = false;
            RowTemplate.DefaultCellStyle.BackColor = Color.White;
            RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.GradientActiveCaption;
            RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            RowTemplate.Height = 15;
        }

        private void applyInitHeaderStyle()
        {
            AllowUserToResizeColumns = true;
            EnableHeadersVisualStyles = true;
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
            //CellMouseEnter += new DataGridViewCellEventHandler(SheetGridView_CellMouseEnter);
            //CellMouseLeave += new DataGridViewCellEventHandler(SheetGridView_CellMouseLeave);
        }

        private void SheetGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void SheetGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }
    }

    class NacSheet : SheetGridView
    {
        public NacSheet(string name = "nacSheet") : base(name)
        {

        }
    }

    class MatSheet : SheetGridView
    {
        public MatSheet(string name = "matSheet") : base(name)
        {

        }
    }

    class DefSheet : SheetGridView
    {
        public DefSheet(string name = "defSheet") : base(name)
        {

        }
    }

    class UserSheet : SheetGridView
    {
        public UserSheet(string name = "userSheet") : base(name)
        {

        }
    }

}
