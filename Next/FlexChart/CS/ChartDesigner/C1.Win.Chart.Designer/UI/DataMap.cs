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
    internal partial class DataMap : UserControl
    {
        Dictionary<string, List<Field>> bindings = new Dictionary<string, List<Field>>();
        DataEngine eng;

        public DataMap()
        {
            InitializeComponent();
            //InitBindings();

            Dock = DockStyle.Fill;
            tableLayoutPanel1.AllowDrop = true;
            tableLayoutPanel1.DragOver += OnDragOver;
            tableLayoutPanel1.DragDrop += OnDragDrop;
        }

        private void OnDragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            string str = e.Data.GetData(typeof(String)) as String;

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

        private void OnDragDrop(object sender, DragEventArgs e)
        {
            foreach (Control ctrl in tblBindings.Controls)
            {
                if (ctrl.RectangleToScreen(new Rectangle(0, 0, ctrl.Width, ctrl.Height)).Contains(e.X, e.Y))
                {
                    var blbl = ctrl as BindingLabel;
                    if (blbl != null)
                    {
                        blbl.Add(CreateField((string)e.Data.GetData(DataFormats.StringFormat)));
                    }
                }
            }
        }

        public void Init(DataEngine eng)
        {
            this.eng = eng;
            tableLayoutPanel1.SuspendLayout();

            tblFields.SuspendLayout();
            tblFields.Controls.Clear();

            tblFields.RowStyles.Clear();
            tblFields.RowCount = 1;

            for (var i = 0; i < eng.Categories.Count; i++)
            {
                var fl = new FieldLabel(eng.Categories[i]);
                tblFields.Controls.Add(fl, 0, tblFields.RowCount);
                tblFields.RowCount++;
            }

            for (var i = 0; i < eng.Measures.Count; i++)
            {
                var fl = new FieldLabel(eng.Measures[i]);
                tblFields.Controls.Add(fl, 0, tblFields.RowCount);
                tblFields.RowCount++;
            }
            tblFields.ResumeLayout();

            tableLayoutPanel1.ResumeLayout();
        }

        public void InitBindings(FlexChartBase chart)
        {
            tableLayoutPanel1.SuspendLayout();
            tblBindings.SuspendLayout();
            tblBindings.Controls.Clear();

            tblBindings.RowStyles.Clear();
            tblBindings.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tblBindings.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            var fc = chart as FlexChart;
            if (fc != null)
                InitBindings(fc);
            else
            {
                var fp = chart as FlexPie;
                if (fp != null)
                    InitBindings(fp);
            }

            tblBindings.ResumeLayout();
            tableLayoutPanel1.ResumeLayout();
        }

        public event EventHandler BindingsUpdated;

        public Dictionary<string, List<Field>> Bindings
        {
            get { return bindings; }
        }

        void InitBindings(FlexChart chart)
        {
            var blx = new BindingLabel("X-Axis");
            tblBindings.Controls.Add(blx);
            if (chart != null && chart.BindingX != null)
                blx.Add( CreateField(chart.BindingX));
            blx.BindingUpdated += (s, e) => OnBindingsUpdated(this, EventArgs.Empty);

            var bly = new BindingLabel("Y-Axis", true);
            if (chart != null && chart.Series.Count > 0)
            {
                foreach (var ser in chart.Series)
                {
                    var bnds = GetBindings(chart, ser);
                    if(bnds!=null && bnds.Length > 0)
                        bly.Add( CreateField(bnds[0]));
                }
            }
            bly.BindingUpdated += (s, e) => OnBindingsUpdated(this, EventArgs.Empty);
            tblBindings.Controls.Add(bly);

            if (chart.ChartType == C1.Chart.ChartType.Bubble)
            {
                var blsz = new BindingLabel("Size");
                if (chart != null && chart.Series.Count > 0)
                {
                    foreach (var ser in chart.Series)
                    {
                        if (!ser.ChartType.HasValue || ser.ChartType.Value == C1.Chart.ChartType.Bubble)
                        {
                            var bnds = GetBindings(chart, ser);
                            if (bnds != null && bnds.Length > 1)
                            {
                                blsz.Add( CreateField(bnds[1]));
                                break;
                            }
                        }
                    }
                }
                blsz.BindingUpdated += (s, e) => OnBindingsUpdated(this, EventArgs.Empty);
                tblBindings.Controls.Add(blsz);
            }
        }

        string[] GetBindings(FlexChart chart, Series ser)
        {
            var bnd = string.IsNullOrEmpty(ser.Binding) ? chart.Binding : ser.Binding;
            return bnd != null ? bnd.Split(',') : null;
        }

        void InitBindings(FlexPie chart)
        {
            var blx = new BindingLabel("Name");
            tblBindings.Controls.Add(blx);
            if (chart != null && chart.BindingName != null)
                blx.Add( CreateField(chart.BindingName));
            blx.BindingUpdated += (s, e) => OnBindingsUpdated(this, EventArgs.Empty);

            var bly = new BindingLabel("Value", true);
            if (chart != null && !string.IsNullOrEmpty(chart.Binding))
                bly.Add( CreateField(chart.Binding));

            bly.BindingUpdated += (s, e) => OnBindingsUpdated(this, EventArgs.Empty);
            tblBindings.Controls.Add(bly);
        }

        void UpdateBindings()
        {
            Bindings.Clear();

            foreach (BindingLabel bl in tblBindings.Controls)
            {
                Bindings[bl.BindingName] = bl.Fields;
            }
        }

        void OnBindingsUpdated(object sender, EventArgs args)
        {
            UpdateBindings();
            if (BindingsUpdated != null)
                BindingsUpdated(sender, args);
        }

        Field CreateField(string name)
        {
            if (eng != null)
            {
                foreach (var f in eng.Categories)
                {
                    if (f.Name == name)
                        return new Category() { Name = name };
                }

                foreach (var f in eng.Measures)
                {
                    if (f.Name == name)
                        return new Measure() { Name = name, Type = f.Type };
                }
            }

            return new Field() {Name = name };
        }
    }
}
