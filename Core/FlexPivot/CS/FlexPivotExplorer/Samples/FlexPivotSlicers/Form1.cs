using C1.Win.Ribbon;
using C1.Win.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexPivot;

namespace FlexPivotExplorer.Samples.FlexPivotSlicers
{
	public partial class Form1 : UserControl
	{
		string _chlFieldsId;

		public Form1()
		{
			InitializeComponent();
			_chlFieldsId = c1DashboardLayout1.Items[0].Id;
			chlFields.CheckOnClick = true;
			// load data
			var da = new OleDbDataAdapter("select * from Invoices", GetConnectionString());
			var dt = new DataTable();
			da.Fill(dt);

			// assign it to C1FlexPivotPanel that is driving the app
			this.c1FlexPivotPanel1.DataSource = dt;

			// get FlexPivot engine
			var fp = c1FlexPivotPanel1.PivotEngine;

			// add views
			AddView("ExtendedPrice,ProductName,Country,ShipCity");
			AddView("ExtendedPrice,Salesperson,ProductName,UnitPrice");
			ribbonGallery1.SelectedIndex = 0;;

			BuildSlicers();
			chlFieldsSelectAll();
		}

		void chlFieldsSelectAll()
		{
			for (int i = 0; i < chlFields.Items.Count; i++)
			{
				chlFields.SetItemChecked(i, true);
			}
		}

		void SetView(string view)
		{
			chlFields.Items.Clear();
			var fields = view.Split(',');

			// get FlexPivot engine
			var fp = c1FlexPivotPanel1.PivotEngine;
			fp.ValueFields.Clear();
			fp.ColumnFields.Clear();
			fp.RowFields.Clear();
			fp.FilterFields.Clear();
			// build up view
			fp.ValueFields.Add(fields[0]);
			fp.ColumnFields.Add(fields[1]);
			fp.RowFields.Add(fields[2]);
			foreach(var f in fields.Skip(3))
				fp.FilterFields.Add(f);
			chlFields.Items.AddRange(fp.ColumnFields.Concat(fp.RowFields).Concat(fp.ValueFields).Select(x => x.Name).ToArray());
			BuildSlicers();
			chlFieldsSelectAll();
		}


		void AddView(string view)
		{
			var fields = view.Split(',');
			var viewDesc = $"{fields[0]} by {fields[1]} and {fields[2]}";
			var viewTitle = $"{fields[1]}";
			var gallaryItem = new RibbonGalleryItem();

			gallaryItem.Text = viewTitle;
			gallaryItem.Description = viewDesc;
			gallaryItem.ToolTip = viewDesc;
			gallaryItem.Tag = view;
			ribbonGallery1.Items.Add(gallaryItem);
		}

		void BuildSlicers()
		{
			int i = 0;
			while (c1DashboardLayout1.Items.Count > 1)
			{
				if (_chlFieldsId != c1DashboardLayout1.Items[i].Id)
					c1DashboardLayout1.Items.Remove(c1DashboardLayout1.Items[i].Id);
				else
					i++;
			}
			foreach (string field in chlFields.Items)
			{
				var sl = new C1FlexPivotSlicer()
				{
					DataSource = c1FlexPivotPanel1,
					FieldName = field,
					Dock = DockStyle.Fill
				};
				var di = c1DashboardLayout1.Items.Add(field,
					new List<Control>
					{
						sl	
					});
				
				c1DashboardLayout1.SetCaption(di.ItemContainer, field);
				c1DashboardLayout1.SetId(di.ItemContainer, Guid.NewGuid().ToString());
				((Control)di.ItemContainer).Size = new Size(300, 250);
				sl.EndInit();
			}
		}

		// get standard nwind mdb connection string
		static string GetConnectionString()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
			string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
			return string.Format(conn, path);
		}

		private void chlFields_SelectionChanged(object? sender, ItemCheckEventArgs e)
		{
			((Control)c1DashboardLayout1.Items[e.Index + 1].ItemContainer).Visible = e.NewValue == CheckState.Checked;
		}

		private void rbGrid_PressedButtonChanged(object sender, EventArgs e)
		{
			c1FlexPivotGrid1.Visible = rbGrid.Pressed;
			c1FlexPivotChart1.Visible = !rbGrid.Pressed;
		}

		private void ribbonGallery1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Text = ribbonGallery1.SelectedItem.Description;
			SetView((string)ribbonGallery1.SelectedItem.Tag);
		}
	}
}
