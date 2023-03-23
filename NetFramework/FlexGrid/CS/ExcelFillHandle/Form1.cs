using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using C1.Win.C1FlexGrid;

namespace Win_Flex_ExcelLikeCopy
{
    public partial class Form1 : Form
    {
        CellRange startCell;
        CellRange endCell;

        // border info for dragged region
        SolidBrush _bdrBrush;
        int _bdrOutside;
        int _bdrInside;

        public Form1()
        {
            InitializeComponent();

            fg.DrawMode = DrawModeEnum.OwnerDraw;
            fg.AutoClipboard = true;

            fg.OwnerDrawCell += fg_OwnerDrawCell;
            fg.CursorChanged += fg_CursorChanged;
            fg.MouseMove += fg_MouseMove;
            fg.MouseDown += fg_MouseDown;
            fg.MouseUp += fg_MouseUp;
            fg.SelChange += fg_SelChange;

            _bdrBrush = new SolidBrush(Color.Red);
            _bdrOutside = 2;
            _bdrInside = 0;
        }

        void fg_CursorChanged(object sender, EventArgs e)
        {
            if (fg.Cursor == Cursors.Cross)
            {
                string str = "Start Dragging the mouse over the range to copy current cell data";
                toolTip1.Show(str, fg, fg.HitTest().Point, 5000);
                toolTip1.AutoPopDelay = 0;
            }
            else
            {
                toolTip1.Hide(this);
            }
        }

        /// <summary>
        /// Returns the DataType of the Data that has 
        /// to be Copied in the cells using the Fill Handle
        /// </summary>        
        public Type GetDataType(Object Data)
        {
            Type tp = typeof(string);

            int val;
            bool typeFlag = int.TryParse(Data.ToString(), out val);
            if (typeFlag)
                return typeof(int);

            DateTime dval;
            typeFlag = DateTime.TryParse(Data.ToString(), out dval);
            if (typeFlag)
                return typeof(DateTime);

            return tp;
        }

        /// <summary>
        /// Event used to finish up the Copying process
        /// Currently it handles only String, Int and DateTime values        
        /// </summary>        
        void fg_MouseUp(object sender, MouseEventArgs e)
        {
            if (fg.Cursor == Cursors.Cross)
                if (ModifierKeys == Keys.Control)
                {
                    C1.Win.C1FlexGrid.CellRange rg = fg.Selection;
                    Object data = startCell.Data;

                    if (data != null)
                    {
                        Type actualDataType = GetDataType(data);

                        int stepValue = 0;
                        int rowCount = 0;
                        int colCount = 0;

                        if (rg.r1 != rg.r2)
                        {
                            if (rg.r2 > rg.r1)
                            {
                                stepValue = 1;
                            }
                            else if (rg.r2 < rg.r1)
                            {
                                stepValue = -1;
                            }


                            if (stepValue == 1)
                            {
                                rowCount = rg.r2 - rg.r1;
                            }
                            else if (stepValue == -1)
                            {
                                rowCount = rg.r1 - rg.r2;
                            }
                        }
                        else
                        {
                            if (rg.c2 > rg.c1)
                            {
                                stepValue = 1;
                            }
                            else if (rg.c2 < rg.c1)
                            {
                                stepValue = -1;
                            }

                            if (stepValue == 1)
                            {
                                colCount = rg.c2 - rg.c1;
                            }
                            else if (stepValue == -1)
                            {
                                colCount = rg.c1 - rg.c2;
                            }
                        }


                        if (actualDataType == typeof(int))
                        {
                            int val;
                            bool typeFlag = int.TryParse(data.ToString(), out val);

                            if (rowCount > colCount)
                            {
                                for (int i = 1; i <= rowCount; i++)
                                {
                                    fg.SetData(rg.r1 + (i * stepValue), rg.c1, val + (i * stepValue));
                                }
                            }
                            else
                            {
                                for (int i = 1; i <= colCount; i++)
                                {
                                    fg.SetData(rg.r1, rg.c1 + (i * stepValue), val + (i * stepValue));
                                }
                            }

                        }
                        else if (actualDataType == typeof(DateTime))
                        {

                            // This function follows behavior similar to Excel
                            // When the DataTime value is Autofilled using Fill handle 
                            // feature, only the last part of the DateTime value is increased.
                            
                            DateTime val;
                            DateTime.TryParse(data.ToString(), out val);

                            string mainSubStr = data.ToString().Substring(0, data.ToString().LastIndexOf('/') + 1);
                            string lastSubStr = data.ToString().Substring(data.ToString().LastIndexOf('/') + 1);
                            int endVal = int.Parse(lastSubStr);


                            if (rowCount > colCount)
                            {
                                for (int i = 1; i <= rowCount; i++)
                                {
                                    int finalVal = endVal + (i * stepValue);
                                    string endStr = finalVal.ToString();
                                    if (finalVal.ToString().Length < lastSubStr.Length)
                                        endStr = "0" + endStr;
                                    fg.SetData(rg.r1 + (i * stepValue), rg.c1, mainSubStr + endStr);
                                }
                            }
                            else
                            {
                                for (int i = 1; i <= colCount; i++)
                                {
                                    int finalVal = endVal + (i * stepValue);
                                    string endStr = finalVal.ToString();
                                    if (finalVal.ToString().Length < lastSubStr.Length)
                                        endStr = "0" + endStr;

                                    fg.SetData(rg.r1, rg.c1 + (i * stepValue), mainSubStr + endStr);
                                }
                            }
                        }
                        else if (actualDataType == typeof(string))
                        {
                            rg.Data = startCell.Data;
                        }
                    }

                }
                else
                {
                    C1.Win.C1FlexGrid.CellRange rg = fg.Selection;
                    rg.Data = startCell.Data;
                }
        }

        /// <summary>
        /// Save the Master cell used for the Copying process
        /// </summary>        
        void fg_MouseDown(object sender, MouseEventArgs e)
        {
            int row = fg.HitTest(e.Location).Row;
            int col = fg.HitTest(e.Location).Column;
            startCell = fg.GetCellRange(row, col);
        }

        /// <summary>
        /// Mark the Cells for drawing Dragged Rectangle
        /// Cells are marked by setting the UserData property
        /// </summary>        
        void fg_SelChange(object sender, EventArgs e)
        {
            fg.Clear(ClearFlags.UserData);

            if (fg.Cursor == Cursors.Cross)
            {
                CellRange rg = fg.Selection;
                rg.UserData = "Border";
            }
        }

        /// <summary>
        /// This Event is used to Display the Cross cursor
        /// after making the calculation whehter the mouse pointer
        /// location is currently on bottom right edge of the Cell.
        /// </summary>        
        void fg_MouseMove(object sender, MouseEventArgs e)
        {
            // Rectangle for the Focused cell in the grid
            Rectangle currentCellRect = fg.GetCellRect(fg.Row, fg.Col);

            // Rectangular region at the bottom right corner of the cell.
            // Hovering mouse in this region will display Cross cursor.
            Rectangle crossHairRectangle = new Rectangle(currentCellRect.Right - 4, currentCellRect.Bottom - 4, 4, 4);

            // Store the latest Cell Range over which the mouse is currently moved
            endCell = fg.GetCellRange(fg.MouseRow, fg.MouseCol);

            if (fg.Capture)
            {
                // If mouse already down set Cross Cursor
                if (fg.Cursor == Cursors.Cross)
                {
                    fg.Cursor = Cursors.Cross;
                }
            }
            else
            {
                if (crossHairRectangle.Contains(e.Location))
                    fg.Cursor = Cursors.Cross;
                else
                    fg.Cursor = Cursors.Arrow;
            }
        }

        /// <summary>
        /// Show Border Margins on the Cells 
        /// covered by the Cross cursor.
        /// </summary>
        void fg_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            if (fg.IsCellHighlighted(e.Row, e.Col))
            {
                e.DrawCell();
                if (fg.Cursor == Cursors.Cross)
                {
                    // we only want cells with style set to "Border" 
                    if (fg.GetUserData(e.Row, e.Col).ToString() != "Border")
                        return;

                    // draw cell content as usual
                    e.DrawCell();

                    // get custom border widths for this cell
                    // (depends on neighbor cells)
                    Margins m = GetBorderMargins(e.Row, e.Col);

                    // draw custom borders
                    Rectangle rc;
                    Graphics g = e.Graphics;
                    if (m.Top > 0)
                    {
                        rc = e.Bounds;
                        rc.Height = m.Top;
                        g.FillRectangle(_bdrBrush, rc);
                    }
                    if (m.Left > 0)
                    {
                        rc = e.Bounds;
                        rc.Width = m.Left;
                        g.FillRectangle(_bdrBrush, rc);
                    }
                    if (m.Bottom > 0)
                    {
                        rc = e.Bounds;
                        rc.Y = rc.Bottom - m.Bottom;
                        rc.Height = m.Bottom;
                        g.FillRectangle(_bdrBrush, rc);
                    }
                    if (m.Right > 0)
                    {
                        rc = e.Bounds;
                        rc.X = rc.Right - m.Right;
                        rc.Width = m.Right;
                        g.FillRectangle(_bdrBrush, rc);
                    }
                    fg.Invalidate();
                }
            }
        }

        /// <summary>
        ///calculate border widths taking neighbor cells into account 
        /// </summary>
        Margins _m = new Margins(0, 0, 0, 0);
        private Margins GetBorderMargins(int row, int col)
        {
            // initialize return value
            _m.Left = _m.Right = _m.Top = _m.Bottom = 0;

            // check whether this cell has a border
            CellRange rg = fg.GetCellRange(row, col);
            if (rg.UserData.ToString() != "Border")
                return _m;

            // check whether this cell is at the top of the range
            _m.Top = _bdrOutside;
            if (row > fg.Rows.Fixed)
            {
                rg.r1 = rg.r2 = row - 1;
                if (rg.UserData != null && rg.UserData.ToString() == "Border")
                {
                    _m.Top = 0;
                }
                rg.r1 = rg.r2 = row;
            }

            // check whether this cell is at the left of the range
            _m.Left = _bdrOutside;
            if (col > fg.Cols.Fixed)
            {
                rg.c1 = rg.c2 = col - 1;
                if (rg.UserData != null && rg.UserData.ToString() == "Border")
                {
                    _m.Left = 0;
                }
                rg.c1 = rg.c2 = col;
            }

            // check whether this cell is at the bottom of the range
            _m.Bottom = _bdrOutside;
            if (row < fg.Rows.Count - 1)
            {
                rg.r1 = rg.r2 = row + 1;
                if (rg.UserData != null && rg.UserData.ToString() == "Border")
                    _m.Bottom = _bdrInside;
                rg.r1 = rg.r2 = row;
            }

            // check whether this cell is at the right of the range
            _m.Right = _bdrOutside;
            if (col < fg.Cols.Count - 1)
            {
                rg.c1 = rg.c2 = col + 1;
                if (rg.UserData != null && rg.UserData.ToString() == "Border")
                {
                    _m.Right = _bdrInside;
                }
                rg.c1 = rg.c2 = col;
            }

            // done
            return _m;
        }
    }
}
