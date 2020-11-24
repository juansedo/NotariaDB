using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NotariaDB.Views.Components
{
    class ValidatorBoxFlyweight: GroupBox
    {
        private string _name;

        private Button _btnBlank = new Button();
        private Button _btnValidate = new Button();

        private TextBox _tDocument = new TextBox();
        private Label _labelName = new Label();
        private Label _labelDocument = new Label();
        private Label _nameConfirmation = new Label();


        public ValidatorBoxFlyweight(string name) : base()
        {
            _name = name;

            this.SuspendLayout();

            SetButtons();

            SetControls();

            this.Controls.Add(_btnBlank);
            this.Controls.Add(_btnValidate);

            this.Controls.Add(_labelName);
            this.Controls.Add(_labelDocument);
            this.Controls.Add(_tDocument);
            this.Controls.Add(_nameConfirmation);

            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "gb" + name;
            this.Size = new System.Drawing.Size(422, 131);
            this.TabStop = false;
            this.Text = "Datos de " + name;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void SetControls()
        {
            System.Drawing.Font fontRegular = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            System.Drawing.Font fontSmallBold = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            /**
             * TextBox Document
             */
            _tDocument.Font = fontRegular;
            _tDocument.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _tDocument.Location = new System.Drawing.Point(138, 22);
            _tDocument.Name = _name + "tDocument";
            _tDocument.Size = new System.Drawing.Size(270, 26);
            _tDocument.TabIndex = 1;
            

            /**
             * Label "Nombre:"
             */
            _labelName.Font = fontRegular;
            _labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            _labelName.Location = new System.Drawing.Point(12, 56);
            _labelName.Size = new System.Drawing.Size(123, 23);
            _labelName.TabIndex = 0;
            _labelName.Text = "Nombre:";
            _labelName.Name = _name + "labelName";

            /**
             * Label "Documento:"
             */
            _labelDocument.Font = fontRegular;
            _labelDocument.Location = new System.Drawing.Point(12, 24);
            _labelDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            _labelDocument.Size = new System.Drawing.Size(123, 23);
            _labelDocument.TabIndex = 0;
            _labelDocument.Text = "Documento:";
            _labelDocument.Name = _name + "labelDocument";

            /**
             * Label Confirmation Name
             */
            _nameConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            _nameConfirmation.Font = fontSmallBold;
            _nameConfirmation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _nameConfirmation.Location = new System.Drawing.Point(141, 56);
            _nameConfirmation.Size = new System.Drawing.Size(267, 23);
            _nameConfirmation.TabIndex = 0;
            _nameConfirmation.Text = "N/A";
            _nameConfirmation.Name = _name + "ConfirmText";
        }

        private void SetButtons()
        {
            System.Drawing.Font fontRegular = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            /**
             * Button Validate
             */
            this._btnValidate.Font = fontRegular;
            this._btnValidate.Location = new System.Drawing.Point(46, 86);
            this._btnValidate.Name = _name + "btnValidate";
            this._btnValidate.Size = new System.Drawing.Size(158, 32);
            this._btnValidate.TabIndex = 2;
            this._btnValidate.Text = "Validar";
            this._btnValidate.UseVisualStyleBackColor = true;

            /**
             * Button Blank
             */
            this._btnBlank.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this._btnBlank.Font = fontRegular;
            this._btnBlank.Location = new System.Drawing.Point(234, 86);
            this._btnBlank.Name = _name + "btnBlank";
            this._btnBlank.Size = new System.Drawing.Size(158, 32);
            this._btnBlank.TabIndex = 3;
            this._btnBlank.Text = "Dejar en blanco";
            this._btnBlank.UseVisualStyleBackColor = true;
        }

        public void SetValidationName(string text)
        {
            _nameConfirmation.Text = text;
        }

        public void SetLocation(System.Drawing.Point location)
        {
            this.Location = location;
        }

        public string GetText()
        {
            return _tDocument.Text;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
