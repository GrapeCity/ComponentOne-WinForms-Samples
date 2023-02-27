using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchDemo.C1ZoomPages.Help_Forms
{
    public partial class PanWindowForm:Form
    {
        private FormStartPosition _formStartPosition;
        private Size _size;
        private Point _location;
        private string _methodName;

        public PanWindowForm()
        {
            InitializeComponent();
        }

        public PanWindowForm(string methodName, Size size, Point location, FormStartPosition formStartPosition)
        {
            InitializeComponent();

            _methodName = methodName;
            _size=size;
            _location=location;
            _formStartPosition = formStartPosition;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            C1Zoom1.ZoomFactor = 2f;

            switch (_methodName)
            {
                case "Form ShowPanWindow();":
                    C1Zoom1.ShowPanWindow();
                    break;
                case "Form ShowPanWindow(FormStartPosition);":
                    C1Zoom1.ShowPanWindow(_formStartPosition);
                    break;
                case "Form ShowPanWindow(FormStartPosition, Size);":
                    C1Zoom1.ShowPanWindow(_formStartPosition, _size);
                    break;
                case "Form ShowPanWindow(Point);":
                    C1Zoom1.ShowPanWindow(_location);
                    break;
                case "Form ShowPanWindow(Point, Size);":
                    C1Zoom1.ShowPanWindow(_location, _size);
                    break;
                default: break;
            }
        }
    }
}
