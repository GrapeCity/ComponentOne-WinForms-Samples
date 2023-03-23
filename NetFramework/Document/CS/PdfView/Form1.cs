using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1Document;
using C1.Win.Ribbon;

namespace PdfView
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            //
            if (File.Exists("DefaultDocument.pdf"))
                c1PdfDocumentSource1.LoadFromFile("DefaultDocument.pdf");

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

            while (true)
            {
                try
                {
                    c1PdfDocumentSource1.LoadFromFile(ofdOpen.FileName);
                    return;
                }
                catch (PdfPasswordException)
                {
                    string password = PasswordForm.DoEnterPassword(ofdOpen.FileName);
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
    }
}
