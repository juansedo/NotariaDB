using System.Drawing;
using System.Windows.Forms;

namespace NotariaDB
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBuscador = new System.Windows.Forms.Label();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.excelButton = new System.Windows.Forms.Button();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.panel_search = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNAC = new System.Windows.Forms.TabPage();
            this.tabPageMAT = new System.Windows.Forms.TabPage();
            this.tabPageDEF = new System.Windows.Forms.TabPage();
            this.tabPageUSER = new System.Windows.Forms.TabPage();
            this.nacSheetGridView = new SheetGridView(SheetType.NAC, "nacSheetGridView");
            this.panel_buttons.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscador.Location = new System.Drawing.Point(100, 20);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(113, 23);
            this.lblBuscador.TabIndex = 0;
            this.lblBuscador.Text = "BUSCADOR";
            // 
            // tboxSearch
            // 
            this.tboxSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxSearch.Location = new System.Drawing.Point(32, 55);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PlaceholderText = "Buscar...";
            this.tboxSearch.Size = new System.Drawing.Size(249, 26);
            this.tboxSearch.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(47, 50);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(218, 40);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Agregar registro";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(47, 110);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(218, 40);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Eliminar registro";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // excelButton
            // 
            this.excelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.excelButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.excelButton.Location = new System.Drawing.Point(47, 170);
            this.excelButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(218, 40);
            this.excelButton.TabIndex = 2;
            this.excelButton.Text = "Exportar a Excel";
            this.excelButton.UseVisualStyleBackColor = true;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_buttons.Controls.Add(this.addButton);
            this.panel_buttons.Controls.Add(this.excelButton);
            this.panel_buttons.Controls.Add(this.deleteButton);
            this.panel_buttons.Location = new System.Drawing.Point(685, 267);
            this.panel_buttons.Margin = new System.Windows.Forms.Padding(1);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(313, 260);
            this.panel_buttons.TabIndex = 3;
            // 
            // panel_search
            // 
            this.panel_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_search.Controls.Add(this.lblBuscador);
            this.panel_search.Controls.Add(this.tboxSearch);
            this.panel_search.Location = new System.Drawing.Point(685, 12);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(313, 251);
            this.panel_search.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageNAC);
            this.tabControl.Controls.Add(this.tabPageMAT);
            this.tabControl.Controls.Add(this.tabPageDEF);
            this.tabControl.Controls.Add(this.tabPageUSER);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(667, 515);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageNAC
            //
            this.tabPageNAC.Controls.Add(this.nacSheetGridView);
            this.tabPageNAC.Location = new System.Drawing.Point(4, 24);
            this.tabPageNAC.Name = "tabPageNAC";
            this.tabPageNAC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNAC.Size = new System.Drawing.Size(659, 487);
            this.tabPageNAC.TabIndex = 0;
            this.tabPageNAC.Text = "NACIMIENTOS";
            this.tabPageNAC.UseVisualStyleBackColor = true;
            // 
            // tabPageMAT
            // 
            this.tabPageMAT.Location = new System.Drawing.Point(4, 24);
            this.tabPageMAT.Name = "tabPageMAT";
            this.tabPageMAT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMAT.Size = new System.Drawing.Size(659, 487);
            this.tabPageMAT.TabIndex = 1;
            this.tabPageMAT.Text = "MATRIMONIOS";
            this.tabPageMAT.UseVisualStyleBackColor = true;
            // 
            // tabPageDEF
            // 
            this.tabPageDEF.Location = new System.Drawing.Point(4, 24);
            this.tabPageDEF.Name = "tabPageDEF";
            this.tabPageDEF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDEF.Size = new System.Drawing.Size(659, 487);
            this.tabPageDEF.TabIndex = 2;
            this.tabPageDEF.Text = "DEFUNCIONES";
            this.tabPageDEF.UseVisualStyleBackColor = true;
            // 
            // tabPageUSER
            // 
            this.tabPageUSER.Location = new System.Drawing.Point(4, 24);
            this.tabPageUSER.Name = "tabPageUSER";
            this.tabPageUSER.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUSER.Size = new System.Drawing.Size(659, 487);
            this.tabPageUSER.TabIndex = 3;
            this.tabPageUSER.Text = "USUARIOS";
            this.tabPageUSER.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel_search);
            this.Controls.Add(this.panel_buttons);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "formMain";
            this.Text = "NOTARIA DB";
            this.panel_buttons.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        

        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button excelButton;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNAC;
        private System.Windows.Forms.TabPage tabPageMAT;
        private System.Windows.Forms.TabPage tabPageDEF;
        private System.Windows.Forms.TabPage tabPageUSER;
        private SheetGridView nacSheetGridView;
    }
}

