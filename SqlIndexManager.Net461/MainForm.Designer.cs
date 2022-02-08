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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IndexProfileGroup = new System.Windows.Forms.GroupBox();
            this.ActiveProfileLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ReadIndexButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LoadExternalProfileButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.DbTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TestConnectionButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ListIndexGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IndexDefGrid = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.IndexProfileGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListIndexGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndexDefGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(932, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(908, 510);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IndexProfileGroup);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 510);
            this.panel1.TabIndex = 0;
            // 
            // IndexProfileGroup
            // 
            this.IndexProfileGroup.Controls.Add(this.button2);
            this.IndexProfileGroup.Controls.Add(this.ActiveProfileLabel);
            this.IndexProfileGroup.Controls.Add(this.button5);
            this.IndexProfileGroup.Controls.Add(this.button4);
            this.IndexProfileGroup.Controls.Add(this.button1);
            this.IndexProfileGroup.Controls.Add(this.ReadIndexButton);
            this.IndexProfileGroup.Controls.Add(this.button3);
            this.IndexProfileGroup.Controls.Add(this.LoadExternalProfileButton);
            this.IndexProfileGroup.Location = new System.Drawing.Point(3, 223);
            this.IndexProfileGroup.Name = "IndexProfileGroup";
            this.IndexProfileGroup.Size = new System.Drawing.Size(241, 281);
            this.IndexProfileGroup.TabIndex = 10;
            this.IndexProfileGroup.TabStop = false;
            this.IndexProfileGroup.Text = "Index Profile";
            // 
            // ActiveProfileLabel
            // 
            this.ActiveProfileLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ActiveProfileLabel.Location = new System.Drawing.Point(9, 74);
            this.ActiveProfileLabel.Name = "ActiveProfileLabel";
            this.ActiveProfileLabel.Size = new System.Drawing.Size(226, 18);
            this.ActiveProfileLabel.TabIndex = 3;
            this.ActiveProfileLabel.Text = "No Index Profile";
            this.ActiveProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(226, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Load DB Profile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.LoadDBProfile_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(226, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "View Profile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ViewProfileButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gen Create Script Form Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReadIndexButton
            // 
            this.ReadIndexButton.Location = new System.Drawing.Point(9, 25);
            this.ReadIndexButton.Name = "ReadIndexButton";
            this.ReadIndexButton.Size = new System.Drawing.Size(226, 23);
            this.ReadIndexButton.TabIndex = 7;
            this.ReadIndexButton.Text = "List Available Index";
            this.ReadIndexButton.UseVisualStyleBackColor = true;
            this.ReadIndexButton.Click += new System.EventHandler(this.ReadIndexButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Save As External Profile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveAsProfileButton_Click);
            // 
            // LoadExternalProfileButton
            // 
            this.LoadExternalProfileButton.Location = new System.Drawing.Point(9, 124);
            this.LoadExternalProfileButton.Name = "LoadExternalProfileButton";
            this.LoadExternalProfileButton.Size = new System.Drawing.Size(226, 23);
            this.LoadExternalProfileButton.TabIndex = 5;
            this.LoadExternalProfileButton.Text = "Load External Profile";
            this.LoadExternalProfileButton.UseVisualStyleBackColor = true;
            this.LoadExternalProfileButton.Click += new System.EventHandler(this.LoadExternalProfileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PassTextBox);
            this.groupBox1.Controls.Add(this.ServerTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UserIdTextBox);
            this.groupBox1.Controls.Add(this.DbTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TestConnectionButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 217);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassTextBox.Location = new System.Drawing.Point(12, 157);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(232, 22);
            this.PassTextBox.TabIndex = 8;
            this.PassTextBox.Validated += new System.EventHandler(this.PassTextBox_Validated);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerTextBox.Location = new System.Drawing.Point(12, 34);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(232, 22);
            this.ServerTextBox.TabIndex = 1;
            this.ServerTextBox.Validated += new System.EventHandler(this.ServerTextBox_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserIdTextBox.Location = new System.Drawing.Point(12, 116);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(232, 22);
            this.UserIdTextBox.TabIndex = 6;
            this.UserIdTextBox.Validated += new System.EventHandler(this.UserIdTextBox_Validated);
            // 
            // DbTextBox
            // 
            this.DbTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DbTextBox.Location = new System.Drawing.Point(12, 75);
            this.DbTextBox.Name = "DbTextBox";
            this.DbTextBox.Size = new System.Drawing.Size(232, 22);
            this.DbTextBox.TabIndex = 3;
            this.DbTextBox.Validated += new System.EventHandler(this.DbTextBox_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "User Name";
            // 
            // TestConnectionButton
            // 
            this.TestConnectionButton.Location = new System.Drawing.Point(12, 185);
            this.TestConnectionButton.Name = "TestConnectionButton";
            this.TestConnectionButton.Size = new System.Drawing.Size(226, 23);
            this.TestConnectionButton.TabIndex = 4;
            this.TestConnectionButton.Text = "Test Connection";
            this.TestConnectionButton.UseVisualStyleBackColor = true;
            this.TestConnectionButton.Click += new System.EventHandler(this.TestConnectionButton_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(654, 510);
            this.splitContainer2.SplitterDistance = 363;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchText);
            this.groupBox2.Controls.Add(this.ListIndexGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 363);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Index List";
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Location = new System.Drawing.Point(6, 21);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(636, 22);
            this.SearchText.TabIndex = 2;
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchText_KeyDown);
            // 
            // ListIndexGrid
            // 
            this.ListIndexGrid.AllowUserToAddRows = false;
            this.ListIndexGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListIndexGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListIndexGrid.Location = new System.Drawing.Point(6, 49);
            this.ListIndexGrid.Name = "ListIndexGrid";
            this.ListIndexGrid.ReadOnly = true;
            this.ListIndexGrid.Size = new System.Drawing.Size(636, 308);
            this.ListIndexGrid.TabIndex = 0;
            this.ListIndexGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListIndexGrid_CellDoubleClick);
            this.ListIndexGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListIndexGrid_CellMouseDown);
            this.ListIndexGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ListIndexGrid_DataBindingComplete);
            this.ListIndexGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListIndexGrid_RowEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IndexDefGrid);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(654, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Index Definition";
            // 
            // IndexDefGrid
            // 
            this.IndexDefGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IndexDefGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndexDefGrid.Location = new System.Drawing.Point(6, 21);
            this.IndexDefGrid.Name = "IndexDefGrid";
            this.IndexDefGrid.Size = new System.Drawing.Size(636, 116);
            this.IndexDefGrid.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Gen Drop Script";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ZilongIndexManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 547);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ZilongIndexManagerForm";
            this.Text = "Zilong Index Manager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.IndexProfileGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListIndexGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IndexDefGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TestConnectionButton;
        private System.Windows.Forms.TextBox DbTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView ListIndexGrid;
        private System.Windows.Forms.DataGridView IndexDefGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox IndexProfileGroup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button LoadExternalProfileButton;
        private System.Windows.Forms.Button ReadIndexButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label ActiveProfileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

