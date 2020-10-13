using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

using C1.Win.C1Ribbon;

namespace ControlHostLib
{
    /// <summary>
    /// The Ribbon element that contains a NumericUpDown.
    /// </summary>
    public class NumericUpDownHost : RibbonControlHost
    {
        public const string XmlNodeName = "numericUpDownHost";

        //===========================================================================
        #region ** ctor

        /// <summary>
        /// Creates the NumericUpDown control and its host element.
        /// </summary>
        public NumericUpDownHost()
            : base(new NumericUpDown())
        {
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
        /// Gets the hosted NumericUpDown control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public NumericUpDown NumericUpDown
        {
            get { return (NumericUpDown)Control; }
        }

        /// <summary>
        /// Gets or sets the value assigned to the NumericUpDown.
        /// </summary>
        [Category("Data")]
        [Description("Gets or sets the value assigned to the NumericUpDown.")]
        [DefaultValue(0)]
        public decimal Value
        {
            get { return NumericUpDown.Value; }
            set { NumericUpDown.Value = value; }
        }

        /// <summary>
        /// Gets or sets the minimum value for the NumericUpDown.
        /// </summary>
        [Category("Behavior")]
        [Description("Gets or sets the minimum value for the NumericUpDown.")]
        [DefaultValue(0)]
        public decimal Minimum
        {
            get { return NumericUpDown.Minimum; }
            set { NumericUpDown.Minimum = value; }
        }

        /// <summary>
        /// Gets or sets the maximum value for the NumericUpDown.
        /// </summary>
        [Category("Behavior")]
        [Description("Gets or sets the maximum value for the NumericUpDown.")]
        [DefaultValue(100)]
        public decimal Maximum
        {
            get { return NumericUpDown.Maximum; }
            set { NumericUpDown.Maximum = value; }
        }

        /// <summary>
        /// Gets or sets the value to increment or decrement the NumericUpDown when the up or down buttons are clicked.
        /// </summary>
        [Category("Behavior")]
        [Description("Gets or sets the value to increment or decrement the NumericUpDown when the up or down buttons are clicked.")]
        [DefaultValue(1)]
        public decimal Increment
        {
            get { return NumericUpDown.Increment; }
            set { NumericUpDown.Increment = value; }
        }

        /// <summary>
        /// Gets or sets the text that appears on the NumericUpDown.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get { return string.Empty; }
            set { }
        }

        #endregion

        //===========================================================================
        #region ** events

        /// <summary>
        /// Occurs when the <see cref="Value"/> property changes.
        /// </summary>
        [Category("Property Changed")]
        [Description("Occurs when the Value property changes.")]
        public event EventHandler ValueChanged;
        /// <summary>
        /// Raises the <see cref="ValueChanged"/> event.
        /// </summary>
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }

        #endregion

        //===========================================================================
        #region ** methods

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            ((NumericUpDown)control).ValueChanged += new EventHandler(HandleValueChanged);
        }
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            ((NumericUpDown)control).ValueChanged -= new EventHandler(HandleValueChanged);
        }

        void HandleValueChanged(object sender, EventArgs e)
        {
            this.OnValueChanged(e);
        }

        protected override void LoadControlHostProperties(XmlNode node)
        {
            base.LoadControlHostProperties(node);

            Value = Read(node, "value", 0);
            Minimum = Read(node, "minimum", 0);
            Maximum = Read(node, "maximum", 100);
            Increment = Read(node, "increment", 1);
        }

        protected override void SaveControlHostProperties(XmlWriter writer)
        {
            base.SaveControlHostProperties(writer);

            Write(writer, "value", Value, 0);
            Write(writer, "minimum", Minimum, 0);
            Write(writer, "maximum", Maximum, 100);
            Write(writer, "increment", Increment, 1);
        }

        static decimal Read(XmlNode node, string attName, decimal defVal)
        {
            XmlAttribute att = node.Attributes[attName];
            if (att != null)
            {
                return Decimal.Parse(att.Value);
            }
            return defVal;
        }

        static void Write(XmlWriter writer, string attName, decimal value, decimal defVal)
        {
            if (value != defVal)
            {
                writer.WriteAttributeString(attName, value.ToString());
            }
        }

        #endregion
    }
}
