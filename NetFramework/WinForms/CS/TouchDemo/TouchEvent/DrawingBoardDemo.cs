using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchDemo.TouchEvent
{
    public partial class DrawingBoardDemo : DemoBase
    {
        public const int ColorButtonSize = 30;
        public const int ColorButtonMagion = 2;

        public DrawingBoardDemo()
        {
            InitializeComponent();
            this.Title = "Drawing Board";
            this.Description = "Please use the pen to draw. You can erase by using the back button, fill color by side button, and draw lines using the pen.";
            this.paintPanel.Owner = this;
            this.drawModePanel1.Owner = this;
            this.C1TouchEventProvider1.EnablePenFlicks = false;
        }
        
        public Color ForegroundColor
        {
            get
            {
                return this.colorPanel1.ForegroundColor;
            }
        }
        public Color BackgroundColor
        {
            get
            {
                return this.colorPanel1.BackgroundColor;
            }
        }

        public DrawMode DrawMode
        {
            get
            {
                return this.drawModePanel1.DrawMode;
            }
            set
            {
                this.drawModePanel1.DrawMode = value;
            }
        }

        public int DrawSize
        {
            get
            {
                return this.drawSizePanel1.DrawSize;
            }
        }

        private Point _pointerDownPoint;
        private Point _lastPoint;
        private bool _penDown;

        public void RefereshPaintPanel()
        {
            this.paintPanel.RefereshPaintPanel();
        }

        private void C1TouchEventProvider1_PointerMoved(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if (e.OriginalSource != this.paintPanel)
            {
                return;
            }
            if (_penDown)
            {
                UpdateDrawMode(e);
                Point currentPoint = PointToPaintPanel(e.Position);
                Process(currentPoint);
                _lastPoint = currentPoint;
            }
        }

        private void Process(Point currentPoint)
        {
            if (this.DrawMode == TouchEvent.DrawMode.Erase)
            {
                this.paintPanel.Erase(_lastPoint, currentPoint);
            }
            else if (this.DrawMode == TouchEvent.DrawMode.Fill)
            {
                this.paintPanel.Fill(currentPoint);
            }
            else
            {
                this.paintPanel.Draw(_lastPoint, currentPoint);
            }
        }

        private void UpdateDrawMode(C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if (e.DeviceType == C1.Win.TouchToolKit.PointerDeviceType.Pen)
            {
                if (e.Properties.IsInverted || e.Properties.IsEraser)
                {
                    this.DrawMode = TouchEvent.DrawMode.Erase;
                }
                else if (e.Properties.IsBarrelButtonPressed)
                {
                    this.DrawMode = TouchEvent.DrawMode.Fill;
                }
                else
                {
                    this.DrawMode = TouchEvent.DrawMode.Draw;
                }
            }
            
        }

        private void C1TouchEventProvider1_PointerPressed(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            if (e.OriginalSource != this.paintPanel)
            {
                return;
            }
            UpdateDrawMode(e);
            _penDown = true;
            _pointerDownPoint = PointToPaintPanel(e.Position);
            _lastPoint = _pointerDownPoint;
        }

        Point PointToPaintPanel(Point point)
        {
            return this.paintPanel.PointToClient(this.panel1.PointToScreen(point));
        }

        private void C1TouchEventProvider1_PointerReleased(object sender, C1.Win.TouchToolKit.PointerEventArgs e)
        {
            _penDown = false;
            this.UpdateDrawMode(e);
        }

        private void C1TouchEventProvider1_ManipulationCompleted(object sender, C1.Win.TouchToolKit.ManipulationCompletedEventArgs e)
        {
            e.Handled = true;
        }

        private void C1TouchEventProvider1_ManipulationDelta(object sender, C1.Win.TouchToolKit.ManipulationDeltaEventArgs e)
        {
            e.Handled = true;
        }

        private void C1TouchEventProvider1_ManipulationInertiaStarting(object sender, C1.Win.TouchToolKit.ManipulationInertiaStartingEventArgs e)
        {
            e.Handled = true;
        }

        private void C1TouchEventProvider1_ManipulationStarted(object sender, C1.Win.TouchToolKit.ManipulationStartedEventArgs e)
        {
            e.Handled = true;
        }

        private void C1TouchEventProvider1_ManipulationStarting(object sender, C1.Win.TouchToolKit.ManipulationStartingEventArgs e)
        {
            e.Handled = true;
        }
    }

    public class PaintPanel : Panel
    {
        public Color ForegroundColor
        {
            get
            {
                return this.Owner.ForegroundColor;
            }
        }
        public Color BackgroundColor
        {
            get
            {
                return this.Owner.BackgroundColor;
            }
        }

        public DrawingBoardDemo Owner { get; set; }

        public int DrawSize 
        {
            get
            {
                return this.Owner.DrawSize;
            }
        }

        private Bitmap _img;
        private Graphics _graphics;
        public PaintPanel()
        {
            _img = new Bitmap(this.Width, this.Height);
            _graphics = Graphics.FromImage(_img);
            this.DoubleBuffered = true;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            Bitmap tmpImg = new Bitmap(this.Width, this.Height);
            _graphics.Dispose();
            _graphics = Graphics.FromImage(tmpImg);
            _graphics.DrawImage(_img, Point.Empty);
            _img.Dispose();
            _img = tmpImg;
            base.OnSizeChanged(e);
        }

        public void Draw(Point startPoint, Point endPoint)
        {
            using (Pen pen = new Pen(this.ForegroundColor))
            {
                pen.Width = DrawSize;
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                _graphics.DrawLine(pen, startPoint, endPoint);
            }
            this.Invalidate();
        }

        public void Erase(Point startPoint, Point endPoint)
        {
            using (Pen pen = new Pen(this.BackgroundColor))
            {
                pen.Width = DrawSize + 3;
                _graphics.DrawLine(pen, startPoint, endPoint);
            }

            this.Invalidate();
        }

        public void Fill(Point point)
        {
            Color regionColor = _img.GetPixel(point.X, point.Y);
            if ((point.X == 0 || _img.GetPixel(point.X - 1, point.Y).ToArgb() == ForegroundColor.ToArgb())
                && (point.Y == 0 || _img.GetPixel(point.X, point.Y - 1).ToArgb() == ForegroundColor.ToArgb())
                && (point.X == _img.Width - 1 || _img.GetPixel(point.X + 1, point.Y).ToArgb() == ForegroundColor.ToArgb())
                && (point.Y == _img.Height - 1 || _img.GetPixel(point.X, point.Y + 1).ToArgb() == ForegroundColor.ToArgb()))
            {
                return;
            }
            int[,] flags = new int[_img.Width, _img.Height];
            Fill(point, regionColor, flags);
            for (int y = 0; y < _img.Height; y++)
            {
                for (int x = 0; x < _img.Width; x++)
                {
                    if (flags[x, y] > 0)
                    {
                        _img.SetPixel(x, y, ForegroundColor);
                    }
                }
            }
            this.Invalidate();
        }

        private void Fill(Point point, Color regionColor, int[,] flags)
        {
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(point);
            Point currentPoint;
            while (queue.Count > 0)
            {
                currentPoint = queue.Dequeue();
                int x = currentPoint.X;
                int y = currentPoint.Y;
                if (_img.GetPixel(x, y).ToArgb() != regionColor.ToArgb())
                {
                    flags[x, y] = -1;
                    continue;
                }
                flags[x, y] = 1;
                // left
                if (x > 0 && flags[x - 1, y] == 0)
                {
                    queue.Enqueue(new Point(x - 1, y));
                    flags[x - 1, y] = -1;
                }
                // top
                if (y > 0 && flags[x, y - 1] == 0)
                {
                    queue.Enqueue(new Point(x, y - 1));
                    flags[x, y - 1] = -1;
                }
                // right
                if (x < _img.Width - 1 && flags[x + 1, y] == 0)
                {
                    queue.Enqueue(new Point(x + 1, y));
                    flags[x + 1, y] = -1;
                }
                // bottom 
                if (y < _img.Height - 1 && flags[x, y + 1] == 0)
                {
                    queue.Enqueue(new Point(x, y + 1));
                    flags[x, y + 1] = -1;
                }
            }
        }

        public void RefereshPaintPanel()
        {
            _graphics.Clear(BackgroundColor);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(this._img, Point.Empty);
        }
    }

    public class ColorPanel : Panel
    {
        public ColorPanel()
        {
            this.InitializeComponent();
            this.BackgroundColor = Color.White;
            this.ForegroundColor = Color.Black;
        }

        private Color _backColor;
        public Color BackgroundColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
                backColorButton.BackColor = value;
                backColorButton.ForeColor = GetForeColor(value);
            }
        }

        private Color _foreColor;
        public Color ForegroundColor
        {
            get
            {
                return _foreColor;
            }
            set
            {
                _foreColor = value;
                foreColorButton.BackColor = value;
                foreColorButton.ForeColor = GetForeColor(value);
            }
        }

        SelectableButton foreColorButton;
        SelectableButton backColorButton;
        Button editColorButton;

        private Color GetForeColor(Color backColor)
        {
            return Color.FromArgb(GetInverseColorValue(backColor.R),
                GetInverseColorValue(backColor.G),
                GetInverseColorValue(backColor.B));            
        }

        private int GetInverseColorValue(int colorValue)
        {
            if (colorValue <= 106 || colorValue >= 150)
            {
                return 255 - colorValue;
            }
            if (colorValue < 128)
            {
                return 255;
            }
            return 0;
        }

        public void InitializeComponent()
        {
            Color[,] colors = new Color[,] { 
            {Color.Black, Color.Gray, Color.Brown, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.LightBlue, Color.Blue, Color.Violet},
            {Color.White, Color.LightGray, Color.LightCoral, Color.Pink, Color.DarkOrange, Color.LightYellow, Color.GreenYellow, Color.SkyBlue, Color.CadetBlue, Color.Tomato }};
            int magion = DrawingBoardDemo.ColorButtonMagion;
            int x = magion + 2;
            int y = magion + 2;
            int colorButtonSize = DrawingBoardDemo.ColorButtonSize;

            foreColorButton = new ColorButton();
            foreColorButton.Selected = true;
            foreColorButton.Name = "foreColorButton";
            foreColorButton.Text = "Fore color";
            foreColorButton.Bounds = new Rectangle(x, y, colorButtonSize * 2, colorButtonSize * 2);
            foreColorButton.Click += button_Click;
            this.Controls.Add(foreColorButton);
            x = foreColorButton.Right + magion;

            backColorButton = new ColorButton();
            backColorButton.Name = "backColorButton";
            backColorButton.Text = "Back color";
            backColorButton.Bounds = new Rectangle(x, y, colorButtonSize * 2, colorButtonSize * 2);
            backColorButton.Click += button_Click;
            this.Controls.Add(backColorButton);
            x = backColorButton.Right + magion;

            int startX = x;
            for (int i = 0; i < colors.GetLength(0); i++)
            {
                x = startX;
                for (int j = 0; j < colors.GetLength(1); j++)
                {
                    Button button = new Button();
                    button.Click += button_Click;
                    button.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
                    button.BackColor = colors[i, j];
                    x = button.Right + magion;
                    this.Controls.Add(button);
                }
                y = y + colorButtonSize + magion;
            }
            y = magion + 3;
            x += 2;
            editColorButton = new Button();
            editColorButton.Name = "editColorButton";
            editColorButton.Text = "Edit colors";
            editColorButton.Bounds = new Rectangle(x, y, colorButtonSize * 2, colorButtonSize * 2);
            editColorButton.Click += button_Click;
            editColorButton.Image = Properties.Resources.ChooseColor;
            editColorButton.TextImageRelation = TextImageRelation.ImageAboveText;
            this.Controls.Add(editColorButton);
        }

        void button_Click(object sender, EventArgs e)
        {
            if (sender == this.foreColorButton)
            {
                this.foreColorButton.Selected = true;
                this.backColorButton.Selected = false;
            }
            else if (sender == this.backColorButton)
            {
                this.foreColorButton.Selected = false;
                this.backColorButton.Selected = true;                
            }
            else if (sender == this.editColorButton)
            {
                ColorDialog dialog = new ColorDialog();
                dialog.ShowDialog(this.FindForm());
                SelectColor(dialog.Color);
            }
            else
            {
                SelectColor((sender as Button).BackColor);
            }
        }

        private void SelectColor(Color color)
        {
            if (this.foreColorButton.Selected)
            {
                this.ForegroundColor = color;
            }
            else
            {
                this.BackgroundColor = color;
            }
        }
    }

    public enum DrawMode
    { 
        Draw, 
        Fill,
        Erase
    }

    public class DrawModePanel : Panel
    {
        private DrawMode _drawMode;
        public DrawMode DrawMode
        {
            get
            {
                return _drawMode;
            }
            set
            {
                _drawMode = value;
                if (_drawMode == TouchEvent.DrawMode.Draw)
                {
                    this.drawButton.Selected = true;
                    this.fillButton.Selected = false;
                    this.eraseButton.Selected = false;
                }
                else if (_drawMode == TouchEvent.DrawMode.Fill)
                {
                    this.drawButton.Selected = false;
                    this.fillButton.Selected = true;
                    this.eraseButton.Selected = false;
                }
                else if (_drawMode == TouchEvent.DrawMode.Erase)
                {
                    this.drawButton.Selected = false;
                    this.fillButton.Selected = false;
                    this.eraseButton.Selected = true;
                }
            }
        }

        public DrawingBoardDemo Owner { get; set; }

        private SelectableButton drawButton;
        private SelectableButton fillButton;
        private SelectableButton eraseButton;
        private Button clearButton;

        public DrawModePanel()
        {
            InitializeComponent();
            this.DrawMode = TouchEvent.DrawMode.Draw;
        }

        public void InitializeComponent()
        {
            int magion = DrawingBoardDemo.ColorButtonMagion;
            int x = magion + 2;
            int y = magion + 2;
            int colorButtonSize = DrawingBoardDemo.ColorButtonSize;
            drawButton = new DrawModeButton();
            drawButton.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            drawButton.Click += button_Click;
            drawButton.Image = Properties.Resources.Pen;
            this.Controls.Add(drawButton);
            x += colorButtonSize + magion;

            fillButton = new DrawModeButton();
            fillButton.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            fillButton.Click += button_Click;
            fillButton.Image = Properties.Resources.Fill;
            this.Controls.Add(fillButton);
            x = magion + 2;
            y += colorButtonSize + magion;

            eraseButton = new DrawModeButton();
            eraseButton.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            eraseButton.Click += button_Click;
            eraseButton.Image = Properties.Resources.Erase;
            this.Controls.Add(eraseButton);
            x += colorButtonSize + magion;

            clearButton = new Button();
            clearButton.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            clearButton.Click += button_Click;
            clearButton.Image = Properties.Resources.Referesh;
            this.Controls.Add(clearButton);

        }

        void button_Click(object sender, EventArgs e)
        {
            if (sender == this.drawButton)
            {
                this.DrawMode = TouchEvent.DrawMode.Draw;
            }
            else if (sender == this.fillButton)
            {
                this.DrawMode = TouchEvent.DrawMode.Fill;
            }
            else if (sender == this.eraseButton)
            {
                this.DrawMode = TouchEvent.DrawMode.Erase;
            }
            else
            {
                this.Owner.RefereshPaintPanel();
            }
        }
    }

    public class DrawSizePanel : Panel
    {
        private int _drawSize;
        public int DrawSize
        {
            get
            {
                return _drawSize;
            }
            set
            {
                _drawSize = value;
            }
        }

        public DrawingBoardDemo Owner { get; set; }

        private SizeButton sizeButton1;
        private SizeButton sizeButton2;
        private SizeButton sizeButton3;
        private SizeButton sizeButton4;
        private SizeButton sizeButton5;
        private SizeButton sizeButton6;

        public DrawSizePanel()
        {
            InitializeComponent();
            this.DrawSize = 1;
            this.sizeButton1.Selected = true;
        }

        public void InitializeComponent()
        {
            int magion = DrawingBoardDemo.ColorButtonMagion;
            int x = magion + 3;
            int y = magion + 3;
            int colorButtonSize = DrawingBoardDemo.ColorButtonSize;
            sizeButton1 = new SizeButton();
            sizeButton1.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            sizeButton1.Click += button_Click;
            sizeButton1.DrawSize = 1;
            this.Controls.Add(sizeButton1);
            x += colorButtonSize + magion;

            sizeButton2 = new SizeButton();
            sizeButton2.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            sizeButton2.Click += button_Click;
            sizeButton2.DrawSize = 2;
            this.Controls.Add(sizeButton2);
            x += colorButtonSize + magion;

            sizeButton3 = new SizeButton();
            sizeButton3.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            sizeButton3.Click += button_Click;
            sizeButton3.DrawSize = 3;
            this.Controls.Add(sizeButton3);
            x = magion + 3;
            y += colorButtonSize + magion;

            sizeButton4 = new SizeButton();
            sizeButton4.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            sizeButton4.Click += button_Click;
            sizeButton4.DrawSize = 4;
            this.Controls.Add(sizeButton4);
            x += colorButtonSize + magion;

            sizeButton5 = new SizeButton();
            sizeButton5.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            sizeButton5.Click += button_Click;
            sizeButton5.DrawSize = 5;
            this.Controls.Add(sizeButton5);
            x += colorButtonSize + magion;

            sizeButton6 = new SizeButton();
            sizeButton6.Bounds = new Rectangle(x, y, colorButtonSize, colorButtonSize);
            sizeButton6.Click += button_Click;
            sizeButton6.DrawSize = 6;
            this.Controls.Add(sizeButton6);

        }

        void button_Click(object sender, EventArgs e)
        {
            this.sizeButton1.Selected = false;
            this.sizeButton2.Selected = false;
            this.sizeButton3.Selected = false;
            this.sizeButton4.Selected = false;
            this.sizeButton5.Selected = false;
            this.sizeButton6.Selected = false;
            (sender as SizeButton).Selected = true;
            if (sender == this.sizeButton1)
            {
                this.DrawSize = 1;
            }
            else if (sender == this.sizeButton2)
            {
                this.DrawSize = 2;
            }
            else if (sender == this.sizeButton3)
            {
                this.DrawSize = 3;
            }
            else if (sender == this.sizeButton4)
            {
                this.DrawSize = 4;
            }
            else if (sender == this.sizeButton5)
            {
                this.DrawSize = 5;
            }
            else
            {
                this.DrawSize = 6;
            }
        }
    }

    internal abstract class SelectableButton : Button
    {
        private bool _selected;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
                this.Invalidate();
            }
        }

        public SelectableButton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            OnPaintBackground(pevent.Graphics);
            OnPaintForeground(pevent.Graphics);
        }

        internal void OnPaintBackground(Graphics g)
        {
            Rectangle bounds = new Rectangle(Point.Empty, this.Size);
            g.Clear(Color.White);
            bounds.Width -= 1;
            bounds.Height -= 1;
            if (Selected)
            {
                g.FillRectangle(Brushes.LightBlue, bounds);
                g.DrawRectangle(Pens.Blue, bounds);
            }
            
        }

        internal abstract void OnPaintForeground(Graphics g);
    }

    internal class ColorButton : SelectableButton
    {
        internal override void OnPaintForeground(Graphics g)
        {
            Rectangle bounds = new Rectangle(Point.Empty, this.Size);
            bounds.Width -= 1;
            bounds.Height -= 1;
            bounds.Inflate(-5, -5);
            g.DrawRectangle(Pens.Black, bounds);
            bounds.Inflate(-1, -1);
            g.DrawRectangle(Pens.White, bounds);
            bounds.Inflate(-1, -1);
            using (Brush brush = new SolidBrush(this.BackColor))
            {
                g.FillRectangle(brush, bounds);
            }
            using (Brush brush = new SolidBrush(this.ForeColor))
            {
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                g.DrawString(this.Text, this.Font, brush, bounds, format);
            }
        }
    }

    internal class DrawModeButton : SelectableButton
    {
        internal override void OnPaintForeground(Graphics g)
        {
            Rectangle bounds = new Rectangle(Point.Empty, this.Size);
            bounds.Width -= 1;
            bounds.Height -= 1;
            if (this.Image != null)
            {
                bounds.Inflate(-3, -3);
                g.DrawImage(this.Image, bounds);
            }
        }
    }

    internal class SizeButton : SelectableButton
    {
        private int _drawSize;
        public int DrawSize
        {
            get
            {
                return _drawSize;
            }
            set
            {
                _drawSize = value;
            }
        }

        internal override void OnPaintForeground(Graphics g)
        {
            int x = 5;
            int y = (this.Height - DrawSize) / 2;
            int right = this.Width - x;
            using (Pen pen = new Pen(Color.Black))
            {
                pen.Width = DrawSize;
                g.DrawLine(pen, new Point(x, y), new Point(right, y));
            }
        }
    }
}
