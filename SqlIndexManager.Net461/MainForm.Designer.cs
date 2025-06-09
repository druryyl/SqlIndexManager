namespace SqlIndexManager.Net461
{
    partial class ZilongIndexManagerForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Connection1Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Connection2Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanelIndexManager = new System.Windows.Forms.Panel();
            this.IndexManagerSplit = new System.Windows.Forms.SplitContainer();
            this.ListIndexGrid = new System.Windows.Forms.DataGridView();
            this.IndexDefGrid = new System.Windows.Forms.DataGridView();
            this.ReadIndexButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.MainPanelDbCompare = new System.Windows.Forms.Panel();
            this.DbComparerSplit = new System.Windows.Forms.SplitContainer();
            this.ListTable1Grid = new System.Windows.Forms.DataGridView();
            this.FilterTableNameText = new System.Windows.Forms.TextBox();
            this.ReadDatabaseButton = new System.Windows.Forms.Button();
            this.PenalField = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ListField1Grid = new System.Windows.Forms.DataGridView();
            this.CreateTableCheckBox = new System.Windows.Forms.CheckBox();
            this.ScriptText = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PanelIndex = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListIndexTableGrid = new System.Windows.Forms.DataGridView();
            this.ListTableIndexDefGrid = new System.Windows.Forms.DataGridView();
            this.ExecuteScriptButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MainPanelIndexManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndexManagerSplit)).BeginInit();
            this.IndexManagerSplit.Panel1.SuspendLayout();
            this.IndexManagerSplit.Panel2.SuspendLayout();
            this.IndexManagerSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListIndexGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexDefGrid)).BeginInit();
            this.MainPanelDbCompare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DbComparerSplit)).BeginInit();
            this.DbComparerSplit.Panel1.SuspendLayout();
            this.DbComparerSplit.Panel2.SuspendLayout();
            this.DbComparerSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTable1Grid)).BeginInit();
            this.PenalField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListField1Grid)).BeginInit();
            this.PanelIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListIndexTableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListTableIndexDefGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connection1Status,
            this.Connection2Status,
            this.ProgressBarStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(978, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Connection1Status
            // 
            this.Connection1Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(177)))));
            this.Connection1Status.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Connection1Status.ForeColor = System.Drawing.Color.OrangeRed;
            this.Connection1Status.Name = "Connection1Status";
            this.Connection1Status.Size = new System.Drawing.Size(84, 19);
            this.Connection1Status.Text = "Connection-1";
            // 
            // Connection2Status
            // 
            this.Connection2Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(210)))), ((int)(((byte)(234)))));
            this.Connection2Status.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Connection2Status.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Connection2Status.Name = "Connection2Status";
            this.Connection2Status.Size = new System.Drawing.Size(84, 19);
            this.Connection2Status.Text = "Connection-2";
            // 
            // ProgressBarStatus
            // 
            this.ProgressBarStatus.Name = "ProgressBarStatus";
            this.ProgressBarStatus.Size = new System.Drawing.Size(100, 18);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dBCompareToolStripMenuItem,
            this.indexManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.fileToolStripMenuItem.Text = "Server Connection";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.ConnectionMenu_Click);
            // 
            // dBCompareToolStripMenuItem
            // 
            this.dBCompareToolStripMenuItem.Name = "dBCompareToolStripMenuItem";
            this.dBCompareToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.dBCompareToolStripMenuItem.Text = "DB-Compare";
            this.dBCompareToolStripMenuItem.Click += new System.EventHandler(this.dBCompareToolStripMenuItem_Click);
            // 
            // indexManagerToolStripMenuItem
            // 
            this.indexManagerToolStripMenuItem.Name = "indexManagerToolStripMenuItem";
            this.indexManagerToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.indexManagerToolStripMenuItem.Text = "Index-Manager";
            this.indexManagerToolStripMenuItem.Click += new System.EventHandler(this.indexManagerToolStripMenuItem_Click);
            // 
            // MainPanelIndexManager
            // 
            this.MainPanelIndexManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanelIndexManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(236)))), ((int)(((byte)(213)))));
            this.MainPanelIndexManager.Controls.Add(this.IndexManagerSplit);
            this.MainPanelIndexManager.Controls.Add(this.ReadIndexButton);
            this.MainPanelIndexManager.Controls.Add(this.SearchText);
            this.MainPanelIndexManager.Location = new System.Drawing.Point(6, 32);
            this.MainPanelIndexManager.Name = "MainPanelIndexManager";
            this.MainPanelIndexManager.Size = new System.Drawing.Size(964, 430);
            this.MainPanelIndexManager.TabIndex = 4;
            this.MainPanelIndexManager.Visible = false;
            // 
            // IndexManagerSplit
            // 
            this.IndexManagerSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IndexManagerSplit.Location = new System.Drawing.Point(7, 36);
            this.IndexManagerSplit.Name = "IndexManagerSplit";
            this.IndexManagerSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // IndexManagerSplit.Panel1
            // 
            this.IndexManagerSplit.Panel1.Controls.Add(this.ListIndexGrid);
            // 
            // IndexManagerSplit.Panel2
            // 
            this.IndexManagerSplit.Panel2.Controls.Add(this.IndexDefGrid);
            this.IndexManagerSplit.Size = new System.Drawing.Size(949, 386);
            this.IndexManagerSplit.SplitterDistance = 235;
            this.IndexManagerSplit.TabIndex = 10;
            // 
            // ListIndexGrid
            // 
            this.ListIndexGrid.AllowUserToAddRows = false;
            this.ListIndexGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ListIndexGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListIndexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListIndexGrid.Location = new System.Drawing.Point(0, 0);
            this.ListIndexGrid.Name = "ListIndexGrid";
            this.ListIndexGrid.ReadOnly = true;
            this.ListIndexGrid.Size = new System.Drawing.Size(949, 235);
            this.ListIndexGrid.TabIndex = 8;
            // 
            // IndexDefGrid
            // 
            this.IndexDefGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.IndexDefGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndexDefGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndexDefGrid.Location = new System.Drawing.Point(0, 0);
            this.IndexDefGrid.Name = "IndexDefGrid";
            this.IndexDefGrid.Size = new System.Drawing.Size(949, 147);
            this.IndexDefGrid.TabIndex = 1;
            // 
            // ReadIndexButton
            // 
            this.ReadIndexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadIndexButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.ReadIndexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadIndexButton.Location = new System.Drawing.Point(857, 6);
            this.ReadIndexButton.Name = "ReadIndexButton";
            this.ReadIndexButton.Size = new System.Drawing.Size(100, 22);
            this.ReadIndexButton.TabIndex = 9;
            this.ReadIndexButton.Text = "Read Index";
            this.ReadIndexButton.UseVisualStyleBackColor = false;
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchText.Location = new System.Drawing.Point(6, 6);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(845, 22);
            this.SearchText.TabIndex = 8;
            // 
            // MainPanelDbCompare
            // 
            this.MainPanelDbCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanelDbCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(205)))), ((int)(((byte)(156)))));
            this.MainPanelDbCompare.Controls.Add(this.DbComparerSplit);
            this.MainPanelDbCompare.Location = new System.Drawing.Point(6, 32);
            this.MainPanelDbCompare.Name = "MainPanelDbCompare";
            this.MainPanelDbCompare.Size = new System.Drawing.Size(964, 430);
            this.MainPanelDbCompare.TabIndex = 5;
            // 
            // DbComparerSplit
            // 
            this.DbComparerSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbComparerSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(236)))), ((int)(((byte)(213)))));
            this.DbComparerSplit.Location = new System.Drawing.Point(6, 6);
            this.DbComparerSplit.Name = "DbComparerSplit";
            // 
            // DbComparerSplit.Panel1
            // 
            this.DbComparerSplit.Panel1.Controls.Add(this.ListTable1Grid);
            this.DbComparerSplit.Panel1.Controls.Add(this.FilterTableNameText);
            this.DbComparerSplit.Panel1.Controls.Add(this.ReadDatabaseButton);
            // 
            // DbComparerSplit.Panel2
            // 
            this.DbComparerSplit.Panel2.Controls.Add(this.PenalField);
            this.DbComparerSplit.Panel2.Controls.Add(this.radioButton2);
            this.DbComparerSplit.Panel2.Controls.Add(this.radioButton1);
            this.DbComparerSplit.Panel2.Controls.Add(this.PanelIndex);
            this.DbComparerSplit.Size = new System.Drawing.Size(951, 418);
            this.DbComparerSplit.SplitterDistance = 380;
            this.DbComparerSplit.TabIndex = 12;
            // 
            // ListTable1Grid
            // 
            this.ListTable1Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTable1Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ListTable1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTable1Grid.Location = new System.Drawing.Point(8, 37);
            this.ListTable1Grid.Name = "ListTable1Grid";
            this.ListTable1Grid.Size = new System.Drawing.Size(372, 372);
            this.ListTable1Grid.TabIndex = 1;
            // 
            // FilterTableNameText
            // 
            this.FilterTableNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTableNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterTableNameText.Location = new System.Drawing.Point(8, 8);
            this.FilterTableNameText.Name = "FilterTableNameText";
            this.FilterTableNameText.Size = new System.Drawing.Size(253, 22);
            this.FilterTableNameText.TabIndex = 10;
            // 
            // ReadDatabaseButton
            // 
            this.ReadDatabaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadDatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.ReadDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadDatabaseButton.Location = new System.Drawing.Point(267, 8);
            this.ReadDatabaseButton.Name = "ReadDatabaseButton";
            this.ReadDatabaseButton.Size = new System.Drawing.Size(110, 23);
            this.ReadDatabaseButton.TabIndex = 11;
            this.ReadDatabaseButton.Text = "Read DB Scheme";
            this.ReadDatabaseButton.UseVisualStyleBackColor = false;
            // 
            // PenalField
            // 
            this.PenalField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PenalField.Controls.Add(this.splitContainer2);
            this.PenalField.Location = new System.Drawing.Point(6, 37);
            this.PenalField.Name = "PenalField";
            this.PenalField.Size = new System.Drawing.Size(553, 374);
            this.PenalField.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ListField1Grid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ExecuteScriptButton);
            this.splitContainer2.Panel2.Controls.Add(this.CreateTableCheckBox);
            this.splitContainer2.Panel2.Controls.Add(this.ScriptText);
            this.splitContainer2.Size = new System.Drawing.Size(553, 374);
            this.splitContainer2.SplitterDistance = 164;
            this.splitContainer2.TabIndex = 3;
            // 
            // ListField1Grid
            // 
            this.ListField1Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ListField1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListField1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListField1Grid.Location = new System.Drawing.Point(0, 0);
            this.ListField1Grid.Name = "ListField1Grid";
            this.ListField1Grid.Size = new System.Drawing.Size(553, 164);
            this.ListField1Grid.TabIndex = 2;
            // 
            // CreateTableCheckBox
            // 
            this.CreateTableCheckBox.AutoSize = true;
            this.CreateTableCheckBox.Location = new System.Drawing.Point(3, 3);
            this.CreateTableCheckBox.Name = "CreateTableCheckBox";
            this.CreateTableCheckBox.Size = new System.Drawing.Size(88, 17);
            this.CreateTableCheckBox.TabIndex = 1;
            this.CreateTableCheckBox.Text = "Create Table";
            this.CreateTableCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScriptText
            // 
            this.ScriptText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScriptText.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScriptText.Location = new System.Drawing.Point(0, 32);
            this.ScriptText.Multiline = true;
            this.ScriptText.Name = "ScriptText";
            this.ScriptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ScriptText.Size = new System.Drawing.Size(553, 176);
            this.ScriptText.TabIndex = 0;
            this.ScriptText.WordWrap = false;
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(75, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 22);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Indexes";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(6, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 22);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fields";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // PanelIndex
            // 
            this.PanelIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelIndex.Controls.Add(this.splitContainer1);
            this.PanelIndex.Location = new System.Drawing.Point(6, 37);
            this.PanelIndex.Name = "PanelIndex";
            this.PanelIndex.Size = new System.Drawing.Size(553, 374);
            this.PanelIndex.TabIndex = 3;
            this.PanelIndex.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListIndexTableGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ListTableIndexDefGrid);
            this.splitContainer1.Size = new System.Drawing.Size(553, 374);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 1;
            // 
            // ListIndexTableGrid
            // 
            this.ListIndexTableGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ListIndexTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListIndexTableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListIndexTableGrid.Location = new System.Drawing.Point(0, 0);
            this.ListIndexTableGrid.Name = "ListIndexTableGrid";
            this.ListIndexTableGrid.Size = new System.Drawing.Size(553, 140);
            this.ListIndexTableGrid.TabIndex = 1;
            // 
            // ListTableIndexDefGrid
            // 
            this.ListTableIndexDefGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ListTableIndexDefGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTableIndexDefGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListTableIndexDefGrid.Location = new System.Drawing.Point(0, 0);
            this.ListTableIndexDefGrid.Name = "ListTableIndexDefGrid";
            this.ListTableIndexDefGrid.Size = new System.Drawing.Size(553, 230);
            this.ListTableIndexDefGrid.TabIndex = 2;
            // 
            // ExecuteScriptButton
            // 
            this.ExecuteScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteScriptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.ExecuteScriptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteScriptButton.Location = new System.Drawing.Point(424, 3);
            this.ExecuteScriptButton.Name = "ExecuteScriptButton";
            this.ExecuteScriptButton.Size = new System.Drawing.Size(110, 24);
            this.ExecuteScriptButton.TabIndex = 12;
            this.ExecuteScriptButton.Text = "Execute Script";
            this.ExecuteScriptButton.UseVisualStyleBackColor = false;
            // 
            // ZilongIndexManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(180)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(978, 491);
            this.Controls.Add(this.MainPanelDbCompare);
            this.Controls.Add(this.MainPanelIndexManager);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZilongIndexManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zilong Index Manager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanelIndexManager.ResumeLayout(false);
            this.MainPanelIndexManager.PerformLayout();
            this.IndexManagerSplit.Panel1.ResumeLayout(false);
            this.IndexManagerSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IndexManagerSplit)).EndInit();
            this.IndexManagerSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListIndexGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexDefGrid)).EndInit();
            this.MainPanelDbCompare.ResumeLayout(false);
            this.DbComparerSplit.Panel1.ResumeLayout(false);
            this.DbComparerSplit.Panel1.PerformLayout();
            this.DbComparerSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DbComparerSplit)).EndInit();
            this.DbComparerSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListTable1Grid)).EndInit();
            this.PenalField.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListField1Grid)).EndInit();
            this.PanelIndex.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListIndexTableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListTableIndexDefGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Connection1Status;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Connection2Status;
        private System.Windows.Forms.ToolStripProgressBar ProgressBarStatus;
        private System.Windows.Forms.Panel MainPanelIndexManager;
        private System.Windows.Forms.SplitContainer IndexManagerSplit;
        private System.Windows.Forms.DataGridView ListIndexGrid;
        private System.Windows.Forms.DataGridView IndexDefGrid;
        private System.Windows.Forms.Button ReadIndexButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Panel MainPanelDbCompare;
        private System.Windows.Forms.SplitContainer DbComparerSplit;
        private System.Windows.Forms.DataGridView ListTable1Grid;
        private System.Windows.Forms.Panel PenalField;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView ListField1Grid;
        private System.Windows.Forms.TextBox ScriptText;
        private System.Windows.Forms.Button ReadDatabaseButton;
        private System.Windows.Forms.TextBox FilterTableNameText;
        private System.Windows.Forms.Panel PanelIndex;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView ListIndexTableGrid;
        private System.Windows.Forms.DataGridView ListTableIndexDefGrid;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolStripMenuItem dBCompareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexManagerToolStripMenuItem;
        private System.Windows.Forms.CheckBox CreateTableCheckBox;
        private System.Windows.Forms.Button ExecuteScriptButton;
    }
}

