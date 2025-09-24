using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.Helpers
{
    public static class BuildUrl
    {
        /// <summary>
        /// Returns the complete URL to link to AI model
        /// </summary>
        /// <param name="apiKey">API Key</param>
        /// <param name="baseUrl">Base URL to the API</param>
        /// <returns>String of URL which connects to the AI Model</returns>
        public static string BuildRequestUrl(string? apiKey, string? baseUrl)
        {
            var url = $"{baseUrl}?key={apiKey}";   

            if (string.IsNullOrWhiteSpace(url) || !Uri.IsWellFormedUriString(url, UriKind.Absolute))
                throw new InvalidOperationException("Gemini API URL is malformed or missing.");
            return url;

        }
    }
}
