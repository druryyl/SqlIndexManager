using SqlIndexManager.Net461.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Repository
{
    public class SqlCommandExecutor
    {
        private string _connString;
        private readonly ConnectionModel _conn;
        public SqlCommandExecutor(ConnectionModel conn)
        {
            _connString = conn.ConnectionString;
            _conn = conn;
        }

        public void ExecuteCommand(string sqlCommand)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(_connString))
            {
                conn.Open();
                using (var cmd = new System.Data.SqlClient.SqlCommand(sqlCommand, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}
