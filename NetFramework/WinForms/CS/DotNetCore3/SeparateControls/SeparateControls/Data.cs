using System;

namespace SeparateControls
{
    // demo data with significant properties to be used in the expression
    public class Data
    {
        #region Fields
        private int _var1;
        private int _var2;
        private int _var3;
        private int _var4;
        private int _var5;
        #endregion

        #region Properties
        public int Variable1
        {
            get { return _var1; }
            set
            {
                if (_var1 != value)
                {
                    _var1 = value;
                    OnValueChanged();
                }
            }
        }
        public int Variable2
        {
            get { return _var2; }
            set
            {
                if (_var2 != value)
                {
                    _var2 = value;
                    OnValueChanged();
                }
            }
        }
        public int Variable3
        {
            get { return _var3; }
            set
            {
                if (_var3 != value)
                {
                    _var3 = value;
                    OnValueChanged();
                }
            }
        }
        public int Variable4
        {
            get { return _var4; }
            set
            {
                if (_var4 != value)
                {
                    _var4 = value;
                    OnValueChanged();
                }
            }
        }
        public int Variable5
        {
            get { return _var5; }
            set
            {
                if (_var5 != value)
                {
                    _var5 = value;
                    OnValueChanged();
                }
            }
        }
        #endregion

        public event EventHandler ValueChanged;
        private void OnValueChanged()
        {
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
