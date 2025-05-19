using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace FlexGridAi.Helpers
{
    public class GeminiParsedResult
    {
        public string ResponseText { get; set; }
        public string JsonData { get; set; }
    }

    public static class GeminiResponseParser
    {
        public static GeminiParsedResult ExtractJsonFromResponse(string responseJson)
        {
            string modelText = null;
            var result = new GeminiParsedResult();

            try
            {
                var jsonObject = JObject.Parse(responseJson);
                modelText = jsonObject["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();

                if (!string.IsNullOrEmpty(modelText))
                {
                    // Normalize line breaks
                    modelText = modelText.Replace("\\n", "\n");

                    // Extract "Response: ..."
                    var responseMatch = Regex.Match(modelText, @"Response:\s*(.*)");
                    if (responseMatch.Success)
                    {
                        result.ResponseText = responseMatch.Groups[1].Value.Trim();
                    }

                    // Extract "Data: [...]"
                    var dataIndex = modelText.IndexOf("Data:", StringComparison.OrdinalIgnoreCase);
                    if (dataIndex != -1)
                    {
                        var jsonStart = modelText.IndexOf('[', dataIndex);
                        var jsonEnd = modelText.LastIndexOf(']');
                        if (jsonStart != -1 && jsonEnd > jsonStart)
                        {
                            var jsonPart = modelText.Substring(jsonStart, jsonEnd - jsonStart + 1);
                            result.JsonData = JToken.Parse(jsonPart).ToString(Formatting.Indented);
                        }
                    }
                }
            }
            catch
            {
                result.ResponseText = modelText; // fallback if parsing fails
            }

            return result;
        }
    }

}
