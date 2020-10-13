using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using C1.C1DataExtender;
using C1.C1DataExtender.SchemaExtender;

namespace SchemaExtenderAndColumnStyles
{
    public partial class NWindDataSetExtender : DataSetExtender
    {
        public NWindDataSetExtender()
        {
            InitializeComponent();
        }

        public NWindDataSetExtender(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
