using SqlIndexManager.Net461.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlIndexManager.Net461.Repository
{
    public class TableRepo
    {
        private readonly IndexRepo _indexRepo;
        private readonly ConnectionModel _conn;
        private List<TableModel> _listAllTable;

        private List<FieldModel> _listAllField;
        private List<IndexModel> _listAllIndex;
        private List<IndexDefModel> _listAllIndexDef;

        public TableRepo(ConnectionModel conn)
        {
            _conn = conn;
            _indexRepo = new IndexRepo(conn);
        }

        public event EventHandler<OnPopulateAllTablesEventArgs> OnPopulateAllTables;

        public TableModel GetTable(string tableName)
        {
            var result = new TableModel(tableName);

            var listField = _indexRepo.ListField(tableName)?.ToList() ?? new List<FieldModel>();
            foreach (var field in listField)
            {
                result.AddField(tableName, field.FieldName, field.FieldType, field.Length, field.Scale);
            }

            var listIndex = _indexRepo.ListIndex(tableName)?.ToList() ?? new List<IndexModel>();
            foreach (var index in listIndex)
            {
                if (index.IxType == "HEAP")
                    continue;

                var listIndexDef = _indexRepo.ListIndexDef(tableName, index.IndexName)?.ToList() ?? new List<IndexDefModel>();
                result.AddIndex(index.IndexName, index.IxType, index.FF, index.UQ,
                    index.PK, index.UQC, index.USeek, index.UScan,
                    index.ULookup, index.UUpdate,
                    index.LSeek, index.LScan, index.LLookup, index.LUpdate, listIndexDef);
            }
            return result;
        }

        public void PopulateAllData()
        {
            _listAllTable = _indexRepo.ListTable()?.ToList() ?? new List<TableModel>();
            _listAllField = _indexRepo.ListField()?.ToList() ?? new List<FieldModel>();

            var dbId = _indexRepo.GetDatabaseID(_conn.Database);
            _listAllIndex = _indexRepo.ListIndex(dbId)?.ToList() ?? new List<IndexModel>();
            _listAllIndexDef = _indexRepo.ListIndexDef()?.ToList() ?? new List<IndexDefModel>();
        }

        public List<TableModel> PopulateAllTables(string filterTableName)
        {
            PopulateAllData();
            if (!string.IsNullOrEmpty(filterTableName))
            {
                filterTableName = filterTableName.ToLower();
                _listAllTable = _listAllTable.Where(t => t.TableName.ToLower().Contains(filterTableName)).ToList();
            }

            var totalTables = _listAllTable.Count;
            var currentProgress = 0;
            foreach (var table in _listAllTable)
            {
                OnPopulateAllTables?.Invoke(this, new OnPopulateAllTablesEventArgs(totalTables, currentProgress++));

                var fields = _listAllField.Where(f => f.TableName.Trim() == table.TableName.Trim()).ToList();
                foreach (var field in fields)
                {
                    table.AddField(field.TableName, field.FieldName, field.FieldType, field.Length, field.Scale);
                }
                var indexes = _listAllIndex.Where(i => i.TableName.Trim() == table.TableName.Trim()).ToList();
                foreach (var index in indexes)
                {
                    if (index.IxType == "HEAP")
                        continue;
                    var indexDefs = _listAllIndexDef.Where(id => id.IndexName == index.IndexName).ToList();
                    table.AddIndex(index.IndexName, index.IxType, index.FF, index.UQ,
                        index.PK, index.UQC, index.USeek, index.UScan,
                        index.ULookup, index.UUpdate,
                        index.LSeek, index.LScan, index.LLookup, index.LUpdate, indexDefs);
                }
            }
            _listAllTable.RemoveAll(x => x.Fields.Count == 0);
            return _listAllTable;
        }
    }

    public class OnPopulateAllTablesEventArgs : EventArgs
    {
        public int Total { get; set; }
        public int CurrentProgress { get; set; }
        public OnPopulateAllTablesEventArgs(int total, int currentProgress)
        {
            Total = total;
            CurrentProgress = currentProgress;
        }
    }
}
