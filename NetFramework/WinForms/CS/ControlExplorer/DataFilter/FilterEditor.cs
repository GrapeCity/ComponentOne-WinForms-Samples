using C1.DataCollection;
using C1.DataFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ControlExplorer.DataFilter
{
    public partial class FilterEditor : C1DemoForm
    {
        private const string xmlFileName = "FilterExpression.xml";
        private string pathToXmlFile = null;

        public FilterEditor()
        {
            InitializeComponent();
        }

        private void FilterEditor_Load(object sender, EventArgs e)
        {
            ApplyDataSource();
            ApplyFilter();
        }

        private void ApplyDataSource()
        {
            var dt = Data.GetDataSource();
            c1FlexGrid1.DataSource = dt;
            c1FilterEditor1.DataSource = dt;
        }

        private async void ApplyFilter()
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

            c1FilterEditor1.SetExpression(filterExpression);
            await c1FilterEditor1.ApplyFilterAsync();
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
            c1FilterEditor1.ApplyFilterAsync();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            c1FilterEditor1.ClearFilter();
            c1FilterEditor1.ApplyFilterAsync();
        }

        private void c1FilterEditor1_FilterChanged(object sender, EventArgs e)
        {
            SaveFilterToFile(pathToXmlFile);
        }

        private void SaveFilterToFile(string filePath)
        {
            var expression = c1FilterEditor1.GetExpression();
            var xmlSerializer = new XmlSerializer(typeof(CombinationExpression));
            using (var fs = File.Create(filePath))
            {
                xmlSerializer.Serialize(fs, expression);
            }
        }
    }
}
