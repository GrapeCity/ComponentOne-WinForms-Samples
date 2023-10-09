//----------------------------------------------------------------------------
// PercentEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.ComponentModel;
using C1.Win.Input;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal class PercentEditor : NumericEditor
    {
        private const string c_DefFormat = "{0}%";
        private const decimal c_DefIncrement = 0.01m;

        #region Constructors
        public PercentEditor()
        {
            //VisibleButtons = DropDownControlButtonFlags.UpDown;
            Format = c_DefFormat;
            NumericType = NumericType.Double;
            Increment = c_DefIncrement;
            MinValue = 0.0m;
            MaxValue = 1.0m;
        }
        #endregion

        #region Protected
        #region Serialize methods
        protected override bool ShouldSerializeIncrement()
        {
            return Increment != c_DefIncrement;
        }

        protected override void ResetIncrement()
        {
            Increment = c_DefIncrement;
        }

        protected override bool ShouldSerializeFormat()
        {
            return Format != c_DefFormat;
        }

        protected override void ResetFormat()
        {
            Format = c_DefFormat;
        }
        #endregion

        protected override decimal ToActualValue(
            decimal value)
        {
            return value / 100.0m;
        }

        protected override decimal FromActualValue(
            decimal value)
        {
            return value * 100.0m;
        }
        #endregion

        #region Public properties
        #region Hidden properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new decimal? MinValue
        {
            get { return base.MinValue; }
            set { base.MinValue = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new decimal? MaxValue
        {
            get { return base.MaxValue; }
            set { base.MaxValue = value; }
        }
        #endregion
        #endregion
    }
}
