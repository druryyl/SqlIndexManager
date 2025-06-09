using Nuna.Lib.DataTypeExtension;
using SqlIndexManager.Net461.Model;
using System.Collections.Generic;
using System.Linq;

namespace SqlIndexManager.Net461
{
    public class ScriptGenerator
    {
        public string TableName { get; set; }
        public IEnumerable<FieldDto> Fields { get; set; }
        public string GererateScript(bool isCreateTable)
        {
            if (isCreateTable)
                return GenScriptCreate();

            var result = string.Empty;
            foreach (var item in Fields.Where(x => x.Script == true))
            {
                switch (item.StatusCode)
                {
                    case 0: // sama
                        continue;
                    case 1: // belum ada
                        result += $"ALTER TABLE {item.TableName} ADD {GenGlobalField(item)} {GenGlobalConstraint(item)}\r\n";
                        break;
                    case 2: // tidak diperlukan
                        result += $"ALTER TABLE {item.TableName} DROP COLUMN {item.FieldName}\r\n";
                        break;
                    case 3: // berbeda
                        result += $"ALTER TABLE {item.TableName} ALTER COLUMN {GenGlobalField(item)}\r\n";
                        break;
                    default:
                        continue;
                }
            }
            return result;
        }

        private string GenScriptCreate()
        {
            if (string.IsNullOrEmpty(TableName) || Fields == null)
                return string.Empty;
            var script = $"CREATE TABLE {TableName}(\r\n";
            foreach (var field in Fields.Where(x => x.StatusCode != 2))
            {
                script += $"  {GenGlobalField(field)} {GenGlobalConstraint(field)},\r\n";
            }
            script = script.Substring(0, script.Length - 3) + ")";
            return script;
        }

        private string GenGlobalField(FieldDto field)
        {
            var script = string.Empty;
            switch (field.AcuanType.FieldType.ToUpper())
            {
                case "VARCHAR":
                case "NVARCHAR":
                    script += $"{GenString(field.FieldName, field.AcuanType)}";
                    break;
                case "INT":
                case "BIGINT":
                case "SMALLINT":
                case "TINYINT":
                case "BIT":
                case "FLOAT":
                    // No length or scale for integer types
                    script += $"{GenInt(field.FieldName, field.AcuanType)}";
                    break;
                case "DECIMAL":
                case "NUMERIC":
                    // Use length and scale for decimal types
                    script += $"{GenDecimal(field.FieldName, field.AcuanType)}";
                    break;
                case "DATETIME":
                    // Use DATETIME for date and time types
                    script += $"{GenDateTime(field.FieldName)}";
                    break;
                case "TEXT":
                    // Use DATETIME for date and time types
                    script += $"{GenText(field.FieldName, field.AcuanType)}";
                    break;
                default:
                    // For other types, use the original field type
                    script += $"{field.FieldName} {field.AcuanType.FieldType}";
                    break;
            }
            return script;
        }

        private string GenString(string fieldName, FieldTypeDef fieldType)
        {
            if (fieldName.Left(3).ToLower() == "fd_")
                return $"{fieldName} {fieldType.FieldType.ToUpper()} ({fieldType.Length})";

            if (fieldName.Left(6).ToLower() == "fs_jam")
                return $"{fieldName} {fieldType.FieldType.ToUpper()} ({fieldType.Length})";

            return $"{fieldName} {fieldType.FieldType.ToUpper()} ({fieldType.Length})";
        }

        private string GenText(string fieldName, FieldTypeDef fieldType)
            => $"{fieldName} {fieldType.FieldType.ToUpper()}";

        private string GenDecimal(string fieldName, FieldTypeDef fieldType)
            => $"{fieldName} {fieldType.FieldType.ToUpper()} ({fieldType.Length}, {fieldType.Scale})";

        private string GenDateTime(string fieldName)
            => $"{fieldName} DATETIME";

        private string GenInt(string fieldName, FieldTypeDef fieldType)
            => $"{fieldName} {fieldType.FieldType.ToUpper()}";

        private string GenGlobalConstraint(FieldDto field)
        {
            string script = string.Empty;
            switch (field.AcuanType.FieldType.ToUpper())
            {
                case "VARCHAR":
                case "NVARCHAR":
                case "TEXT":
                    script = $"NOT NULL CONSTRAINT DF_{TableName}_{field.FieldName} DEFAULT('')";
                    break;
                case "INT":
                case "BIGINT":
                case "SMALLINT":
                case "TINYINT":
                case "BIT":
                case "DECIMAL":
                case "NUMERIC":
                case "FLOAT":
                    script = $"NOT NULL CONSTRAINT DF_{TableName}_{field.FieldName} DEFAULT(0)";
                    break;
                case "DATETIME":
                    script = $"NOT NULL CONSTRAINT DF_{TableName}_{field.FieldName} DEFAULT('3000-01-01')";
                    break;
                default:
                    script = $"NOT NULL CONSTRAINT DF_{TableName}_{field.FieldName} DEFAULT('')";
                    break;
            }

            //  case khusus
            if (field.FieldName.Left(3).ToLower() == "fd_")
                script = $"NOT NULL CONSTRAINT DF_{TableName}_{field.FieldName} DEFAULT('3000-01-01')";

            if (field.FieldName.Left(6).ToLower() == "fs_jam")
                script = $"NOT NULL CONSTRAINT DF_{TableName}_{field.FieldName} DEFAULT('00:00:00')";

            return script;
        }
    }
}