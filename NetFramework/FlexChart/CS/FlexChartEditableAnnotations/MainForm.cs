using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using C1Anno = C1.Win.Chart.Annotation;
using C1.Chart.Annotation;
using C1.Win.Chart.Interaction;
using C1.Win.Chart;
using C1.Chart;

namespace FlexChartEditableAnnotations
{
    public partial class MainForm : Form
    {
        private EditableAnnotationLayer al;
        private List<ToolStripButton> _lsAttachmentGroup, _lsAnnotationGroup;
        private AxisScrollbar _scrollbar;
        private ContextMenu _flexChartContextMenu;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            _lsAttachmentGroup = new List<ToolStripButton>{
                tsAbsolute,tsDataCoordinate,tsRelative
            };
            _lsAnnotationGroup = new List<ToolStripButton>{
                tsText,tsCircle,tsEllipse,tsRectangle,tsSquare,tsLine,tsPolygon
            };

            _flexChartContextMenu = new ContextMenu(new MenuItem[]{
                new MenuItem("Delete", OnDeleteClicked)
            });

            this.Text = Localizer.GetItem("introduction", "title");
            lblTitle.Text = Localizer.GetItem("introduction", "title");
            tbDescription.Rtf = Localizer.GetItem("introduction", "description").MakeRtf();
            tsAbsolute.Text = Localizer.GetItem("Absolute", "description");
            tsRelative.Text = Localizer.GetItem("Relative", "description");
            tsDataCoordinate.Text = Localizer.GetItem("DataCoordinate", "description");
            tsAllowMove.Text = Localizer.GetItem("allowMove", "description");
            tsText.Text = Localizer.GetItem("textAnno", "description");
            tsLine.Text = Localizer.GetItem("lineAnno", "description");
            tsCircle.Text = Localizer.GetItem("circleAnno", "description");
            tsEllipse.Text = Localizer.GetItem("ellipseAnno", "description");
            tsRectangle.Text = Localizer.GetItem("rectAnno", "description");
            tsSquare.Text = Localizer.GetItem("squareAnno", "description");
            tsPolygon.Text = Localizer.GetItem("polygonAnno", "description");

            tsAbsolute.Tag = AnnotationAttachment.Absolute;
            tsRelative.Tag = AnnotationAttachment.Relative;
            tsDataCoordinate.Tag = AnnotationAttachment.DataCoordinate;
            tsAllowMove.Tag = "Move";
            tsText.Tag = "Text";
            tsLine.Tag = "Line";
            tsCircle.Tag = "Circle";
            tsEllipse.Tag = "Ellipse";
            tsRectangle.Tag = "Rectangle";
            tsSquare.Tag = "Square";
            tsPolygon.Tag = "Polygon";

            SetupChart();

            tsAbsolute.Checked = true;
            tsAllowMove.Checked = al.AllowMove;
        }

        private void SetupChart()
        {
            var ls = new List<Point>();
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                ls.Add(new Point(i, r.Next(0, 1000)));
            }

            flexChart1.DataSource = ls;
            flexChart1.ChartType = C1.Chart.ChartType.Scatter;
            flexChart1.ToolTip.Active = false;
            flexChart1.Series.Clear();
            flexChart1.Series.Add(new C1.Win.Chart.Series
            {
                Binding = "Y",
                BindingX = "X"
            });

            #region Annotations Setup

            al = new EditableAnnotationLayer(flexChart1);

            al.Annotations.Add(new C1Anno.Text
            {
                Attachment = AnnotationAttachment.Relative,
                Content = "Text Annotation",
                Location = new PointF(0.5f, 0.2f)
            });

            al.Annotations.Add(new C1Anno.Rectangle
            {
                Attachment = AnnotationAttachment.Absolute,
                Content = "Absolute",
                Location = new PointF(100, 150),
                Width = 100,
                Height = 50
            });

            al.Annotations.Add(new C1Anno.Ellipse
            {
                Attachment = AnnotationAttachment.Relative,
                Location = new PointF(0.5f, 0.35f),
                Content = "Relative",
                Width = 100,
                Height = 50
            });

            al.Annotations.Add(new C1Anno.Square
            {
                Attachment = AnnotationAttachment.DataCoordinate,
                Content = "DataCoordinate",
                Length = 100,
                Location = new PointF(20, 200)
            });

            al.Annotations.Add(new C1Anno.Polygon("Polygon")
            {
                Attachment = AnnotationAttachment.Absolute,
                Points =
                {
                    new PointF(200, 25),
                    new PointF(150, 70),
                    new PointF(175, 115),
                    new PointF(225, 115),
                    new PointF(250, 70)
                },
            });

            al.Annotations.Add(new C1Anno.Line
            {
                Attachment = AnnotationAttachment.Relative,
                Content = "Horizontal Line",
                Start = new PointF(0, 0.5f),
                End = new PointF(1.2f, 0.5f),
            });

            al.Annotations.Add(new C1Anno.Line
            {
                Attachment = AnnotationAttachment.Relative,
                Content = "Vertical Line",
                Start = new PointF(0.7f, 0),
                End = new PointF(0.7f, 1.2f),
            });

            al.Annotations.Add(new C1Anno.Line
            {
                Attachment = AnnotationAttachment.Absolute,
                Content = "Slanted Line",
                Start = new PointF(100, 70),
                End = new PointF(200, 170),
            });

            al.PolygonAddFunc = (pt) =>
            {
                return new C1Anno.Polygon(string.Empty)
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
            #endregion

            flexChart1.Rendered += OnChartRendered;
            flexChart1.MouseDown += OnMouseDown;
            flexChart1.KeyDown += OnKeyDown;
        }     

        #region Event Handlers

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
                al.Annotations.Remove(al.SelectedAnnotation);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            flexChart1.Focus(); //KeyDown does not triggers without this
            if (e.Button == MouseButtons.Right)
            {
                if (al.HitTest(e.Location) != null)
                {
                    flexChart1.ContextMenu = _flexChartContextMenu;
                    flexChart1.ContextMenu.Show(flexChart1, e.Location);
                }
                else
                    flexChart1.ContextMenu = null;
            }
        }

        private void OnChartRendered(object sender, C1.Win.Chart.RenderEventArgs e)
        {
            SetupAxisScrollbar();
        }

        private void SetupAxisScrollbar()
        {
            if (_scrollbar != null)
                return;
            _scrollbar = new AxisScrollbar(flexChart1.AxisX);
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            al.Annotations.Remove(al.SelectedAnnotation);
        }

        private void OnToolstripItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
                var asm = typeof(C1Anno.AnnotationBase).Assembly;
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
        #endregion

        #region UI EventHandlers
        private void pControls_Paint(object sender, PaintEventArgs e)
        {
            pControls.CreateGraphics().DrawLine(new Pen(Color.LightGray), 0, pControls.Height - 1, pControls.Width, pControls.Height - 1);
        }

        private void pCollapse_Paint(object sender, PaintEventArgs e)
        {
            using (var gr = pCollapse.CreateGraphics())
            {
                gr.FillRectangle(new SolidBrush(Color.White), 0, 0, pCollapse.Width, pCollapse.Height / 2);
                gr.DrawLine(new Pen(Color.LightGray), 0, pCollapse.Height / 2, pCollapse.Width, pCollapse.Height / 2);
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            pDescription.Visible = !pDescription.Visible;
            btnCollapse.BackgroundImage = pDescription.Visible ?
                Properties.Resources.cb_up26 :
                Properties.Resources.cb_down26;
        }

        private void pDescription_Paint(object sender, PaintEventArgs e)
        {
            pDescription.CreateGraphics().DrawLine(new Pen(Color.LightGray), 0, 13, pDescription.Width, 13);
        }

        private void BaseSample_SizeChanged(object sender, EventArgs e)
        {
            tbDescription.Height = (int)tbDescription.CreateGraphics().MeasureString(tbDescription.Text,
                tbDescription.Font, tbDescription.Width).Height;
        }

        #endregion
    }
}
