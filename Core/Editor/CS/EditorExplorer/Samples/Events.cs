using C1.Win.Editor;
using C1.Win.Editor.Ribbon;
using C1.Win.Ribbon;
using C1.Win.Themes;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.IO;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;

namespace EditorExplorer.Samples
{
    public partial class Events : UserControl
    {
        public Events()
        {
            InitializeComponent();
            c1Editor1.C1EditorReady += c1Editor1_C1EditorReadyAsync;
            c1Editor1.ClientSizeChanged += C1Editor1_Resize;
            c1Editor1.SizeChanged += C1Editor1_Resize;

            c1Editor1.DragDrop += C1Editor1_DragDrop;
            c1Editor1.DragEnter += C1Editor1_DragEnter;
            c1Editor1.DragOver += C1Editor1_DragOver;
            c1Editor1.DragLeave += C1Editor1_DragLeave;

            c1Editor1.MouseUp += C1Editor1_MouseUp;
            c1Editor1.MouseDown += C1Editor1_MouseDown;

            c1Editor1.DocumentChanged += C1Editor1_DocumentChanged;
        }
        private void C1Editor1_Resize(object sender, EventArgs e)
        {
            c1Editor1.Focus();
        }

        private async void c1Editor1_C1EditorReadyAsync(object sender, EventArgs e)
        {
            string filename = @"Resources\tesla.html";
            if (File.Exists(filename))
            {
                await c1Editor1.LoadDocumentAsync(Path.GetFullPath(filename));
                await c1Editor1.SetDefaultStylesAsync(null, true);
            }
        }

        private void C1Editor1_DragEnter(object? sender, DragEventArgs e)
        {
            AddLog("DragEnter");
        }

        private void C1Editor1_DragDrop(object? sender, DragEventArgs e)
        {
            AddLog("DragDrop");
        }

        private void C1Editor1_DragLeave(object? sender, EventArgs e)
        {
            AddLog("DragLeave");
        }

        private void C1Editor1_DragOver(object? sender, DragEventArgs e)
        {
            AddLog("DragOver");
        }
        private void C1Editor1_MouseDown(object? sender, MouseEventArgs e)
        {
            AddLog("MouseDown");
        }
        private void C1Editor1_MouseUp(object? sender, MouseEventArgs e)
        {
            AddLog("MouseUp");
        }
        private void C1Editor1_DocumentChanged(object? sender, EventArgs e)
        {
            AddLog("DocumentChanged");
        }

        private int count = 0;
        private string lastMessage = "";
        private int times = 0;
        private void AddLog(string message)
        {
            if (message == lastMessage)
            {
                times++;
                ReplaceLastLine(count.ToString("D3") + " - " + message + ". Times : " + times.ToString());
            }
            else
            {
                lastMessage = message;
                times = 1;
                count++;
                AppendLine(count.ToString("D3") + " - " + message);
            }
        }

        private void AppendLine(string text)
        {
            if (richTextBoxEvents.TextLength > 0)
                richTextBoxEvents.AppendText("\n");

            richTextBoxEvents.AppendText(text);
            richTextBoxEvents.SelectionStart = richTextBoxEvents.TextLength;
            richTextBoxEvents.ScrollToCaret();
        }

        private void ReplaceLastLine(string text)
        {
            int start = richTextBoxEvents.Text.LastIndexOf('\n');
            start = start < 0 ? 0 : start + 1;

            richTextBoxEvents.Select(start, richTextBoxEvents.TextLength - start);
            richTextBoxEvents.SelectedText = text;

            richTextBoxEvents.SelectionStart = richTextBoxEvents.TextLength;
        }
    }
}
