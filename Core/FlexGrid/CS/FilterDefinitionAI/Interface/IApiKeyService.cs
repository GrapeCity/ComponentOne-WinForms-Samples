using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.Interface
{
    public interface IApiKeyService
    {
        /// <summary>
        /// Retrieves the stored API key, prompting the user if necessary.
        /// </summary>
        string? GetApiKey();

        /// <summary>
        /// Persists the API key in the desired location (e.g., user environment).
        /// </summary>
        void SetApiKey(string value);


        /// <summary>
        /// Check if there is API key or not in the enviroment.
        /// </summary>
        bool ApiKeyExists();
    }
}
