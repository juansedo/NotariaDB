namespace NotariaDB
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
            this.tMomDocument = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbMom = new System.Windows.Forms.GroupBox();
            this.btnMomBlank = new System.Windows.Forms.Button();
            this.btnMomValidate = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDadBlank = new System.Windows.Forms.Button();
            this.btnDadValidate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tDadDocument = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbDad = new System.Windows.Forms.GroupBox();
            this.btnWitBlank = new System.Windows.Forms.Button();
            this.btnWitValidate = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tWitDocument = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gbWitness = new System.Windows.Forms.GroupBox();
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
            this.gbMom.SuspendLayout();
            this.gbDad.SuspendLayout();
            this.gbWitness.SuspendLayout();
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
            this.gbBasics.Size = new System.Drawing.Size(470, 305);
            this.gbBasics.TabIndex = 1;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "Datos básicos";
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
            this.label7.Location = new System.Drawing.Point(329, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "MM:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(200, 218);
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
            this.tBirthMinutes.Location = new System.Drawing.Point(379, 217);
            this.tBirthMinutes.Name = "tBirthMinutes";
            this.tBirthMinutes.Size = new System.Drawing.Size(58, 26);
            this.tBirthMinutes.TabIndex = 8;
            // 
            // tBirthHour
            // 
            this.tBirthHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBirthHour.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBirthHour.Location = new System.Drawing.Point(250, 217);
            this.tBirthHour.Name = "tBirthHour";
            this.tBirthHour.Size = new System.Drawing.Size(58, 26);
            this.tBirthHour.TabIndex = 7;
            // 
            // cBloodtype
            // 
            this.cBloodtype.FormattingEnabled = true;
            this.cBloodtype.Location = new System.Drawing.Point(191, 251);
            this.cBloodtype.Name = "cBloodtype";
            this.cBloodtype.Size = new System.Drawing.Size(265, 25);
            this.cBloodtype.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tipo de sangre:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 218);
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
            this.dtBirthDate.Location = new System.Drawing.Point(191, 184);
            this.dtBirthDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(265, 26);
            this.dtBirthDate.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fecha de nacimiento:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 152);
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
            this.tSurname2.Location = new System.Drawing.Point(191, 150);
            this.tSurname2.Name = "tSurname2";
            this.tSurname2.Size = new System.Drawing.Size(265, 26);
            this.tSurname2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 120);
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
            this.tSurname1.Location = new System.Drawing.Point(191, 118);
            this.tSurname1.Name = "tSurname1";
            this.tSurname1.Size = new System.Drawing.Size(265, 26);
            this.tSurname1.TabIndex = 4;
            // 
            // tName
            // 
            this.tName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tName.Location = new System.Drawing.Point(191, 86);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(265, 26);
            this.tName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 88);
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
            this.gbAttach.Location = new System.Drawing.Point(12, 456);
            this.gbAttach.Name = "gbAttach";
            this.gbAttach.Size = new System.Drawing.Size(470, 94);
            this.gbAttach.TabIndex = 3;
            this.gbAttach.TabStop = false;
            this.gbAttach.Text = "Antecedente";
            // 
            // cAttachtype
            // 
            this.cAttachtype.FormattingEnabled = true;
            this.cAttachtype.Location = new System.Drawing.Point(191, 21);
            this.cAttachtype.Name = "cAttachtype";
            this.cAttachtype.Size = new System.Drawing.Size(265, 25);
            this.cAttachtype.TabIndex = 1;
            // 
            // tMomDocument
            // 
            this.tMomDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tMomDocument.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tMomDocument.Location = new System.Drawing.Point(138, 22);
            this.tMomDocument.Name = "tMomDocument";
            this.tMomDocument.Size = new System.Drawing.Size(270, 26);
            this.tMomDocument.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(12, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nombre:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(12, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Documento:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbMom
            // 
            this.gbMom.Controls.Add(this.btnMomBlank);
            this.gbMom.Controls.Add(this.btnMomValidate);
            this.gbMom.Controls.Add(this.label15);
            this.gbMom.Controls.Add(this.tMomDocument);
            this.gbMom.Controls.Add(this.label13);
            this.gbMom.Controls.Add(this.label14);
            this.gbMom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbMom.Location = new System.Drawing.Point(494, 45);
            this.gbMom.Name = "gbMom";
            this.gbMom.Size = new System.Drawing.Size(422, 131);
            this.gbMom.TabIndex = 4;
            this.gbMom.TabStop = false;
            this.gbMom.Text = "Datos de la madre";
            // 
            // btnMomBlank
            // 
            this.btnMomBlank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMomBlank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMomBlank.Location = new System.Drawing.Point(234, 86);
            this.btnMomBlank.Name = "btnMomBlank";
            this.btnMomBlank.Size = new System.Drawing.Size(158, 32);
            this.btnMomBlank.TabIndex = 3;
            this.btnMomBlank.Text = "Dejar en blanco";
            this.btnMomBlank.UseVisualStyleBackColor = true;
            // 
            // btnMomValidate
            // 
            this.btnMomValidate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMomValidate.Location = new System.Drawing.Point(46, 86);
            this.btnMomValidate.Name = "btnMomValidate";
            this.btnMomValidate.Size = new System.Drawing.Size(158, 32);
            this.btnMomValidate.TabIndex = 2;
            this.btnMomValidate.Text = "Validar";
            this.btnMomValidate.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(141, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(267, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "N/A";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDadBlank
            // 
            this.btnDadBlank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDadBlank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDadBlank.Location = new System.Drawing.Point(234, 86);
            this.btnDadBlank.Name = "btnDadBlank";
            this.btnDadBlank.Size = new System.Drawing.Size(158, 32);
            this.btnDadBlank.TabIndex = 3;
            this.btnDadBlank.Text = "Dejar en blanco";
            this.btnDadBlank.UseVisualStyleBackColor = true;
            // 
            // btnDadValidate
            // 
            this.btnDadValidate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDadValidate.Location = new System.Drawing.Point(46, 86);
            this.btnDadValidate.Name = "btnDadValidate";
            this.btnDadValidate.Size = new System.Drawing.Size(158, 32);
            this.btnDadValidate.TabIndex = 2;
            this.btnDadValidate.Text = "Validar";
            this.btnDadValidate.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(141, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(267, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "N/A";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tDadDocument
            // 
            this.tDadDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tDadDocument.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tDadDocument.Location = new System.Drawing.Point(138, 22);
            this.tDadDocument.Name = "tDadDocument";
            this.tDadDocument.Size = new System.Drawing.Size(270, 26);
            this.tDadDocument.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(12, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 23);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nombre:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(12, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "Documento:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbDad
            // 
            this.gbDad.Controls.Add(this.btnDadBlank);
            this.gbDad.Controls.Add(this.btnDadValidate);
            this.gbDad.Controls.Add(this.label16);
            this.gbDad.Controls.Add(this.tDadDocument);
            this.gbDad.Controls.Add(this.label17);
            this.gbDad.Controls.Add(this.label18);
            this.gbDad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDad.Location = new System.Drawing.Point(494, 182);
            this.gbDad.Name = "gbDad";
            this.gbDad.Size = new System.Drawing.Size(422, 131);
            this.gbDad.TabIndex = 5;
            this.gbDad.TabStop = false;
            this.gbDad.Text = "Datos del padre";
            // 
            // btnWitBlank
            // 
            this.btnWitBlank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWitBlank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWitBlank.Location = new System.Drawing.Point(234, 86);
            this.btnWitBlank.Name = "btnWitBlank";
            this.btnWitBlank.Size = new System.Drawing.Size(158, 32);
            this.btnWitBlank.TabIndex = 3;
            this.btnWitBlank.Text = "Dejar en blanco";
            this.btnWitBlank.UseVisualStyleBackColor = true;
            // 
            // btnWitValidate
            // 
            this.btnWitValidate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWitValidate.Location = new System.Drawing.Point(46, 86);
            this.btnWitValidate.Name = "btnWitValidate";
            this.btnWitValidate.Size = new System.Drawing.Size(158, 32);
            this.btnWitValidate.TabIndex = 2;
            this.btnWitValidate.Text = "Validar";
            this.btnWitValidate.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(141, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(267, 23);
            this.label19.TabIndex = 0;
            this.label19.Text = "N/A";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tWitDocument
            // 
            this.tWitDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tWitDocument.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tWitDocument.Location = new System.Drawing.Point(138, 22);
            this.tWitDocument.Name = "tWitDocument";
            this.tWitDocument.Size = new System.Drawing.Size(270, 26);
            this.tWitDocument.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(12, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 23);
            this.label20.TabIndex = 0;
            this.label20.Text = "Nombre:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(12, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 23);
            this.label21.TabIndex = 0;
            this.label21.Text = "Documento:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbWitness
            // 
            this.gbWitness.Controls.Add(this.btnWitBlank);
            this.gbWitness.Controls.Add(this.btnWitValidate);
            this.gbWitness.Controls.Add(this.label19);
            this.gbWitness.Controls.Add(this.tWitDocument);
            this.gbWitness.Controls.Add(this.label20);
            this.gbWitness.Controls.Add(this.label21);
            this.gbWitness.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbWitness.Location = new System.Drawing.Point(494, 319);
            this.gbWitness.Name = "gbWitness";
            this.gbWitness.Size = new System.Drawing.Size(422, 131);
            this.gbWitness.TabIndex = 6;
            this.gbWitness.TabStop = false;
            this.gbWitness.Text = "Datos del testigo";
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
            this.cNotary.FormattingEnabled = true;
            this.cNotary.Location = new System.Drawing.Point(620, 496);
            this.cNotary.Name = "cNotary";
            this.cNotary.Size = new System.Drawing.Size(266, 23);
            this.cNotary.TabIndex = 7;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.Location = new System.Drawing.Point(358, 566);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(215, 32);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cDepartment
            // 
            this.cDepartment.FormattingEnabled = true;
            this.cDepartment.Location = new System.Drawing.Point(191, 21);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.Size = new System.Drawing.Size(265, 25);
            this.cDepartment.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lugar de nacimiento";
            // 
            // cCity
            // 
            this.cCity.FormattingEnabled = true;
            this.cCity.Location = new System.Drawing.Point(191, 57);
            this.cCity.Name = "cCity";
            this.cCity.Size = new System.Drawing.Size(265, 25);
            this.cCity.TabIndex = 2;
            // 
            // FormNacRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cNotary);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.gbWitness);
            this.Controls.Add(this.gbDad);
            this.Controls.Add(this.gbMom);
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
            this.gbMom.ResumeLayout(false);
            this.gbMom.PerformLayout();
            this.gbDad.ResumeLayout(false);
            this.gbDad.PerformLayout();
            this.gbWitness.ResumeLayout(false);
            this.gbWitness.PerformLayout();
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
        private System.Windows.Forms.TextBox tMomDocument;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbMom;
        private System.Windows.Forms.Button btnMomBlank;
        private System.Windows.Forms.Button btnMomValidate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDadBlank;
        private System.Windows.Forms.Button btnDadValidate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tDadDocument;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbDad;
        private System.Windows.Forms.Button btnWitBlank;
        private System.Windows.Forms.Button btnWitValidate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tWitDocument;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox gbWitness;
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
    }
}