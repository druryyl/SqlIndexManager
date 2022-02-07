namespace SqlIndexManager.Net461
{
    partial class CreateIndexForm
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
            this.ListFieldGrid = new System.Windows.Forms.DataGridView();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.ClusteredCheck = new System.Windows.Forms.CheckBox();
            this.UniqueCheck = new System.Windows.Forms.CheckBox();
            this.FillFactorNum = new System.Windows.Forms.NumericUpDown();
            this.FillFactorCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListFieldGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillFactorNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ListFieldGrid
            // 
            this.ListFieldGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListFieldGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFieldGrid.Location = new System.Drawing.Point(12, 12);
            this.ListFieldGrid.Name = "ListFieldGrid";
            this.ListFieldGrid.Size = new System.Drawing.Size(449, 298);
            this.ListFieldGrid.TabIndex = 0;
            this.ListFieldGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListFieldGrid_CellDoubleClick);
            this.ListFieldGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListFieldGrid_CellMouseDown);
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptTextBox.Location = new System.Drawing.Point(12, 316);
            this.ScriptTextBox.Multiline = true;
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(449, 71);
            this.ScriptTextBox.TabIndex = 1;
            // 
            // ClusteredCheck
            // 
            this.ClusteredCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClusteredCheck.AutoSize = true;
            this.ClusteredCheck.Location = new System.Drawing.Point(12, 393);
            this.ClusteredCheck.Name = "ClusteredCheck";
            this.ClusteredCheck.Size = new System.Drawing.Size(75, 17);
            this.ClusteredCheck.TabIndex = 2;
            this.ClusteredCheck.Text = "Clustered";
            this.ClusteredCheck.UseVisualStyleBackColor = true;
            // 
            // UniqueCheck
            // 
            this.UniqueCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UniqueCheck.AutoSize = true;
            this.UniqueCheck.Location = new System.Drawing.Point(93, 393);
            this.UniqueCheck.Name = "UniqueCheck";
            this.UniqueCheck.Size = new System.Drawing.Size(64, 17);
            this.UniqueCheck.TabIndex = 3;
            this.UniqueCheck.Text = "Unique";
            this.UniqueCheck.UseVisualStyleBackColor = true;
            // 
            // FillFactorNum
            // 
            this.FillFactorNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FillFactorNum.Location = new System.Drawing.Point(245, 392);
            this.FillFactorNum.Name = "FillFactorNum";
            this.FillFactorNum.Size = new System.Drawing.Size(53, 22);
            this.FillFactorNum.TabIndex = 4;
            // 
            // FillFactorCheck
            // 
            this.FillFactorCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FillFactorCheck.AutoSize = true;
            this.FillFactorCheck.Location = new System.Drawing.Point(163, 393);
            this.FillFactorCheck.Name = "FillFactorCheck";
            this.FillFactorCheck.Size = new System.Drawing.Size(76, 17);
            this.FillFactorCheck.TabIndex = 5;
            this.FillFactorCheck.Text = "Fill Factor";
            this.FillFactorCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(304, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(386, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Execute";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CreateIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 430);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FillFactorCheck);
            this.Controls.Add(this.FillFactorNum);
            this.Controls.Add(this.UniqueCheck);
            this.Controls.Add(this.ClusteredCheck);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.ListFieldGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateIndexForm";
            this.Text = "CreateIndexForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListFieldGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillFactorNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListFieldGrid;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.CheckBox ClusteredCheck;
        private System.Windows.Forms.CheckBox UniqueCheck;
        private System.Windows.Forms.NumericUpDown FillFactorNum;
        private System.Windows.Forms.CheckBox FillFactorCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}