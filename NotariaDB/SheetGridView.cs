using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using NotariaDB.Entities;

namespace NotariaDB
{
    abstract class SheetGridView : DataGridView
    {
        public SheetGridView(string name)
        {
            defineProperties(name);

            applyInitRowStyle();

            applyInitHeaderStyle();

            defineColumns();

            Rows.Add("1", "PRUEBA DE TEXTO");
            Rows.Add("2", "PRUEBA DE TEXTO");
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
            CellMouseEnter += new DataGridViewCellEventHandler(SheetGridView_CellMouseEnter);
            CellMouseLeave += new DataGridViewCellEventHandler(SheetGridView_CellMouseLeave);
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

        protected abstract void defineColumns();
    }

    class NacSheet : SheetGridView
    {
        public NacSheet(string name = "nacSheet") : base(name)
        {

        }

        protected override void defineColumns()
        {
            //ColumnCount = 17;
            //Columns[0].Name = "NUIP";
            //Columns[1].Name = "SERIAL";
            //Columns[2].Name = "NOMBRE";
            //Columns[3].Name = "APELLIDO";
            //Columns[4].Name = "SEXO";
            //Columns[5].Name = "TIPO DE SANGRE";
            //Columns[6].Name = "LUGAR DE NACIMIENTO";
            //Columns[7].Name = "FECHA DE NACIMIENTO";
            //Columns[8].Name = "FECHA DE REGISTRO";
            //Columns[9].Name = "ANEXO";
            //Columns[10].Name = "DESCRIPCIÓN DE ANEXO";
            //Columns[11].Name = "DOCUMENTO DEL PADRE";
            //Columns[12].Name = "DOCUMENTO DEL MADRE";
            //Columns[13].Name = "DOCUMENTO DEL TESTIGO 1";
            //Columns[14].Name = "DOCUMENTO DEL TESTIGO 2";
            //Columns[15].Name = "DOCUMENTO USUARIO REL.";
            //Columns[16].Name = "NOTARIO";
        }

        public void AddRow(NacRegister reg)
        {
            Rows.Add(reg.Nuip, reg.Serial, reg.Name, reg.Surname,
                reg.Sex, reg.Bloodtype, reg.Place, reg.Birth_date, reg.Reg_date,
                reg.Attachtype, reg.Attach_description, reg.Mom_id, reg.Dad_id,
                reg.Witness1_id, reg.Relateduser_id, reg.Notary, reg.Fileroute);
        }
    }

    class MatSheet : SheetGridView
    {
        public MatSheet(string name = "matSheet") : base(name)
        {

        }

        protected override void defineColumns()
        {
            //ColumnCount = 10;
            //Columns[0].Name = "SERIAL";
            //Columns[1].Name = "NOMBRE ESPOSO";
            //Columns[2].Name = "APELLIDO ESPOSO";
            //Columns[3].Name = "DOCUMENTO ESPOSO";
            //Columns[4].Name = "NOMBRE ESPOSA";
            //Columns[5].Name = "APELLIDO ESPOSA";
            //Columns[6].Name = "DOCUMENTO ESPOSA";
            //Columns[7].Name = "LUGAR DE BODA";
            //Columns[8].Name = "FECHA BODA";
            //Columns[9].Name = "FECHA REGISTRO";
        }
    }

    class DefSheet : SheetGridView
    {
        public DefSheet(string name = "defSheet") : base(name)
        {

        }

        protected override void defineColumns()
        {
            //ColumnCount = 10;
            //Columns[0].Name = "SERIAL";
            //Columns[1].Name = "CÉDULA";
            //Columns[2].Name = "NOMBRE DEL DIFUNTO";
            //Columns[3].Name = "APELLIDO DEL DIFUNTO";
            //Columns[4].Name = "SEXO";
            //Columns[5].Name = "FECHA DE MUERTE";
            //Columns[6].Name = "FECHA DE REGISTRO";
            //Columns[7].Name = "MÉDICO";
            //Columns[8].Name = "CIUDAD";
            //Columns[9].Name = "DEPARTAMENTO";
        }
    }

    class UserSheet : SheetGridView
    {
        public UserSheet(string name = "userSheet") : base(name)
        {

        }

        protected override void defineColumns()
        {
            //ColumnCount = 7;
            //Columns[0].Name = "NRO. DOCUMENTO";
            //Columns[1].Name = "TIPO DE DOCUMENTO";
            //Columns[2].Name = "NOMBRE";
            //Columns[3].Name = "APELLIDO";
            //Columns[4].Name = "LUGAR DE EXPEDICIÓN";
            //Columns[5].Name = "FECHA DE EXPEDICIÓN";
            //Columns[6].Name = "FECHA DE NACIMIENTO";
        }

        public void AddRow(User user)
        {
            Rows.Add(user.Id, user.Doctype, user.Name, user.Surname, user.Expedition_place, user.Expedition_date, user.Birth_date);
        }
    }

}
