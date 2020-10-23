namespace NotariaDB
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_buttons.SuspendLayout();
            this.panel_search.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.panel_search.Controls.Add(this.lblBuscador);
            this.panel_search.Controls.Add(this.tboxSearch);
            this.panel_search.Location = new System.Drawing.Point(685, 12);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(313, 251);
            this.panel_search.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 515);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(262, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_search);
            this.Controls.Add(this.panel_buttons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_buttons.ResumeLayout(false);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

