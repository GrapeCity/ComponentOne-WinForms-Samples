using C1.DataCollection;
using C1.DataFilter;
using C1.Win.DataFilter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace CustomFilters
{
    public class ColorFilter : CustomFilter
    {
        private ColorFilterView _colorFilterView;

        public ColorFilter()
        {
            Control = _colorFilterView = new ColorFilterView();
            _colorFilterView.SelectedChanged += (s, e) => OnValueChanged(new ValueChangedEventArgs() { ApplyFilter = true });
        }

        public void SetColors(IEnumerable<Color> colors) => _colorFilterView.SetColors(colors);        

        protected override Expression GetExpression()
        {
            var colors = _colorFilterView.GetSelectedColors();
            var expr = new CombinationExpression() { FilterCombination = FilterCombination.Or };
            foreach(var color in colors)
            {
                expr.Expressions.Add(new OperationExpression() { Value = color, FilterOperation = FilterOperation.Equal, PropertyName = PropertyName });
            }
            return expr;
        }

        protected override void SetExpression(Expression expression)
        {
            
        }

        public override bool IsApplied => _colorFilterView.GetSelectedColors().Count() > 0;
    }

    public class ColorFilterView : UserControl
    {
        public void SetColors(IEnumerable<Color> colors)
        {
            foreach (ColorCheckBox cb in Controls)
                cb.CheckedChanged -= CB_CheckedChanged;
            Controls.Clear();
            foreach(var color in colors)
            {
                var cb = new ColorCheckBox
                {
                    BackColor = color,
                    Text = color.Name
                };
                cb.CheckedChanged += CB_CheckedChanged;
                Controls.Add(cb);
            }
            UpdateLocations();
        }

        public event EventHandler SelectedChanged;

        private void CB_CheckedChanged(object sender, EventArgs e) => SelectedChanged?.Invoke(this, e);        

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateLocations();
        }

        private void UpdateLocations()
        {
            var loc = new Point(10, 10);
            foreach (Control cb in Controls)
            {
                cb.Location = loc;
                var delta = Width - loc.X - (10 + cb.Width) * 2;
                if (delta > 0)
                {
                    loc.X += 10 + cb.Width;
                }
                else
                {
                    loc.X = 10;
                    loc.Y += cb.Height + 10;                    
                }                
            }
            Height = loc.Y + 32;
        }

        public IEnumerable<Color> GetSelectedColors()
        {            
            foreach (ColorCheckBox cb in Controls)
                if (cb.Checked)
                    yield return cb.BackColor;            
        }
    }

    public class ColorCheckBox : CheckBox
    {
        public ColorCheckBox()
        {
            AutoSize = false;
            Size = new Size(32, 32);
            FlatStyle = FlatStyle.Flat;            
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            var g = pevent.Graphics;

            using (var brush = new SolidBrush(Parent.BackColor))
                g.FillRectangle(brush, new Rectangle(Point.Empty, Size));
            
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var brush = new SolidBrush(BackColor))
                g.FillEllipse(brush, new Rectangle(2, 2, Width - 4, Height - 4));

            if (Checked)
            {
                using (var pen = new Pen(Color.White, 3))
                {
                    var p1 = new Point(8, 16);
                    var p2 = new Point(14, 22);
                    var p3 = new Point(24, 10);
                    g.DrawLines(pen, new Point[3] { p1, p2, p3 });
                }
            }
        }
    }
}
