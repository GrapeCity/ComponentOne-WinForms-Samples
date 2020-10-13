
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing.Printing
Imports System.IO

Imports C1.Win.C1Chart3D



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private propertyGrid1 As System.Windows.Forms.PropertyGrid
   WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
   WithEvents numericUpDown2 As System.Windows.Forms.NumericUpDown
   WithEvents numericUpDown3 As System.Windows.Forms.NumericUpDown
   Private mainMenu1 As System.Windows.Forms.MenuStrip
   WithEvents menuItem1 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem2 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem3 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem4 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem5 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem6 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem7 As System.Windows.Forms.ToolStripMenuItem
   WithEvents timer1 As System.Windows.Forms.Timer
   WithEvents checkBox1 As System.Windows.Forms.CheckBox
   WithEvents checkBox2 As System.Windows.Forms.CheckBox
   WithEvents checkBox3 As System.Windows.Forms.CheckBox
   WithEvents menuSepItem8 As System.Windows.Forms.ToolStripSeparator
   WithEvents menuItem9 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem10 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem11 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem12 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem13 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem14 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem15 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem16 As System.Windows.Forms.ToolStripMenuItem
   Private components As System.ComponentModel.IContainer
   WithEvents menuSepItem17 As System.Windows.Forms.ToolStripSeparator
   WithEvents menuItem18 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuSepItem19 As System.Windows.Forms.ToolStripSeparator
   WithEvents menuItem20 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem21 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem22 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuSepItem23 As System.Windows.Forms.ToolStripSeparator
   WithEvents menuItem24 As System.Windows.Forms.ToolStripMenuItem
   Private c1Chart3D1 As C1.Win.C1Chart3D.C1Chart3D
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   Private label3 As System.Windows.Forms.Label
   Private panel1 As System.Windows.Forms.Panel
   '
   Private angleIncrement As Integer = 2
   Private setPoint As Chart3DDataSetPoint
   Private setGrid As Chart3DDataSetGrid
   Private setIrGrid As Chart3DDataSetIrGrid
   Private pointData(27) As Chart3DPoint
   Private pointData1(27) As Chart3DPoint
   Private contourData(,) As Double
   WithEvents menuSepItem25 As System.Windows.Forms.ToolStripSeparator
   WithEvents menuItem26 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem27 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem28 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuItem29 As System.Windows.Forms.ToolStripMenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.ToolStripMenuItem
   Private bUpdate As Boolean = True


   Public Sub New()
      InitializeComponent()

      '
      ' TODO: Add any constructor code after InitializeComponent call
      '
      numericUpDown1.Minimum = -360
      numericUpDown1.Maximum = 360
      numericUpDown1.Increment = CDec(angleIncrement)
      numericUpDown1.Value = CDec(c1Chart3D1.ChartArea.View.RotationX)

      numericUpDown2.Maximum = 360
      numericUpDown2.Minimum = -360
      numericUpDown2.Increment = CDec(angleIncrement)
      numericUpDown2.Value = CDec(c1Chart3D1.ChartArea.View.RotationY)

      numericUpDown3.Maximum = 360
      numericUpDown3.Minimum = -360
      numericUpDown3.Increment = CDec(angleIncrement)
      numericUpDown3.Value = CDec(c1Chart3D1.ChartArea.View.RotationZ)
   End Sub 'New


   '/ <summary>
   '/ Clean up any resources being used.
   '/ </summary>
   Public Shadows Sub Dispose(disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub 'Dispose


#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
      Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
      Me.c1Chart3D1 = New C1.Win.C1Chart3D.C1Chart3D()
      Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
      Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown()
      Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
      Me.mainMenu1 = New System.Windows.Forms.MenuStrip()
      Me.menuItem14 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem21 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem22 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuSepItem23 = New System.Windows.Forms.ToolStripSeparator()
      Me.menuItem15 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem16 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuSepItem19 = New System.Windows.Forms.ToolStripSeparator()
      Me.menuItem28 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem24 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem20 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem4 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem27 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem26 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuSepItem25 = New System.Windows.Forms.ToolStripSeparator()
      Me.menuItem5 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem6 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem7 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuSepItem17 = New System.Windows.Forms.ToolStripSeparator()
      Me.menuItem18 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem1 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem2 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem12 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem13 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem3 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem11 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuSepItem8 = New System.Windows.Forms.ToolStripSeparator()
      Me.menuItem9 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem10 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuItem29 = New System.Windows.Forms.ToolStripMenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
      Me.timer1 = New System.Windows.Forms.Timer(Me.components)
      Me.checkBox1 = New System.Windows.Forms.CheckBox()
      Me.checkBox2 = New System.Windows.Forms.CheckBox()
      Me.checkBox3 = New System.Windows.Forms.CheckBox()
      Me.label1 = New System.Windows.Forms.Label()
      Me.label2 = New System.Windows.Forms.Label()
      Me.label3 = New System.Windows.Forms.Label()
      Me.panel1 = New System.Windows.Forms.Panel()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.mainMenu1.SuspendLayout()
      Me.panel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'propertyGrid1
      '
      Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
      Me.propertyGrid1.Location = New System.Drawing.Point(8, 81)
      Me.propertyGrid1.Name = "propertyGrid1"
      Me.propertyGrid1.SelectedObject = Me.c1Chart3D1
      Me.propertyGrid1.Size = New System.Drawing.Size(224, 353)
      Me.propertyGrid1.TabIndex = 0
      '
      'c1Chart3D1
      '
      Me.c1Chart3D1.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.c1Chart3D1.Location = New System.Drawing.Point(232, 25)
      Me.c1Chart3D1.Name = "c1Chart3D1"
      Me.c1Chart3D1.PropBag = resources.GetString("c1Chart3D1.PropBag")
      Me.c1Chart3D1.Size = New System.Drawing.Size(360, 409)
      Me.c1Chart3D1.TabIndex = 7
      '
      'numericUpDown2
      '
      Me.numericUpDown2.Location = New System.Drawing.Point(80, 24)
      Me.numericUpDown2.Name = "numericUpDown2"
      Me.numericUpDown2.Size = New System.Drawing.Size(48, 20)
      Me.numericUpDown2.TabIndex = 2
      '
      'numericUpDown3
      '
      Me.numericUpDown3.Location = New System.Drawing.Point(152, 24)
      Me.numericUpDown3.Name = "numericUpDown3"
      Me.numericUpDown3.Size = New System.Drawing.Size(48, 20)
      Me.numericUpDown3.TabIndex = 2
      '
      'numericUpDown1
      '
      Me.numericUpDown1.Location = New System.Drawing.Point(8, 24)
      Me.numericUpDown1.Name = "numericUpDown1"
      Me.numericUpDown1.Size = New System.Drawing.Size(48, 20)
      Me.numericUpDown1.TabIndex = 2
      '
      'mainMenu1
      '
      Me.mainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem14, Me.menuItem4, Me.menuItem1, Me.menuItem29})
      Me.mainMenu1.Location = New System.Drawing.Point(0, 0)
      Me.mainMenu1.Name = "mainMenu1"
      Me.mainMenu1.Size = New System.Drawing.Size(592, 24)
      Me.mainMenu1.TabIndex = 12
      '
      'menuItem14
      '
      Me.menuItem14.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem21, Me.menuItem22, Me.menuSepItem23, Me.menuItem15, Me.menuItem16, Me.menuSepItem19, Me.menuItem28, Me.menuItem24, Me.menuItem20})
      Me.menuItem14.Name = "menuItem14"
      Me.menuItem14.Size = New System.Drawing.Size(35, 20)
      Me.menuItem14.Text = "File"
      '
      'menuItem21
      '
      Me.menuItem21.Name = "menuItem21"
      Me.menuItem21.Size = New System.Drawing.Size(137, 22)
      Me.menuItem21.Text = "Open Chart"
      '
      'menuItem22
      '
      Me.menuItem22.Name = "menuItem22"
      Me.menuItem22.Size = New System.Drawing.Size(137, 22)
      Me.menuItem22.Text = "Save Chart"
      '
      'menuItem23
      '
      Me.menuSepItem23.Name = "menuItem23"
      Me.menuSepItem23.Size = New System.Drawing.Size(134, 6)
      '
      'menuItem15
      '
      Me.menuItem15.Name = "menuItem15"
      Me.menuItem15.Size = New System.Drawing.Size(137, 22)
      Me.menuItem15.Text = "Load Data"
      '
      'menuItem16
      '
      Me.menuItem16.Name = "menuItem16"
      Me.menuItem16.Size = New System.Drawing.Size(137, 22)
      Me.menuItem16.Text = "Save Data"
      '
      'menuItem19
      '
      Me.menuSepItem19.Name = "menuItem19"
      Me.menuSepItem19.Size = New System.Drawing.Size(134, 6)
      '
      'menuItem28
      '
      Me.menuItem28.Name = "menuItem28"
      Me.menuItem28.Size = New System.Drawing.Size(137, 22)
      Me.menuItem28.Text = "Save Image"
      '
      'menuItem24
      '
      Me.menuItem24.Name = "menuItem24"
      Me.menuItem24.Size = New System.Drawing.Size(137, 22)
      Me.menuItem24.Text = "Print Preview"
      '
      'menuItem20
      '
      Me.menuItem20.Name = "menuItem20"
      Me.menuItem20.Size = New System.Drawing.Size(137, 22)
      Me.menuItem20.Text = "Exit"
      '
      'menuItem4
      '
      Me.menuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem27, Me.menuItem26, Me.menuSepItem25, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuSepItem17, Me.menuItem18})
      Me.menuItem4.Name = "menuItem4"
      Me.menuItem4.Size = New System.Drawing.Size(46, 20)
      Me.menuItem4.Text = "Chart"
      '
      'menuItem27
      '
      Me.menuItem27.Name = "menuItem27"
      Me.menuItem27.Size = New System.Drawing.Size(123, 22)
      Me.menuItem27.Text = "Properties"
      '
      'menuItem26
      '
      Me.menuItem26.Name = "menuItem26"
      Me.menuItem26.Size = New System.Drawing.Size(123, 22)
      Me.menuItem26.Text = "Wizard"
      '
      'menuItem25
      '
      Me.menuSepItem25.Name = "menuItem25"
      Me.menuSepItem25.Size = New System.Drawing.Size(120, 6)
      '
      'menuItem5
      '
      Me.menuItem5.Name = "menuItem5"
      Me.menuItem5.Size = New System.Drawing.Size(123, 22)
      Me.menuItem5.Text = "Bar"
      '
      'menuItem6
      '
      Me.menuItem6.Name = "menuItem6"
      Me.menuItem6.Size = New System.Drawing.Size(123, 22)
      Me.menuItem6.Text = "Scatter"
      '
      'menuItem7
      '
      Me.menuItem7.Name = "menuItem7"
      Me.menuItem7.Size = New System.Drawing.Size(123, 22)
      Me.menuItem7.Text = "Surface"
      '
      'menuItem17
      '
      Me.menuSepItem17.Name = "menuItem17"
      Me.menuSepItem17.Size = New System.Drawing.Size(120, 6)
      '
      'menuItem18
      '
      Me.menuItem18.Name = "menuItem18"
      Me.menuItem18.Size = New System.Drawing.Size(123, 22)
      Me.menuItem18.Text = "Interacive"
      '
      'menuItem1
      '
      Me.menuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem2, Me.menuItem3, Me.menuItem11, Me.menuSepItem8, Me.menuItem9, Me.menuItem10})
      Me.menuItem1.Name = "menuItem1"
      Me.menuItem1.Size = New System.Drawing.Size(42, 20)
      Me.menuItem1.Text = "Data"
      '
      'menuItem2
      '
      Me.menuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem12, Me.menuItem13})
      Me.menuItem2.Name = "menuItem2"
      Me.menuItem2.Size = New System.Drawing.Size(135, 22)
      Me.menuItem2.Text = "Points"
      '
      'menuItem12
      '
      Me.menuItem12.Name = "menuItem12"
      Me.menuItem12.Size = New System.Drawing.Size(111, 22)
      Me.menuItem12.Text = "1 series"
      '
      'menuItem13
      '
      Me.menuItem13.Name = "menuItem13"
      Me.menuItem13.Size = New System.Drawing.Size(111, 22)
      Me.menuItem13.Text = "2 series"
      '
      'menuItem3
      '
      Me.menuItem3.Name = "menuItem3"
      Me.menuItem3.Size = New System.Drawing.Size(135, 22)
      Me.menuItem3.Text = "Grid"
      '
      'menuItem11
      '
      Me.menuItem11.Name = "menuItem11"
      Me.menuItem11.Size = New System.Drawing.Size(135, 22)
      Me.menuItem11.Text = "IrregularGrid"
      '
      'menuItem8
      '
      Me.menuSepItem8.Name = "menuItem8"
      Me.menuSepItem8.Size = New System.Drawing.Size(132, 6)
      '
      'menuItem9
      '
      Me.menuItem9.Name = "menuItem9"
      Me.menuItem9.Size = New System.Drawing.Size(135, 22)
      Me.menuItem9.Text = "Holes"
      '
      'menuItem10
      '
      Me.menuItem10.Name = "menuItem10"
      Me.menuItem10.Size = New System.Drawing.Size(135, 22)
      Me.menuItem10.Text = "4D"
      '
      'menuItem29
      '
      Me.menuItem29.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpAbout})
      Me.menuItem29.Name = "menuItem29"
      Me.menuItem29.Size = New System.Drawing.Size(40, 20)
      Me.menuItem29.Text = "&Help"
      '
      'menuHelpAbout
      '
      Me.menuHelpAbout.Name = "menuHelpAbout"
      Me.menuHelpAbout.Size = New System.Drawing.Size(103, 22)
      Me.menuHelpAbout.Text = "&About"
      '
      'timer1
      '
      Me.timer1.Interval = 200
      '
      'checkBox1
      '
      Me.checkBox1.Location = New System.Drawing.Point(56, 24)
      Me.checkBox1.Name = "checkBox1"
      Me.checkBox1.Size = New System.Drawing.Size(16, 24)
      Me.checkBox1.TabIndex = 3
      Me.checkBox1.Text = "checkBox1"
      '
      'checkBox2
      '
      Me.checkBox2.Location = New System.Drawing.Point(128, 24)
      Me.checkBox2.Name = "checkBox2"
      Me.checkBox2.Size = New System.Drawing.Size(16, 24)
      Me.checkBox2.TabIndex = 4
      Me.checkBox2.Text = "checkBox2"
      '
      'checkBox3
      '
      Me.checkBox3.Location = New System.Drawing.Point(200, 24)
      Me.checkBox3.Name = "checkBox3"
      Me.checkBox3.Size = New System.Drawing.Size(16, 24)
      Me.checkBox3.TabIndex = 5
      Me.checkBox3.Text = "checkBox3"
      '
      'label1
      '
      Me.label1.Location = New System.Drawing.Point(8, 8)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(48, 16)
      Me.label1.TabIndex = 8
      Me.label1.Text = "Rot X"
      '
      'label2
      '
      Me.label2.Location = New System.Drawing.Point(80, 8)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(48, 16)
      Me.label2.TabIndex = 9
      Me.label2.Text = "Rot Y"
      '
      'label3
      '
      Me.label3.Location = New System.Drawing.Point(152, 8)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(48, 16)
      Me.label3.TabIndex = 10
      Me.label3.Text = "Rot Z"
      '
      'panel1
      '
      Me.panel1.BackColor = System.Drawing.SystemColors.Control
      Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panel1.Controls.Add(Me.checkBox1)
      Me.panel1.Controls.Add(Me.label3)
      Me.panel1.Controls.Add(Me.label2)
      Me.panel1.Controls.Add(Me.numericUpDown2)
      Me.panel1.Controls.Add(Me.checkBox3)
      Me.panel1.Controls.Add(Me.checkBox2)
      Me.panel1.Controls.Add(Me.label1)
      Me.panel1.Controls.Add(Me.numericUpDown3)
      Me.panel1.Controls.Add(Me.numericUpDown1)
      Me.panel1.ForeColor = System.Drawing.SystemColors.ControlText
      Me.panel1.Location = New System.Drawing.Point(8, 26)
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(224, 56)
      Me.panel1.TabIndex = 11
      '
      'Form1
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 436)
      Me.Controls.Add(Me.panel1)
      Me.Controls.Add(Me.c1Chart3D1)
      Me.Controls.Add(Me.propertyGrid1)
      Me.Controls.Add(Me.mainMenu1)
      Me.MainMenuStrip = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 3D - PropertyGrid Demo"
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.mainMenu1.ResumeLayout(False)
      Me.mainMenu1.PerformLayout()
      Me.panel1.ResumeLayout(False)
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


   Private Sub OnValueChanged1(sender As Object, e As System.EventArgs) Handles numericUpDown1.ValueChanged
      If bUpdate Then
         c1Chart3D1.ChartArea.View.RotationX = CInt(numericUpDown1.Value)
      End If
   End Sub 'OnValueChanged1

   Private Sub OnValueChanged2(sender As Object, e As System.EventArgs) Handles numericUpDown2.ValueChanged
      If bUpdate Then
         c1Chart3D1.ChartArea.View.RotationY = CInt(numericUpDown2.Value)
      End If
   End Sub 'OnValueChanged2

   Private Sub OnValueChanged3(sender As Object, e As System.EventArgs) Handles numericUpDown3.ValueChanged
      If bUpdate Then
         c1Chart3D1.ChartArea.View.RotationZ = CInt(numericUpDown3.Value)
      End If
   End Sub 'OnValueChanged3

   Sub createTestData()
      Dim i, j As Integer
      Dim x, y As Single
      ' init point dataset
      setPoint = New Chart3DDataSetPoint()

      Dim ix As Integer
      For ix = 0 To 2
         Dim iy As Integer
         For iy = 0 To 2
            Dim iz As Integer
            For iz = 0 To 2
               pointData((ix + 3 * iy + 9 * iz)).X = ix
               pointData((ix + 3 * iy + 9 * iz)).Y = iy
               pointData((ix + 3 * iy + 9 * iz)).Z = iz

               pointData1((ix + 3 * iy + 9 * iz)).X = 3 + 2 * ix
               pointData1((ix + 3 * iy + 9 * iz)).Y = 2 * iy
               pointData1((ix + 3 * iy + 9 * iz)).Z = 2 * iz
            Next iz
         Next iy 
      Next ix
      setPoint.AddSeries(pointData)
      setPoint.AddSeries(pointData1)

      'float[,] gridData = new float[ 11, 11];
      Dim gridData As Single(,) = CType(Array.CreateInstance(GetType(Single), 11, 11), Single(,))
      For i = 0 To (gridData.GetLength(0)) - 1
         For j = 0 To (gridData.GetLength(1)) - 1
            x = - 5 + i
            y = - 5 + j
            gridData(i, j) = 0.1F * x * x - 0.4F * y * y
         Next j
      Next i 
      setGrid = New Chart3DDataSetGrid(- 5, - 5, 1, 1, gridData)

      ' contour data for 4d chart
      contourData = CType(Array.CreateInstance(GetType(Double), setGrid.ColumnCount, setGrid.RowCount), Double(,))
      For i = 0 To setGrid.ColumnCount - 1
         For j = 0 To setGrid.RowCount - 1
            contourData(i, j) = i + j
         Next j
      Next i 
      ' init irregular grid dataset
      Dim xdata As Single() =  {1, 2, 6, 8, 9, 13, 15}
      Dim ydata As Single() =  {1, 2, 4, 8, 11, 12, 15}
      Dim vals As Single(,) = CType(Array.CreateInstance(GetType(Single), xdata.Length, ydata.Length), Single(,))

      setIrGrid = New Chart3DDataSetIrGrid(xdata, ydata, vals)

      If (True) Then
         x = CSng(setIrGrid.ColumnOrigin)
         For i = 0 To setIrGrid.ColumnCount - 1
            x += CSng(setIrGrid.ColumnDeltaArray(i))
            y = CSng(setIrGrid.RowOrigin)
            For j = 0 To setIrGrid.RowCount - 1
               y += CSng(setIrGrid.RowDeltaArray(j))
               Dim val As Single = 0.1F * x * x - 0.4F * y * y
               setIrGrid.SetValue(i, j, val)
            Next j
         Next i
      End If
      ' starting dataset
      c1Chart3D1.ChartGroups(0).ChartData.Set = setGrid

      ' adding labels to chart
      Dim labelC As Chart3DLabel = c1Chart3D1.ChartLabels.LabelsCollection.AddNewLabel()
      labelC.Text = "Label(Coordinate)"
      labelC.LabelCompass = LabelCompassEnum.SouthEast
      labelC.AttachMethodData.X = 20
      labelC.AttachMethodData.Y = 20
      labelC.Visible = True

      Dim labelD As Chart3DLabel = c1Chart3D1.ChartLabels.LabelsCollection.AddNewLabel()
      labelD.Text = "Label(DataCoordinate)"
      labelD.LabelCompass = LabelCompassEnum.SouthEast
      labelD.Offset = 50
      labelD.Connected = True
      labelD.AttachMethod = AttachMethodEnum.DataCoordinate
      labelD.AttachMethodData.X = 0
      labelD.AttachMethodData.Y = 0
      labelD.AttachMethodData.Z = 0
      labelD.Visible = True

      Dim labelI As Chart3DLabel = c1Chart3D1.ChartLabels.LabelsCollection.AddNewLabel()
      labelI.Text = "Label(DataIndex)"
      labelI.LabelCompass = LabelCompassEnum.SouthWest
      labelI.Offset = 25
      labelI.Connected = True
      labelI.AttachMethod = AttachMethodEnum.DataIndex
      labelI.AttachMethodData.SeriesIndex = 2
      labelI.AttachMethodData.PointIndex = 4
      labelI.Visible = True

      ' adding data labels
      c1Chart3D1.DefaultLabelStyle.BackColor = Color.MistyRose
      c1Chart3D1.DefaultLabelStyle.Border.BorderStyle = BorderStyleEnum.Solid
      For i = 0 To setGrid.RowCount - 1
         Dim lab As Chart3DDataLabel = c1Chart3D1.ChartGroups.RowLabels.AddNewLabel()
         lab.Index = i
         lab.Text = "Row " + i.ToString()
      Next i
      For j = 0 To setGrid.ColumnCount - 1
         Dim lab As Chart3DDataLabel = c1Chart3D1.ChartGroups.ColumnLabels.AddNewLabel()
         lab.Index = j
         lab.Text = "Col " + j.ToString()
      Next j

      ' adding labels to axis
      Dim axis As Chart3DAxis
      For Each axis In  c1Chart3D1.ChartArea.Axes
         Dim alab1 As Chart3DAxisLabel = axis.ValueLabels.AddNewLabel()
         alab1.Value = - 1
         alab1.Text = "minus one"

         Dim alab2 As Chart3DAxisLabel = axis.ValueLabels.AddNewLabel()
         alab2.Value = + 1
         alab2.Text = "plus one"
      Next axis

      ' set bar colors
      c1Chart3D1.ChartGroups(0).Bar.SetBarColor(1, 1, Color.Red)
      c1Chart3D1.ChartGroups(0).Bar.SetBarColor(1, 2, Color.Red)
      c1Chart3D1.ChartGroups(0).Bar.SetBarColor(- 1, 3, Color.Blue)
      c1Chart3D1.ChartGroups(0).Bar.SetBarColor(3, - 1, Color.Green)
   End Sub 'createTestData


   Private Sub FormLoad(sender As Object, e As System.EventArgs) Handles MyBase.Load
      createTestData()
      AddHandler c1Chart3D1.ChartArea.View.AfterRotate, AddressOf RotateHandler
      Me.propertyGrid1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left 
      Me.c1Chart3D1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
   End Sub 'FormLoad
   'c1Chart3D1.DumpModel();

   Private Sub menuItem3_Click(sender As Object, e As System.EventArgs) Handles menuItem3.Click
      c1Chart3D1.ChartGroups(0).ChartData.Set = setGrid
   End Sub 'menuItem3_Click


   Private Sub menuItem5_Click(sender As Object, e As System.EventArgs) Handles menuItem5.Click
      c1Chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Bar
   End Sub 'menuItem5_Click


   Private Sub menuItem6_Click(sender As Object, e As System.EventArgs) Handles menuItem6.Click
      c1Chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Scatter
   End Sub 'menuItem6_Click


   Private Sub menuItem7_Click(sender As Object, e As System.EventArgs) Handles menuItem7.Click
      c1Chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Surface
   End Sub 'menuItem7_Click


   Private Sub timer1_Tick(sender As Object, e As System.EventArgs) Handles timer1.Tick
      If checkBox1.Checked Then
         c1Chart3D1.ChartArea.View.RotationX += angleIncrement
         If c1Chart3D1.ChartArea.View.RotationX >= 360 Then
            c1Chart3D1.ChartArea.View.RotationX = 0
         End If
         numericUpDown1.Value = CDec(c1Chart3D1.ChartArea.View.RotationX)
      End If
      If checkBox2.Checked Then
         c1Chart3D1.ChartArea.View.RotationY += angleIncrement
         If c1Chart3D1.ChartArea.View.RotationY >= 360 Then
            c1Chart3D1.ChartArea.View.RotationY = 0
         End If
         numericUpDown2.Value = CDec(c1Chart3D1.ChartArea.View.RotationY)
      End If
      If checkBox3.Checked Then
         c1Chart3D1.ChartArea.View.RotationZ += angleIncrement
         If c1Chart3D1.ChartArea.View.RotationZ >= 360 Then
            c1Chart3D1.ChartArea.View.RotationZ = 0
         End If
         numericUpDown3.Value = CDec(c1Chart3D1.ChartArea.View.RotationZ)
      End If
   End Sub 'timer1_Tick


   Private Sub checkBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles checkBox1.CheckedChanged, checkBox2.CheckedChanged, checkBox3.CheckedChanged
      timer1.Enabled = checkBox1.Checked OrElse checkBox2.Checked OrElse checkBox3.Checked
   End Sub 'checkBox1_CheckedChanged


   Sub setHoles(grset As Chart3DDataSetGrid, enable As Boolean)
      Dim i, j As Integer
      If enable Then
         For i = 0 To grset.ColumnCount - 1
            For j = 0 To grset.RowCount - 1
               Dim x As Single
               Dim y As Single

               If TypeOf grset Is Chart3DDataSetIrGrid Then
                  Dim s As Chart3DDataSetIrGrid = CType(grset, Chart3DDataSetIrGrid)
                  x = CSng(s.GetColumnValue(i))
                  y = CSng(s.GetRowValue(j))
               Else
                  x = CSng(grset.MinX + i * grset.RowDelta)
                  y = CSng(grset.MinY + j * grset.ColumnDelta)
               End If

               Dim val As Single = 0.1F * x * x - 0.4F * y * y
               If i = j OrElse i = grset.RowCount - j Then
                  grset.SetValue(i, j, val)
               End If
            Next j
         Next i
      Else
         For i = 0 To grset.ColumnCount - 1
            For j = 0 To grset.RowCount - 1
               ' holes
               If i = j OrElse i = grset.RowCount - j Then
                  grset.SetValue(i, j, grset.Hole)
               End If
            Next j
         Next i
      End If 
   End Sub 'setHoles

   Private Sub menuItem9_Click(sender As Object, e As System.EventArgs) Handles menuItem9.Click
      setHoles(setGrid, menuItem9.Checked)
      setHoles(CType(setIrGrid, Chart3DDataSetGrid), menuItem9.Checked)
      menuItem9.Checked = Not menuItem9.Checked
   End Sub 'menuItem9_Click


   Private Sub menuItem10_Click(sender As Object, e As System.EventArgs) Handles menuItem10.Click
      If c1Chart3D1.ChartGroups(0).ChartData.ContourData Is Nothing Then
         c1Chart3D1.ChartGroups(0).ChartData.ContourData = contourData
      Else
         c1Chart3D1.ChartGroups(0).ChartData.ContourData = Nothing
      End If
   End Sub 'menuItem10_Click

   Private Sub menuItem11_Click(sender As Object, e As System.EventArgs) Handles menuItem11.Click
      c1Chart3D1.ChartGroups(0).ChartData.Set = Me.setIrGrid
   End Sub 'menuItem11_Click


   Private Sub menuItem13_Click(sender As Object, e As System.EventArgs) Handles menuItem13.Click
      If setPoint.SeriesCollection.Count = 1 Then
         setPoint.AddSeries(pointData1)
      End If 
      c1Chart3D1.ChartGroups(0).ChartData.Set = setPoint
      c1Chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Scatter
   End Sub 'menuItem13_Click


   Private Sub menuItem12_Click(sender As Object, e As System.EventArgs) Handles menuItem12.Click
      If setPoint.SeriesCollection.Count = 2 Then
         setPoint.RemoveSeries(1)
      End If
      c1Chart3D1.ChartGroups(0).ChartData.Set = setPoint
      c1Chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Scatter
   End Sub 'menuItem12_Click


   Private Sub c1Chart3D1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
   End Sub 'c1Chart3D1_MouseMove

   'float x=0, y=0, z=0;
   'c1Chart3D1.ChartGroups[0].ChartData.CoordToDataCoord( e.X, e.Y, ref x, ref y, ref z);
   'c1Chart3D1.ChartLabels[0].Text = String.Format( " {0}, {1}, {2}", x, y, z );

   Private Sub RotateHandler(sender As Object, e As RotateEventArgs)
      bUpdate = False
      numericUpDown1.Value = CDec(e.RotationX / Math.PI * 180)
      numericUpDown2.Value = CDec(e.RotationY / Math.PI * 180)
      numericUpDown3.Value = CDec(e.RotationZ / Math.PI * 180)
      bUpdate = True
   End Sub 'RotateHandler


   Private Sub menuItem15_Click(sender As Object, e As System.EventArgs) Handles menuItem15.Click
      Dim ofd As New OpenFileDialog()
      ofd.DefaultExt = "dat3xml"
      ofd.FileName = "doc1"
      ofd.Filter = "Chart3D.Net xml data files(*.dat3xml)|*.dat3xml|C1Chart7 data files(*.dat)|*.dat"

      If ofd.ShowDialog() = DialogResult.OK Then
         c1Chart3D1.ChartGroups(0).ChartData.LoadDataFromFile(ofd.FileName)
      End If
   End Sub 'menuItem15_Click

   Private Sub menuItem16_Click(sender As Object, e As System.EventArgs) Handles menuItem16.Click
      Dim sfd As New SaveFileDialog()
      sfd.DefaultExt = "dat3xml"
      sfd.FileName = "doc1"
      sfd.Filter = "Chart3D.Net xml data files(*.dat3xml)|*.dat3xml|C1Chart7 data files(*.dat)|*.dat"

      If sfd.ShowDialog() = DialogResult.OK Then
         c1Chart3D1.ChartGroups(0).ChartData.SaveDataToFile(sfd.FileName)
      End If
   End Sub 'menuItem16_Click

   Private Sub menuItem18_Click(sender As Object, e As System.EventArgs) Handles menuItem18.Click
      c1Chart3D1.ChartArea.View.IsInteractive = Not c1Chart3D1.ChartArea.View.IsInteractive
      menuItem18.Checked = c1Chart3D1.ChartArea.View.IsInteractive
   End Sub 'menuItem18_Click


   Private Sub menuItem20_Click(sender As Object, e As System.EventArgs) Handles menuItem20.Click
      Me.Close()
   End Sub 'menuItem20_Click


   Private Sub menuItem21_Click(sender As Object, e As System.EventArgs) Handles menuItem21.Click
      Dim ofd As New OpenFileDialog()
      ofd.DefaultExt = "chart3dxml"
      ofd.FileName = "doc1"
      ofd.Filter = "Chart3D xml files(*.chart3dxml)|*.chart3dxml|All files (*.*)|*.*"

      If ofd.ShowDialog() = DialogResult.OK Then
         c1Chart3D1.LoadChartFromFile(ofd.FileName)
      End If
   End Sub 'menuItem21_Click

   Private Sub menuItem22_Click(sender As Object, e As System.EventArgs) Handles menuItem22.Click
      Dim sfd As New SaveFileDialog()
      sfd.DefaultExt = "chart3dxml"
      sfd.FileName = "doc1"
      sfd.Filter = "Chart3D xml files(*.chart3dxml)|*.chart3dxml|All files (*.*)|*.*"

      If sfd.ShowDialog() = DialogResult.OK Then
         c1Chart3D1.SaveChartToFile(sfd.FileName)
      End If
   End Sub 'menuItem22_Click

   Private Sub menuItem24_Click(sender As Object, e As System.EventArgs) Handles menuItem24.Click
      Dim pd As New PrintDocument()
      AddHandler pd.PrintPage , AddressOf Me.pd_PrintPage

      Dim preview As New PrintPreviewDialog()
      preview.Document = pd
      preview.ShowDialog()
   End Sub 'menuItem24_Click


   Private Sub pd_PrintPage(sender As Object, ev As PrintPageEventArgs)
      Me.c1Chart3D1.Draw(ev.Graphics, ev.MarginBounds)
   End Sub 'pd_PrintPage


   Private Sub menuItem26_Click(sender As Object, e As System.EventArgs) Handles menuItem26.Click
      c1Chart3D1.ShowWizard()
   End Sub 'menuItem26_Click


   Private Sub menuItem27_Click_1(sender As Object, e As System.EventArgs) Handles menuItem27.Click
      c1Chart3D1.ShowProperties()
   End Sub 'menuItem27_Click_1


   Private Sub menuItem28_Click(sender As Object, e As System.EventArgs) Handles menuItem28.Click
      Dim sfg As New SaveFileDialog()

      sfg.Filter = "Metafiles (*.emf)|*.emf|" + "Bmp files (*.bmp)|*.bmp|" + "Gif files (*.gif)|*.gif|" + "Jpeg files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Png files (*.png)|*.png"
      sfg.DefaultExt = "emf"
      sfg.FileName = "image1"
      sfg.OverwritePrompt = True
      sfg.CheckPathExists = True
      sfg.RestoreDirectory = False
      sfg.ValidateNames = True

      If sfg.ShowDialog() = DialogResult.OK Then
         Dim imgfmt As ImageFormat = Nothing
         Select Case Path.GetExtension(sfg.FileName)
         Case ".emf"
            imgfmt = ImageFormat.Emf

         Case ".bmp"
            imgfmt = ImageFormat.Bmp

         Case ".gif"
            imgfmt = ImageFormat.Gif

         Case ".jpeg", ".jpg"
            imgfmt = ImageFormat.Jpeg

         Case ".png"
            imgfmt = ImageFormat.Png

         Case Else
            Return
         End Select
         c1Chart3D1.SaveImage(sfg.FileName, imgfmt)
      End If
   End Sub 'menuItem28_Click


   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
End Class 'Form1
