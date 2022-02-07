using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Model
{
    public class IndexDefModel
    {
        public string IndexName { get; set; }
        public string ColName { get; set; }
        public int ColOrder { get; set; }
        public bool IsIncludeCol { get; set; }
    }
}
