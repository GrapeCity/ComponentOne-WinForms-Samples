using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using C1.DataCollection;
using C1.DataFilter;
using C1.Win.DataFilter;
using C1.Win.Input;
using DataFilterExplorer.Data;


namespace DataFilterExplorer.Samples
{
    public partial class FilterEditor : UserControl
    {
        private const string xmlFileName = "FilterExpression.xml";
        private string pathToXmlFile = null;
        public FilterEditor()
        {
            InitializeComponent();
            filterEditor.CustomEditorInitializing += FilterEditor_CustomEditorInitializing;
        }

        private void FilterEditorSample_Load(object sender, EventArgs e)
        {
            ApplyDataSource();
            ApplyFilter();
        }

        private void ApplyDataSource()
        {
            var dt = DataService.GetDataSource();
            flexGrid.DataSource = dt;
            filterEditor.DataSource = dt;
        }

        private void ApplyFilter()
        {
            pathToXmlFile = Directory.GetCurrentDirectory() + "\\" + xmlFileName;
            CombinationExpression filterExpression = null;

            if (!File.Exists(pathToXmlFile))
            {
                filterExpression = GetPredefinedFilter();
            }
            else
            {
                filterExpression = LoadFilterFromFile(pathToXmlFile);
            }

            filterEditor.SetExpression(filterExpression);
            filterEditor.ApplyFilterAsync();
        }

        private static CombinationExpression GetPredefinedFilter()
        {
            var filterExpression = new CombinationExpression();

            var filterExpressions = filterExpression.Expressions;

            var hpGreaterThen200Expression = new OperationExpression()
            {
                PropertyName = "HP",
                FilterOperation = FilterOperation.GreaterThanOrEqual,
                Value = 200
            };
            filterExpressions.Add(hpGreaterThen200Expression);

            var automaticTransmissionExpression = new OperationExpression()
            {
                PropertyName = "AutomaticTransmission",
                FilterOperation = FilterOperation.Equal,
                Value = true
            };
            filterExpressions.Add(automaticTransmissionExpression);

            var sportsCategoryExpression = new OperationExpression()
            {
                PropertyName = "StartSaleDate",
                FilterOperation = FilterOperation.GreaterThanOrEqual,
                Value = new DateTime(2011, 1, 1)
            };
            filterExpressions.Add(sportsCategoryExpression);

            var brandOrExpression = new CombinationExpression();
            brandOrExpression.FilterCombination = FilterCombination.Or;

            var brandExpressions = brandOrExpression.Expressions;

            var brandEqualMercedesBenzExpression = new OperationExpression()
            {
                PropertyName = "Brand",
                FilterOperation = FilterOperation.EqualText,
                Value = "Mercedes-Benz"
            };
            brandExpressions.Add(brandEqualMercedesBenzExpression);

            var brandEqualAudiExpression = new OperationExpression()
            {
                PropertyName = "Brand",
                FilterOperation = FilterOperation.EqualText,
                Value = "Audi"
            };
            brandExpressions.Add(brandEqualAudiExpression);

            filterExpressions.Add(brandOrExpression);

            return filterExpression;
        }

        private CombinationExpression LoadFilterFromFile(string filePath)
        {
            CombinationExpression filterExpression;
            var xmlSerializer = new XmlSerializer(typeof(CombinationExpression));
            using (var fs = File.Open(filePath, FileMode.Open))
            {
                filterExpression = xmlSerializer.Deserialize(fs) as CombinationExpression;
            }

            return filterExpression;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            filterEditor.ApplyFilterAsync();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            filterEditor.ClearFilter();
            filterEditor.ApplyFilterAsync();
        }

        private void filterEditor_FilterChanged(object sender, EventArgs e)
        {
            SaveFilterToFile(pathToXmlFile);
        }

        private void SaveFilterToFile(string filePath)
        {
            var expression = filterEditor.GetExpression();
            var xmlSerializer = new XmlSerializer(typeof(CombinationExpression));
            using (var fs = File.Create(filePath))
            {
                xmlSerializer.Serialize(fs, expression);
            }
        }

        private void FilterEditor_CustomEditorInitializing(object sender, CustomEditorEventArgs e)
        {
            if (e.PropertyName == "Brand")
            {
                var cmb = new C1ComboBox() { AutoSize = false, Width = 150 };
                cmb.ItemsDataSource = DataService.GetDataSource();
                cmb.ItemsValueMember = "Brand";
                cmb.ItemsDisplayMember = "Brand";
                cmb.EmptyAsNull = true;
                e.Control = cmb;
            }
        }
    }
}
