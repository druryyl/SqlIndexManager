using Dapper;
using SqlIndexManager.Net461.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            ListCol = new List<string>();
            ListIncludeCol = new List<string>();

            ListField();
        }

        private void ListField()
        {
            var dal = new IndexRepo();
            var listField = dal.ListField(TableName);
            ListFieldGrid.DataSource = listField;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ListCol = new List<string>();
            ListIncludeCol = new List<string>();
            GenCreateIndexScript();
        }

        private void ListFieldGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.Button != MouseButtons.Right)
                return;

            var fieldName = grid.CurrentRow.Cells["FieldName"].Value.ToString();
            ListIncludeCol.Add(fieldName.ToLower());
            GenCreateIndexScript();

        }

        private void ListFieldGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var fieldName = grid.CurrentRow.Cells["FieldName"].Value.ToString();
            ListCol.Add(fieldName.ToLower());

            GenCreateIndexScript();
        }

        private void GenCreateIndexScript()
        {
            ScriptTextBox.Text = String.Empty;
            if (ClusteredCheck.Checked)
            {
                if (UniqueCheck.Checked)
                    ScriptTextBox.AppendText("CREATE UNIQUE CLUSTERED INDEX UCX_");
                else
                    ScriptTextBox.AppendText("CREATE CLUSTERED INDEX CX_");
            }
            else
            {
                if (UniqueCheck.Checked)
                    ScriptTextBox.AppendText("CREATE UNIQUE INDEX UX_");
                else
                    ScriptTextBox.AppendText("CREATE INDEX IX_");
            }

            ScriptTextBox.AppendText($"{TableName}_");

            ScriptTextBox.AppendText($"{ListCol.FirstOrDefault() ?? string.Empty}");
            ScriptTextBox.AppendText(Environment.NewLine);
            ScriptTextBox.AppendText("    ");

            ScriptTextBox.AppendText($"ON {TableName} (");

            foreach (var field in ListCol)
                ScriptTextBox.AppendText($"{field},");

            ScriptTextBox.Text = ScriptTextBox.Text.Substring(0, ScriptTextBox.Text.Length - 1);
            ScriptTextBox.AppendText(")");
            ScriptTextBox.AppendText(Environment.NewLine);
            ScriptTextBox.AppendText("    ");


            if (ListIncludeCol.Count != 0)
            {
                ScriptTextBox.AppendText($"INCLUDE (");
                foreach (var col in ListIncludeCol)
                    ScriptTextBox.AppendText($"{col},");
                ScriptTextBox.Text = ScriptTextBox.Text.Substring(0, ScriptTextBox.Text.Length - 1);
                ScriptTextBox.AppendText(")");
                ScriptTextBox.AppendText(Environment.NewLine);
                ScriptTextBox.AppendText("    ");
            }

            if (FillFactorCheck.Checked)
                ScriptTextBox.AppendText($"WITH(FILLFACTOR={FillFactorNum.Value})");
        }

        private void ClusteredCheck_CheckedChanged(object sender, EventArgs e)
        {
            GenCreateIndexScript();
        }

        private void UniqueCheck_CheckedChanged(object sender, EventArgs e)
        {
            GenCreateIndexScript();

        }

        private void FillFactorCheck_CheckedChanged(object sender, EventArgs e)
        {
            GenCreateIndexScript();

        }

        private void FillFactorNum_ValueChanged(object sender, EventArgs e)
        {
            GenCreateIndexScript();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using(var conn = new SqlConnection(ConnStringHelper.Get()))
                {
                    conn.Execute(ScriptTextBox.Text);
                }
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
