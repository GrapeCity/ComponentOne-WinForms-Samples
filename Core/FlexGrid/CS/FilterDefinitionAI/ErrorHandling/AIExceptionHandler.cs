// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using FlexGridGeminiAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.ErrorHandling
{
    public static class AIExceptionHandler
    {
        /// <summary>
        /// Constructs a structured <see cref="AppError"/> from an exception, error code, and message.
        /// Enables consistent error mapping across services with optional diagnostic details for UI-friendly feedback.
        /// </summary>
        /// <param name="ex">The originating exception to capture.</param>
        /// <param name="code">The domain-specific error code representing the failure type.</param>
        /// <param name="message">A user-facing or diagnostic message describing the error.</param>
        /// <param name="details">Optional extended details for debugging or logging.</param>
        /// <returns>An <see cref="AppError"/> encapsulating the error context.</returns>
        public static AppError Handle(
            Exception ex, 
            ErrorCode code, 
            string message, 
            string? details = null
            )
        {
            return new AppError(code, message, details, ex);
        }

        public static AppError Handle(int httpStatusCode, string reason)
        {
            return new AppError(ErrorCode.HttpFailure, $"HTTP {httpStatusCode}: {reason}");
        }
    }
}
