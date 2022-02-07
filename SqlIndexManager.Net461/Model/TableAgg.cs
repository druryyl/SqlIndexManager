using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Model
{
    public class TableAgg : TableModel
    {
        public IEnumerable<FieldModel> Fields { get; set; }
        public IEnumerable<IndexAgg> Indexes { get; set; }
    }
}
