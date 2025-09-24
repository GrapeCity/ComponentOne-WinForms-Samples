using FlexGridGeminiAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.ErrorHandling
{
    public static class ErrorHandler
    {
        public static AppError FromHttpStatus(int code, string? details = null)
        {
            return code switch
            {
                401 => new AppError(ErrorCode.ApiUnauthorized, "Unauthorized access.", details),
                402 => new AppError(ErrorCode.ApiPaymentRequired, "Payment required.", details),
                403 => new AppError(ErrorCode.ApiForbidden, "Access is forbidden.", details),
                404 => new AppError(ErrorCode.ApiNotFound, "Resource not found.", details),
                500 => new AppError(ErrorCode.ApiInternalError, "Internal server error.", details),
                503 => new AppError(ErrorCode.ApiServiceUnavailable, "Service is unavailable.", details),
                _ => new AppError(ErrorCode.ApiInternalError, $"Unhandled status code: {code}", details)

            };
        }
        public static AppError FromModelError(ErrorCode code, string message, string? details = null, Exception? ex = null)
        {
            return new AppError(code, message, details, ex);
        }
    }
}
