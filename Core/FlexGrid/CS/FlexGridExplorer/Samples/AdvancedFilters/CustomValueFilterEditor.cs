using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples.AdvancedFilters
{
    public partial class CustomValueFilterEditor : ValueFilterEditor
    {
        private Size _size;

        public CustomValueFilterEditor()
        {
            InitializeComponent();

            _size = Size;
            Layout += CustomValueFilterEditor_Layout;
        }

        private void CustomValueFilterEditor_Layout(object sender, LayoutEventArgs e)
        {
            Size = _size;
        }
    }
}
