using CreatingDiagram.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingDiagram.Controls
{
    public partial class CodeSnippet : UserControl
    {
        string code = "";
        Button buttonCopy = new Button() { Text = "\ue8c8", AutoSize = true, Padding = new Padding() };

        public CodeSnippet()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async();

            buttonCopy.Font = new Font("Segoe Fluent Icons", Font.Size);
            buttonCopy.Click += (s, e) =>
            {
                if(!string.IsNullOrEmpty(code)) 
                    Clipboard.SetText(Code);
            };

            webView21.SizeChanged += (s, e) =>
            {
                var size = webView21.ClientSize;
                buttonCopy.Location = new Point( size.Width - buttonCopy.Width - 24, 24);
            };


            webView21.Controls.Add(buttonCopy);
        }

        void SetCodeHtml(string code)
        {
            if (string.IsNullOrEmpty(code))
                return;

            var html = SyntaxHighlighter.HighlightCSharp(code);
            string fullHtml = $@"
            <!DOCTYPE html>
            <html>
            <head>
<style>
.bdr
{{
}}
.body {{
    border: 0.2px solid lightgray;
    border-radius:4px;

}}

.csharp-code {{
    overflow: auto;

    padding: 4px;
    font-family: Consolas, ""Courier New"", monospace;
    white-space: pre;
}}

.csharp-code .keyword {{ color: #0000ff; font-weight: bold; }}
.csharp-code .string  {{ color: #a31515; }}
.csharp-code .comment {{ color: #008000; font-style: italic; }}
.csharp-code .number  {{ color: #098658; }}
</style>

            </head>
            <body class='body'>
                <div>{html}</div>
            </body>
            </html>";

            webView21.NavigateToString(fullHtml);
        }


        public string Code
        {
            get => code;
            set
            {
                if (code != value)
                {
                    code = value;
                    SetCodeHtml(code);
                }
            }
        }
    }
}
