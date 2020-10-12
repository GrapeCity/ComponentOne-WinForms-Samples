
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Chart



Public Class Form1
   Inherits Form
   
   Public Sub New()
      InitializeComponent()
      radioCompass.Checked = False
      radioCompass.Checked = True
      c1Chart1.ChartLabels(0).Text = "Rotating" + ControlChars.Cr + ControlChars.Lf + "Label"
   End Sub 'New
   
   
   Private Sub picSelect_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles picSelect.Paint
      Dim pic As PictureBox = sender
      If Not (pic Is Nothing) Then
         Dim g As Graphics = e.Graphics
         Dim f As Font = Me.Font
         Dim fs As Integer = CInt(f.SizeInPoints * e.Graphics.DpiY / 72)

         Dim rect As Rectangle = Rectangle.Inflate(pic.DisplayRectangle, -(12 + fs), -(12 + fs))
         Dim center As New Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2)

         If pic.Tag Is Nothing Then
            pic.Tag = rect
         End If

         Dim radiusi As Double = rect.Width / 2
         Dim radiuso As Double = radiusi + 5
         Dim radiuss As Double = radiuso + 5 + fs / 2

         Dim cps() As String = {"E", "SE", "S", "SW", "W", "NW", "N", "NE"}
         Dim inc As Integer = 360 / cps.Length

         Dim lce As LabelCompassEnum = c1Chart1.ChartLabels(0).Compass

         Dim s As Integer
         For s = 0 To cps.Length - 1
            Dim i As Integer = s * inc

            Dim brush As Brush = Brushes.Cornsilk
            If i Mod 2 = 0 Then brush = Brushes.CornflowerBlue

            Dim iTest As Integer = i
            If i > 180 Then iTest = i - 360
            Dim lceTest As LabelCompassEnum = getLabelCompassFromAngle(iTest)

            If radioCompass.Checked AndAlso lce = lceTest Then
               brush = Brushes.DarkRed
               g.FillPie(brush, rect, i - inc \ 2, inc)
               g.DrawPie(Pens.DarkBlue, rect, i - inc \ 2, inc)
            Else
               g.FillPie(brush, rect, i - inc \ 2, inc)
            End If
            Dim angle As Double = i * Math.PI / 180
            Dim cos As Double = Math.Cos(angle)
            Dim sin As Double = Math.Sin(angle)

            Dim str As String = cps(s)
            If radioRotation.Checked Then str = i.ToString()

            Dim sz As SizeF = g.MeasureString(str, f)

            Dim tick As New Point(CInt(center.X + radiusi * cos), CInt(center.Y + radiusi * sin))
            Dim tickr As New Point(CInt(center.X + radiuso * cos), CInt(center.Y + radiuso * sin))
            Dim sloc As New Point(CInt(center.X + radiuss * cos - sz.Width \ 2), CInt(center.Y + radiuss * sin - sz.Height \ 2))

            g.DrawLine(Pens.Black, tick, tickr)
            g.DrawString(str, Me.Font, Brushes.Black, sloc)
         Next s

         If radioRotation.Checked Then
            Dim angle As Double = c1Chart1.ChartLabels(0).RotationOverride * Math.PI / 180
            Dim cos As Double = Math.Cos(angle)
            Dim sin As Double = Math.Sin(angle)

            Dim tick As New Point(CInt(center.X + radiusi * cos), CInt(center.Y + radiusi * sin))
            g.DrawLine(Pens.DarkRed, center, tick)
         End If

         g.DrawEllipse(Pens.Black, rect)
      End If
   End Sub

   Private Sub radioCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioRotation.CheckedChanged, radioCompass.CheckedChanged
      Dim radio As RadioButton = sender
      If Not (radio Is Nothing) AndAlso radio.Checked Then
         Dim gb As GroupBox = radio.Parent
         If Not (gb Is Nothing) Then
            gb.Text = "Click image to select a " + radio.Text
         End If
         picSelect.Refresh()
      End If
   End Sub  'radioCheckedChanged

   Private Sub picSelect_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picSelect.MouseDown
      If TypeOf picSelect.Tag Is Rectangle Then
         Dim r As Rectangle = CType(picSelect.Tag, Rectangle)
         Dim center As New Point(r.X + r.Width / 2, r.Y + r.Height / 2)

         Dim dist As Integer = CInt(Math.Round(Math.Sqrt(((e.X - center.X) * (e.X - center.X) + (e.Y - center.Y) * (e.Y - center.Y)))))
         If dist <= r.Width / 2 Then
            Dim angle As Double = Math.Atan2(e.Y - center.Y, e.X - center.X) * 180 / Math.PI
            If radioCompass.Checked Then
               setLabelCompassFromAngle(angle)
            ElseIf radioRotation.Checked Then
               setLabelRotationOverride(angle)
            End If
         End If
      End If
   End Sub  'picSelect_MouseDown

   Private Function getLabelCompassFromAngle(angle As Double) As LabelCompassEnum
      Dim lce As LabelCompassEnum = LabelCompassEnum.East
      
      If angle >= - 22.5 AndAlso angle < 22.5 Then
         lce = LabelCompassEnum.East
      ElseIf angle >= 22.5 AndAlso angle < 67.5 Then
         lce = LabelCompassEnum.SouthEast
      ElseIf angle >= 67.5 AndAlso angle < 112.5 Then
         lce = LabelCompassEnum.South
      ElseIf angle >= 112.5 AndAlso angle < 157.5 Then
         lce = LabelCompassEnum.SouthWest
      ElseIf angle >= 157.5 OrElse angle <= - 157.5 Then
         lce = LabelCompassEnum.West
      ElseIf angle <= - 112.5 AndAlso angle > - 157.5 Then
         lce = LabelCompassEnum.NorthWest
      ElseIf angle <= - 67.5 AndAlso angle > - 112.5 Then
         lce = LabelCompassEnum.North
      ElseIf angle <= - 22.5 AndAlso angle > - 67.5 Then
         lce = LabelCompassEnum.NorthEast
      End If 
      Return lce
   End Function 'getLabelCompassFromAngle

   Private Sub setLabelCompassFromAngle(angle As Double)
      c1Chart1.ChartLabels(0).Compass = getLabelCompassFromAngle(angle)
      picSelect.Refresh()
   End Sub 'setLabelCompassFromAngle

   Private Sub setLabelRotationOverride(angle As Double)
      Dim lab As C1.Win.C1Chart.Label = Nothing
      If c1Chart1.ChartLabels.LabelsCollection.Count > 0 Then
         lab = c1Chart1.ChartLabels(0)
         lab.RotationOverride = CInt(angle)
         picSelect.Refresh()
      End If
   End Sub 'setLabelRotationOverride

   Private Sub c1Chart1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles c1Chart1.DoubleClick
      Dim frm As New Form()
      Dim pg As New PropertyGrid()
      pg.SelectedObject = c1Chart1.ChartLabels(0)
      pg.Dock = DockStyle.Fill
      frm.Controls.Add(pg)
      frm.ShowDialog()
   End Sub  'c1Chart1_DoubleClick
End Class 'Form1
