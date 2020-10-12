using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using C1.Win.C1Chart;

namespace PieGrouping
{
	public class PieGrouper
	{
		List<PieGrouper> _root = null;
		List<PieGrouper> _children = null;
		PieGrouper _parent = null;

		int _syncPoint = -1;
		float _syncValue = 0f;
		Color _syncColor = Color.Empty;

		string _name = string.Empty;
		float _value = 0f;
		Color _color = Color.Empty;

		string[] msgs = new string[] {
			/* 0 */	"All leaf nodes must be at the same depth.",
			/* 1 */	"A leaf node cannot have children.",
			/* 2 */	"An intermediate node cannot be added to a node with child leaf nodes",
			/* 3 */	"A leaf node cannot be added to a node with child intermediate nodes",
			/* 4 */	"A root node cannot be added to a child node.",
			/* 5 */	"Only a populated root node can be synced and used for populating the ChartDataSeriesCollection.",
			};

		private Exception makeException(string name, int code)
		{
			Exception e = new Exception(msgs[code]);
			e.Data.Add("code", code);
			e.Data.Add("name", name);
			return e;
		}

		private void setDepth()
		{
			int depth = 0;
			PieGrouper ps = this;
			ps._syncPoint = 0;
			while (ps._parent != null)
			{
				ps = ps._parent;
				depth++;
				if (ps._syncPoint < 0)
					ps._syncPoint = depth;
			}

			if (ps._syncPoint != depth)
				throw makeException(null, 0);
		}

		private void reset()
		{
			_syncValue = 0f;
			_syncColor = Color.Empty;

			if (_root != null)
			{
				foreach (PieGrouper pg in _root)
					pg.reset();
			}

			if (_children != null)
			{
				foreach (PieGrouper pg in _children)
					pg.reset();
			}
		}

		private PieGrouper addChild(ref List<PieGrouper> sliceList, PieGrouper pieSlice)
		{
			if (sliceList == null)
				sliceList = new List<PieGrouper>();

			pieSlice._parent = this;
			sliceList.Add(pieSlice);

			return pieSlice;
		}

		private PieGrouper initChild(string name, float value, Color color)
		{
			PieGrouper ps = new PieGrouper();
			ps._name = name;
			ps._value = value;
			ps._color = color;
			ps._parent = this;
			return ps;
		}

		private PieGrouper AddChild(PieGrouper pieSlice)
		{
			if (this._value != 0f)
				throw makeException(pieSlice._name, 1);

			if (this._children != null && this._children.Count > 0)
			{
				float childValue = this._children[0]._value;
				if ((childValue == 0) != (pieSlice._value == 0))
				{
					if (childValue != 0)
						throw makeException(pieSlice._name, 2);
					else
						throw makeException(pieSlice._name, 3);
				}
			}
			return addChild(ref _children, pieSlice);
		}

		/// <summary>
		/// Adds a leaf node with an explicit value and explicit color.
		/// A leaf node cannot have children.  Use Color.Transparent
		/// to inherit the parent node color.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <param name="color"></param>
		/// <returns></returns>
		public void AddLeaf(string name, float value, Color color)
		{
			if (value == 0f) return;
			PieGrouper ps = AddChild(initChild(name, value, color));
			ps.setDepth();
		}

		/// <summary>
		/// Adds a leaf node with a value and uniquely generated color.
		/// A leaf node cannot have children.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public void AddLeaf(string name, float value)
		{
			AddLeaf(name, value, Color.Empty);
		}

		/// <summary>
		/// Adds an intermediate node with an explicit color.  An intermediate node
		/// is valued as the sum of its immediate children.  Use Color.Transparent
		/// to inherit the parent node color.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="color"></param>
		/// <returns></returns>
		public PieGrouper AddIntermediate(string name, Color color)
		{
			return AddChild(initChild(name, 0f, color));
		}

		/// <summary>
		/// Adds an intermediate node with a uniquely generated color.  An intermediate
		/// node is valued as the sum of its immediate children.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public PieGrouper AddIntermediate(string name)
		{
			return AddIntermediate(name, Color.Empty);
		}

		/// <summary>
		/// Adds a root node with an explicit color.  A root node is valued as
		/// the sum of its immediate children.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="color"></param>
		/// <returns></returns>
		public PieGrouper AddRoot(string name, Color color)
		{
			if (this._parent != null)
				throw makeException(name, 4);

			return addChild(ref _root, initChild(name, 0f, color));
		}

		/// <summary>
		/// Add a root node with a uniquely generated color.  A root node is
		/// valued as the sum of its immediate children.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public PieGrouper AddRoot(string name)
		{
			return AddRoot(name, Color.Empty);
		}

		private void syncSubnodes(PieGrouper node, List<PieGrouper>[] pointLists, ref int seriesCount)
		{
			if (node != null)
			{
				if (node._children != null && node._children.Count > 0)
				{
					// an intermediate node
					foreach (PieGrouper ps in node._children)
					{
						if (ps._color == Color.Transparent && node._syncColor != Color.Empty)
							ps._syncColor = node._syncColor;
						else
							ps._syncColor = ps._color;

						syncSubnodes(ps, pointLists, ref seriesCount);
						node._syncValue += ps._syncValue;
					}
				}
				else
				{
					// an leaf node
					node._syncValue = node._value;
				}
				if (node._syncValue != 0f)
				{
					seriesCount++;

					int point = node._syncPoint;
					if (pointLists[point] == null)
						pointLists[point] = new List<PieGrouper>();
					pointLists[point].Add(node);
				}
			}
		}

		private void syncNodes(List<PieGrouper>[] pointLists)
		{
			if (this._root == null)
				throw makeException(null, 5);

			reset();

			int seriesCount = 0;

			foreach (PieGrouper root in _root)
			{
				root._syncColor = root._color;
				syncSubnodes(root, pointLists, ref seriesCount);
			}
		}

		public void AddToChartDataSeriesCollection(bool ascending, ChartDataSeriesCollection cdsc)
		{
			AddToChartDataSeriesCollection(ascending, cdsc, null);
		}

		/// <summary>
		/// Using the data structures created through the use of AddRoot, AddIntermediate and AddLeaf
		/// methods, populates the specified ChartDataSeriesCollection for a stacked Pie chart with
		/// segments.
		/// </summary>
		/// <param name="ascending"></param>
		/// <param name="cdsc"></param>
		/// <param name="dataLabelText"></param>
		public void AddToChartDataSeriesCollection(bool ascending, ChartDataSeriesCollection cdsc, string dataLabelText)
		{
			int pointCount = _syncPoint;
			List<PieGrouper>[] pointLists = new List<PieGrouper>[pointCount];
			syncNodes(pointLists);
			cdsc.Clear();

			float[] pointArray = new float[pointCount];
			pointArray.Initialize();

			if (dataLabelText == null)
				dataLabelText = "{#TEXT}\r\n{#YVAL} ({%YVAL:0.00%})";

			for (int i = 0; i < pointCount; i++)
			{
				int j = ascending ? i : pointCount - 1 - i;
				List<PieGrouper> pointList = pointLists[j];
				foreach (PieGrouper ps in pointList)
				{
					ChartDataSeries cds = cdsc.AddNewSeries();

					cds.Label = ps._name;
					if (ps._syncColor != Color.Empty)
					{
						if (ps._syncColor == Color.Transparent)
						{
							PieGrouper ps1 = ps;
							while (ps1 != null && ps1._syncColor == Color.Transparent)
								ps1 = ps1._parent;
							if (ps1 != null && ps1._syncColor != Color.Transparent)
							{
								if (ps1._syncColor == Color.Empty)
									ps1._syncColor = cds.FillStyle.Color1;
								ps._syncColor = ps1._syncColor;
								for (ps1 = ps; ps1 != null && ps1._syncColor == Color.Transparent; ps1 = ps1._parent)
									ps1._syncColor = ps._syncColor;
							}
						}
						cds.FillStyle.Color1 = ps._syncColor;
					}
					else
					{
						ps._syncColor = cds.FillStyle.Color1;
					}

					pointArray[i] = ps._syncValue;
					cds.Y.CopyDataIn(pointArray);

					cds.DataLabel.Compass = LabelCompassEnum.RadialText;
					cds.DataLabel.Offset = -5;
					cds.DataLabel.Text = dataLabelText;
					cds.DataLabel.Visible = true;

					cds.TooltipText = cds.DataLabel.Text;
				}
				pointArray[i] = 0f;
			}
		}
	}
}
