using FlexGridGeminiAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.Interface
{
    public interface IAIModel
    {
        /// <summary>
        /// AI Model name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Generates a response based on the given prompt asynchronously.
        /// </summary>
        /// <param name="prompt">The input string for which a response is required.</param>
        /// <returns>A task that represents the asynchronous operation, containing the generated response as a string.</returns>
        Task<(string? response, AppError? error)> GetResponse(string prompt);
    }
}
