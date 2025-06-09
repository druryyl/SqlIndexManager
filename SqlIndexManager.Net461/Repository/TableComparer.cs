using SqlIndexManager.Net461.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Repository
{
    public class TableComparer
    {
        public TableComparer(TableModel targetTable, TableModel acuanTable)
        {
            TargetTable = targetTable;
            AcuanTable = acuanTable;
        }
        public TableModel TargetTable { get; private set; }
        public TableModel AcuanTable { get; private set; }
        public List<FieldCompareResultModel> Result { get; private set; }
        public string Script { get; private set; }

        public void Compare()
        {
        }
    }
}
