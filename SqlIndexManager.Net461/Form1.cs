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
            var creteIndexForm = new CreateIndexForm(tableName);
            creteIndexForm.ShowDialog();
        }
    }
}
