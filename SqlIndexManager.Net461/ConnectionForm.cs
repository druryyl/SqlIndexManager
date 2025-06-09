using Microsoft.Win32;
using SqlIndexManager.Net461.Model;
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
    public partial class ConnectionForm : Form
    {
        private ConnectionModel _connection1;
        private ConnectionModel _connection2;
        public ConnectionForm()
        {
            InitializeComponent();
            LoadConnectionFromRegistry();

            TestConnection1Button.Click += TestConnection1Button_Click;
            TestConnection2Button.Click += TestConnection2Button_Click;
            OkButton.Click += OkButton_Click;
            CancelButton.Click += CancelButton_Click;
            SwitchButton.Click += SwitchButton_Click;
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            var temp = _connection1;
            _connection1 = _connection2;
            _connection2 = temp;
            
            Server1Text.Text = _connection1.Server;
            Db1Text.Text = _connection1.Database;
            User1Text.Text = _connection1.UserId;
            Password1Text.Text = _connection1.Password;

            Server2Text.Text = _connection2.Server;
            Db2Text.Text = _connection2.Database;
            User2Text.Text = _connection2.UserId;
            Password2Text.Text = _connection2.Password;

            SaveConnectionToRegistry();
        }

        public (ConnectionModel Connection1, ConnectionModel Connection2) GetConnections()
        {
            return (_connection1, _connection2);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _connection1 = new ConnectionModel(Server1Text.Text, Db1Text.Text, User1Text.Text, Password1Text.Text);
            _connection2 = new ConnectionModel(Server2Text.Text, Db2Text.Text, User2Text.Text, Password2Text.Text);
            SaveConnectionToRegistry();
            Close();
        }

        private void TestConnection2Button_Click(object sender, EventArgs e)
        {
            TestConnection(Server2Text.Text, Db2Text.Text, User2Text.Text, Password2Text.Text);
        }

        private void TestConnection1Button_Click(object sender, EventArgs e)
        {
            TestConnection(Server1Text.Text, Db1Text.Text, User1Text.Text, Password1Text.Text);
        }

        private void SaveConnectionToRegistry()
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("SqlIndexManager");
            regKey.SetValue("Server1", Server1Text.Text);
            regKey.SetValue("Database1", Db1Text.Text);
            regKey.SetValue("User1", User1Text.Text);
            regKey.SetValue("Password1", Password1Text.Text);
            regKey.SetValue("Server2", Server2Text.Text);
            regKey.SetValue("Database2", Db2Text.Text);
            regKey.SetValue("User2", User2Text.Text);
            regKey.SetValue("Password2", Password2Text.Text);
            regKey.Close();
        }
        private void LoadConnectionFromRegistry()
        {
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("SqlIndexManager");
            if (regKey is null)
                return;
            Server1Text.Text = regKey.GetValue("Server1", "").ToString();
            Db1Text.Text = regKey.GetValue("Database1", "").ToString();
            User1Text.Text = regKey.GetValue("User1", "").ToString();
            Password1Text.Text = regKey.GetValue("Password1", "").ToString();
            Server2Text.Text = regKey.GetValue("Server2", "").ToString();
            Db2Text.Text = regKey.GetValue("Database2", "").ToString();
            User2Text.Text = regKey.GetValue("User2", "").ToString();
            Password2Text.Text = regKey.GetValue("Password2", "").ToString();
            
            _connection1 = new ConnectionModel(Server1Text.Text, Db1Text.Text, User1Text.Text, Password1Text.Text);
            _connection2 = new ConnectionModel(Server2Text.Text, Db2Text.Text, User2Text.Text, Password2Text.Text);
         }

        private void TestConnection(string server, string database, string userId, string password)
        {
            try
            {
                using (var connection = new SqlConnection($"Server={server};Database={database};User Id={userId};Password={password};"))
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
        }
    }
}
