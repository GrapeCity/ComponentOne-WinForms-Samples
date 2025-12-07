using System.Text;
using System.Text.RegularExpressions;

namespace CreatingDiagram.Utils
{
    public static class SyntaxHighlighter
    {
        // A minimal set of C# keywords; you can add more as needed.
        private static readonly string[] Keywords = new[]
        {
        "abstract","as","base","bool","break","byte","case","catch","char","checked",
        "class","const","continue","decimal","default","delegate","do","double","else",
        "enum","event","explicit","extern","false","finally","fixed","float","for",
        "foreach","goto","if","implicit","in","int","interface","internal","is","lock",
        "long","namespace","new","null","object","operator","out","override","params",
        "private","protected","public","readonly","ref","return","sbyte","sealed","short",
        "sizeof","stackalloc","static","string","struct","switch","this","throw","true",
        "try","typeof","uint","ulong","unchecked","unsafe","ushort","using","virtual",
        "void","volatile","while","var","async","await","yield"
    };

        // Pre‐compiled regexes for performance
        private static readonly Regex StringLiteral = new Regex(@"@?""(""(?:\""""|[^""])*""|([^""]|\\.)*?)""", RegexOptions.Compiled);
        private static readonly Regex VerbatimString = new Regex(@"@""(""|[^""])*""", RegexOptions.Compiled);
        private static readonly Regex LineComment = new Regex(@"//.*?$", RegexOptions.Compiled | RegexOptions.Multiline);
        private static readonly Regex BlockComment = new Regex(@"/\*[\s\S]*?\*/", RegexOptions.Compiled);
        private static readonly Regex NumberLiteral = new Regex(@"\b\d+(\.\d+)?\b", RegexOptions.Compiled);
        private static readonly Regex KeywordRegex;

        static SyntaxHighlighter()
        {
            // Build a regex that matches any keyword, using \b boundaries
            string kw = "\\b(" + string.Join("|", Keywords) + ")\\b";
            KeywordRegex = new Regex(kw, RegexOptions.Compiled);
        }

        /// <summary>
        /// Escapes HTML chars: &, <, > into HTML entities.
        /// </summary>
        private static string EscapeHtml(string s)
        {
            return s
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;");
        }

        /// <summary>
        /// Highlights a C# code snippet and returns HTML string.
        /// </summary>
        /// <param name="code">The C# code snippet</param>
        /// <param name="cssClassForPre">CSS class for &lt;pre&gt; wrapper</param>
        /// <returns>HTML string with syntax highlighting</returns>
        public static string HighlightCSharp(string code, string cssClassForPre = "csharp-code")
        {
            if (code == null) throw new ArgumentNullException(nameof(code));

            // Escape HTML
            string escaped = EscapeHtml(code);

            // We will store intermediate parts to avoid overlapping replacements
            var placeholders = new Dictionary<string, string>();
            int placeholderCounter = 0;

            // A helper to generate placeholder keys
            string NewPlaceholder()
            {
                return $"__PLACEHOLDER_{placeholderCounter++}__";
            }

            // 1. Block comments (/* ... */)
            escaped = BlockComment.Replace(escaped, m =>
            {
                var key = NewPlaceholder();
                placeholders[key] = $"<span class=\"comment\">{m.Value}</span>";
                return key;
            });

            // 2. Line comments (// ...)
            escaped = LineComment.Replace(escaped, m =>
            {
                var key = NewPlaceholder();
                placeholders[key] = $"<span class=\"comment\">{m.Value.TrimEnd()}</span>";
                return key;
            });

            // 3. Verbatim strings @"..."
            escaped = VerbatimString.Replace(escaped, m =>
            {
                var key = NewPlaceholder();
                placeholders[key] = $"<span class=\"string\">{m.Value}</span>";
                return key;
            });

            // 4. Ordinary string literals "..."
            escaped = StringLiteral.Replace(escaped, m =>
            {
                // Skip if it's been handled (verbatim) — but order ensures we do verbatim first
                var key = NewPlaceholder();
                placeholders[key] = $"<span class=\"string\">{m.Value}</span>";
                return key;
            });

            // 5. Numbers
            escaped = NumberLiteral.Replace(escaped, m =>
            {
                var key = NewPlaceholder();
                placeholders[key] = $"<span class=\"number\">{m.Value}</span>";
                return key;
            });

            // 6. Keywords
            escaped = KeywordRegex.Replace(escaped, m =>
            {
                return $"<span class=\"keyword\">{m.Value}</span>";
            });

            // 7. Restore placeholders
            foreach (var kv in placeholders)
            {
                escaped = escaped.Replace(kv.Key, kv.Value);
            }

            // Wrap into <pre><code>
            var sb = new StringBuilder();
            sb.Append($"<pre class=\"{cssClassForPre}\"><code>");
            sb.Append(escaped);
            sb.Append("</code></pre>");

            return sb.ToString();
        }
    }

}
