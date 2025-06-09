using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Model
{
    public class IndexModel
    {
        public string TableName { get; set; }
        public string IndexName { get; set; }
        public string IxType { get; set; }
        public int FF { get; set; }
        public bool UQ { get; set; }
        public bool PK { get; set; }
        public bool UQC { get; set; }
        public long USeek { get; set; }
        public long UScan { get; set; }
        public long ULookup { get; set; }
        public long UUpdate { get; set; }
        public DateTime LSeek { get; set; }
        public DateTime LScan { get; set; }
        public DateTime LLookup { get; set; }
        public DateTime LUpdate { get; set; }

        public List<IndexDefModel> ListIndexDef { get; set; }
    }
}
