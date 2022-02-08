using Dapper;
using Microsoft.Win32;
using SqlIndexManager.Net461.Model;
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
    public partial class ZilongIndexManagerForm : Form
    {
        public ZilongIndexManagerForm()
        {
            InitializeComponent();
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("SqlIndexManager");
            ServerTextBox.Text = regKey.GetValue("Server", string.Empty)?.ToString()??string.Empty;
            DbTextBox.Text = regKey.GetValue("Database", string.Empty)?.ToString() ?? string.Empty;
            UserIdTextBox.Text = regKey.GetValue("UserID", string.Empty)?.ToString() ?? string.Empty;
            PassTextBox.Text = regKey.GetValue("Password", string.Empty)?.ToString() ?? string.Empty;
            regKey.Close();
        }

        private void TestConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                InitConnection();
                MessageBox.Show("Test Succesfull");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ReadIndexButton_Click(object sender, EventArgs e)
        {
            ReadIndex();
        }

        private void ServerTextBox_Validated(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("SqlIndexManager");
            regKey.SetValue("Server", textBox.Text);
            regKey.Close();
        }

        private void DbTextBox_Validated(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("SqlIndexManager");
            regKey.SetValue("Database", textBox.Text);
            regKey.Close();
        }

        private void UserIdTextBox_Validated(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("SqlIndexManager");
            regKey.SetValue("UserID", textBox.Text);
            regKey.Close();
        }

        private void PassTextBox_Validated(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("SqlIndexManager");
            regKey.SetValue("Password", textBox.Text);
            regKey.Close();
        }

        private void ListIndexGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var tableName = grid.CurrentRow.Cells["TableName"].Value.ToString();

            var currentRowIndex = grid.CurrentRow.Index;
            var firstDisplayRow = grid.FirstDisplayedCell.RowIndex;

            CreateIndex(tableName);
            ReadIndex();
            
            grid.CurrentCell = grid.Rows[currentRowIndex].Cells[0];
            grid.FirstDisplayedScrollingRowIndex = firstDisplayRow;


        }

        private void CreateIndex(string tableName)
        {

            var creteIndexForm = new CreateIndexForm(tableName.ToLower().Trim());
            creteIndexForm.ShowDialog();
        }
        private void ListIndexGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            var indexName = grid.CurrentRow.Cells["IndexName"].Value?.ToString()??string.Empty;
            var tableName = grid.CurrentRow.Cells["TableName"].Value?.ToString()??string.Empty;
            if (indexName == string.Empty)
                return;


            if (e.Button == MouseButtons.Right)
            {
                var currentRowIndex = grid.CurrentRow.Index;
                var firstDisplayRow = grid.FirstDisplayedCell.RowIndex;

                DeleteIndex(indexName, tableName);
                ReadIndex();
                
                grid.CurrentCell = grid.Rows[currentRowIndex].Cells[0];
                grid.FirstDisplayedScrollingRowIndex = firstDisplayRow;
            }
        }

        private void ListIndexGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var indexName = grid.Rows[e.RowIndex]?.Cells["IndexName"].Value?.ToString() ?? string.Empty;
            var tableName = grid.Rows[e.RowIndex]?.Cells["TableName"].Value?.ToString() ?? string.Empty;

            ViewIndexDef(indexName, tableName);
        }

        private void InitConnection()
        {
            ConnStringHelper.Set(
                ServerTextBox.Text,
                DbTextBox.Text,
                UserIdTextBox.Text,
                PassTextBox.Text);
        }

        private void ReadIndex()
        {
            InitConnection();
            var dal = new IndexRepo();
            var listIndex = dal.ListIndex();

            IEnumerable<IndexModel> result;
            if (SearchText.Text.Length > 0)
                result = listIndex.Where(x => x.TableName.ToLower().Contains(SearchText.Text.ToLower()));
            else
                result = listIndex;

            ListIndexGrid.DataSource = result.ToList();
            //ListIndexGrid.AutoResizeColumns();
            ListIndexGrid.Columns[0].Width = 200;
            ListIndexGrid.Columns[1].Width = 225;
            //ListIndexGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //ListIndexGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //ListIndexGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }

        private void DeleteIndex(string indexName, string tableName)
        {
            if (MessageBox.Show($"Delete Index {indexName} on {tableName}?", "Delete Index", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                string sql;
                sql = $"DROP INDEX [{indexName}] ON [{tableName}]";
                using (var conn = new SqlConnection(ConnStringHelper.Get()))
                {
                    conn.Execute(sql);
                }

            }
            catch (SqlException ex)
            {
                string sql;
                sql = $"ALTER TABLE [{tableName}] DROP CONSTRAINT [{indexName}]";
                using (var conn = new SqlConnection(ConnStringHelper.Get()))
                {
                    conn.Execute(sql);
                } 
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }   
            
        }

        private void ViewIndexDef(string indexName, string tableName)
        {
            if(indexName == String.Empty)
                IndexDefGrid.DataSource = null;

            var dal = new IndexRepo();
            var listIndexDef = dal.ListIndexDef(indexName, tableName);
            IndexDefGrid.DataSource = listIndexDef;
        }

        private void ListIndexGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
                gridView.RowHeadersWidth = 70;
            }
        }

        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                 ReadIndex();
        }
    }
}
