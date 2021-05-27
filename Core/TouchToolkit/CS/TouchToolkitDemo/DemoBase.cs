using System.Windows.Forms;

namespace TouchToolkitDemo
{
    public partial class DemoBase : UserControl
    {
        public DemoBase()
        {
            InitializeComponent();
            Title = GetType().Name;
        }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string Description
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }
    }
}
