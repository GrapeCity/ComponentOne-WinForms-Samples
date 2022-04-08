using System;
using C1.Win.Layout;

namespace DashboardDemo.Controls
{
    public class FilePathEventArgs : EventArgs
    {
        public FilePathEventArgs(string path) : base()
        {
            FilePath = path;
        }

        public string FilePath { get; private set; }
    }

    public class LayoutTypeEventArgs : EventArgs
    {
        public LayoutTypeEventArgs(LayoutType type) : base()
        {
            Type = type;
        }

        public LayoutType Type { get; private set; }
    }
    public class ToolIconAppearanceEventArgs : EventArgs
    {
        public ToolIconAppearanceEventArgs(ToolIconAppearance tia) : base()
        {
            ToolIconAppearance = tia;
        }

        public ToolIconAppearance ToolIconAppearance { get; private set; }
    }
}
