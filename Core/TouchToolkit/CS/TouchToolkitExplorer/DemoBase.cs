using System.Windows.Forms;

namespace TouchToolkitExplorer
{
    public partial class DemoBase : UserControl
    {
        public DemoBase()
        {
            InitializeComponent();
            Title = GetType().Name;
        }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
