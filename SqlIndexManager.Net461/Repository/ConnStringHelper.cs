using SqlIndexManager.Net461.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace SqlIndexManager.Net461.Repository
//{
//    public static class ConnStringHelper
//    {
//        private static string _connString;
//        public static void Set(ConnectionModel conn)
//        {
//            _connString = $"Server={conn.Server};Database={conn.Database};User Id={conn.UserId};Password={conn.Password};TrustServerCertificate=Yes";
//        }
//        public static string Get() => _connString;

//        public static void TestConnection()
//        {
//            using (SqlConnection connection = new SqlConnection(_connString))
//            {
//                connection.Open();
//            }
//        }
//    }
//}
