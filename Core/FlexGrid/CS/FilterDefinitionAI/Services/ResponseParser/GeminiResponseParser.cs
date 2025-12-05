using FlexGridGeminiAI.ErrorHandling;
using FlexGridGeminiAI.Models;
using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace FlexGridGeminiAI.Services.ResponseParser
{
    public class GeminiResponseParser
    {
        /// <summary>
        /// Parses a raw JSON response from the Gemini API and extracts relevant content.
        /// </summary>
        /// <remarks>This method expects the JSON to follow a specific structure, including a "candidates"
        /// array  with nested "content" and "parts" objects. If the structure is invalid or the required fields  are
        /// missing, the method will return an error message instead of throwing an exception.</remarks>
        /// <param name="rawJson">The raw JSON string returned by the Gemini API.</param>
        /// <returns>A string containing the extracted content if successful. If the content is empty or not relevant,  a
        /// descriptive message is returned. If parsing fails, an error message is returned.</returns>
        public static (string? result, AppError? error) ParseGeminiResponse(string geminiResponse)
        {
            try
            {
                using var parsedGeminiResponse = JsonDocument.Parse(geminiResponse);
                var root = parsedGeminiResponse.RootElement;

                var text = root.GetProperty("candidates")[0]
                               .GetProperty("content")
                               .GetProperty("parts")[0]
                               .GetProperty("text")
                               .GetString();

                if (string.IsNullOrWhiteSpace(text))
                    return ("No text found in response.", null);

                var code = ExtractXmlFromBackticks(text);

                var result = string.IsNullOrWhiteSpace(code)
                    ? "Prompt is not related to the Data."
                    : code.Trim();

                return (result, null);
            }
            catch (JsonException ex)
            {
                var error = AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelInvalidInput,
                    "Invalid JSON format returned by Gemini API.",
                    ex.Message
                );
                return (null, error);
            }
            catch (IndexOutOfRangeException ex)
            {
                var error = AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelInvalidInput,
                    "Unexpected array structure in Gemini response.",
                    ex.Message
                );
                return (null, error);
            }
            catch (KeyNotFoundException ex)
            {
                var error = AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelInvalidInput,
                    "Missing expected property in Gemini response.",
                    ex.Message
                );
                return (null, error);
            }
            catch (InvalidOperationException ex)
            {
                var error = AIExceptionHandler.Handle(
                    ex,
                    ErrorCode.ModelUnsupportedOperation,
                    "Invalid operation while parsing Gemini response.",
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
