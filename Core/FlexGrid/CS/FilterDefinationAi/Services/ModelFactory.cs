using C1.Win.Input;
using FlexGridGeminiAI.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.Services
{
    public class ModelFactory
    {
        IApiKeyService _geminiKey;
        IApiKeyService _groqKey ;

        public ModelFactory()
        {
            _geminiKey = new GeminiApiKeyService();
            _groqKey = new GroqApiKeyService();
        }

        public IAIModel CreateGeminiModel()
        {   
            string? apiKey = _geminiKey.GetApiKey();
                string? apiUrl = ConfigurationManager.AppSettings["GeminiApiUrl"];
                return new GeminiPromptService(apiKey, apiUrl);
        }

        public IAIModel CreateGroqModel()
        {
            string? apiKey = _groqKey.GetApiKey();
            string? apiUrl = ConfigurationManager.AppSettings["GroqApiUrl"];
            return new GroqPromptService(apiKey, apiUrl);
        }


    }
}
