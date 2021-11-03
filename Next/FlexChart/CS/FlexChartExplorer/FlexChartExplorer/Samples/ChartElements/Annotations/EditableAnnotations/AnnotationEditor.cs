using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlexChartExplorer.Samples
{
    public partial class AnnotationEditor : TextEditor
    {
        public AnnotationEditor()
        {
            InitializeComponent();
        }
        public override void UpdateEditorContent()
        {
            textBox1.Text = GetAnnotationContent();
        }

        private void btnOKCancelClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn.Tag.ToString() == "OK")
                AcceptChanges(textBox1.Text);
            else
                RejectChanges();
            this.Parent.Controls.Remove(this);
        }
    }
}
