// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Input;
using System.ComponentModel;

namespace InputDateRange.CustomControl
{
    public partial class C1NumericEditEx : C1NumericEdit
    {
        public C1NumericEditEx()
        {
            InitializeComponent();
            this.ValueChanged += ClampNumericValue;
        }

        private int _minimum = 0;
        private int _maximum = int.MaxValue;
        private bool _maximumExplicitlySet = false;

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

        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = value;
                _maximumExplicitlySet = true;
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
            else if (_maximumExplicitlySet && valueSelected > Maximum)
            {
                this.Value = Maximum;
            }
        }
    }
}
