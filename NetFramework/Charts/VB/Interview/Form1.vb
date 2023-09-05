
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private panel1 As System.Windows.Forms.Panel
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents chbFilled As System.Windows.Forms.CheckBox
   WithEvents chbThick As System.Windows.Forms.CheckBox
   Private pictureBox1 As System.Windows.Forms.PictureBox
   WithEvents chbAntiAlias As System.Windows.Forms.CheckBox
   WithEvents button1 As System.Windows.Forms.Button
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
      InitializeComponent()
      
      InitChart()
      SetupChartData()
      
      chbFilled.Checked = c1Chart1.ChartGroups(0).Radar.Filled
      chbThick.Checked = c1Chart1.ChartGroups(0).ChartData.SeriesList(0).LineStyle.Thickness > 1
      chbAntiAlias.Checked = c1Chart1.UseAntiAliasedGraphics
   End Sub 'New
   
   
   '/ <summary>
   '/ Clean up any resources being used.
   '/ </summary>
   Protected Overloads Overrides Sub Dispose(disposing As Boolean) 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.chbAntiAlias = New System.Windows.Forms.CheckBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chbThick = New System.Windows.Forms.CheckBox()
        Me.chbFilled = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.chbAntiAlias)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.chbThick)
        Me.panel1.Controls.Add(Me.chbFilled)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(656, 64)
        Me.panel1.TabIndex = 0
        '
        'chbAntiAlias
        '
        Me.chbAntiAlias.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chbAntiAlias.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.chbAntiAlias.Location = New System.Drawing.Point(270, 23)
        Me.chbAntiAlias.Name = "chbAntiAlias"
        Me.chbAntiAlias.Size = New System.Drawing.Size(72, 24)
        Me.chbAntiAlias.TabIndex = 3
        Me.chbAntiAlias.Text = "Anti Alias"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(41, 6)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(143, 50)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        '
        'chbThick
        '
        Me.chbThick.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chbThick.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.chbThick.Location = New System.Drawing.Point(358, 23)
        Me.chbThick.Name = "chbThick"
        Me.chbThick.Size = New System.Drawing.Size(72, 24)
        Me.chbThick.TabIndex = 1
        Me.chbThick.Text = "Thicker"
        '
        'chbFilled
        '
        Me.chbFilled.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.chbFilled.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.chbFilled.Location = New System.Drawing.Point(438, 23)
        Me.chbFilled.Name = "chbFilled"
        Me.chbFilled.Size = New System.Drawing.Size(64, 24)
        Me.chbFilled.TabIndex = 0
        Me.chbFilled.Text = "Filled"
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.button1.Location = New System.Drawing.Point(527, 22)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 24)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Visit Web Site"
        Me.button1.UseVisualStyleBackColor = False
        '
        'c1Chart1
        '
        Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Chart1.Location = New System.Drawing.Point(0, 64)
        Me.c1Chart1.Name = "c1Chart1"
        Me.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag")
        Me.c1Chart1.Size = New System.Drawing.Size(656, 382)
        Me.c1Chart1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 446)
        Me.Controls.Add(Me.c1Chart1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "ComponentOne Chart for .NET Demo - Interview"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent
    
#End Region
   '/ <summary>
   '/ The main entry point for the application.
   '/ </summary>
   <STAThread()>  _
   Shared    Sub Main()
      Application.Run(New Form1())
   End Sub 'Main
   
   
   '/ <summary>
   '/ Initialize the chart style
   '/ </summary>
   Private Sub InitChart()
      button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right 
      c1Chart1.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Radar
      
      c1Chart1.BackColor = Color.White
      
      ' Setup the header and footer
      c1Chart1.Header.Style.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
      c1Chart1.Header.Text = "Employment Candidate Review"
      c1Chart1.Footer.Visible = False
      
      ' Setup the legend
      c1Chart1.Legend.Compass = C1.Win.C1Chart.CompassEnum.South
      c1Chart1.Legend.Orientation = C1.Win.C1Chart.LegendOrientationEnum.Horizontal
      c1Chart1.Legend.Visible = True
      
      ' Setup the Axis X
      Dim ax As C1.Win.C1Chart.Axis = c1Chart1.ChartArea.AxisX
      ax.Font = New Font("Arial", 8)
      ax.Thickness = 2
      ax.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels
      ax.GridMajor.Color = Color.DarkGray
      ax.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid
      ax.GridMajor.Thickness = 2
      ax.GridMajor.Visible = True
      
      ' Setup the value labels
      Dim vlbl As C1.Win.C1Chart.ValueLabel = ax.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 1
      vlbl.Text = "Experience"
      
      vlbl = ax.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 2
      vlbl.Text = "Education"
      
      vlbl = ax.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 3
      vlbl.Text = "Communication"
      
      vlbl = ax.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 4
      vlbl.Text = "Friendliness"
      
      vlbl = ax.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 5
      vlbl.Text = "Presentation"
      
      vlbl = ax.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 6
      vlbl.Text = "Expression"
      
      ' Setup the Axis Y
      Dim ay As C1.Win.C1Chart.Axis = c1Chart1.ChartArea.AxisY
      ay.Min = 0
      ay.Max = 5
      ay.UnitMinor = 0
      ay.UnitMajor = 1
      ay.Compass = C1.Win.C1Chart.CompassEnum.North
      
      c1Chart1.UseAntiAliasedGraphics = True
   End Sub 'InitChart
   
   
   
   '/ <summary>
   '/ Setup the chart data
   '/ </summary>
   Private Sub SetupChartData()
      c1Chart1.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Radar
      Dim series As C1.Win.C1Chart.ChartDataSeriesCollection = c1Chart1.ChartGroups(0).ChartData.SeriesList
      series.RemoveAll()
      
      ' Fill the X array
      Dim x As Integer() = CType(Array.CreateInstance(GetType(Integer), 6), Integer())
      Dim i As Integer
      For i = 0 To x.Length - 1
         x(i) = i + 1
      Next i
      
      ' Add one series
      Dim s As C1.Win.C1Chart.ChartDataSeries = series.AddNewSeries()
      s.LineStyle.Color = Color.SeaGreen
      s.LineStyle.Thickness = 2
      s.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid
      s.SymbolStyle.Color = Color.FromArgb(90, Color.Lime)
      s.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Tri
      s.SymbolStyle.Size = 8
      s.Label = "Michael Johnson"
      s.Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      
      Dim y() As Integer = {5, 3, 4, 5, 4, 2}
      s.X.CopyDataIn(x)
      s.Y.CopyDataIn(y)
      
      ' Add one series
      s = series.AddNewSeries()
      s.LineStyle.Color = Color.Navy
      s.LineStyle.Thickness = 2
      s.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid
      s.SymbolStyle.Color = Color.FromArgb(90, Color.CornflowerBlue)
      s.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot
      s.SymbolStyle.Size = 8
      s.Label = "Jim Hubbard"
      s.Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      
      y = New Integer() {3, 5, 3, 4, 3, 4}
      s.X.CopyDataIn(x)
      s.Y.CopyDataIn(y)
      
      ' Add one series
      s = series.AddNewSeries()
      s.LineStyle.Color = Color.Chocolate
      s.LineStyle.Thickness = 2
      s.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Dot
      s.SymbolStyle.Color = Color.FromArgb(90, Color.Orange)
      s.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Diamond
      s.SymbolStyle.Size = 8
      s.Label = "Larry Richardson"
      s.Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      
      y = New Integer() {5, 3, 2, 3, 4, 4}
      s.X.CopyDataIn(x)
      s.Y.CopyDataIn(y)
   End Sub 'SetupChartData
   
   
   Private Sub chbFilled_CheckedChanged(sender As Object, e As System.EventArgs) Handles chbFilled.CheckedChanged
      c1Chart1.ChartGroups(0).Radar.Filled = chbFilled.Checked
      
      Dim s As C1.Win.C1Chart.ChartDataSeries
      For Each s In  c1Chart1.ChartGroups(0).ChartData.SeriesList
         If chbFilled.Checked Then
            s.LineStyle.Color = Color.FromArgb(90, s.LineStyle.Color)
         Else
            s.LineStyle.Color = Color.FromArgb(255, s.LineStyle.Color)
         End If
      Next s
   End Sub 'chbFilled_CheckedChanged
    
   Private Sub chbThick_CheckedChanged(sender As Object, e As System.EventArgs) Handles chbThick.CheckedChanged
      Dim s As C1.Win.C1Chart.ChartDataSeries
      For Each s In  c1Chart1.ChartGroups(0).ChartData.SeriesList
         If chbThick.Checked Then
            s.LineStyle.Thickness = 2
            s.SymbolStyle.Size = 8
         Else
            s.LineStyle.Thickness = 1
            s.SymbolStyle.Size = 5
         End If
      Next s
   End Sub 'chbThick_CheckedChanged
   
   
   Private Sub chbAntiAlias_CheckedChanged(sender As Object, e As System.EventArgs) Handles chbAntiAlias.CheckedChanged
      c1Chart1.UseAntiAliasedGraphics = chbAntiAlias.Checked
   End Sub 'chbAntiAlias_CheckedChanged
   
   
   Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
      System.Diagnostics.Process.Start("https://developer.mescius.com")
   End Sub 'button1_Click
End Class 'Form1
