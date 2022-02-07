using SqlIndexManager.Net461.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlIndexManager.Net461
{
    public partial class CreateIndexForm : Form
    {
        private bool IsUnique { get; set; }
        private string TableName { get; set; }
        private List<string> ListCol { get; set; }
        private List<string> ListIncludeCol { get; set; }

        public CreateIndexForm(string tableName)
        {
            InitializeComponent();
            TableName = tableName;

            ListField();
        }

        private void ListField()
        {
            var dal = new IndexRepo();
            var listField = dal.ListField(TableName);
            ListFieldGrid.DataSource = listField;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListFieldGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.Button != MouseButtons.Right)
                return;

            var fieldName = grid.CurrentRow.Cells["FieldName"].Value.ToString();
            ListIncludeCol.Add(fieldName);

        }

        private void ListFieldGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var fieldName = grid.CurrentRow.Cells["FieldName"].Value.ToString();
            ListCol.Add(fieldName);

            GenCreateIndexScript();
        }

        private void GenCreateIndexScript()
        {
            string script;
            if (ClusteredCheck.Checked)
            {
                if (UniqueCheck.Checked)
                    script = "CREATE UNIQUE CLUSTERED INDEX UCX_";
                else
                    script = "CREATE CLUSTERED INDEX CX_";
            }
            else
            {
                if (UniqueCheck.Checked)
                    script = "CREATE UNIQUE INDEX UX_";
                else
                    script = "CREATE INDEX IX_";
            }
            script = "IX_";

            script += $"{TableName}_";

            script += $"{ListCol.FirstOrDefault() ?? string.Empty}\n";

            script += $"ON {TableName} (";

            foreach (var field in ListCol)
                script += $"{field},";

            script = script.Substring(0, script.Length - 1);
            script += ")\n";

            if(ListIncludeCol.Count != 0)
            {
                script += $"INCLUDE (";
                foreach(var col in ListIncludeCol)
                    script += $"{col},";
                script = script.Substring(0, script.Length - 1);
                script += ")\n";
            }

            if (FillFactorCheck.Checked)
                script += $"WITH(FILLFACTOR={FillFactorNum})";

            ScriptTextBox.Text = script;
        }
    }
}
