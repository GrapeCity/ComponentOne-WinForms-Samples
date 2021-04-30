using C1.Win.C1Ribbon;
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

namespace DataSlicer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
			chlFields.SelectAll();
		}

		void SetView(string view)
		{
			chlFields.Items.Clear();
			while (c1DashboardLayout1.Items.Count > 1)
				c1DashboardLayout1.Items.Remove(c1DashboardLayout1.Items[1].Id);
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
			chlFields.Items.AddRange(fp.ColumnFields.Concat(fp.RowFields).Concat(fp.ValueFields).Select(x => x.Name).ToList());
			BuildSlicers();
			chlFields.SelectAll();
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
			foreach (var field in chlFields.Items)
			{
				var sl = new C1FlexPivotSlicer()
				{
					DataSource = c1FlexPivotPanel1,
					FieldName = (string)field.Value,
					Dock = DockStyle.Fill
				};
				var di = c1DashboardLayout1.Items.Add((string)field.Value,
					new List<Control>
					{
						sl	
					});
				
				c1DashboardLayout1.SetCaption(di.ItemContainer, field.Value.ToString());
				c1DashboardLayout1.SetId(di.ItemContainer, Guid.NewGuid().ToString());
				((Control)di.ItemContainer).Size = new Size(300, 250);
				if (!field.Selected) ((Control)di.ItemContainer).Visible = false;
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

		private void chlFields_SelectionChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < chlFields.Items.Count; i++)
			{
				var di = c1DashboardLayout1.Items[i+1];
				((Control)di.ItemContainer).Visible = chlFields.Items[i].Selected;
			}
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
