using C1.DataCollection;
using C1.DataFilter;
using C1.FlexMap;
using C1.Win.DataFilter;
using C1.Win.Map;
using CustomFilters.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomFilters
{
    public class MapFilter : CustomFilter
    {
        private MapFilterView _mapFilterView;

        public MapFilter()
        {
            _mapFilterView = new MapFilterView
            {
                Height = 200
            };
            _mapFilterView.SelectedChanged += MapFilterView_SelectedChanged;
            Control = _mapFilterView;
        }

        private void MapFilterView_SelectedChanged(object sender, EventArgs e) => OnValueChanged(new ValueChangedEventArgs() { ApplyFilter = true });

        public void SetStores(IEnumerable<Store> stores) => _mapFilterView.SetStores(stores);

        protected override Expression GetExpression()
        {
            var stores = _mapFilterView.GetSelectedStores();
            var expr = new CombinationExpression() { FilterCombination = FilterCombination.Or };
            foreach (var store in stores)
            {
                expr.Expressions.Add(new OperationExpression() { Value = store.ID, FilterOperation = FilterOperation.Equal, PropertyName = PropertyName });
            }
            return expr;
        }

        protected override void SetExpression(Expression expression)
        {
            
        }

        public override bool IsApplied => base.IsApplied && _mapFilterView.GetSelectedStores().Count() > 0;
    }

    public class MapFilterView: UserControl
    {
        private C1Map _map;
        private C1.Win.Map.VectorLayer _layer;
        private C1.Win.Map.VectorLayer _selectedLayer;
        private List<Store> _stores;

        public MapFilterView()
        {
            _map = new C1Map();
            _map.UseAntiAliasedGraphics = true;            
            _map.Dock = DockStyle.Fill;
            _map.TileLayer.TileSource = new VirtualEarthRoadSource();
            _map.ZoomTool.Visible = false;
            _map.PanTool.Visible = false;
            _map.Viewport.Zoom = 2.15;
            _map.AllowZooming = false;
            _map.Viewport.Center = new C1.Win.Interop.Point(-80.8, 39.8);            

            _map.MouseClick += Map_MouseClick;

            _layer = new C1.Win.Map.VectorLayer { LabelVisibility = LabelVisibility.AutoHide };
            _layer.Style.BackColor = Color.FromArgb(0x80, Color.Green);
            _layer.Style.Stroke.Color = Color.FromArgb(0x80, Color.White);
            _layer.Style.Stroke.Width = 1;
            _map.Layers.Add(_layer);

            _selectedLayer = new C1.Win.Map.VectorLayer { LabelVisibility = LabelVisibility.AutoHide };
            _selectedLayer.LabelStyle.ForeColor = Color.FromArgb(0xC0, 0x50, 0x4d);
            _selectedLayer.Style.BackColor = Color.FromArgb(0x80, Color.Gold);
            _selectedLayer.Style.Stroke.Color = Color.FromArgb(0x80, Color.White);
            _selectedLayer.Style.Stroke.Width = 1;
            _map.Layers.Add(_selectedLayer);

            Controls.Add(_map);
        }

        public IEnumerable<Store> GetSelectedStores()
        {
            return _stores.Where(store =>
                _selectedLayer.Items.Cast<C1.Win.Map.VectorPlacemark>().Count(
                    x => Math.Abs(x.Geometry.Center.X - store.Location.X) < 1 && Math.Abs(x.Geometry.Center.Y - store.Location.Y) < 1 && x.Marker.Caption == store.City
                ) > 0);
        }

        public event EventHandler SelectedChanged;        

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            var point = _map.ScreenToGeographic(e.Location);

            var selectedStore = FindShop(point, _selectedLayer);
            if (selectedStore != null)
            {
                _selectedLayer.Items.Remove(selectedStore);
                _layer.Items.Add(selectedStore);
                SelectedChanged?.Invoke(this, e);
            }
            else
            {
                var store = FindShop(point, _layer);
                if (store != null)
                {
                    _layer.Items.Remove(store);
                    _selectedLayer.Items.Add(store);
                    SelectedChanged?.Invoke(this, e);
                }
            }
        }

        private C1.Win.Map.VectorItem FindShop(C1.Win.Interop.Point point, C1.Win.Map.VectorLayer layer)
        {
            foreach (C1.Win.Map.VectorPlacemark mark in layer.Items)
            {
                var p = mark.Geometry.Center;
                if (Math.Abs(p.X - point.X) < 1 && Math.Abs(p.Y - point.Y) < 1)
                {
                    return mark;
                }
            }
            return null;
        }

        public void SetStores(IEnumerable<Store> shops)
        {
            _stores = shops.ToList();
            foreach (var shop in shops)
            {
                var mark = new C1.Win.Map.VectorPlacemark
                {
                    Geometry = new GeoPoint(shop.Location.X, shop.Location.Y),
                    Lod = new LOD(0, 0, 0, 20),
                    Tag = shop.City,
                    Marker =
                        {
                            Size = new SizeF(12,12),
                            Shape = MarkerShape.Circle,
                            Caption = shop.City,
                            LabelPosition = LabelPosition.Right
                        }
                };
                _layer.Items.Add(mark);
            }
        }
    }
}
