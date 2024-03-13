using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ControlExplorer.Controls
{
    public partial class HomeNavigation : UserControl
    {
        public HomeNavigation()
        {
            InitializeComponent();
            lblPromo.Text = Explorer.SuiteDescription;
            InitializeCategories();
        }

        private void InitializeCategories()
        {
            var cat1 = new CategoryControl("NEW CONTROLS\r\n&& FEATURES", "new", Color.FromArgb(242, 242, 243), Color.FromArgb(226, 226, 225), 26);
            cat1.Location = new Point(0, 0);
            cat1.Width = this.Width;

            var cat2 = new CategoryControl("TOP CONTROLS", "top", Color.FromArgb(242, 242, 243), Color.FromArgb(226, 226, 225), 26);
            cat2.Location = new Point(0, cat1.Height);
            cat2.Width = this.Width;

            pnlFeaturedTiles.Controls.Add(cat2);
            pnlFeaturedTiles.Controls.Add(cat1);
        }

        static Image ReadEmbeddedRessourceImage(Assembly assembly, string searchPattern)
        {
            var resourceName = assembly.GetManifestResourceNames().FirstOrDefault(x => x.Contains(searchPattern));
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null) return Image.FromStream(stream);
            }
            return null;
        }
    }
}
