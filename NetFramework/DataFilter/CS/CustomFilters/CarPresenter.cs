using C1.Framework;
using C1.Win.TreeView;
using CustomFilters.Model;
using CustomFilters.ViewModel;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;

namespace CustomFilters
{
    public class CarPresenter : CustomContentPresenter
    {        
        private CarViewElement _carViewElement = new CarViewElement();
        private StoreViewElement _storeViewElement = new StoreViewElement();

        public CarPresenter()
        {
            
        }

        public override string ToolTipText => string.Empty;

        public override void SetFormat(string format)
        {
            
        }        

        public override void SetValue(object value)
        {
            if (Node.Level == 0)
            {
                _carViewElement.SetValue((CarView)Node.GetValue());
                // set root panel
                Child = _carViewElement;
            }
            else
            {
                _storeViewElement.SetValue((CountInStore)Node.GetValue());
                // set root panel
                Child = _storeViewElement;
            }
        }
    }

    public class CarViewElement:RowPanel
    {
        private ImageElement _img = new ImageElement();
        private ColorsElement _colors = new ColorsElement();
        private TextElement _model = new TextElement();
        private TextElement _brand = new TextElement();
        private TextElement _liter = new TextElement();
        private TextElement _transmiss = new TextElement();
        private TextElement _category = new TextElement();
        private TextElement _price = new TextElement();
        private TextElement _count = new TextElement();

        public CarViewElement()
        {
            InitStyles();
            _img.Size = new Size(130, 130);

            // first column
            var cp1 = new ColumnPanel();
            cp1.Children.Add(_img);
            cp1.Children.Add(_colors);
            // second column
            var cp2 = new ColumnPanel();
            cp2.Children.Add(_model);
            cp2.Children.Add(_brand);
            cp2.Children.Add(_liter);
            cp2.Children.Add(_transmiss);
            cp2.Children.Add(_category);
            // third column
            var cp3 = new ColumnPanel();
            cp3.Children.Add(_price);
            cp3.Children.Add(_count);

            // row with three columns            
            Children.Add(cp1);
            Children.Add(cp2);
            Children.Add(cp3);
        }

        public void SetValue(CarView carView)
        {
            _model.Text = carView.Model;
            _brand.Text = $"Brand: {carView.Brand}";
            _liter.Text = $"Liter: {carView.Liter.ToString()}";
            _transmiss.Text = $"Automatic transmission: {carView.TransmissAutomatic}";
            _category.Text = $"Category: {carView.Category}";
            _price.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", carView.Price);
            _count.Text = $"Total number in stores: {carView.Count}";

            var converter = new ImageConverter();
            if (_img.Image != null)
            {
                _img.Image.Dispose();
                _img.Image = null;
            }
            _img.Image = (Image)converter.ConvertFrom(carView.Picture);

            _colors.SetColors(carView.Stores.GroupBy(x => x.Color).Select(x => x.Key));
        }

        private void InitStyles()
        {
            Style = new Style
            {
                VerticalAlignment = Alignment.Near,
                ChildSpacing = new Size(10, 0)
            };

            _model.Style = new Style
            {
                Margins = new Thickness(3),
                Font = new Font("Calibri", 14, FontStyle.Bold)
            };

            _brand.Style = new Style
            {
                Margins = new Thickness(3),
                Font = new Font("Calibri", 11),
                WordWrap = false
            };

            _liter.Style = new Style();
            _liter.Style.Copy(_brand.Style);

            _transmiss.Style = new Style();
            _transmiss.Style.Copy(_brand.Style);

            _category.Style = new Style();
            _category.Style.Copy(_brand.Style);

            _price.Style = new Style();
            _price.Style.Copy(_model.Style);

            _count.Style = new Style();
            _count.Style.Copy(_brand.Style);

            _img.Style = new Style
            {
                ImageScaling = ImageScaling.Scale,
                ImageAlignment = ImageAlignment.CenterCenter
            };
        }

        private class ColorsElement : RowPanel
        {
            public ColorsElement()
            {
                Style = new Style();
                Style.ChildSpacing = new Size(4, 0);
                Style.Padding = new Thickness(0, 4);
                Style.VerticalAlignment = Alignment.Center;
            }

            public void SetColors(IEnumerable<Color> colors)
            {
                Children.Clear();
                foreach (var color in colors)
                {
                    var e = new CircleElement();
                    e.Style.BackColor = color;

                    Children.Add(e);
                }
            }

            private class CircleElement : Element, IToolTipElement
            {
                public CircleElement()
                {
                    Size = new Size(16, 16);
                    Style = new Style();
                    HitTestable = true;
                }

                public string ToolTipText => Style.BackColor.Name;

                public override void Render(Graphics g, Rectangle r)
                {
                    var im = g.InterpolationMode;
                    var sm = g.SmoothingMode;

                    g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    using (var brush = new SolidBrush(Style.BackColor))
                        g.FillEllipse(brush, new Rectangle(r.X + 2, r.Y + 2, Width - 4, Height - 4));

                    g.InterpolationMode = im;
                    g.SmoothingMode = sm;
                }
            }
        }
    }

    public class StoreViewElement: RowPanel
    {
        private TextElement _store = new TextElement();
        private TextElement _count = new TextElement();
        private ColorElement _color = new ColorElement();

        public StoreViewElement()
        {
            InitStyles();
            _store.Width = 150;
            Children.Add(_store);
            _count.Width = 150;
            Children.Add(_count);
            _color.Size = new Size(50, 15);
            Children.Add(_color);
        }

        internal void SetValue(CountInStore countInStore)
        {
            _store.Text = $"Store: {countInStore.Store.City}";
            _count.Text = $"Number of cars: {countInStore.Count}";
            _color.Style.BackColor = countInStore.Color;
        }

        private void InitStyles()
        {
            Style = new Style
            {
                VerticalAlignment = Alignment.Center,
                ChildSpacing = new Size(10, 10),
                Margins = new Thickness(5)
            };

            _store.Style = new Style
            {
                Margins = new Thickness(3),
                Font = new Font("Calibri", 11),
                WordWrap = false                
            };            

            _count.Style = new Style();
            _count.Style.Copy(_store.Style);

            _color.Style = new Style();
        }

        private class ColorElement : Element, IToolTipElement
        {
            public ColorElement()
            {
                HitTestable = true;
            }

            public string ToolTipText => Style.BackColor.Name;
        }
    }
}
