using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.C1ZoomPages.Help_Forms
{
    public partial class MyTrackBar : UserControl
    {
        public MyTrackBar()
        {
            InitializeComponent();

            MaxValue = 4;
            MinValue = 1;

            button2.LocationChanged += button2_LocationChanged;
            button2.MouseMove += button2_MouseMove;
            button2.MouseDown += button2_MouseDown;
            button2.MouseUp += button2_MouseUp;
            button2.MouseCaptureChanged += button2_MouseCaptureChanged;
        }

        int? downLocation = null;
        int startY = 0;

        void button2_MouseCaptureChanged(object sender, EventArgs e)
        {
            downLocation = null;
        }

        void button2_MouseUp(object sender, MouseEventArgs e)
        {
            downLocation = null;
        }

        void button2_MouseDown(object sender, MouseEventArgs e)
        {
            downLocation = button2.PointToScreen(e.Location).Y;
            startY = button2.Location.Y;
        }

        void button2_MouseMove(object sender, MouseEventArgs e)
        {
            var moveLocation = button2.PointToScreen(e.Location).Y;

            if (downLocation != null)
            {
                int y = startY + (moveLocation - downLocation.Value);
                if (y < 0)
                {
                    y = 0;
                }
                if (y > button1.Height - button2.Height)
                {
                    y = button1.Height - button2.Height;
                }
                button2.Location = new Point(button2.Location.X, y);
            }
        }

        void button2_LocationChanged(object sender, EventArgs e)
        {
            OnValueChanged(e);
        }

        [Bindable(true)]
        public float Value
        {
            get
            {
                return (float)(button2.Location.Y) / (button1.Height - button2.Height) * (MaxValue - MinValue) + MinValue;
            }
            set
            {
                button2.Location = new Point(button2.Location.X, (int)((button1.Height - button2.Height) * (value - MinValue) / (MaxValue - MinValue)));
            }
        }

        public float MaxValue { get; set; }
        public float MinValue { get; set; }

        public event EventHandler<EventArgs> ValueChanged;

        protected virtual void OnValueChanged(EventArgs e)
        {
            if (this.ValueChanged != null)
            {
                this.ValueChanged(this, e);
            }
        }
    }
}
