using System.Drawing.Drawing2D;
using System.Text;

namespace FlexGridExplorer.Utility
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Flattens the given collection 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static IEnumerable<T> SelectManyRecursive<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>> selector)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");

            foreach (T item in source)
            {
                var children = selector(item);
                if (children.IsNullOrEmpty())
                    yield return item;
                else
                    foreach (T descendant in children.SelectManyRecursive(selector))
                    {
                        yield return descendant;
                    }
            }
        }

        public static T GetNext<T>(this IEnumerable<T> list, T current)
        {
            try
            {
                return list.SkipWhile(x => !x.Equals(current)).Skip(1).First();
            }
            catch
            {
                return default(T);
            }
        }

        public static T GetPrevious<T>(this IEnumerable<T> list, T current)
        {
            try
            {
                return list.TakeWhile(x => !x.Equals(current)).LastOrDefault();
            }
            catch
            {
                return default(T);
            }
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || collection.Count() == 0;
        }

        public static void Clear(this Control.ControlCollection controls, bool dispose)
        {
            for (int ix = controls.Count - 1; ix >= 0; --ix)
            {
                if (dispose) controls[ix].Dispose();
                else controls.RemoveAt(ix);
            }
        }

        public static string TrimLines(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            var lines = input.Split(new string[] { "\n" }, StringSplitOptions.None);
            var sb = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                sb.AppendLine(line.Trim());
            }
            return sb.ToString();
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(this System.Windows.Forms.Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(this System.Windows.Forms.Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, true, 0);
            control.Refresh();
        }

        public static GraphicsPath RoundedRect(this RectangleF bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            RectangleF arc = new RectangleF(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, RectangleF bounds, int cornerRadius)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (pen == null)
                throw new ArgumentNullException("pen");

            using (GraphicsPath path = bounds.RoundedRect(cornerRadius))
            {
                graphics.DrawPath(pen, path);
            }
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, RectangleF bounds, int cornerRadius)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (brush == null)
                throw new ArgumentNullException("brush");

            using (GraphicsPath path = bounds.RoundedRect(cornerRadius))
            {
                graphics.FillPath(brush, path);
            }
        }
    }
}
