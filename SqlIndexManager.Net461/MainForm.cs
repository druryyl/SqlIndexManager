using Dapper;
using Microsoft.Win32;
using SqlIndexManager.Net461.Helpers;
using SqlIndexManager.Net461.Model;
using SqlIndexManager.Net461.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace SqlIndexManager.Net461
{
    public partial class ZilongIndexManagerForm : Form
    {
        private int _dbID;
        private ConnectionModel _connection1;
        private ConnectionModel _connection2;
        private List<TableModel> _listTable1 = new List<TableModel>();
        private List<TableModel> _listTable2 = new List<TableModel>();
        private readonly BindingSource _tableBindingSource;
        private readonly BindingList<TableDto> _listTableDataSource;

        private readonly BindingSource _fieldBindingSource;
        private readonly BindingList<FieldDto> _listFieldDataSource;

        private  TableRepo _tableRepo1;
        private  TableRepo _tableRepo2;


        const int TABLE_SAMA = 0;
        const int TABLE_TIDAK_ADA = 1;
        const int TABLE_TIDAK_DIBUTUHKAN = 2;
        const int TABLE_BEDA_FIELD = 3;
        const int TABLE_BEDA_INDEX = 4;

        const string COLOR_WHITE = "#FFFFFF";
        const string COLOR_NOT_FOUND = "#FFC3C5";
        const string COLOR_NOT_USED = "#FFECB8";
        const string COLOR_DIFFERENT1 = "#ACD2EA";
        const string COLOR_DIFFERENT2 = "#C9BED8";

        public ZilongIndexManagerForm()
        {
            InitializeComponent();
            LoadConnectionFromReg();

            _tableRepo1 = new TableRepo(_connection1);
            _tableRepo2 = new TableRepo(_connection2);

            _listTableDataSource = new BindingList<TableDto>();
            _tableBindingSource = new BindingSource(_listTableDataSource, null);

            _listFieldDataSource = new BindingList<FieldDto>();
            _fieldBindingSource = new BindingSource(_listFieldDataSource, null);

            InitControlEventHandler();
            InitGridTable();
            InitGridField();
        }

        private void InitControlEventHandler()
        {
            _tableRepo1.OnPopulateAllTables += (s, e) =>
            {
                ProgressBarStatus.Maximum = e.Total;
                ProgressBarStatus.Value = e.CurrentProgress;
            };
            _tableRepo2.OnPopulateAllTables += (s, e) =>
            {
                ProgressBarStatus.Maximum = e.Total;
                ProgressBarStatus.Value = e.CurrentProgress;
            };

            ListIndexGrid.CellDoubleClick += ListIndexGrid_CellDoubleClick;
            ListIndexGrid.CellMouseDown += ListIndexGrid_CellMouseDown;
            ListIndexGrid.RowEnter += ListIndexGrid_RowEnter;
            ListIndexGrid.DataBindingComplete += ListIndexGrid_DataBindingComplete;

            ListTable1Grid.RowPostPaint += DataGridViewExtensions.DataGridView_RowPostPaint;
            ListTable1Grid.RowEnter += ListTable1Grid_RowEnter;

            ListField1Grid.RowPostPaint += DataGridViewExtensions.DataGridView_RowPostPaint;
            ListField1Grid.CellContentClick += ListField1Grid_CellContentClick;

            ReadIndexButton.Click += ReadIndexButton_Click;
            SearchText.KeyDown += SearchText_KeyDown;
            ReadDatabaseButton.Click += (s, e) => ReadDatabase();
            ExecuteScriptButton.Click += ExecuteScriptButton_Click;

            CreateTableCheckBox.CheckedChanged += CreateTableCheckBox_CheckedChanged;
        }

        private void ExecuteScriptButton_Click(object sender, EventArgs e)
        {
            var scriptExecutor = new SqlCommandExecutor(_connection1);
            try
            {
                scriptExecutor.ExecuteCommand(ScriptText.Text);
                MessageBox.Show("Script executed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error executing script: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListField1Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (!(grid.CurrentCell is DataGridViewCheckBoxCell))
                return;

            if (grid.Columns[e.ColumnIndex].Name != "Script")
                return;
            ListField1Grid.EndEdit();
            CreateTableCheckBox_CheckedChanged(sender, e);
        }

        private void CreateTableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var grid = ListTable1Grid;

            var generator = new ScriptGenerator();
            generator.TableName = _listFieldDataSource.FirstOrDefault()?.TableName ?? string.Empty;
            generator.Fields = _listFieldDataSource.ToList();
            if (generator.TableName == string.Empty)
                return;
            
            var script = generator.GererateScript(CreateTableCheckBox.Checked);
            ScriptText.Text = script;
        }

        private void InitGridTable()
        {
            ListTable1Grid.DataSource = _tableBindingSource;
            ListTable1Grid.Columns.SetDefaultCellStyle(Color.Cornsilk);
            ListTable1Grid.Columns["TableName"].Width = 200;
            ListTable1Grid.Columns["Status"].Width = 110;
            ListTable1Grid.Columns["StatusCode"].Visible = false;

            ListTable1Grid.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0)
                    return;
                var row = ListTable1Grid.Rows[e.RowIndex];
                var item = (TableDto)row.DataBoundItem;
                switch (item.StatusCode)
                {
                    case TABLE_SAMA:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_WHITE);
                        break;
                    case TABLE_TIDAK_ADA:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_NOT_FOUND);
                        break;
                    case TABLE_TIDAK_DIBUTUHKAN:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_NOT_USED);
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        break;
                    case TABLE_BEDA_FIELD:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_DIFFERENT1);
                        break;
                    case TABLE_BEDA_INDEX:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_DIFFERENT2);
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            };
        }

        private void InitGridField()
        {
            ListField1Grid.AutoGenerateColumns = true;
            ListField1Grid.DataSource = _fieldBindingSource;

            ListField1Grid.Columns.SetDefaultCellStyle(Color.Cornsilk);
            ListField1Grid.Columns["TableName"].Width = 100;
            ListField1Grid.Columns["TableName"].Visible = false;

            ListField1Grid.Columns["FieldName"].Width = 150;
            ListField1Grid.Columns["OriginalType"].Width = 100;
            ListField1Grid.Columns["AcuanType"].Width = 100;
            ListField1Grid.Columns["Status"].Width = 100;
            ListField1Grid.Columns["StatusCode"].Visible = false;
            ListField1Grid.Columns["Script"].Width = 50;

            ListField1Grid.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0)
                    return;
                var row = ListField1Grid.Rows[e.RowIndex];
                var item = (FieldDto)row.DataBoundItem;
                switch (item.StatusCode)
                {
                    case 0:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_WHITE);
                        break;
                    case 1:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_NOT_FOUND);
                        break;
                    case 2:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_NOT_USED); 
                        row.DefaultCellStyle.ForeColor = Color.Gray;
                        break;
                    case 3:
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(COLOR_DIFFERENT1);
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            };
        }

        private void ListTable1Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            var table = _listTableDataSource[e.RowIndex];

            var tableName = table.TableName;
            
            if (table.StatusCode == TABLE_TIDAK_ADA)
                CreateTableCheckBox.Checked = true;
            else
                CreateTableCheckBox.Checked = false;

            ShowTableDef(tableName);
            CreateTableCheckBox_CheckedChanged(sender, e);
        }

        private void ShowTableDef(string tableName)
        {
            var table1 = _tableRepo1.GetTable(tableName);
            var table2 = _tableRepo2.GetTable(tableName);
            
            var compareResult = FieldCompareResultModel.CompareTable(table1, table2);
            _listFieldDataSource.Clear();
            foreach (var item in compareResult)
                _listFieldDataSource.Add(new FieldDto(item));

            ListField1Grid.Refresh();
        }

        private void LoadConnectionFromReg()
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SqlIndexManager");
            if (regKey == null)
                return;

            var server1 = regKey.GetValue("Server1", "").ToString();
            var db1 = regKey.GetValue("Database1", "").ToString();
            var user1 = regKey.GetValue("User1", "").ToString();
            var pass1 = regKey.GetValue("Password1", "").ToString();

            var server2 = regKey.GetValue("Server2", "").ToString();
            var db2 = regKey.GetValue("Database2", "").ToString();
            var user2 = regKey.GetValue("User2", "").ToString();
            var pass2 = regKey.GetValue("Password2", "").ToString();

            _connection1 = new ConnectionModel(server1, db1, user1, pass1);
            _connection2 = new ConnectionModel(server2, db2, user2, pass2);
            ShowConnectionInfo();
        }

        private void ConnectionMenu_Click(object sender, EventArgs e)
        {
            var connectionForm = new ConnectionForm();
            if (connectionForm.ShowDialog() == DialogResult.Cancel)
                return;

            (_connection1, _connection2) = connectionForm.GetConnections();
            _tableRepo1 = new TableRepo(_connection1);
            _tableRepo2 = new TableRepo(_connection2);
            ShowConnectionInfo();
        }
        private void ShowConnectionInfo()
        {
            var status1 = _connection1.Server == string.Empty ?
                $"[DB Production]: Not Connected" :
                $"[DB Production]: {_connection1}";
            Connection1Status.Text = $"{status1}";

            var status2 = _connection2.Server == string.Empty ?
                $"[DB Referensi]: Not Connected" :
                $"[DB Referensi]: {_connection2}";
            Connection2Status.Text = $"{status2}";
        }

        private void ReadIndexButton_Click(object sender, EventArgs e)
        {
            ReadIndex();
        }
        private void SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ReadIndex();
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

        private void ReadIndex()
        {
            var dal = new IndexRepo(_connection1);
            _dbID = dal.GetDatabaseID(_connection1.Database);
            var listIndex = dal.ListIndex(_dbID);

            IEnumerable<IndexModel> result;
            if (SearchText.Text.Length > 0)
                result = listIndex.Where(x => x.TableName.ToLower().Contains(SearchText.Text.ToLower()));
            else
                result = listIndex;

            ListIndexGrid.DataSource = result.ToList();
            ListIndexGrid.Columns[0].Width = 200;
            ListIndexGrid.Columns[1].Width = 225;
            ListIndexGrid.Columns[2].Width = 80;

            ListIndexGrid.Columns[3].Width = 30;
            ListIndexGrid.Columns[4].Width = 30;
            ListIndexGrid.Columns[5].Width = 30;
            ListIndexGrid.Columns[6].Width = 30;

            ListIndexGrid.Columns[7].Width = 45;
            ListIndexGrid.Columns[8].Width = 45;
            ListIndexGrid.Columns[9].Width = 45;
            ListIndexGrid.Columns[10].Width = 45;
        }
        private void CreateIndex(string tableName)
        {
            var creteIndexForm = new CreateIndexForm(tableName.ToLower().Trim(), _connection1);
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
                using (var conn = new SqlConnection(_connection1.ConnectionString))
                {
                    conn.Execute(sql);
                }

            }
            catch (SqlException)
            {
                string sql;
                sql = $"ALTER TABLE [{tableName}] DROP CONSTRAINT [{indexName}]";
                using (var conn = new SqlConnection(_connection1.ConnectionString))
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

            var dal = new IndexRepo(_connection1);
            var listIndexDef = dal.ListIndexDef(indexName, tableName);
            IndexDefGrid.DataSource = listIndexDef;
        }

        private void ReadDatabase()
        {
            var filterTableName = FilterTableNameText.Text.Trim().ToLower();
            if (_connection1.Server == string.Empty)
                return;
            var dal = new IndexRepo(_connection1);
            _listTable1 = _tableRepo1.PopulateAllTables(filterTableName)?.ToList() ?? new List<TableModel>();
            _listTable1 = _listTable1.OrderBy(x => x.TableName).ToList();

            if (_connection2.Server == string.Empty)
                return;
            dal = new IndexRepo(_connection2);
            _listTable2 = _tableRepo2.PopulateAllTables(filterTableName)?.ToList() ?? new List<TableModel>();
            _listTable2 = _listTable2.OrderBy(x => x.TableName).ToList();

            ProgressBarStatus.Value = 0;
            ProgressBarStatus.Maximum = _listTable1.Count;
            foreach (var item in _listTable1)
            {
                ProgressBarStatus.Value++;
                var existed = _listTable2.FirstOrDefault(x => x.TableName.ToLower() == item.TableName.ToLower());
                item.Status = existed == null ? TABLE_TIDAK_DIBUTUHKAN : TABLE_SAMA;
            }

            ProgressBarStatus.Value = 0;
            ProgressBarStatus.Maximum = _listTable2.Count;
            foreach (var item in _listTable2)
            {
                ProgressBarStatus.Value++;
                var existed = _listTable1.FirstOrDefault(x => x.TableName.ToLower() == item.TableName.ToLower());
                if (existed != null)
                    continue;
                _listTable1.Add(new TableModel(item.TableName)
                {
                    Status = TABLE_TIDAK_ADA
                });
            }

            //  scan field yang berbeda
            var listToProsess = _listTable1.Where(x => x.Status == TABLE_SAMA).ToList();
            ProgressBarStatus.Value = 0;
            ProgressBarStatus.Maximum = listToProsess.Count;

            foreach (var item in _listTable1.Where(x => x.Status == TABLE_SAMA))
            {
                ProgressBarStatus.Value++;
                var table2 = _listTable2.FirstOrDefault(x => x.TableName.ToLower() == item.TableName.ToLower());
                if (table2 == null)
                    continue;

                var table1 = _listTable1.FirstOrDefault(x => x.TableName.ToLower() == item.TableName.ToLower());
                if (table1 == null)
                    continue;

                var isFieldSama = table1.IsFieldSama(table2);
                if (!isFieldSama)
                {
                    item.Status = TABLE_BEDA_FIELD;
                    continue;
                }
                var isIndexSama = table1.IsIndexSama(table2);
                if (!isIndexSama)
                {
                    item.Status = TABLE_BEDA_INDEX;
                    continue;
                }
            }

            _listTableDataSource.Clear();
            _listTable1 = _listTable1.OrderBy(x => x.TableName).ToList();
            _listTable1.ForEach(x => _listTableDataSource.Add(new TableDto(x.TableName, x.StatusText, x.Status)));
            ListTable1Grid.Refresh();

            ProgressBarStatus.Value = 0;
        }

        private void dBCompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelDbCompare.Visible = true;
            MainPanelIndexManager.Visible = false;
        }

        private void indexManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelDbCompare.Visible = false;
            MainPanelIndexManager.Visible = true;
        }
    }

    public class TableDto
    {
        public TableDto(string name, string status, int code)
        {
            TableName = name;
            Status = status;
            StatusCode = code;
        }
        public string TableName { get; private set; }
        public string Status { get; private set; }
        public int StatusCode { get; private set; }
    }

    public class FieldDto
    {
        public FieldDto(FieldCompareResultModel field)
        {
            TableName = field.TableName;
            FieldName = field.FieldName;
            OriginalType = field.OriginalFieldType;
            AcuanType = field.AcuanFieldType;
            StatusCode = field.Status;
            Status = field.StatusText;
        }

        public string TableName { get; private set; }
        public string FieldName { get; private set; }
        public FieldTypeDef OriginalType { get; private set; }
        public FieldTypeDef AcuanType { get; private set; }
        public string Status { get; private set; }
        public int StatusCode { get; private set; }
        public bool Script { get; set; }
    }
}
