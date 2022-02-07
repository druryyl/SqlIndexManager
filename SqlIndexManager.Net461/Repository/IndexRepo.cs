using Dapper;
using Nuna.Lib.DataAccessHelper;
using SqlIndexManager.Net461.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Repository
{
    public class IndexRepo
    {
        public IEnumerable<TableModel> ListTable()
        {
            var sql = @"
                SELECT  name AS TableName
                FROM sys.objects
                WHERE type = 'U' ";
            using(var conn = new SqlConnection(ConnStringHelper.Get()))
            {
                var result = conn.Read<TableModel>(sql);
                return result;
            }
        }
        public IEnumerable<FieldModel> ListField(string tableName)
        {
            var sql = @"
                SELECT  
                    aa.name AS FieldName, 
                    bb.name AS FiledType, 
                    aa.max_length AS Length, 
                    aa.scale AS Scale
                FROM    
                    sys.columns aa
                    INNER JOIN sys.types bb ON aa.system_type_id = bb.system_type_id
                    INNER JOIN sys.objects cc ON aa.object_id = cc.object_id 
                WHERE
                    cc.name = @name 
                ORDER BY 
                    aa.column_id ";

            var dp = new DynamicParameters();
            dp.AddParam("@name", tableName, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
            {
                var result = conn.Read<FieldModel>(sql);
                return result;
            }
        }

        public IEnumerable<IndexModel> ListIndex()
        {
            var sql = @"
                SELECT
                    aa1.name AS TableName, 
                    aa.name AS IndexName, 
                    aa.type_desc AS IndexType, 
                    aa.fill_factor AS FillFactorA,
                    aa.is_unique AS IsUnique, 
                    aa.is_primary_key AS IsPrimaryKey, 
                    aa2.user_seeks AS UserSeek, 
                    aa2.user_scans AS UserScan, 
                    aa2.user_lookups AS UserLookUp, 
                    aa2.user_updates AS UserUpdate,
                    aa2.last_user_seek AS LastUserSeek, 
                    aa2.last_user_scan AS LastUserScan, 
                    aa2.last_user_lookup AS LastUserLookUp, 
                    aa2.last_user_update AS LastUserUpdate
                FROM 
                    sys.indexes aa
                    LEFT JOIN sys.objects aa1 ON aa.object_id = aa1.object_id
                    LEFT JOIN sys.dm_db_index_usage_stats aa2 on aa.object_id = aa2.object_id AND aa.index_id = aa2.index_id
                WHERE
                    aa1.type = 'U'
                ORDER BY 
                    aa1.name, aa.index_id ";
            using (var conn = new SqlConnection(ConnStringHelper.Get()))
            {
                var result = conn.Read<IndexModel>(sql);
                return result;
            }
        }

        public IEnumerable<IndexDefModel> ListIndexDef(string indexName)
        {
            var sql = @"
                SELECT
                    aa.name AS IndexName, 
                    bb1.name AS ColName, 
                    bb.index_column_id AS ColOrder
                    bb.is_included_column AS IsIncludeCol, 
                FROM
                    sys.indexes aa
                    LEFT JOIN sys.index_columns bb ON aa.object_id = bb.object_id AND aa.index_id = bb.index_id
                    LEFT JOIN sys.columns bb1 on bb.column_id = bb1.column_id AND aa.object_id = bb1.object_id
                WHERE 
                    aa.name = @name
                order by aa.object_id, aa.index_id, bb.index_column_id ";

            var dp = new DynamicParameters();
            dp.AddParam("@name", indexName, SqlDbType.VarChar);

            using (var conn = new SqlConnection(ConnStringHelper.Get()))
            {
                var result = conn.Read<IndexDefModel>(sql);
                return result;
            }
        }
    }
}
