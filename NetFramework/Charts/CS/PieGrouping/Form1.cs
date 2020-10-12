using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using C1.Win.C1Chart;

namespace PieGrouping
{
	public partial class Form1 : Form
	{
		PieGrouper pieGrouper = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			c1Chart1.BackColor = Color.FromKnownColor(KnownColor.Window);

			// use light colors so all of the labels are easily read.
			c1Chart1.ColorGeneration = ColorGeneration.Flow;

			// stacked pie chart
			c1Chart1.ChartGroups.Group0.ChartType = Chart2DTypeEnum.Pie;
			c1Chart1.ChartGroups.Group0.Stacked = chkStacked.Checked;

			// 3d effects
			if (chk3D.Checked)
			{
				c1Chart1.ChartArea.PlotArea.View3D.Depth = 15;
				c1Chart1.ChartArea.PlotArea.View3D.Elevation = 75;
			}

			// with tooltips
			c1Chart1.ToolTip.SelectAction = SelectActionEnum.Click;
			c1Chart1.ToolTip.Enabled = true;

			// maximize the ChartArea
			c1Chart1.ChartArea.Margins.SetMargins(0, 0, 0, 0);
			c1Chart1.ChartArea.Style.Border.BorderStyle = BorderStyleEnum.None;

			// Use the PieGrouper class to input the data.
			PieGrouper pgBaseNode = new PieGrouper();
			PieGrouper pgRootNode = null;
			PieGrouper pgMidNode = null;

			// Brackets are not required, but show the nesting of
			// the data nodes.
			pgRootNode = pgBaseNode.AddRoot("Beverages", Color.LightBlue);
			{
				pgMidNode = pgRootNode.AddIntermediate("Cold", Color.Transparent);
				{
					pgMidNode.AddLeaf("Apple Cider", 300, Color.Transparent);
					pgMidNode.AddLeaf("Orange juice", 200, Color.Orange);
				}
				pgMidNode = pgRootNode.AddIntermediate("Hot", Color.Empty);
				{
					pgMidNode.AddLeaf("Tea", 120, Color.Transparent);
					pgMidNode.AddLeaf("Chocolate", 80, Color.Transparent);
				}
			}

			pgRootNode = pgBaseNode.AddRoot("Dairy", Color.LightCoral);
			{
				pgMidNode = pgRootNode.AddIntermediate("Confections", Color.Transparent);
				{
					pgMidNode.AddLeaf("Ice Cream", 256, Color.Transparent);
				}

				pgMidNode = pgRootNode.AddIntermediate("Cheeses", Color.Transparent);
				{
					pgMidNode.AddLeaf("Cheddar", 350, Color.Transparent);
					pgMidNode.AddLeaf("Rocky Cheese", 310, Color.Transparent);
				}
			}

			pgRootNode = pgBaseNode.AddRoot("Condiments", Color.LightGray);
			{
				pgMidNode = pgRootNode.AddIntermediate("Sweet");
				{
					pgMidNode.AddLeaf("Demiglace", 220);
					pgMidNode.AddLeaf("Pure sugar", 180);
				}
				pgMidNode = pgRootNode.AddIntermediate("Spicy");
				{
					pgMidNode.AddLeaf("Bl. Pepper", 150);
					pgMidNode.AddLeaf("Cayenne", 170);
					pgMidNode.AddLeaf("Chili", 84);
					pgMidNode.AddLeaf("Jalepeno", 52);
				}
			}

			// save the class instance to allow changes later.
			pieGrouper = pgBaseNode;

			// create the new ChartDataSeriesCollection with the current settings
			pgBaseNode.AddToChartDataSeriesCollection(chkAscending.Checked,
				c1Chart1.ChartGroups.Group0.ChartData.SeriesList);
		}

		private void CheckBoxCheckedChanged(object sender, EventArgs e)
		{
			CheckBox cb = sender as CheckBox;
			if (cb != null)
			{
				switch (cb.Name)
				{
					case "chk3D":
						if (chk3D.Checked)
						{
							c1Chart1.ChartArea.PlotArea.View3D.Depth = 20;
							c1Chart1.ChartArea.PlotArea.View3D.Elevation = 75;
						}
						else
						{
							c1Chart1.ChartArea.PlotArea.View3D.Depth = 0;
						}
						break;

					case "chkStacked":
						c1Chart1.ChartGroups.Group0.Stacked = cb.Checked;
						break;

					case "chkAscending":
						pieGrouper.AddToChartDataSeriesCollection(chkAscending.Checked,
							c1Chart1.ChartGroups.Group0.ChartData.SeriesList);
						break;
				}
			}
		}
	}
}
