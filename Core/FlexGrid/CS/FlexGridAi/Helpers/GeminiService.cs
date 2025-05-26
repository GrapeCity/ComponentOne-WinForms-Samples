using FlexGridAi.Utilities;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace FlexGridAi.Helpers
{
    public class GeminiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent";

        public GeminiService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Sends a prompt and JSON data to the Gemini API and returns the response.
        /// </summary>
        public async Task<string> GetResponseAsync(string prompt, string jsonData)
        {
            string apiKey = EnvironmentHelper.GetApiKey();
            string apiUrl = $"{BaseUrl}?key={apiKey}";

            var content = BuildRequestContent(prompt, jsonData);
            var response = await _httpClient.PostAsync(apiUrl, content);
            
            if (!response.IsSuccessStatusCode)
            {
                // Use the factory method to create the appropriate exception
                throw GeminiApiException.CreateFromStatusCode((int)response.StatusCode, response.ReasonPhrase);
            }

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Builds the HTTP content payload for the Gemini API using a prompt and JSON data.
        /// </summary>
        private static StringContent BuildRequestContent(string prompt, string jsonData)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Prompt: {prompt}");
            sb.AppendLine();
            sb.AppendLine($"Data: {jsonData}");
            sb.AppendLine();
            sb.AppendLine("Instructions:");
            sb.AppendLine("1. If the prompt is related to the data, respond based on the type of analysis required:");
            sb.AppendLine("   a. If it's a **comparison**, respond in this format:");
            sb.AppendLine("      Response: <brief explanation (5–20 words)>");
            sb.AppendLine("      Data: <valid JSON array>");
            sb.AppendLine();
            sb.AppendLine("   b. If it's an **aggregation** (e.g., totals, averages, summaries), respond in this format:");
            sb.AppendLine("      Response: <brief explanation with the answer (5–20 words)>");
            sb.AppendLine();
            sb.AppendLine("2. If the prompt is **not related to the data**, respond only with:");
            sb.AppendLine("   Response: <brief explanation (5–20 words)>");

            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[] { new { text = sb.ToString() } }
                    }
                }
            };

            string json = JsonConvert.SerializeObject(requestBody);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        /// <summary>
        /// Validates a given Gemini API key by sending a simple test message.
        /// </summary>
        public static async Task<bool> ValidateApiKeyAsync(string testKey)
        {
            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[] { new { text = "Hello!" } }
                    }
                }
            };

            using var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            string apiUrl = $"{BaseUrl}?key={testKey}";
            var response = await client.PostAsync(apiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                // Use the factory method to create the appropriate exception
                throw GeminiApiException.CreateFromStatusCode((int)response.StatusCode, response.ReasonPhrase);
            }

            return true;
        }
    }
}
