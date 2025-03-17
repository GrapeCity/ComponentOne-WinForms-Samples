using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Ribbon;
using C1.Document;

namespace ControlExplorer.PdfDocumentSource
{
    public partial class PdfView : C1DemoForm
    {
        public PdfView()
        {
            InitializeComponent();

            //
            if (File.Exists(@"Resources\DefaultDocument.pdf"))
                c1PdfDocumentSource1.LoadFromFile(@"Resources\DefaultDocument.pdf");

            // initialize Ribbon control
            RibbonGroup rgFile = new RibbonGroup() { Text = "File" };
            c1FlexViewer1.Ribbon.Tabs[0].Groups.Insert(0, rgFile);

            RibbonButton rbOpen = new RibbonButton() { Text = "Open..." };
            rbOpen.ToolTip = "Open PDF file";
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
