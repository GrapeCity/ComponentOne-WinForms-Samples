using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.MultiSelect
{
    public partial class TagEditor : C1DemoForm
    {
        public TagEditor()
        {
            InitializeComponent();

            c1TagEditor1.Tags.Add("Windows Forms");

            AddProperty("ShowRemoveButton", c1TagEditor1);
            AddProperty("Placeholder", c1TagEditor1);
            AddProperty("TagWrap", c1TagEditor1);
            AddProperty("DisplayMode", c1TagEditor1);
            AddProperty("Separator", c1TagEditor1);
        }
    }
}
