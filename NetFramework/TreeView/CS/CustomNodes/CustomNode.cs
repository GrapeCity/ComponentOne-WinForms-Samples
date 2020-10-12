using C1.Framework;
using C1.Win.TreeView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNodes
{
    public class CategoryCustomNode : CustomContentPresenter
    {
        // level 0
        private TextElement _name;
        private TextElement _description;
        private ImageElement _img;
        private RowPanel _rw;
        // level 1
        private TextElement _product;

        public CategoryCustomNode()
        {
            // level 0
            // init text elements
            // name
            _name = new TextElement();
            _name.Style = new Style();                    
            // description
            _description = new TextElement();
            _description.Style = new Style();
            _description.Width = 120;
            // init image element
            _img = new ImageElement();
            _img.Style = new Style();
            _img.Size = new Size(70, 50);            
            // init a grid for text elements
            var cp = new ColumnPanel();
            cp.Children.Add(_name);
            cp.Children.Add(_description);
            // init panel for image
            _rw = new RowPanel();
            _rw.Children.Add(cp);
            _rw.Children.Add(_img);
            _rw.Style = new Style();
            _rw.Style.VerticalAlignment = Alignment.Center;
            // level 1
            _product = new TextElement();
            _product.Style = new Style();
        }

        public override string ToolTipText
        {
            get
            {
                return _name.Text;
            }
        }

        public override void SetStyle(TreeNodeCellStyles styles)
        {
            base.SetStyle(styles);
            // level 0
            // name 
            _name.Style.Margins = new Thickness(1);
            _name.Style.Font = new Font("Calibri", 10, FontStyle.Bold);
            // description
            _description.Style.Margins = new Thickness(1);
            _description.Style.Font = new Font("Calibri", 9, FontStyle.Italic);
            _description.Style.WordWrap = true;
            // img
            _img.Style.ImageScaling = ImageScaling.Scale;
            _img.Style.ImageAlignment = ImageAlignment.CenterCenter;    
            // level 1
            _product.Style.Font = new Font("Calibri", 10, FontStyle.Bold);
            _product.Style.Margins = new Thickness(2);
            _product.Style.HorizontalAlignment = Alignment.Center;
            _product.Style.VerticalAlignment = Alignment.Center;
        }

        public override void SetValue(object value)
        {
            if (Node.Level == 0)
            {
                var row = (DataSet1.CategoriesRow)Node.GetValue();
                _name.Text = row.CategoryName;
                _description.Text = row.Description;
                var converter = new ImageConverter();
                if (_img.Image != null)
                {
                    _img.Image.Dispose();
                    _img.Image = null;
                }
                _img.Image = (Image)converter.ConvertFrom(row.Picture);
                // set root panel
                Child = _rw;
            }
            else
            {
                _product.Text = value.ToString();
                // set root element
                Child = _product;
            }
        }

        public override void SetFormat(string format)
        {
            
        }
    }

    public class ProductCustomNode : CustomContentPresenter
    {
        // level 0
        private TextElement _count;
        // level 1
        private TextElement _quantityPerUnit;
        private TextElement _unitPrice;
        private TextElement _unitInStock;
        private TextElement _unitsOnOrder;
        private TextElement _reorderLevel;
        private GridPanel _gp;
        private Style _eStyle;

        public ProductCustomNode()
        {
            // level 0
            // count in category
            _count = new TextElement();
            _count.Style = new Style();
            _count.Style.Margins = new Thickness(2);
            // level 1
            // lable style
            var lStyle = new Style();
            lStyle.HorizontalAlignment = Alignment.Far;
            lStyle.Margins = new Thickness(1);
            lStyle.Font = new Font("Calibri", 9, FontStyle.Regular);
            // elements style
            _eStyle = new Style();
            _eStyle.Margins = new Thickness(1);
            _eStyle.Font = new Font("Calibri", 9, FontStyle.Regular);
            // init elements
            _quantityPerUnit = new TextElement(_eStyle.Clone());
            _unitPrice = new TextElement(_eStyle.Clone());
            _unitInStock = new TextElement(_eStyle.Clone());
            _unitsOnOrder = new TextElement(_eStyle.Clone());
            _reorderLevel = new TextElement(_eStyle.Clone());
            // init a grid for text elements
            _gp = new GridPanel();
            _gp.Columns.Add(); // labels
            _gp.Columns[0].Width = 100;
            _gp.Columns.Add(); // text
            _gp.Columns[1].Width = 120;

            _gp.Rows.Add(); // ReorderLevel
            _gp[0, 0].Element = new TextElement(lStyle, "Reorder level:");
            _gp[0, 1].Element = _reorderLevel;
            _gp.Rows.Add(); // UnitPrice
            _gp[1, 0].Element = new TextElement(lStyle, "Unit price:");
            _gp[1, 1].Element = _unitPrice;
            _gp.Rows.Add(); // QuantityPerUnit
            _gp[2, 0].Element = new TextElement(lStyle, "Quantity per unit:");
            _gp[2, 1].Element = _quantityPerUnit;                        

            _gp.Columns.Add(); // labels
            _gp.Columns[2].Width = 100;
            _gp.Columns.Add(); // text
            // UnitsInStock
            _gp[0, 2].Element = new TextElement(lStyle, "Units in stock:");
            _gp[0, 3].Element = _unitInStock;
            // UnitsOnOrder
            _gp[1, 2].Element = new TextElement(lStyle, "Units on order:");
            _gp[1, 3].Element = _unitsOnOrder;

        }

        public override string ToolTipText
        {
            get
            {
                return string.Empty; ;
            }
        }

        public override void SetStyle(TreeNodeCellStyles styles)
        {
            base.SetStyle(styles);
            // level 0
            _count.Style.HorizontalAlignment = Alignment.Center;
            _count.Style.VerticalAlignment = Alignment.Center;
            _count.Style.Font = new Font("Calibri", 11, FontStyle.Bold);
            // level 1
            _unitPrice.Style.Font = new Font(_eStyle.Font, FontStyle.Bold);
            if (_unitInStock.Text == "0")
            {
                _unitInStock.Style.ForeColor = Color.Red;
                _unitInStock.Style.Font = new Font(_eStyle.Font, FontStyle.Bold);
            }
            if (_unitsOnOrder.Text == "0")
            {
                _unitsOnOrder.Style.ForeColor = Color.Red;
                _unitsOnOrder.Style.Font = new Font(_eStyle.Font, FontStyle.Bold);
            }
        }

        public override void SetValue(object value)
        {
            if (Node.Level == 0)
            {
                var count = Node.HasChildren ? Node.Nodes.Count : 0;
                _count.Text = count.ToString();
                Child = _count;
            }
            else
            {
                var row = (DataSet1.ProductsRow)Node.GetValue();
                _quantityPerUnit.Text = row.QuantityPerUnit;
                _unitPrice.Text = row.UnitPrice.ToString("C");                
                _unitInStock.Text = row.UnitsInStock.ToString();
                _unitsOnOrder.Text = row.UnitsOnOrder.ToString();
                _reorderLevel.Text = row.ReorderLevel.ToString();
                Child = _gp;
            }
        }

        public override void SetFormat(string format)
        {
            
        }
    }
}
