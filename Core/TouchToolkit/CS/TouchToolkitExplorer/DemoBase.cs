using System.ComponentModel;
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

        [DefaultValue(null)]
        public string Title { get; set; }
        
        [DefaultValue(null)]
        public string Description { get; set; }
    }
}
