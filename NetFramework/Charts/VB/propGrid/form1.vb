
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics

Imports C1.Win.C1Chart




'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private propertyGrid1 As System.Windows.Forms.PropertyGrid
   WithEvents C1Chart1 As C1.Win.C1Chart.C1Chart
   Private mainMenu1 As System.Windows.Forms.MenuStrip
   WithEvents menuItem1 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem2 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuSepItem4 As System.Windows.Forms.ToolStripSeparator
   WithEvents menuItem5 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem6 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuSepItem7 As System.Windows.Forms.ToolStripSeparator
   WithEvents menuItem8 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem9 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem10 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem11 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem12 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem13 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem14 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem15 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem16 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem17 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuSepItem18 As System.Windows.Forms.ToolStripSeparator
   WithEvents menuItem19 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem3 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem20 As System.Windows.Forms.ToolStripMenuItem

   Private cInfoLabel As String = "FloatingInfo"
   Private hole_value As Single = Single.MaxValue
   WithEvents menuItem21 As System.Windows.Forms.ToolStripMenuItem
   Private m_unique As Integer = 0
   WithEvents menuItem22 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem23 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem24 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem25 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem26 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem27 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem28 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem29 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem30 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem31 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem32 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem33 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem34 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem35 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem36 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem37 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem38 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem39 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem40 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem41 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem42 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem43 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem44 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem45 As System.Windows.Forms.ToolStripMenuItem

   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing


   Public Sub New()
      InitializeComponent()
   End Sub 'New


   '/ <summary>
   '/ Clean up any resources being used.
   '/ </summary>
   Public Shadows Sub Dispose()
      MyBase.Dispose()
      If Not (components Is Nothing) Then
         components.Dispose()
      End If
   End Sub 'Dispose

#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
      Me.menuItem19 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuSepItem18 = New System.Windows.Forms.ToolStripSeparator
      Me.menuItem15 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem14 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem16 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem17 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem11 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem10 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem13 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem12 = New System.Windows.Forms.ToolStripMenuItem
      Me.C1Chart1 = New C1.Win.C1Chart.C1Chart
      Me.mainMenu1 = New System.Windows.Forms.MenuStrip
      Me.menuItem1 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem2 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem28 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem3 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem20 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem33 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem21 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem29 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem22 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem23 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem24 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem25 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem26 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem30 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem27 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem32 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem31 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuSepItem4 = New System.Windows.Forms.ToolStripSeparator
      Me.menuItem6 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem34 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem42 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem43 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem44 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem45 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem35 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem36 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem37 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem38 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem39 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem40 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem8 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem9 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuSepItem7 = New System.Windows.Forms.ToolStripSeparator
      Me.menuItem5 = New System.Windows.Forms.ToolStripMenuItem
      Me.menuItem41 = New System.Windows.Forms.ToolStripMenuItem
      Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
      CType(Me.C1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.mainMenu1.SuspendLayout()
      Me.SuspendLayout()
      '
      'menuItem19
      '
      Me.menuItem19.Name = "menuItem19"
      Me.menuItem19.Size = New System.Drawing.Size(142, 22)
      Me.menuItem19.Text = "Default Print"
      '
      'menuSepItem18
      '
      Me.menuSepItem18.Name = "menuSepItem18"
      Me.menuSepItem18.Size = New System.Drawing.Size(149, 6)
      '
      'menuItem15
      '
      Me.menuItem15.Name = "menuItem15"
      Me.menuItem15.Size = New System.Drawing.Size(152, 22)
      Me.menuItem15.Text = "Page Setup ..."
      '
      'menuItem14
      '
      Me.menuItem14.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem15, Me.menuItem16, Me.menuSepItem18, Me.menuItem17})
      Me.menuItem14.Name = "menuItem14"
      Me.menuItem14.Size = New System.Drawing.Size(51, 20)
      Me.menuItem14.Text = "Printer"
      '
      'menuItem16
      '
      Me.menuItem16.Name = "menuItem16"
      Me.menuItem16.Size = New System.Drawing.Size(152, 22)
      Me.menuItem16.Text = "Printer Setup ..."
      '
      'menuItem17
      '
      Me.menuItem17.Name = "menuItem17"
      Me.menuItem17.Size = New System.Drawing.Size(152, 22)
      Me.menuItem17.Text = "Dialog on Print"
      '
      'menuItem11
      '
      Me.menuItem11.Name = "menuItem11"
      Me.menuItem11.Size = New System.Drawing.Size(142, 22)
      Me.menuItem11.Text = "ScaleToMax"
      '
      'menuItem10
      '
      Me.menuItem10.Name = "menuItem10"
      Me.menuItem10.Size = New System.Drawing.Size(142, 22)
      Me.menuItem10.Text = "ScaleToHeight"
      '
      'menuItem13
      '
      Me.menuItem13.Name = "menuItem13"
      Me.menuItem13.Size = New System.Drawing.Size(142, 22)
      Me.menuItem13.Text = "ScaleNone"
      '
      'menuItem12
      '
      Me.menuItem12.Name = "menuItem12"
      Me.menuItem12.Size = New System.Drawing.Size(142, 22)
      Me.menuItem12.Text = "ScaleToWidth"
      '
      'C1Chart1
      '
      Me.C1Chart1.BackColor = System.Drawing.Color.SlateGray
      Me.C1Chart1.Location = New System.Drawing.Point(336, 29)
      Me.C1Chart1.Name = "C1Chart1"
      Me.C1Chart1.PropBag = resources.GetString("C1Chart1.PropBag")
      Me.C1Chart1.Size = New System.Drawing.Size(336, 360)
      Me.C1Chart1.TabIndex = 1
      '
      'mainMenu1
      '
      Me.mainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem1, Me.menuItem14, Me.menuItem41})
      Me.mainMenu1.Location = New System.Drawing.Point(0, 0)
      Me.mainMenu1.Name = "mainMenu1"
      Me.mainMenu1.Size = New System.Drawing.Size(700, 24)
      Me.mainMenu1.TabIndex = 2
      '
      'menuItem1
      '
      Me.menuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem2, Me.menuItem28, Me.menuItem3, Me.menuItem20, Me.menuItem33, Me.menuItem21, Me.menuItem29, Me.menuItem22, Me.menuItem23, Me.menuItem24, Me.menuItem25, Me.menuItem26, Me.menuItem30, Me.menuItem27, Me.menuItem32, Me.menuItem31, Me.menuSepItem4, Me.menuItem6, Me.menuItem34, Me.menuItem35, Me.menuItem38, Me.menuItem8, Me.menuSepItem7, Me.menuItem5})
      Me.menuItem1.Name = "menuItem1"
      Me.menuItem1.Size = New System.Drawing.Size(83, 20)
      Me.menuItem1.Text = "DemoOptions"
      '
      'menuItem2
      '
      Me.menuItem2.Name = "menuItem2"
      Me.menuItem2.Size = New System.Drawing.Size(207, 22)
      Me.menuItem2.Text = "XY Plot - Trig Functions"
      '
      'menuItem28
      '
      Me.menuItem28.Name = "menuItem28"
      Me.menuItem28.Size = New System.Drawing.Size(207, 22)
      Me.menuItem28.Text = "Stacked XY Plot"
      '
      'menuItem3
      '
      Me.menuItem3.Name = "menuItem3"
      Me.menuItem3.Size = New System.Drawing.Size(207, 22)
      Me.menuItem3.Text = "Pie Charts"
      '
      'menuItem20
      '
      Me.menuItem20.Name = "menuItem20"
      Me.menuItem20.Size = New System.Drawing.Size(207, 22)
      Me.menuItem20.Text = "Bar Chart"
      '
      'menuItem33
      '
      Me.menuItem33.Name = "menuItem33"
      Me.menuItem33.Size = New System.Drawing.Size(207, 22)
      Me.menuItem33.Text = "Stacked Bar Chart"
      '
      'menuItem21
      '
      Me.menuItem21.Name = "menuItem21"
      Me.menuItem21.Size = New System.Drawing.Size(207, 22)
      Me.menuItem21.Text = "Area Chart - Trig Functions"
      '
      'menuItem29
      '
      Me.menuItem29.Name = "menuItem29"
      Me.menuItem29.Size = New System.Drawing.Size(207, 22)
      Me.menuItem29.Text = "Stacked Area Chart"
      '
      'menuItem22
      '
      Me.menuItem22.Name = "menuItem22"
      Me.menuItem22.Size = New System.Drawing.Size(207, 22)
      Me.menuItem22.Text = "Hi-Lo Chart"
      '
      'menuItem23
      '
      Me.menuItem23.Name = "menuItem23"
      Me.menuItem23.Size = New System.Drawing.Size(207, 22)
      Me.menuItem23.Text = "Hi-Lo-Open-Close"
      '
      'menuItem24
      '
      Me.menuItem24.Name = "menuItem24"
      Me.menuItem24.Size = New System.Drawing.Size(207, 22)
      Me.menuItem24.Text = "Bubble Chart"
      '
      'menuItem25
      '
      Me.menuItem25.Name = "menuItem25"
      Me.menuItem25.Size = New System.Drawing.Size(207, 22)
      Me.menuItem25.Text = "Candle Chart"
      '
      'menuItem26
      '
      Me.menuItem26.Name = "menuItem26"
      Me.menuItem26.Size = New System.Drawing.Size(207, 22)
      Me.menuItem26.Text = "Polar Chart"
      '
      'menuItem30
      '
      Me.menuItem30.Name = "menuItem30"
      Me.menuItem30.Size = New System.Drawing.Size(207, 22)
      Me.menuItem30.Text = "Stacked Polar Chart"
      '
      'menuItem27
      '
      Me.menuItem27.Name = "menuItem27"
      Me.menuItem27.Size = New System.Drawing.Size(207, 22)
      Me.menuItem27.Text = "Radar Chart"
      '
      'menuItem32
      '
      Me.menuItem32.Name = "menuItem32"
      Me.menuItem32.Size = New System.Drawing.Size(207, 22)
      Me.menuItem32.Text = "Simple Stacked Radar Chart"
      '
      'menuItem31
      '
      Me.menuItem31.Name = "menuItem31"
      Me.menuItem31.Size = New System.Drawing.Size(207, 22)
      Me.menuItem31.Text = "Stacked Radar Chart"
      '
      'menuSepItem4
      '
      Me.menuSepItem4.Name = "menuSepItem4"
      Me.menuSepItem4.Size = New System.Drawing.Size(204, 6)
      '
      'menuItem6
      '
      Me.menuItem6.Name = "menuItem6"
      Me.menuItem6.Size = New System.Drawing.Size(207, 22)
      Me.menuItem6.Text = "Reset C1Chart"
      '
      'menuItem34
      '
      Me.menuItem34.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem42, Me.menuItem43})
      Me.menuItem34.Name = "menuItem34"
      Me.menuItem34.Size = New System.Drawing.Size(207, 22)
      Me.menuItem34.Text = "Save Chart Image"
      '
      'menuItem42
      '
      Me.menuItem42.Name = "menuItem42"
      Me.menuItem42.Size = New System.Drawing.Size(157, 22)
      Me.menuItem42.Text = "Save to file"
      '
      'menuItem43
      '
      Me.menuItem43.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem44, Me.menuItem45})
      Me.menuItem43.Name = "menuItem43"
      Me.menuItem43.Size = New System.Drawing.Size(157, 22)
      Me.menuItem43.Text = "Save to clipboard"
      '
      'menuItem44
      '
      Me.menuItem44.Name = "menuItem44"
      Me.menuItem44.Size = New System.Drawing.Size(108, 22)
      Me.menuItem44.Text = "as BMP"
      '
      'menuItem45
      '
      Me.menuItem45.Name = "menuItem45"
      Me.menuItem45.Size = New System.Drawing.Size(108, 22)
      Me.menuItem45.Text = "as EMF"
      '
      'menuItem35
      '
      Me.menuItem35.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem36, Me.menuItem37})
      Me.menuItem35.Name = "menuItem35"
      Me.menuItem35.Size = New System.Drawing.Size(207, 22)
      Me.menuItem35.Text = "Save/Load Chart"
      '
      'menuItem36
      '
      Me.menuItem36.Name = "menuItem36"
      Me.menuItem36.Size = New System.Drawing.Size(141, 22)
      Me.menuItem36.Text = "Save to File"
      '
      'menuItem37
      '
      Me.menuItem37.Name = "menuItem37"
      Me.menuItem37.Size = New System.Drawing.Size(141, 22)
      Me.menuItem37.Text = "Load from File"
      '
      'menuItem38
      '
      Me.menuItem38.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem39, Me.menuItem40})
      Me.menuItem38.Name = "menuItem38"
      Me.menuItem38.Size = New System.Drawing.Size(207, 22)
      Me.menuItem38.Text = "Save/Load Data"
      '
      'menuItem39
      '
      Me.menuItem39.Name = "menuItem39"
      Me.menuItem39.Size = New System.Drawing.Size(167, 22)
      Me.menuItem39.Text = "Save Data to File"
      '
      'menuItem40
      '
      Me.menuItem40.Name = "menuItem40"
      Me.menuItem40.Size = New System.Drawing.Size(167, 22)
      Me.menuItem40.Text = "Load Data from File"
      '
      'menuItem8
      '
      Me.menuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem13, Me.menuItem9, Me.menuItem10, Me.menuItem11, Me.menuItem12, Me.menuItem19})
      Me.menuItem8.Name = "menuItem8"
      Me.menuItem8.Size = New System.Drawing.Size(207, 22)
      Me.menuItem8.Text = "Print C1Chart"
      '
      'menuItem9
      '
      Me.menuItem9.Name = "menuItem9"
      Me.menuItem9.Size = New System.Drawing.Size(142, 22)
      Me.menuItem9.Text = "ScaleToFit"
      '
      'menuSepItem7
      '
      Me.menuSepItem7.Name = "menuSepItem7"
      Me.menuSepItem7.Size = New System.Drawing.Size(204, 6)
      '
      'menuItem5
      '
      Me.menuItem5.Name = "menuItem5"
      Me.menuItem5.Size = New System.Drawing.Size(207, 22)
      Me.menuItem5.Text = "Exit"
      '
      'menuItem41
      '
      Me.menuItem41.Name = "menuItem41"
      Me.menuItem41.Size = New System.Drawing.Size(68, 20)
      Me.menuItem41.Text = "Properties"
      '
      'propertyGrid1
      '
      Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
      Me.propertyGrid1.Location = New System.Drawing.Point(12, 43)
      Me.propertyGrid1.Name = "propertyGrid1"
      Me.propertyGrid1.Size = New System.Drawing.Size(304, 272)
      Me.propertyGrid1.TabIndex = 0
      '
      'Form1
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(700, 406)
      Me.Controls.Add(Me.C1Chart1)
      Me.Controls.Add(Me.propertyGrid1)
      Me.Controls.Add(Me.mainMenu1)
      Me.MainMenuStrip = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
      Me.Text = "Form1"
      CType(Me.C1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.mainMenu1.ResumeLayout(False)
      Me.mainMenu1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub 'InitializeComponent

#End Region
   '/ <summary>
   '/ The main entry point for the application.
   '/ </summary>
   <STAThread()>  _
   Shared    Sub Main()
      Application.Run(New Form1())
   End Sub 'Main


   Private Sub _sizeControls()
      Me.propertyGrid1.Top = Me.mainMenu1.Bottom + 1
      Me.propertyGrid1.Height = Me.ClientSize.Height - mainMenu1.Height - 1
      Me.C1Chart1.Left = Me.propertyGrid1.Width
      Me.C1Chart1.Top = Me.mainMenu1.Bottom + 1
      Me.C1Chart1.Height = Me.ClientSize.Height - mainMenu1.Height - 1
      Me.C1Chart1.Width = Me.ClientSize.Width - Me.C1Chart1.Left
   End Sub '_sizeControls


   Private ReadOnly Property _unique() As Integer
      Get
         m_unique += 1
         Return m_unique
      End Get
   End Property

   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      Me.propertyGrid1.SelectedObject = Me.C1Chart1
      Me.propertyGrid1.Text = Me.C1Chart1.Name
      Me.propertyGrid1.Top = 0
      Me.propertyGrid1.Left = 0
      Me.C1Chart1.Top = 0
      _sizeControls()
      Me.menuItem17.Checked = C1Chart1.PrintDialogUsage
      Me.runTestProcedures()
      Debug.WriteLine(("Chart AssemblyFileVersion: " + C1Chart1.AssemblyFileVersionString))
      Debug.WriteLine(("Chart AssemblyVersion: " + C1Chart1.AssemblyVersionString))
   End Sub 'Form1_Load


   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles MyBase.Resize
      _sizeControls()
   End Sub 'Form1_Resize


   Private Sub Chart1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles C1Chart1.MouseUp
      If e.Button = MouseButtons.Right Then
         Debug.WriteLine(("Right Click X,Y Position = " + e.X.ToString() + "," + e.Y.ToString()))
         Dim grp As ChartGroup = C1Chart1.ChartGroups.Group0

         Dim xd As Single = 0F
         Dim yd As Single = 0F
         If grp.CoordToDataCoord(e.X, e.Y, xd, yd) Then
            Debug.WriteLine(("   DataCoord = " + xd.ToString() + "," + yd.ToString()))
         End If
      ElseIf e.Button = MouseButtons.Middle Then
         Debug.WriteLine("Middle Click")

         ' the floating labels, since constantly repainting
         ' these labels will undo the drawing below.
         Dim lc As LabelsCollection = C1Chart1.ChartLabels.LabelsCollection
         lc.Remove(lc((cInfoLabel + "0")))
         lc.Remove(lc((cInfoLabel + "1")))
         C1Chart1.Refresh()

         Dim grp As ChartGroup = C1Chart1.ChartGroups.Group0
         Dim si As Integer = 0
         Dim pi As Integer = 0
         Dim ds As Integer = 0
         ' find the nearest point.
         If grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, si, pi, ds) Then
            Dim r As Rectangle = grp.DataIndexToRect(si, pi)
            If Not r.IsEmpty Then
               Dim lpen As Pen = Pens.Black
               Dim lbrush As Brush = Brushes.Black

               If grp.ChartType = Chart2DTypeEnum.Pie Then
                  ' pie charts a special case, where the
                  ' returned rectangle provides information
                  ' describing the pie slice, and not really
                  ' a rectangle.
                  If ds = 0 Then
                     Dim xp As Integer = 0
                     Dim yp As Integer = 0
                     If grp.DataIndexToCoord(si, pi, xp, yp) Then
                        xp -= r.Left
                        yp -= r.Top

                        Dim radius As Integer = CInt(Math.Sqrt((xp * xp + yp * yp)))
                        Dim startAngle As Integer = r.Width
                        Dim sweepAngle As Integer = r.Height - r.Width

                        r.Width = 2 * radius
                        r.Height = 2 * radius
                        r.X -= radius
                        r.Y -= radius

                        Dim g As Graphics = C1Chart1.CreateGraphics()
                        g.DrawPie(lpen, r, startAngle, sweepAngle)
                        g.FillPie(lbrush, r, startAngle, sweepAngle)
                        g.Dispose()
                     End If
                  End If
               ElseIf r.Contains(e.X, e.Y) Then
                  ' if the nearest point rect contains the click point
                  ' draw and fill the rectangle the rectangle.
                  Dim g As Graphics = C1Chart1.CreateGraphics()
                  g.DrawRectangle(lpen, r)
                  g.FillRectangle(lbrush, r)
                  g.Dispose()
               End If
            End If
         End If
      End If
   End Sub 'Chart1_MouseUp


   Private Sub Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles C1Chart1.MouseMove
      Dim [region] As ChartRegionEnum = C1Chart1.ChartRegionFromCoord(e.X, e.Y)
      Debug.WriteLine((_unique.ToString() + ") RegionCode: " + [region].ToString()))
      If [region] = ChartRegionEnum.Legend Then
         Dim gi As Integer = 0
         Dim si As Integer = 0
         If C1Chart1.Legend.SeriesFromCoord(e.X, e.Y, gi, si) Then
            Dim seriesName As String = C1Chart1.ChartGroups(gi).ChartData(si).Label
            Debug.WriteLine(("  gi=" + gi.ToString() + ", si=" + si.ToString() + ", SeriesName=" + seriesName))
         End If
      ElseIf [region] = ChartRegionEnum.ChartLabel Then
         Dim li As Integer = 0
         If C1Chart1.ChartLabels.LabelFromCoord(e.X, e.Y, li) Then
            Dim lab As C1.Win.C1Chart.Label = C1Chart1.ChartLabels(li)
            Debug.WriteLine((" LabelIndex=" + li.ToString() + ", LabelName=" + lab.Name))
         End If
      End If

      If C1Chart1.Capture Then
         If e.Button = MouseButtons.Left Then
            If Me.Cursor.Equals(Cursors.VSplit) Then
               Dim newleft As Integer = C1Chart1.Left + e.X
               propertyGrid1.Width = newleft - 1
               _sizeControls()
            End If
         Else
            If e.X < - 10 OrElse e.X > 10 Then
               ' restore mouse cursor
               If Cursor.Equals(Cursors.VSplit) Then
                  Me.Cursor = Cursors.Default
               End If
            End If
         End If
      Else
         If e.X >= - 10 AndAlso e.X <= 10 Then
            ' set mouse cursor
            If Not Cursor.Equals(Cursors.VSplit) Then
               Me.Cursor = Cursors.VSplit
            End If
         Else
            ' restore mouse cursor
            If Cursor.Equals(Cursors.VSplit) Then
               Me.Cursor = Cursors.Default
            End If
         End If 
         Dim i As Integer
         For i = 0 To C1Chart1.ChartGroups.Count - 1
            Dim grp As ChartGroup = C1Chart1.ChartGroups(i)
            If grp.ChartData.SeriesList.Count > 0 Then
               Dim xd As Single = 0F
               Dim yd As Single = 0F
               If grp.CoordToDataCoord(e.X, e.Y, xd, yd) Then
                  Dim l As C1.Win.C1Chart.Label = C1Chart1.ChartLabels((cInfoLabel + i.ToString()))
                  If Not (l Is Nothing) Then
                     Dim borderWidth As Integer = C1Chart1.Style.Border.Thickness
                     If i = 0 Then
                        l.AttachMethodData.X = borderWidth
                     Else
                        l.AttachMethodData.X = C1Chart1.Width - borderWidth
                     End If 
                     l.AttachMethodData.Y = borderWidth
                     l.Text = "<<< " + l.Name + " >>>" + ControlChars.Lf
                     l.Text += "Coord=(" + e.X.ToString() + "," + e.Y.ToString() + ")" + ControlChars.Lf + "  DataCoord=" + xd.ToString() + "," + yd.ToString() + ")" + ControlChars.Lf

                     Dim xc As Integer = 0
                     Dim yc As Integer = 0
                     grp.DataCoordToCoord(xd, yd, xc, yc)
                     l.Text += "    Coord=(" + xc.ToString() + "," + yc.ToString() + ")" + ControlChars.Lf

                     Dim s As Integer = 0
                     Dim p As Integer = 0
                     Dim dist As Integer = - 1
                     grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, s, p, dist)
                     'grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XCoord, ref s, ref p, ref dist);
                     'grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.YCoord, ref s, ref p, ref dist);
                     l.Text += "  Series=" + s.ToString() + "("
                     If s >= 0 Then
                        l.Text += grp.ChartData.SeriesList(s).Label
                     Else
                        l.Text += "n/a"
                     End If
                     l.Text += ")  Point=" + p.ToString() + "   Distance=" + dist.ToString() + ControlChars.Lf

                     If s >= 0 AndAlso p >= 0 Then
                        grp.DataIndexToCoord(s, p, xc, yc)
                        l.Text += "    Coord=(" + xc.ToString() + "," + yc.ToString() + ")"

                        Dim pf As PointF = CType(grp.ChartData.SeriesList(s).PointData(p), PointF)
                        l.Text += "    DataValue(s,p)=" + pf.ToString() + ControlChars.Lf

                        If grp.ChartType = Chart2DTypeEnum.HiLo OrElse grp.ChartType = Chart2DTypeEnum.HiLoOpenClose OrElse grp.ChartType = Chart2DTypeEnum.Candle Then
                           Dim ser As ChartDataSeries = grp.ChartData.SeriesList(s)
                           Dim hi As Single = CSng(ser.Y(p))
                           Dim lo As Single = CSng(ser.Y1(p))
                           Dim adder As String = "    Hi=" + hi.ToString() + ", Lo=" + lo.ToString()
                           If grp.ChartType = Chart2DTypeEnum.HiLoOpenClose OrElse grp.ChartType = Chart2DTypeEnum.Candle Then
                              hi = CSng(ser.Y2(p)) ' open
                              lo = CSng(ser.Y3(p)) ' close
                              adder += ", Open=" + hi.ToString() + ", Close=" + lo.ToString()
                           End If
                           If ser.X.DataType.Equals(GetType(DateTime)) Then
                              adder += ", Date=" + CType(ser.X(p), DateTime).ToShortDateString()
                           End If
                           l.Text += adder + ControlChars.Lf
                        End If
                     End If
                     If Not l.Visible Then
                        l.Visible = True
                     End If
                  End If
               End If
            End If
         Next i
      End If
   End Sub 'Chart1_MouseMove

   Private Function makeSineCurveData(phasor As Single) As PointF()
      Const nPts As Integer = 42
      Dim pi As Double = System.Math.PI

      Dim pts As PointF() = CType(Array.CreateInstance(GetType(PointF), nPts), PointF())

      Dim xi As Double = 4.0 * pi /(nPts - 1)
      Dim i As Integer
      For i = 0 To nPts - 1
         Dim x As Double = CDbl(i) * xi
         pts(i).X = CSng(x)
         pts(i).Y = CSng(Math.Sin((x + phasor)))
      Next i

      Return pts
   End Function 'makeSineCurveData


   Private Sub addInfoLabels()
      ' add a floating informational label that
      ' will response to chart positioning
      Dim l As C1.Win.C1Chart.Label = C1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
      l.Visible = False
      l.Name = cInfoLabel + "0"
      l.Style.Font = New Font("Arial", 8)
      l.Style.HorizontalAlignment = AlignHorzEnum.Near
      l.Style.BackColor = Color.FromKnownColor(KnownColor.Info)
      l.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      l.Style.Border.Color = Color.Red
      l.Style.Border.Thickness = 1
      l.AttachMethod = AttachMethodEnum.Coordinate
      l.Compass = LabelCompassEnum.SouthEast

      l = C1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
      l.Visible = False
      l.Name = cInfoLabel + "1"
      l.Style.Font = New Font("Arial", 8)
      l.Style.BackColor = Color.FromKnownColor(KnownColor.Info)
      l.Style.HorizontalAlignment = AlignHorzEnum.Far
      l.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      l.Style.Border.Color = Color.Red
      l.Style.Border.Thickness = 1
      l.AttachMethod = AttachMethodEnum.Coordinate
      l.Compass = LabelCompassEnum.SouthWest
   End Sub 'addInfoLabels


   Public Sub doRefresh()
      propertyGrid1.Refresh()
   End Sub 'doRefresh


   Public Sub runTestProceduresForXYPlot()
      C1Chart1.Reset()

      ' this is a dummy function that is used to modify
      ' object properties during startup.  It is to be removed
      ' later, if this application is ever used as a designer.
      C1Chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      C1Chart1.Style.Border.Thickness = 5

      Dim lab As C1.Win.C1Chart.Title = Me.C1Chart1.Header
      lab.Text = "This is the header"
      lab.Style.Font = New Font("Arial", 18, FontStyle.Bold)
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      lab.Style.Border.Thickness = 5
      lab.Visible = True

      lab = Me.C1Chart1.Footer
      lab.Text = "This is the footer"
      lab.Style.Font = New Font("Arial", 18, FontStyle.Bold)
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      lab.Style.Border.Thickness = 5
      lab.Visible = True

      Dim leg As C1.Win.C1Chart.Legend = Me.C1Chart1.Legend
      leg.Text = "Legend"
      leg.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      leg.Style.Border.Thickness = 8
      leg.Visible = True

      Dim area As Area = Me.C1Chart1.ChartArea
      area.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      area.Style.Border.Thickness = 8
      area.Visible = True

      area.AxisX.Text = "The X-Axis"
      area.AxisY.Text = "The Y-Axis"
      area.AxisY2.Text = "The Y2-Axis"

      Dim ps() As PointF
      Dim pif As Single = CSng(System.Math.PI)

      Dim group As ChartGroup = C1Chart1.ChartGroups(0)
      Dim group1 As ChartGroup = C1Chart1.ChartGroups(1)
      group.ChartType = Chart2DTypeEnum.XYPlot
      Dim data As ChartData = group.ChartData

      Dim s As New ChartDataSeries()
      data.SeriesList.Add(s)
      ps = Me.makeSineCurveData(0F)
      ps(1).Y = hole_value
      s.PointData.CopyDataIn(ps)
      s.LineStyle.Thickness = 1
      s.FitType = FitTypeEnum.Line

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      ps = Me.makeSineCurveData((pif / 2))
      ps(10).X = hole_value
      ps(11).Y = hole_value
      s.PointData.CopyDataIn(ps)
      s.LineStyle.Thickness = 2
      s.FitType = FitTypeEnum.Spline

      s = New ChartDataSeries()
      ps = Me.makeSineCurveData(pif)
      ps(22).Y = hole_value
      s.PointData.CopyDataIn(ps)
      s.LineStyle.Thickness = 3
      s.FitType = FitTypeEnum.Beziers
      data.SeriesList.Add(s)

      s = New ChartDataSeries()
      ps = New PointF() {PointF.Empty, New PointF(CSng(data.MaxX), 0F)}
      s.PointData.CopyDataIn(ps)
      s.LineStyle.Thickness = 2
      data.SeriesList.Insert(0, s)

      s = data.SeriesList.AddNewSeries()
      ps = Me.makeSineCurveData((pif / 4))
      s.PointData.CopyDataIn(ps)
      s.LineStyle.Thickness = 7

      s = data.SeriesList.AddNewSeries()
      ps = Me.makeSineCurveData(2.445F)
      s.PointData.CopyDataIn(ps)
      s.LineStyle.Thickness = 7
      s.FitType = FitTypeEnum.Spline

      Dim cLabs As ChartLabels = C1Chart1.ChartLabels
      cLabs.DefaultLabelStyle.BackColor = Color.Turquoise
      cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      cLabs.DefaultLabelStyle.Border.Thickness = 2

      Dim cLab As C1.Win.C1Chart.Label = cLabs.LabelsCollection.AddNewLabel()
      cLab.Text = "This is a C1Chart Label" + ControlChars.Lf + "Second line of label"
      cLab.AttachMethod = AttachMethodEnum.DataIndex
      cLab.AttachMethodData.GroupIndex = 0
      cLab.AttachMethodData.SeriesIndex = 2
      cLab.AttachMethodData.PointIndex = 3
      cLab.Connected = True
      cLab.Offset = 15
      cLab.Visible = True

      addInfoLabels()
      doRefresh()
   End Sub 'runTestProceduresForXYPlot


   Public Sub runTestProceduresForStackedXYChart()
      C1Chart1.Reset()

      ' this is a dummy function that is used to modify
      ' object properties during startup.  It is to be removed
      ' later, if this application is ever used as a designer.
      C1Chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      C1Chart1.Style.Border.Thickness = 5

      Dim lab As C1.Win.C1Chart.Title = Me.C1Chart1.Header
      lab.Text = "Stacked XY Header"
      lab.Style.Font = New Font("Arial", 18, FontStyle.Bold)
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      lab.Style.Border.Thickness = 5
      lab.Visible = True

      lab = Me.C1Chart1.Footer
      lab.Text = "Stacked XY Footer"
      lab.Style.Font = New Font("Arial", 18, FontStyle.Bold)
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      lab.Style.Border.Thickness = 5
      lab.Visible = True

      Dim leg As C1.Win.C1Chart.Legend = Me.C1Chart1.Legend
      leg.Text = "Legend"
      leg.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      leg.Style.Border.Thickness = 8
      leg.Visible = True

      Dim area As Area = Me.C1Chart1.ChartArea
      area.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      area.Style.Border.Thickness = 8
      area.Visible = True

      area.AxisX.Text = "The X-Axis"
      area.AxisX.GridMajor.Visible = True
      area.AxisX.GridMajor.Color = Color.Black
      area.AxisX.GridMinor.Visible = True
      area.AxisX.GridMinor.Color = Color.DarkBlue

      area.AxisY.Text = "The Y-Axis"
      area.AxisY.GridMajor.Visible = True
      area.AxisY.GridMajor.Color = Color.Black
      area.AxisY.GridMinor.Visible = True
      area.AxisY.GridMinor.Color = Color.DarkBlue

      Dim group As ChartGroup = C1Chart1.ChartGroups(0)
      group.ChartType = Chart2DTypeEnum.XYPlot
      group.Stacked = True

      Dim data As ChartData = group.ChartData

      Dim s As New ChartDataSeries()
      data.SeriesList.Add(s)
      s.FitType = FitTypeEnum.Line
      Dim pfa() As PointF = {New PointF(0.5F, 0.5F), New PointF(1F, 1.5F), New PointF(1.5F, 3F), New PointF(1.6F, 3.5F), New PointF(1.8F, 1.5F)}
      s.PointData.CopyDataIn(pfa)

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.FitType = FitTypeEnum.Spline
      pfa = New PointF() {PointF.Empty, New PointF(0.5F, 1.2F), New PointF(1F, 1.2F), New PointF(1.5F, 1.3F), New PointF(2F, 4F)}
      s.PointData.CopyDataIn(pfa)

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.FitType = FitTypeEnum.Line
      pfa = New PointF() {New PointF(0F, 1.2F), New PointF(0.81F, 2F), New PointF(1.5F, 3F), New PointF(2F, 1F)}
      s.PointData.CopyDataIn(pfa)

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.FitType = FitTypeEnum.Spline
      pfa = New PointF() {New PointF(0F, 1.2F), New PointF(1F, 1F), New PointF(1.5F, 0.3F), New PointF(2F, 0.5F)}
      s.PointData.CopyDataIn(pfa)

      Dim cLabs As ChartLabels = C1Chart1.ChartLabels
      cLabs.DefaultLabelStyle.BackColor = Color.Turquoise
      cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      cLabs.DefaultLabelStyle.Border.Thickness = 2

      Dim cLab As C1.Win.C1Chart.Label = cLabs.LabelsCollection.AddNewLabel()
      cLab.Text = "G=0,S=2,P=3"
      cLab.AttachMethod = AttachMethodEnum.DataIndex
      cLab.AttachMethodData.GroupIndex = 0
      cLab.AttachMethodData.SeriesIndex = 2
      cLab.AttachMethodData.PointIndex = 3
      cLab.Connected = True
      cLab.Offset = 15
      cLab.Visible = True

      addInfoLabels()
      doRefresh()
   End Sub 'runTestProceduresForStackedXYChart


   Public Sub runTestProceduresForStackedAreaChart()
      runTestProceduresForStackedXYChart()
      Dim grp As ChartGroup = C1Chart1.ChartGroups(0)
      grp.ChartType = Chart2DTypeEnum.Area
      grp.Stacked = True

      C1Chart1.Header.Text = "Stacked Area Header"
      C1Chart1.Footer.Text = "Stacked Area Footer"
      doRefresh()
   End Sub 'runTestProceduresForStackedAreaChart


   Public Sub runTestProceduresForPieChart()
      C1Chart1.Reset()
      C1Chart1.Style.Font = New Font("Arial", 18, FontStyle.Bold)

      Dim lab As C1.Win.C1Chart.Title = Me.C1Chart1.Header
      lab.Text = "Pie C1Chart"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      lab = C1Chart1.Footer
      lab.Text = "Pie Footer"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      Dim leg As C1.Win.C1Chart.Legend = Me.C1Chart1.Legend
      leg.Text = "Legend"
      leg.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      leg.Style.Border.Thickness = 2
      leg.Visible = True

      Dim area As Area = Me.C1Chart1.ChartArea
      area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None
      area.Style.BackColor = Color.Azure
      area.Visible = True

      Dim group As ChartGroup = C1Chart1.ChartGroups(0)
      group.ChartType = Chart2DTypeEnum.Pie

      Dim data As ChartData = group.ChartData

      Dim s As New ChartDataSeries()
      data.SeriesList.Add(s)
      Dim ps() As PointF
      ps = New PointF() {New PointF(1F, 20F), New PointF(2F, 24F), New PointF(3F, 42F), New PointF(4F, 13F), New PointF(5F, 10F)}
      s.PointData.CopyDataIn(ps)
      s.Offset = 30

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      ps = New PointF() {New PointF(1F, 20F), New PointF(2F, 24F), New PointF(3F, 42F), New PointF(4F, 13F), New PointF(5F, 10F)}
      s.PointData.CopyDataIn(ps)

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      ps = New PointF() {New PointF(1F, 10F), New PointF(2F, 4F), New PointF(3F, 17F), New PointF(4F, 81F), New PointF(5F, 10F)}
      s.PointData.CopyDataIn(ps)
      s.Offset = 40

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      ps = New PointF() {New PointF(1F, 20F), New PointF(2F, 4F), New PointF(3F, 52F), New PointF(4F, 13F), New PointF(5F, 10F)}
      s.PointData.CopyDataIn(ps)

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      ps = New PointF() {New PointF(1F, 6F), New PointF(2F, 24F), New PointF(3F, 142F), New PointF(4F, 113), New PointF(5F, 10F)}
      s.PointData.CopyDataIn(ps)

      Dim cLabs As ChartLabels = C1Chart1.ChartLabels
      cLabs.DefaultLabelStyle.BackColor = Color.Turquoise
      cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      cLabs.DefaultLabelStyle.Border.Thickness = 3

      Dim cLab As C1.Win.C1Chart.Label = cLabs.LabelsCollection.AddNewLabel()
      cLab.Text = "(0,0)"
      cLab.AttachMethod = AttachMethodEnum.DataIndex
      cLab.AttachMethodData.GroupIndex = 0
      cLab.AttachMethodData.SeriesIndex = 0
      cLab.AttachMethodData.PointIndex = 0
      cLab.Connected = True
      cLab.Offset = 10
      cLab.Visible = True

      addInfoLabels()
      doRefresh()
   End Sub 'runTestProceduresForPieChart


   Public Sub runTestProceduresForBarChart()
      C1Chart1.Reset()
      C1Chart1.Style.Font = New Font("Lucida Console", 18, FontStyle.Bold)

      Dim lab As C1.Win.C1Chart.Title = Me.C1Chart1.Header
      lab.Text = "Bar Chart"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      lab = C1Chart1.Footer
      lab.Text = "Bar Footer"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      Dim leg As C1.Win.C1Chart.Legend = Me.C1Chart1.Legend
      leg.Text = "Legend"
      leg.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      leg.Style.Border.Thickness = 2
      leg.Visible = True

      Dim area As Area = Me.C1Chart1.ChartArea
      area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None
      area.Style.BackColor = Color.Bisque
      area.Visible = True

      Dim group As ChartGroup = C1Chart1.ChartGroups(0)
      Dim group2 As ChartGroup = C1Chart1.ChartGroups(1)
      group.ChartType = Chart2DTypeEnum.Bar

      Dim data As ChartData = group.ChartData
      Dim data2 As ChartData = group2.ChartData

      Dim ps() As PointF
      ps = New PointF() {New PointF(5F, 20F), New PointF(4F, 24F), New PointF(3F, 42F), New PointF(1F, 13F), New PointF(2F, 10F)}
      Dim s As New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      s = New ChartDataSeries()
      data2.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(1F, 20F), New PointF(2F, 24F), New PointF(3F, 42F), New PointF(4F, 13F), New PointF(5F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      s = New ChartDataSeries()
      data2.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(1F, 10F), New PointF(2F, 4F), New PointF(3F, 17F), New PointF(4F, 81F), New PointF(5F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      s = New ChartDataSeries()
      data2.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(1F, 20F), New PointF(2F, 4F), New PointF(3F, 52F), New PointF(4F, 13F), New PointF(5F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      s = New ChartDataSeries()
      data2.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(1F, 6F), New PointF(2F, 24F), New PointF(3F, 142F), New PointF(4F, 113), New PointF(5F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      s = New ChartDataSeries()
      data2.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      Dim cLabs As ChartLabels = C1Chart1.ChartLabels
      cLabs.DefaultLabelStyle.BackColor = Color.Turquoise
      cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      cLabs.DefaultLabelStyle.Border.Thickness = 3

      Dim cLab As C1.Win.C1Chart.Label = cLabs.LabelsCollection.AddNewLabel()
      cLab.Text = "Bar Label"
      cLab.AttachMethod = AttachMethodEnum.DataIndex
      cLab.AttachMethodData.GroupIndex = 0
      cLab.AttachMethodData.SeriesIndex = 0
      cLab.AttachMethodData.PointIndex = 0
      cLab.Compass = LabelCompassEnum.North
      cLab.Connected = True
      cLab.Offset = 10
      cLab.Visible = True

      addInfoLabels()
      doRefresh()
   End Sub 'runTestProceduresForBarChart


   Public Sub runTestProceduresForStackedBarChart()
      C1Chart1.Reset()
      C1Chart1.Style.Font = New Font("Lucida Console", 18, FontStyle.Bold)

      Dim lab As C1.Win.C1Chart.Title = Me.C1Chart1.Header
      lab.Text = "Stacked Bar Chart" + ControlChars.Lf + "With A Centered AlarmZone"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      lab = C1Chart1.Footer
      lab.Text = "Stacked Bar Footer"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      Dim leg As C1.Win.C1Chart.Legend = Me.C1Chart1.Legend
      leg.Text = "SB Legend"
      leg.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      leg.Style.Border.Thickness = 2
      leg.Visible = True

      Dim area As Area = Me.C1Chart1.ChartArea
      area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None
      area.Style.BackColor = Color.Bisque
      area.Visible = True

      area.AxisY.Min = 0
      area.AxisY.GridMajor.Color = Color.Black
      area.AxisY.GridMajor.Visible = True
      area.AxisY.GridMinor.Visible = True

      Dim az As AlarmZone = area.PlotArea.AlarmZones.AddNewZone()
      az.Name = "AlarmZoneForBar"
      az.BackColor = Color.CadetBlue
      az.NearExtent = 1.5F
      az.FarExtent = 4.5F
      az.LowerExtent = 100F
      az.UpperExtent = 200F
      az.Visible = True

      Dim group As ChartGroup = C1Chart1.ChartGroups(0)
      group.ChartType = Chart2DTypeEnum.Bar
      group.Stacked = True

      Dim data As ChartData = group.ChartData
      Dim ps() As PointF
      ps = New PointF() {New PointF(1F, 13F), New PointF(2F, 10F), New PointF(3F, 42F), New PointF(4F, 24F), New PointF(5F, 20F)}
      Dim s As New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(1F, 20F), New PointF(2F, 24F), New PointF(3F, 42F), New PointF(4F, 13F), New PointF(5F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(1F, 10F), New PointF(2F, 4F), New PointF(3F, 17F), New PointF(4F, 81F), New PointF(5F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(1F, 20F), New PointF(2F, 4F), New PointF(3F, 52F), New PointF(4F, 13F), New PointF(5F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(1F, 6F), New PointF(2F, 24F), New PointF(3F, 142F), New PointF(4F, 113), New PointF(5F, 10F)}

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      Dim cLabs As ChartLabels = C1Chart1.ChartLabels
      cLabs.DefaultLabelStyle.BackColor = Color.Turquoise
      cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      cLabs.DefaultLabelStyle.Border.Thickness = 3

      Dim cLab As C1.Win.C1Chart.Label = cLabs.LabelsCollection.AddNewLabel()
      cLab.Text = "Stacked Bar Label"
      cLab.AttachMethod = AttachMethodEnum.DataIndex
      cLab.AttachMethodData.GroupIndex = 0
      cLab.AttachMethodData.SeriesIndex = 0
      cLab.AttachMethodData.PointIndex = 0
      cLab.Compass = LabelCompassEnum.North
      cLab.Connected = True
      cLab.Offset = 10
      cLab.Visible = False 'true;
      addInfoLabels()

      Dim sl As Integer = data.SeriesList.Count
      Dim pl As Integer = ps.Length

      Dim xys As Single(,) = CType(Array.CreateInstance(GetType(Single), sl + 1, pl), Single(,))
      xys.Initialize()

      ' set the X values.
      Dim p As Integer
      For p = 0 To pl - 1
         xys(0, p) = ps(p).X
      Next p 
      Dim rand As New Random(11)
      Dim si As Integer
      For si = 0 To sl - 1
         ps = CType(data(si).PointData.CopyDataOut(), PointF())
         Dim p0 As Integer
         For p0 = 0 To pl - 1
            xys(si + 1, p0) = ps(p0).Y
         Next p0
      Next si 
      dumpStackedArray(xys)
      doRefresh()
   End Sub 'runTestProceduresForStackedBarChart


   Public Sub runTestProceduresForHiLoChart()
      C1Chart1.Reset()
      C1Chart1.Style.Font = New Font("Lucida Console", 18, FontStyle.Bold)

      Dim lab As C1.Win.C1Chart.Title = Me.C1Chart1.Header
      lab.Text = "Hi-Lo Chart Header"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      lab = C1Chart1.Footer
      lab.Text = "Hi-Lo Chart Footer"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      Dim leg As C1.Win.C1Chart.Legend = Me.C1Chart1.Legend
      leg.Text = "Legend"
      leg.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      leg.Style.Border.Thickness = 2
      leg.Visible = True

      Dim area As Area = Me.C1Chart1.ChartArea
      area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None
      area.Style.BackColor = Color.AliceBlue
      area.Visible = True

      area.AxisX.GridMajor.Visible = True
      area.AxisX.AnnoFormat = FormatEnum.DateManual
      area.AxisX.AnnoFormatString = "MM/dd"
      area.AxisX.AnnotationRotation = 30
      area.AxisX.Text = "Date of Interest"

      area.AxisY.GridMajor.Visible = True
      area.AxisY.Text = "Price ($)"

      Dim group As ChartGroup = C1Chart1.ChartGroups(0)
      group.ChartType = Chart2DTypeEnum.HiLo
      Dim data As ChartData = group.ChartData

      Dim Xds() As DateTime = {New DateTime(2002, 1, 1), New DateTime(2002, 1, 2), New DateTime(2002, 1, 3), New DateTime(2002, 1, 4), New DateTime(2002, 1, 5)}
      Dim Hi() As Single = {10F, 12F, 17F, 19F, 14F}
      Dim Lo() As Single = {7F, 6F, 12F, 10F, 13F}

      Dim s As New ChartDataSeries()
      data.SeriesList.Add(s)
      s.X.CopyDataIn(Xds)
      s.Y.CopyDataIn(Hi)
      s.Y1.CopyDataIn(Lo)
      s.LineStyle.Color = Color.Red
      s.LineStyle.Thickness = 5
      s.SymbolStyle.Size = 5

      Hi = New Single() {20F, 22F, 27F, 29F, 24F}
      Lo = New Single() {17F, 16F, 22F, 20F, 23F}

      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.X.CopyDataIn(Xds)
      s.Y.CopyDataIn(Hi)
      s.Y1.CopyDataIn(Lo)

      s.LineStyle.Color = Color.Green
      s.LineStyle.Thickness = 5
      s.SymbolStyle.Size = 8

      Dim cLabs As ChartLabels = C1Chart1.ChartLabels
      cLabs.DefaultLabelStyle.BackColor = Color.Turquoise
      cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      cLabs.DefaultLabelStyle.Border.Thickness = 3

      Dim cLab As C1.Win.C1Chart.Label = cLabs.LabelsCollection.AddNewLabel()
      cLab.Text = "Hi-Lo Label"
      cLab.AttachMethod = AttachMethodEnum.DataIndex
      cLab.AttachMethodData.GroupIndex = 0
      cLab.AttachMethodData.SeriesIndex = 0
      cLab.AttachMethodData.PointIndex = 0
      cLab.Compass = LabelCompassEnum.North
      cLab.Connected = True
      cLab.Offset = 10
      cLab.Visible = True

      addInfoLabels()
      doRefresh()
   End Sub 'runTestProceduresForHiLoChart


   Public Sub runTestProceduresForHiLoOpenCloseChart()
      runTestProceduresForHiLoChart()

      Dim cg As ChartGroup = C1Chart1.ChartGroups(0)
      cg.ChartType = Chart2DTypeEnum.HiLoOpenClose

      Dim ns As Integer = cg.ChartData.SeriesList.Count
      Dim s As Integer
      For s = 0 To ns - 1
         Dim ser As ChartDataSeries = cg.ChartData.SeriesList(s)
         Dim np As Integer = ser.Length

         Dim his As Single() = CType(ser.Y.CopyDataOut(), Single())
         Dim los As Single() = CType(ser.Y1.CopyDataOut(), Single())
         Dim opens As Single() = CType(Array.CreateInstance(GetType(Single), np), Single())
         Dim closes As Single() = CType(Array.CreateInstance(GetType(Single), np), Single())

         Dim rnd As New Random(666)

         Dim p As Integer
         For p = 0 To np - 1
            ' add in open and close points
            Dim hi As Single = his(p)
            Dim lo As Single = los(p)
            opens(p) = CSng(lo +(hi - lo) * rnd.NextDouble())
            closes(p) = CSng(lo +(hi - lo) * rnd.NextDouble())
         Next p
         ser.Y2.CopyDataIn(opens)
         ser.Y3.CopyDataIn(closes)
      Next s
      doRefresh()
   End Sub 'runTestProceduresForHiLoOpenCloseChart


   Public Sub runTestProceduresForBubbleChart()
      Me.runTestProceduresForHiLoChart()
      C1Chart1.ChartGroups(0).ChartType = Chart2DTypeEnum.Bubble
      Dim lab As C1.Win.C1Chart.Label = C1Chart1.ChartLabels(0)
      lab.Text = "Bubble Label"
      lab.AttachMethodData.PointIndex = 3
      lab.Compass = LabelCompassEnum.North
      lab.Offset = 30

      C1Chart1.Header.Text = "Bubble Header"
      C1Chart1.Footer.Text = "Bubble Footer"
      doRefresh()
   End Sub 'runTestProceduresForBubbleChart


   Public Sub runTestProceduresForAreaChart()
      Me.runTestProceduresForXYPlot()
      C1Chart1.ChartGroups(0).ChartType = Chart2DTypeEnum.Area
      doRefresh()
   End Sub 'runTestProceduresForAreaChart


   Public Sub runTestProceduresForCandleChart()
      runTestProceduresForHiLoOpenCloseChart()

      Dim cg As ChartGroup = C1Chart1.ChartGroups(0)
      cg.ChartType = Chart2DTypeEnum.Candle
      cg.HiLoData.FillTransparent = False
      Dim ser As ChartDataSeries
      For Each ser In  cg.ChartData.SeriesList
         ser.LineStyle.Thickness = 1
         ser.SymbolStyle.Size = 12
         ser.SymbolStyle.Color = Color.Yellow
      Next ser

      Dim lab As C1.Win.C1Chart.Label = C1Chart1.ChartLabels(0)
      lab.Text = "Candle Label"
      lab.AttachMethodData.PointIndex = 3
      lab.Compass = LabelCompassEnum.NorthEast
      lab.Offset = 30

      C1Chart1.Header.Text = "Candle Header"
      C1Chart1.Footer.Text = "Candle Footer"
      doRefresh()
   End Sub 'runTestProceduresForCandleChart


   Public Sub runTestProceduresForPolarChart()
      C1Chart1.Reset()
      C1Chart1.Style.Font = New Font("Lucida Console", 18, FontStyle.Bold)

      Dim lab As C1.Win.C1Chart.Title = Me.C1Chart1.Header
      lab.Text = "Polar Chart" + ControlChars.Lf + "with 2 AlarmZones"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      lab = C1Chart1.Footer
      lab.Text = "Polar Chart Footer"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      Dim leg As C1.Win.C1Chart.Legend = Me.C1Chart1.Legend
      leg.Text = "Polar Legend"
      leg.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      leg.Style.Border.Thickness = 2
      leg.Visible = True

      Dim area As Area = Me.C1Chart1.ChartArea
      area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None
      area.Style.BackColor = Color.Bisque
      area.AxisX.Font = New Font("Lucida Console", 9)
      area.AxisX.Text = "Polar X Axis"
      area.AxisX.TickMajor = TickMarksEnum.Cross
      area.AxisX.GridMajor.Visible = True
      area.AxisY.GridMajor.Visible = True
      area.AxisX.GridMinor.Visible = True
      area.AxisY.GridMinor.Visible = True
      area.AxisY.Font = New Font("Arial", 9)
      area.Visible = True
      area.PlotArea.BackColor = Color.Azure

      Dim az As AlarmZone = area.PlotArea.AlarmZones.AddNewZone()
      az.LowerExtent = 0F
      az.UpperExtent = 24F
      az.NearExtent = 240F
      az.FarExtent = 265F
      az.BackColor = Color.Green
      az.Visible = True

      az = area.PlotArea.AlarmZones.AddNewZone()
      az.LowerExtent = 24F
      az.UpperExtent = 34F
      az.NearExtent = 120F
      az.FarExtent = 150F
      az.BackColor = Color.CadetBlue
      az.Visible = True

      Dim group As ChartGroup = C1Chart1.ChartGroups(0)
      group.ChartType = Chart2DTypeEnum.Polar
      group.Polar.Degrees = True

      Dim data As ChartData = group.ChartData
      Dim ps() As PointF

      ps = New PointF() {New PointF(30F, 20F), New PointF(60F, 24F), New PointF(90F, 42F), New PointF(120F, 13F), New PointF(150F, 10F)}
      Dim s As New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(10F, 20F), New PointF(20F, 24F), New PointF(30F, 42F), New PointF(40F, 13F), New PointF(50F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(60F, 10F), New PointF(120F, 4F), New PointF(180F, 17F), New PointF(240F, 18F), New PointF(300F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      ps = New PointF() {New PointF(45F, 20F), New PointF(90F, 4F), New PointF(135F, 25F), New PointF(180F, 13F), New PointF(225F, 10F)}
      s = New ChartDataSeries()
      data.SeriesList.Add(s)
      s.PointData.CopyDataIn(ps)

      Dim cLabs As ChartLabels = C1Chart1.ChartLabels
      cLabs.DefaultLabelStyle.BackColor = Color.Turquoise
      cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      cLabs.DefaultLabelStyle.Border.Thickness = 3

      Dim cLab As C1.Win.C1Chart.Label = cLabs.LabelsCollection.AddNewLabel()
      cLab.Text = "Polar Label"
      cLab.AttachMethod = AttachMethodEnum.DataIndex
      cLab.AttachMethodData.GroupIndex = 0
      cLab.AttachMethodData.SeriesIndex = 0
      cLab.AttachMethodData.PointIndex = 0
      cLab.Compass = LabelCompassEnum.North
      cLab.Connected = True
      cLab.Offset = 10
      cLab.Visible = True

      addInfoLabels()
      doRefresh()
   End Sub 'runTestProceduresForPolarChart


   Public Sub runTestProceduresForRadarChart()
      Me.runTestProceduresForPolarChart()

      C1Chart1.ChartGroups(0).ChartType = Chart2DTypeEnum.Radar
      Dim lab As C1.Win.C1Chart.Label = C1Chart1.ChartLabels(0)
      lab.Text = "Radar Label"
      lab.AttachMethodData.PointIndex = 3
      lab.Compass = LabelCompassEnum.North
      lab.Offset = 30

      C1Chart1.Header.Text = "Radar Header"
      C1Chart1.Footer.Text = "Radar Footer"
      C1Chart1.Legend.Text = "Radar Legend"
      C1Chart1.ChartArea.AxisX.Text = "Radar X Axis"
      doRefresh()
   End Sub 'runTestProceduresForRadarChart


   Public Sub runTestProceduresForStackedPolarChart()
      runTestProceduresForPolarChart()
      C1Chart1.ChartGroups(0).Stacked = True
      C1Chart1.ChartLabels(0).Text = "Stacked Polar Label"

      C1Chart1.Header.Text = "Stacked Polar Header"
      C1Chart1.Footer.Text = "Stacked Polar Footer"
      C1Chart1.Legend.Text = "Stacked Polar Legend"
      doRefresh()
   End Sub 'runTestProceduresForStackedPolarChart


   Public Sub runTestProceduresForStackedRadarChart()
      runTestProceduresForRadarChart()
      C1Chart1.ChartGroups(0).Stacked = True
      C1Chart1.ChartLabels(0).Text = "Stacked Radar Label"
      C1Chart1.ChartLabels(0).Visible = False

      C1Chart1.Header.Text = "Stacked Radar Header"
      C1Chart1.Footer.Text = "Stacked Radar Footer"
      C1Chart1.Legend.Text = "Stacked Radar Legend"
      doRefresh()
   End Sub 'runTestProceduresForStackedRadarChart


   Public Sub dumpStackedArray(xys(,) As Single)
      Dim sl As Integer = xys.GetLength(0)
      Dim pl As Integer = xys.GetLength(1)
      Dim s As Integer

      Dim ss1 As String = "     X "
      Dim ss2 As String = ""
      For s = 0 To (sl - 1) - 1
         Dim ss As String = "Y" + s.ToString()
         While ss.Length < 6
            ss = " " + ss
         End While
         ss1 += ss + "  "

         ss = "SY" + s.ToString()
         While ss.Length < 6
            ss = " " + ss
         End While
         ss2 += ss + "  "
      Next s
      Debug.WriteLine((ss1 + ss2))

      ss2 = ""
      For s = 0 To (2 * sl - 1) - 1
         ss2 += "------  "
      Next s
      Debug.WriteLine(ss2)

      Dim p As Integer
      For p = 0 To pl - 1
         For s = 0 To sl - 1
            ss1 = xys(s, p).ToString("f2")
            While ss1.Length < 6
               ss1 = " " + ss1
            End While
            Debug.Write((ss1 + "  "))
         Next s

         Dim sum As Single = 0F
         For s = 1 To sl - 1
            sum += xys(s, p)
            ss1 = sum.ToString("f2")
            While ss1.Length < 6
               ss1 = " " + ss1
            End While
            Debug.Write((ss1 + "  "))
         Next s
         Debug.WriteLine("")
      Next p
   End Sub 'dumpStackedArray


   Public Sub runTestProceduresForSimpleStackedRadarChart()
      C1Chart1.Reset()
      C1Chart1.Style.Font = New Font("Lucida Console", 18, FontStyle.Bold)

      Dim lab As C1.Win.C1Chart.Title = Me.C1Chart1.Header
      lab.Text = "Simple Stacked Radar Chart Header"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      lab = C1Chart1.Footer
      lab.Text = "Simple Stacked Radar Chart Footer"
      lab.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      lab.Style.Border.Thickness = 2
      lab.Visible = True

      Dim leg As C1.Win.C1Chart.Legend = Me.C1Chart1.Legend
      leg.Text = "Radar Legend"
      leg.Style.Font = New Font("Arial", 10, FontStyle.Italic Or FontStyle.Bold) 
      leg.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      leg.Style.Border.Thickness = 2
      leg.Visible = True

      Dim area As Area = Me.C1Chart1.ChartArea
      area.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None
      area.Style.BackColor = Color.Bisque
      area.AxisX.TickMajor = TickMarksEnum.Cross
      area.AxisX.GridMajor.Visible = True
      area.AxisY.GridMajor.Visible = True
      area.AxisX.GridMinor.Visible = True
      area.AxisY.GridMinor.Visible = True
      area.AxisY.Font = New Font("Arial", 9)
      area.AxisY.Min = 0F
      area.Visible = True

      area.PlotArea.BackColor = Color.Azure

      Dim group As ChartGroup = C1Chart1.ChartGroups(0)
      group.ChartType = Chart2DTypeEnum.Radar
      group.Stacked = True
      group.Radar.Filled = True

      Dim data As ChartData = group.ChartData
      Dim ps() As PointF

      Dim sl As Integer = 4
      Dim pl As Integer = 5
      Dim p As Integer

      ps = CType(Array.CreateInstance(GetType(PointF), pl), PointF())

      Dim xys As Single(,) = CType(Array.CreateInstance(GetType(Single), sl + 1, pl), Single(,))
      xys.Initialize()

      ' set the X values.
      For p = 0 To pl - 1
         xys(0, p) = p
         ps(p).X = p
      Next p

      Dim rand As New Random(11)
      Dim s As Integer
      For s = 0 To sl - 1
         For p = 0 To pl - 1
            ps(p).Y = CSng(50 * rand.NextDouble() + 10)
            xys(s + 1, p) = ps(p).Y
         Next p

         Dim ser As New ChartDataSeries()
         data.SeriesList.Add(ser)
         ser.PointData.CopyDataIn(ps)
      Next s

      dumpStackedArray(xys)

      Dim cLabs As ChartLabels = C1Chart1.ChartLabels
      cLabs.DefaultLabelStyle.BackColor = Color.Turquoise
      cLabs.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      cLabs.DefaultLabelStyle.Border.Thickness = 3

      Dim cLab As C1.Win.C1Chart.Label = cLabs.LabelsCollection.AddNewLabel()
      cLab.Text = "Simple Stacked Radar Label"
      cLab.AttachMethod = AttachMethodEnum.DataIndex
      cLab.AttachMethodData.GroupIndex = 0
      cLab.AttachMethodData.SeriesIndex = 0
      cLab.AttachMethodData.PointIndex = 0
      cLab.Compass = LabelCompassEnum.North
      cLab.Connected = True
      cLab.Offset = 10
      cLab.Visible = True 'false;
      addInfoLabels()
      doRefresh()
   End Sub 'runTestProceduresForSimpleStackedRadarChart


   Public Sub runTestProcedures()
   End Sub 'runTestProcedures

   'this.runTestProceduresForXYPlot();
   'this.runTestProceduresForPieChart();
   'this.runTestProceduresForBarChart();
   'this.runTestProceduresForAreaChart();
   'this.runTestProceduresForHiLoChart();
   'this.runTestProceduresForBubbleChart();
   'this.runTestProceduresForCandleChart();
   'this.runTestProceduresForPolarChart();
   'this.runTestProceduresForRadarChart();
   'this.runTestProceduresForStackedXYChart();
   'this.runTestProceduresForStackedAreaChart();
   'this.runTestProceduresForStackedPolarChart();
   'this.runTestProceduresForStackedRadarChart();
   'this.runTestProceduresForSimpleStackedRadarChart();
   'this.runTestProceduresForStackedBarChart();

   Private Sub Chart1_BackColorChanged(sender As Object, e As System.EventArgs) Handles C1Chart1.BackColorChanged
      Debug.WriteLine("BackColor has changed")
   End Sub 'Chart1_BackColorChanged

   Private Sub Chart1_ForeColorChanged(sender As Object, e As System.EventArgs) Handles C1Chart1.ForeColorChanged
      Debug.WriteLine("ForeColor has changed")
   End Sub 'Chart1_ForeColorChanged

   Private Sub Chart1_FontChanged(sender As Object, e As System.EventArgs) Handles C1Chart1.FontChanged
      Debug.WriteLine("Font has changed")
   End Sub 'Chart1_FontChanged


   Private Sub menuItem2_Click(sender As Object, e As System.EventArgs) Handles menuItem2.Click
      Me.runTestProceduresForXYPlot()
   End Sub 'menuItem2_Click


   Private Sub menuItem3_Click(sender As Object, e As System.EventArgs) Handles menuItem3.Click
      Me.runTestProceduresForPieChart()
   End Sub 'menuItem3_Click


   Private Sub menuItem20_Click(sender As Object, e As System.EventArgs) Handles menuItem20.Click
      Me.runTestProceduresForBarChart()
   End Sub 'menuItem20_Click


   Private Sub menuItem21_Click(sender As Object, e As System.EventArgs) Handles menuItem21.Click
      Me.runTestProceduresForAreaChart()
   End Sub 'menuItem21_Click


   Private Sub menuItem22_Click(sender As Object, e As System.EventArgs) Handles menuItem22.Click
      Me.runTestProceduresForHiLoChart()
   End Sub 'menuItem22_Click


   Private Sub menuItem23_Click(sender As Object, e As System.EventArgs) Handles menuItem23.Click
      Me.runTestProceduresForHiLoOpenCloseChart()
   End Sub 'menuItem23_Click


   Private Sub menuItem24_Click(sender As Object, e As System.EventArgs) Handles menuItem24.Click
      Me.runTestProceduresForBubbleChart()
   End Sub 'menuItem24_Click


   Private Sub menuItem25_Click(sender As Object, e As System.EventArgs) Handles menuItem25.Click
      Me.runTestProceduresForCandleChart()
   End Sub 'menuItem25_Click


   Private Sub menuItem26_Click(sender As Object, e As System.EventArgs) Handles menuItem26.Click
      Me.runTestProceduresForPolarChart()
   End Sub 'menuItem26_Click


   Private Sub menuItem27_Click(sender As Object, e As System.EventArgs) Handles menuItem27.Click
      Me.runTestProceduresForRadarChart()
   End Sub 'menuItem27_Click


   Private Sub menuItem28_Click(sender As Object, e As System.EventArgs) Handles menuItem28.Click
      Me.runTestProceduresForStackedXYChart()
   End Sub 'menuItem28_Click


   Private Sub menuItem29_Click(sender As Object, e As System.EventArgs) Handles menuItem29.Click
      Me.runTestProceduresForStackedAreaChart()
   End Sub 'menuItem29_Click


   Private Sub menuItem30_Click(sender As Object, e As System.EventArgs) Handles menuItem30.Click
      Me.runTestProceduresForStackedPolarChart()
   End Sub 'menuItem30_Click


   Private Sub menuItem31_Click(sender As Object, e As System.EventArgs) Handles menuItem31.Click
      Me.runTestProceduresForStackedRadarChart()
   End Sub 'menuItem31_Click


   Private Sub menuItem32_Click(sender As Object, e As System.EventArgs) Handles menuItem32.Click
      Me.runTestProceduresForSimpleStackedRadarChart()
   End Sub 'menuItem32_Click


   Private Sub menuItem33_Click(sender As Object, e As System.EventArgs) Handles menuItem33.Click
      Me.runTestProceduresForStackedBarChart()
   End Sub 'menuItem33_Click


   Private Sub menuItem5_Click(sender As Object, e As System.EventArgs) Handles menuItem5.Click
      Me.Close()
   End Sub 'menuItem5_Click


   Private Sub menuItem6_Click(sender As Object, e As System.EventArgs) Handles menuItem6.Click
      C1Chart1.Reset()
   End Sub 'menuItem6_Click


   Private Sub menuItem8_Click(sender As Object, e As System.EventArgs) Handles menuItem8.Click
      C1Chart1.PrintChart()
   End Sub 'menuItem8_Click


   Private Sub menuItem9_Click(sender As Object, e As System.EventArgs) Handles menuItem9.Click
      C1Chart1.PrintChart(PrintScaleEnum.ScaleToFit)
   End Sub 'menuItem9_Click


   Private Sub menuItem10_Click(sender As Object, e As System.EventArgs) Handles menuItem10.Click
      C1Chart1.PrintChart(PrintScaleEnum.ScaleToHeight)
   End Sub 'menuItem10_Click


   Private Sub menuItem11_Click(sender As Object, e As System.EventArgs) Handles menuItem11.Click
      C1Chart1.PrintChart(PrintScaleEnum.ScaleToMax)
   End Sub 'menuItem11_Click


   Private Sub menuItem12_Click(sender As Object, e As System.EventArgs) Handles menuItem12.Click
      C1Chart1.PrintChart(PrintScaleEnum.ScaleToWidth)
   End Sub 'menuItem12_Click


   Private Sub menuItem13_Click(sender As Object, e As System.EventArgs) Handles menuItem13.Click
      C1Chart1.PrintChart(PrintScaleEnum.ScaleNone)
   End Sub 'menuItem13_Click


   Private Sub menuItem15_Click(sender As Object, e As System.EventArgs) Handles menuItem15.Click
      C1Chart1.PageSetup()
   End Sub 'menuItem15_Click


   Private Sub menuItem16_Click(sender As Object, e As System.EventArgs) Handles menuItem16.Click
      C1Chart1.PrintSetup()
   End Sub 'menuItem16_Click


   Private Sub menuItem17_Click(sender As Object, e As System.EventArgs) Handles menuItem17.Click
      Dim usePrintDialog As Boolean = C1Chart1.PrintDialogUsage
      C1Chart1.PrintDialogUsage = Not usePrintDialog
      Me.menuItem17.Checked = Not usePrintDialog
   End Sub 'menuItem17_Click


   Private Sub menuItem19_Click(sender As Object, e As System.EventArgs) Handles menuItem19.Click
      C1Chart1.PrintChart()
   End Sub 'menuItem19_Click


   Private lastFilterIndex As Integer = 1

   Private Sub menuItem34_Click(sender As Object, e As System.EventArgs)
   End Sub 'menuItem34_Click


   Private Sub menuItem36_Click(sender As Object, e As System.EventArgs) Handles menuItem36.Click
      Dim sfd As New SaveFileDialog()
      sfd.DefaultExt = "chart2dxml"
      sfd.FileName = "doc1"
      sfd.Filter = "Chart files(*.chart2dxml)|*.chart2dxml|All files (*.*)|*.*"

      Dim dr As DialogResult = sfd.ShowDialog()
      If dr = DialogResult.OK Then
         C1Chart1.SaveChartToFile(sfd.FileName)
      End If
   End Sub 'menuItem36_Click

   Private Sub menuItem37_Click(sender As Object, e As System.EventArgs) Handles menuItem37.Click
      Dim ofd As New OpenFileDialog()
      ofd.DefaultExt = "chart2dxml"
      ofd.FileName = "doc1"
      ofd.Filter = "Chart files(*.chart2dxml)|*.chart2dxml|All files (*.*)|*.*"

      Dim dr As DialogResult = ofd.ShowDialog()
      If dr = DialogResult.OK Then
         C1Chart1.LoadChartFromFile(ofd.FileName)
      End If 
      doRefresh()
   End Sub 'menuItem37_Click


   Private Sub menuItem39_Click(sender As Object, e As System.EventArgs) Handles menuItem39.Click
      Dim sfd As New SaveFileDialog()
      sfd.DefaultExt = "datxml"
      sfd.FileName = "doc1"
      sfd.Filter = "Chart files(*.datxml)|*.datxml|All files (*.*)|*.*"

      Dim dr As DialogResult = sfd.ShowDialog()
      If dr = DialogResult.OK Then
         C1Chart1.ChartGroups(0).ChartData.SaveDataToFile(sfd.FileName)
      End If
   End Sub 'menuItem39_Click

   Private Sub menuItem40_Click(sender As Object, e As System.EventArgs) Handles menuItem40.Click
      Dim ofd As New OpenFileDialog()
      ofd.DefaultExt = "datxml"
      ofd.FileName = "doc1"
      ofd.Filter = "Chart files(*.datxml)|*.datxml|All files (*.*)|*.*"

      Dim dr As DialogResult = ofd.ShowDialog()
      If dr = DialogResult.OK Then
         C1Chart1.ChartGroups(0).ChartData.LoadDataFromFile(ofd.FileName)
      End If 
      doRefresh()
   End Sub 'menuItem40_Click


   Private Sub menuItem41_Click(sender As Object, e As System.EventArgs) Handles menuItem41.Click
      C1Chart1.ShowProperties()
   End Sub 'menuItem41_Click


   Private Sub menuItem42_Click(sender As Object, e As System.EventArgs) Handles menuItem42.Click
      ' save to file
      Dim sfg As New SaveFileDialog()

      sfg.Filter = "Metafiles (*.emf)|*.emf|" + "Bmp files (*.bmp)|*.bmp|" + "Gif files (*.gif)|*.gif|" + "Jpeg files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Png files (*.png)|*.png|" + "All graphic files (*.emf;*.bmp;*.gif;*.jpg;*.jpeg;*.png)|*.emf;*.bmp;*.gif;*.jpg;*.jpeg;*.png"
      sfg.FilterIndex = lastFilterIndex
      sfg.OverwritePrompt = True
      sfg.CheckPathExists = True
      sfg.RestoreDirectory = False
      sfg.ValidateNames = True

      If sfg.ShowDialog() = DialogResult.OK Then
         Dim fn As String = sfg.FileName
         Dim indext As Integer = fn.LastIndexOf("."c)
         If indext < 0 Then
            indext = fn.Length + 1
            fn += ".emf"
         Else
            indext += 1
         End If 
         Dim ext As String = fn.Substring(indext)
         Dim imgfmt As ImageFormat = Nothing

         Select Case ext
         Case "emf"
            imgfmt = ImageFormat.Emf
            C1Chart1.SaveImage(fn, imgfmt)

         Case "bmp"
            imgfmt = ImageFormat.Bmp

         Case "gif"
            imgfmt = ImageFormat.Gif

         Case "jpeg", "jpg"
            imgfmt = ImageFormat.Jpeg

         Case "png"
            imgfmt = ImageFormat.Png

         Case Else
            Return
         End Select

         lastFilterIndex = sfg.FilterIndex

         If Not imgfmt.Equals(ImageFormat.Emf) Then
            Dim img As Image = C1Chart1.GetImage()
            img.Save(fn, imgfmt)
            img.Dispose()
         End If
      End If
      sfg.Dispose()
   End Sub 'menuItem42_Click


   Private Sub menuItem44_Click(sender As Object, e As System.EventArgs) Handles menuItem44.Click
      ' Save to Clipboard as bmp
      C1Chart1.SaveImage(ImageFormat.Bmp)
   End Sub 'menuItem44_Click


   Private Sub menuItem45_Click(sender As Object, e As System.EventArgs) Handles menuItem45.Click
      ' Save to Clipboard as emf
      C1Chart1.SaveImage(ImageFormat.Emf)
   End Sub 'menuItem45_Click
End Class 'Form1
