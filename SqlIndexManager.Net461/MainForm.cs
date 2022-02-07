using Dapper;
using Microsoft.Win32;
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

        private void InitConnection()
        {
            ConnStringHelper.Set(
                ServerTextBox.Text,
                DbTextBox.Text,
                UserIdTextBox.Text,
                PassTextBox.Text);
        }

        private void ReadIndexButton_Click(object sender, EventArgs e)
        {
            ReadIndex();
        }

        private void ReadIndex()
        {
            InitConnection();
            var dal = new IndexRepo();
            var listIndex = dal.ListIndex();
            ListIndexGrid.DataSource = listIndex;
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
            var creteIndexForm = new CreateIndexForm(tableName.ToLower().Trim());

            var currentRowIndex = grid.CurrentRow.Index;
            creteIndexForm.ShowDialog();
            ReadIndex();
            grid.CurrentCell = grid.Rows[currentRowIndex].Cells[0];


        }

        private void ListIndexGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            var indexName = grid.CurrentRow.Cells["IndexName"].Value?.ToString()??string.Empty;
            var tableName = grid.CurrentRow.Cells["TableName"].Value?.ToString()??string.Empty;
            bool isPrimary = Convert.ToBoolean(grid.CurrentRow.Cells["IsPrimaryKey"].Value);
            if (indexName == string.Empty)
                return;


            if (e.Button == MouseButtons.Right)
            {
                var currentRowIndex = grid.CurrentRow.Index;
                DeleteIndex(indexName, tableName, isPrimary);
                ReadIndex();
                grid.CurrentCell = grid.Rows[currentRowIndex].Cells[0];
            }
        }

        private void DeleteIndex(string indexName, string tableName, bool isPrimary)
        {
            if (MessageBox.Show($"Delete Index {indexName} on {tableName}?", "Delete Index", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                string sql;
                if(isPrimary)
                    sql = $"ALTER TABLE {tableName} DROP CONSTRAINT {indexName}";
                else
                    sql = $"DROP INDEX {indexName} ON {tableName}";
                using (var conn = new SqlConnection(ConnStringHelper.Get()))
                {
                    conn.Execute(sql);
                }

            }
            catch (SqlException ex)
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

        private void ListIndexGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var indexName = grid.Rows[e.RowIndex]?.Cells["IndexName"].Value?.ToString() ?? string.Empty;
            var tableName = grid.Rows[e.RowIndex]?.Cells["TableName"].Value?.ToString() ?? string.Empty;

            ViewIndexDef(indexName, tableName);
        }

        private void ListIndexGrid_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void ListIndexGrid_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
