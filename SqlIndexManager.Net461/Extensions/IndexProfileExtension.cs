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
            indexProfile.TableName = indexProfile.TableName.Trim();
            if (indexProfile.IsPrimaryKey)
                return CreatePrimaryKey(indexProfile);
            else
                return CreateIndex(indexProfile);
        }

        private static string CreatePrimaryKey(IndexProfileDto indexProfile)
        {
            var sb = new StringBuilder();
            
            sb.Append($"ALTER TABLE [{indexProfile.TableName.ToLower()}]");
            //sb.Append($"{indexProfile.IndexDef.OrderBy(x => x.ColOrder).FirstOrDefault(x => x.IsIncludeCol == false).ColName ?? string.Empty}");
            sb.Append(Environment.NewLine);
            sb.Append("    ");

            sb.Append($"ADD CONSTRAINT [PK_{indexProfile.TableName.ToLower()}_");
            sb.Append($"{indexProfile.ListIndexDef.OrderBy(x => x.ColOrder).FirstOrDefault(x => x.IsIncludeCol == false)?.ColName.ToLower() ?? string.Empty}] ");
            sb.Append($"PRIMARY KEY ");

            if (indexProfile.IndexType == "CLUSTERED")
                sb.Append($"CLUSTERED");

            sb.Append("(");
            foreach (var field in indexProfile.ListIndexDef.Where(x => x.IsIncludeCol == false).OrderBy(x => x.ColOrder))
                sb.Append($"[{field.ColName.ToLower()}],");
            sb.Length--;
            sb.Append(")");

            return sb.ToString();

        }

        private static string  CreateIndex(IndexProfileDto indexProfile)
        {
            if (indexProfile == null)
                return string.Empty;

            var sb = new StringBuilder();
            if (indexProfile.IndexType == "CLUSTERED")
            {
                if (indexProfile.IsUnique)
                    sb.Append("CREATE UNIQUE CLUSTERED INDEX [UCX_");
                else
                    sb.Append("CREATE CLUSTERED INDEX [CX_");
            }
            else
            {
                if (indexProfile.IsUnique)
                    sb.Append("CREATE UNIQUE INDEX [UX_");
                else
                    sb.Append("CREATE INDEX [IX_");
            }

            sb.Append($"{indexProfile.TableName.ToLower()}_");

            sb.Append($"{indexProfile.ListIndexDef.FirstOrDefault()?.ColName.ToLower() ?? string.Empty}]");
            sb.Append(Environment.NewLine);
            sb.Append("    ");

            sb.Append($"ON [{indexProfile.TableName.ToLower()}] (");

            foreach (var field in indexProfile.ListIndexDef.Where(x => x.IsIncludeCol == false).OrderBy(x => x.ColOrder))
                sb.Append($"[{field.ColName.ToLower()}],");

            sb.Length--;
            sb.Append(")");

            var ListIncludeCol = indexProfile.ListIndexDef.Where(x => x.IsIncludeCol == true).ToList();
            if (ListIncludeCol.Count != 0)
            {
                sb.Append(Environment.NewLine);
                sb.Append("    ");
                sb.Append($"INCLUDE (");
                foreach (var col in ListIncludeCol)
                    sb.Append($"[{col.ColName.ToLower()}],");
                sb.Length--;
                sb.Append(")");
            }

            if (indexProfile.FillFactorA != 0)
            {
                sb.Append(Environment.NewLine);
                sb.Append("    ");
                sb.Append($"WITH(FILLFACTOR={indexProfile.FillFactorA})");
            }

            return sb.ToString();

        }

        public static string GenDropIndexScript(this IndexProfileDto indexProfile)
        {
            if (indexProfile.IsPrimaryKey || indexProfile.IsUniqueConstraint)
                return DropConstraint(indexProfile);

            return DropIndex(indexProfile);
        }

        private static string DropIndex(IndexProfileDto indexProfile)
        {
            if (indexProfile == null)
                return string.Empty;

            var sb = new StringBuilder();
            sb.Append($"DROP INDEX [{indexProfile.IndexName.ToLower()}] ON [{indexProfile.TableName.ToLower()}]");

            return sb.ToString();
        }

        private static string DropConstraint(IndexProfileDto indexProfile)
        {
            if (indexProfile == null)
                return string.Empty;

            var sb = new StringBuilder();
            sb.Append($"ALTER TABLE [{indexProfile.TableName.ToLower()}] DROP CONSTRAINT [{indexProfile.IndexName.ToLower()}]");

            return sb.ToString();
        }


    }
}
