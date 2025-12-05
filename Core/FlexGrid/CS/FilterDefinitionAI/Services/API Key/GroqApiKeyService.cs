using FlexGridGeminiAI.Interface;
using FlexGridGeminiAI.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.Services
{
    public class GroqApiKeyService : IApiKeyService
    {
        private const string key = "GROQ_API_KEY";

        public string? GetApiKey()
        {
            string? GROQ_API_KEY = Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.User);
            return GROQ_API_KEY ?? string.Empty;
        }

        public bool ApiKeyExists()
        { 
            return !string.IsNullOrEmpty(GetApiKey());  
        }

        public void SetApiKey(string value)
        {
            Environment.SetEnvironmentVariable(key, value, EnvironmentVariableTarget.User);
        }
    }
}
