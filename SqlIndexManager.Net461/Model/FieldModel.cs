using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Model
{
    public class FieldModel
    {
        public FieldModel()
        {
        }
        public FieldModel(string tableName, string fieldName, string fieldType, int length, int scale)
        {
            TableName = tableName;
            FieldName = fieldName;
            FieldType = fieldType;
            Length = length;
            Scale = scale;
        }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public int Length { get; set; }
        public int Scale { get; set; }
    }
}
