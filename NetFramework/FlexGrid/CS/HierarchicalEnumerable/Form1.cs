using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.UI;
using C1.Win.FlexGrid;

namespace HierarchicalEnumerable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // create hierarchical data source
            var ds = Common.GetCategoryData();

            // bind grid to hierarchical data source
            FillGridWithHierarchicalData(_flex, ds);
        }
        void FillGridWithHierarchicalData(C1FlexGrid flex, IHierarchicalEnumerable dataSource)
        {
            // configure grid
            flex.Rows.Count = flex.Rows.Fixed;
            flex.Cols.Count = flex.Cols.Fixed + 1;
            flex.Tree.Column = flex.Cols.Count - 1;
            flex.ExtendLastCol = true;
            flex.AllowEditing = false;
            flex.Cols[1].Caption = "Items";
            
            // add data
            foreach (IHierarchyData item in dataSource)
            {
                var p = item.GetParent();
                if (p == null)
                {
                    AddItem(flex, item, 0);
                }
            }
        }
        void AddItem(C1FlexGrid flex, IHierarchyData item, int level)
        {
            // add this item
            var nd = flex.Rows.AddNode(level);
            nd.Row.UserData = item;
            nd.Data = ((Category)item).Name;

            // add children
            foreach (IHierarchyData child in item.GetChildren())
            {
                AddItem(flex, child, level + 1);
            }
        }
    }
}
