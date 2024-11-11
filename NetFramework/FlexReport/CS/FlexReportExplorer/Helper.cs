using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace FlexReportExplorer
{
    public class Helper
    {
        public static GraphicsPath GetRoundedCornerPath (Rectangle rect, int radius) { 
            GraphicsPath path = new GraphicsPath ();
            path.StartFigure ();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top left corner
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top right corner
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90); // Bottom right corner
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90); // Bottom left corner

            path.CloseFigure ();

            return path;
        }

        public enum Roles
        {
            parent,
            child,
        }

        public static Color GetContrastingForeColor(Color backgroundColor)
        {
            // Calculate the brightness of the background color
            int brightness = (int)((backgroundColor.R * 0.299) + (backgroundColor.G * 0.587) + (backgroundColor.B * 0.114));

            // Return white for dark backgrounds, black for light backgrounds
            return brightness < 128 ? Color.White : Color.Black; // You can also use Color.DarkGray or other colors as needed
        }

        public static int AccordionNodeCount(ControlCollection nodes) { 
            int count = 0;
            foreach (Control node in nodes) { 
                if(node is AccordionNode) count++;
            }
            return count;
        }
    }
}