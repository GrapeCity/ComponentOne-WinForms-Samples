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

namespace HelloWorld
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            C1PrintDocument doc = new C1PrintDocument();
#if plain
            doc.Body.Children.Add(new C1.C1Preview.RenderText("Hello, World!"));
#else
            doc.Body.Children.Clear();
            RenderText rt = new RenderText("Hello, World!");
            rt.X = "2in";
            rt.Y = "3in";
            rt.Width = "4in";
            rt.Height = "3in";
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.FontName = "Arial";
            rt.Style.FontSize = 14;
            rt.Style.TextColor = Colors.Red;
            rt.Style.BackColor = Colors.PowderBlue;
            rt.Style.TextAlignHorz = AlignHorzEnum.Center;
            rt.Style.TextAlignVert = AlignVertEnum.Center;
            doc.Body.Children.Add(rt);
#endif
            c1DocumentViewer1.FitToWidth();
            c1DocumentViewer1.Document = doc.FixedDocumentSequence;
        }
    }
}
