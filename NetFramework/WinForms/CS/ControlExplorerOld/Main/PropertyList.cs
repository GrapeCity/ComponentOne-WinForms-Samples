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
        private int unitHeight = 25;
        private int leftPadding = 2;
        public PropertyList(ArrayList properties)
        {
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
                    chk.Padding = new Padding(leftPadding, 2, 0, 0);
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
                    lab.Padding = new Padding(leftPadding, 7, 0, 0);
                    lab.Height = unitHeight;
                    if (string.IsNullOrEmpty(a.LongName))
                        lab.Text = a.Descriptor.Name;
                    else
                        lab.Text = a.LongName;
                    this.Items.Add(lab);
                    if (a.Descriptor.PropertyType.IsEnum)
                    {
                        InputComboBox box = new InputComboBox();
                        //box.Padding = new Padding(5, 0, 0, 0);
                        box.Height = unitHeight;
                        box.DropDownStyle = InputComboBoxStyle.DropDownList;
                        BindingFlags flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly;
                        FieldInfo[] fields = a.Descriptor.PropertyType.GetFields(flags);
                        box.Tag = a;
                        box.Text = a.Value.ToString();
                        box.SelectedIndexChanged += new EventHandler(box_SelectedIndexChanged);
                        for(int f = 0; f < fields.Length; f ++)
                        {
                            InputOption ic = new InputOption();
                            ic.Text = fields[f].GetValue(fields[f]).ToString();
                            ic.Tag = fields[f];
                            box.Items.Add(ic);
                        }
                        this.Items.Add(box);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.DateTime"))
                    {
                        InputDatePicker dp = new InputDatePicker();
                        //dp.Padding = new Padding(5, 2, 0, 0);
                        dp.Height = unitHeight;
                        dp.Value = (DateTime)a.Value;
                        dp.Tag = a;
                        dp.LostFocus += new EventHandler(date_LostFocus);
                        this.Items.Add(dp);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.TimeSpan"))
                    {
                        InputTimePicker tp = new InputTimePicker();
                        //tp.Padding = new Padding(5, 2, 0, 0);
                        tp.Height = unitHeight;
                        tp.Value = (TimeSpan)a.Value;
                        tp.Tag = a;
                        tp.LostFocus += new EventHandler(time_LostFocus);
                        this.Items.Add(tp);
                    }
                    else if (a.Descriptor.PropertyType.ToString().Equals("System.Drawing.Color"))
                    {
                        //had to remove ColorEditor due to ClientProfile
                        //InputPanel.ControlHosts.ColorEditorHost ce = new InputPanel.ControlHosts.ColorEditorHost();
                        ////ce.Padding = new Padding(5, 2, 0, 0);
                        //ce.Height = unitHeight;
                        //ce.SelectedColor = (System.Drawing.Color)a.Value;
                        //ce.Tag = a;
                        //ce.LostFocus += new EventHandler(color_LostFocus);
                        //this.Items.Add(ce);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.Int32"))
                    {
                        InputNumericBox nb = new InputNumericBox();
                        nb.Height = unitHeight - 5;
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
                        nb.Padding = new Padding(5, 0, 0, 0);
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
                        nb.Padding = new Padding(5, 0, 0, 0);
                        nb.Value = (long)a.Value;
                        nb.Tag = a;
                        nb.Maximum = 100000;
                        nb.Height = unitHeight - 5;
                        nb.Width = 50;
                        nb.ValueChanged += new EventHandler(nb_ValueChanged);
                        this.Items.Add(nb);
                    }
                    else if (a.Descriptor.PropertyType == Type.GetType("System.Single") || a.Descriptor.PropertyType == Type.GetType("System.Double"))
                    {
                        InputNumericBox nb = new InputNumericBox();
                        nb.Padding = new Padding(5, 0, 0, 0);
                        nb.Value = (decimal)Math.Floor((Single)a.Value);
                        nb.Tag = a;
                        nb.Maximum = 360;
                        nb.Minimum = 0;
                        nb.Height = unitHeight - 5;
                        nb.Width = 50;
                        nb.ValueChanged += new EventHandler(nb_ValueChanged);
                        this.Items.Add(nb);
                    }
                    else
                    {
                        InputTextBox txt = new InputTextBox();
                        txt.Padding = new Padding(5, 2, 0, 0);
                        txt.Height = unitHeight - 5;
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

        public Image BackImage
        {
            get { return this.BackgroundImage; }
            set { this.BackgroundImage = value; }
        }

        public int CalculateHeight(PropertyList pl)
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
        }

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
            //InputPanel.ControlHosts.ColorEditorHost ce = sender as InputPanel.ControlHosts.ColorEditorHost;

            //if (ce != null)
            //{
            //    Association a = ce.Tag as Association;
            //    a.Value = ce.SelectedColor;
            //}
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
    }
}
