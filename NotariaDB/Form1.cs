﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotariaDB
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            DatabaseModel test = new DatabaseModel("notariadb");

            test.UpdateSheets(userSheetGridView);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
