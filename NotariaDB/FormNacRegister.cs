using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using NotariaDB.Models;

namespace NotariaDB
{
    public partial class FormNacRegister : Form
    {
        public Models.Nacimientos Register =new Models.Nacimientos();

        public FormNacRegister()
        {
            InitializeComponent();
        }

        private void FormNacRegister_Load(object sender, EventArgs e)
        {
            using (Models.notariadbContext db = new Models.notariadbContext())
            {
                initializeComboBox(cBloodtype, "Name", "BloodtypeId");
                cBloodtype.DataSource = (from s in db.Bloodtypes select new { s.BloodtypeId, s.Name }).ToList();
                cBloodtype.SelectedItem = null;

                initializeComboBox(cDepartment, "Name", "Id");
                cDepartment.DataSource = (from s in db.Departments select new {s.Id, s.Name}).ToArray();
                cDepartment.SelectedIndex = 1;

                initializeComboBox(cAttachtype, "Name", "AttachId");
                cAttachtype.DataSource = (from s in db.NacAttaches select new { s.AttachId, s.Name }).ToArray();

                initializeComboBox(cNotary, "Name", "Id");
                var result = (from n in db.Notarios
                              join user in db.Usuarios
                              on n.UserId equals user.Id
                              select new {Id=n.UserId, Name=string.Concat(user.Name," ",user.Surname)}).ToList();
                cNotary.DataSource = result;
            }
        }

        private void initializeComboBox(ComboBox cb, string display, string value)
        {
            cb.Items.Clear();
            cb.DisplayMember = display;
            cb.ValueMember = value;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Register.Nuip = tNuip.Text;
            this.Register.Serial = tSerial.Text;
            this.Register.Name = tName.Text;
            this.Register.Surname1 = tSurname1.Text;
            //this.Register.Birthdate
            using (Models.notariadbContext db = new Models.notariadbContext()) {
                this.Register.Bloodtype = db.Bloodtypes
                                            .Single(c => c.Name == cBloodtype.Text);
                //this.Register.Place = db.Places
                //                            .Where(c => c. == cBloodtype.Text &&)
                //                            .First();
            }

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void cDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cCity.Items.Clear();
            cCity.Text = "";
            int selection = Int32.Parse(cDepartment.SelectedValue.ToString());
            using (Models.notariadbContext db = new Models.notariadbContext())
            {
                cCity.Items.AddRange((from p in db.Places
                                      join c in db.Cities
                                      on p.CityId equals c.Id
                                      where p.DepartmentId == selection
                                      select c.Name).ToArray());
            }
        }
    }
}
