using Dapper;
using SqlIndexManager.Net461.Extensions;
using SqlIndexManager.Net461.Model;
using SqlIndexManager.Net461.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SqlIndexManager.Net461
{
    public partial class CreateIndexForm : Form
    {
        private IndexProfileDto _indexProfile;
        private string _tableName;
        private ConnectionModel _conn;

        public CreateIndexForm(string tableName, ConnectionModel conn)
        {
            InitializeComponent();
            _tableName = tableName;
            _conn = conn;
            Reset();

            ListField();
        }

        private void ListField()
        {
            var dal = new IndexRepo(_conn);
            var listField = dal.ListField(_indexProfile.TableName);
            ListFieldGrid.DataSource = listField;
        }

        private void Reset()
        {
            _indexProfile = new IndexProfileDto();
            _indexProfile.TableName = _tableName;
            _indexProfile.ListIndexDef = new List<IndexDefProfileDto>();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
            GenCreateIndexScript();
        }

        private void ListFieldGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (e.Button != MouseButtons.Right)
                return;

            var fieldName = grid.CurrentRow.Cells["FieldName"].Value.ToString();
            var indexDef = new IndexDefProfileDto()
            {
                ColName = fieldName.ToLower(),
                IsIncludeCol = true,
                ColOrder = _indexProfile.ListIndexDef.Count() + 1
            };
            _indexProfile.ListIndexDef.Add(indexDef);
            GenCreateIndexScript();

        }

        private void ListFieldGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var fieldName = grid.CurrentRow.Cells["FieldName"].Value.ToString();
            var indexDef = new IndexDefProfileDto()
            {
                ColName = fieldName.ToLower(),
                IsIncludeCol = false,
                ColOrder = _indexProfile.ListIndexDef.Count() + 1
            };
            _indexProfile.ListIndexDef.Add(indexDef);

            GenCreateIndexScript();
        }

        private void GenCreateIndexScript()
        {
            ScriptTextBox.Text = _indexProfile.GenCreateIndexScript();
            //ScriptTextBox.Text = String.Empty;
            //if (ClusteredCheck.Checked)
            //{
            //    if (UniqueCheck.Checked)
            //        ScriptTextBox.AppendText("CREATE UNIQUE CLUSTERED INDEX UCX_");
            //    else
            //        ScriptTextBox.AppendText("CREATE CLUSTERED INDEX CX_");
            //}
            //else
            //{
            //    if (UniqueCheck.Checked)
            //        ScriptTextBox.AppendText("CREATE UNIQUE INDEX UX_");
            //    else
            //        ScriptTextBox.AppendText("CREATE INDEX IX_");
            //}

            //ScriptTextBox.AppendText($"{TableName}_");

            //ScriptTextBox.AppendText($"{ListCol.FirstOrDefault() ?? string.Empty}");
            //ScriptTextBox.AppendText(Environment.NewLine);
            //ScriptTextBox.AppendText("    ");

            //ScriptTextBox.AppendText($"ON {TableName} (");

            //foreach (var field in ListCol)
            //    ScriptTextBox.AppendText($"{field},");

            //ScriptTextBox.Text = ScriptTextBox.Text.Substring(0, ScriptTextBox.Text.Length - 1);
            //ScriptTextBox.AppendText(")");
            //ScriptTextBox.AppendText(Environment.NewLine);
            //ScriptTextBox.AppendText("    ");


            //if (ListIncludeCol.Count != 0)
            //{
            //    ScriptTextBox.AppendText($"INCLUDE (");
            //    foreach (var col in ListIncludeCol)
            //        ScriptTextBox.AppendText($"{col},");
            //    ScriptTextBox.Text = ScriptTextBox.Text.Substring(0, ScriptTextBox.Text.Length - 1);
            //    ScriptTextBox.AppendText(")");
            //    ScriptTextBox.AppendText(Environment.NewLine);
            //    ScriptTextBox.AppendText("    ");
            //}

            //if (FillFactorCheck.Checked)
            //    ScriptTextBox.AppendText($"WITH(FILLFACTOR={FillFactorNum.Value})");
        }

        private void ClusteredCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ClusteredCheck.Checked)
                _indexProfile.IndexType = "CLUSTERED";
            else
                _indexProfile.IndexType = "NON CLUSTERED";

            GenCreateIndexScript();
        }

        private void UniqueCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UniqueCheck.Checked)
                _indexProfile.IsUnique = true;
            else
                _indexProfile.IsUnique = false;
            GenCreateIndexScript();

        }

        private void FillFactorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (FillFactorCheck.Checked)
                _indexProfile.FillFactorA = Convert.ToInt16(FillFactorNum.Value);
            else
                _indexProfile.FillFactorA = 0;

            GenCreateIndexScript();

        }

        private void FillFactorNum_ValueChanged(object sender, EventArgs e)
        {
            if (FillFactorCheck.Checked)
                _indexProfile.FillFactorA = Convert.ToInt16(FillFactorNum.Value);
            else
                _indexProfile.FillFactorA = 0; 
            GenCreateIndexScript();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using(var conn = new SqlConnection(_conn.ConnectionString))
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

        private void PrimaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PrimaryCheckBox.Checked)
                _indexProfile.IsPrimaryKey = true;
            else
                _indexProfile.IsPrimaryKey = false;
            GenCreateIndexScript();
        }
    }
}
