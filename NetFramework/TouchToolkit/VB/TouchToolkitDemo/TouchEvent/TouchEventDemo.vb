Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Namespace TouchEvent
    Partial Public Class TouchEventDemo
        Inherits DemoBase
        Public Sub New()
            InitializeComponent()
            Me.Title = "Image Viewer"
            Me.Description = "Use C1TouchEventProvider to make a Picture viewer, you can zoom, pan, rotate the picture."
            Me.TouchMode = MyTouchMode.[Default]
        End Sub

        Private startLocation As Point() = New Point() {New Point(37, 77), New Point(413, 56), New Point(448, 230), New Point(262, 124), New Point(169, 160)}
        Private startRatation As Double() = New Double() {3, 20, 27, 37, 36}

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            Me.paintPanel1.AddImage(My.Resources.Cherry)
            Me.paintPanel1.AddImage(My.Resources.Cat2)
            Me.paintPanel1.AddImage(My.Resources.F22)
            Me.paintPanel1.AddImage(My.Resources.Ln)
            Me.paintPanel1.AddImage(My.Resources.SL)

            Dim width As Integer = Me.Width
            Dim height As Integer = Me.Height
            Dim r As New Random()
            For i As Integer = 0 To Me.paintPanel1.ImageBounds.Count - 1
                Dim bounds As Rectangle = Me.paintPanel1.ImageBounds(i)

                If bounds.Width > width / 2 Then
                    bounds.Width = bounds.Width / 2
                    bounds.Height = bounds.Height / 2
                End If
                bounds.Location = startLocation(i)
                Me.paintPanel1.ImageBounds(i) = bounds
                Me.paintPanel1.Rotations(i) = startRatation(i)
            Next
        End Sub

        Private position As Point
        Private size As Size
        Private startSize As Size
        Private startPositionPercent As System.Nullable(Of SizeF)
        Private _mode As MyTouchMode
        Private Property TouchMode() As MyTouchMode
            Get
                Return _mode
            End Get
            Set(value As MyTouchMode)
                _mode = value
                Me.paintPanel1.TouchMoe = value
                Me.paintPanel1.Invalidate()
            End Set
        End Property
        Private manipulationMode As ManipulationModes

        Private Sub gcTouchEventProvider1_ManipulationDelta(sender As Object, e As C1.Win.TouchToolKit.ManipulationDeltaEventArgs)
            Dim pointerPosition As Point = e.Position
            'this.paintPanel1.PointToClient(e.Position);
            Dim tmpSize As New Size(CInt(startSize.Width * e.Cumulative.Scale), CInt(startSize.Height * e.Cumulative.Scale))

            If e.Cumulative.Scale <> 1.0 AndAlso Not startPositionPercent.HasValue Then
                Me.startPositionPercent = New SizeF((pointerPosition.X - position.X) / CSng(size.Width), (pointerPosition.Y - position.Y) / CSng(size.Height))
            ElseIf startPositionPercent.HasValue Then
                position = New Point(pointerPosition.X - CInt(tmpSize.Width * startPositionPercent.Value.Width), pointerPosition.Y - CInt(tmpSize.Height * startPositionPercent.Value.Height))
            Else
                position = New Point(position.X + e.Delta.Translation.X, position.Y + e.Delta.Translation.Y)
            End If
            Dim minSize As Integer = 50
            tmpSize.Width = If(tmpSize.Width < minSize, minSize, tmpSize.Width)
            tmpSize.Height = If(tmpSize.Height < minSize, minSize, tmpSize.Height)
            If position.X + size.Width < minSize Then
                position.X = minSize - size.Width
            End If
            If position.Y + size.Height < minSize Then
                position.Y = minSize - size.Height
            End If
            If position.Y + minSize > paintPanel1.Height Then
                position.Y = paintPanel1.Height - minSize
            End If
            If position.X + minSize > paintPanel1.Width Then
                position.X = paintPanel1.Width - minSize
            End If
            Me.paintPanel1.ManipulationPosition = pointerPosition

            If Me.paintPanel1.ActiveImageIndex >= 0 Then
                size = tmpSize
                Me.paintPanel1.ImageBounds(Me.paintPanel1.ActiveImageIndex) = New Rectangle(position, size)
                Me.paintPanel1.Rotations(Me.paintPanel1.ActiveImageIndex) += e.Delta.Rotation
                Me.paintPanel1.Invalidate()
            End If
            If Me.paintPanel1.ActiveImageIndex <> -1 AndAlso manipulationMode = ManipulationModes.All OrElse TouchMode = MyTouchMode.Pivort Then
                e.Handled = True
            End If
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationStarted(sender As Object, e As C1.Win.TouchToolKit.ManipulationStartedEventArgs)
            If Me.paintPanel1.ActiveImageIndex >= 0 Then
                size = Me.paintPanel1.ImageBounds(Me.paintPanel1.ActiveImageIndex).Size
                startSize = size
                position = Me.paintPanel1.ImageBounds(Me.paintPanel1.ActiveImageIndex).Location
                startPositionPercent = Nothing
            End If
            If Me.paintPanel1.ActiveImageIndex <> -1 AndAlso manipulationMode = ManipulationModes.All OrElse TouchMode = MyTouchMode.Pivort Then
                e.Handled = True
            End If
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationStarting(sender As Object, e As C1.Win.TouchToolKit.ManipulationStartingEventArgs)
            Dim pointerPosition As Point = e.Position
            Dim hitTest As Boolean = Me.paintPanel1.HitTest(pointerPosition)
            If Me.TouchMode = MyTouchMode.[Default] Then
                If hitTest Then
                    e.Mode = ManipulationModes.All
                Else
                    e.Mode = ManipulationModes.Rotate Or ManipulationModes.RotateInertia
                End If
            Else
                If Me.paintPanel1.ActiveImageIndex <> -1 Then
                    Dim pivot As New ManipulationPivot()
                    pivot.Center = Me.paintPanel1.GetImageCenter(Me.paintPanel1.ActiveImageIndex)
                    pivot.Radius = Me.paintPanel1.GetImageRadius(Me.paintPanel1.ActiveImageIndex)
                    e.Pivot = pivot
                End If
                e.Mode = ManipulationModes.Rotate Or ManipulationModes.RotateInertia
            End If
            manipulationMode = e.Mode
            If e.Mode = ManipulationModes.All Then
                e.Handled = True
            End If
        End Sub

        Private Sub gcTouchEventProvider1_Tapped(sender As Object, e As TappedEventArgs)
            If Not Object.ReferenceEquals(e.OriginalSource, Me.paintPanel1) Then
                Me.paintPanel1.ActiveImageIndex = -1
            End If
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationInertiaStarting(sender As Object, e As ManipulationInertiaStartingEventArgs)
            e.TranslationBehavior.DesiredDeceleration = 0.008F
            e.TranslationBehavior.DesiredDisplacement = 200
            If Me.paintPanel1.ActiveImageIndex <> -1 AndAlso manipulationMode = ManipulationModes.All OrElse TouchMode = MyTouchMode.Pivort Then
                e.Handled = True
            End If
        End Sub

        Private Sub gcTouchEventProvider1_ManipulationCompleted(sender As Object, e As ManipulationCompletedEventArgs)
            If Me.paintPanel1.ActiveImageIndex <> -1 AndAlso manipulationMode = ManipulationModes.All OrElse TouchMode = MyTouchMode.Pivort Then
                e.Handled = True
            End If
        End Sub

        Private Sub ModeRadioButton_CheckedChanged(sender As Object, e As EventArgs)
            If defaultRadioButton.Checked Then
                Me.TouchMode = MyTouchMode.[Default]
            Else
                Me.TouchMode = MyTouchMode.Pivort
            End If
        End Sub
    End Class


    Friend Interface IWndProcHooker
        Function ProcessWndProc(ByRef m As Message) As Boolean
    End Interface

    Friend Class ControlNativeWindow
        Inherits NativeWindow
        Private _owner As Control
        Private _hooker As IWndProcHooker
        Private _handle As IntPtr = IntPtr.Zero

        Friend ReadOnly Property Owner() As Control
            Get
                Return _owner
            End Get
        End Property

        Friend ReadOnly Property Hooker() As IWndProcHooker
            Get
                Return _hooker
            End Get
        End Property

        Friend Sub New(control As Control, hooker As IWndProcHooker)
            _owner = control
            _hooker = hooker
            _handle = IntPtr.Zero

            If _owner.IsHandleCreated Then
                OnOwnerHandleCreated(_owner, EventArgs.Empty)
            End If
            AddHandler _owner.HandleCreated, New EventHandler(AddressOf Me.OnOwnerHandleCreated)
            AddHandler _owner.HandleDestroyed, New EventHandler(AddressOf Me.OnOwnerHandleDestroyed)
        End Sub

        Friend Sub New(handle As IntPtr, hooker As IWndProcHooker)
            _owner = Nothing
            _handle = handle
            _hooker = hooker

            OnOwnerHandleCreated(Me, EventArgs.Empty)
        End Sub

        Friend Overridable Sub DetachHandle()
            Me.ReleaseHandle()
        End Sub

        Friend Overridable Sub OnOwnerHandleCreated(sender As Object, e As EventArgs)
            If _owner IsNot Nothing Then
                Me.AssignHandle(_owner.Handle)
            Else
                Me.AssignHandle(Me._handle)
            End If
        End Sub

        Friend Overridable Sub OnOwnerHandleDestroyed(sender As Object, e As EventArgs)
            Me.DetachHandle()
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            If Not _hooker.ProcessWndProc(m) Then
                MyBase.WndProc(m)
            End If
        End Sub
    End Class

    Friend Enum MyTouchMode
        [Default]
        Pivort
    End Enum

    Public Class ImagePanel
        Inherits Panel
        Public ImageBounds As New List(Of Rectangle)()
        Public Rotations As New List(Of Double)()
        Private Images As New List(Of Image)()
        Public Property ManipulationPosition() As Point
            Get
                Return m_ManipulationPosition
            End Get
            Set(value As Point)
                m_ManipulationPosition = Value
            End Set
        End Property
        Private m_ManipulationPosition As Point

        Private _activeImageIndex As Integer = -1
        Public Property ActiveImageIndex() As Integer
            Get
                Return _activeImageIndex
            End Get
            Set(value As Integer)
                If _activeImageIndex <> value Then
                    _activeImageIndex = value
                    Me.Invalidate()
                End If
            End Set
        End Property

        Friend Property TouchMoe() As MyTouchMode
            Get
                Return m_TouchMoe
            End Get
            Set(value As MyTouchMode)
                m_TouchMoe = Value
            End Set
        End Property
        Private m_TouchMoe As MyTouchMode

        Public Sub AddImage(image As Image)
            Dim size As Size = image.Size
            If size.Width > 450 OrElse size.Height > 450 Then
                Dim scale As Double = Math.Min(450.0 / size.Width, 450.0 / size.Height)
                size.Width = CInt(scale * size.Width)
                size.Height = CInt(scale * size.Height)
            End If
            ImageBounds.Add(New Rectangle(Point.Empty, size))
            Rotations.Add(0.0)
            Images.Add(image)
        End Sub

        Public Function HitTest(position As Point) As Boolean
            If Me.ActiveImageIndex <> -1 AndAlso Me.ImageBounds(ActiveImageIndex).Contains(position) Then
                'ManipulationPivot pivot = new ManipulationPivot(new Point(this.paintPanel1.Width / 2, this.paintPanel1.Height / 2), this.paintPanel1.Height / 2);
                'e.Pivot = pivot; 
                Return True
            Else
                For i As Integer = 0 To Me.Images.Count - 1
                    If Me.ImageBounds(i).Contains(position) Then
                        Me.ActiveImageIndex = i
                        Return True
                    End If
                Next
            End If
            Return False
        End Function

        Public Sub New()
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            For i As Integer = Me.Images.Count - 1 To 0 Step -1
                If i = Me.ActiveImageIndex Then
                    Continue For
                End If
                DrawImage(e, i)
            Next
            If Me.ActiveImageIndex <> -1 AndAlso Me.ActiveImageIndex < Me.Images.Count Then
                DrawImage(e, Me.ActiveImageIndex)
                Dim bounds As Rectangle = Me.ImageBounds(Me.ActiveImageIndex)
                If TouchMoe = MyTouchMode.[Default] Then
                    Dim pen As New Pen(Color.Gray)
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
                    bounds = New Rectangle(bounds.X - 1, bounds.Y - 1, bounds.Width + 2, bounds.Height + 2)
                    e.Graphics.DrawRectangle(pen, bounds)
                    pen.Dispose()
                Else
                    Dim center As Point = Me.GetImageCenter(Me.ActiveImageIndex)
                    Dim radius As Integer = CInt(Me.GetImageRadius(Me.ActiveImageIndex))
                    bounds.Location = New Point(center.X - radius - 1, center.Y - radius - 1)
                    bounds.Size = New Size(radius * 2, radius * 2)
                    Dim pen As New Pen(Color.Gray)
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
                    e.Graphics.DrawEllipse(pen, bounds)
                    pen.Dispose()
                End If
            End If
        End Sub

        Public Function GetImageCenter(index As Integer) As Point
            Dim center As New Point(Me.ImageBounds(index).X + Me.ImageBounds(index).Width / 2, Me.ImageBounds(index).Y + Me.ImageBounds(index).Height / 2)
            Return center
        End Function



        Public Function GetImageRadius(index As Integer) As Single
            Dim bounds As Rectangle = Me.ImageBounds(index)
            Return CSng(Math.Sqrt(bounds.Width * bounds.Width / 4.0 + bounds.Height * bounds.Height / 4.0))
        End Function

        Private Sub DrawImage(e As PaintEventArgs, index As Integer)
            Dim location As New Point()
            If Rotations(index) <> 0.0 Then
                Dim center As Point = GetImageCenter(index)
                e.Graphics.RenderingOrigin = center
                e.Graphics.TranslateTransform(center.X, center.Y)
                location = New Point(-center.X, -center.Y)
                e.Graphics.RotateTransform(CSng(Rotations(index)))
                e.Graphics.RenderingOrigin = Point.Empty
            End If
            location.Offset(Me.ImageBounds(index).Location)
            e.Graphics.DrawImage(Me.Images(index), New Rectangle(location, Me.ImageBounds(index).Size))

            If Rotations(index) <> 0.0 Then
                e.Graphics.ResetTransform()
            End If
        End Sub
    End Class
End Namespace
