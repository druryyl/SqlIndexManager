using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Model
{
    public class FieldModel
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public int Length { get; set; }
        public int Scale { get; set; }

    }
}
