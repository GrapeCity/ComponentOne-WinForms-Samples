using C1.Diagram;
using C1.Diagram.Parser;
using C1.Win.Diagram;
using DiagramExplorer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramExplorer.Samples
{
    internal partial class Samples
    {
        public static Control CreateAnimalsDiagram(Color foreColor, Color backColor)
        {
            var diagram = new FlexDiagram();// { Direction = DiagramDirection.LeftRight };
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;

            var animals = Data.AnimalData.GetAnimals();

            diagram.NodeCreated += (s, args) =>
            {
                var node = (C1.Win.Diagram.Node)args.Node;
                var animal = args.Data as Animal;

                node.Title = animal!=null ? animal.Name : args.Data.ToString();

                if (animal != null && animal.Image != null)
                {
                    node.TitleImage = animal.Image;
                    node.TitleImageSize = new Size(64, 64);
                    node.TitleDirection = C1.Chart.Direction.Vertical;
                }

                node.Shape = Shape.RoundedRectangle;
                node.LegendItem = args.ParentNode == null ? args.Data?.ToString() : args.ParentNode.LegendItem;
            };

            diagram.DataSource = animals;
            diagram.Binding = "Phylum,Class,Order,Name";
            diagram.Legend.Position = C1.Chart.Position.None;
            diagram.ScaleMode = ScaleMode.ScaleToFit;

            return diagram;
        }

    }
}
