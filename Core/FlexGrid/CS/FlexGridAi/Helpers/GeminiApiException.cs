[Serializable]
public class GeminiApiException : Exception
{
    public int StatusCode { get; }

    // Constructor with message and status code
    public GeminiApiException(string message, int statusCode) : base(message)
    {
        StatusCode = statusCode;
    }

    // Factory Method - Creates an exception based on status code
    public static GeminiApiException CreateFromStatusCode(int statusCode, string reasonPhrase)
    {
        return statusCode switch
        {
            404 => new GeminiApiException("The requested URL was not found.", 404),
            400 => new GeminiApiException("Invalid API Key", 400),
            503 => new GeminiApiException("Service Unavailable: The model is overloaded. Please try again later.", 503),
            _ => new GeminiApiException($"API Error: {statusCode} - {reasonPhrase}", statusCode)
        };
    }
}
