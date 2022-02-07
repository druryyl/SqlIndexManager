using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Repository
{
    public static class ConnStringHelper
    {
        private static string _connString;
        public static void Set(string server, string db, string userId, string pass)
        {
            _connString = $"Server={server};Database={db};User Id={userId};Password={pass};";
        }
        public static string Get() => _connString;

        public static void TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                connection.Open();
            }
        }
    }
}
