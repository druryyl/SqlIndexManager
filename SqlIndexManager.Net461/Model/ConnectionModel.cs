using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Model
{
    public class ConnectionModel
    {
        public ConnectionModel(string server, string db, string user, string pass)
        {
            Server = server;
            Database = db;
            UserId = user;
            Password = pass;
        }
        public string Server { get; private set; }
        public string Database { get; private set; }
        public string UserId { get; private set; }
        public string Password { get; private set; }
        public string ConnectionString
        {
            get
            {
                return $"Server={Server};Database={Database};User Id={UserId};Password={Password};TrustServerCertificate=Yes";
            }
        }
        public override string ToString()
        {
            return $"{Database}@{Server} as ({UserId})";
        }
    }
}
