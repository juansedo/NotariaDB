namespace NotariaDB.Views
{
    partial class FormNacRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbBasics = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cSex = new System.Windows.Forms.ComboBox();
            this.tSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBirthMinutes = new System.Windows.Forms.NumericUpDown();
            this.tBirthHour = new System.Windows.Forms.NumericUpDown();
            this.cBloodtype = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tSurname2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tSurname1 = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tNuip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tAttachDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbAttach = new System.Windows.Forms.GroupBox();
            this.cAttachtype = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cNotary = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cDepartment = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cCity = new System.Windows.Forms.ComboBox();
            this.gbBasics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBirthMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBirthHour)).BeginInit();
            this.gbAttach.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(296, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NUEVO REGISTRO DE NACIMIENTO";
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.label25);
            this.gbBasics.Controls.Add(this.cSex);
            this.gbBasics.Controls.Add(this.tSerial);
            this.gbBasics.Controls.Add(this.label1);
            this.gbBasics.Controls.Add(this.label7);
            this.gbBasics.Controls.Add(this.label6);
            this.gbBasics.Controls.Add(this.tBirthMinutes);
            this.gbBasics.Controls.Add(this.tBirthHour);
            this.gbBasics.Controls.Add(this.cBloodtype);
            this.gbBasics.Controls.Add(this.label12);
            this.gbBasics.Controls.Add(this.label11);
            this.gbBasics.Controls.Add(this.dtBirthDate);
            this.gbBasics.Controls.Add(this.label10);
            this.gbBasics.Controls.Add(this.label5);
            this.gbBasics.Controls.Add(this.tSurname2);
            this.gbBasics.Controls.Add(this.label4);
            this.gbBasics.Controls.Add(this.tSurname1);
            this.gbBasics.Controls.Add(this.tName);
            this.gbBasics.Controls.Add(this.label3);
            this.gbBasics.Controls.Add(this.tNuip);
            this.gbBasics.Controls.Add(this.label2);
            this.gbBasics.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBasics.Location = new System.Drawing.Point(12, 45);
            this.gbBasics.Name = "gbBasics";
            this.gbBasics.Size = new System.Drawing.Size(470, 323);
            this.gbBasics.TabIndex = 1;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "Datos básicos";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(6, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(172, 23);
            this.label25.TabIndex = 0;
            this.label25.Text = "Sexo:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cSex
            // 
            this.cSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cSex.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cSex.FormattingEnabled = true;
            this.cSex.Location = new System.Drawing.Point(191, 86);
            this.cSex.Name = "cSex";
            this.cSex.Size = new System.Drawing.Size(265, 28);
            this.cSex.TabIndex = 3;
            // 
            // tSerial
            // 
            this.tSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tSerial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tSerial.Location = new System.Drawing.Point(191, 54);
            this.tSerial.Name = "tSerial";
            this.tSerial.Size = new System.Drawing.Size(265, 26);
            this.tSerial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(329, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "MM:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(200, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "HH:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tBirthMinutes
            // 
            this.tBirthMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBirthMinutes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBirthMinutes.Location = new System.Drawing.Point(379, 251);
            this.tBirthMinutes.Name = "tBirthMinutes";
            this.tBirthMinutes.Size = new System.Drawing.Size(58, 26);
            this.tBirthMinutes.TabIndex = 9;
            // 
            // tBirthHour
            // 
            this.tBirthHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBirthHour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBirthHour.Location = new System.Drawing.Point(250, 251);
            this.tBirthHour.Name = "tBirthHour";
            this.tBirthHour.Size = new System.Drawing.Size(58, 26);
            this.tBirthHour.TabIndex = 8;
            // 
            // cBloodtype
            // 
            this.cBloodtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBloodtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBloodtype.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBloodtype.FormattingEnabled = true;
            this.cBloodtype.Location = new System.Drawing.Point(191, 285);
            this.cBloodtype.Name = "cBloodtype";
            this.cBloodtype.Size = new System.Drawing.Size(265, 28);
            this.cBloodtype.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tipo de sangre:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hora de nacimiento:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtBirthDate.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtBirthDate.CustomFormat = " dd / MMM / yyyy";
            this.dtBirthDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtBirthDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthDate.Location = new System.Drawing.Point(191, 218);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(265, 26);
            this.dtBirthDate.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fecha de nacimiento:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Segundo apellido:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSurname2
            // 
            this.tSurname2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tSurname2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tSurname2.Location = new System.Drawing.Point(191, 184);
            this.tSurname2.Name = "tSurname2";
            this.tSurname2.Size = new System.Drawing.Size(265, 26);
            this.tSurname2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Primer apellido:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSurname1
            // 
            this.tSurname1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tSurname1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tSurname1.Location = new System.Drawing.Point(191, 152);
            this.tSurname1.Name = "tSurname1";
            this.tSurname1.Size = new System.Drawing.Size(265, 26);
            this.tSurname1.TabIndex = 5;
            // 
            // tName
            // 
            this.tName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tName.Location = new System.Drawing.Point(191, 120);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(265, 26);
            this.tName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tNuip
            // 
            this.tNuip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tNuip.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tNuip.Location = new System.Drawing.Point(191, 22);
            this.tNuip.Name = "tNuip";
            this.tNuip.Size = new System.Drawing.Size(265, 26);
            this.tNuip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "NUIP:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tAttachDescription
            // 
            this.tAttachDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tAttachDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tAttachDescription.Location = new System.Drawing.Point(191, 54);
            this.tAttachDescription.Name = "tAttachDescription";
            this.tAttachDescription.Size = new System.Drawing.Size(265, 26);
            this.tAttachDescription.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descripción:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Antecedente:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbAttach
            // 
            this.gbAttach.Controls.Add(this.cAttachtype);
            this.gbAttach.Controls.Add(this.tAttachDescription);
            this.gbAttach.Controls.Add(this.label8);
            this.gbAttach.Controls.Add(this.label9);
            this.gbAttach.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbAttach.Location = new System.Drawing.Point(12, 474);
            this.gbAttach.Name = "gbAttach";
            this.gbAttach.Size = new System.Drawing.Size(470, 94);
            this.gbAttach.TabIndex = 3;
            this.gbAttach.TabStop = false;
            this.gbAttach.Text = "Antecedente";
            // 
            // cAttachtype
            // 
            this.cAttachtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cAttachtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cAttachtype.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cAttachtype.FormattingEnabled = true;
            this.cAttachtype.Location = new System.Drawing.Point(191, 20);
            this.cAttachtype.Name = "cAttachtype";
            this.cAttachtype.Size = new System.Drawing.Size(265, 28);
            this.cAttachtype.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(502, 494);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 23);
            this.label22.TabIndex = 0;
            this.label22.Text = "Notario:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cNotary
            // 
            this.cNotary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cNotary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cNotary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cNotary.FormattingEnabled = true;
            this.cNotary.Location = new System.Drawing.Point(620, 494);
            this.cNotary.Name = "cNotary";
            this.cNotary.Size = new System.Drawing.Size(266, 28);
            this.cNotary.TabIndex = 7;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.Location = new System.Drawing.Point(364, 574);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(215, 32);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cDepartment
            // 
            this.cDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cDepartment.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cDepartment.FormattingEnabled = true;
            this.cDepartment.Location = new System.Drawing.Point(191, 20);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.Size = new System.Drawing.Size(265, 28);
            this.cDepartment.TabIndex = 1;
            this.cDepartment.SelectedIndexChanged += new System.EventHandler(this.cDepartment_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(6, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(172, 23);
            this.label23.TabIndex = 0;
            this.label23.Text = "Ciudad:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(6, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(172, 23);
            this.label24.TabIndex = 0;
            this.label24.Text = "Departamento:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cCity);
            this.groupBox1.Controls.Add(this.cDepartment);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lugar de nacimiento";
            // 
            // cCity
            // 
            this.cCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cCity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cCity.FormattingEnabled = true;
            this.cCity.Location = new System.Drawing.Point(191, 56);
            this.cCity.Name = "cCity";
            this.cCity.Size = new System.Drawing.Size(265, 28);
            this.cCity.TabIndex = 2;
            // 
            // FormNacRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cNotary);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.gbAttach);
            this.Controls.Add(this.gbBasics);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormNacRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo registro de nacimiento";
            this.Load += new System.EventHandler(this.FormNacRegister_Load);
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBirthMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBirthHour)).EndInit();
            this.gbAttach.ResumeLayout(false);
            this.gbAttach.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbBasics;
        private System.Windows.Forms.TextBox tNuip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tSurname2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tSurname1;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tAttachDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbAttach;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBloodtype;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tBirthMinutes;
        private System.Windows.Forms.NumericUpDown tBirthHour;
        private System.Windows.Forms.ComboBox cAttachtype;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cNotary;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox tSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cDepartment;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cCity;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cSex;
    }
}