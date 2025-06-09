using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SqlIndexManager.Net461.Model
{
    public class FieldCompareResultModel
    {
        public FieldCompareResultModel(string tableName, string fieldName, FieldTypeDef originalFieldType,
            FieldTypeDef acuanFieldType, int status)
        {
            TableName = tableName;
            FieldName = fieldName;
            Status = status;
            OriginalFieldType = originalFieldType;
            AcuanFieldType = acuanFieldType;
        }
        public string TableName { get; private set; }
        public string FieldName { get; private set; }
        public FieldTypeDef OriginalFieldType { get; private set; }
        public FieldTypeDef AcuanFieldType { get; private set; }
        public int Status { get; private set; }
        public string StatusText
        {
            get
            {
                switch (Status)
                {
                    case 0: return "Sama";
                    case 1: return "Belum Ada";
                    case 2: return "Tidak Diperlukan";
                    case 3: return "Berbeda";
                    default: return "Unknown Status";
                }
            }
        }

        public static IEnumerable<FieldCompareResultModel> CompareTable(TableModel original, TableModel acuan)
        {
            var result = new List<FieldCompareResultModel>();
            
            if (original is null || original.Fields.Count == 0)
            {
                // field belum ada semua
                var originalFieldType = new FieldTypeDef("", 0, 0);
                result.AddRange(acuan.Fields.Select(x => new FieldCompareResultModel(acuan.TableName, x.FieldName,
                    originalFieldType,
                    new FieldTypeDef(x.FieldType, x.Length, x.Scale),
                    1)));
                return result;
            }

            if (acuan is null || acuan.Fields.Count == 0)
            {
                // field tidak diperlukan semua
                var acuanFieldType = new FieldTypeDef("", 0, 0);
                result.AddRange(original.Fields.Select(x => new FieldCompareResultModel(original.TableName, x.FieldName,
                    new FieldTypeDef(x.FieldType, x.Length, x.Scale),
                    acuanFieldType,
                    2)));
                return result;
            }

            foreach (var item in original.Fields)
            {
                var field2 = acuan.Fields.FirstOrDefault(x => x.FieldName.ToLower() == item.FieldName.ToLower());
                var acuanFieldType = field2 is null ?
                    new FieldTypeDef("", 0, 0) :
                    new FieldTypeDef(field2.FieldType, field2.Length, field2.Scale);
                var originalFieldType = new FieldTypeDef(item.FieldType, item.Length, item.Scale);

                if (field2 == null)
                {
                    // field tidak diperlukan
                    result.Add(new FieldCompareResultModel(original.TableName, item.FieldName,
                        originalFieldType,
                        acuanFieldType,
                        2));
                    continue;
                }

                if (FieldTypeDef.IsEqual(originalFieldType, acuanFieldType))
                {
                    // field sudah sama
                    result.Add(new FieldCompareResultModel(original.TableName, item.FieldName,
                        originalFieldType,
                        acuanFieldType,
                        0));
                    continue;
                }

                // field berbeda
                result.Add(new FieldCompareResultModel(original.TableName, item.FieldName,
                    originalFieldType,
                    acuanFieldType,
                    3));
            }

            foreach (var item in acuan.Fields)
            {
                var field1 = original.Fields.FirstOrDefault(x => x.FieldName.ToLower() == item.FieldName.ToLower());
                if (field1 != null)
                    continue;

                // field belum ada
                var originalFieldType = new FieldTypeDef("", 0, 0);
                var acuanFieldType = new FieldTypeDef(item.FieldType, item.Length, item.Scale);
                result.Add(new FieldCompareResultModel(acuan.TableName, item.FieldName, originalFieldType, acuanFieldType, 1));
            }

            return result;
        }
    }
}
