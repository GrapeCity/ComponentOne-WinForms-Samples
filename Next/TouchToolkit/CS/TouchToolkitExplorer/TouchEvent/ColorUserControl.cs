using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchToolkitExplorer.TouchEvent
{
    public partial class ColorUserControl : UserControl
    {
        #region Filed

        private Color _color;
        private bool _isNormalSize = true;

        #endregion

        #region Init

        public ColorUserControl()
        {
            InitializeComponent();
            foreach (Button button in tableLayoutPanel1.Controls)
            {
                button.Click += button_Click;
            }
        }

        #endregion

        #region Property

        public Color Color
        {
            get
            {
                return _color;
            }
        }

        public bool IsNormalSize
        {
            get
            {
                return _isNormalSize;
            }
            set
            {
                if (_isNormalSize != value)
                {
                    _isNormalSize = value;
                    if (_isNormalSize)
                    {
                        tableLayoutPanel1.Size = new Size(200, 150);
                        this.Size = new Size(200, 150);
                    }
                    else
                    {
                        this.Size = new Size(400, 300);
                        tableLayoutPanel1.Size = new Size(400, 300);
                    }
                }
            }
        }

        #endregion

        #region Methods and Events

        public event EventHandler<EventArgs> ValueChanged;

        protected virtual void OnValueChanged(EventArgs e)
        {
            if (this.ValueChanged != null)
            {
                this.ValueChanged(this, e);
            }
        }

        void button_Click(object sender, EventArgs e)
        {
            _color = (sender as Button).BackColor;
            OnValueChanged(EventArgs.Empty);
        }

        #endregion
    }
}
