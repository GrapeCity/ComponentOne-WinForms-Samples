using FlexGridGeminiAI.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.Models
{
    public class AppError(ErrorCode code, string message, string? details = null, Exception exception = null)
    {
        public ErrorCode Code { get; } = code;
        public string Message { get; } = message;
        public string? Details { get; } = details;
        public Exception? Exception { get; } = exception;
        public override string ToString()
        {
            return $"[{(int)Code} {Code}] {Message}" +
               (Details != null ? $" - {Details}" : "") +
               (Exception != null ? $" - Exception: {Exception.Message}" : "");
        }
    }      
}
