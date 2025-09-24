using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.ErrorHandling
{
    public enum ErrorCode
    {
        // HTTP and API-related failures
        ApiUnauthorized = 401,
        ApiPaymentRequired = 402,
        ApiForbidden = 403,
        ApiNotFound = 404,
        ApiInternalError = 500,
        ApiServiceUnavailable = 503,
        HttpFailure = 550, // Distinct from server-side 500

        // Model and configuration issues
        ModelMissingConfig = 600,
        ModelInvalidInput = 601,
        ModelTimeout = 602,
        ModelUnsupportedOperation = 603,
        ModelParseError = 604,
        ModelResponseEmpty = 605,

        // Filter application errors
        FilterApplyInvalidOp = 700,
        FilterApplyFormatError = 701,
        FilterApplyUnexpected = 702,

        // Network and transport errors
        NetworkFailure = 800,
        NetworkTimeout = 801,
        NetworkUnreachable = 802,

        // General fallback
        ResponseRetrievalFailure = 900,
        UnexpectedError = 999
    }
}