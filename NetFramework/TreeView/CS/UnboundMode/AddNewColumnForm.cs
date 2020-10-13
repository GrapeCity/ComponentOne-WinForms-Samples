using System.Windows.Forms;

namespace UnboundMode
{
    public partial class AddNewColumnForm : Form
    {
        public AddNewColumnForm()
        {
            InitializeComponent();
        }

        public string ColumnName
        {
            get { return tbName.Text; }
        }

        public string ColumnHeaderText
        {
            get { return tbHeaderText.Text; }
        }

        public string ColumnDisplayFieldName
        {
            get { return tbDisplayFieldName.Text; }
        }
    }
}
