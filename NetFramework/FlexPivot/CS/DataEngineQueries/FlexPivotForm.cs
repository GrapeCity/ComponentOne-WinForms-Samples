using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DataEngineQueries
{
    public partial class FlexPivotForm : Form
    {
        public FlexPivotForm()
        {
            InitializeComponent();
        }

        public C1.Win.FlexPivot.C1FlexPivotPanel FlexPivot { get { return _c1FlexPivotPage.FlexPivotPanel; } }
    }
}
