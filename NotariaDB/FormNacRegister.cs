﻿using System;
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
                cSex.Items.Clear();
                cSex.Items.Add("MASCULINO");
                cSex.Items.Add("FEMENINO");

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
                this.Register.MomId = tMomDocument.Text;
                this.Register.DadId = tDadDocument.Text;
                this.Register.WitnessId = tWitDocument.Text;
                this.Register.BloodtypeId = Int32.Parse(cBloodtype.SelectedValue.ToString());
                this.Register.PlaceId = Int32.Parse(cDepartment.SelectedValue.ToString());
                this.Register.AttachId = Int32.Parse(cAttachtype.SelectedValue.ToString());
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
            int selection = Int32.Parse(cDepartment.SelectedValue.ToString());
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
