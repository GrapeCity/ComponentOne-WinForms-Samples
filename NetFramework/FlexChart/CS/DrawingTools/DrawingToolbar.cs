using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.Chart;

namespace DrawingTools
{
    class DrawingToolbar
    {
        Options _options;
        ToolStrip _ts;

        ToolStripSplitButton btnEl;
        ToolStripButton btnClear;
        ToolStripButton btnRemove;

        object _selection;
        ToolbarEditor _editor;

        public DrawingToolbar(FlexChart chart, Options options)
        {
            _options = options;
            _options.PropertyChanged += (s, e) => UpdateVisibility();
            CreateToolbar(chart);
        }

        public event EventHandler Clear;
        public event EventHandler Remove;
        public event EventHandler Add;

        public object Selection
        {
            get { return _selection; }
            set
            {
                if (_selection != value)
                {
                    if (_editor != null)
                    {
                        var items = _editor.Items;
                        if (items != null)
                        {
                            foreach (var item in items)
                                _ts.Items.Remove(item);
                        }
                        _editor = null;
                    }
                    _selection = value;
                    if(_selection!=null)
                        _editor = new ToolbarEditor(_selection as IPropertyList);
                    if (_editor != null)
                    {
                        var items = _editor.Items;
                        if (items != null)
                        {
                            int pos = 3;
                            foreach (var item in items)
                                _ts.Items.Insert(pos++, item);
                        }
                    }
                }
            }
        }

        void CreateToolbar(FlexChart chart)
        {
            _ts = new ToolStrip();
            _ts.GripStyle = ToolStripGripStyle.Hidden;

            var btnShow = new ToolStripButton("<");
            btnShow.ToolTipText = "Show/hide toolbar";
            btnShow.Click += (s, e) =>
            {
                if (_ts.Dock == DockStyle.Top)
                {
                    btnShow.Text = ">";
                    _ts.Dock = DockStyle.None;
                    for (var i = 1; i < _ts.Items.Count; i++)
                        _ts.Items[i].Visible = false;
                }
                else
                {
                    btnShow.Text = "<";
                    _ts.Dock = DockStyle.Top;
                    for (var i = 1; i < _ts.Items.Count; i++)
                        _ts.Items[i].Visible = true;
                    UpdateVisibility();
                }
            };
            _ts.Items.Add(btnShow);

            // --
            btnEl = new ToolStripSplitButton();
            foreach (var dt in new DrawingType[] { DrawingType.Marker, DrawingType.Line, DrawingType.Rectangle, DrawingType.Text,
                DrawingType.Ellipse, DrawingType.None, DrawingType.MovingAverage, DrawingType.Fibonacci })
            {
                if (dt == DrawingType.None)
                    btnEl.DropDownItems.Add(new ToolStripSeparator());
                else
                {
                    var item = btnEl.DropDownItems.Add(dt.ToString());
                    item.Image = GetIcon(item.Text.ToLower());
                }
            }
            btnEl.DropDownItemClicked += (s, e) =>
            {
                _options.DrawingType = (DrawingType)Enum.Parse(typeof(DrawingType), e.ClickedItem.Text);
                if (Add != null)
                    Add.Invoke(this, EventArgs.Empty);
            };
            btnEl.Text = "Add";
            btnEl.Image = GetIcon("add");
            AddSplitButton(btnEl);

            _ts.Items.Add(new ToolStripSeparator());

            btnRemove = new ToolStripButton("", GetIcon("remove")) { ToolTipText = "Delete selected drawing" };
            btnRemove.Click += (s, e) =>
            {
                if (Remove != null)
                    Remove.Invoke(this, EventArgs.Empty);
            };
            _ts.Items.Add(btnRemove);

            btnClear = new ToolStripButton("",GetIcon("clear")) { ToolTipText = "Delete all drawings" };
            btnClear.Click += (s, e) =>
            {
                if(Clear!=null)
                    Clear.Invoke(this, EventArgs.Empty);
            };
            _ts.Items.Add(btnClear);

            UpdateVisibility();

            chart.Controls.Add(_ts);
        }

        void AddSplitButton(ToolStripSplitButton btn)
        {
            btn.Click += (s, e) => btn.DropDown.Show();
            _ts.Items.Add(btn);
        }

        void UpdateVisibility()
        {
            btnRemove.Visible = _options.HasSelection;
            btnClear.Visible = _options.HasDrawings;
        }

        Image GetIcon(string name)
        {
            try
            {
            return Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Format("DrawingTools.png.{0}.png", name)));
            }
            catch
            {
                return null;
            }
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class OptionsAttribute : Attribute
    {
        private string options;

        public OptionsAttribute(string options)
        {
            this.options = options;
        }

        public string Options
        {
            get { return options; }
        }
    }

    class ToolbarEditor
    {
        List<ToolStripItem> _items;

        public ToolbarEditor(IPropertyList obj)
        {
            _items = CreateToolstripItems(obj);
        }

        public List<ToolStripItem> Items
        {
            get
            {
                return _items;
            }
        }

        List<ToolStripItem> CreateToolstripItems(IPropertyList obj)
        {
            List<ToolStripItem> list = null;

            if (obj != null)
            {
                var pnames = obj.PropertyNames;
                if (pnames != null)
                {
                    list = new List<ToolStripItem>();
                    list.Add(new ToolStripLabel(obj.ToString() + ":" ) { Font = new Font(Control.DefaultFont, FontStyle.Bold)});

                    foreach (var pname in pnames)
                    {
                        var pi = obj.GetType().GetProperty(pname);
                        if (pi != null)
                        {
                            var item = CreateToolstrpItem(obj, pi);
                            list.Add(item);
                        }
                    }
                    list.Add(new ToolStripSeparator());
                }
            }

            return list;
        }

        ToolStripItem CreateToolstrpItem(object obj, PropertyInfo pi)
        {
            ToolStripItem item = null;

            if (pi.PropertyType == typeof(Color))
            {
                item = CreateColorEditor(obj, pi);
            }
            else if (pi.PropertyType == typeof(string))
            {
                if (pi.GetCustomAttribute<OptionsAttribute>() != null)
                    item = CreateComboBoxEditor(obj, pi);
                else
                    item = CreateTextEditor(obj, pi);

            }
            else if (pi.PropertyType == typeof(int))
            {
                if (pi.GetCustomAttribute<OptionsAttribute>() != null)
                {
                    item = CreateComboBoxEditor(obj, pi);
                }
            }

            return item;
        }

        ToolStripSplitButton CreateColorEditor(object obj, PropertyInfo pi)
        {
            var clrs = new List<Color>() { Color.DarkGray, Color.Red, Color.Green, Color.Blue };

            var oa = pi.GetCustomAttribute<OptionsAttribute>();
            if (oa != null)
            {
                var opts = oa.Options.Split(',');
                clrs = new List<Color>();

                foreach (var o in opts)
                    clrs.Add(Color.FromArgb(int.Parse(o,System.Globalization.NumberStyles.HexNumber)));
            }

            var btn = new ToolStripSplitButton(pi.Name);
            foreach (var clr in clrs)
            {
                var tsi = new ToolStripMenuItem(clr.Name);
                tsi.Tag = clr;
                tsi.Image = CreateBitmap(clr);
                btn.DropDownItems.Add(tsi);
            }
            btn.DropDownItemClicked += (s, e) =>
            {
                btn.Image = e.ClickedItem.Image;
                pi.SetValue(obj, (Color)e.ClickedItem.Tag);
            };
            btn.Click += (s, e) => btn.DropDown.Show();
            btn.Image = CreateBitmap( (Color)pi.GetValue(obj));
            btn.Text = pi.Name;
            return btn;
        }

        ToolStripSplitButton CreateComboBoxEditor(object obj, PropertyInfo pi)
        {
            var btn = new ToolStripSplitButton();
            var opts = pi.GetCustomAttribute<OptionsAttribute>().Options.Split(',');
            //var fnt = new Font("Segoe UI Symbol", 20);
            foreach (var s in  opts)
                btn.DropDownItems.Add(new ToolStripMenuItem(s) { /*Font = fnt*/ });
            btn.DropDownItemClicked += (s, e) =>
            {
                btn.Text = string.Format("{0}: {1}", pi.Name,  e.ClickedItem.Text);
                object val = e.ClickedItem.Text;
                if(pi.PropertyType == typeof(int))
                    val = int.Parse(e.ClickedItem.Text);
                pi.SetValue(obj, val);
            };
            btn.Click += (s, e) => btn.DropDown.Show();
            btn.Text = string.Format("{0}: {1}", pi.Name, pi.GetValue(obj));
            return btn;
        }

        ToolStripTextBox CreateTextEditor(object obj, PropertyInfo pi)
        {
            var tb = new ToolStripTextBox() { Text = pi.GetValue(obj) as string };
            tb.TextChanged += (s, e) => pi.SetValue( obj, tb.Text);
            return tb;
        }

        Bitmap CreateBitmap(Color clr)
        {
            var bmp = new Bitmap(24, 24);
            using (var g = Graphics.FromImage(bmp))
            using (var brush = new SolidBrush(clr))
            {
                g.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
            }

            return bmp;
        }
    }
}
