using SqlIndexManager.Net461.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Repository
{
    public class FieldRepo
    {
        private readonly ConnectionModel _conn;
        public FieldRepo(ConnectionModel conn)
        {
            _conn = conn;
        }

        public IEnumerable<FieldModel> ListField(string tableName)
        {
            var dal = new IndexRepo(_conn);
            return dal.ListField(tableName);
        }
    }
}
