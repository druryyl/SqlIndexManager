namespace SqlIndexManager.Net461
{
    partial class ProfileViewer
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
            this.IndexProfileGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.IndexProfileGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IndexProfileGrid
            // 
            this.IndexProfileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndexProfileGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndexProfileGrid.Location = new System.Drawing.Point(0, 0);
            this.IndexProfileGrid.Name = "IndexProfileGrid";
            this.IndexProfileGrid.ReadOnly = true;
            this.IndexProfileGrid.Size = new System.Drawing.Size(819, 473);
            this.IndexProfileGrid.TabIndex = 0;
            this.IndexProfileGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.IndexProfileGrid_DataBindingComplete);
            // 
            // ProfileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 473);
            this.Controls.Add(this.IndexProfileGrid);
            this.Name = "ProfileViewer";
            this.Text = "ProfileViewer";
            ((System.ComponentModel.ISupportInitialize)(this.IndexProfileGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IndexProfileGrid;
    }
}