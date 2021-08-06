using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiDocumentFilesPrint
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            Form main = Application.OpenForms[0];
            this.Location = new Point(main.Left + 40, main.Top + 60);
            this.Owner = main;
        }

        public bool Cancelled
        {
            get { return this.DialogResult == System.Windows.Forms.DialogResult.Cancel; }
        }

        public void SetProgress(string text, float complete)
        {
            this.label1.Text = text;
            this.progressBar1.Value = (int)(complete * 100);
            btnCancel.Enabled = true;
            Application.DoEvents();
        }

        public void SetProgress(string text)
        {
            SetProgress(text, 0.5f);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Enabled = false;
        }
    }
}
