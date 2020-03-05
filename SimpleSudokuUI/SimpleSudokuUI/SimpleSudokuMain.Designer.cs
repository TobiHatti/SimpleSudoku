namespace SimpleSudokuUI
{
    partial class SimpleSudokuMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleSudokuMain));
            this.rbcMenu = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.pbxSudokuGrid = new System.Windows.Forms.PictureBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.rbcMenu)).BeginInit();
            this.rbcMenu.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSudokuGrid)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbcMenu
            // 
            this.rbcMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbcMenu.Header.AddMainItem(toolStripTabItem1);
            this.rbcMenu.Location = new System.Drawing.Point(1, 0);
            this.rbcMenu.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rbcMenu.MenuButtonText = "";
            this.rbcMenu.MenuButtonWidth = 56;
            this.rbcMenu.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.rbcMenu.Name = "rbcMenu";
            this.rbcMenu.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.Managed;
            this.rbcMenu.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // rbcMenu.OfficeMenu
            // 
            this.rbcMenu.OfficeMenu.Name = "OfficeMenu";
            this.rbcMenu.OfficeMenu.ShowItemToolTips = true;
            this.rbcMenu.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.rbcMenu.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rbcMenu.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.rbcMenu.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.rbcMenu.SelectedTab = this.toolStripTabItem1;
            this.rbcMenu.ShowRibbonDisplayOptionButton = true;
            this.rbcMenu.Size = new System.Drawing.Size(512, 133);
            this.rbcMenu.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.rbcMenu.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.rbcMenu.TabIndex = 0;
            this.rbcMenu.Text = "ribbonControlAdv1";
            this.rbcMenu.ThemeName = "Office2016";
            this.rbcMenu.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.rbcMenu.ThemeStyle.ControlBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.rbcMenu.ThemeStyle.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbcMenu.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.rbcMenu.TitleColor = System.Drawing.Color.Black;
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // rbcMenu.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "Start";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(47, 30);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "Start";
            // 
            // pbxSudokuGrid
            // 
            this.pbxSudokuGrid.BackColor = System.Drawing.Color.White;
            this.pbxSudokuGrid.Location = new System.Drawing.Point(5, 139);
            this.pbxSudokuGrid.Name = "pbxSudokuGrid";
            this.pbxSudokuGrid.Size = new System.Drawing.Size(500, 500);
            this.pbxSudokuGrid.TabIndex = 1;
            this.pbxSudokuGrid.TabStop = false;
            this.pbxSudokuGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxSudokuGrid_Paint);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 50;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStripEx1.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Office12Mode = false;
            this.toolStripEx1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripEx1.Size = new System.Drawing.Size(468, 64);
            this.toolStripEx1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.rbcMenu.SetDescription(this.toolStripButton1, "Solve");
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 47);
            this.toolStripButton1.Text = "Solve";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // SimpleSudokuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Borders = new System.Windows.Forms.Padding(0);
            this.ClientSize = new System.Drawing.Size(510, 645);
            this.Controls.Add(this.pbxSudokuGrid);
            this.Controls.Add(this.rbcMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimpleSudokuMain";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ShowApplicationIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Sudoku";
            ((System.ComponentModel.ISupportInitialize)(this.rbcMenu)).EndInit();
            this.rbcMenu.ResumeLayout(false);
            this.rbcMenu.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSudokuGrid)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv rbcMenu;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private System.Windows.Forms.PictureBox pbxSudokuGrid;
        private System.Windows.Forms.Timer tmrUpdate;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

