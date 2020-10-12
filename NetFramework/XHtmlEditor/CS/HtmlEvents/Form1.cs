using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using C1.Win.C1Editor;
using C1.Win.C1Editor.Internal.HTML;

namespace HtmlEvents
{
    public partial class Form1 : Form
    {
        private Control _currentControl = null;
        private IHTMLElement _currentHTMLElement = null;

        public Form1()
        {
            Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            InitializeComponent();

            c1Editor1.HtmlEvent += new C1.Win.C1Editor.HtmlEventEventHandler(c1Editor1_HtmlEvent);
            textBox1.TextChanged += new EventHandler(control_TextChanged);
            dateTimePicker1.TextChanged += new EventHandler(control_TextChanged);
            comboBox1.TextChanged += new EventHandler(control_TextChanged);
        }

        protected override void OnLoad(EventArgs e)
        {
            c1Editor1.LoadXml(Properties.Resources.Document, null);
            base.OnLoad(e);
        }

        void c1Editor1_HtmlEvent(object sender, HtmlEventEventArgs e)
        {
            if (e.Type != C1.Win.C1Editor.HtmlEventTypes.MouseOver) //only MouseOver event is handled
                return;
            bool isLinked = false;
            IHTMLElement element = e.HTMLEventObj.SrcElement;
            if (element != null)
            {
                object oClassName = element.getAttribute("className", 0); //get class name of the current element
                if (oClassName is string)
                {
                    string className = oClassName as string;
                    switch (className)
                    {
                        //text input fields
                        case "pubtitle":
                        case "subtitle":
                        case "other":
                        case "pubname":
                        case "isbn":
                            LinkControlToElement(textBox1, element); 
                            isLinked = true;
                            break;
                        //date input fields
                        case "date":
                            LinkControlToElement(dateTimePicker1, element);
                            isLinked = true;
                            break;
                        //combobox input fields
                        case "pubcity":
                            LinkControlToElement(comboBox1, element); 
                            isLinked = true;
                            break;
                    }
                }
            }
            if (!isLinked)
                HideCurrentVisibleControl(); //hide current control if visible
        }

        void control_TextChanged(object sender, EventArgs e)
        {
            if (_currentHTMLElement == null)
                return;
            _currentHTMLElement.innerText = _currentControl.Text;
        }

        private void LinkControlToElement(Control control, IHTMLElement element)
        {
            if (_currentControl == control) //this control is already visible
                return;
            else if (_currentControl != null)
                HideCurrentVisibleControl(); //visible control found? Then hide it.

            _currentControl = control;
            _currentHTMLElement = element;

            int x = element.offsetLeft;
            int y = element.offsetTop;
            int width = element.offsetWidth;

            //set location, width and text of the control, and make them visible
            control.Location = new Point(x, y);
            control.Width = width + 20;
            control.Text = element.innerText;
            control.Visible = true;
        }

        private void HideCurrentVisibleControl()
        {
            if (_currentControl == null)
                return;
            //hide the current visible control
            _currentControl.Visible = false;
            _currentControl = null;
            _currentHTMLElement = null;
        }
   }
}