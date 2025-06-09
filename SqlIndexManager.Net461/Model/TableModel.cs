using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Model
{
    public class TableModel
    {
        public TableModel(string tableName)
        {
            TableName = tableName.Trim();
            Fields = new List<FieldModel>();
            Indexes = new List<IndexModel>();
        }
        public string TableName { get; set; }
        public int Status { get; set; } 
        public string StatusText
        {
            get
            {
                switch (Status)
                {
                    case 0: return "Sama";
                    case 1: return "Belum Ada";
                    case 2: return "Tidak Diperlukan";
                    case 3: return "Beda Field";
                    case 4: return "Beda Index";
                    default: return "Unknown Status";
                }
            }
        }
        public List<FieldModel> Fields { get; set; }
        public List<IndexModel> Indexes { get; set; }

        public void AddField(string tableName, string fieldName, string fieldType, int length, int scale)
        {
            var field = new FieldModel(tableName, fieldName, fieldType, length, scale);
            Fields.Add(field);
        }
        
        public void AddIndex(string indexName, string ixType, int ff, bool uq, 
            bool pk, bool uqc, long useek, long uscan, long ulookup, 
            long uupdate, DateTime lseek, DateTime lscan, DateTime llookup, DateTime lupdate,
            IEnumerable<IndexDefModel> listIndexDef)
        {
            var index = new IndexModel
            {
                TableName = this.TableName,
                IndexName = indexName,
                IxType = ixType,
                FF = ff,
                UQ = uq,
                PK = pk,
                UQC = uqc,
                USeek = useek,
                UScan = uscan,
                ULookup = ulookup,
                UUpdate = uupdate,
                LSeek = lseek,
                LScan = lscan,
                LLookup = llookup,
                LUpdate = lupdate,
                ListIndexDef = listIndexDef?.ToList() ?? new List<IndexDefModel>()

            };
            Indexes.Add(index);
        }

        public bool IsFieldSama(TableModel otherTable)
        {
            if (Fields.Count != otherTable.Fields.Count) return false;

            foreach (var item in Fields)
            {
                var otherField = otherTable.Fields.FirstOrDefault(f => f.FieldName.ToLower().Trim() == item.FieldName.ToLower().Trim());
                if (otherField == null) return false;

                if (item.FieldType != otherField.FieldType || 
                    item.Length != otherField.Length || 
                    item.Scale != otherField.Scale)
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsIndexSama(TableModel otherTable)
        {
            if (Indexes.Count != otherTable.Indexes.Count) return false;
            foreach (var item in Indexes)
            {
                var otherIndex = otherTable.Indexes.FirstOrDefault(i => i.IndexName == item.IndexName);
                if (otherIndex == null) return false;
                if (item.IxType != otherIndex.IxType ||
                    item.FF != otherIndex.FF ||
                    item.UQ != otherIndex.UQ ||
                    item.PK != otherIndex.PK)
                {
                    return false;
                }

                foreach(var field in item.ListIndexDef)
                {
                    var otherField = otherIndex.ListIndexDef.FirstOrDefault(f => f.ColName == field.ColName);
                    if (otherField == null)
                        return false;
                    if (field.IsIncludeCol != otherField.IsIncludeCol || field.ColOrder != otherField.ColOrder)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
