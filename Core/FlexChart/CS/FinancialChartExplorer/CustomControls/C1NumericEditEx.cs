using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.Input;

namespace FinancialChartExplorer.CustomControls
{
    public partial class C1NumericEditEx : C1NumericEdit
    {
        public C1NumericEditEx()
        {
            InitializeComponent();
            this.ValueChanged += ClampNumericValue;
        }

        private int _minimum = 0;
        private int _maximum = 100;

        [DefaultValue(0)]
        public int Minimum
        {
            get => _minimum;
            set
            {
                _minimum = value;
                ClampNumericValue(this, EventArgs.Empty); 
            }
        }

        [DefaultValue(100)]
        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = value;
                ClampNumericValue(this, EventArgs.Empty);
            }
        }

        private void ClampNumericValue(object sender, EventArgs e)
        {
            if (this.Value == null || this.Value is DBNull)
            {
                return;
            }

            int valueSelected;
            try
            {
                valueSelected = Convert.ToInt32(this.Value);
            }
            catch (InvalidCastException)
            {
                return;
            }

            if (valueSelected < Minimum)
            {
                this.Value = Minimum;
            }
            else if (valueSelected > Maximum)
            {
                this.Value = Maximum;
            }
        }
    }
}
