﻿namespace helper
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.SheetMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doneSheetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSheetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearSheetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.insertColumnSheetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OrganaizedGrid = new System.Windows.Forms.DataGridView();
            this.OrganizedMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneToolOrgMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolOrgMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CleartoolOrgMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRowTOrgMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceOrgMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.qcCheckOrgMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoOrgMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLoadFile = new System.Windows.Forms.ToolStripButton();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DropCat = new System.Windows.Forms.ToolStripComboBox();
            this.btnAnalayze = new System.Windows.Forms.ToolStripButton();
            this.btnSaveSheet = new System.Windows.Forms.ToolStripButton();
            this.btnCreateBulk = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.BulkGrid = new System.Windows.Forms.DataGridView();
            this.BulkMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExportBulkMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EnglishTxtBox = new System.Windows.Forms.TextBox();
            this.ArabicTxtBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBAR = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTranslatedCellCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnRebulk = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SheetMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrganaizedGrid)).BeginInit();
            this.OrganizedMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulkGrid)).BeginInit();
            this.BulkMenu.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1011, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Imported";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 28);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.GridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.OrganaizedGrid);
            this.splitContainer2.Size = new System.Drawing.Size(1005, 368);
            this.splitContainer2.SplitterDistance = 395;
            this.splitContainer2.TabIndex = 2;
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToOrderColumns = true;
            this.GridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.ContextMenuStrip = this.SheetMenu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.GridView1.Location = new System.Drawing.Point(0, 0);
            this.GridView1.Name = "GridView1";
            this.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView1.Size = new System.Drawing.Size(395, 368);
            this.GridView1.TabIndex = 1;
            this.GridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellContentClick);
            this.GridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellEndEdit);
            this.GridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView1_ColumnHeaderMouseClick);
            this.GridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView1_RowHeaderMouseClick);
            this.GridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridView1_KeyDown);
            // 
            // SheetMenu
            // 
            this.SheetMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem1,
            this.insertColumnSheetMenu});
            this.SheetMenu.Name = "contextMenuStrip1";
            this.SheetMenu.Size = new System.Drawing.Size(212, 48);
            // 
            // colorsToolStripMenuItem1
            // 
            this.colorsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doneSheetMenu,
            this.cancelSheetMenu,
            this.ClearSheetMenu});
            this.colorsToolStripMenuItem1.Name = "colorsToolStripMenuItem1";
            this.colorsToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.colorsToolStripMenuItem1.Text = "Format by Color";
            // 
            // doneSheetMenu
            // 
            this.doneSheetMenu.Name = "doneSheetMenu";
            this.doneSheetMenu.Size = new System.Drawing.Size(133, 22);
            this.doneSheetMenu.Text = "Done";
            this.doneSheetMenu.Click += new System.EventHandler(this.doneToolMenuSheet_Click);
            // 
            // cancelSheetMenu
            // 
            this.cancelSheetMenu.Name = "cancelSheetMenu";
            this.cancelSheetMenu.Size = new System.Drawing.Size(133, 22);
            this.cancelSheetMenu.Text = "Cancel";
            this.cancelSheetMenu.Click += new System.EventHandler(this.cancelToolSheetMenu_Click);
            // 
            // ClearSheetMenu
            // 
            this.ClearSheetMenu.Name = "ClearSheetMenu";
            this.ClearSheetMenu.Size = new System.Drawing.Size(133, 22);
            this.ClearSheetMenu.Text = "Clear Color";
            this.ClearSheetMenu.Click += new System.EventHandler(this.CleartoolSheetMenu_Click);
            // 
            // insertColumnSheetMenu
            // 
            this.insertColumnSheetMenu.Name = "insertColumnSheetMenu";
            this.insertColumnSheetMenu.Size = new System.Drawing.Size(211, 22);
            this.insertColumnSheetMenu.Text = "Insert Comments Column";
            this.insertColumnSheetMenu.Click += new System.EventHandler(this.insertColumnToolStripMenuItem_Click);
            // 
            // OrganaizedGrid
            // 
            this.OrganaizedGrid.AllowUserToOrderColumns = true;
            this.OrganaizedGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OrganaizedGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrganaizedGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.OrganaizedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrganaizedGrid.ContextMenuStrip = this.OrganizedMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrganaizedGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrganaizedGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrganaizedGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.OrganaizedGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.OrganaizedGrid.Location = new System.Drawing.Point(0, 0);
            this.OrganaizedGrid.Name = "OrganaizedGrid";
            this.OrganaizedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.OrganaizedGrid.Size = new System.Drawing.Size(606, 368);
            this.OrganaizedGrid.TabIndex = 1;
            this.OrganaizedGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.OrganaizedGrid_CellBeginEdit);
            this.OrganaizedGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganaizedGrid_CellClick);
            this.OrganaizedGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganaizedGrid_CellContentClick);
            this.OrganaizedGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganaizedGrid_CellEndEdit);
            this.OrganaizedGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganaizedGrid_CellLeave);
            this.OrganaizedGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrganaizedGrid_CellValueChanged);
            this.OrganaizedGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrganaizedGrid_ColumnHeaderMouseClick);
            this.OrganaizedGrid.CurrentCellChanged += new System.EventHandler(this.OrganaizedGrid_CurrentCellChanged_1);
            this.OrganaizedGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrganaizedGrid_RowHeaderMouseClick);
            this.OrganaizedGrid.SelectionChanged += new System.EventHandler(this.OrganaizedGrid_SelectionChanged_1);
            this.OrganaizedGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrganaizedGrid_KeyDown);
            // 
            // OrganizedMenu
            // 
            this.OrganizedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem,
            this.removeRowTOrgMenu,
            this.replaceOrgMenu,
            this.qcCheckOrgMenu,
            this.UndoOrgMenu});
            this.OrganizedMenu.Name = "OrganizedMenu";
            this.OrganizedMenu.Size = new System.Drawing.Size(171, 114);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doneToolOrgMenu,
            this.cancelToolOrgMenu,
            this.CleartoolOrgMenu});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.colorsToolStripMenuItem.Text = "Format by Color";
            // 
            // doneToolOrgMenu
            // 
            this.doneToolOrgMenu.Name = "doneToolOrgMenu";
            this.doneToolOrgMenu.Size = new System.Drawing.Size(133, 22);
            this.doneToolOrgMenu.Text = "Done";
            this.doneToolOrgMenu.Click += new System.EventHandler(this.doneToolOrgMenu_Click);
            // 
            // cancelToolOrgMenu
            // 
            this.cancelToolOrgMenu.Name = "cancelToolOrgMenu";
            this.cancelToolOrgMenu.Size = new System.Drawing.Size(133, 22);
            this.cancelToolOrgMenu.Text = "Cancel";
            this.cancelToolOrgMenu.Click += new System.EventHandler(this.cancelToolOrgMenu_Click);
            // 
            // CleartoolOrgMenu
            // 
            this.CleartoolOrgMenu.Name = "CleartoolOrgMenu";
            this.CleartoolOrgMenu.Size = new System.Drawing.Size(133, 22);
            this.CleartoolOrgMenu.Text = "Clear Color";
            this.CleartoolOrgMenu.Click += new System.EventHandler(this.CleartoolOrgMenu_Click);
            // 
            // removeRowTOrgMenu
            // 
            this.removeRowTOrgMenu.Name = "removeRowTOrgMenu";
            this.removeRowTOrgMenu.Size = new System.Drawing.Size(170, 22);
            this.removeRowTOrgMenu.Text = "Remove Row";
            this.removeRowTOrgMenu.Click += new System.EventHandler(this.removeRowToolStripMenuItem_Click);
            // 
            // replaceOrgMenu
            // 
            this.replaceOrgMenu.Name = "replaceOrgMenu";
            this.replaceOrgMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.replaceOrgMenu.Size = new System.Drawing.Size(170, 22);
            this.replaceOrgMenu.Text = "Replace";
            this.replaceOrgMenu.Click += new System.EventHandler(this.ReplaceOrgMenu_Click);
            // 
            // qcCheckOrgMenu
            // 
            this.qcCheckOrgMenu.Name = "qcCheckOrgMenu";
            this.qcCheckOrgMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.qcCheckOrgMenu.Size = new System.Drawing.Size(170, 22);
            this.qcCheckOrgMenu.Text = "QC Check";
            this.qcCheckOrgMenu.Click += new System.EventHandler(this.btnQC_Click);
            // 
            // UndoOrgMenu
            // 
            this.UndoOrgMenu.Name = "UndoOrgMenu";
            this.UndoOrgMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoOrgMenu.Size = new System.Drawing.Size(170, 22);
            this.UndoOrgMenu.Text = "Undo";
            this.UndoOrgMenu.Click += new System.EventHandler(this.Undo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadFile,
            this.ComboBox1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.DropCat,
            this.btnAnalayze,
            this.btnSaveSheet,
            this.btnCreateBulk,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1005, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadFile.Image")));
            this.btnLoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(55, 22);
            this.btnLoadFile.Text = "LoadFile";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(25, 0, 1, 0);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 25);
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabel1.Text = "Choose Category";
            // 
            // DropCat
            // 
            this.DropCat.Items.AddRange(new object[] {
            "Perfume",
            "Refrigerators & Freezers",
            "MakeUp"});
            this.DropCat.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.DropCat.Name = "DropCat";
            this.DropCat.Size = new System.Drawing.Size(200, 25);
            // 
            // btnAnalayze
            // 
            this.btnAnalayze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAnalayze.Image = ((System.Drawing.Image)(resources.GetObject("btnAnalayze.Image")));
            this.btnAnalayze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnalayze.Margin = new System.Windows.Forms.Padding(25, 1, 0, 2);
            this.btnAnalayze.Name = "btnAnalayze";
            this.btnAnalayze.Size = new System.Drawing.Size(58, 22);
            this.btnAnalayze.Text = "Analayze";
            this.btnAnalayze.Click += new System.EventHandler(this.btnAnalayze_Click);
            // 
            // btnSaveSheet
            // 
            this.btnSaveSheet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSaveSheet.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSheet.Image")));
            this.btnSaveSheet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveSheet.Name = "btnSaveSheet";
            this.btnSaveSheet.Size = new System.Drawing.Size(92, 22);
            this.btnSaveSheet.Text = "Export Sheet";
            this.btnSaveSheet.Click += new System.EventHandler(this.btnSaveSheet_Click);
            // 
            // btnCreateBulk
            // 
            this.btnCreateBulk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCreateBulk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreateBulk.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateBulk.Image")));
            this.btnCreateBulk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateBulk.Name = "btnCreateBulk";
            this.btnCreateBulk.Size = new System.Drawing.Size(71, 22);
            this.btnCreateBulk.Text = "Create Bulk";
            this.btnCreateBulk.Click += new System.EventHandler(this.btnCreateBulk_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton5.Text = "test Functions";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Controls.Add(this.BulkGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1011, 399);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bulk Sheet";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1005, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 22);
            this.btnSave.Text = "Export Bulk Sheet";
            this.btnSave.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // BulkGrid
            // 
            this.BulkGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BulkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BulkGrid.ContextMenuStrip = this.BulkMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BulkGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.BulkGrid.Location = new System.Drawing.Point(3, 31);
            this.BulkGrid.Name = "BulkGrid";
            this.BulkGrid.Size = new System.Drawing.Size(1005, 368);
            this.BulkGrid.TabIndex = 0;
            // 
            // BulkMenu
            // 
            this.BulkMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportBulkMenu});
            this.BulkMenu.Name = "BulkMenu";
            this.BulkMenu.Size = new System.Drawing.Size(174, 26);
            // 
            // ExportBulkMenu
            // 
            this.ExportBulkMenu.Name = "ExportBulkMenu";
            this.ExportBulkMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ExportBulkMenu.Size = new System.Drawing.Size(173, 22);
            this.ExportBulkMenu.Text = "Export Bulk";
            this.ExportBulkMenu.Click += new System.EventHandler(this.btnSaveSheet_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.toolStrip4);
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1011, 399);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Translation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.btnRebulk});
            this.toolStrip4.Location = new System.Drawing.Point(3, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(1005, 25);
            this.toolStrip4.TabIndex = 1;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton4.Text = "Save";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EnglishTxtBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ArabicTxtBox);
            this.splitContainer1.Size = new System.Drawing.Size(1009, 372);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 0;
            // 
            // EnglishTxtBox
            // 
            this.EnglishTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnglishTxtBox.Location = new System.Drawing.Point(0, 0);
            this.EnglishTxtBox.Multiline = true;
            this.EnglishTxtBox.Name = "EnglishTxtBox";
            this.EnglishTxtBox.Size = new System.Drawing.Size(336, 372);
            this.EnglishTxtBox.TabIndex = 0;
            // 
            // ArabicTxtBox
            // 
            this.ArabicTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArabicTxtBox.Location = new System.Drawing.Point(0, 0);
            this.ArabicTxtBox.Multiline = true;
            this.ArabicTxtBox.Name = "ArabicTxtBox";
            this.ArabicTxtBox.Size = new System.Drawing.Size(669, 372);
            this.ArabicTxtBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtStatus,
            this.ProgressBAR,
            this.toolStripStatusLabel2,
            this.txtTranslatedCellCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1019, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status: ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(39, 17);
            this.txtStatus.Text = "Ready";
            // 
            // ProgressBAR
            // 
            this.ProgressBAR.Margin = new System.Windows.Forms.Padding(15, 3, 1, 3);
            this.ProgressBAR.Name = "ProgressBAR";
            this.ProgressBAR.Size = new System.Drawing.Size(100, 16);
            this.ProgressBAR.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBAR.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(897, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "Untranslated Cells:";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTranslatedCellCount
            // 
            this.txtTranslatedCellCount.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.txtTranslatedCellCount.Name = "txtTranslatedCellCount";
            this.txtTranslatedCellCount.Size = new System.Drawing.Size(13, 17);
            this.txtTranslatedCellCount.Text = "0";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1019, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1019, 425);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // btnRebulk
            // 
            this.btnRebulk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRebulk.Image = ((System.Drawing.Image)(resources.GetObject("btnRebulk.Image")));
            this.btnRebulk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRebulk.Name = "btnRebulk";
            this.btnRebulk.Size = new System.Drawing.Size(47, 22);
            this.btnRebulk.Text = "ReBulk";
            this.btnRebulk.Click += new System.EventHandler(this.btnCreateBulk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 447);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content Helper";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.SheetMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrganaizedGrid)).EndInit();
            this.OrganizedMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulkGrid)).EndInit();
            this.BulkMenu.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLoadFile;
        private System.Windows.Forms.ToolStripComboBox ComboBox1;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAnalayze;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView BulkGrid;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripComboBox DropCat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBAR;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox EnglishTxtBox;
        private System.Windows.Forms.TextBox ArabicTxtBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtTranslatedCellCount;
        private System.Windows.Forms.ContextMenuStrip SheetMenu;
        private System.Windows.Forms.ContextMenuStrip OrganizedMenu;
        private System.Windows.Forms.ToolStripMenuItem removeRowTOrgMenu;
        private System.Windows.Forms.ToolStripMenuItem insertColumnSheetMenu;
        private System.Windows.Forms.ToolStripButton btnSaveSheet;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView OrganaizedGrid;
        private System.Windows.Forms.ToolStripButton btnCreateBulk;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneToolOrgMenu;
        private System.Windows.Forms.ToolStripMenuItem cancelToolOrgMenu;
        private System.Windows.Forms.ToolStripMenuItem CleartoolOrgMenu;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doneSheetMenu;
        private System.Windows.Forms.ToolStripMenuItem cancelSheetMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearSheetMenu;
        private System.Windows.Forms.ToolStripMenuItem replaceOrgMenu;
        private System.Windows.Forms.ToolStripMenuItem qcCheckOrgMenu;
        private System.Windows.Forms.ToolStripMenuItem UndoOrgMenu;
        private System.Windows.Forms.ContextMenuStrip BulkMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportBulkMenu;
        private System.Windows.Forms.ToolStripButton btnRebulk;
    }
}

