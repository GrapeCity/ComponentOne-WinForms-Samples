using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.Chart.Designer.Data;

namespace C1.Win.Chart.Designer.UI
{
    partial class BindingLabel : UserControl
    {
        List<Field> fields = new List<Field>();
        bool multiFields;

        public BindingLabel(string name, bool multiFields = false)
        {
            InitializeComponent();

            label1.Text = name;
            this.multiFields = multiFields;
        }

        public string BindingName
        {
            get { return label1.Text; }
        }

        public List<Field> Fields
        {
            get{ return fields; }
        }

        public void Add(Field f)
        {
            if (!multiFields)
            {
                if(Fields.Count > 0)
                    tableLayoutPanel1.Controls.RemoveAt(tableLayoutPanel1.Controls.Count-1);
                Fields.Clear();
            }

            Fields.Add(f);
            var flbl = new FieldLabel(f, true, false);
            flbl.Closed += (s, e) =>
            {
                Fields.Remove(flbl.Field);
                tableLayoutPanel1.Controls.Remove(flbl);
                OnBindingsUpdated(this, EventArgs.Empty);
            };
            tableLayoutPanel1.Controls.Add(flbl);
            OnBindingsUpdated(this, EventArgs.Empty);
        }

        public event EventHandler BindingUpdated;

        void OnBindingsUpdated(object sender, EventArgs args)
        {
            if (BindingUpdated != null)
                BindingUpdated(sender, args);
        }
    }
}
