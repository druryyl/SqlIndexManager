using SqlIndexManager.Net461.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Extensions
{
    public static class IndexProfileExtension
    {
        public static string GenCreateIndexScript(this IndexProfileDto indexProfile)
        {
            if (indexProfile == null)
                return string.Empty;

            var sb = new StringBuilder();
            if (indexProfile.IndexType == "CLUSTERED")
            {
                if (indexProfile.IsUnique)
                    sb.Append("CREATE UNIQUE CLUSTERED INDEX UCX_");
                else
                    sb.Append("CREATE CLUSTERED INDEX CX_");
            }
            else
            {
                if (indexProfile.IsUnique)
                    sb.Append("CREATE UNIQUE INDEX UX_");
                else
                    sb.Append("CREATE INDEX IX_");
            }

            sb.Append($"{indexProfile.TableName}_");

            sb.Append($"{indexProfile.IndexDef.FirstOrDefault().ColName ?? string.Empty}");
            sb.Append(Environment.NewLine);
            sb.Append("    ");

            sb.Append($"ON {indexProfile.TableName} (");

            foreach (var field in indexProfile.IndexDef.Where(x => x.IsIncludeCol == false).OrderBy(x => x.ColOrder))
                sb.Append($"{field.ColName},");

            sb.Length--;
            sb.Append(")");
            sb.Append(Environment.NewLine);
            sb.Append("    ");

            var ListIncludeCol = indexProfile.IndexDef.Where(x => x.IsIncludeCol == true).ToList();
            if (ListIncludeCol.Count != 0)
            {
                sb.Append($"INCLUDE (");
                foreach (var col in ListIncludeCol)
                    sb.Append($"{col.ColName},");
                sb.Length--;
                sb.Append(")");
                sb.Append(Environment.NewLine);
                sb.Append("    ");
            }

            if (indexProfile.FillFactorA != 0)
                sb.Append($"WITH(FILLFACTOR={indexProfile.FillFactorA})");

            return sb.ToString();
        }
    }
}
