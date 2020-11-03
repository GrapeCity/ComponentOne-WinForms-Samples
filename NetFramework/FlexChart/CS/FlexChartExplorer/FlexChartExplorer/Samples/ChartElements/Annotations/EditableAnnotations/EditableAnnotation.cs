using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart.Annotation;
using C1.Win.Chart.Annotation;
using C1.Win.Chart.Interaction;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class EditableAnnotation : FlexChartBaseSample
    {
        private FlexChart flexChart1;
        private EditableAnnotationLayer al;
        private ToolStrip _toolStrip;
        private ToolStripButton _tsRectangle, _tsSquare, _tsLine, _tsCircle, _tsEllipse, _tsPoly, _tsText, _tsAbsolute, _tsRelative, _tsDataCord, _tsMove;
        private ToolStripSeparator _tsSeparator1, _tsSeparator2;
        private List<ToolStripButton> _lsAnnotationGroup, _lsAttachmentGroup;
        private ContextMenu _flexChartContextMenu;
        private C1.Win.Chart.Interaction.AxisScrollbar _axisScrollbar;
        public EditableAnnotation()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var ls = new List<Point>();
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                ls.Add(new Point(i, r.Next(0, 1000)));
            }

            this.flexChart1.Header.Content = "Annotated Data Points";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            flexChart1.DataSource = ls;
            flexChart1.ChartType = C1.Chart.ChartType.Scatter;
            flexChart1.ToolTip.Active = false;
            flexChart1.Series.Clear();
            flexChart1.Series.Add(new C1.Win.Chart.Series
            {
                Binding = "Y",
                BindingX = "X"
            });
            flexChart1.MouseDown += FlexChart1_MouseDown;
            flexChart1.KeyDown += FlexChart1_KeyDown;
            flexChart1.Rendered += FlexChart1_Rendered;

            #region Annotation Setup
            al = new EditableAnnotationLayer(flexChart1);
            al.PolygonAddFunc = (pt) =>
            {
                return new Polygon(string.Empty)
                {
                    Points =
                    {
                        pt,pt,pt
                    }
                };
            };

            al.PolygonResizeFunc = (poly, rectangle) =>
            {
                var top = new PointF((float)(rectangle.Left + rectangle.Width / 2), rectangle.Y);
                var left = new PointF(rectangle.Left, rectangle.Bottom);
                var right = new PointF(rectangle.Right, rectangle.Bottom);
                poly.Points[0] = Helpers.CoordsToAnnoPoint(flexChart1, poly, top);
                poly.Points[1] = Helpers.CoordsToAnnoPoint(flexChart1, poly, left);
                poly.Points[2] = Helpers.CoordsToAnnoPoint(flexChart1, poly, right);
            };

            al.ContentEditor = new AnnotationEditor();
            al.Annotations.Add(new C1.Win.Chart.Annotation.Rectangle
            {
                Attachment = AnnotationAttachment.Absolute,
                Content = "Absolute",
                Location = new PointF(700, 150),
                Width = 100,
                Height = 50,
            });
            al.Annotations.Add(new C1.Win.Chart.Annotation.Ellipse
            {
                Attachment = AnnotationAttachment.Relative,
                Content = "Relative",
                Width = 70,
                Height = 30,
                Location = new PointF(0.4f,0.2f),
            });
            al.Annotations.Add(new C1.Win.Chart.Annotation.Square
            {
                Attachment = AnnotationAttachment.DataCoordinate,
                Content = "DataCoordinate",
                Location = new PointF(70, 500),
                Length = 100,
            });
            al.Annotations.Add(new C1.Win.Chart.Annotation.Text("Text Annotation")
            {
                Attachment = AnnotationAttachment.Absolute,
                Location = new PointF(400, 50),
            });
            al.Annotations.Add(new C1.Win.Chart.Annotation.Line("Slanted Line")
            {
                Attachment = AnnotationAttachment.Absolute,
                Start = new PointF(150, 200),
                End = new PointF(300, 300),
            });
            al.Annotations.Add(new C1.Win.Chart.Annotation.Line("Horizontal Line")
            {
                Attachment = AnnotationAttachment.Relative,
                Start = new PointF(0,0.8f),
                End = new PointF(1.2f, 0.8f),
            });
            al.Annotations.Add(new C1.Win.Chart.Annotation.Line("Vertical Line")
            {
                Attachment = AnnotationAttachment.Relative,
                Start = new PointF(0.7f, 0),
                End = new PointF(0.7f, 1.2f),
            });
            al.Annotations.Add(new C1.Win.Chart.Annotation.Polygon("Polygon")
            {
                Attachment = AnnotationAttachment.Absolute,
                Points = 
                {
                    new PointF(100, 150),
                    new PointF(150, 100),
                    new PointF(200, 150),
                    new PointF(190, 200),
                    new PointF(110, 200),
                }
            });
            #endregion
        }

        private void FlexChart1_Rendered(object sender, C1.Win.Chart.RenderEventArgs e)
        {
            if (_axisScrollbar == null)
            {
                _axisScrollbar = new C1.Win.Chart.Interaction.AxisScrollbar(flexChart1.AxisX);
            }
        }

        private void FlexChart1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                al.Annotations.Remove(al.SelectedAnnotation);
            }
        }

        private void FlexChart1_MouseDown(object sender, MouseEventArgs e)
        {
            this.flexChart1.Focus();//Key down does not trigger without this
            if(e.Button == MouseButtons.Right)
            {
                if (al.HitTest(e.Location) != null)
                {
                    this.flexChart1.ContextMenu = _flexChartContextMenu;
                    this.flexChart1.ContextMenu.Show(flexChart1, e.Location);
                }
                else
                    this.flexChart1.ContextMenu=null;
            }
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _toolStrip = new ToolStrip();
            //Annotations
            _tsRectangle = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsRectangle_Image,
                Text = "Add Rectangle Annotation",
                Tag = "Rectangle",
            };
            _tsSquare = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsSquare_Image,
                Text = "Add Square Annotation",
                Tag = "Square",
            };
            _tsCircle = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsCircle_Image,
                Text = "Add Circle Annotation",
                Tag = "Circle",
            };
            _tsEllipse = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsEllipse_Image,
                Text = "Add Ellipse Annotation",
                Tag = "Ellipse",
            };
            _tsLine = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsLine_Image,
                Text = "Add Line Annotation",
                Tag = "Line",
            };
            _tsPoly = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsPolygon_Image,
                Text = "Add Polygon Annotation",
                Tag = "Polygon",
            };
            _tsText = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsText_Image,
                Text = "Add Text Annotation",
                Tag = "Text",
            };
            //Attachments
            _tsAbsolute = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsAbsolute_Image,
                Text = "Absolute Attachment",
                Tag = AnnotationAttachment.Absolute,
            };
            _tsRelative = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsRelative_Image,
                Text = "Relative Attachment",
                Tag = AnnotationAttachment.Relative,
            };
            _tsDataCord = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsDataCoordinate_Image,
                Text = "DataCoordinate Attachment",
                Tag = AnnotationAttachment.DataCoordinate,
            };
            //Allow Move and Separators
            _tsMove = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.tsAllowMove_Image,
                Text = "Allow Move",
                Tag = "Move",
            };
            _tsSeparator1 = new ToolStripSeparator();
            _tsSeparator2 = new ToolStripSeparator();
            //Context Menu
            _flexChartContextMenu = new ContextMenu(new MenuItem[] { new MenuItem("Delete", OnDeleteClicked)});

            _lsAnnotationGroup = new List<ToolStripButton> { _tsRectangle, _tsSquare, _tsCircle, _tsEllipse, _tsLine, _tsPoly, _tsText };
            _lsAttachmentGroup = new List<ToolStripButton> { _tsAbsolute, _tsRelative, _tsDataCord};

            _toolStrip.ItemClicked += _toolStrip_ItemClicked;
            _tsAbsolute.Checked = true;
            _tsMove.Checked = true;

            _toolStrip.Items.AddRange(new ToolStripItem[] {_tsAbsolute, _tsRelative, _tsDataCord, _tsSeparator1,
            _tsLine, _tsRectangle, _tsSquare, _tsCircle, _tsEllipse, _tsPoly, _tsText, _tsSeparator2, _tsMove});
            this.pnlControls.Controls.Add(_toolStrip);

        }

        private void _toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var clickedItem = e.ClickedItem as ToolStripButton;

            //Handle Annotation Attachments
            if (_lsAttachmentGroup.Contains(clickedItem))
            {
                foreach (var item in _lsAttachmentGroup)
                    item.Checked = item == clickedItem ? !item.Checked : false;
                al.Attachment = (AnnotationAttachment)clickedItem.Tag;
            }

            //Handle adding new Annotations 
            else if (_lsAnnotationGroup.Contains(clickedItem))
            {
                foreach (var item in _lsAnnotationGroup)
                    item.Checked = item == clickedItem ? !item.Checked : false;
                var annoToAdd = (string)clickedItem.Tag;
                var asm = typeof(AnnotationBase).Assembly;
                al.NewAnnotationType = asm.GetType(string.Format("C1.Win.Chart.Annotation.{0}", annoToAdd));
                al.AllowAdd = clickedItem.Checked;
            }
            //Allow Moving Annotations at runtime
            else if ((string)clickedItem.Tag == "Move")
            {
                clickedItem.Checked = !clickedItem.Checked;
                al.AllowMove = clickedItem.Checked;
            }
        }
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            al.Annotations.Remove(al.SelectedAnnotation);
        }
    }
}