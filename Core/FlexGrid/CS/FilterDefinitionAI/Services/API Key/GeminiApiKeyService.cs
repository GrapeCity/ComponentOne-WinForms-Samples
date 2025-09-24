using FlexGridGeminiAI.Interface;
using FlexGridGeminiAI.Views.Forms;

namespace FlexGridGeminiAI.Services
{
    public class GeminiApiKeyService : IApiKeyService
    {
        private const string key = "GEMINI_API_KEY";
        public string? GetApiKey()
        {
            string? GEMINI_API_KEY = Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.User);
            return GEMINI_API_KEY ?? string.Empty;
        }
        public void SetApiKey(string value)
        {
            Environment.SetEnvironmentVariable(key, value, EnvironmentVariableTarget.User);
        }

        public bool ApiKeyExists()
        {
           return !string.IsNullOrEmpty(GetApiKey());
        }

    }
}
