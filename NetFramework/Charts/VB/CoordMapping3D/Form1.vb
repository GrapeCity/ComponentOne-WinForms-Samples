
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports C1.Win.C1Chart3D



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private xpixel, ypixel As Integer
   Private bMarker As Boolean = False
   Private pen As New Pen(Color.Red, 2)
   Private x As Single = 0
   Private y As Single = 0
   Private z As Single = 0
   Private nlabel As Integer = 0
   Private old_row As Integer = - 1
   Private old_col As Integer = - 1
   Private bCapture As Boolean = True
   
   WithEvents chart3D1 As C1.Win.C1Chart3D.C1Chart3D
   Private panel1 As System.Windows.Forms.Panel
   Private groupBox1 As System.Windows.Forms.GroupBox
   Private lblMouse As System.Windows.Forms.Label
   Private groupBox2 As System.Windows.Forms.GroupBox
   Private lblDataCoord As System.Windows.Forms.Label
   Private groupBox3 As System.Windows.Forms.GroupBox
   Private lblDataIndex As System.Windows.Forms.Label
   Private groupBox4 As System.Windows.Forms.GroupBox
   WithEvents rbSurface As System.Windows.Forms.RadioButton
   WithEvents rbScatter As System.Windows.Forms.RadioButton
   WithEvents rbBar As System.Windows.Forms.RadioButton
   Private groupBox5 As System.Windows.Forms.GroupBox
   WithEvents rbValues As System.Windows.Forms.RadioButton
   WithEvents rbValueLabels As System.Windows.Forms.RadioButton
   Private groupBox6 As System.Windows.Forms.GroupBox
   WithEvents upRotX As System.Windows.Forms.NumericUpDown
   WithEvents upRotZ As System.Windows.Forms.NumericUpDown
   Private groupBox7 As System.Windows.Forms.GroupBox
   Private statusBar1 As System.Windows.Forms.StatusBar
   Private statusBarPanel1 As System.Windows.Forms.StatusBarPanel
   Private groupBox8 As System.Windows.Forms.GroupBox
   WithEvents cbLabel As System.Windows.Forms.CheckBox
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   WithEvents btnSetData As System.Windows.Forms.Button
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
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
   Protected Overloads Overrides Sub Dispose(disposing As Boolean) 
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub 'Dispose
   
   
   Sub updateChartType()
      bMarker = False
      If rbBar.Checked Then
         chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Bar
      ElseIf rbScatter.Checked Then
         chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Scatter
      Else
         chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Surface
      End If
   End Sub 'updateChartType
    
   Sub toggleValueLabels(show As Boolean)
      If show Then
         Dim axis As C1.Win.C1Chart3D.Chart3DAxis
         For Each axis In  chart3D1.ChartArea.Axes
            Dim val As Single
            If axis.Equals(chart3D1.ChartArea.AxisX) Then
               val = x
            ElseIf axis.Equals(chart3D1.ChartArea.AxisY) Then
               val = y
            Else
               val = z
            End If 
            If axis.ValueLabels.Count < nlabel + 1 Then
               axis.ValueLabels.Add(val, val.ToString())
            Else
               axis.ValueLabels(nlabel).Value = val
               axis.ValueLabels(nlabel).Text = val.ToString()
            End If
            axis.AnnoMethod = C1.Win.C1Chart3D.AnnotationMethodEnum.ValueLabels
            
            axis.MajorGrid.Style.Color = Color.Red
         Next axis
         
         Me.statusBarPanel1.Text = "Left click to save current axis labels position. Right click to clear all labels"
         bCapture = True
      Else
         Dim axis As C1.Win.C1Chart3D.Chart3DAxis
         For Each axis In  chart3D1.ChartArea.Axes
            axis.AnnoMethod = C1.Win.C1Chart3D.AnnotationMethodEnum.Values
            axis.MajorGrid.Style.Color = Color.Black
         Next axis
         statusBarPanel1.Text = "Move mouse over chart to see coordinates mapping results on the left panel.Click on chart to toggle mouse capture"
      End If
   End Sub 'toggleValueLabels
   
   
   Sub updateMarkerPosition()
      bMarker = False
      If chart3D1.ChartGroups(0).ChartType <> Chart3DTypeEnum.Bar Then
         If chart3D1.ChartGroups(0).ChartData.DataCoordToCoord(x, y, z, xpixel, ypixel) Then
            bMarker = True
         End If
      End If
   End Sub 'updateMarkerPosition
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Me.chart3D1 = New C1.Win.C1Chart3D.C1Chart3D()
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.btnSetData = New System.Windows.Forms.Button()
      Me.groupBox5 = New System.Windows.Forms.GroupBox()
      rbValueLabels = New System.Windows.Forms.RadioButton()
      rbValues = New System.Windows.Forms.RadioButton()
      Me.groupBox8 = New System.Windows.Forms.GroupBox()
      Me.cbLabel = New System.Windows.Forms.CheckBox()
      Me.groupBox7 = New System.Windows.Forms.GroupBox()
      Me.upRotZ = New System.Windows.Forms.NumericUpDown()
      Me.groupBox6 = New System.Windows.Forms.GroupBox()
      Me.upRotX = New System.Windows.Forms.NumericUpDown()
      Me.groupBox3 = New System.Windows.Forms.GroupBox()
      Me.lblDataIndex = New System.Windows.Forms.Label()
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      Me.lblMouse = New System.Windows.Forms.Label()
      Me.groupBox2 = New System.Windows.Forms.GroupBox()
      Me.lblDataCoord = New System.Windows.Forms.Label()
      Me.groupBox4 = New System.Windows.Forms.GroupBox()
      rbSurface = New System.Windows.Forms.RadioButton()
      rbScatter = New System.Windows.Forms.RadioButton()
      rbBar = New System.Windows.Forms.RadioButton()
      Me.statusBar1 = New System.Windows.Forms.StatusBar()
      Me.statusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      CType(Me.chart3D1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panel1.SuspendLayout()
      Me.groupBox5.SuspendLayout()
      Me.groupBox8.SuspendLayout()
      Me.groupBox7.SuspendLayout()
      CType(Me.upRotZ, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.groupBox6.SuspendLayout()
      CType(Me.upRotX, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.groupBox3.SuspendLayout()
      Me.groupBox1.SuspendLayout()
      Me.groupBox2.SuspendLayout()
      Me.groupBox4.SuspendLayout()
      CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' chart3D1
      ' 
      Me.chart3D1.BackColor = System.Drawing.SystemColors.Control
      Me.chart3D1.Location = New System.Drawing.Point(168, 0)
      Me.chart3D1.Name = "chart3D1"
      Me.chart3D1.PropBag = "<?xml version=""1.0""?><Chart3DPropBag Version=""""><ChartStyles><Chart3DStyle><Symbo" + "lStyle Color=""Blue"" Shape=""Diamond"" Size=""5"" /><LineStyle Color=""Black"" Thicknes" + "s=""0"" Pattern=""Solid"" /></Chart3DStyle></ChartStyles><LegendData WV=""Auto"" Compa" + "ss=""East"" /><ChartGroupsCollection><Chart3DGroup><ChartData><Set type=""Chart3DDa" + "taSetGrid"" RowDelta=""1"" RowCount=""11"" ColumnCount=""11"" ColumnDelta=""1"" ColumnOri" + "gin=""0"" RowOrigin=""0"" Hole=""3.40282347E+38""><Data>4.5 3.6 2.89999986 2.39999986 " + "2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4.5 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5" + " 7.2 8.1 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 12.9 12 11.3 10.8 10.5 10.4" + " 10.5 10.8 11.3 12 12.9 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 14.5 " + "13.6 12.9 12.4 12.1 12 12.1 12.4 12.9 13.6 14.5 14.1 13.2 12.5 12 11.7 11.6 11.7" + " 12 12.5 13.2 14.1 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 10.9 10 9." + "3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3." + "6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4.5</Data><" + "/Set></ChartData><Elevation ShadedBottomColor=""Gray"" ShadedTopColor=""Gainsboro"" " + "Transparency=""190"" /><Bar Origin=""0"" ColumnWidth=""60"" RowWidth=""60"" /></Chart3DG" + "roup></ChartGroupsCollection><AxisX GridY=""True"" GridZ=""True"" Text=""X - axis"" />" + "<AxisY GridX=""True"" GridZ=""True"" Text=""Y - axis"" /><AxisZ GridY=""True"" GridX=""Tr" + "ue"" AutoMajor=""False"" UnitMajor=""2"" AnnoRotated=""True"" Text=""Z - axis"" /><StyleC" + "ollection><NamedStyle ParentName=""Legend.default"" Name=""Legend"" /><NamedStyle Pa" + "rentName=""Control"" Name=""Footer"" /><NamedStyle ParentName=""Area.default"" Name=""A" + "rea"" StyleData=""Border=Empty,ControlText,1;BackColor=Control;"" /><NamedStyle Par" + "entName=""Control.default"" Name=""Control"" StyleData=""Border=Solid,Black,1;BackCol" + "or=Control;"" /><NamedStyle ParentName=""Control"" Name=""LabelStyleDefault"" StyleDa" + "ta=""ForeColor=ControlText;BackColor=White;"" /><NamedStyle ParentName=""Control"" N" + "ame=""Legend.default"" StyleData=""Wrap=False;AlignVert=Top;"" /><NamedStyle ParentN" + "ame=""Control"" Name=""Header"" /><NamedStyle ParentName="""" Name=""Control.default"" S" + "tyleData=""ForeColor=ControlText;BackColor=Control;"" /><NamedStyle ParentName=""Co" + "ntrol"" Name=""Area.default"" StyleData=""AlignVert=Top;"" /></StyleCollection><Foote" + "rData Compass=""South"" /><HeaderData Compass=""North"" /><View RotationX=""74"" BackC" + "olor=""OldLace"" AxisTitleFont=""Microsoft Sans Serif, 10world"" /></Chart3DPropBag>" + ""

      Me.chart3D1.Size = New System.Drawing.Size(424, 376)
      Me.chart3D1.TabIndex = 0
      ' 
      ' panel1
      ' 
      Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSetData, Me.groupBox5, Me.groupBox8, Me.groupBox7, Me.groupBox6, Me.groupBox3, Me.groupBox1, Me.groupBox2, Me.groupBox4})
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(168, 376)
      Me.panel1.TabIndex = 2
      ' 
      ' btnSetData
      ' 
      Me.btnSetData.Enabled = False
      Me.btnSetData.Location = New System.Drawing.Point(8, 300)
      Me.btnSetData.Name = "btnSetData"
      Me.btnSetData.Size = New System.Drawing.Size(88, 20)
      Me.btnSetData.TabIndex = 10
      Me.btnSetData.Text = "Set Z-value ..."
      ' 
      ' groupBox5
      ' 
      Me.groupBox5.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbValueLabels, rbValues})
      Me.groupBox5.Location = New System.Drawing.Point(8, 96)
      Me.groupBox5.Name = "groupBox5"
      Me.groupBox5.Size = New System.Drawing.Size(78, 80)
      Me.groupBox5.TabIndex = 5
      Me.groupBox5.TabStop = False
      Me.groupBox5.Text = "Axis anno"
      ' 
      ' rbValueLabels
      ' 
      rbValueLabels.Location = New System.Drawing.Point(8, 40)
      rbValueLabels.Name = "rbValueLabels"
      rbValueLabels.Size = New System.Drawing.Size(64, 32)
      rbValueLabels.TabIndex = 1
      rbValueLabels.Text = "Value Labels"
      ' 
      ' rbValues
      ' 
      rbValues.Location = New System.Drawing.Point(8, 20)
      rbValues.Name = "rbValues"
      rbValues.Size = New System.Drawing.Size(56, 16)
      rbValues.TabIndex = 0
      rbValues.Text = "Values"
      ' 
      ' groupBox8
      ' 
      Me.groupBox8.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbLabel})
      Me.groupBox8.Location = New System.Drawing.Point(88, 96)
      Me.groupBox8.Name = "groupBox8"
      Me.groupBox8.Size = New System.Drawing.Size(72, 80)
      Me.groupBox8.TabIndex = 9
      Me.groupBox8.TabStop = False
      Me.groupBox8.Text = "Label"
      ' 
      ' cbLabel
      ' 
      Me.cbLabel.Location = New System.Drawing.Point(4, 16)
      Me.cbLabel.Name = "cbLabel"
      Me.cbLabel.Size = New System.Drawing.Size(52, 16)
      Me.cbLabel.TabIndex = 0
      Me.cbLabel.Text = "Show"
      ' 
      ' groupBox7
      ' 
      Me.groupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.upRotZ})
      Me.groupBox7.Location = New System.Drawing.Point(88, 52)
      Me.groupBox7.Name = "groupBox7"
      Me.groupBox7.Size = New System.Drawing.Size(72, 44)
      Me.groupBox7.TabIndex = 8
      Me.groupBox7.TabStop = False
      Me.groupBox7.Text = "RotationZ"
      ' 
      ' upRotZ
      ' 
      Me.upRotZ.Increment = New System.Decimal(New Integer() {5, 0, 0, 0})
      Me.upRotZ.Location = New System.Drawing.Point(12, 16)
      Me.upRotZ.Maximum = New System.Decimal(New Integer() {360, 0, 0, 0})
      Me.upRotZ.Name = "upRotZ"
      Me.upRotZ.Size = New System.Drawing.Size(48, 20)
      Me.upRotZ.TabIndex = 7
      ' 
      ' groupBox6
      ' 
      Me.groupBox6.Controls.AddRange(New System.Windows.Forms.Control() {Me.upRotX})
      Me.groupBox6.Location = New System.Drawing.Point(88, 8)
      Me.groupBox6.Name = "groupBox6"
      Me.groupBox6.Size = New System.Drawing.Size(72, 44)
      Me.groupBox6.TabIndex = 6
      Me.groupBox6.TabStop = False
      Me.groupBox6.Text = "RotationX"
      ' 
      ' upRotX
      ' 
      Me.upRotX.Increment = New System.Decimal(New Integer() {5, 0, 0, 0})
      Me.upRotX.Location = New System.Drawing.Point(12, 16)
      Me.upRotX.Maximum = New System.Decimal(New Integer() {360, 0, 0, 0})
      Me.upRotX.Name = "upRotX"
      Me.upRotX.Size = New System.Drawing.Size(48, 20)
      Me.upRotX.TabIndex = 0
      ' 
      ' groupBox3
      ' 
      Me.groupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDataIndex})
      Me.groupBox3.Location = New System.Drawing.Point(8, 256)
      Me.groupBox3.Name = "groupBox3"
      Me.groupBox3.Size = New System.Drawing.Size(152, 40)
      Me.groupBox3.TabIndex = 4
      Me.groupBox3.TabStop = False
      Me.groupBox3.Text = "Data index"
      ' 
      ' lblDataIndex
      ' 
      Me.lblDataIndex.Location = New System.Drawing.Point(8, 16)
      Me.lblDataIndex.Name = "lblDataIndex"
      Me.lblDataIndex.Size = New System.Drawing.Size(136, 16)
      Me.lblDataIndex.TabIndex = 4
      ' 
      ' groupBox1
      ' 
      Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblMouse})
      Me.groupBox1.Location = New System.Drawing.Point(8, 176)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(152, 40)
      Me.groupBox1.TabIndex = 3
      Me.groupBox1.TabStop = False
      Me.groupBox1.Text = "Mouse"
      ' 
      ' lblMouse
      ' 
      Me.lblMouse.Location = New System.Drawing.Point(8, 16)
      Me.lblMouse.Name = "lblMouse"
      Me.lblMouse.Size = New System.Drawing.Size(136, 16)
      Me.lblMouse.TabIndex = 3
      ' 
      ' groupBox2
      ' 
      Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDataCoord})
      Me.groupBox2.Location = New System.Drawing.Point(8, 216)
      Me.groupBox2.Name = "groupBox2"
      Me.groupBox2.Size = New System.Drawing.Size(152, 40)
      Me.groupBox2.TabIndex = 3
      Me.groupBox2.TabStop = False
      Me.groupBox2.Text = "Data coordinates"
      ' 
      ' lblDataCoord
      ' 
      Me.lblDataCoord.Location = New System.Drawing.Point(8, 16)
      Me.lblDataCoord.Name = "lblDataCoord"
      Me.lblDataCoord.Size = New System.Drawing.Size(136, 16)
      Me.lblDataCoord.TabIndex = 4
      ' 
      ' groupBox4
      ' 
      Me.groupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbSurface, rbScatter, rbBar})
      Me.groupBox4.Location = New System.Drawing.Point(8, 8)
      Me.groupBox4.Name = "groupBox4"
      Me.groupBox4.Size = New System.Drawing.Size(78, 88)
      Me.groupBox4.TabIndex = 3
      Me.groupBox4.TabStop = False
      Me.groupBox4.Text = "Chart Type"
      ' 
      ' rbSurface
      ' 
      rbSurface.Location = New System.Drawing.Point(8, 64)
      rbSurface.Name = "rbSurface"
      rbSurface.Size = New System.Drawing.Size(64, 16)
      rbSurface.TabIndex = 5
      rbSurface.Text = "Surface"
      ' 
      ' rbScatter
      ' 
      rbScatter.Location = New System.Drawing.Point(8, 40)
      rbScatter.Name = "rbScatter"
      rbScatter.Size = New System.Drawing.Size(64, 16)
      rbScatter.TabIndex = 4
      rbScatter.Text = "Scatter"
      ' 
      ' rbBar
      ' 
      rbBar.Location = New System.Drawing.Point(8, 16)
      rbBar.Name = "rbBar"
      rbBar.Size = New System.Drawing.Size(56, 16)
      rbBar.TabIndex = 3
      rbBar.Text = "Bar"
      ' 
      ' statusBar1
      ' 
      Me.statusBar1.Location = New System.Drawing.Point(0, 379)
      Me.statusBar1.Name = "statusBar1"
      Me.statusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statusBarPanel1})
      Me.statusBar1.ShowPanels = True
      Me.statusBar1.Size = New System.Drawing.Size(592, 24)
      Me.statusBar1.TabIndex = 3
      Me.statusBar1.Text = "statusBar1"
      ' 
      ' statusBarPanel1
      ' 
      Me.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
      Me.statusBarPanel1.Text = "Move mouse over chart."
      Me.statusBarPanel1.Width = 576
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem3})
      ' 
      ' menuItem1
      ' 
      Me.menuItem1.Index = 0
      Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileExit})
      Me.menuItem1.Text = "&File"
      ' 
      ' menuFileExit
      ' 
      Me.menuFileExit.Index = 0
      Me.menuFileExit.Text = "E&xit"
      ' 
      ' menuItem3
      ' 
      Me.menuItem3.Index = 1
      Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      Me.menuItem3.Text = "&Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 0
      Me.menuHelpAbout.Text = "About"
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 403)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.statusBar1, Me.panel1, Me.chart3D1})
      Me.Menu = Me.mainMenu1
      Me.MinimumSize = New System.Drawing.Size(400, 396)
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 3D - CoordMapping Demo"
      CType(Me.chart3D1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panel1.ResumeLayout(False)
      Me.groupBox5.ResumeLayout(False)
      Me.groupBox8.ResumeLayout(False)
      Me.groupBox7.ResumeLayout(False)
      CType(Me.upRotZ, System.ComponentModel.ISupportInitialize).EndInit()
      Me.groupBox6.ResumeLayout(False)
      CType(Me.upRotX, System.ComponentModel.ISupportInitialize).EndInit()
      Me.groupBox3.ResumeLayout(False)
      Me.groupBox1.ResumeLayout(False)
      Me.groupBox2.ResumeLayout(False)
      Me.groupBox4.ResumeLayout(False)
      CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
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
   
   
   Private Sub chart3D1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles chart3D1.MouseMove
      If Not bCapture Then
         Return
      End If 
      lblMouse.Text = [String].Format("X={0}; Y={1}", e.X, e.Y)
      
      Dim _x As Single = 0
      Dim _y As Single = 0
      Dim _z As Single = 0
      If chart3D1.ChartGroups(0).ChartData.CoordToDataCoord(e.X, e.Y, _x, _y, _z) Then
         If _x <> x OrElse _y <> y OrElse _z <> z Then
            x = _x
            y = _y
            z = _z
            lblDataCoord.Text = [String].Format("X={0}; Y={1}; Z={2}", x, y, z)
            If rbValueLabels.Checked Then
               toggleValueLabels(True)
            End If
         Else
            Return
         End If
      Else
      End If 'lblDataCoord.Text = " Not in data range";
      
      Dim row As Integer = 0
      Dim col As Integer = 0
      If chart3D1.ChartGroups(0).ChartData.CoordToDataIndex(e.X, e.Y, col, row) Then
         lblDataIndex.Text = [String].Format("Col={0}; Row={1}", col, row)
         
         chart3D1.ChartLabels(0).AttachMethodData.Column = col
         chart3D1.ChartLabels(0).AttachMethodData.Row = row
         
         If chart3D1.ChartGroups(0).ChartType = Chart3DTypeEnum.Bar Then
            If old_col <> - 1 AndAlso old_row <> - 1 Then
               chart3D1.ChartGroups(0).Bar.SetBarColor(old_col, old_row, Color.White)
            End If
            chart3D1.ChartGroups(0).Bar.SetBarColor(col, row, Color.Red)
         End If
         old_row = row
         old_col = col
         btnSetData.Enabled = True
      Else
      End If 'lblDataIndex.Text = " Not in data range";
   End Sub 'chart3D1_MouseMove
   
   
   Private Sub chart3D1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles chart3D1.Paint
      updateMarkerPosition()
      If bMarker Then
         e.Graphics.DrawEllipse(pen, xpixel - 5, ypixel - 5, 10, 10)
      End If
   End Sub 'chart3D1_Paint
    
   Private Sub rbChartType_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbSurface.CheckedChanged, rbScatter.CheckedChanged, rbBar.CheckedChanged
      updateChartType()
   End Sub 'rbChartType_CheckedChanged
   
   
   Private Sub rbValueLabels_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbValueLabels.CheckedChanged
      toggleValueLabels(rbValueLabels.Checked)
   End Sub 'rbValueLabels_CheckedChanged
   
   
   Private Sub rbValues_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbValues.CheckedChanged
      toggleValueLabels(rbValueLabels.Checked)
   End Sub 'rbValues_CheckedChanged
   
   
   Private Sub chart3D1_Load(sender As Object, e As System.EventArgs) Handles chart3D1.Load
      rbValues.Checked = True
      rbSurface.Checked = True
      upRotX.Value = chart3D1.ChartArea.View.RotationX
      upRotZ.Value = chart3D1.ChartArea.View.RotationZ
      
      chart3D1.ChartLabels.AddNewLabel()
      chart3D1.ChartLabels(0).Text = "Selected" + ControlChars.Lf + "Data Point"
      chart3D1.ChartLabels(0).AttachMethod = C1.Win.C1Chart3D.AttachMethodEnum.DataIndex
      chart3D1.ChartLabels(0).Connected = True
      chart3D1.ChartLabels(0).Offset = 25
      chart3D1.ChartLabels(0).LabelCompass = C1.Win.C1Chart3D.LabelCompassEnum.NorthEast
      chart3D1.ChartLabels(0).Style.BackColor = Color.LightSalmon
      chart3D1.ChartGroups(0).Bar.SetBarColor(- 1, - 1, Color.White)
      
      chart3D1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left 
   End Sub 'chart3D1_Load
   
   
   Private Sub chart3D1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles chart3D1.MouseDown
      If rbValueLabels.Checked Then
         If e.Button = MouseButtons.Left Then
            nlabel += 1
         Else
            Dim axis As C1.Win.C1Chart3D.Chart3DAxis
            For Each axis In  chart3D1.ChartArea.Axes
               axis.ValueLabels.Clear()
            Next axis
            nlabel = 0
            chart3D1.Invalidate()
         End If
      Else
         bCapture = Not bCapture
      End If
   End Sub 'chart3D1_MouseDown
    
   Private Sub upRotX_ValueChanged(sender As Object, e As System.EventArgs) Handles upRotX.ValueChanged
      chart3D1.ChartArea.View.RotationX = CInt(upRotX.Value)
   End Sub 'upRotX_ValueChanged
   
   
   Private Sub upRotZ_ValueChanged(sender As Object, e As System.EventArgs) Handles upRotZ.ValueChanged
      chart3D1.ChartArea.View.RotationZ = CInt(upRotZ.Value)
   End Sub 'upRotZ_ValueChanged
   
   
   Private Sub cbLabel_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbLabel.CheckedChanged
      chart3D1.ChartLabels(0).Visible = cbLabel.Checked
   End Sub 'cbLabel_CheckedChanged
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub btnSetData_Click(sender As Object, e As System.EventArgs) Handles btnSetData.Click
      If old_col <> - 1 AndAlso old_row <> - 1 Then
         Dim frm As New InputValueForm()
         frm.ZValue = chart3D1.ChartGroups(0).ChartData.SetGrid(old_col, old_row)
         frm.Hole = chart3D1.ChartGroups(0).ChartData.SetGrid.Hole
         If frm.ShowDialog(Me) = DialogResult.OK Then
            chart3D1.ChartGroups(0).ChartData.SetGrid(old_col, old_row) = frm.ZValue
            If z <> frm.Hole Then
               z = CSng(frm.ZValue)
            End If
         End If
      End If
   End Sub 'btnSetData_Click
    
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
End Class 'Form1
