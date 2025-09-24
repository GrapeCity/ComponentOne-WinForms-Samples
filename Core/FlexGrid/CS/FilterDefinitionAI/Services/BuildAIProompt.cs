using FlexGridGeminiAI.Interface;
using FlexGridGeminiAI.Models;
using System.Text;

namespace FlexGridGeminiAI.Services
{
    public  class BuildAIPrompt : IPromptGenerator
    {
        /// <summary>
        /// Builds a prompt using string builder to generate XML filterin for teh c1 flex grid
        /// </summary>
        /// <param name="userPrompt">Comes from the user, instruction</param>
        /// <param name="schema">Table which consisit of the DataTable schema</param>
        /// <returns>String, Prompt</returns>
        public string GenerateGeminiPrompt(string userPrompt, List<DataColumnSchema> schema)
        {
            var sbPrompt = new StringBuilder();

            if (schema == null || schema.Count == 0)
                return "No valid schema";

            if (string.IsNullOrWhiteSpace(userPrompt))
                return "Not related to data";

            sbPrompt.AppendLine("Generate an XML filter definition for a C1FlexGrid column filter.");
            sbPrompt.AppendLine();

            sbPrompt.AppendLine("User Request:");
            sbPrompt.AppendLine($"\"{userPrompt}\"");
            sbPrompt.AppendLine();

            sbPrompt.AppendLine("Schema:");
            sbPrompt.AppendLine("<Schema>");
            foreach (var col in schema)
            {
                sbPrompt.AppendLine($"  <Column Name=\\\"{col.Name}\\\" Index=\\\"{col.ColumnIndex}\\\" DataType=\\\"{col.DataType}\\\" />");
            }
            sbPrompt.AppendLine("</Schema>");
            sbPrompt.AppendLine();

            sbPrompt.AppendLine("Instructions:");
            sbPrompt.AppendLine("- (Strick)DO NOT INCLUDE ANY EXPLANATIONS — ONLY OUTPUT THE RAW XML snippet or a ONE-LINE message mentioned below is it is not related");
            sbPrompt.AppendLine("- Analyze the user request and identify relevant columns from the schema.");
            sbPrompt.AppendLine("- Matching must be case-insensitive.");
            sbPrompt.AppendLine("- If no relevant columns are found, return 'Not related to data' or 'No matching fields found'.");
            sbPrompt.AppendLine("- Do not treat 'and' as a logical AND unless it refers to conditions across multiple columns.");
            sbPrompt.AppendLine("- Use semantic reasoning; the user may not mention column names explicitly.");
            sbPrompt.AppendLine();
            sbPrompt.AppendLine("- Distinguish between inclusion and exclusion intents:");
            sbPrompt.AppendLine("  * If the user wants to show/include/filter by certain values (e.g., 'show only red items'), use 'Contains', 'Equals', etc.");
            sbPrompt.AppendLine("  * If the user wants to remove/exclude/filter out values (e.g., 'remove all containing animal names'), use 'DoesNotContain', 'NotEquals', etc.");
            sbPrompt.AppendLine("  * Common exclusion keywords: 'remove', 'exclude', 'filter out', 'except', 'do not show', 'without'.");
            sbPrompt.AppendLine();
            sbPrompt.AppendLine("- For exclusionary filters, generate a broad list of filter values.");
            sbPrompt.AppendLine("- Include at least 100-150 common terms from the relevant category.");
            sbPrompt.AppendLine("- For example, if filtering out animal names, include a diverse range: domestic animals, wild animals, birds, fish, reptiles, insects.");
            sbPrompt.AppendLine("- The filter values must be common and semantically relevant, even if not explicitly mentioned by the user.");

            sbPrompt.AppendLine("- The output must follow this XML structure:");
            sbPrompt.AppendLine();
            sbPrompt.AppendLine("Output Structure Examples:");
            sbPrompt.AppendLine("1. Single-Condition Format:");
            sbPrompt.AppendLine("  <ColumnFilters>");
            sbPrompt.AppendLine("    <ConditionFilter");
            sbPrompt.AppendLine("      ColumnIndex=\\\"[index]\\\"");
            sbPrompt.AppendLine("      ColumnName=\\\"[name]\\\"");
            sbPrompt.AppendLine("      DataType=\\\"[type]\\\"");
            sbPrompt.AppendLine("      ConditionFilterEnabled=\\\"True\\\"");
            sbPrompt.AppendLine("      ValueFilterEnabled=\\\"False\\\">");
            sbPrompt.AppendLine("      <ConditionFilter>");
            sbPrompt.AppendLine("        <Condition ChainingWithAnd=\\\"False\\\" Operator=\\\"[operator]\\\" Parameter=\\\"[value]\\\" />");
            sbPrompt.AppendLine("      </ConditionFilter>");
            sbPrompt.AppendLine("    </ConditionFilter>");
            sbPrompt.AppendLine("  </ColumnFilters>");
            sbPrompt.AppendLine();
            sbPrompt.AppendLine("2. Multi-Condition Format:");
            sbPrompt.AppendLine("  <ColumnFilters>");
            sbPrompt.AppendLine("    <ConditionFilter");
            sbPrompt.AppendLine("      ColumnIndex=\\\"[index]\\\"");
            sbPrompt.AppendLine("      ColumnName=\\\"[name]\\\"");
            sbPrompt.AppendLine("      DataType=\\\"[type]\\\"");
            sbPrompt.AppendLine("      ConditionFilterEnabled=\\\"True\\\"");
            sbPrompt.AppendLine("      ValueFilterEnabled=\\\"False\\\">");
            sbPrompt.AppendLine("      <ConditionFilter>");
            sbPrompt.AppendLine("        <Condition ChainingWithAnd=\\\"False\\\" Operator=\\\"[operator]\\\" Parameter=\\\"[value1]\\\" />");
            sbPrompt.AppendLine("        <Condition ChainingWithAnd=\\\"False\\\" Operator=\\\"[operator]\\\" Parameter=\\\"[value2]\\\" />");
            sbPrompt.AppendLine("        <!-- Add as many as are relevant -->");
            sbPrompt.AppendLine("      </ConditionFilter>");
            sbPrompt.AppendLine("    </ConditionFilter>");
            sbPrompt.AppendLine("  </ColumnFilters>");
            sbPrompt.AppendLine();
            sbPrompt.AppendLine("- Choose appropriate operators like GreaterThan, Contains, Equals, DoesNotContain, NotEquals based on user intent and column type.");
            sbPrompt.AppendLine("- Output must be valid XML, with all quotes escaped as \\\".");
            sbPrompt.AppendLine("- Do not include explanations — only output the XML snippet or a one-line message.");

            return sbPrompt.ToString();
        }


    }
}
