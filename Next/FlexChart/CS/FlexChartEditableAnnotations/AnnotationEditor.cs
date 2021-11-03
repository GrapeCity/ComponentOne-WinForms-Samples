using System;
using System.Windows.Forms;
using C1.Win.Chart.Annotation;

namespace FlexChartEditableAnnotations
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
