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
        public Models.Nacimientos Register;

        public FormNacRegister()
        {
            InitializeComponent();
        }

        private void FormNacRegister_Load(object sender, EventArgs e)
        {
            using (Models.notariadbContext db = new Models.notariadbContext())
            {
                cBloodtype.Items.Clear();
                cBloodtype.Items.AddRange( (from s in db.Bloodtypes select s.Name).ToArray() );

                cDepartment.Items.Clear();
                cDepartment.Items.AddRange( (from s in db.Departments select s.Name).ToArray() );

                cAttachtype.Items.Clear();
                cAttachtype.Items.AddRange( (from s in db.NacAttaches select s.Name).ToArray() );
                
                cNotary.Items.Clear();
                var result = (from n in db.Notarios join user in db.Usuarios on n.UserId equals user.Id select new {user.Name, user.Surname}).ToList();
                foreach(var item in result)
                    cNotary.Items.Add(item.Name + " " + item.Surname);

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Register.Nuip = tNuip.Text;
            this.Register.Serial = tSerial.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cCity.Items.Clear();
            cCity.Text = "";
            string selection = cDepartment.SelectedItem.ToString();
            using (Models.notariadbContext db = new Models.notariadbContext())
            {
                int box_id = db.Departments.Where(c => c.Name == selection).Select(c => c.Id).First(); 
                cCity.Items.AddRange((from p in db.Places
                                      join c in db.Cities
                                      on p.CityId equals c.Id
                                      where p.DepartmentId == box_id
                                      select c.Name).ToArray());
            }
        }
    }
}
