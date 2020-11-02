using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotariaDB
{
    public partial class FormNacRegister : Form
    {
        public Entities.NacRegister Register;

        public FormNacRegister()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Register.Nuip = tNuip.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
