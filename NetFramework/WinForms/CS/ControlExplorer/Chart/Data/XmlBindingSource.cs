using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ControlExplorer.Chart
{
    [ToolboxItem(false)]
    public partial class XmlBindingSource : BindingSource
    {
        protected DataSet ds = null;

        public XmlBindingSource()
        {
            InitializeComponent();
            LoadXml();
        }

        public XmlBindingSource(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            LoadXml();
        }

        protected void AddDataMember(string xml)
        {
            StringReader reader = new StringReader(xml);
            ds.ReadXml(reader);
        }

        protected virtual void LoadXml()
        {
            ds = new DataSet();
            this.DataSource = ds;
		}

		[DefaultValue(null)]
		[Browsable(false)]
		[AttributeProvider(typeof(IListSource))]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new object DataSource
		{
			get { return base.DataSource; }
			set { base.DataSource = value; }
		}
    }
}
