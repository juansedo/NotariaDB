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
            this.components = new System.ComponentModel.Container();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.panel_search = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageNAC = new System.Windows.Forms.TabPage();
            this.tabPageMAT = new System.Windows.Forms.TabPage();
            this.tabPageDEF = new System.Windows.Forms.TabPage();
            this.tabPageUSER = new System.Windows.Forms.TabPage();
            this.btnNewRegister = new System.Windows.Forms.Button();
            this.btnEditRegister = new System.Windows.Forms.Button();
            this.btnDeleteRegister = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
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
            this.tboxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tboxSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxSearch.Location = new System.Drawing.Point(32, 55);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.PlaceholderText = "Buscar...";
            this.tboxSearch.Size = new System.Drawing.Size(249, 26);
            this.tboxSearch.TabIndex = 1;
            // 
            // panel_search
            // 
            this.panel_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_search.Controls.Add(this.lblBuscador);
            this.panel_search.Controls.Add(this.tboxSearch);
            this.panel_search.Location = new System.Drawing.Point(685, 12);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(313, 511);
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
            this.tabControl.Location = new System.Drawing.Point(12, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(667, 460);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageNAC
            // 
            this.tabPageNAC.Location = new System.Drawing.Point(4, 24);
            this.tabPageNAC.Name = "tabPageNAC";
            this.tabPageNAC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNAC.Size = new System.Drawing.Size(659, 432);
            this.tabPageNAC.TabIndex = 0;
            this.tabPageNAC.Text = "NACIMIENTOS";
            // 
            // tabPageMAT
            // 
            this.tabPageMAT.Location = new System.Drawing.Point(4, 24);
            this.tabPageMAT.Name = "tabPageMAT";
            this.tabPageMAT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMAT.Size = new System.Drawing.Size(659, 432);
            this.tabPageMAT.TabIndex = 1;
            this.tabPageMAT.Text = "MATRIMONIOS";
            this.tabPageMAT.UseVisualStyleBackColor = true;
            // 
            // tabPageDEF
            // 
            this.tabPageDEF.Location = new System.Drawing.Point(4, 24);
            this.tabPageDEF.Name = "tabPageDEF";
            this.tabPageDEF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDEF.Size = new System.Drawing.Size(659, 432);
            this.tabPageDEF.TabIndex = 2;
            this.tabPageDEF.Text = "DEFUNCIONES";
            this.tabPageDEF.UseVisualStyleBackColor = true;
            // 
            // tabPageUSER
            // 
            this.tabPageUSER.Location = new System.Drawing.Point(4, 24);
            this.tabPageUSER.Name = "tabPageUSER";
            this.tabPageUSER.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUSER.Size = new System.Drawing.Size(659, 432);
            this.tabPageUSER.TabIndex = 3;
            this.tabPageUSER.Text = "USUARIOS";
            this.tabPageUSER.UseVisualStyleBackColor = true;
            // 
            // btnNewRegister
            // 
            this.btnNewRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRegister.FlatAppearance.BorderSize = 0;
            this.btnNewRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRegister.Location = new System.Drawing.Point(16, 11);
            this.btnNewRegister.Name = "btnNewRegister";
            this.btnNewRegister.Size = new System.Drawing.Size(50, 50);
            this.btnNewRegister.TabIndex = 6;
            this.btnNewRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewRegister.UseVisualStyleBackColor = false;
            this.btnNewRegister.Click += new System.EventHandler(this.btnNewRegister_Click);
            // 
            // btnEditRegister
            // 
            this.btnEditRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRegister.FlatAppearance.BorderSize = 0;
            this.btnEditRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRegister.Location = new System.Drawing.Point(72, 11);
            this.btnEditRegister.Name = "btnEditRegister";
            this.btnEditRegister.Size = new System.Drawing.Size(50, 50);
            this.btnEditRegister.TabIndex = 6;
            this.btnEditRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditRegister.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRegister
            // 
            this.btnDeleteRegister.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRegister.FlatAppearance.BorderSize = 0;
            this.btnDeleteRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRegister.Location = new System.Drawing.Point(128, 11);
            this.btnDeleteRegister.Name = "btnDeleteRegister";
            this.btnDeleteRegister.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteRegister.TabIndex = 6;
            this.btnDeleteRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteRegister.UseVisualStyleBackColor = false;
            this.btnDeleteRegister.Click += new System.EventHandler(this.btnDeleteRegister_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUserInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserInfo.FlatAppearance.BorderSize = 0;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Location = new System.Drawing.Point(196, 11);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(50, 50);
            this.btnUserInfo.TabIndex = 6;
            this.btnUserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserInfo.UseVisualStyleBackColor = false;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Location = new System.Drawing.Point(252, 11);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(50, 50);
            this.btnPDF.TabIndex = 6;
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(320, 11);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(50, 50);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.btnDeleteRegister);
            this.Controls.Add(this.btnEditRegister);
            this.Controls.Add(this.btnNewRegister);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel_search);
            this.MinimumSize = new System.Drawing.Size(754, 371);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTARIA DB";
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        

        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageNAC;
        private System.Windows.Forms.TabPage tabPageMAT;
        private System.Windows.Forms.TabPage tabPageDEF;
        private System.Windows.Forms.TabPage tabPageUSER;
        private Button btnNewRegister;
        private Button btnEditRegister;
        private Button btnDeleteRegister;
        private Button btnUserInfo;
        private ToolTip toolTip;
        private Button btnPDF;
        private Button btnExcel;
    }
}

