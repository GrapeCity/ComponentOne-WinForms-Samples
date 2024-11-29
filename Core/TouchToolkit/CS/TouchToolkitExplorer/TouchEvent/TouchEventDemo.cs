using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.TouchToolKit;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace TouchToolkitExplorer.TouchEvent
{
    public partial class TouchEventDemo : DemoBase
    {
        public TouchEventDemo()
        {
            InitializeComponent();
            this.Title = "Image Viewer";
            this.Description = "Use C1TouchEventProvider to make a Picture viewer, you can zoom, pan, rotate the picture.";
            this.TouchMode = MyTouchMode.Default;
        }

        Point[] startLocation = new Point[] { new Point(37, 77), new Point(413, 56), new Point(448, 230), new Point(262, 124), new Point(169, 160) };
        double[] startRatation = new double[] { 3, 20, 27, 37, 36 };

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.paintPanel1.AddImage(Properties.Resources.Cherry);
            this.paintPanel1.AddImage(Properties.Resources.Cat2);
            this.paintPanel1.AddImage(Properties.Resources.F22);
            this.paintPanel1.AddImage(Properties.Resources.Ln);
            this.paintPanel1.AddImage(Properties.Resources.SL);

            int width = this.Width;
            int height = this.Height;
            Random r = new Random();
            for (int i = 0; i < this.paintPanel1.ImageBounds.Count; i++)
            {
                Rectangle bounds = this.paintPanel1.ImageBounds[i];

                if (bounds.Width > width / 2)
                {
                    bounds.Width = bounds.Width / 2;
                    bounds.Height = bounds.Height / 2;
                }
                bounds.Location = startLocation[i];
                this.paintPanel1.ImageBounds[i] = bounds;
                this.paintPanel1.Rotations[i] = startRatation[i];
            }
        }

        Point position;
        Size size;
        Size startSize;
        SizeF? startPositionPercent;
        private MyTouchMode _mode;
        private MyTouchMode TouchMode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
                this.paintPanel1.TouchMoe = value;
                this.paintPanel1.Invalidate();
            }
        }
        private ManipulationModes manipulationMode;

        private void C1TouchEventProvider1_ManipulationDelta(object sender, C1.Win.TouchToolKit.ManipulationDeltaEventArgs e)
        {
            Point pointerPosition = e.Position;//this.paintPanel1.PointToClient(e.Position);
            Size tmpSize = new Size((int)(startSize.Width * e.Cumulative.Scale), (int)(startSize.Height * e.Cumulative.Scale));

            if (e.Cumulative.Scale != 1d && !startPositionPercent.HasValue)
            {
                this.startPositionPercent = new SizeF((pointerPosition.X - position.X) / (float)size.Width, (pointerPosition.Y - position.Y) / (float)size.Height);
            }
            else if (startPositionPercent.HasValue)
            {
                position = new Point(pointerPosition.X - (int)(tmpSize.Width * startPositionPercent.Value.Width),
                    pointerPosition.Y - (int)(tmpSize.Height * startPositionPercent.Value.Height));
            }
            else
            {
                position = new Point(position.X + e.Delta.Translation.X, position.Y + e.Delta.Translation.Y);
            }
            int minSize = 50;
            tmpSize.Width = tmpSize.Width < minSize ? minSize : tmpSize.Width;
            tmpSize.Height = tmpSize.Height < minSize ? minSize : tmpSize.Height;
            if (position.X + size.Width < minSize)
            {
                position.X = minSize - size.Width;
            }
            if (position.Y + size.Height < minSize)
            {
                position.Y = minSize - size.Height;
            }
            if (position.Y + minSize > paintPanel1.Height)
            {
                position.Y = paintPanel1.Height - minSize;
            }
            if (position.X + minSize > paintPanel1.Width)
            {
                position.X = paintPanel1.Width - minSize;
            }
            this.paintPanel1.ManipulationPosition = pointerPosition;

            if (this.paintPanel1.ActiveImageIndex >= 0)
            {
                size = tmpSize;
                this.paintPanel1.ImageBounds[this.paintPanel1.ActiveImageIndex] = new Rectangle(position, size);
                this.paintPanel1.Rotations[this.paintPanel1.ActiveImageIndex] += e.Delta.Rotation;
                this.paintPanel1.Invalidate();
            }
            if (this.paintPanel1.ActiveImageIndex != -1 && manipulationMode == ManipulationModes.All
                || TouchMode == MyTouchMode.Pivort)
            {
                e.Handled = true;
            }
        }

        private void C1TouchEventProvider1_ManipulationStarted(object sender, C1.Win.TouchToolKit.ManipulationStartedEventArgs e)
        {
            if (this.paintPanel1.ActiveImageIndex >= 0)
            {
                size = this.paintPanel1.ImageBounds[this.paintPanel1.ActiveImageIndex].Size;
                startSize = size;
                position = this.paintPanel1.ImageBounds[this.paintPanel1.ActiveImageIndex].Location;
                startPositionPercent = null;
            }
            if (this.paintPanel1.ActiveImageIndex != -1 && manipulationMode == ManipulationModes.All
                || TouchMode == MyTouchMode.Pivort)
            {
                e.Handled = true;
            }
        }

        private void C1TouchEventProvider1_ManipulationStarting(object sender, C1.Win.TouchToolKit.ManipulationStartingEventArgs e)
        {
            Point pointerPosition = e.Position;
            bool hitTest = this.paintPanel1.HitTest(pointerPosition);
            if (this.TouchMode == MyTouchMode.Default)
            {
                if (hitTest)
                {
                    e.Mode = ManipulationModes.All;
                }
                else
                {
                    e.Mode = ManipulationModes.Rotate | ManipulationModes.RotateInertia;
                }
            }
            else
            {
                if (this.paintPanel1.ActiveImageIndex != -1)
                {
                    ManipulationPivot pivot = new ManipulationPivot();
                    pivot.Center = this.paintPanel1.GetImageCenter(this.paintPanel1.ActiveImageIndex);
                    pivot.Radius = this.paintPanel1.GetImageRadius(this.paintPanel1.ActiveImageIndex);
                    e.Pivot = pivot;
                }
                e.Mode = ManipulationModes.Rotate | ManipulationModes.RotateInertia;
            }
            manipulationMode = e.Mode;
            if (e.Mode == ManipulationModes.All)
            {
                e.Handled = true;
            }
        }

        private void C1TouchEventProvider1_Tapped(object sender, TappedEventArgs e)
        {
            if (e.OriginalSource != this.paintPanel1)
            {
                this.paintPanel1.ActiveImageIndex = -1;
            }
        }

        private void C1TouchEventProvider1_ManipulationInertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
        {
            e.TranslationBehavior.DesiredDeceleration = 0.008f;
            e.TranslationBehavior.DesiredDisplacement = 200;
            if (this.paintPanel1.ActiveImageIndex != -1 && manipulationMode == ManipulationModes.All
                || TouchMode == MyTouchMode.Pivort)
            {
                e.Handled = true;
            }
        }

        private void C1TouchEventProvider1_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            if (this.paintPanel1.ActiveImageIndex != -1 && manipulationMode == ManipulationModes.All
                || TouchMode == MyTouchMode.Pivort)
            {
                e.Handled = true;
            }
        }

        private void ModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultRadioButton.Checked)
            {
                this.TouchMode = MyTouchMode.Default;
            }
            else
            {
                this.TouchMode = MyTouchMode.Pivort;
            }
        }
    }


    internal interface IWndProcHooker
    {
        bool ProcessWndProc(ref Message m);
    }

    internal class ControlNativeWindow : NativeWindow
    {
        private Control _owner;
        private IWndProcHooker _hooker;
        private IntPtr _handle = IntPtr.Zero;

        internal Control Owner
        {
            get
            {
                return _owner;
            }
        }

        internal IWndProcHooker Hooker
        {
            get
            {
                return _hooker;
            }
        }

        internal ControlNativeWindow(Control control, IWndProcHooker hooker)
        {
            _owner = control;
            _hooker = hooker;
            _handle = IntPtr.Zero;

            if (_owner.IsHandleCreated)
            {
                OnOwnerHandleCreated(_owner, EventArgs.Empty);
            }
            _owner.HandleCreated += new EventHandler(OnOwnerHandleCreated);
            _owner.HandleDestroyed += new EventHandler(OnOwnerHandleDestroyed);
        }

        internal ControlNativeWindow(IntPtr handle, IWndProcHooker hooker)
        {
            _owner = null;
            _handle = handle;
            _hooker = hooker;

            OnOwnerHandleCreated(this, EventArgs.Empty);
        }

        internal virtual void DetachHandle()
        {
            this.ReleaseHandle();
        }

        internal virtual void OnOwnerHandleCreated(object sender, EventArgs e)
        {
            if (_owner != null)
            {
                this.AssignHandle(_owner.Handle);
            }
            else
            {
                this.AssignHandle(this._handle);
            }
        }

        internal virtual void OnOwnerHandleDestroyed(object sender, EventArgs e)
        {
            this.DetachHandle();
        }

        protected override void WndProc(ref Message m)
        {
            if (!_hooker.ProcessWndProc(ref m))
            {
                base.WndProc(ref m);
            }
        }
    }

    internal enum MyTouchMode
    {
        Default,
        Pivort,
    }

    public class ImagePanel : Panel
    {
        public List<Rectangle> ImageBounds = new List<Rectangle>();
        public List<double> Rotations = new List<double>();
        List<Image> Images = new List<Image>();
        public Point ManipulationPosition { get; set; }

        int _activeImageIndex = -1;
        public int ActiveImageIndex
        {
            get
            {
                return _activeImageIndex;
            }
            set
            {
                if (_activeImageIndex != value)
                {
                    _activeImageIndex = value;
                    this.Invalidate();
                }
            }
        }

        internal MyTouchMode TouchMoe { get; set; }

        public void AddImage(Image image)
        {
            Size size = image.Size;
            if (size.Width > 450 || size.Height > 450)
            {
                double scale = Math.Min(450d / size.Width, 450d / size.Height);
                size.Width = (int)(scale * size.Width);
                size.Height = (int)(scale * size.Height);
            }
            ImageBounds.Add(new Rectangle(Point.Empty, size));
            Rotations.Add(0d);
            Images.Add(image);
        }

        public bool HitTest(Point position)
        {
            if (this.ActiveImageIndex != -1 && this.ImageBounds[ActiveImageIndex].Contains(position))
            {
                //ManipulationPivot pivot = new ManipulationPivot(new Point(this.paintPanel1.Width / 2, this.paintPanel1.Height / 2), this.paintPanel1.Height / 2);
                //e.Pivot = pivot; 
                return true;
            }
            else
            {
                for (int i = 0; i < this.Images.Count; i++)
                {
                    if (this.ImageBounds[i].Contains(position))
                    {
                        this.ActiveImageIndex = i;
                        return true;
                    }
                }
            }
            return false;
        }

        public ImagePanel()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = this.Images.Count - 1; i >= 0; i--)
            {
                if (i == this.ActiveImageIndex)
                {
                    continue;
                }
                DrawImage(e, i);
            }
            if (this.ActiveImageIndex != -1 && this.ActiveImageIndex < this.Images.Count)
            {
                DrawImage(e, this.ActiveImageIndex);
                Rectangle bounds = this.ImageBounds[this.ActiveImageIndex];
                if (TouchMoe == MyTouchMode.Default)
                {
                    Pen pen = new Pen(Color.Gray);
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    bounds = new Rectangle(bounds.X - 1, bounds.Y - 1, bounds.Width + 2, bounds.Height + 2);
                    e.Graphics.DrawRectangle(pen, bounds);
                    pen.Dispose();
                }
                else
                {
                    Point center = this.GetImageCenter(this.ActiveImageIndex);
                    int radius = (int)this.GetImageRadius(this.ActiveImageIndex);
                    bounds.Location = new Point(center.X - radius - 1, center.Y - radius - 1);
                    bounds.Size = new Size(radius * 2, radius * 2);
                    Pen pen = new Pen(Color.Gray);
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawEllipse(pen, bounds);
                    pen.Dispose();
                }
            }
        }

        public Point GetImageCenter(int index)
        {
            Point center = new Point(this.ImageBounds[index].X + this.ImageBounds[index].Width / 2, this.ImageBounds[index].Y + this.ImageBounds[index].Height / 2);
            return center;
        }



        public float GetImageRadius(int index)
        {
            Rectangle bounds = this.ImageBounds[index];
            return (float)Math.Sqrt(bounds.Width * bounds.Width / 4d + bounds.Height * bounds.Height / 4d);
        }

        private void DrawImage(PaintEventArgs e, int index)
        {
            Point location = new Point();
            if (Rotations[index] != 0d)
            {
                Point center = GetImageCenter(index);
                e.Graphics.RenderingOrigin = center;
                e.Graphics.TranslateTransform(center.X, center.Y);
                location = new Point(-center.X, -center.Y);
                e.Graphics.RotateTransform((float)Rotations[index]);
                e.Graphics.RenderingOrigin = Point.Empty;
            }
            location.Offset(this.ImageBounds[index].Location);
            e.Graphics.DrawImage(this.Images[index], new Rectangle(location, this.ImageBounds[index].Size));

            if (Rotations[index] != 0d)
            {
                e.Graphics.ResetTransform();
            }
        }
    }
}
