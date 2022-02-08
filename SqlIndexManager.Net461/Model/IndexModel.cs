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
        public string IndexType { get; set; }
        public int FillFactorA { get; set; }
        public bool IsUnique { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsUniqueConstraint { get; set; }
        public long UserSeek { get; set; }
        public long UserScan { get; set; }
        public long UserLookUp { get; set; }
        public long UserUpdate { get; set; }
        public DateTime LastUserSeek { get; set; }
        public DateTime LastUserScan { get; set; }
        public DateTime LastUserLookUp { get; set; }
        public DateTime LastUserUpdate { get; set; }

    }
}
