using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Ribbon;

namespace ClickOnceDemo.GcZoomPages.ControlHosts
{
    /// <summary>
    /// The Ribbon element that contains a NumericUpDown.
    /// </summary>
    public class NumericUpDownHost : RibbonControlHost
    {
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
            get { return base.Text; }
            set { base.Text = value; }
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
        private void HandleValueChanged(object sender, EventArgs e)
        {
            this.OnValueChanged(e);
        }

        #endregion
    }
}
