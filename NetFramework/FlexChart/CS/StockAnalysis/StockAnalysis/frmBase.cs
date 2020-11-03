using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;

namespace StockAnalysis
{
    using C1.Chart.Finance;
    using C1.Win.Chart;
    using C1.Win.Chart.Finance;

    [Serializable()]
    public partial class frmBase : Form
    {
        protected Point nextControl = new Point(20, 35);
        protected PropertyInfo[] formProperties = null;
        protected bool doNotLoadOrSave = false;

        public frmBase()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Icon = ImageManager.GetC1LogoIcon();
        }

        public static frmBase CreateForm(string name)
        {
            frmBase frm = Assembly.GetExecutingAssembly().CreateInstance(typeof(frmBase).Namespace + ".frm" + name) as frmBase;
            return frm;
        }

        public static void InitMasterSettingData()
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in types)
            {
                if (type.IsSubclassOf(typeof(frmBase)))
                {
                    using (frmBase frm = Assembly.GetExecutingAssembly().CreateInstance(type.FullName) as frmBase)
                    {
                        if (!frm.doNotLoadOrSave) frm.SaveData();
                    }
                }
            }
        }

        public virtual void BuildForm()
        {
            PropertyInfo[] props = formProperties;
            if (props != null && props.Length > 0)
            {
                for (int p = 0; p < props.Length; p++)
                {
                    addInputFields(props[p]);
                    if (props[p].Name == "OverBought" || props[p].Name == "OverSold" || props[p].Name == "Threshold")
                    {
                        addInputField2(props[++p]);
                    }
                }
            }
        }

        public virtual void SetTargetObject(object o)
        {
            foreach (PropertyInfo pi in formProperties)
            {
                PropertyInfo pio = o.GetType().GetProperty(pi.Name);
                if (pio != null && pio.PropertyType == pi.PropertyType)
                {
                    pio.SetValue(o, pi.GetValue(this, null), null);
                }
            }
        }

        public static void SetChartOptions(FinancialChart chart)
        {
            FinancialChartType finType = chart.ChartType;
            if (finType == FinancialChartType.Kagi || finType == FinancialChartType.Renko || finType == FinancialChartType.PointAndFigure)
            {
                string frmName = typeof(frmBase).Namespace + ".frm" + finType.ToString();
                using (frmBase frm = Assembly.GetExecutingAssembly().CreateInstance(frmName) as frmBase)
                {
                    FinancialChartOptions fco = chart.Options;
                    frm.SetTargetObject(fco);
                }
            }
        }

        protected virtual void SetSeriesOvers(FinancialChart chart, FinancialSeries primary,
            double overBoughtValue, Color overBoughtColor, double overSoldValue, Color overSoldColor, bool showZones)
        {
            FinancialSeries serOverBought = chart.Series.FirstOrDefault(p => p.Name == primary.Name + "OverBought") as FinancialSeries;
            FinancialSeries serOverSold = chart.Series.FirstOrDefault(p => p.Name == primary.Name + "OverSold") as FinancialSeries;

            if (serOverBought == null || serOverSold == null)
            {
                serOverBought = new FinancialSeries()
                    { ChartType = FinancialChartType.Line, Name = primary.Name + "OverBought", Binding = "Y" };
                serOverSold = new FinancialSeries()
                    { ChartType = FinancialChartType.Line, Name = primary.Name + "OverSold", Binding = "X" };
                serOverSold.AxisY = serOverBought.AxisY = primary.AxisY;
                serOverSold.Style.StrokeWidth = serOverBought.Style.StrokeWidth = 1;
                chart.Series.Add(serOverBought);
                chart.Series.Add(serOverSold);
            }

            serOverBought.Style.StrokeColor = overBoughtColor;
            serOverSold.Style.StrokeColor = overSoldColor;

            serOverBought.Visibility = serOverSold.Visibility = 
                showZones ? C1.Chart.SeriesVisibility.Plot : C1.Chart.SeriesVisibility.Hidden;

            if (showZones)
            {
                PointF[] pts = new PointF[primary.GetCount()];
                pts = pts.Select((p) => p = new PointF((float)overSoldValue, (float)overBoughtValue)).ToArray();
                serOverSold.DataSource = serOverBought.DataSource = pts;
            }
        }

        public virtual void SetSeriesData(FinancialChart chart)
        {
        }

        public virtual void SetSeriesData(FinancialChart chart, object obj)
        {
        }

        private void btnOkCancel_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            Rectangle r = new Rectangle(new Point(btn.ClientSize.Width / 5, btn.ClientSize.Height / 5),
                new Size(3 * btn.ClientSize.Width / 5, 3 * btn.ClientSize.Height / 5));

            Color penColor = Color.Empty;
            Point[] pts = null;
            Point[] pts2 = null;

            if (btn.Name == "btnOK")
            {
                penColor = Color.Green;
                pts = new Point[] { new Point(8, 11), new Point(14, 17), new Point(22, 8), };
            }
            else
            {
                penColor = Color.Red;
                pts = new Point[] { new Point(10, 6), new Point(21, 17), };
                pts2 = new Point[] { new Point(21, 6), new Point(10, 17), };
            }

            using (Pen pen = new Pen(penColor, 3f))
            {
                pen.StartCap = pen.EndCap = LineCap.Round;
                SmoothingMode smSave = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawLines(pen, pts);
                if (pts2 != null) e.Graphics.DrawLines(pen, pts2);

                if (smSave != SmoothingMode.AntiAlias)
                    e.Graphics.SmoothingMode = smSave;
            }
        }

        static Dictionary<string, Dictionary<string, object>> masterDictionary =
            new Dictionary<string, Dictionary<string, object>>();

        protected bool IsKeyed
        {
            get { return masterDictionary.ContainsKey(this.GetType().Name); }
        }

        private void SaveData()
        {
            if (formProperties == null)
                return;

            Dictionary<string, object> storage = null;
            string key = GetType().Name;
            if (masterDictionary.ContainsKey(key))
                storage = masterDictionary[key];
            else
            {
                storage = new Dictionary<string, object>();
                masterDictionary.Add(key, storage);
            }

            foreach (PropertyInfo pi in formProperties)
            {
                object o = pi.GetValue(this, null);
                if (storage.ContainsKey(pi.Name))
                    storage[pi.Name] = o;
                else
                    storage.Add(pi.Name, o);
            }
        }

        private void LoadData()
        {
            Dictionary<string, object> storage = null;
            string key = GetType().Name;
            if (masterDictionary.ContainsKey(key))
                storage = masterDictionary[key];

            if (storage == null) return;

            foreach (PropertyInfo pi in formProperties)
            {
                if (storage.ContainsKey(pi.Name))
                {
                    pi.SetValue(this, storage[pi.Name], null);
                }
            }
        }

        protected virtual void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        protected virtual void InitializeFormProperties(Type type)
        {
            // only get top level properties, not inheritted properties, and only properties
            // for which there are both get and set accessors
            this.formProperties = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            this.formProperties = this.formProperties.Where(pi => pi.GetSetMethod() != null).ToArray();
            if(!doNotLoadOrSave) LoadData();
        }

        protected string getDisplayName(PropertyInfo pi)
        {
            string displayName = pi.Name;
            DisplayNameAttribute[] dna = pi.GetCustomAttributes(typeof(DisplayNameAttribute), false) as DisplayNameAttribute[];
            if (dna != null && dna.Length > 0)
                displayName = dna[0].DisplayName;
            return displayName;
        }

        protected const int lineHeight = 19;
        protected int lineCenter = 0;
        protected int lastXPosition = 0;

        protected virtual void addInputField2(PropertyInfo pi)
        {
            string name = getDisplayName(pi);

            if (pi.PropertyType == typeof(Color))
            {
                Button b = new Button();
                b.Name = "btn" + pi.Name;
                b.Text = null;
                b.BackColor = (Color)pi.GetValue(this, null);
                b.Size = new Size(lineHeight, 6 * lineHeight / 7);
                b.Location = new Point(lastXPosition - b.Size.Width - nextControl.X, lineCenter - b.Size.Height / 2);
                lastXPosition = b.Location.X;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderColor = Color.LightGray;
                b.Padding = b.Margin = new System.Windows.Forms.Padding(0);
                b.Click += (sender, e) =>
                {
                    Button bs = sender as Button;
                    Point cdePosition = new Point(this.Left + Width / 2 - 105, this.Top + Height / 2 - 171);
                    ColorDialogEx cde = new ColorDialogEx(cdePosition.X, cdePosition.Y, "Select " + name + " Color");
                    cde.SolidColorOnly = false;
                    cde.Color = bs.BackColor;
                    if (cde.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        b.BackColor = cde.Color;
                        pi.SetValue(this, cde.Color, null);
                    }
                };
                this.Controls.Add(b);
            }
            else if (pi.PropertyType == typeof(bool))
            {
                CheckBox cb = new CheckBox();
                cb.Name = "chk" + pi.Name;
                cb.Text = null;
                cb.Checked = (bool)pi.GetValue(this, null);
                cb.Size = new Size(lineHeight, 6 * lineHeight / 7);
                cb.Location = new Point(lastXPosition - cb.Size.Width - nextControl.X + 7, lineCenter - cb.Size.Height / 2);
                lastXPosition = cb.Location.X;
                cb.FlatStyle = FlatStyle.Flat;
                cb.CheckedChanged += (sender, e) => { pi.SetValue(this, cb.Checked, null); };
                this.Controls.Add(cb);
            }
            else if (pi.PropertyType.IsEnum)
            {
                ComboBox cb = new ComboBox();
                cb.Name = "cbo" + pi.Name;
                cb.Items.AddRange(Enum.GetNames(pi.PropertyType));
                cb.Size = new Size(100, 6 * lineHeight / 7);
                cb.Location = new Point(lastXPosition - cb.Size.Width - nextControl.X, lineCenter - cb.Size.Height / 2);
                lastXPosition = cb.Location.X;
                cb.FlatStyle = FlatStyle.Flat;
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.DrawMode = DrawMode.OwnerDrawFixed;
                cb.DrawItem += (sender, e) =>
                {
                    string item = cb.Items[e.Index] as string;
                    SizeF sz = e.Graphics.MeasureString(item, cb.Font);
                    Brush backBrush = (e.State.HasFlag(DrawItemState.Selected) && cb.DroppedDown)
                        ? Brushes.LightGray : Brushes.White;
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawString(item, cb.Font, Brushes.Black,
                        new PointF(e.Bounds.Right - sz.Width - 2, e.Bounds.Y));
                };
                cb.SelectedItem = Enum.GetName(pi.PropertyType, pi.GetValue(this, null));
                cb.SelectedValueChanged += (sender, e) =>
                { pi.SetValue(this, Enum.Parse(pi.PropertyType, cb.SelectedItem as string, false), null); };
                this.Controls.Add(cb);
            }
            else
            {
                TextBox tb = new TextBox();
                tb.Name = "txt" + pi.Name;
                tb.Text = pi.GetValue(this, null).ToString();
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.TextAlign = (pi.PropertyType == typeof(int) || pi.PropertyType == typeof(uint) || pi.PropertyType == typeof(double))
                    ? HorizontalAlignment.Right : HorizontalAlignment.Left;
                tb.Size = new Size(40, lineHeight);
                tb.Location = new Point(lastXPosition - tb.Size.Width - nextControl.X, lineCenter - tb.Size.Height / 2);
                lastXPosition = tb.Location.X;
                tb.Validating += (sender, e) =>
                {
                    e.Cancel = !this.ValidateProperty(pi.Name, pi.GetValue(this, null));
                };
                tb.TextChanged += (sender, e) =>
                {
                    string s = tb.Text;
                    if (!string.IsNullOrWhiteSpace(s) || s == "-" || s == "+")
                    {
                        if (pi.PropertyType == typeof(uint))
                        {
                            uint res = 0;
                            if (uint.TryParse(s, out res))
                                pi.SetValue(this, res, null);
                            else
                            {
                                MessageBox.Show("Unassigned integer value required.", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (pi.PropertyType == typeof(int))
                        {
                            int res = 0;
                            if (int.TryParse(s, out res))
                                pi.SetValue(this, res, null);
                            else
                            {
                                MessageBox.Show("Integer value required.", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (pi.PropertyType == typeof(double))
                        {
                            double res = 0.0;
                            if (double.TryParse(s, out res))
                                pi.SetValue(this, res, null);
                            else
                            {
                                MessageBox.Show("Double value required.", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (pi.PropertyType == typeof(string))
                        {
                            pi.SetValue(this, tb.Text, null);
                        }
                    }
                };
                this.Controls.Add(tb);
            }
        }

        protected virtual void addInputFields(PropertyInfo pi)
        {
            string name = getDisplayName(pi);

            int startY = nextControl.Y;
            lineCenter = 0;
            lastXPosition = this.ClientSize.Width;

            Label lab = new Label();
            lab.Name = "lab" + pi.Name;
            lab.Text = name + ":";
            lab.Location = nextControl;
            lab.Height = lineHeight;
            lab.TextAlign = ContentAlignment.MiddleLeft;
            lab.AutoSize = true;
            lineCenter = nextControl.Y + lineHeight / 2;
            this.Controls.Add(lab);

            addInputField2(pi);

            nextControl.Y += lineHeight * 7 / 4;

            Panel panel = new Panel();
            panel.Size = new Size(this.ClientSize.Width - nextControl.X - nextControl.X, 1);
            panel.Location = nextControl;
            panel.BackColor = Color.LightGray;

            this.Controls.Add(panel);

            nextControl.Y += lineHeight * 3 / 4;

            this.Size = new Size(this.Size.Width, this.Size.Height + nextControl.Y - startY);
        }

        protected virtual bool ValidateProperty(string propertyName, object value)
        {
            // handle some validation implicitly for all forms.
            bool result = true;
            string message = null;

            string triggerName = propertyName;
            if (triggerName.EndsWith("Period"))
                triggerName = "Period";

            switch (triggerName)
            {
                case "Period":
                    if (!(value is int) || (int)value < 1)
                    {
                        message = "Value must be >= 1";
                        result = false;
                    }
                    break;

                case "OverBought":
                case "OverSold":
                    if (!(value is int) || (int)value > 100 || (int)value < -100)
                    {
                        message = "Value must be -100 >= value >= 100";
                        result = false;
                    }
                    break;
            }
            if(!result && message != null)
                MessageBox.Show(message, propertyName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return result;
        }

        protected virtual string[] getFontValues(string name)
        {
            string[] values = null;

            if (name == "FontFamily")
            {
                FontFamily[] ffa = System.Drawing.FontFamily.Families.
                    Where(s => s.IsStyleAvailable(FontStyle.Regular) && s.IsStyleAvailable(FontStyle.Bold)).ToArray();

                values = ffa.Select(ff => ff.Name).ToArray();
            }
            else if (name == "FontSize")
            {
                List<float> ffs = new List<float>(new float[] { 8f, 9f, 10f, 12f, 14f, 16f, 20f, 24f, 32f, 64f });
                values = ffs.Select(fso => fso.ToString()).ToArray() as string[];
            }
            else if (name == "FontWeight")
            {
                values = new string[] { "Regular", "Bold" };
            }
            return values;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if(!e.Cancel && DialogResult == System.Windows.Forms.DialogResult.OK)
                SaveData();
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
    }

    public class ColorDialogEx : ColorDialog
    {
        private const Int32 WM_INITDIALOG = 0x0110;

        //uFlag Constants
        private const uint SWP_NOSIZE = 0x0001, SWP_SHOWWINDOW = 0x0040, SWP_NOZORDER = 0x0004;
        private const uint UFLAGS = SWP_NOSIZE | SWP_NOZORDER | SWP_SHOWWINDOW;

        //Windows Handle Constants
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private static readonly IntPtr HWND_TOP = new IntPtr(0);
        private static readonly IntPtr HWND_BOTTOM = new IntPtr(1);

        //Module vars
        private int _x;
        private int _y;
        private string _title = null;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool SetWindowText(IntPtr hWnd, string text);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        public ColorDialogEx(int x, int y, String title = null)
        {
            _x = x;
            _y = y;
            _title = title;
        }

        protected override IntPtr HookProc(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam)
        {
            IntPtr hookProc = base.HookProc(hWnd, msg, wparam, lparam);
            if (msg == WM_INITDIALOG)
            {
                if (!String.IsNullOrEmpty(_title))
                    SetWindowText(hWnd, _title);

                SetWindowPos(hWnd, HWND_TOP, _x, _y, 0, 0, UFLAGS);
            }
            return hookProc;
        }
    }
}
