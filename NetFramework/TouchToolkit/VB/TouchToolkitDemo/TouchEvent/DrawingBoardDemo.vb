Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TouchEvent
    Partial Public Class DrawingBoardDemo
        Inherits DemoBase
        Public Const ColorButtonSize As Integer = 30
        Public Const ColorButtonMagion As Integer = 2

        Public Sub New()
            InitializeComponent()
            Me.Title = "Drawing Board"
            Me.Description = "Please use pen to drawing. Erase by back button, fill color by side button, draw lines by pen."
            Me.paintPanel.Owner = Me
            Me.drawModePanel1.Owner = Me
            Me.gcTouchEventProvider1.EnablePenFlicks = False
        End Sub

        Public ReadOnly Property ForegroundColor() As Color
            Get
                Return Me.colorPanel1.ForegroundColor
            End Get
        End Property
        Public ReadOnly Property BackgroundColor() As Color
            Get
                Return Me.colorPanel1.BackgroundColor
            End Get
        End Property

        Public Property DrawMode() As DrawMode
            Get
                Return Me.drawModePanel1.DrawMode
            End Get
            Set(value As DrawMode)
                Me.drawModePanel1.DrawMode = value
            End Set
        End Property

        Public ReadOnly Property DrawSize() As Integer
            Get
                Return Me.drawSizePanel1.DrawSize
            End Get
        End Property

        Private _pointerDownPoint As Point
        Private _lastPoint As Point
        Private _penDown As Boolean

        Public Sub RefereshPaintPanel()
            Me.paintPanel.RefereshPaintPanel()
        End Sub

        Private Sub gcTouchEventProvider1_PointerMoved(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs) Handles gcTouchEventProvider1.PointerMoved
            If Not Object.ReferenceEquals(e.OriginalSource, Me.paintPanel) Then
                Return
            End If
            If _penDown Then
                UpdateDrawMode(e)
                Dim currentPoint As Point = PointToPaintPanel(e.Position)
                Process(currentPoint)
                _lastPoint = currentPoint
            End If
        End Sub

        Private Sub Process(currentPoint As Point)
            If Me.DrawMode = TouchEvent.DrawMode.[Erase] Then
                Me.paintPanel.[Erase](_lastPoint, currentPoint)
            ElseIf Me.DrawMode = TouchEvent.DrawMode.Fill Then
                Me.paintPanel.Fill(currentPoint)
            Else
                Me.paintPanel.Draw(_lastPoint, currentPoint)
            End If
        End Sub

        Private Sub UpdateDrawMode(e As C1.Win.TouchToolKit.PointerEventArgs)
            If e.DeviceType = C1.Win.TouchToolKit.PointerDeviceType.Pen Then
                If e.Properties.IsInverted OrElse e.Properties.IsEraser Then
                    Me.DrawMode = TouchEvent.DrawMode.[Erase]
                ElseIf e.Properties.IsBarrelButtonPressed Then
                    Me.DrawMode = TouchEvent.DrawMode.Fill
                Else
                    Me.DrawMode = TouchEvent.DrawMode.Draw
                End If
            End If

        End Sub

        Private Sub gcTouchEventProvider1_PointerPressed(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs) Handles gcTouchEventProvider1.PointerPressed
            If Not Object.ReferenceEquals(e.OriginalSource, Me.paintPanel) Then
                Return
            End If
            UpdateDrawMode(e)
            _penDown = True
            _pointerDownPoint = PointToPaintPanel(e.Position)
            _lastPoint = _pointerDownPoint
        End Sub

        Private Function PointToPaintPanel(point As Point) As Point
            Return Me.paintPanel.PointToClient(Me.panel1.PointToScreen(point))
        End Function

        Private Sub gcTouchEventProvider1_PointerReleased(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs) Handles gcTouchEventProvider1.PointerReleased
            _penDown = False
            Me.UpdateDrawMode(e)
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationCompleted(sender As Object, e As C1.Win.TouchToolKit.ManipulationCompletedEventArgs) Handles gcTouchEventProvider1.ManipulationCompleted
            e.Handled = True
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationDelta(sender As Object, e As C1.Win.TouchToolKit.ManipulationDeltaEventArgs) Handles gcTouchEventProvider1.ManipulationDelta
            e.Handled = True
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationInertiaStarting(sender As Object, e As C1.Win.TouchToolKit.ManipulationInertiaStartingEventArgs) Handles gcTouchEventProvider1.ManipulationInertiaStarting
            e.Handled = True
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationStarted(sender As Object, e As C1.Win.TouchToolKit.ManipulationStartedEventArgs) Handles gcTouchEventProvider1.ManipulationStarted
            e.Handled = True
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationStarting(sender As Object, e As C1.Win.TouchToolKit.ManipulationStartingEventArgs) Handles gcTouchEventProvider1.ManipulationStarting
            e.Handled = True
        End Sub
    End Class

    Public Class PaintPanel
        Inherits Panel
        Public ReadOnly Property ForegroundColor() As Color
            Get
                Return Me.Owner.ForegroundColor
            End Get
        End Property
        Public ReadOnly Property BackgroundColor() As Color
            Get
                Return Me.Owner.BackgroundColor
            End Get
        End Property

        Public Property Owner() As DrawingBoardDemo
            Get
                Return m_Owner
            End Get
            Set(value As DrawingBoardDemo)
                m_Owner = Value
            End Set
        End Property
        Private m_Owner As DrawingBoardDemo

        Public ReadOnly Property DrawSize() As Integer
            Get
                Return Me.Owner.DrawSize
            End Get
        End Property

        Private _img As Bitmap
        Private _graphics As Graphics
        Public Sub New()
            _img = New Bitmap(Me.Width, Me.Height)
            _graphics = Graphics.FromImage(_img)
            Me.DoubleBuffered = True
        End Sub

        Protected Overrides Sub OnSizeChanged(e As EventArgs)
            Dim tmpImg As New Bitmap(Me.Width, Me.Height)
            _graphics.Dispose()
            _graphics = Graphics.FromImage(tmpImg)
            _graphics.DrawImage(_img, Point.Empty)
            _img.Dispose()
            _img = tmpImg
            MyBase.OnSizeChanged(e)
        End Sub

        Public Sub Draw(startPoint As Point, endPoint As Point)
            Using pen As New Pen(Me.ForegroundColor)
                pen.Width = DrawSize
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round
                _graphics.DrawLine(pen, startPoint, endPoint)
            End Using
            Me.Invalidate()
        End Sub

        Public Sub [Erase](startPoint As Point, endPoint As Point)
            Using pen As New Pen(Me.BackgroundColor)
                pen.Width = DrawSize + 3
                _graphics.DrawLine(pen, startPoint, endPoint)
            End Using

            Me.Invalidate()
        End Sub

        Public Sub Fill(point As Point)
            Dim regionColor As Color = _img.GetPixel(point.X, point.Y)
            If (point.X = 0 OrElse _img.GetPixel(point.X - 1, point.Y).ToArgb() = ForegroundColor.ToArgb()) AndAlso (point.Y = 0 OrElse _img.GetPixel(point.X, point.Y - 1).ToArgb() = ForegroundColor.ToArgb()) AndAlso (point.X = _img.Width - 1 OrElse _img.GetPixel(point.X + 1, point.Y).ToArgb() = ForegroundColor.ToArgb()) AndAlso (point.Y = _img.Height - 1 OrElse _img.GetPixel(point.X, point.Y + 1).ToArgb() = ForegroundColor.ToArgb()) Then
                Return
            End If
            Dim flags As Integer(,) = New Integer(_img.Width - 1, _img.Height - 1) {}
            Fill(point, regionColor, flags)
            For y As Integer = 0 To _img.Height - 1
                For x As Integer = 0 To _img.Width - 1
                    If flags(x, y) > 0 Then
                        _img.SetPixel(x, y, ForegroundColor)
                    End If
                Next
            Next
            Me.Invalidate()
        End Sub

        Private Sub Fill(point As Point, regionColor As Color, flags As Integer(,))
            Dim queue As New Queue(Of Point)()
            queue.Enqueue(point)
            Dim currentPoint As Point
            While queue.Count > 0
                currentPoint = queue.Dequeue()
                Dim x As Integer = currentPoint.X
                Dim y As Integer = currentPoint.Y
                If _img.GetPixel(x, y).ToArgb() <> regionColor.ToArgb() Then
                    flags(x, y) = -1
                    Continue While
                End If
                flags(x, y) = 1
                ' left
                If x > 0 AndAlso flags(x - 1, y) = 0 Then
                    queue.Enqueue(New Point(x - 1, y))
                    flags(x - 1, y) = -1
                End If
                ' top
                If y > 0 AndAlso flags(x, y - 1) = 0 Then
                    queue.Enqueue(New Point(x, y - 1))
                    flags(x, y - 1) = -1
                End If
                ' right
                If x < _img.Width - 1 AndAlso flags(x + 1, y) = 0 Then
                    queue.Enqueue(New Point(x + 1, y))
                    flags(x + 1, y) = -1
                End If
                ' bottom 
                If y < _img.Height - 1 AndAlso flags(x, y + 1) = 0 Then
                    queue.Enqueue(New Point(x, y + 1))
                    flags(x, y + 1) = -1
                End If
            End While
        End Sub

        Public Sub RefereshPaintPanel()
            _graphics.Clear(BackgroundColor)
            Me.Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            e.Graphics.DrawImage(Me._img, Point.Empty)
        End Sub
    End Class

    Public Class ColorPanel
        Inherits Panel
        Public Sub New()
            Me.InitializeComponent()
            Me.BackgroundColor = Color.White
            Me.ForegroundColor = Color.Black
        End Sub

        Private _backColor As Color
        Public Property BackgroundColor() As Color
            Get
                Return _backColor
            End Get
            Set(value As Color)
                _backColor = value
                backColorButton.BackColor = value
                backColorButton.ForeColor = GetForeColor(value)
            End Set
        End Property

        Private _foreColor As Color
        Public Property ForegroundColor() As Color
            Get
                Return _foreColor
            End Get
            Set(value As Color)
                _foreColor = value
                foreColorButton.BackColor = value
                foreColorButton.ForeColor = GetForeColor(value)
            End Set
        End Property

        Private foreColorButton As SelectableButton
        Private backColorButton As SelectableButton
        Private editColorButton As Button

        Private Function GetForeColor(backColor As Color) As Color
            Return Color.FromArgb(GetInverseColorValue(backColor.R), GetInverseColorValue(backColor.G), GetInverseColorValue(backColor.B))
        End Function

        Private Function GetInverseColorValue(colorValue As Integer) As Integer
            If colorValue <= 106 OrElse colorValue >= 150 Then
                Return 255 - colorValue
            End If
            If colorValue < 128 Then
                Return 255
            End If
            Return 0
        End Function

        Public Sub InitializeComponent()
            Dim colors As Color(,) = New Color(,) {{Color.Black, Color.Gray, Color.Brown, Color.Red, Color.Orange, Color.Yellow, _
                Color.Green, Color.LightBlue, Color.Blue, Color.Violet}, {Color.White, Color.LightGray, Color.LightCoral, Color.Pink, Color.DarkOrange, Color.LightYellow, _
                Color.GreenYellow, Color.SkyBlue, Color.CadetBlue, Color.Tomato}}
            Dim magion As Integer = DrawingBoardDemo.ColorButtonMagion
            Dim x As Integer = magion + 2
            Dim y As Integer = magion + 2
            Dim colorButtonSize As Integer = DrawingBoardDemo.ColorButtonSize

            foreColorButton = New ColorButton()
            foreColorButton.Selected = True
            foreColorButton.Name = "foreColorButton"
            foreColorButton.Text = "Fore color"
            foreColorButton.Bounds = New Rectangle(x, y, colorButtonSize * 2, colorButtonSize * 2)
            AddHandler foreColorButton.Click, AddressOf button_Click
            Me.Controls.Add(foreColorButton)
            x = foreColorButton.Right + magion

            backColorButton = New ColorButton()
            backColorButton.Name = "backColorButton"
            backColorButton.Text = "Back color"
            backColorButton.Bounds = New Rectangle(x, y, colorButtonSize * 2, colorButtonSize * 2)
            AddHandler backColorButton.Click, AddressOf button_Click
            Me.Controls.Add(backColorButton)
            x = backColorButton.Right + magion

            Dim startX As Integer = x
            For i As Integer = 0 To colors.GetLength(0) - 1
                x = startX
                For j As Integer = 0 To colors.GetLength(1) - 1
                    Dim button As New Button()
                    AddHandler button.Click, AddressOf button_Click
                    button.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
                    button.BackColor = colors(i, j)
                    x = button.Right + magion
                    Me.Controls.Add(button)
                Next
                y = y + colorButtonSize + magion
            Next
            y = magion + 3
            x += 2
            editColorButton = New Button()
            editColorButton.Name = "editColorButton"
            editColorButton.Text = "Edit colors"
            editColorButton.Bounds = New Rectangle(x, y, colorButtonSize * 2, colorButtonSize * 2)
            AddHandler editColorButton.Click, AddressOf button_Click
            editColorButton.Image = My.Resources.ChooseColor
            editColorButton.TextImageRelation = TextImageRelation.ImageAboveText
            Me.Controls.Add(editColorButton)
        End Sub

        Private Sub button_Click(sender As Object, e As EventArgs)
            If Object.ReferenceEquals(sender, Me.foreColorButton) Then
                Me.foreColorButton.Selected = True
                Me.backColorButton.Selected = False
            ElseIf Object.ReferenceEquals(sender, Me.backColorButton) Then
                Me.foreColorButton.Selected = False
                Me.backColorButton.Selected = True
            ElseIf Object.ReferenceEquals(sender, Me.editColorButton) Then
                Dim dialog As New ColorDialog()
                dialog.ShowDialog(Me.FindForm())
                SelectColor(dialog.Color)
            Else
                SelectColor(TryCast(sender, Button).BackColor)
            End If
        End Sub

        Private Sub SelectColor(color As Color)
            If Me.foreColorButton.Selected Then
                Me.ForegroundColor = color
            Else
                Me.BackgroundColor = color
            End If
        End Sub
    End Class

    Public Enum DrawMode
        Draw
        Fill
        [Erase]
    End Enum

    Public Class DrawModePanel
        Inherits Panel
        Private _drawMode As DrawMode
        Public Property DrawMode() As DrawMode
            Get
                Return _drawMode
            End Get
            Set(value As DrawMode)
                _drawMode = value
                If _drawMode = TouchEvent.DrawMode.Draw Then
                    Me.drawButton.Selected = True
                    Me.fillButton.Selected = False
                    Me.eraseButton.Selected = False
                ElseIf _drawMode = TouchEvent.DrawMode.Fill Then
                    Me.drawButton.Selected = False
                    Me.fillButton.Selected = True
                    Me.eraseButton.Selected = False
                ElseIf _drawMode = TouchEvent.DrawMode.[Erase] Then
                    Me.drawButton.Selected = False
                    Me.fillButton.Selected = False
                    Me.eraseButton.Selected = True
                End If
            End Set
        End Property

        Public Property Owner() As DrawingBoardDemo
            Get
                Return m_Owner
            End Get
            Set(value As DrawingBoardDemo)
                m_Owner = Value
            End Set
        End Property
        Private m_Owner As DrawingBoardDemo

        Private drawButton As SelectableButton
        Private fillButton As SelectableButton
        Private eraseButton As SelectableButton
        Private clearButton As Button

        Public Sub New()
            InitializeComponent()
            Me.DrawMode = TouchEvent.DrawMode.Draw
        End Sub

        Public Sub InitializeComponent()
            Dim magion As Integer = DrawingBoardDemo.ColorButtonMagion
            Dim x As Integer = magion + 2
            Dim y As Integer = magion + 2
            Dim colorButtonSize As Integer = DrawingBoardDemo.ColorButtonSize
            drawButton = New DrawModeButton()
            drawButton.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler drawButton.Click, AddressOf button_Click
            drawButton.Image = My.Resources.Pen
            Me.Controls.Add(drawButton)
            x += colorButtonSize + magion

            fillButton = New DrawModeButton()
            fillButton.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler fillButton.Click, AddressOf button_Click
            fillButton.Image = My.Resources.Fill
            Me.Controls.Add(fillButton)
            x = magion + 2
            y += colorButtonSize + magion

            eraseButton = New DrawModeButton()
            eraseButton.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler eraseButton.Click, AddressOf button_Click
            eraseButton.Image = My.Resources._Erase
            Me.Controls.Add(eraseButton)
            x += colorButtonSize + magion

            clearButton = New Button()
            clearButton.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler clearButton.Click, AddressOf button_Click
            clearButton.Image = My.Resources.Referesh
            Me.Controls.Add(clearButton)

        End Sub

        Private Sub button_Click(sender As Object, e As EventArgs)
            If Object.ReferenceEquals(sender, Me.drawButton) Then
                Me.DrawMode = TouchEvent.DrawMode.Draw
            ElseIf Object.ReferenceEquals(sender, Me.fillButton) Then
                Me.DrawMode = TouchEvent.DrawMode.Fill
            ElseIf Object.ReferenceEquals(sender, Me.eraseButton) Then
                Me.DrawMode = TouchEvent.DrawMode.[Erase]
            Else
                Me.Owner.RefereshPaintPanel()
            End If
        End Sub
    End Class

    Public Class DrawSizePanel
        Inherits Panel
        Private _drawSize As Integer
        Public Property DrawSize() As Integer
            Get
                Return _drawSize
            End Get
            Set(value As Integer)
                _drawSize = value
            End Set
        End Property

        Public Property Owner() As DrawingBoardDemo
            Get
                Return m_Owner
            End Get
            Set(value As DrawingBoardDemo)
                m_Owner = Value
            End Set
        End Property
        Private m_Owner As DrawingBoardDemo

        Private sizeButton1 As SizeButton
        Private sizeButton2 As SizeButton
        Private sizeButton3 As SizeButton
        Private sizeButton4 As SizeButton
        Private sizeButton5 As SizeButton
        Private sizeButton6 As SizeButton

        Public Sub New()
            InitializeComponent()
            Me.DrawSize = 1
            Me.sizeButton1.Selected = True
        End Sub

        Public Sub InitializeComponent()
            Dim magion As Integer = DrawingBoardDemo.ColorButtonMagion
            Dim x As Integer = magion + 3
            Dim y As Integer = magion + 3
            Dim colorButtonSize As Integer = DrawingBoardDemo.ColorButtonSize
            sizeButton1 = New SizeButton()
            sizeButton1.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler sizeButton1.Click, AddressOf button_Click
            sizeButton1.DrawSize = 1
            Me.Controls.Add(sizeButton1)
            x += colorButtonSize + magion

            sizeButton2 = New SizeButton()
            sizeButton2.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler sizeButton2.Click, AddressOf button_Click
            sizeButton2.DrawSize = 2
            Me.Controls.Add(sizeButton2)
            x += colorButtonSize + magion

            sizeButton3 = New SizeButton()
            sizeButton3.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler sizeButton3.Click, AddressOf button_Click
            sizeButton3.DrawSize = 3
            Me.Controls.Add(sizeButton3)
            x = magion + 3
            y += colorButtonSize + magion

            sizeButton4 = New SizeButton()
            sizeButton4.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler sizeButton4.Click, AddressOf button_Click
            sizeButton4.DrawSize = 4
            Me.Controls.Add(sizeButton4)
            x += colorButtonSize + magion

            sizeButton5 = New SizeButton()
            sizeButton5.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler sizeButton5.Click, AddressOf button_Click
            sizeButton5.DrawSize = 5
            Me.Controls.Add(sizeButton5)
            x += colorButtonSize + magion

            sizeButton6 = New SizeButton()
            sizeButton6.Bounds = New Rectangle(x, y, colorButtonSize, colorButtonSize)
            AddHandler sizeButton6.Click, AddressOf button_Click
            sizeButton6.DrawSize = 6
            Me.Controls.Add(sizeButton6)

        End Sub

        Private Sub button_Click(sender As Object, e As EventArgs)
            Me.sizeButton1.Selected = False
            Me.sizeButton2.Selected = False
            Me.sizeButton3.Selected = False
            Me.sizeButton4.Selected = False
            Me.sizeButton5.Selected = False
            Me.sizeButton6.Selected = False
            TryCast(sender, SizeButton).Selected = True
            If Object.ReferenceEquals(sender, Me.sizeButton1) Then
                Me.DrawSize = 1
            ElseIf Object.ReferenceEquals(sender, Me.sizeButton2) Then
                Me.DrawSize = 2
            ElseIf Object.ReferenceEquals(sender, Me.sizeButton3) Then
                Me.DrawSize = 3
            ElseIf Object.ReferenceEquals(sender, Me.sizeButton4) Then
                Me.DrawSize = 4
            ElseIf Object.ReferenceEquals(sender, Me.sizeButton5) Then
                Me.DrawSize = 5
            Else
                Me.DrawSize = 6
            End If
        End Sub
    End Class

    Friend MustInherit Class SelectableButton
        Inherits Button
        Private _selected As Boolean
        Public Property Selected() As Boolean
            Get
                Return _selected
            End Get
            Set(value As Boolean)
                _selected = value
                Me.Invalidate()
            End Set
        End Property

        Public Sub New()
            Me.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        End Sub

        Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
            OnPaintBackground(pevent.Graphics)
            OnPaintForeground(pevent.Graphics)
        End Sub

        Friend Sub OnPaintBackground(g As Graphics)
            Dim bounds As New Rectangle(Point.Empty, Me.Size)
            g.Clear(Color.White)
            bounds.Width -= 1
            bounds.Height -= 1
            If Selected Then
                g.FillRectangle(Brushes.LightBlue, bounds)
                g.DrawRectangle(Pens.Blue, bounds)
            End If

        End Sub

        Friend MustOverride Sub OnPaintForeground(g As Graphics)
    End Class

    Friend Class ColorButton
        Inherits SelectableButton
        Friend Overrides Sub OnPaintForeground(g As Graphics)
            Dim bounds As New Rectangle(Point.Empty, Me.Size)
            bounds.Width -= 1
            bounds.Height -= 1
            bounds.Inflate(-5, -5)
            g.DrawRectangle(Pens.Black, bounds)
            bounds.Inflate(-1, -1)
            g.DrawRectangle(Pens.White, bounds)
            bounds.Inflate(-1, -1)
            Using brush As Brush = New SolidBrush(Me.BackColor)
                g.FillRectangle(brush, bounds)
            End Using
            Using brush As Brush = New SolidBrush(Me.ForeColor)
                Dim format As New StringFormat()
                format.Alignment = StringAlignment.Center
                format.LineAlignment = StringAlignment.Center
                g.DrawString(Me.Text, Me.Font, brush, bounds, format)
            End Using
        End Sub
    End Class

    Friend Class DrawModeButton
        Inherits SelectableButton
        Friend Overrides Sub OnPaintForeground(g As Graphics)
            Dim bounds As New Rectangle(Point.Empty, Me.Size)
            bounds.Width -= 1
            bounds.Height -= 1
            If Me.Image IsNot Nothing Then
                bounds.Inflate(-3, -3)
                g.DrawImage(Me.Image, bounds)
            End If
        End Sub
    End Class

    Friend Class SizeButton
        Inherits SelectableButton
        Private _drawSize As Integer
        Public Property DrawSize() As Integer
            Get
                Return _drawSize
            End Get
            Set(value As Integer)
                _drawSize = value
            End Set
        End Property

        Friend Overrides Sub OnPaintForeground(g As Graphics)
            Dim x As Integer = 5
            Dim y As Integer = (Me.Height - DrawSize) / 2
            Dim right As Integer = Me.Width - x
            Using pen As New Pen(Color.Black)
                pen.Width = DrawSize
                g.DrawLine(pen, New Point(x, y), New Point(right, y))
            End Using
        End Sub
    End Class
End Namespace
