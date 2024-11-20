using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace C1RibbonBasedApp
{
    //temporary fix for apprearance of blue strip of on active buttons.
    public class C1NavBarHighLight : C1NavBar
    {
        private int hoveredButtonIndex = -1;
        private int pressedButtonIndex = -1;

        public C1NavBarHighLight()
        {
            this.MouseMove += C1NavBarNew_MouseMove;
            this.MouseLeave += C1NavBarNew_MouseLeave;
            this.MouseDown += C1NavBarNew_MouseDown;
            this.MouseUp += C1NavBarNew_MouseUp;
        }

        private void C1NavBarNew_MouseMove(object sender, MouseEventArgs e)
        {
            int newHoveredIndex = GetButtonIndexAtPoint(e.Location);
            if (newHoveredIndex != hoveredButtonIndex)
            {
                hoveredButtonIndex = newHoveredIndex;
                Invalidate(); // Redraw on hover change
            }
        }

        private void C1NavBarNew_MouseLeave(object sender, EventArgs e)
        {
            hoveredButtonIndex = -1;
            Invalidate(); // Redraw when mouse leaves
        }

        private void C1NavBarNew_MouseDown(object sender, MouseEventArgs e)
        {
            pressedButtonIndex = GetButtonIndexAtPoint(e.Location);
            Invalidate(); // Redraw on press
        }

        private void C1NavBarNew_MouseUp(object sender, MouseEventArgs e)
        {
            int clickedButtonIndex = GetButtonIndexAtPoint(e.Location);

            if (clickedButtonIndex != -1)
            {
                this.SelectedButtonIndex = clickedButtonIndex; // Update the selected button using C1NavBar's property
            }

            pressedButtonIndex = -1;
            Invalidate(); // Redraw on release
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < this.Buttons.Count; i++)
            {
                if (this.Buttons[i] is C1NavBarButton button)
                {
                    Rectangle buttonRect = GetButtonBounds(i);

                    // Draw custom highlight background
                    if (i == hoveredButtonIndex || i == pressedButtonIndex || i == this.SelectedButtonIndex)
                    {
                      

                        // Draw the blue indicator line on the left side of the button
                        using (Pen roundedPen = new Pen(ColorTranslator.FromHtml("#005FB8"), 5))
                        {
                            roundedPen.StartCap = LineCap.Round;
                            roundedPen.EndCap = LineCap.Round;
                            roundedPen.LineJoin = LineJoin.Round;

                            int lineStartX = buttonRect.Left + 5; // Adjust position if needed
                            int lineStartY = buttonRect.Top + 8;
                            int lineEndY = buttonRect.Top + buttonRect.Height - 10; // Shorten line slightly for a centered look

                            e.Graphics.DrawLine(roundedPen, lineStartX, lineStartY, lineStartX, lineEndY);
                        }
                    }
                }
            }
        }

        private Rectangle GetButtonBounds(int buttonIndex)
        {
            int buttonPosition = (this.Buttons.Count - buttonIndex) + 1;
            
            int buttonYPosition = this.ClientSize.Height - Style.Button.Height * (buttonPosition);
            if (buttonIndex > 0)
            {
                buttonYPosition +=4;
            }
            return new Rectangle(0, buttonYPosition, this.ClientSize.Width, Style.Button.Height);
        }

        private int GetButtonIndexAtPoint(Point location)
        {
            for (int i = 0; i < this.Buttons.Count; i++)
            {
                if (this.Buttons[i] is C1NavBarButton button && GetButtonBounds(i).Contains(location))
                {
                    return i;
                }
            }
            return -1; // No button found at the location
        }
    }
}
