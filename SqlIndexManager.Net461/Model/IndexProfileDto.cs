using Newtonsoft.Json;
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
        public string IndexDef { get => SerializeCol(ListIndexDef); }
        public string IncludeCol { get => SerializeIncludeCol(ListIndexDef); }
        public List<IndexDefProfileDto> ListIndexDef { get; set; }


        private string SerializeCol(List<IndexDefProfileDto> indexDef)
        {
            var sb = new StringBuilder();
            foreach (var item in ListIndexDef.Where(x => x.IsIncludeCol == false))
                sb.Append($"{item.ColName},");
            sb.Length--;
            return sb.ToString();
        }
        private string SerializeIncludeCol(List<IndexDefProfileDto> indexDef)
        {
            if (indexDef.Any(x => x.IsIncludeCol == true))
            {
                var sb = new StringBuilder();
                foreach (var item in ListIndexDef.Where(x => x.IsIncludeCol == true))
                    sb.Append($"{item.ColName},");
                sb.Length--;
                return sb.ToString();
            }
            return String.Empty;
        }

    }

    public class IndexDefProfileDto
    {
        public string ColName { get; set; }
        public int ColOrder { get; set; }
        public bool IsIncludeCol { get; set; }
    }
}
