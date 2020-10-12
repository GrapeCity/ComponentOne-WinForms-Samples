
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Xml.Serialization
Imports System.Reflection



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem2 As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   Private tabControl1 As System.Windows.Forms.TabControl
   Private tabPage1 As System.Windows.Forms.TabPage
   WithEvents tbFuncText As System.Windows.Forms.TextBox
   Private components As System.ComponentModel.IContainer
   Private pnlFuncEditor As System.Windows.Forms.Panel
   WithEvents menuItem5 As System.Windows.Forms.MenuItem
   Private splitter1 As System.Windows.Forms.Splitter
   Private tabPage2 As System.Windows.Forms.TabPage
   Private label1 As System.Windows.Forms.Label
   Private groupBox1 As System.Windows.Forms.GroupBox
   Private label2 As System.Windows.Forms.Label
   Private label3 As System.Windows.Forms.Label
   Private label4 As System.Windows.Forms.Label
   Private groupBox2 As System.Windows.Forms.GroupBox
   Private label5 As System.Windows.Forms.Label
   Private label6 As System.Windows.Forms.Label
   Private label7 As System.Windows.Forms.Label
   Private udNx As System.Windows.Forms.NumericUpDown
   WithEvents tbMinX As System.Windows.Forms.TextBox
   WithEvents tbMaxX As System.Windows.Forms.TextBox
   WithEvents tbMaxY As System.Windows.Forms.TextBox
   WithEvents tbMinY As System.Windows.Forms.TextBox
   Private udNy As System.Windows.Forms.NumericUpDown
   WithEvents btnSave As System.Windows.Forms.Button
   
   '
   Private eng As New Engine()
   Private _range As New Range()
   WithEvents cbFList As System.Windows.Forms.ComboBox
   WithEvents btnGenerate As System.Windows.Forms.Button
   WithEvents tbErrors As System.Windows.Forms.TextBox
   Private sbChart As System.Windows.Forms.StatusBar
   Private sbpChart As System.Windows.Forms.StatusBarPanel
   Private sbpC1 As System.Windows.Forms.StatusBarPanel
   Private cmChartType As System.Windows.Forms.ContextMenu
   WithEvents menuItem12 As System.Windows.Forms.MenuItem
   WithEvents menuItem13 As System.Windows.Forms.MenuItem
   Private imageList1 As System.Windows.Forms.ImageList
   Private c1Chart3D1 As C1.Win.C1Chart3D.C1Chart3D
   Private toolBarButton1 As System.Windows.Forms.ToolBarButton
   Private toolBarButton2 As System.Windows.Forms.ToolBarButton
   Private toolBarButton3 As System.Windows.Forms.ToolBarButton
   Private toolBarButton4 As System.Windows.Forms.ToolBarButton
   Private toolBarButton5 As System.Windows.Forms.ToolBarButton
   Private toolBarButton6 As System.Windows.Forms.ToolBarButton
   Private toolBarButton7 As System.Windows.Forms.ToolBarButton
   Private toolBarButton8 As System.Windows.Forms.ToolBarButton
   WithEvents tlbChart As System.Windows.Forms.ToolBar
   Private fcoll As New FunctionInfoCollection()
   
   Private rot_inc As Integer = 5
   Private rotx, rotz As Integer
   Private toolBarButton10 As System.Windows.Forms.ToolBarButton
   WithEvents menuItem14 As System.Windows.Forms.MenuItem
   Private cmView As System.Windows.Forms.ContextMenu
   WithEvents menuItem11 As System.Windows.Forms.MenuItem
   WithEvents menuItem15 As System.Windows.Forms.MenuItem
   WithEvents menuItem16 As System.Windows.Forms.MenuItem
   WithEvents menuItem17 As System.Windows.Forms.MenuItem
   Private toolBarButton11 As System.Windows.Forms.ToolBarButton
   WithEvents menuItem18 As System.Windows.Forms.MenuItem
   Private toolBarButton12 As System.Windows.Forms.ToolBarButton
   Private cmContour As System.Windows.Forms.ContextMenu
   WithEvents menuItem19 As System.Windows.Forms.MenuItem
   WithEvents menuItem20 As System.Windows.Forms.MenuItem
   WithEvents menuItem21 As System.Windows.Forms.MenuItem
   WithEvents menuItem22 As System.Windows.Forms.MenuItem
   WithEvents menuItem23 As System.Windows.Forms.MenuItem
   Private cmNCont As System.Windows.Forms.ContextMenu
   WithEvents menuItem24 As System.Windows.Forms.MenuItem
   WithEvents menuItem25 As System.Windows.Forms.MenuItem
   WithEvents menuItem26 As System.Windows.Forms.MenuItem
   WithEvents menuItem27 As System.Windows.Forms.MenuItem
   WithEvents menuItem28 As System.Windows.Forms.MenuItem
   WithEvents menuItem29 As System.Windows.Forms.MenuItem
   WithEvents menuItem30 As System.Windows.Forms.MenuItem
   WithEvents menuItem31 As System.Windows.Forms.MenuItem
   WithEvents menuItem32 As System.Windows.Forms.MenuItem
   Private toolBarButton13 As System.Windows.Forms.ToolBarButton
   Private toolBarButton14 As System.Windows.Forms.ToolBarButton
   WithEvents menuItem33 As System.Windows.Forms.MenuItem
   WithEvents menuItem34 As System.Windows.Forms.MenuItem
   WithEvents menuItem35 As System.Windows.Forms.MenuItem
   WithEvents menuItem36 As System.Windows.Forms.MenuItem
   WithEvents menuItem37 As System.Windows.Forms.MenuItem
   WithEvents menuItem38 As System.Windows.Forms.MenuItem
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   Private toolBarButton9 As System.Windows.Forms.ToolBarButton
   
   
   Property Range() As Range
      Get
         updateRange(True)
         Return _range
      End Get
      Set
         _range = value
         updateRange(False)
      End Set
   End Property
   
   
   Sub updateRange(dir As Boolean)
      If dir Then
         _range.MinX = Single.Parse(tbMinX.Text)
         _range.MinY = Single.Parse(tbMinY.Text)
         _range.MaxX = Single.Parse(tbMaxX.Text)
         _range.MaxY = Single.Parse(tbMaxY.Text)
         _range.NumX = CInt(udNx.Value)
         _range.NumY = CInt(udNy.Value)
      Else
         tbMinX.Text = _range.MinX.ToString()
         tbMinY.Text = _range.MinY.ToString()
         tbMaxX.Text = _range.MaxX.ToString()
         tbMaxY.Text = _range.MaxY.ToString()
         udNx.Value = _range.NumX
         udNy.Value = _range.NumY
      End If
   End Sub 'updateRange
   
   
   Sub updateFList(sel As Integer)
      cbFList.Items.Clear()
      Dim i As Integer
      For i = 0 To fcoll.Count - 1
         cbFList.Items.Add(fcoll(i).Name)
      Next i
      cbFList.SelectedIndex = sel
   End Sub 'updateFList
   
   
   Sub setZoneChart(clrset As C1.Win.C1Chart3D.ColorSetEnum)
      If Not c1Chart3D1.ChartGroups(0).Contour.IsZoned Then
         c1Chart3D1.ChartGroups(0).Contour.IsZoned = True
      End If
      c1Chart3D1.ChartGroups.ContourStyles.ColorSet = clrset
   End Sub 'setZoneChart
   
   
   Sub setZoneNumber(n As Integer)
      If Not c1Chart3D1.ChartGroups(0).Contour.IsZoned Then
         c1Chart3D1.ChartGroups(0).Contour.IsZoned = True
         selectNext(cmContour)
      End If
      c1Chart3D1.ChartGroups(0).Contour.NumLevels = n
   End Sub 'setZoneNumber
   
   
   Sub loadFList()
      Dim fic As FunctionInfoCollection = Nothing
      Dim reader As TextReader = Nothing
      Dim x As New XmlSerializer(GetType(FunctionInfoCollection))
      
      Try
         reader = New StreamReader(getConfigFileName())
         fic = CType(x.Deserialize(reader), FunctionInfoCollection)
         reader.Close()
      Catch
      Finally
         If Not (reader Is Nothing) Then
            reader.Close()
         End If
      End Try 
      Dim res As String = String.Empty
      If fic Is Nothing OrElse fic.Count = 0 Then
         Dim resources As New System.Resources.ResourceManager("Function3D.Config", [Assembly].GetAssembly(GetType(Form1)))
         res = resources.GetString("Config")
         If res.Length > 0 Then
            reader = New StringReader(res)
            fic = CType(x.Deserialize(reader), FunctionInfoCollection)
         End If
      End If
      
      If Not (fic Is Nothing) Then
         fcoll = fic
         updateFList(0)
      End If
   End Sub 'loadFList
   
   
   Function getConfigFileName() As String
      'return config_dir + "\\" + 
      Return [Assembly].GetExecutingAssembly().GetName().Name + ".config"
   End Function 'getConfigFileName
   
   
   Sub selectNext(cm As System.Windows.Forms.ContextMenu)
      Dim sel As Integer = 0
      Dim i As Integer
      For i = 0 To cm.MenuItems.Count - 1
         If cm.MenuItems(i).Checked Then
            sel = i
            Exit For
         End If
      Next i
      
      If sel >= cm.MenuItems.Count - 1 Then
         sel = 0
      Else
         sel += 1
      End If 
      If cm.MenuItems(sel).Text.Equals("-") Then
         If sel >= cm.MenuItems.Count - 1 Then
            sel = 0
         Else
            sel += 1
         End If
      End If 
      cm.MenuItems(sel).PerformClick()
   End Sub 'selectNext
   
   
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
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As New System.Resources.ResourceManager(GetType(Form1))
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      menuItem2 = New System.Windows.Forms.MenuItem()
      menuItem5 = New System.Windows.Forms.MenuItem()
      menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.pnlFuncEditor = New System.Windows.Forms.Panel()
      Me.cbFList = New System.Windows.Forms.ComboBox()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.label1 = New System.Windows.Forms.Label()
      Me.tabControl1 = New System.Windows.Forms.TabControl()
      Me.tabPage1 = New System.Windows.Forms.TabPage()
      tbErrors = New System.Windows.Forms.TextBox()
      tbFuncText = New System.Windows.Forms.TextBox()
      Me.tabPage2 = New System.Windows.Forms.TabPage()
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      tbMaxX = New System.Windows.Forms.TextBox()
      tbMinX = New System.Windows.Forms.TextBox()
      Me.udNx = New System.Windows.Forms.NumericUpDown()
      Me.label4 = New System.Windows.Forms.Label()
      Me.label3 = New System.Windows.Forms.Label()
      Me.label2 = New System.Windows.Forms.Label()
      Me.groupBox2 = New System.Windows.Forms.GroupBox()
      tbMaxY = New System.Windows.Forms.TextBox()
      tbMinY = New System.Windows.Forms.TextBox()
      Me.udNy = New System.Windows.Forms.NumericUpDown()
      Me.label5 = New System.Windows.Forms.Label()
      Me.label6 = New System.Windows.Forms.Label()
      Me.label7 = New System.Windows.Forms.Label()
      Me.btnGenerate = New System.Windows.Forms.Button()
      Me.splitter1 = New System.Windows.Forms.Splitter()
      Me.sbChart = New System.Windows.Forms.StatusBar()
      Me.sbpChart = New System.Windows.Forms.StatusBarPanel()
      Me.sbpC1 = New System.Windows.Forms.StatusBarPanel()
      Me.tlbChart = New System.Windows.Forms.ToolBar()
      Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton()
      Me.cmChartType = New System.Windows.Forms.ContextMenu()
      menuItem14 = New System.Windows.Forms.MenuItem()
      menuItem12 = New System.Windows.Forms.MenuItem()
      menuItem13 = New System.Windows.Forms.MenuItem()
      Me.toolBarButton11 = New System.Windows.Forms.ToolBarButton()
      Me.cmView = New System.Windows.Forms.ContextMenu()
      menuItem11 = New System.Windows.Forms.MenuItem()
      menuItem18 = New System.Windows.Forms.MenuItem()
      menuItem15 = New System.Windows.Forms.MenuItem()
      menuItem16 = New System.Windows.Forms.MenuItem()
      menuItem17 = New System.Windows.Forms.MenuItem()
      Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton7 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton8 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton9 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton10 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton14 = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton12 = New System.Windows.Forms.ToolBarButton()
      Me.cmContour = New System.Windows.Forms.ContextMenu()
      menuItem19 = New System.Windows.Forms.MenuItem()
      menuItem20 = New System.Windows.Forms.MenuItem()
      menuItem21 = New System.Windows.Forms.MenuItem()
      menuItem22 = New System.Windows.Forms.MenuItem()
      menuItem23 = New System.Windows.Forms.MenuItem()
      menuItem33 = New System.Windows.Forms.MenuItem()
      menuItem34 = New System.Windows.Forms.MenuItem()
      menuItem35 = New System.Windows.Forms.MenuItem()
      menuItem36 = New System.Windows.Forms.MenuItem()
      menuItem37 = New System.Windows.Forms.MenuItem()
      menuItem38 = New System.Windows.Forms.MenuItem()
      Me.toolBarButton13 = New System.Windows.Forms.ToolBarButton()
      Me.cmNCont = New System.Windows.Forms.ContextMenu()
      menuItem24 = New System.Windows.Forms.MenuItem()
      menuItem25 = New System.Windows.Forms.MenuItem()
      menuItem26 = New System.Windows.Forms.MenuItem()
      menuItem27 = New System.Windows.Forms.MenuItem()
      menuItem28 = New System.Windows.Forms.MenuItem()
      menuItem29 = New System.Windows.Forms.MenuItem()
      menuItem30 = New System.Windows.Forms.MenuItem()
      menuItem31 = New System.Windows.Forms.MenuItem()
      menuItem32 = New System.Windows.Forms.MenuItem()
      Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
      Me.c1Chart3D1 = New C1.Win.C1Chart3D.C1Chart3D()
      Me.pnlFuncEditor.SuspendLayout()
      Me.tabControl1.SuspendLayout()
      Me.tabPage1.SuspendLayout()
      Me.tabPage2.SuspendLayout()
      Me.groupBox1.SuspendLayout()
      CType(Me.udNx, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.groupBox2.SuspendLayout()
      CType(Me.udNy, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.sbpChart, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.sbpC1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, menuItem2, menuItem3})
      ' 
      ' menuItem1
      ' 
      menuItem1.Index = 0
      menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileExit})
      menuItem1.Text = "&File"
      ' 
      ' menuFileExit
      ' 
      Me.menuFileExit.Index = 0
      Me.menuFileExit.Text = "E&xit"
      ' 
      ' menuItem2
      ' 
      menuItem2.Index = 1
      menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem5})
      menuItem2.Text = "&View"
      ' 
      ' menuItem5
      ' 
      menuItem5.Checked = True
      menuItem5.Index = 0
      menuItem5.Text = "Function Editor"
      ' 
      ' menuItem3
      ' 
      menuItem3.Index = 2
      menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      menuItem3.Text = "&Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 0
      Me.menuHelpAbout.Text = "&About"
      ' 
      ' pnlFuncEditor
      ' 
      Me.pnlFuncEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.pnlFuncEditor.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbFList, Me.btnSave, Me.label1, Me.tabControl1, Me.btnGenerate})
      Me.pnlFuncEditor.Dock = System.Windows.Forms.DockStyle.Left
      Me.pnlFuncEditor.Name = "pnlFuncEditor"
      Me.pnlFuncEditor.Size = New System.Drawing.Size(240, 403)
      Me.pnlFuncEditor.TabIndex = 0
      ' 
      ' cbFList
      ' 
      Me.cbFList.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.cbFList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbFList.Location = New System.Drawing.Point(8, 24)
      Me.cbFList.MaxDropDownItems = 10
      Me.cbFList.Name = "cbFList"
      Me.cbFList.Size = New System.Drawing.Size(224, 21)
      Me.cbFList.TabIndex = 3
      ' 
      ' btnSave
      ' 
      Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.btnSave.Location = New System.Drawing.Point(136, 56)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(96, 20)
      Me.btnSave.TabIndex = 2
      Me.btnSave.Text = "Save function..."
      ' 
      ' label1
      ' 
      Me.label1.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.label1.BackColor = System.Drawing.SystemColors.ActiveCaption
      Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(240, 16)
      Me.label1.TabIndex = 1
      Me.label1.Text = "Function Editor"
      ' 
      ' tabControl1
      ' 
      Me.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.tabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabPage1, Me.tabPage2})
      Me.tabControl1.Location = New System.Drawing.Point(8, 88)
      Me.tabControl1.Name = "tabControl1"
      Me.tabControl1.SelectedIndex = 0
      Me.tabControl1.Size = New System.Drawing.Size(222, 306)
      Me.tabControl1.TabIndex = 0
      ' 
      ' tabPage1
      ' 
      Me.tabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tbErrors, tbFuncText})
      Me.tabPage1.Location = New System.Drawing.Point(4, 22)
      Me.tabPage1.Name = "tabPage1"
      Me.tabPage1.Size = New System.Drawing.Size(214, 280)
      Me.tabPage1.TabIndex = 0
      Me.tabPage1.Text = "Code"
      ' 
      ' tbErrors
      ' 
      tbErrors.Dock = System.Windows.Forms.DockStyle.Bottom
      tbErrors.Location = New System.Drawing.Point(0, 224)
      tbErrors.Multiline = True
      tbErrors.Name = "tbErrors"
      tbErrors.ReadOnly = True
      tbErrors.ScrollBars = System.Windows.Forms.ScrollBars.Both
      tbErrors.Size = New System.Drawing.Size(214, 56)
      tbErrors.TabIndex = 1
      tbErrors.Text = ""
      tbErrors.Visible = False
      ' 
      ' tbFuncText
      ' 
      tbFuncText.Dock = System.Windows.Forms.DockStyle.Fill
      tbFuncText.Multiline = True
      tbFuncText.Name = "tbFuncText"
      tbFuncText.Size = New System.Drawing.Size(214, 280)
      tbFuncText.TabIndex = 0
      tbFuncText.Text = ""
      tbFuncText.WordWrap = False
      ' 
      ' tabPage2
      ' 
      Me.tabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.groupBox1, Me.groupBox2})
      Me.tabPage2.Location = New System.Drawing.Point(4, 22)
      Me.tabPage2.Name = "tabPage2"
      Me.tabPage2.Size = New System.Drawing.Size(214, 280)
      Me.tabPage2.TabIndex = 1
      Me.tabPage2.Text = "Range"
      ' 
      ' groupBox1
      ' 
      Me.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tbMaxX, tbMinX, Me.udNx, Me.label4, Me.label3, Me.label2})
      Me.groupBox1.Location = New System.Drawing.Point(8, 8)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(200, 96)
      Me.groupBox1.TabIndex = 0
      Me.groupBox1.TabStop = False
      Me.groupBox1.Text = "X"
      ' 
      ' tbMaxX
      ' 
      tbMaxX.Location = New System.Drawing.Point(56, 40)
      tbMaxX.Name = "tbMaxX"
      tbMaxX.Size = New System.Drawing.Size(80, 20)
      tbMaxX.TabIndex = 7
      tbMaxX.Text = "textBox2"
      ' 
      ' tbMinX
      ' 
      tbMinX.Location = New System.Drawing.Point(56, 16)
      tbMinX.Name = "tbMinX"
      tbMinX.Size = New System.Drawing.Size(80, 20)
      tbMinX.TabIndex = 6
      tbMinX.Text = "textBox1"
      ' 
      ' udNx
      ' 
      Me.udNx.Location = New System.Drawing.Point(96, 64)
      Me.udNx.Minimum = New System.Decimal(New Integer() {5, 0, 0, 0})
      Me.udNx.Name = "udNx"
      Me.udNx.Size = New System.Drawing.Size(40, 20)
      Me.udNx.TabIndex = 5
      Me.udNx.Value = New System.Decimal(New Integer() {5, 0, 0, 0})
      ' 
      ' label4
      ' 
      Me.label4.Location = New System.Drawing.Point(8, 64)
      Me.label4.Name = "label4"
      Me.label4.Size = New System.Drawing.Size(96, 16)
      Me.label4.TabIndex = 4
      Me.label4.Text = "Number of points"
      ' 
      ' label3
      ' 
      Me.label3.Location = New System.Drawing.Point(8, 41)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(48, 23)
      Me.label3.TabIndex = 3
      Me.label3.Text = "Max"
      ' 
      ' label2
      ' 
      Me.label2.Location = New System.Drawing.Point(8, 16)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(48, 23)
      Me.label2.TabIndex = 1
      Me.label2.Text = "Min"
      ' 
      ' groupBox2
      ' 
      Me.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.tbMaxY, tbMinY, Me.udNy, Me.label5, Me.label6, Me.label7})
      Me.groupBox2.Location = New System.Drawing.Point(8, 112)
      Me.groupBox2.Name = "groupBox2"
      Me.groupBox2.Size = New System.Drawing.Size(200, 96)
      Me.groupBox2.TabIndex = 8
      Me.groupBox2.TabStop = False
      Me.groupBox2.Text = "Y"
      ' 
      ' tbMaxY
      ' 
      tbMaxY.Location = New System.Drawing.Point(56, 40)
      tbMaxY.Name = "tbMaxY"
      tbMaxY.Size = New System.Drawing.Size(80, 20)
      tbMaxY.TabIndex = 7
      tbMaxY.Text = "textBox2"
      ' 
      ' tbMinY
      ' 
      tbMinY.Location = New System.Drawing.Point(56, 16)
      tbMinY.Name = "tbMinY"
      tbMinY.Size = New System.Drawing.Size(80, 20)
      tbMinY.TabIndex = 6
      tbMinY.Text = "textBox1"
      ' 
      ' udNy
      ' 
      Me.udNy.Location = New System.Drawing.Point(96, 64)
      Me.udNy.Minimum = New System.Decimal(New Integer() {5, 0, 0, 0})
      Me.udNy.Name = "udNy"
      Me.udNy.Size = New System.Drawing.Size(40, 20)
      Me.udNy.TabIndex = 5
      Me.udNy.Value = New System.Decimal(New Integer() {5, 0, 0, 0})
      ' 
      ' label5
      ' 
      Me.label5.Location = New System.Drawing.Point(8, 64)
      Me.label5.Name = "label5"
      Me.label5.Size = New System.Drawing.Size(96, 16)
      Me.label5.TabIndex = 4
      Me.label5.Text = "Number of points"
      ' 
      ' label6
      ' 
      Me.label6.Location = New System.Drawing.Point(8, 41)
      Me.label6.Name = "label6"
      Me.label6.Size = New System.Drawing.Size(48, 23)
      Me.label6.TabIndex = 3
      Me.label6.Text = "Max"
      ' 
      ' label7
      ' 
      Me.label7.Location = New System.Drawing.Point(8, 16)
      Me.label7.Name = "label7"
      Me.label7.Size = New System.Drawing.Size(48, 23)
      Me.label7.TabIndex = 1
      Me.label7.Text = "Min"
      ' 
      ' btnGenerate
      ' 
      Me.btnGenerate.Location = New System.Drawing.Point(8, 56)
      Me.btnGenerate.Name = "btnGenerate"
      Me.btnGenerate.Size = New System.Drawing.Size(96, 20)
      Me.btnGenerate.TabIndex = 1
      Me.btnGenerate.Text = "Generate Chart"
      ' 
      ' splitter1
      ' 
      Me.splitter1.Location = New System.Drawing.Point(240, 0)
      Me.splitter1.MinSize = 220
      Me.splitter1.Name = "splitter1"
      Me.splitter1.Size = New System.Drawing.Size(4, 403)
      Me.splitter1.TabIndex = 2
      Me.splitter1.TabStop = False
      ' 
      ' sbChart
      ' 
      Me.sbChart.Location = New System.Drawing.Point(244, 381)
      Me.sbChart.Name = "sbChart"
      Me.sbChart.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.sbpChart, Me.sbpC1})
      Me.sbChart.ShowPanels = True
      Me.sbChart.Size = New System.Drawing.Size(348, 22)
      Me.sbChart.TabIndex = 3
      Me.sbChart.Text = "Ready"
      ' 
      ' sbpChart
      ' 
      Me.sbpChart.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
      Me.sbpChart.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
      Me.sbpChart.Text = "Ready"
      Me.sbpChart.Width = 302
      ' 
      ' sbpC1
      ' 
      Me.sbpC1.Icon = CType(resources.GetObject("sbpC1.Icon"), System.Drawing.Icon)
      Me.sbpC1.MinWidth = 30
      Me.sbpC1.Width = 30
      ' 
      ' tlbChart
      ' 
      Me.tlbChart.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
      Me.tlbChart.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton11, Me.toolBarButton2, Me.toolBarButton4, Me.toolBarButton3, Me.toolBarButton5, Me.toolBarButton7, Me.toolBarButton6, Me.toolBarButton8, Me.toolBarButton9, Me.toolBarButton10, Me.toolBarButton14, Me.toolBarButton12, Me.toolBarButton13})
      Me.tlbChart.DropDownArrows = True
      Me.tlbChart.ImageList = Me.imageList1
      Me.tlbChart.Location = New System.Drawing.Point(244, 0)
      Me.tlbChart.Name = "tlbChart"
      Me.tlbChart.ShowToolTips = True
      Me.tlbChart.Size = New System.Drawing.Size(348, 25)
      Me.tlbChart.TabIndex = 5
      Me.tlbChart.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
      ' 
      ' toolBarButton1
      ' 
      Me.toolBarButton1.DropDownMenu = Me.cmChartType
      Me.toolBarButton1.ImageIndex = 0
      Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
      Me.toolBarButton1.ToolTipText = "Chart type"
      ' 
      ' cmChartType
      ' 
      Me.cmChartType.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem14, menuItem12, menuItem13})
      ' 
      ' menuItem14
      ' 
      menuItem14.Index = 0
      menuItem14.RadioCheck = True
      menuItem14.Text = "Bar"
      ' 
      ' menuItem12
      ' 
      menuItem12.Index = 1
      menuItem12.RadioCheck = True
      menuItem12.Text = "Scatter"
      ' 
      ' menuItem13
      ' 
      menuItem13.Checked = True
      menuItem13.Index = 2
      menuItem13.RadioCheck = True
      menuItem13.Text = "Surface"
      ' 
      ' toolBarButton11
      ' 
      Me.toolBarButton11.DropDownMenu = Me.cmView
      Me.toolBarButton11.ImageIndex = 9
      Me.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
      Me.toolBarButton11.ToolTipText = "View"
      ' 
      ' cmView
      ' 
      Me.cmView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem11, menuItem18, menuItem15, menuItem16, menuItem17})
      ' 
      ' menuItem11
      ' 
      menuItem11.Checked = True
      menuItem11.Index = 0
      menuItem11.RadioCheck = True
      menuItem11.Text = "3D - Default"
      ' 
      ' menuItem18
      ' 
      menuItem18.Index = 1
      menuItem18.Text = "-"
      ' 
      ' menuItem15
      ' 
      menuItem15.Index = 2
      menuItem15.RadioCheck = True
      menuItem15.Text = "2D - XY plane"
      ' 
      ' menuItem16
      ' 
      menuItem16.Index = 3
      menuItem16.RadioCheck = True
      menuItem16.Text = "2D - XZ plane"
      ' 
      ' menuItem17
      ' 
      menuItem17.Index = 4
      menuItem17.RadioCheck = True
      menuItem17.Text = "2D - YZ plane"
      ' 
      ' toolBarButton2
      ' 
      Me.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
      ' 
      ' toolBarButton4
      ' 
      Me.toolBarButton4.ImageIndex = 5
      Me.toolBarButton4.ToolTipText = "Rotation Z"
      ' 
      ' toolBarButton3
      ' 
      Me.toolBarButton3.ImageIndex = 1
      Me.toolBarButton3.ToolTipText = "Rotation Z"
      ' 
      ' toolBarButton5
      ' 
      Me.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
      ' 
      ' toolBarButton7
      ' 
      Me.toolBarButton7.ImageIndex = 6
      Me.toolBarButton7.ToolTipText = "Rotation X"
      ' 
      ' toolBarButton6
      ' 
      Me.toolBarButton6.ImageIndex = 2
      Me.toolBarButton6.ToolTipText = "Rotation X"
      ' 
      ' toolBarButton8
      ' 
      Me.toolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
      ' 
      ' toolBarButton9
      ' 
      Me.toolBarButton9.ImageIndex = 7
      Me.toolBarButton9.Pushed = True
      Me.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
      Me.toolBarButton9.ToolTipText = "Grid"
      ' 
      ' toolBarButton10
      ' 
      Me.toolBarButton10.ImageIndex = 8
      Me.toolBarButton10.Pushed = True
      Me.toolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
      Me.toolBarButton10.ToolTipText = "Axes"
      ' 
      ' toolBarButton14
      ' 
      Me.toolBarButton14.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
      ' 
      ' toolBarButton12
      ' 
      Me.toolBarButton12.DropDownMenu = Me.cmContour
      Me.toolBarButton12.ImageIndex = 10
      Me.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
      Me.toolBarButton12.ToolTipText = "Zone colors"
      ' 
      ' cmContour
      ' 
      Me.cmContour.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem19, menuItem20, menuItem21, menuItem22, menuItem23, menuItem33, menuItem34, menuItem35, menuItem36, menuItem37, menuItem38})
      ' 
      ' menuItem19
      ' 
      menuItem19.Checked = True
      menuItem19.Index = 0
      menuItem19.RadioCheck = True
      menuItem19.Text = "None"
      ' 
      ' menuItem20
      ' 
      menuItem20.Index = 1
      menuItem20.RadioCheck = True
      menuItem20.Text = "Rainbow"
      ' 
      ' menuItem21
      ' 
      menuItem21.Index = 2
      menuItem21.RadioCheck = True
      menuItem21.Text = "RevRainbow"
      ' 
      ' menuItem22
      ' 
      menuItem22.Index = 3
      menuItem22.RadioCheck = True
      menuItem22.Text = "Black -> White"
      ' 
      ' menuItem23
      ' 
      menuItem23.Index = 4
      menuItem23.RadioCheck = True
      menuItem23.Text = "White -> Black"
      ' 
      ' menuItem33
      ' 
      menuItem33.Index = 5
      menuItem33.RadioCheck = True
      menuItem33.Text = "Green -> Blue"
      ' 
      ' menuItem34
      ' 
      menuItem34.Index = 6
      menuItem34.RadioCheck = True
      menuItem34.Text = "Red -> White"
      ' 
      ' menuItem35
      ' 
      menuItem35.Index = 7
      menuItem35.RadioCheck = True
      menuItem35.Text = "Blue -> Pink"
      ' 
      ' menuItem36
      ' 
      menuItem36.Index = 8
      menuItem36.RadioCheck = True
      menuItem36.Text = "Blue -> White -> Red"
      ' 
      ' menuItem37
      ' 
      menuItem37.Index = 9
      menuItem37.RadioCheck = True
      menuItem37.Text = "Black -> Red ->Yellow"
      ' 
      ' menuItem38
      ' 
      menuItem38.Index = 10
      menuItem38.RadioCheck = True
      menuItem38.Text = "Green -> Purple -> Yellow"
      ' 
      ' toolBarButton13
      ' 
      Me.toolBarButton13.DropDownMenu = Me.cmNCont
      Me.toolBarButton13.ImageIndex = 11
      Me.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
      Me.toolBarButton13.ToolTipText = "Number of levels"
      ' 
      ' cmNCont
      ' 
      Me.cmNCont.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem24, menuItem25, menuItem26, menuItem27, menuItem28, menuItem29, menuItem30, menuItem31, menuItem32})
      ' 
      ' menuItem24
      ' 
      menuItem24.Index = 0
      menuItem24.RadioCheck = True
      menuItem24.Text = "10"
      ' 
      ' menuItem25
      ' 
      menuItem25.Index = 1
      menuItem25.RadioCheck = True
      menuItem25.Text = "15"
      ' 
      ' menuItem26
      ' 
      menuItem26.Checked = True
      menuItem26.Index = 2
      menuItem26.RadioCheck = True
      menuItem26.Text = "20"
      ' 
      ' menuItem27
      ' 
      menuItem27.Index = 3
      menuItem27.RadioCheck = True
      menuItem27.Text = "25"
      ' 
      ' menuItem28
      ' 
      menuItem28.Index = 4
      menuItem28.RadioCheck = True
      menuItem28.Text = "30"
      ' 
      ' menuItem29
      ' 
      menuItem29.Index = 5
      menuItem29.RadioCheck = True
      menuItem29.Text = "35"
      ' 
      ' menuItem30
      ' 
      menuItem30.Index = 6
      menuItem30.RadioCheck = True
      menuItem30.Text = "40"
      ' 
      ' menuItem31
      ' 
      menuItem31.Index = 7
      menuItem31.RadioCheck = True
      menuItem31.Text = "45"
      ' 
      ' menuItem32
      ' 
      menuItem32.Index = 8
      menuItem32.RadioCheck = True
      menuItem32.Text = "50"
      ' 
      ' imageList1
      ' 
      Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
      Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
      Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.imageList1.TransparentColor = System.Drawing.Color.White
      ' 
      ' c1Chart3D1
      ' 
      Me.c1Chart3D1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart3D1.Location = New System.Drawing.Point(244, 25)
      Me.c1Chart3D1.Name = "c1Chart3D1"
      Me.c1Chart3D1.PropBag = "<?xml version=""1.0""?><Chart3DPropBag Version=""""><LegendData Compass=""East"" /><Sty" + "leCollection><NamedStyle Name=""Legend"" ParentName=""Legend.default"" /><NamedStyle" + " Name=""Footer"" ParentName=""Control"" /><NamedStyle Name=""Area"" ParentName=""Area.d" + "efault"" StyleData=""Border=Empty,ControlText,1;"" /><NamedStyle Name=""Control"" Par" + "entName=""Control.default"" StyleData=""Border=RaisedBevel,ControlText,1;"" /><Named" + "Style Name=""LabelStyleDefault"" ParentName=""Control"" StyleData=""BackColor=Transpa" + "rent;"" /><NamedStyle Name=""Legend.default"" ParentName=""Control"" StyleData=""Wrap=" + "False;AlignVert=Top;"" /><NamedStyle Name=""Header"" ParentName=""Control"" /><NamedS" + "tyle Name=""Control.default"" ParentName="""" StyleData=""ForeColor=ControlText;BackC" + "olor=Control;"" /><NamedStyle Name=""Area.default"" ParentName=""Control"" StyleData=" + """AlignVert=Top;"" /></StyleCollection><FooterData Compass=""South"" /><HeaderData C" + "ompass=""North"" /><ChartStyles><Chart3DStyle><SymbolStyle Shape=""Dot"" Color=""Red""" + " Size=""4"" /><LineStyle Pattern=""Solid"" Color=""Black"" Thickness=""0"" /></Chart3DSt" + "yle></ChartStyles><ChartGroupsCollection><Chart3DGroup><Contour NumLevels=""20"" /" + "><ChartData><Set type=""Chart3DDataSetGrid"" ColumnOrigin=""0"" RowOrigin=""0"" RowDel" + "ta=""1"" RowCount=""11"" ColumnCount=""11"" ColumnDelta=""1"" Hole=""3.40282347E+38""><Dat" + "a>4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4.5" + " 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 " + "10.9 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 14.1 13.2 12.5 12 11.7 1" + "1.6 11.7 12 12.5 13.2 14.1 14.5 13.6 12.9 12.4 12.1 12 12.1 12.4 12.9 13.6 14.5 " + "14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 12.9 12 11.3 10.8 10.5 10.4 1" + "0.5 10.8 11.3 12 12.9 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 8.1 7.2 6.5 6 " + "5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.399" + "99986 2.89999986 3.6 4.5 </Data></Set></ChartData></Chart3DGroup></ChartGroupsCo" + "llection><View BackColor=""Control"" ViewportHorizontalShift=""0"" ViewportVerticalS" + "hift=""0"" /></Chart3DPropBag>"

      Me.c1Chart3D1.Size = New System.Drawing.Size(348, 356)
      Me.c1Chart3D1.TabIndex = 6
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 403)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart3D1, Me.tlbChart, Me.sbChart, Me.splitter1, Me.pnlFuncEditor})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 3D - Function Plotting Demo"
      Me.pnlFuncEditor.ResumeLayout(False)
      Me.tabControl1.ResumeLayout(False)
      Me.tabPage1.ResumeLayout(False)
      Me.tabPage2.ResumeLayout(False)
      Me.groupBox1.ResumeLayout(False)
      CType(Me.udNx, System.ComponentModel.ISupportInitialize).EndInit()
      Me.groupBox2.ResumeLayout(False)
      CType(Me.udNy, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.sbpChart, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.sbpC1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).EndInit()
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
   
   
   Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles btnGenerate.Click
      sbpChart.Text = "Generating chart ..."
      Dim grset As C1.Win.C1Chart3D.Chart3DDataSetGrid = eng.Run(tbFuncText.Text, Range)
      If Not (grset Is Nothing) Then
         tbErrors.Visible = False
         c1Chart3D1.ChartGroups(0).ChartData.SetGrid = grset
         Me.sbpChart.Text = "Ready"
      Else
         tbErrors.Visible = True
         tbErrors.Lines = eng.Errors
         Me.sbpChart.Text = "Error in function code"
      End If
   End Sub 'button1_Click
   
   
   Private Sub menuItem5_Click(sender As Object, e As System.EventArgs) Handles menuItem5.Click
      pnlFuncEditor.Visible = Not pnlFuncEditor.Visible
      Dim mi As MenuItem = CType(sender, MenuItem)
      mi.Checked = pnlFuncEditor.Visible
   End Sub 'menuItem5_Click
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      cbFList.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right 
      btnSave.Anchor = AnchorStyles.Top Or AnchorStyles.Right 
      label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right 
      tabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      groupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right 
      groupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right 
      updateRange(False)
      loadFList()
      rotz = c1Chart3D1.ChartArea.View.RotationZ
      rotx = c1Chart3D1.ChartArea.View.RotationX
   End Sub 'Form1_Load
   
   
   Private Sub tbFloat_TextChanged(sender As Object, e As System.EventArgs) Handles tbMaxX.TextChanged, tbMinX.TextChanged, tbMaxY.TextChanged, tbMinY.TextChanged
      Dim tb As TextBox = CType(sender, TextBox)
      Try
         Single.Parse(tb.Text)
      Catch
         tb.Undo()
         tb.ClearUndo()
      End Try
      tb.Text = tb.Text.Trim()
   End Sub 'tbFloat_TextChanged
   
   
   Private Sub btnSave_Click(sender As Object, e As System.EventArgs) Handles btnSave.Click
      Dim fnf As New FuncNameForm()
      fnf.FName = cbFList.SelectedItem.ToString()
      If fnf.ShowDialog() = DialogResult.OK Then
         Dim i As Integer = fcoll.FindName(fnf.FName)
         If i = - 1 Then
            i = fcoll.Add(New FunctionInfo(fnf.tbFName.Text, tbFuncText.Lines, Range))
         Else
            If MessageBox.Show("Overwrite existing function?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
               fcoll(i).Code = tbFuncText.Lines
               fcoll(i).Range = Range
            End If
         End If
         
         updateFList(i)
         Dim x As New XmlSerializer(GetType(FunctionInfoCollection))
         Dim writer = New StreamWriter(getConfigFileName())
         x.Serialize(writer, fcoll)
         writer.Close()
      End If
   End Sub 'btnSave_Click
   
   
   Private Sub cbFList_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbFList.SelectedIndexChanged
      Dim i As Integer = cbFList.SelectedIndex
      If i >= 0 AndAlso i <= fcoll.Count Then
         tbFuncText.Lines = fcoll(i).Code
         Range = fcoll(i).Range
      End If
   End Sub 'cbFList_SelectedIndexChanged
   
   
   Private Sub tbErrors_VisibleChanged(sender As Object, e As System.EventArgs) Handles tbErrors.VisibleChanged
   End Sub 'tbErrors_VisibleChanged
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub tlbChart_ButtonClick(sender As Object, e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tlbChart.ButtonClick
      Select Case tlbChart.Buttons.IndexOf(e.Button)
         Case 0
            selectNext(cmChartType)
         Case 1
            selectNext(cmView)
         Case 4
            rotz += rot_inc
            If rotz > 360 Then
               rotz -= 360
            End If
            c1Chart3D1.ChartArea.View.RotationZ = rotz
         Case 3
            rotz -= rot_inc
            If rotz < 0 Then
               rotz += 360
            End If
            c1Chart3D1.ChartArea.View.RotationZ = rotz
         Case 6
            rotx += rot_inc
            If rotx > 360 Then
               rotx -= 360
            End If
            c1Chart3D1.ChartArea.View.RotationX = rotx
         Case 7
            rotx -= rot_inc
            If rotx < 0 Then
               rotx += 360
            End If
            c1Chart3D1.ChartArea.View.RotationX = rotx
         Case 9
            c1Chart3D1.ChartGroups(0).Elevation.IsMeshed = Not c1Chart3D1.ChartGroups(0).Elevation.IsMeshed
         Case 10
            c1Chart3D1.ChartArea.AxisX.Visible = Not c1Chart3D1.ChartArea.AxisX.Visible
            c1Chart3D1.ChartArea.AxisY.Visible = Not c1Chart3D1.ChartArea.AxisY.Visible
            c1Chart3D1.ChartArea.AxisZ.Visible = Not c1Chart3D1.ChartArea.AxisZ.Visible
         Case 12
            selectNext(cmContour)
         Case 13
            selectNext(cmNCont)
         Case Else
      End Select
   End Sub 'tlbChart_ButtonClick
   
   
   Private Sub miChartType_Click(sender As Object, e As System.EventArgs) Handles menuItem14.Click, menuItem12.Click, menuItem13.Click
      Dim mi As MenuItem = CType(sender, MenuItem)
      Dim _mi As MenuItem
      For Each _mi In  cmChartType.MenuItems
         _mi.Checked = False
      Next _mi
      mi.Checked = True
      
      Select Case Me.cmChartType.MenuItems.IndexOf(mi)
         Case 0
            c1Chart3D1.ChartGroups(0).ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Bar
         Case 1
            c1Chart3D1.ChartGroups(0).ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Scatter
         Case 2
            c1Chart3D1.ChartGroups(0).ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Surface
         Case Else
      End Select
   End Sub 'miChartType_Click
   
   
   Private Sub miView_Click(sender As Object, e As System.EventArgs) Handles menuItem11.Click, menuItem15.Click, menuItem16.Click, menuItem17.Click
      Dim mi As MenuItem = CType(sender, MenuItem)
      Dim _mi As MenuItem
      For Each _mi In  cmView.MenuItems
         _mi.Checked = False
      Next _mi
      mi.Checked = True
      
      Select Case Me.cmView.MenuItems.IndexOf(mi)
         Case 0
            c1Chart3D1.ChartArea.View.View3D = C1.Win.C1Chart3D.View3DEnum.Default
         Case 2
            c1Chart3D1.ChartArea.View.View3D = C1.Win.C1Chart3D.View3DEnum.XY_2D_Pos
         Case 3
            c1Chart3D1.ChartArea.View.View3D = C1.Win.C1Chart3D.View3DEnum.XZ_2D_Pos
         Case 4
            c1Chart3D1.ChartArea.View.View3D = C1.Win.C1Chart3D.View3DEnum.YZ_2D_Pos
         Case Else
      End Select
   End Sub 'miView_Click
   
   
   Private Sub miContour_Click(sender As Object, e As System.EventArgs) Handles menuItem19.Click, menuItem20.Click, menuItem21.Click, menuItem22.Click, menuItem23.Click, menuItem33.Click, menuItem34.Click, menuItem35.Click, menuItem36.Click, menuItem37.Click, menuItem38.Click
      Dim mi As MenuItem = CType(sender, MenuItem)
      Dim _mi As MenuItem
      For Each _mi In  cmContour.MenuItems
         _mi.Checked = False
      Next _mi
      mi.Checked = True
      
      Dim i As Integer = Me.cmContour.MenuItems.IndexOf(mi)
      
      Select Case i
         Case 0
            If c1Chart3D1.ChartGroups(0).Contour.IsZoned Then
               c1Chart3D1.ChartGroups(0).Contour.IsZoned = False
            End If
         Case Else
            setZoneChart(CType(i, C1.Win.C1Chart3D.ColorSetEnum))
      End Select
   End Sub 'miContour_Click
   
   
   Private Sub miNCont_Click(sender As Object, e As System.EventArgs) Handles menuItem24.Click, menuItem25.Click, menuItem26.Click, menuItem27.Click, menuItem28.Click, menuItem29.Click, menuItem30.Click, menuItem31.Click, menuItem32.Click
      Dim mi As MenuItem = CType(sender, MenuItem)
      Dim _mi As MenuItem
      For Each _mi In  cmNCont.MenuItems
         _mi.Checked = False
      Next _mi
      mi.Checked = True
      setZoneNumber((mi.Index * 5 + 10))
   End Sub 'miNCont_Click
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
End Class 'Form1
