using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.Chart.Designer.Data;
using C1.Win.Chart.Designer.Utils;

namespace C1.Win.Chart.Designer.UI
{
    partial class FieldLabel : UserControl
    {
        Field field;

        public FieldLabel(Field f, bool closeButton = false, bool drag = true)
        {
            InitializeComponent();
            btnClose.Visible = closeButton;
            tableLayoutPanel1.ColumnCount = closeButton ? 3 : 2;

            field = f;

            lblName.Text = f.Name;
            lblType.Text = f is Measure ? ((Measure)f).Type.ToString().ToLower() : "string";

            //AllowDrop = lblType.AllowDrop = lblName.AllowDrop = true;

            //lblName.DragOver += OnDragOver;
            //lblType.DragOver += OnDragOver;
            //DragOver += OnDragOver;

            if (drag)
            {
                lblName.MouseDown += OnMouseDown;
                lblType.MouseDown += OnMouseDown;
                MouseDown += OnMouseDown;

                lblName.GiveFeedback += OnGiveFeedback;
                lblType.GiveFeedback += OnGiveFeedback;
                GiveFeedback += OnGiveFeedback;
            }
        }

        public Field Field
        {
            get { return field; }
        }

        public event EventHandler Closed;

        private void OnGiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = e.Effect != DragDropEffects.Copy;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop( field.Name, DragDropEffects.Copy);
            //CreateCursor(field.Name);
        }

        private void CreateCursor(string str)
        {
            //e.Effect = DragDropEffects.Copy;

            SizeF size;
            Font f = new Font("Segoe UI", 10, FontStyle.Regular);
            using (Bitmap tmpBmp = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(tmpBmp))
                size = g.MeasureString(str, f);

            size.Height += 4;
            size.Width += 4;

            Bitmap bitmap = new Bitmap((int)Math.Ceiling(size.Width),
                (int)Math.Ceiling(size.Height));
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                g.FillRectangle(SystemBrushes.Control, 0, 0, size.Width, size.Height);
                g.DrawString(str, f, SystemBrushes.ControlText, 2, 2);
                g.DrawRectangle(Pens.Black, 0, 0, size.Width - 1, size.Height - 1);
            }

            Cursor.Current = CursorUtils.CreateCursor(bitmap, 0, 0);

            bitmap.Dispose();
            f.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Closed != null)
                Closed(sender, e);
        }
    }
}
