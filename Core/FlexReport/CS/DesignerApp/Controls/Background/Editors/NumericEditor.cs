//----------------------------------------------------------------------------
// NumericEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using C1.Win.Input;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal enum NumericType
    {
        Decimal,
        Double,
        Float,
        Integer,
    }

    internal class NumericEditor : DropDownEditorBase
    {
        private const int c_DefDecimalPlaces = 2;
        private const decimal c_DefIncrement = 1.0m;
        private const bool c_DefSuppressTrailingZeros = true;
        private const string c_DefFormat = null;
        private static readonly decimal? c_DefMinValue = null;
        private static readonly decimal? c_DefMaxValue = null;
        private const NumericType c_DefNumericType = NumericType.Decimal;

        private decimal _increment = c_DefIncrement;
        private decimal? _minValue = c_DefMinValue;
        private decimal? _maxValue = c_DefMaxValue;
        private int _decimalPlaces = c_DefDecimalPlaces;
        private bool _suppressTrailingZeros = c_DefSuppressTrailingZeros;
        private string _format = c_DefFormat;
        private NumericType _numericType = c_DefNumericType;

        #region Constructors
        public NumericEditor()
        {
            //VisibleButtons = DropDownControlButtonFlags.UpDown;
            //NumericInputKeys = NumericInputKeyFlags.Minus;
            UpdateAllowedChars();
        }
        #endregion

        #region Private
        private void UpdateAllowedChars()
        {
            // update _allowedChars
            m_AllowedChars = "0123456789-";
            if (!IntegerNumber)
            {
                m_AllowedChars += Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                m_AllowedChars += CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator;
            }
        }
        #endregion

        #region Private properties
        private bool IntegerNumber
        {
            get { return _numericType == NumericType.Integer; }
        }
        #endregion

        #region Protected
        #region Serialize methods
        protected virtual bool ShouldSerializeIncrement()
        {
            return _increment != c_DefIncrement;
        }

        protected virtual void ResetIncrement()
        {
            _increment = c_DefIncrement;
        }

        protected virtual bool ShouldSerializeFormat()
        {
            return _format != c_DefFormat;
        }

        protected virtual void ResetFormat()
        {
            _format = c_DefFormat;
        }

        protected virtual bool ShouldSerializeMinValue()
        {
            return _minValue != c_DefMinValue;
        }

        protected virtual void ResetMinValue()
        {
            _minValue = c_DefMinValue;
        }

        protected virtual bool ShouldSerializeMaxValue()
        {
            return _maxValue != c_DefMaxValue;
        }

        protected virtual void ResetMaxValue()
        {
            _maxValue = c_DefMaxValue;
        }
        #endregion

        //protected override CreationTime DropDownFormCreationTime
        //{
        //    get { return CreationTime.OnFirstCall; }
        //}

        protected override bool TextToValue(TextToValueArgs e)
        {
            if (string.IsNullOrEmpty(e.Text))
                return false;

            string s = e.Text;
            if (!string.IsNullOrEmpty(_format))
            {
                foreach (char c in _format.Replace("{0}", string.Empty))
                    s = s.Replace(new string(c, 1), string.Empty);
            }
            decimal v;
            if (!decimal.TryParse(s, out v))
            {
                if (!decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out v))
                    return false;
            }

            //
            if (_minValue.HasValue && v < _minValue.Value)
                e.Value = ToDataTypeValue(_minValue.Value);
            else if (_maxValue.HasValue && v > _maxValue.Value)
                e.Value = ToDataTypeValue(_maxValue.Value);
            else
                e.Value = ToDataTypeValue(ToActualValue(v));
            
            return true;
        }

        protected override void ValueToText(ValueToTextArgs e)
        {
            decimal v = FromActualValue(Utils.AsDecimal(e.Value));
            if (IntegerNumber || _decimalPlaces == 0)
                e.Text = Math.Round(v).ToString();
            else
            {
                if (_decimalPlaces < 0)
                    e.Text = e.Value.ToString();
                else
                    e.Text = Utils.DoubleToString((double)v, _decimalPlaces, _suppressTrailingZeros, e.Target == FormatTarget.ForEdit);
            }

            if (!string.IsNullOrEmpty(_format))
                e.Text = string.Format(_format, e.Text);
        }

        protected virtual decimal FromActualValue(decimal value)
        {
            return value;
        }

        protected virtual decimal ToActualValue(decimal value)
        {
            return value;
        }

        protected object ToDataTypeValue(decimal value)
        {
            switch (_numericType)
            {
                case NumericType.Decimal:
                    return value;
                case NumericType.Double:
                    return (double)value;
                case NumericType.Float:
                    return (float)value;
                case NumericType.Integer:
                    return (int)value;
            }
            throw new ArgumentException();
        }

        protected override void OnUpDownButtonClick(UpDownButtonClickEventArgs e)
        {
            base.OnUpDownButtonClick(e);
            if (e.Handled)
                return;

            var tvi = ParseContent();
            if (tvi == null)
                return;
            decimal numValue;
           if (Utils.IsNumber(tvi))
                numValue = Utils.AsDecimal(tvi);
            else
                return;
            decimal newNumValue;
            if (e.Delta > 0)
                newNumValue = numValue + _increment;
            else
                newNumValue = numValue - _increment;
            if (_minValue.HasValue && newNumValue < _minValue.Value)
                return;
            if (_maxValue.HasValue && newNumValue > _maxValue.Value)
                return;

            bool caught = false;
            try
            {
                SetProposedValue(ToDataTypeValue(newNumValue));
            }
            catch (Exception)
            {
                caught = true;
            }
            if (caught || ParseContent() == null)
            {
                SetProposedValue(tvi);
            }
            else if (RightToLeft == RightToLeft.Yes)
            {
                Select(base.Text.Length, 0);
            }
        }
        void SetProposedValue(object value)
        {
            this.Value = value;
        }

        internal override object GetEditorValue()
        {
            switch (NumericType)
            {
                case Editors.NumericType.Decimal:
                case Editors.NumericType.Double:
                case Editors.NumericType.Integer:
                    return Utils.AsNumber(Value);
                case Editors.NumericType.Float:
                    return (float) Utils.AsNumber(Value);
            }

            return null;
        }
        #endregion

        #region Protected properties
        //protected override string DefaultDropDownFormClassName
        //{
        //    get { return null; }
        //}
        #endregion

        #region Public properties

        [DefaultValue(c_DefNumericType)]
        public NumericType NumericType
        {
            get { return _numericType; }
            set
            {
                if (_numericType == value)
                    return;

                _numericType = value;
                UpdateAllowedChars();
            }
        }

        public decimal Increment
        {
            get { return _increment; }
            set { _increment = value; }
        }

        [DefaultValue(c_DefDecimalPlaces)]
        public int DecimalPlaces
        {
            get { return _decimalPlaces; }
            set { _decimalPlaces = value; }
        }

        [DefaultValue(c_DefSuppressTrailingZeros)]
        public bool SuppressTrailingZeros
        {
            get { return _suppressTrailingZeros; }
            set { _suppressTrailingZeros = value; }
        }

        public string Format
        {
            get { return _format; }
            set { _format = value; }
        }

        public decimal? MinValue
        {
            get { return _minValue; }
            set { _minValue = value; }
        }

        public decimal? MaxValue
        {
            get { return _maxValue; }
            set { _maxValue = value; }
        }
        #endregion
    }
}
