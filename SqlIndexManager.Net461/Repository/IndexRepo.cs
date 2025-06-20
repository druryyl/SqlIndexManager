﻿using Dapper;
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
        private string _connString;
        private readonly ConnectionModel _conn;
        public IndexRepo(ConnectionModel conn)
        {
            _connString = conn.ConnectionString;
            _conn = conn;
        }
        public IEnumerable<TableModel> ListTable()
        {
            var sql = @"
                SELECT  name AS TableName
                FROM sys.objects
                WHERE type = 'U' ";
            using(var conn = new SqlConnection(_connString))
            {
                var result = conn.Read<TableModel>(sql);
                return result;
            }
        }
        public IEnumerable<FieldModel> ListField(string tableName)
        {
            var sql = @"
                SELECT  
                    cc.Name AS TableName,
                    aa.name AS FieldName, 
                    bb.name AS FieldType, 
                    aa.max_length AS Length, 
                    aa.scale AS Scale
                FROM    
                    sys.columns aa
                    INNER JOIN sys.types bb ON aa.system_type_id = bb.system_type_id
                    INNER JOIN sys.objects cc ON aa.object_id = cc.object_id 
                WHERE
                    cc.name = @name 
                    AND bb.name NOT IN ('sysname', 'xml', 'hierarchyid', 'geometry', 'geography')
                ORDER BY 
                    aa.column_id ";

            var dp = new DynamicParameters();
            dp.AddParam("@name", tableName, SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connString))
            {
                var result = conn.Read<FieldModel>(sql, dp);
                return result;
            }
        }

        public IEnumerable<FieldModel> ListField()
        {
            var sql = @"
                SELECT  
                    cc.Name AS TableName,   
                    aa.name AS FieldName, 
                    bb.name AS FieldType, 
                    aa.max_length AS Length, 
                    aa.scale AS Scale
                FROM    
                    sys.columns aa
                    INNER JOIN sys.types bb ON aa.system_type_id = bb.system_type_id
                    INNER JOIN sys.objects cc ON aa.object_id = cc.object_id 
                WHERE
                    cc.[type] = 'U' 
                    AND bb.name NOT IN ('sysname', 'xml', 'hierarchyid', 'geometry', 'geography')";

            using (var conn = new SqlConnection(_connString))
            {
                var result = conn.Read<FieldModel>(sql);
                return result;
            }
        }

        public IEnumerable<IndexModel> ListIndex(int dbID)
        {
            var sql = @"
                SELECT
                    aa1.name AS TableName, 
                    aa.name AS IndexName, 
                    aa.type_desc AS IxType, 
                    aa.fill_factor AS FF,
                    aa.is_unique AS UQ, 
                    aa.is_primary_key AS PK, 
                    aa.is_unique_constraint AS UQC,
                    aa2.user_seeks AS USeek, 
                    aa2.user_scans AS UScan, 
                    aa2.user_lookups AS ULookup, 
                    aa2.user_updates AS UUpdate,
                    aa2.last_user_seek AS LSeek, 
                    aa2.last_user_scan AS LScan, 
                    aa2.last_user_lookup AS LLookUp, 
                    aa2.last_user_update AS LUpdate
                FROM 
                    sys.indexes aa
                    LEFT JOIN sys.objects aa1 ON aa.object_id = aa1.object_id
                    LEFT JOIN sys.dm_db_index_usage_stats aa2 on aa.object_id = aa2.object_id AND aa.index_id = aa2.index_id AND aa2.database_id = @dbID
                WHERE
                    aa1.type = 'U'
                ORDER BY 
                    aa1.name, aa.index_id ";

            var dp = new DynamicParameters();
            dp.AddParam("@dbID", dbID, SqlDbType.Int);

            using (var conn = new SqlConnection(_connString))
            {
                var result = conn.Read<IndexModel>(sql, dp);
                return result;
            }
        }

        public IEnumerable<IndexModel> ListIndex(string tableName)
        {
            var dbId = GetDatabaseID(_conn.Database);

            var sql = @"
                SELECT
                    aa1.name AS TableName, 
                    aa.name AS IndexName, 
                    aa.type_desc AS IxType, 
                    aa.fill_factor AS FF,
                    aa.is_unique AS UQ, 
                    aa.is_primary_key AS PK, 
                    aa.is_unique_constraint AS UQC,
                    aa2.user_seeks AS USeek, 
                    aa2.user_scans AS UScan, 
                    aa2.user_lookups AS ULookup, 
                    aa2.user_updates AS UUpdate,
                    aa2.last_user_seek AS LSeek, 
                    aa2.last_user_scan AS LScan, 
                    aa2.last_user_lookup AS LLookUp, 
                    aa2.last_user_update AS LUpdate
                FROM 
                    sys.indexes aa
                    LEFT JOIN sys.objects aa1 ON aa.object_id = aa1.object_id
                    LEFT JOIN sys.dm_db_index_usage_stats aa2 on aa.object_id = aa2.object_id AND aa.index_id = aa2.index_id AND aa2.database_id = @dbID
                WHERE
                    aa1.type = 'U'
                    AND aa1.name = @tableName
                ORDER BY 
                    aa1.name, aa.index_id ";

            var dp = new DynamicParameters();
            dp.AddParam("@tableName", tableName, SqlDbType.VarChar);
            dp.AddParam("@dbID", dbId, SqlDbType.Int);

            using (var conn = new SqlConnection(_connString))
            {
                var result = conn.Read<IndexModel>(sql, dp);
                return result;
            }
        }


        public IEnumerable<IndexDefModel> ListIndexDef(string indexName, string tableName)
        {
            var sql = @"
                SELECT
                    aa.name AS IndexName, 
                    bb1.name AS ColName, 
                    bb.key_ordinal AS ColOrder,
                    bb.is_included_column AS IsIncludeCol
                FROM
                    sys.indexes aa
                    LEFT JOIN sys.index_columns bb ON aa.object_id = bb.object_id AND aa.index_id = bb.index_id
                    LEFT JOIN sys.columns bb1 on bb.column_id = bb1.column_id AND aa.object_id = bb1.object_id
                    LEFT JOIN sys.objects aa1 on aa.object_id = aa1.object_id
                WHERE 
                    aa.name = @name AND
                    aa1.name = @tableName
                ORDER BY 
                    aa.object_id, aa.index_id, bb.is_included_column, bb.key_ordinal ";

            var dp = new DynamicParameters();
            dp.AddParam("@name", indexName, SqlDbType.VarChar);
            dp.AddParam("@tableName", tableName, SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connString))
            {
                var result = conn.Read<IndexDefModel>(sql, dp);
                return result;
            }
        }

        public IEnumerable<IndexDefModel> ListIndexDef()
        {
            var sql = @"
                SELECT
                    aa.name AS IndexName, 
                    bb1.name AS ColName, 
                    bb.key_ordinal AS ColOrder,
                    bb.is_included_column AS IsIncludeCol
                FROM
                    sys.indexes aa
                    LEFT JOIN sys.index_columns bb ON aa.object_id = bb.object_id AND aa.index_id = bb.index_id
                    LEFT JOIN sys.columns bb1 on bb.column_id = bb1.column_id AND aa.object_id = bb1.object_id
                    LEFT JOIN sys.objects aa1 on aa.object_id = aa1.object_id
                WHERE 
                    aa1.[type] = 'U'";

            using (var conn = new SqlConnection(_connString))
            {
                var result = conn.Read<IndexDefModel>(sql);
                return result;
            }
        }


        public int GetDatabaseID(string dbName)
        {
            var sql = @"SELECT DB_ID(@dbName) ";

            var dp = new DynamicParameters();
            dp.AddParam("@dbName", dbName, SqlDbType.VarChar);

            using (var conn = new SqlConnection(_connString))
            {
                var result = conn.ReadSingle<int>(sql, dp);
                return result;
            }
        }
    }
}
