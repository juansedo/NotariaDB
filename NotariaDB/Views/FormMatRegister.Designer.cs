namespace NotariaDB
{
    partial class FormMatRegister
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
            this.tBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tAttachDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbAttach = new System.Windows.Forms.GroupBox();
            this.tAttachtype = new System.Windows.Forms.ComboBox();
            this.tHusbandDocument = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbHusband = new System.Windows.Forms.GroupBox();
            this.btnHusbandBlank = new System.Windows.Forms.Button();
            this.btnHusbandValidate = new System.Windows.Forms.Button();
            this.lblHusbandName = new System.Windows.Forms.Label();
            this.btnWifeBlank = new System.Windows.Forms.Button();
            this.btnWifeValidate = new System.Windows.Forms.Button();
            this.lblWifeName = new System.Windows.Forms.Label();
            this.tWifeDocument = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbWife = new System.Windows.Forms.GroupBox();
            this.btnWitBlank = new System.Windows.Forms.Button();
            this.btnWitValidate = new System.Windows.Forms.Button();
            this.lblWitName = new System.Windows.Forms.Label();
            this.tWitDocument = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gbWitness = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tNotary = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.cDepartment = new System.Windows.Forms.ComboBox();
            this.cCity = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBasics.SuspendLayout();
            this.gbAttach.SuspendLayout();
            this.gbHusband.SuspendLayout();
            this.gbWife.SuspendLayout();
            this.gbWitness.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(296, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(366, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NUEVO REGISTRO DE MATRIMONIO";
            // 
            // gbBasics
            // 
            this.gbBasics.Controls.Add(this.cCity);
            this.gbBasics.Controls.Add(this.cDepartment);
            this.gbBasics.Controls.Add(this.tBirthDate);
            this.gbBasics.Controls.Add(this.label10);
            this.gbBasics.Controls.Add(this.label4);
            this.gbBasics.Controls.Add(this.label3);
            this.gbBasics.Controls.Add(this.tSerial);
            this.gbBasics.Controls.Add(this.label2);
            this.gbBasics.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbBasics.Location = new System.Drawing.Point(12, 45);
            this.gbBasics.Name = "gbBasics";
            this.gbBasics.Size = new System.Drawing.Size(470, 160);
            this.gbBasics.TabIndex = 1;
            this.gbBasics.TabStop = false;
            this.gbBasics.Text = "Datos básicos";
            // 
            // tBirthDate
            // 
            this.tBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBirthDate.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBirthDate.CustomFormat = " dd / MMM / yyyy";
            this.tBirthDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.tBirthDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tBirthDate.Location = new System.Drawing.Point(191, 119);
            this.tBirthDate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.tBirthDate.Name = "tBirthDate";
            this.tBirthDate.Size = new System.Drawing.Size(265, 26);
            this.tBirthDate.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fecha de boda:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ciudad:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Departamento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tSerial
            // 
            this.tSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tSerial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tSerial.Location = new System.Drawing.Point(191, 22);
            this.tSerial.Name = "tSerial";
            this.tSerial.Size = new System.Drawing.Size(265, 26);
            this.tSerial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serial:";
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
            this.gbAttach.Controls.Add(this.label1);
            this.gbAttach.Controls.Add(this.textBox1);
            this.gbAttach.Controls.Add(this.tAttachtype);
            this.gbAttach.Controls.Add(this.tAttachDescription);
            this.gbAttach.Controls.Add(this.label8);
            this.gbAttach.Controls.Add(this.label9);
            this.gbAttach.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbAttach.Location = new System.Drawing.Point(12, 206);
            this.gbAttach.Name = "gbAttach";
            this.gbAttach.Size = new System.Drawing.Size(470, 125);
            this.gbAttach.TabIndex = 2;
            this.gbAttach.TabStop = false;
            this.gbAttach.Text = "Antecedente";
            // 
            // tAttachtype
            // 
            this.tAttachtype.FormattingEnabled = true;
            this.tAttachtype.Location = new System.Drawing.Point(191, 21);
            this.tAttachtype.Name = "tAttachtype";
            this.tAttachtype.Size = new System.Drawing.Size(265, 25);
            this.tAttachtype.TabIndex = 1;
            // 
            // tHusbandDocument
            // 
            this.tHusbandDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tHusbandDocument.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tHusbandDocument.Location = new System.Drawing.Point(138, 22);
            this.tHusbandDocument.Name = "tHusbandDocument";
            this.tHusbandDocument.Size = new System.Drawing.Size(270, 26);
            this.tHusbandDocument.TabIndex = 1;
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
            // gbHusband
            // 
            this.gbHusband.Controls.Add(this.btnHusbandBlank);
            this.gbHusband.Controls.Add(this.btnHusbandValidate);
            this.gbHusband.Controls.Add(this.lblHusbandName);
            this.gbHusband.Controls.Add(this.tHusbandDocument);
            this.gbHusband.Controls.Add(this.label13);
            this.gbHusband.Controls.Add(this.label14);
            this.gbHusband.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbHusband.Location = new System.Drawing.Point(494, 45);
            this.gbHusband.Name = "gbHusband";
            this.gbHusband.Size = new System.Drawing.Size(422, 131);
            this.gbHusband.TabIndex = 4;
            this.gbHusband.TabStop = false;
            this.gbHusband.Text = "Datos del esposo";
            // 
            // btnHusbandBlank
            // 
            this.btnHusbandBlank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHusbandBlank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHusbandBlank.Location = new System.Drawing.Point(234, 86);
            this.btnHusbandBlank.Name = "btnHusbandBlank";
            this.btnHusbandBlank.Size = new System.Drawing.Size(158, 32);
            this.btnHusbandBlank.TabIndex = 3;
            this.btnHusbandBlank.Text = "Dejar en blanco";
            this.btnHusbandBlank.UseVisualStyleBackColor = true;
            // 
            // btnHusbandValidate
            // 
            this.btnHusbandValidate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHusbandValidate.Location = new System.Drawing.Point(46, 86);
            this.btnHusbandValidate.Name = "btnHusbandValidate";
            this.btnHusbandValidate.Size = new System.Drawing.Size(158, 32);
            this.btnHusbandValidate.TabIndex = 2;
            this.btnHusbandValidate.Text = "Validar";
            this.btnHusbandValidate.UseVisualStyleBackColor = true;
            // 
            // lblHusbandName
            // 
            this.lblHusbandName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHusbandName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHusbandName.Location = new System.Drawing.Point(141, 56);
            this.lblHusbandName.Name = "lblHusbandName";
            this.lblHusbandName.Size = new System.Drawing.Size(267, 23);
            this.lblHusbandName.TabIndex = 0;
            this.lblHusbandName.Text = "N/A";
            this.lblHusbandName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnWifeBlank
            // 
            this.btnWifeBlank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWifeBlank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWifeBlank.Location = new System.Drawing.Point(234, 86);
            this.btnWifeBlank.Name = "btnWifeBlank";
            this.btnWifeBlank.Size = new System.Drawing.Size(158, 32);
            this.btnWifeBlank.TabIndex = 3;
            this.btnWifeBlank.Text = "Dejar en blanco";
            this.btnWifeBlank.UseVisualStyleBackColor = true;
            // 
            // btnWifeValidate
            // 
            this.btnWifeValidate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWifeValidate.Location = new System.Drawing.Point(46, 86);
            this.btnWifeValidate.Name = "btnWifeValidate";
            this.btnWifeValidate.Size = new System.Drawing.Size(158, 32);
            this.btnWifeValidate.TabIndex = 2;
            this.btnWifeValidate.Text = "Validar";
            this.btnWifeValidate.UseVisualStyleBackColor = true;
            // 
            // lblWifeName
            // 
            this.lblWifeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWifeName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWifeName.Location = new System.Drawing.Point(141, 56);
            this.lblWifeName.Name = "lblWifeName";
            this.lblWifeName.Size = new System.Drawing.Size(267, 23);
            this.lblWifeName.TabIndex = 0;
            this.lblWifeName.Text = "N/A";
            this.lblWifeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tWifeDocument
            // 
            this.tWifeDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tWifeDocument.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tWifeDocument.Location = new System.Drawing.Point(138, 22);
            this.tWifeDocument.Name = "tWifeDocument";
            this.tWifeDocument.Size = new System.Drawing.Size(270, 26);
            this.tWifeDocument.TabIndex = 1;
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
            // gbWife
            // 
            this.gbWife.Controls.Add(this.btnWifeBlank);
            this.gbWife.Controls.Add(this.btnWifeValidate);
            this.gbWife.Controls.Add(this.lblWifeName);
            this.gbWife.Controls.Add(this.tWifeDocument);
            this.gbWife.Controls.Add(this.label17);
            this.gbWife.Controls.Add(this.label18);
            this.gbWife.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbWife.Location = new System.Drawing.Point(494, 182);
            this.gbWife.Name = "gbWife";
            this.gbWife.Size = new System.Drawing.Size(422, 131);
            this.gbWife.TabIndex = 5;
            this.gbWife.TabStop = false;
            this.gbWife.Text = "Datos de la esposa";
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
            // lblWitName
            // 
            this.lblWitName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWitName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWitName.Location = new System.Drawing.Point(141, 56);
            this.lblWitName.Name = "lblWitName";
            this.lblWitName.Size = new System.Drawing.Size(267, 23);
            this.lblWitName.TabIndex = 0;
            this.lblWitName.Text = "N/A";
            this.lblWitName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.gbWitness.Controls.Add(this.lblWitName);
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
            this.label22.Location = new System.Drawing.Point(18, 377);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(172, 23);
            this.label22.TabIndex = 0;
            this.label22.Text = "Notario:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tNotary
            // 
            this.tNotary.FormattingEnabled = true;
            this.tNotary.Location = new System.Drawing.Point(203, 377);
            this.tNotary.Name = "tNotary";
            this.tNotary.Size = new System.Drawing.Size(265, 23);
            this.tNotary.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAccept.Location = new System.Drawing.Point(365, 466);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(215, 32);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // cDepartment
            // 
            this.cDepartment.FormattingEnabled = true;
            this.cDepartment.Location = new System.Drawing.Point(191, 56);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.Size = new System.Drawing.Size(265, 25);
            this.cDepartment.TabIndex = 2;
            // 
            // cCity
            // 
            this.cCity.FormattingEnabled = true;
            this.cCity.Location = new System.Drawing.Point(191, 88);
            this.cCity.Name = "cCity";
            this.cCity.Size = new System.Drawing.Size(265, 25);
            this.cCity.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(191, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficina:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMatRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 517);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tNotary);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.gbWitness);
            this.Controls.Add(this.gbWife);
            this.Controls.Add(this.gbHusband);
            this.Controls.Add(this.gbAttach);
            this.Controls.Add(this.gbBasics);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormMatRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo registro de matrimonio";
            this.gbBasics.ResumeLayout(false);
            this.gbBasics.PerformLayout();
            this.gbAttach.ResumeLayout(false);
            this.gbAttach.PerformLayout();
            this.gbHusband.ResumeLayout(false);
            this.gbHusband.PerformLayout();
            this.gbWife.ResumeLayout(false);
            this.gbWife.PerformLayout();
            this.gbWitness.ResumeLayout(false);
            this.gbWitness.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbBasics;
        private System.Windows.Forms.TextBox tSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tAttachDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbAttach;
        private System.Windows.Forms.DateTimePicker tBirthDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tAttachtype;
        private System.Windows.Forms.TextBox tHusbandDocument;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbHusband;
        private System.Windows.Forms.Button btnHusbandBlank;
        private System.Windows.Forms.Button btnHusbandValidate;
        private System.Windows.Forms.Label lblHusbandName;
        private System.Windows.Forms.Button btnWifeBlank;
        private System.Windows.Forms.Button btnWifeValidate;
        private System.Windows.Forms.Label lblWifeName;
        private System.Windows.Forms.TextBox tWifeDocument;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbWife;
        private System.Windows.Forms.Button btnWitBlank;
        private System.Windows.Forms.Button btnWitValidate;
        private System.Windows.Forms.Label lblWitName;
        private System.Windows.Forms.TextBox tWitDocument;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox gbWitness;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox tNotary;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox cCity;
        private System.Windows.Forms.ComboBox cDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}