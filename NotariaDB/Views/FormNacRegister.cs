using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using NotariaDB.Models;
using Org.BouncyCastle.Crypto.Agreement.Kdf;
using NotariaDB.Views.Components;

namespace NotariaDB.Views
{
    public partial class FormNacRegister : Form
    {
        public Models.Nacimientos Register =new Models.Nacimientos();

        ValidatorBox gbMom = new ValidatorBox(ValidatorBoxFactory.getValidator("madre"), 6, new Point(494, 45));
        ValidatorBox gbDad = new ValidatorBox(ValidatorBoxFactory.getValidator("padre"), 6, new Point(494, 182));
        ValidatorBox gbWitness = new ValidatorBox(ValidatorBoxFactory.getValidator("testigo"), 6, new Point(494, 319));

        public FormNacRegister()
        {
            InitializeComponent();
        }

        private void FormNacRegister_Load(object sender, EventArgs e)
        {
            Controls.Add(gbMom.toGroupBox());
            Controls.Add(gbDad.toGroupBox());
            Controls.Add(gbWitness.toGroupBox());

            using (Models.notariadbContext db = new Models.notariadbContext())
            {
                // Sexo
                cSex.Items.Clear();
                cSex.Items.Add("MASCULINO");
                cSex.Items.Add("FEMENINO");

                // Tipo de sangre
                cBloodtype.Items.Clear();
                setComboBoxDisplay(cBloodtype, "BloodtypeId", "Name");
                cBloodtype.DataSource = db.Bloodtypes.Select(s => new {s.BloodtypeId, s.Name}).ToList();
                cBloodtype.SelectedItem = null;

                // Departamento
                cDepartment.Items.Clear();
                setComboBoxDisplay(cDepartment, "Id", "Name");
                cDepartment.DataSource = db.Departments.Select(s => new { s.Id, s.Name }).ToList();
                cDepartment.SelectedIndex = 1;

                // Tipo de anexo
                cAttachtype.Items.Clear();
                setComboBoxDisplay(cAttachtype, "AttachId", "Name");
                cAttachtype.DataSource = db.NacAttaches.Select(s => new {s.AttachId, s.Name}).ToList();

                // Notario
                cNotary.Items.Clear();
                setComboBoxDisplay(cNotary, "Id", "Name");
                cNotary.DataSource = db.Notarios.Join(db.Usuarios,
                                n => n.UserId, u => u.Id, (n, u) =>
                                new {
                                        Id = n.UserId,
                                        Name = string.Concat(u.Name," ",u.Surname)
                                }).ToList();
            }
        }

        private void setComboBoxDisplay(ComboBox cb, string hidden_value, string displayed_value)
        {
            cb.DisplayMember = displayed_value;
            cb.ValueMember = hidden_value;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                this.Register.Nuip = tNuip.Text;
                this.Register.Serial = tSerial.Text;
                this.Register.Sex = cSex.SelectedItem.ToString().Substring(0, 1);
                this.Register.Name = tName.Text;
                this.Register.Surname1 = tSurname1.Text;
                this.Register.Surname2 = tSurname2.Text;
                this.Register.RegDate = DateTime.Now;
                this.Register.BirthDate = dtBirthDate.Value;
                this.Register.BirthHour = new TimeSpan(decimal.ToInt32(tBirthHour.Value), decimal.ToInt32(tBirthMinutes.Value), 0);
                this.Register.MomId = gbMom.GetText();
                this.Register.DadId = gbDad.GetText();
                this.Register.WitnessId = gbWitness.GetText();
                this.Register.BloodtypeId = int.Parse(cBloodtype.SelectedValue.ToString());
                this.Register.PlaceId = int.Parse(cDepartment.SelectedValue.ToString());
                this.Register.AttachId = int.Parse(cAttachtype.SelectedValue.ToString());
                this.Register.AttachDescription = tAttachDescription.Text;
                this.Register.NotaryId = cNotary.SelectedValue.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Faltan campos por llenar", "Error 001 - " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido", "Error 00? - " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = int.Parse(cDepartment.SelectedValue.ToString());
            using (Models.notariadbContext db = new Models.notariadbContext())
            {
                cCity.DisplayMember = "Name";
                cCity.ValueMember = "Id";
                cCity.DataSource = (from p in db.Places
                                      join c in db.Cities
                                      on p.CityId equals c.Id
                                      where p.DepartmentId == selection
                                      select new { Id = p.PlaceId, Name = c.Name }).ToList();
                cCity.SelectedItem = null;
            }
        }
    }
}
