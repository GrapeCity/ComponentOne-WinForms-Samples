using FlexGridGeminiAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridGeminiAI.Interface
{
    public interface IPromptGenerator
    {
        public string GenerateGeminiPrompt(string userPrompt, List<DataColumnSchema> schema);
    }
}
