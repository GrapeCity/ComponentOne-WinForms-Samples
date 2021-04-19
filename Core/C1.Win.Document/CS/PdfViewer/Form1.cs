using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Document;
using C1.Win.Document.Export;
using C1.Win.Ribbon;

namespace PdfViewer
{
    public partial class Form1 : C1RibbonForm
    {
        private string _title;

        public Form1()
        {
            // design initialize
            InitializeComponent();

            // set window coordinates
            object xo = Properties.Settings.Default["WindowX"];
            object yo = Properties.Settings.Default["WindowY"];
            object wo = Properties.Settings.Default["WindowWidth"];
            object ho = Properties.Settings.Default["WindowHeight"];
            if (xo != null && yo != null && wo != null && ho != null && (int)wo > 0 && (int)ho > 0)
            {
                Location = new Point((int)xo, (int)yo);
                Size = new Size((int)wo, (int)ho);
            }

            // set window state
            object wso = Properties.Settings.Default["WindowState"];
            if (wso != null && (int)wso >= 0 && (int)wso < 3)
            {
                WindowState = (FormWindowState)wso;
            }

            // remember default title
            if (string.IsNullOrWhiteSpace(_title))
            {
                _title = this.Text;
            }

            // load recent or default document
            string path = Properties.Settings.Default["RecentFile"] as string;
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"DefaultDocument.pdf");
            }
            if (File.Exists(path))
            {
                c1PdfDocumentSource1.LoadFromFile(path);
                SetTitle(path);
            }

            // initialize Ribbon control
            RibbonGroup rgFile = new RibbonGroup() { Text = "File" };
            c1FlexViewer1.Ribbon.Tabs[0].Groups.Insert(0, rgFile);

            RibbonButton rbOpen = new RibbonButton() { Text = "Open..." };
            rbOpen.ToolTip = "Open PDF file";
            rbOpen.ShortcutKeys = Keys.O | Keys.Control;
            rbOpen.KeyTip = "O";
            rbOpen.LargeImage = ilLarge.Images[0];
            rbOpen.SmallImage = ilSmall.Images[0];
            rbOpen.Click += Open_Click;
            rgFile.Items.Insert(0, rbOpen);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (ofdOpen.ShowDialog(this) != DialogResult.OK)
                return;

            string path = ofdOpen.FileName;

            while (true)
            {
                try
                {
                    c1PdfDocumentSource1.LoadFromFile(path);
                    SetTitle(path);
                    return;
                }
                catch (PdfPasswordException)
                {
                    string password = PasswordForm.DoEnterPassword(path);
                    if (password == null)
                        return;
                    c1PdfDocumentSource1.Credential.Password = password;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void SetTitle(string path)
        {
            this.Text = $"{_title} | {path}";
            Properties.Settings.Default["RecentFile"] = path;
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["WindowX"] = Location.X;
            Properties.Settings.Default["WindowY"] = Location.Y;
            Properties.Settings.Default["WindowWidth"] = Size.Width;
            Properties.Settings.Default["WindowHeight"] = Size.Height;
            Properties.Settings.Default["WindowState"] = (int)WindowState;
            Properties.Settings.Default.Save();
        }
    }
}
