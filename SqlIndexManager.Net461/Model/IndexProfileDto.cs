using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Model
{
    public class IndexProfileDto
    {
        public string TableName { get; set; }
        public string IndexName { get; set; }
        public string IndexType { get; set; }
        public int FillFactorA { get; set; }
        public bool IsUnique { get; set; }
        public bool IsPrimaryKey { get; set; }
        public List<IndexDefProfileDto> IndexDef { get; set; }

    }

    public class IndexDefProfileDto
    {
        public string ColName { get; set; }
        public int ColOrder { get; set; }
        public bool IsIncludeCol { get; set; }
    }
}
