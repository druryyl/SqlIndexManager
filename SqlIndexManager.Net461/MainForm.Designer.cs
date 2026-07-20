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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZilongIndexManagerForm));
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
            this.ExecuteScriptButton = new System.Windows.Forms.Button();
            this.CreateTableCheckBox = new System.Windows.Forms.CheckBox();
            this.ScriptText = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PanelIndex = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListIndexTableGrid = new System.Windows.Forms.DataGridView();
            this.ListTableIndexDefGrid = new System.Windows.Forms.DataGridView();
            this.ResultSamaCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultBedaFieldCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultBelumAdaCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultTidakPerluCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultBedaIndexCheckBox = new System.Windows.Forms.CheckBox();
            this.CountSamaLabel = new System.Windows.Forms.Label();
            this.CountBedaFieldLabel = new System.Windows.Forms.Label();
            this.CountBedaIndexLabel = new System.Windows.Forms.Label();
            this.CountBelumAdaLabel = new System.Windows.Forms.Label();
            this.CountTidakPerluLabel = new System.Windows.Forms.Label();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1034, 24);
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
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
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
            this.MainPanelIndexManager.Size = new System.Drawing.Size(1020, 570);
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
            this.IndexManagerSplit.Size = new System.Drawing.Size(1005, 526);
            this.IndexManagerSplit.SplitterDistance = 316;
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
            this.ListIndexGrid.Size = new System.Drawing.Size(1005, 316);
            this.ListIndexGrid.TabIndex = 8;
            // 
            // IndexDefGrid
            // 
            this.IndexDefGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.IndexDefGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndexDefGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndexDefGrid.Location = new System.Drawing.Point(0, 0);
            this.IndexDefGrid.Name = "IndexDefGrid";
            this.IndexDefGrid.Size = new System.Drawing.Size(1005, 206);
            this.IndexDefGrid.TabIndex = 1;
            // 
            // ReadIndexButton
            // 
            this.ReadIndexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadIndexButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.ReadIndexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadIndexButton.Location = new System.Drawing.Point(913, 6);
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
            this.SearchText.Size = new System.Drawing.Size(901, 22);
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
            this.MainPanelDbCompare.Size = new System.Drawing.Size(1020, 570);
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
            this.DbComparerSplit.Panel1.Controls.Add(this.CountTidakPerluLabel);
            this.DbComparerSplit.Panel1.Controls.Add(this.CountBelumAdaLabel);
            this.DbComparerSplit.Panel1.Controls.Add(this.CountBedaIndexLabel);
            this.DbComparerSplit.Panel1.Controls.Add(this.CountBedaFieldLabel);
            this.DbComparerSplit.Panel1.Controls.Add(this.CountSamaLabel);
            this.DbComparerSplit.Panel1.Controls.Add(this.ResultBedaIndexCheckBox);
            this.DbComparerSplit.Panel1.Controls.Add(this.ResultTidakPerluCheckBox);
            this.DbComparerSplit.Panel1.Controls.Add(this.ResultBelumAdaCheckBox);
            this.DbComparerSplit.Panel1.Controls.Add(this.ResultBedaFieldCheckBox);
            this.DbComparerSplit.Panel1.Controls.Add(this.ResultSamaCheckBox);
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
            this.DbComparerSplit.Size = new System.Drawing.Size(1007, 558);
            this.DbComparerSplit.SplitterDistance = 414;
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
            this.ListTable1Grid.Size = new System.Drawing.Size(404, 469);
            this.ListTable1Grid.TabIndex = 1;
            // 
            // FilterTableNameText
            // 
            this.FilterTableNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTableNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterTableNameText.Location = new System.Drawing.Point(8, 8);
            this.FilterTableNameText.Name = "FilterTableNameText";
            this.FilterTableNameText.Size = new System.Drawing.Size(324, 22);
            this.FilterTableNameText.TabIndex = 10;
            // 
            // ReadDatabaseButton
            // 
            this.ReadDatabaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadDatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.ReadDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadDatabaseButton.Location = new System.Drawing.Point(338, 8);
            this.ReadDatabaseButton.Name = "ReadDatabaseButton";
            this.ReadDatabaseButton.Size = new System.Drawing.Size(74, 22);
            this.ReadDatabaseButton.TabIndex = 11;
            this.ReadDatabaseButton.Text = "Read DB";
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
            this.PenalField.Size = new System.Drawing.Size(576, 512);
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
            this.splitContainer2.Size = new System.Drawing.Size(576, 512);
            this.splitContainer2.SplitterDistance = 229;
            this.splitContainer2.TabIndex = 3;
            // 
            // ListField1Grid
            // 
            this.ListField1Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ListField1Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListField1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListField1Grid.Location = new System.Drawing.Point(0, 0);
            this.ListField1Grid.Name = "ListField1Grid";
            this.ListField1Grid.Size = new System.Drawing.Size(576, 229);
            this.ListField1Grid.TabIndex = 2;
            // 
            // ExecuteScriptButton
            // 
            this.ExecuteScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteScriptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.ExecuteScriptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteScriptButton.Location = new System.Drawing.Point(446, 3);
            this.ExecuteScriptButton.Name = "ExecuteScriptButton";
            this.ExecuteScriptButton.Size = new System.Drawing.Size(110, 24);
            this.ExecuteScriptButton.TabIndex = 12;
            this.ExecuteScriptButton.Text = "Execute Script";
            this.ExecuteScriptButton.UseVisualStyleBackColor = false;
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
            this.ScriptText.Size = new System.Drawing.Size(575, 244);
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
            this.PanelIndex.Size = new System.Drawing.Size(576, 512);
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
            this.splitContainer1.Size = new System.Drawing.Size(576, 512);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 1;
            // 
            // ListIndexTableGrid
            // 
            this.ListIndexTableGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ListIndexTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListIndexTableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListIndexTableGrid.Location = new System.Drawing.Point(0, 0);
            this.ListIndexTableGrid.Name = "ListIndexTableGrid";
            this.ListIndexTableGrid.Size = new System.Drawing.Size(576, 195);
            this.ListIndexTableGrid.TabIndex = 1;
            // 
            // ListTableIndexDefGrid
            // 
            this.ListTableIndexDefGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.ListTableIndexDefGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTableIndexDefGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListTableIndexDefGrid.Location = new System.Drawing.Point(0, 0);
            this.ListTableIndexDefGrid.Name = "ListTableIndexDefGrid";
            this.ListTableIndexDefGrid.Size = new System.Drawing.Size(576, 313);
            this.ListTableIndexDefGrid.TabIndex = 2;
            // 
            // ResultSamaCheckBox
            // 
            this.ResultSamaCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultSamaCheckBox.AutoSize = true;
            this.ResultSamaCheckBox.Location = new System.Drawing.Point(8, 512);
            this.ResultSamaCheckBox.Name = "ResultSamaCheckBox";
            this.ResultSamaCheckBox.Size = new System.Drawing.Size(53, 17);
            this.ResultSamaCheckBox.TabIndex = 13;
            this.ResultSamaCheckBox.Text = "Sama";
            this.ResultSamaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultBedaFieldCheckBox
            // 
            this.ResultBedaFieldCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultBedaFieldCheckBox.AutoSize = true;
            this.ResultBedaFieldCheckBox.Checked = true;
            this.ResultBedaFieldCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResultBedaFieldCheckBox.Location = new System.Drawing.Point(67, 512);
            this.ResultBedaFieldCheckBox.Name = "ResultBedaFieldCheckBox";
            this.ResultBedaFieldCheckBox.Size = new System.Drawing.Size(80, 17);
            this.ResultBedaFieldCheckBox.TabIndex = 14;
            this.ResultBedaFieldCheckBox.Text = "Beda Field";
            this.ResultBedaFieldCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultBelumAdaCheckBox
            // 
            this.ResultBelumAdaCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultBelumAdaCheckBox.AutoSize = true;
            this.ResultBelumAdaCheckBox.Checked = true;
            this.ResultBelumAdaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResultBelumAdaCheckBox.Location = new System.Drawing.Point(242, 512);
            this.ResultBelumAdaCheckBox.Name = "ResultBelumAdaCheckBox";
            this.ResultBelumAdaCheckBox.Size = new System.Drawing.Size(81, 17);
            this.ResultBelumAdaCheckBox.TabIndex = 16;
            this.ResultBelumAdaCheckBox.Text = "Belum Ada";
            this.ResultBelumAdaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultTidakPerluCheckBox
            // 
            this.ResultTidakPerluCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultTidakPerluCheckBox.AutoSize = true;
            this.ResultTidakPerluCheckBox.Location = new System.Drawing.Point(329, 512);
            this.ResultTidakPerluCheckBox.Name = "ResultTidakPerluCheckBox";
            this.ResultTidakPerluCheckBox.Size = new System.Drawing.Size(82, 17);
            this.ResultTidakPerluCheckBox.TabIndex = 17;
            this.ResultTidakPerluCheckBox.Text = "Tidak Perlu";
            this.ResultTidakPerluCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResultBedaIndexCheckBox
            // 
            this.ResultBedaIndexCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultBedaIndexCheckBox.AutoSize = true;
            this.ResultBedaIndexCheckBox.Location = new System.Drawing.Point(153, 512);
            this.ResultBedaIndexCheckBox.Name = "ResultBedaIndexCheckBox";
            this.ResultBedaIndexCheckBox.Size = new System.Drawing.Size(83, 17);
            this.ResultBedaIndexCheckBox.TabIndex = 15;
            this.ResultBedaIndexCheckBox.Text = "Beda Index";
            this.ResultBedaIndexCheckBox.UseVisualStyleBackColor = true;
            // 
            // CountSamaLabel
            // 
            this.CountSamaLabel.Location = new System.Drawing.Point(8, 532);
            this.CountSamaLabel.Name = "CountSamaLabel";
            this.CountSamaLabel.Size = new System.Drawing.Size(53, 17);
            this.CountSamaLabel.TabIndex = 18;
            this.CountSamaLabel.Text = "0";
            this.CountSamaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountBedaFieldLabel
            // 
            this.CountBedaFieldLabel.Location = new System.Drawing.Point(67, 532);
            this.CountBedaFieldLabel.Name = "CountBedaFieldLabel";
            this.CountBedaFieldLabel.Size = new System.Drawing.Size(80, 17);
            this.CountBedaFieldLabel.TabIndex = 19;
            this.CountBedaFieldLabel.Text = "0";
            this.CountBedaFieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountBedaIndexLabel
            // 
            this.CountBedaIndexLabel.Location = new System.Drawing.Point(153, 532);
            this.CountBedaIndexLabel.Name = "CountBedaIndexLabel";
            this.CountBedaIndexLabel.Size = new System.Drawing.Size(83, 17);
            this.CountBedaIndexLabel.TabIndex = 20;
            this.CountBedaIndexLabel.Text = "0";
            this.CountBedaIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountBelumAdaLabel
            // 
            this.CountBelumAdaLabel.Location = new System.Drawing.Point(242, 532);
            this.CountBelumAdaLabel.Name = "CountBelumAdaLabel";
            this.CountBelumAdaLabel.Size = new System.Drawing.Size(81, 17);
            this.CountBelumAdaLabel.TabIndex = 21;
            this.CountBelumAdaLabel.Text = "0";
            this.CountBelumAdaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountTidakPerluLabel
            // 
            this.CountTidakPerluLabel.Location = new System.Drawing.Point(329, 532);
            this.CountTidakPerluLabel.Name = "CountTidakPerluLabel";
            this.CountTidakPerluLabel.Size = new System.Drawing.Size(82, 17);
            this.CountTidakPerluLabel.TabIndex = 22;
            this.CountTidakPerluLabel.Text = "0";
            this.CountTidakPerluLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZilongIndexManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(180)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1034, 631);
            this.Controls.Add(this.MainPanelDbCompare);
            this.Controls.Add(this.MainPanelIndexManager);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ZilongIndexManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zilong DB-Tools";
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
        private System.Windows.Forms.CheckBox ResultSamaCheckBox;
        private System.Windows.Forms.CheckBox ResultBedaFieldCheckBox;
        private System.Windows.Forms.CheckBox ResultTidakPerluCheckBox;
        private System.Windows.Forms.CheckBox ResultBelumAdaCheckBox;
        private System.Windows.Forms.CheckBox ResultBedaIndexCheckBox;
        private System.Windows.Forms.Label CountSamaLabel;
        private System.Windows.Forms.Label CountTidakPerluLabel;
        private System.Windows.Forms.Label CountBelumAdaLabel;
        private System.Windows.Forms.Label CountBedaIndexLabel;
        private System.Windows.Forms.Label CountBedaFieldLabel;
    }
}

