using C1.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace C1IconDemo
{
    /// <summary>
    /// Shows collection of C1Icon elements in a uniform grid.
    /// </summary>
    /// <remarks>The UniformGridView resizes rows and columns according to its own size.</remarks>
    public class UniformGridView : XView
    {
        List<C1Icon> _icons;
        UniformGrid _element;

        /// <summary>
        /// Create a new instance of the <see cref="UniformGridView"/> class.
        /// </summary>
        public UniformGridView()
        {
            _icons = new List<C1Icon>();
            Dock = DockStyle.Fill;
            ScrollBars = ScrollBars.None;
            BuildUI();
        }

        /// <summary>
        /// Gets or sets the list of C1Icon objects to display.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(typeof(C1IconCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public List<C1Icon> Icons
        {
            get
            {
                return _icons;
            }
            set
            {
                _icons = value;
                BuildUI();
            }
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            if (_element != null)
            {
                // update element style to inherit new ForeColor
                _element.Style.ForeColor = ForeColor;
                _element.SetDirty();
            }
        }

        // C1Icon is UI-less object which can be used to specify icon properties, layout and other options.
        // To show C1Icon, application should create IconElements and put them inside some layout panel.
        // BuildUI method creates elements for every icon and puts them into uniform grid cells.
        private void BuildUI()
        {
            if (_icons == null || _icons.Count < 1)
                return;

            // create uniform grid with the same number of rows and columns 
            int count = (int)Math.Floor(Math.Sqrt(_icons.Count));
            _element = new UniformGrid(count, count);
            Element = _element;
            Element.Parent.Bounds = this.Bounds;
            _element.Style = new Style();
            _element.Style.Margins = new Thickness(4);
            _element.Style.ForeColor = ForeColor;

            // Create IconElements for each icon and place them into uniform grid
            int r = 0;
            int c = 0;
            foreach (C1Icon icon in _icons)
            {
                // Use factory method IconElement.CreateElement(icon) to create elements.
                // This method returns IconElement instances specific to icon type.
                // For example, for C1PathIcon it returns PathIconElement.
                var iconElement = IconElement.CreateElement(icon);
                
                // place IconElement into grid cell
                _element[r, c].Element = iconElement;
                c++;
                if (c > count - 1)
                {
                    c = 0;
                    r++;
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (_element != null)
            {
                // autosize content
                _element.Parent.Bounds = this.Bounds; 
            }
        }
    }

    /// <summary>
    /// The <see cref="UniformGrid"/> panel provides a way to arrange content in a grid where all the cells in the grid have the same size.
    /// </summary>
    internal class UniformGrid : GridPanel
    {
        public UniformGrid(int rows, int columns)
            : base(rows, columns)
        {
            base.CellSpacing = 12;
        }

        public override void Layout(Graphics g)
        {
            if (IsDirty)
            {
                if (AutoSize)
                {
                    SizeToParent();
                }
                // update row and column dimensions
                UpdateColumnWidths();
                UpdateRowHeights();

                // update row and column positions
                UpdateRowColumnPositions();

                // update children
                for (int r = 0; r < Rows.Count; r++)
                {
                    GridRow row = Rows[r];
                    row.SpanHeight = -1;
                    int height = row.Height;
                    for (int c = 0; c < row.Children.Count; c++)
                    {
                        // get the element
                        Element e = row.Children[c];
                        if (e != null)
                        {
                            GridColumn col = Columns[c];
                            // position and size element to the cell bounds within the parent row
                            if (e.AutoSize)
                            {
                                e.SetBounds(g, new Rectangle(col.Left, 0, col.Width, height));
                            }
                            else
                            {
                                e.SetBounds(g, new Rectangle(col.Left, 0, e.Width, e.Height));
                            }
                        }
                    }

                    // row is clean
                    row.SetDirty(false);
                }

                // we're clean
                SetDirty(false);
            }
        }
        private void UpdateColumnWidths()
        {
            // reset auto row sizes to -1 so paragraph elements will measure correctly
            foreach (GridRow r in Rows)
            {
                r.Width = -1;
            }

            List<Element> visibleColumns = new List<Element>();
            foreach (Element e in Columns)
            {
                if (e.Visible)
                {
                    visibleColumns.Add(e);
                }
            }
            if (visibleColumns.Count > 0)
            {
                int autoWidth = (ContentBounds.Width + CellSpacing) / visibleColumns.Count - CellSpacing;
                foreach (Element col in visibleColumns)
                {
                    col.SetWidth(autoWidth);
                }
                visibleColumns[visibleColumns.Count - 1].SetWidth(ContentBounds.Width - (autoWidth + CellSpacing) * (visibleColumns.Count - 1));
            }
        }
        private void UpdateRowHeights()
        {
            int autoHeight = (ContentBounds.Height + CellSpacing) / Rows.Count - CellSpacing;
            int count = Rows.Count - 1;
            for (int c = 0; c < count; c++)
            {
                Rows[c].SetHeight(autoHeight);
            }
            Rows[count].SetHeight(ContentBounds.Height - (autoHeight + CellSpacing) * count);
        }
        private void UpdateRowColumnPositions()
        {
            // position columns
            Point pt = Point.Empty;

            foreach (GridColumn col in Columns)
            {
                col.Location = pt;
                if (col.Visible)
                {
                    pt.Offset(col.Width, 0);
                }
                pt.X += CellSpacing;
            }

            // position rows
            pt = ContentBounds.Location;
            int width = (Columns.Count > 0) ? Columns.Last.Bounds.Right : 0;
            foreach (GridRow row in Rows)
            {
                row.Location = pt;
                row.SetWidth(width);
                pt.Offset(0, row.Height);
                pt.Y += CellSpacing;
            }
        }
    }

}
