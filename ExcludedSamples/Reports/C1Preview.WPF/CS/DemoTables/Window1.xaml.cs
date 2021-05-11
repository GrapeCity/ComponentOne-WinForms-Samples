using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using C1.C1Preview;

namespace DemoTables
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnMakeATable_Click(object sender, RoutedEventArgs e)
        {
            C1PrintDocument doc = null;
            if (sender == btnBasicTable)
                doc = MakeDocHelper.BasicTable();
            else if (sender == btnStylesInTables)
                doc = MakeDocHelper.StylesInTables();
            else if (sender == btnWideTables)
                doc = MakeDocHelper.WideTable();
            else if (sender == btnTextStyles)
                doc = MakeDocHelper.TextStyles();
            else if (sender == btnLargeTable)
                doc = MakeDocHelper.LargeTable(800, 4);
            else if (sender == btnTableBorders)
                doc = MakeDocHelper.TableBorders();

            c1DocumentViewer1.FitToWidth();
            c1DocumentViewer1.Document = doc.FixedDocumentSequence;
        }
    }
}
