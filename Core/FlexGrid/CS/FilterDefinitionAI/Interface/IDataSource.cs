using FlexGridGeminiAI.Models;
using System.Data;

namespace FlexGridGeminiAI.Interface
{
    public interface IDataSource
    {
        public string GetPathDb();
        public DataTable GetRows(string query, string tableName = "Result", IEnumerable<string> imageColumns = null);
        public List<DataColumnSchema> GetDataTableSchema(DataTable dataTable);
        public List<string> GetDataTables(string query);
        public void SetDataSource(string fileName);
    }
}
