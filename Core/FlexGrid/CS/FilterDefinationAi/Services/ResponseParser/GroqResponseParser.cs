using FlexGridGeminiAI.ErrorHandling;
using FlexGridGeminiAI.Models;
using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace FlexGridGeminiAI.Services.ResponseParser
{
    public class GroqResponseParser
    {
        /// <summary>
        /// Parses the raw JSON response from the Groq API and extracts the assistant's reply content.
        /// </summary>
        /// <remarks>
        /// Expects OpenAI-compatible structure: "choices" → "message" → "content".
        /// </remarks>
        /// <param name="rawJson">Raw JSON string returned by the Groq API.</param>
        /// <returns>Extracted assistant response or descriptive error message.</returns>
        public static (string? result, AppError? error) ParseGroqResponse(string rawGroqResponse)
        {
            try
            {
                using var parsedGroqResponse = JsonDocument.Parse(rawGroqResponse);
                var root = parsedGroqResponse.RootElement;

                var content = root.GetProperty("choices")[0]
                                  .GetProperty("message")
                                  .GetProperty("content")
                                  .GetString();

                if (string.IsNullOrWhiteSpace(content))
                    return ("Groq response is empty or malformed.", null);

                var code = ExtractXmlFromBackticks(content);

                var result = string.IsNullOrWhiteSpace(code)
                    ? content.Trim()
                    : code.Trim();

                return (result, null);
            }
            catch (JsonException ex)
            {
                var error = AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelInvalidInput,
                    "Invalid JSON format returned by Groq API.",
                    ex.Message
                );
                return (null, error);
            }
            catch (IndexOutOfRangeException ex)
            {
                var error = AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelInvalidInput,
                    "Unexpected array structure in Groq response.",
                    ex.Message
                );
                return (null, error);
            }
            catch (KeyNotFoundException ex)
            {
                var error = AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelInvalidInput,
                    "Missing expected property in Groq response.",
                    ex.Message
                );
                return (null, error);
            }
            catch (InvalidOperationException ex)
            {
                var error = AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelUnsupportedOperation,
                    "Invalid operation while parsing Groq response.",
                    ex.Message
                );
                return (null, error);
            }
        }

        private static string ExtractXmlFromBackticks(string text)
        {
            var match = Regex.Match(text, @"```(?:xml)?\s*(.*?)\s*```", RegexOptions.Singleline);
            return match.Success ? match.Groups[1].Value : null;
        }
    }
}