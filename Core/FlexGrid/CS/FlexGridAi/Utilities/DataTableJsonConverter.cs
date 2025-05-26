using Newtonsoft.Json;
using System.Data;

namespace FlexGridAi.Utilities
{
    static class DataTableJsonConverter
    {
        public static string ConvertDataTableToJson(DataTable dt)
        {
            return JsonConvert.SerializeObject(dt, Formatting.Indented);
        }

        public static DataTable ConvertJsonToDataTable(string jsonData)
        {
            return JsonConvert.DeserializeObject<DataTable>(jsonData);
        }
    }
}
