using FlexGridGeminiAI.ErrorHandling;
using FlexGridGeminiAI.Interface;
using FlexGridGeminiAI.Models;
using FlexGridGeminiAI.Services.ResponseParser;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace FlexGridGeminiAI.Services
{
    public class GroqPromptService : IAIModel
    {
        public string Name => "Groq";

        private readonly string? _apiKey;
        private readonly string? _baseUrl;

        public GroqPromptService(string? apiKey, string? baseUrl)
        {
            _apiKey = apiKey;
            _baseUrl = baseUrl;
        }

        public async Task<(string? response, AppError? error)> GetResponse(string prompt)
        {
            if (!IsConfigured(out var configMessage))
            {
                var configError = AIExceptionHandler.Handle(
                    new InvalidOperationException("Missing configuration"),
                    ErrorCode.ModelMissingConfig,
                    "Groq model configuration is invalid or missing.",
                    configMessage
                );
                return (null, configError);
            }

            try
            {
                using var client = CreateHttpClient();
                var content = CreateRequestContent(prompt);

                var response = await client.PostAsync(_baseUrl!, content);

                if (!response.IsSuccessStatusCode)
                {
                    var httpError = AIExceptionHandler.Handle((int)response.StatusCode, response.ReasonPhrase);
                    return (null, httpError);
                }

                var responseJson = await response.Content.ReadAsStringAsync();
                var (parsed, error) = GroqResponseParser.ParseGroqResponse(responseJson);

                return (parsed, error);
            }
            catch (TaskCanceledException timeoutEx)
            {
                var timeoutError = AIExceptionHandler.Handle(
                    timeoutEx,
                    ErrorCode.ModelTimeout,
                    "Request to Groq API timed out."
                );
                return (null, timeoutError);
            }
            catch (InvalidOperationException configEx)
            {
                var configError = AIExceptionHandler.Handle(
                    configEx,
                    ErrorCode.ModelMissingConfig,
                    "Groq model configuration is invalid or missing."
                );
                return (null, configError);
            }
        }

        private bool IsConfigured(out string errorMessage)
        {
            if (string.IsNullOrEmpty(_apiKey) || string.IsNullOrEmpty(_baseUrl))
            {
                errorMessage = ErrorHandler
                    .FromModelError(
                        ErrorCode.ModelMissingConfig,
                        "Groq API key or base URL is missing.",
                        "GroqPromptService initialization issue"
                    )
                    .ToString();
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
            return client;
        }

        private StringContent CreateRequestContent(string prompt)
        {
            var payload = new
            {
                model = "meta-llama/llama-4-scout-17b-16e-instruct",
                messages = new[]
                {
                    new { role = "user", content = prompt }
                }
            };

            return new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
        }
    }
}
