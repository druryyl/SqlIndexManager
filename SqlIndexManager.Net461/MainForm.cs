using Dapper;
using Microsoft.Win32;
using Newtonsoft.Json;
using SqlIndexManager.Net461.Extensions;
using SqlIndexManager.Net461.Model;
using SqlIndexManager.Net461.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlIndexManager.Net461
{
    public partial class ZilongIndexManagerForm : Form
    {
        private List<IndexProfileDto> _listIndexProfile;
        private int _dbID;
        public ZilongIndexManagerForm()
        {
            InitializeComponent();
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("SqlIndexManager");
            ServerTextBox.Text = regKey.GetValue("Server", string.Empty)?.ToString() ?? string.Empty;
            DbTextBox.Text = regKey.GetValue("Database", string.Empty)?.ToString() ?? string.Empty;
            UserIdTextBox.Text = regKey.GetValue("UserID", string.Empty)?.ToString() ?? string.Empty;
            PassTextBox.Text = regKey.GetValue("Password", string.Empty)?.ToString() ?? string.Empty;
            regKey.Close();

            _listIndexProfile = new List<IndexProfileDto>();
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
        private void ListIndexGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            var indexName = grid.CurrentRow.Cells["IndexName"].Value?.ToString() ?? string.Empty;
            var tableName = grid.CurrentRow.Cells["TableName"].Value?.ToString() ?? string.Empty;
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
        private void ListIndexGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is DataGridView gridView)
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
            if (e.KeyCode == Keys.Enter)
                ReadIndex();
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
            _dbID = dal.GetDatabaseID(DbTextBox.Text);
            var listIndex = dal.ListIndex(_dbID);

            IEnumerable<IndexModel> result;
            if (SearchText.Text.Length > 0)
                result = listIndex.Where(x => x.TableName.ToLower().Contains(SearchText.Text.ToLower()));
            else
                result = listIndex;

            ListIndexGrid.DataSource = result.ToList();
            ListIndexGrid.Columns[0].Width = 200;
            ListIndexGrid.Columns[1].Width = 225;
        }

        private void CreateIndex(string tableName)
        {

            var creteIndexForm = new CreateIndexForm(tableName.ToLower().Trim());
            creteIndexForm.ShowDialog();
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
            catch (SqlException)
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
            if (indexName == String.Empty)
                IndexDefGrid.DataSource = null;

            var dal = new IndexRepo();
            var listIndexDef = dal.ListIndexDef(indexName, tableName);
            IndexDefGrid.DataSource = listIndexDef;
        }

        private void LoadDBProfile()
        {
            var dal = new IndexRepo();
            var listIndex = new IndexRepo().ListIndex(_dbID);
            var listIndexProfile = new List<IndexProfileDto>();
            foreach (var index in listIndex.Where(x => x.IndexType != "HEAP"))
            {
                var indexProfile = new IndexProfileDto
                {
                    IndexName = index.IndexName,
                    TableName = index.TableName,
                    IndexType = index.IndexType,
                    IsPrimaryKey = index.IsPrimaryKey,
                    IsUnique = index.IsUnique,
                    IsUniqueConstraint = index.IsUniqueConstraint,
                    FillFactorA = index.FillFactorA,
                };
                var indexDef = dal.ListIndexDef(index.IndexName, index.TableName);
                var listDef = new List<IndexDefProfileDto>();
                foreach (var def in indexDef)
                {
                    var indexDefProfile = new IndexDefProfileDto
                    {
                        ColName = def.ColName,
                        ColOrder = def.ColOrder,
                        IsIncludeCol = def.IsIncludeCol,
                    };
                    listDef.Add(indexDefProfile);
                }
                indexProfile.ListIndexDef = listDef;
                listIndexProfile.Add(indexProfile);
            }
            _listIndexProfile = listIndexProfile;

            ActiveProfileLabel.BackColor = Color.LightPink;
            ActiveProfileLabel.Text = "DB Profile";
        }

        private void LoadExternalProfile(string fileName)
        {
            var sr = new StreamReader(fileName);
            var json = sr.ReadToEnd();
            var temp = JsonConvert.DeserializeObject<IEnumerable<IndexProfileDto>>(json);

            _listIndexProfile = temp.ToList();
            ActiveProfileLabel.BackColor = Color.LightGreen;
            ActiveProfileLabel.Text = "External Profile";


        }


        private void SaveAsProfile()
        {
            var json = JsonConvert.SerializeObject(_listIndexProfile, Formatting.Indented);
            File.WriteAllText(@"IndexProfile.txt", json);
            Process.Start("notepad.exe", @"IndexProfileScript.txt");
        }

        private void SaveAsProfileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Json File|*.json";
            saveFileDialog1.Title = "Save Index Profile";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                var fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                var json = JsonConvert.SerializeObject(_listIndexProfile, Formatting.Indented);
                var encode = new ASCIIEncoding();
                fs.Write(encode.GetBytes(json),0, encode.GetByteCount(json));
                fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_listIndexProfile == null)
                return;

            var sb = new StringBuilder();
            foreach (var index in _listIndexProfile)
            {
                sb.AppendLine(index.GenCreateIndexScript());
                sb.AppendLine("GO");
                sb.AppendLine();
            }
            File.WriteAllText(@"CreateIndexScript.sql", sb.ToString());
            Process.Start("notepad.exe", @"CreateIndexScript.sql");
        }

        private void ViewProfileButton_Click(object sender, EventArgs e)
        {
            if (_listIndexProfile == null)
                return;
            var viewer = new ProfileViewer(_listIndexProfile);
            viewer.ShowDialog();

        }

        private void LoadDBProfile_Click(object sender, EventArgs e)
        {

            LoadDBProfile();

        }

        private void LoadExternalProfileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadExternalProfile(openFileDialog1.FileName);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
            
        }

        private void GenDropScript_Click(object sender, EventArgs e)
        {
            if (_listIndexProfile == null)
                return;

            var sb = new StringBuilder();
            foreach(var index in _listIndexProfile)
            {
                sb.AppendLine(index.GenDropIndexScript());
                sb.AppendLine("GO");
                sb.AppendLine();
            }
            File.WriteAllText(@"DropIndexScript.sql", sb.ToString());
                Process.Start("notepad.exe", @"DropIndexScript.sql");
        }
    }
}
