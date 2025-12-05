using FlexGridGeminiAI.ErrorHandling;
using FlexGridGeminiAI.Helpers;
using FlexGridGeminiAI.Interface;
using FlexGridGeminiAI.Models;
using FlexGridGeminiAI.Services.ResponseParser;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace FlexGridGeminiAI.Services
{
    /// <summary>
    /// Gemini Service for connecting to Gemini and providing prompt responses.
    /// </summary>
    public class GeminiPromptService : IAIModel
    {
        public string Name => "Gemini";

        private readonly string? _urlToModel;

        public GeminiPromptService(string? apiKey, string? baseUrl)
        {
            _urlToModel = BuildUrl.BuildRequestUrl(apiKey, baseUrl);
        }
        public async Task<(string? response, AppError? error)> GetResponse(string prompt)
        {
            try
            {
                using var client = new HttpClient();
                var content = CreateRequestContent(prompt);

                var response = await client.PostAsync(_urlToModel, content);

                if (!response.IsSuccessStatusCode)
                    return (null, AIExceptionHandler.Handle((int)response.StatusCode, response.ReasonPhrase));

                var json = await response.Content.ReadAsStringAsync();

                var (result , error) = GeminiResponseParser.ParseGeminiResponse(json);

                return (result, error);
            }
            catch (HttpRequestException ex)
            {
                return (null, AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelTimeout,
                    "Network error contacting Gemini API."
                ));
            }
            catch (TaskCanceledException ex)
            {
                return (null, AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelTimeout,
                    "Request to Gemini API timed out."
                ));
            }
            catch (InvalidOperationException ex)
            {
                return (null, AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelMissingConfig,
                    "Gemini model configuration is invalid."
                ));
            }
        }

        private StringContent CreateRequestContent(string prompt)
        {
            var payload = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[] { new { text = prompt } }
                    }
                }
            };

            return new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
        }

       
    }
}
