using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ControlExplorer.Controls
{
    public partial class CompanyInfo : UserControl
    {
        public CompanyInfo()
        {
            InitializeComponent();
            LoadCompanyPhoneNo();
        }
        private void LoadCompanyPhoneNo()
        {
            //todo: need to check how to pick xml file
            //string xmlContent = Resources.ContactInfo;
            string xmlContent = "ControlExplorer.Resources.ContactInfo.xml";

            XDocument xDocument = XDocument.Parse(xmlContent);

            var elements = xDocument.Descendants("Contact").ToList();

            foreach (var element in elements)
            {
                var country = element.Attribute("Country")!.Value;
                CultureInfo culture = CultureInfo.CurrentCulture;
                if (country == culture.EnglishName)
                {
                    var currentRegion = element.Attribute("Phone").Value;
                    lblPhoneNo.Text = currentRegion.ToString();
                    break;
                }

            }
        }
    }
}
