using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using C1.Win.C1InputPanel;

namespace ControlExplorer
{
    public class PropertyList: C1InputPanel
    {
        private static int unitHeight = 26;
        private static int labelWidth = 92;
        public PropertyList(ArrayList properties)
        {
            this.ChildSpacing = new Size(2, 2);
            this.Margin = new Padding(0);
            this.Padding = new Padding(0);
            this.SuspendLayout();

            for (int i = 0; i < properties.Count; i++)
            {
                Association a = properties[i] as Association;
                
                if (a == null)
                {
                    string s = properties[i] as string;
                    if (s.ToLower().Equals("separator"))
                    {
                        InputSeparator sep = new InputSeparator();
                        this.Items.Add(sep);
                    }
                    else if (s.ToLower().Equals("colbreak"))
                    {
                        this.Items[this.Items.Count - 1].Break = BreakType.Column;
                    }
                    else
                    {
                        InputGroupHeader gh = new InputGroupHeader();
                        gh.Text = s;
                        gh.Height = unitHeight;
                        gh.BackColor = Color.Transparent;
                        this.Items.Add(gh);
                    }
                }
                else if (a.Descriptor.PropertyType == Type.GetType("System.Boolean"))
                {
                    InputCheckBox chk = new InputCheckBox();
                    chk.Height = unitHeight;
                    chk.Checked = (bool)a.Value;
                    chk.Tag = a;
                    if (string.IsNullOrEmpty(a.LongName))
                        chk.Text = a.Descriptor.Name + " ";
                    else
                        chk.Text = a.LongName + " ";
                    chk.CheckedChanged += new EventHandler(chk_CheckedChanged);
                    this.Items.Add(chk);
                }
                else
                {
                    InputLabel lab = new InputLabel();
                    lab.VerticalAlign = InputContentAlignment.Center;
                    lab.Height = unitHeight;
                    lab.Width = labelWidth;
                    if (string.IsNullOrEmpty(a.LongName))
                        lab.Text = a.Descriptor.Name;
                    else
                        lab.Text = a.LongName;
                    this.Items.Add(lab);
                    if (a.Descriptor.PropertyType.IsEnum)
                    {
                        InputComboBox box = new InputComboBox();
                        box.Height = unitHeight;
                        box.DropDownStyle = InputComboBoxStyle.DropDownList;
                        BindingFlags flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly;
                        FieldInfo[] fields = a.Descriptor.PropertyType.GetFields(flags);
                        box.Tag = a;
                        box.Text = a.Value.ToString();
                        box.SelectedIndexChanged += new EventHandler(box_SelectedIndexChanged);
                        for(int f = 0; f < fields.Length; f ++)
                        {
                            var field = fields[f];
                            if (a.AllowedValues == null || a.AllowedValues.Contains(field.Name))
                            {
                                InputOption ic = new InputOption();
                                ic.Text = field.GetValue(field).ToString();
                                ic.Tag = field;
                                box.Items.Add(ic);
                            }
                        }
                        this.Items.Add(box);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.DateTime"))
                    {
                        InputDatePicker dp = new InputDatePicker();
                        dp.Height = unitHeight;
                        dp.Value = (DateTime)a.Value;
                        dp.Tag = a;
                        dp.LostFocus += new EventHandler(date_LostFocus);
                        this.Items.Add(dp);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.TimeSpan"))
                    {
                        InputTimePicker tp = new InputTimePicker();
                        tp.Height = unitHeight;
                        tp.Value = (TimeSpan)a.Value;
                        tp.Tag = a;
                        tp.LostFocus += new EventHandler(time_LostFocus);
                        this.Items.Add(tp);
                    }
                    else if (a.Descriptor.PropertyType.ToString().Equals("System.Drawing.Color"))
                    {
                        ColorEditorHost ce = new ColorEditorHost();
                        ce.Height = unitHeight;
                        ce.Width = 102;
                        ce.SelectedColor = (System.Drawing.Color)a.Value;
                        ce.Tag = a;
                        ce.LostFocus += new EventHandler(color_LostFocus);
                        this.Items.Add(ce);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.Int32"))
                    {
                        InputNumericBox nb = new InputNumericBox();
                        nb.Height = unitHeight;
                        nb.Width = 50;
                        nb.Value = (int)a.Value;
                        nb.Tag = a;
                        nb.Maximum = 100000;
                        nb.ValueChanged += new EventHandler(nb_ValueChanged);
                        this.Items.Add(nb);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.Int16"))
                    {
                        InputNumericBox nb = new InputNumericBox();
                        nb.Height = unitHeight;
                        nb.Width = 50;
                        nb.Value = (short)a.Value;
                        nb.Tag = a;
                        nb.Maximum = 100000;
                        nb.ValueChanged += new EventHandler(nb_ValueChanged);
                        this.Items.Add(nb);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.Int64"))
                    {
                        InputNumericBox nb = new InputNumericBox();
                        nb.Value = (long)a.Value;
                        nb.Tag = a;
                        nb.Maximum = 100000;
                        nb.Height = unitHeight;
                        nb.Width = 50;
                        nb.ValueChanged += new EventHandler(nb_ValueChanged);
                        this.Items.Add(nb);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.Single") || a.Descriptor.PropertyType == Type.GetType("System.Double"))
                    {
                        InputNumericBox nb = new InputNumericBox();
                        nb.Value = (decimal)Math.Floor((Single)a.Value);
                        nb.Tag = a;
                        nb.Maximum = 360;
                        nb.Minimum = 0;
                        nb.Height = unitHeight;
                        nb.Width = 50;
                        nb.ValueChanged += new EventHandler(nb_ValueChanged);
                        this.Items.Add(nb);
                    }
                    else
                    {
                        InputTextBox txt = new InputTextBox();
                        txt.VerticalAlign = InputContentAlignment.Center;
                        txt.Height = unitHeight;
                        txt.Text = a.Value.ToString();
                        txt.Tag = a;
                        txt.LostFocus += new EventHandler(txt_LostFocus);
                        this.Items.Add(txt);
                    }
                }
            }

            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout();
        }

        public void UpdatePropertiesFromTheme()
        {
            foreach (var item in this.Items)
            {
                var colorPicker = item as ColorEditorHost;
                if ( colorPicker != null)
                {
                    colorPicker.SelectedColor = (System.Drawing.Color)((Association)colorPicker.Tag).Value;
                }
            }
        }

        public Image BackImage
        {
            get { return this.BackgroundImage; }
            set { this.BackgroundImage = value; }
        }

     /*   public int CalculateHeight(PropertyList pl)
        {
            int count = 0;
            int maxcount = 0;
            int solidcount = 0;
            foreach (InputComponent ic in pl.Items)
            {
                if (ic.GetType() != typeof(InputLabel) && ic.GetType() != typeof(InputGroupHeader))
                    count += 1;

                if (ic.GetType() == typeof(InputGroupHeader))
                    solidcount += 1;

                if (ic.Break == BreakType.Column)
                {
                    if(count > maxcount) maxcount = count;
                    count = 0;
                }
            }
            if (count > maxcount) maxcount = count;

            return ((maxcount + solidcount) * (unitHeight + 2)) + (8 * (solidcount + 1));
        }*/

        void chk_CheckedChanged(object sender, EventArgs e)
        {
           InputCheckBox chk = sender as InputCheckBox;

            if (chk != null)
            {
                Association a = chk.Tag as Association;
                a.Value = chk.Checked;
            }
        }

        void box_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputComboBox box = sender as InputComboBox;
            
            if (box != null)
            {
                InputOption io = box.SelectedOption;
                Association a = box.Tag as Association;
                FieldInfo info = io.Tag as FieldInfo;

                if (info != null)
                    a.Value = info.GetRawConstantValue();
            }
        }

        void txt_LostFocus(object sender, EventArgs e)
        {
            InputTextBox txt = sender as InputTextBox;

            if (txt != null)
            {
                Association a = txt.Tag as Association;
                a.Value = txt.Text;
            }
        }
        void date_LostFocus(object sender, EventArgs e)
        {
            InputDatePicker dp = sender as InputDatePicker;

            if (dp != null)
            {
                Association a = dp.Tag as Association;
                a.Value = dp.Value;
            }
        }
        void time_LostFocus(object sender, EventArgs e)
        {
            InputTimePicker tp = sender as InputTimePicker;

            if (tp != null)
            {
                Association a = tp.Tag as Association;
                a.Value = tp.Value;
            }
        }
        void color_LostFocus(object sender, EventArgs e)
        {
            ColorEditorHost ce = sender as ColorEditorHost;
            if (ce != null)
            {
                Association a = ce.Tag as Association;
                a.Value = ce.SelectedColor;
            }
        }
        void nb_ValueChanged(object sender, EventArgs e)
        {
            InputNumericBox nb = sender as InputNumericBox;

            if (nb != null)
            {
                Association a = nb.Tag as Association;
                a.Value = nb.Value;
            }
        }
    }

    public class Association
    {
        private PropertyDescriptor _pd;
        private object _target;
        private string _longName;

        public Association(PropertyDescriptor pd, object target)
        {
            //Debug.Assert(pd != null);
            //Debug.Assert(target != null);
            _pd = pd;
            _target = target;
            _longName = "";
        }

        public Association(PropertyDescriptor pd, object target, string longName)
        {
            _pd = pd;
            _target = target;
            _longName = longName;
        }

        public PropertyDescriptor Descriptor
        {
            get { return _pd; }
        }

        public object Target
        {
            get { return _target; }
        }

        public string LongName
        {
            get { return _longName; }
        }

        public object Value
        {
            get { return _pd.GetValue(_target); }
            set
            {
                try
                {
                    _pd.SetValue(_target, System.Convert.ChangeType(value, _pd.PropertyType));
                    return;
                }
                catch
                {
                }
                try
                {
                    _pd.SetValue(_target, value);
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Gets or sets names of enum values which are allowed to use.
        /// </summary>
        [DefaultValue(null)]
        public List<string> AllowedValues { get; set; }
    }

    /// <summary>
    /// The host component for the ColorEditorControl on an input panel.
    /// </summary>
    [DefaultEvent("SelectedColorChanged")]
    public class ColorEditorHost : InputControlHost
    {
        public const string XmlNodeName = "colorEditor";

        //===========================================================================
        #region ** ctor

        public ColorEditorHost()
            : base(new C1.Win.C1Input.C1ColorPicker())
        {
            var picker = ColorPicker;
            picker.ShowModalButton = false;
        }

        #endregion

        //===========================================================================
        #region ** properties

        /// <inheritdoc />
        public override string ControlHostNodeName
        {
            get { return XmlNodeName; }
        }

        /// <summary>
        /// Gets the hosted color editor control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1.Win.C1Input.C1ColorPicker ColorPicker
        {
            get { return (C1.Win.C1Input.C1ColorPicker)Control; }
        }

        /// <summary>
        /// Gets or sets the selected color.
        /// </summary>
        [Category("Data")]
        [Description("Gets or sets the selected color.")]
        public Color SelectedColor
        {
            get { return ColorPicker.Color; }
            set { ColorPicker.Color = value; }
        }
        private bool ShouldSerializeSelectedColor()
        {
            return SelectedColor != Color.Empty;
        }
        private void ResetSelectedColor()
        {
            SelectedColor = Color.Empty;
        }

        #endregion

        //===========================================================================
        #region ** events

        /// <summary>
        /// Fires when the <see cref="SelectedColor"/> property is changed.
        /// </summary>
        [Category("Property Changed")]
        [Description("Fires when the value of the SelectedColor property changes.")]
        public event EventHandler SelectedColorChanged;
        /// <summary>
        /// Raises the <see cref="SelectedColorChanged"/> event.
        /// </summary>
        protected virtual void OnSelectedColorChanged(EventArgs e)
        {
            if (SelectedColorChanged != null)
                SelectedColorChanged(this, e);
        }

        #endregion

        //===========================================================================
        #region ** methods

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            ColorPicker.ColorChanged += new EventHandler(HandleSelectedColorChanged);
        }
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            ColorPicker.ColorChanged -= new EventHandler(HandleSelectedColorChanged);
        }
        private void HandleSelectedColorChanged(object sender, EventArgs e)
        {
            this.OnSelectedColorChanged(e);
        }

        #endregion
    }
}
