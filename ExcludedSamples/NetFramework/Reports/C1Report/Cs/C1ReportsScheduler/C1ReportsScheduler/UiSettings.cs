using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace C1ReportsScheduler
{
    public class UiSettings
    {
        public Point Location;
        public Size Size;
        public int TaskPanelHeight;
        public List<int> TaskColsWidths = new List<int>();
        public List<int> ActionColsWidths = new List<int>();
        public Rectangle HelpFormBounds = Rectangle.Empty;
        public Rectangle LogFormBounds = Rectangle.Empty;
        public bool ShowLogForm = false;

        public UiSettings()
        {
        }
    }
}
