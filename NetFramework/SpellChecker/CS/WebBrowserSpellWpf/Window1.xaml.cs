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
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace WebBrowserSpellWpf
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
            webBrowser.NavigateToString("<html><body contentEditable=\"true\">Some missplled text.<body></html>");
            _spell = new C1.Win.SpellChecker.C1SpellChecker();

            // Get IWebBrowser2 interface using reflection
            Type t = webBrowser.GetType();
            PropertyInfo pi = t.GetProperty("AxIWebBrowser2", BindingFlags.NonPublic | BindingFlags.Instance);
            object axBrowser = pi.GetValue(webBrowser, null);


            // Use a dummy windows forms control to as the first parameter.
            _spell.SetActiveSpellChecking(new System.Windows.Forms.Label(), axBrowser, true);
            // or
            //_spell.CheckControl(new System.Windows.Forms.Label(), axBrowser);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
        }

        private C1.Win.SpellChecker.C1SpellChecker _spell;

    }
}
