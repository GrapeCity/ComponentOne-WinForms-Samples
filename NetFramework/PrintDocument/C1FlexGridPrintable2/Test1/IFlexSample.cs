using C1.Win;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C1FlexGridPrinterTest
{
    interface IFlexSample
    {
        /// <summary>
        /// Creates the C1PrintDocument representing the sample.
        /// </summary>
        /// <param name="printInfo">The print info to use.</param>
        /// <param name="longOperation">Long operation event handler.</param>
        /// <returns>The created print document, or null.</returns>
        C1.C1Preview.C1PrintDocument MakeDoc(C1.Win.C1FlexGrid.C1FlexGridPrintInfo printInfo, LongOperationEventHandler longOperation);
    }

    class SampleWrapper
    {
        private Type _formType;
        private string _name;
        private Form _form;

        public SampleWrapper(Type formType, string name)
        {
            _formType = formType;
            _name = name;
        }

        public event EventHandler FormChanged;

        public void Show()
        {
            if (_form != null)
                return;
            _form = Activator.CreateInstance(_formType) as Form;
            if (_form != null)
            {
                _form.FormClosed += new FormClosedEventHandler(_form_FormClosed);
                _form.Show();
                if (FormChanged != null)
                    FormChanged(this, EventArgs.Empty);
            }
        }

        public Form Form { get { return _form; } }

        void _form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form = null;
            if (FormChanged != null)
                FormChanged(this, EventArgs.Empty);
        }

        public C1.Win.C1FlexGrid.C1FlexGrid Flex
        {
            get
            {
                return FindGrid(_form);
            }
        }

        public C1.C1Preview.C1PrintDocument MakeDoc(C1.Win.C1FlexGrid.C1FlexGridPrintInfo printInfo, LongOperationEventHandler longOperation)
        {
            IFlexSample fs = _form as IFlexSample;
            if (fs != null)
                return fs.MakeDoc(printInfo, longOperation);
            else
                return null;
        }

        public override string ToString()
        {
            if (typeof(IFlexSample).IsAssignableFrom(_formType))
                return _name + " (custom C1PrintDocument)";
            else
                return _name;
        }

        public static C1.Win.C1FlexGrid.C1FlexGrid FindGrid(Control parent)
        {
            if (parent == null)
                return null;

            foreach (Control c in parent.Controls)
            {
                if (c is C1.Win.C1FlexGrid.C1FlexGrid)
                    return c as C1.Win.C1FlexGrid.C1FlexGrid;
            }
            foreach (Control c in parent.Controls)
            {
                C1.Win.C1FlexGrid.C1FlexGrid flex = FindGrid(c);
                if (flex != null)
                    return flex;
            }
            return null;
        }
    }
}
