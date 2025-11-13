using C1.Diagram;
using C1.Win.Chart;
using C1.Win.Diagram;
using DiagramExplorer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiagramExplorer.Samples
{
    internal partial class Samples
    {
        static Data.DataService dataService = new Data.DataService();

        public static Control CreateOrgChart(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram();
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;

            var data = dataService.GetOrgChartData();

            var nodeStyle = new ChartStyle() { Font = new Font("Segoe UI", 12), };
            var nodeContentStyle = new ChartStyle()
            {
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                StrokeWidth = 0f,
            };

            var headerStyle = new ChartStyle()
            {
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                StrokeWidth = 0f,
            };

            diagram.Legend.Position = C1.Chart.Position.None;
            diagram.NodeCreated += (s, a) =>
            {
                var orgNode = a.Data as OrgNode;
                var node = a.Node as C1.Win.Diagram.Node;

                if (orgNode == null || node == null)
                    return;

                if (!string.IsNullOrEmpty(orgNode.FirstName))
                {
                    node.Title = $"{orgNode.FirstName}\n{orgNode.LastName}";
                    node.Content = orgNode.JobTitle;

                    node.TitleImage = orgNode.Image;
                    node.TitleImageSize = new Size(60, 80);
                    node.TitleStyle = nodeStyle;
                    node.Style = nodeContentStyle;
                }
                else
                {
                    node.Title = orgNode.Name;
                    node.Style = headerStyle;
                }

                node.LegendItem = orgNode.Department;
                node.Shape = C1.Diagram.Shape.RoundedRectangle;
            };

            diagram.DataSource = data;
            diagram.Binding = "Name";
            diagram.ChildItemsPath = "Childs";
            diagram.ScaleMode = C1.Diagram.ScaleMode.ScaleToFit;

            return diagram;
        }
    }
}
