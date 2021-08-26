Imports C1.C1Report
Imports System.Data.OleDb
Imports System.Xml

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' check selected file
    Dim reports As String()
    Dim tableName As String
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents _c1r As C1.C1Report.C1Report
    Friend WithEvents _imgList As System.Windows.Forms.ImageList
    Friend WithEvents _btnSep As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnPreview As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnAddReport As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnDelReport As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnOpen As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnNew As System.Windows.Forms.ToolBarButton
    Friend WithEvents _tb As System.Windows.Forms.ToolBar
    Friend WithEvents _btnDesign As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnSave As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnAddField As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnAddLabel As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnCut As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnCopy As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnPaste As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnSep4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnUndo As System.Windows.Forms.ToolBarButton
    Friend WithEvents _btnRedo As System.Windows.Forms.ToolBarButton
    Friend WithEvents splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents _ppg As System.Windows.Forms.PropertyGrid
    Friend WithEvents _lblPropGrid As System.Windows.Forms.Label
    Friend WithEvents splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents _list As System.Windows.Forms.ListBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents _c1rd As C1.Win.C1ReportDesigner.C1ReportDesigner
    Friend WithEvents _c1ppv As C1.Win.C1Preview.C1PrintPreviewControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me._c1r = New C1.C1Report.C1Report()
        Me._imgList = New System.Windows.Forms.ImageList(Me.components)
        Me._btnSep = New System.Windows.Forms.ToolBarButton()
        Me._btnPreview = New System.Windows.Forms.ToolBarButton()
        Me._btnAddReport = New System.Windows.Forms.ToolBarButton()
        Me._btnDelReport = New System.Windows.Forms.ToolBarButton()
        Me._btnSep2 = New System.Windows.Forms.ToolBarButton()
        Me._btnOpen = New System.Windows.Forms.ToolBarButton()
        Me._btnNew = New System.Windows.Forms.ToolBarButton()
        Me._tb = New System.Windows.Forms.ToolBar()
        Me._btnDesign = New System.Windows.Forms.ToolBarButton()
        Me._btnSave = New System.Windows.Forms.ToolBarButton()
        Me._btnAddField = New System.Windows.Forms.ToolBarButton()
        Me._btnAddLabel = New System.Windows.Forms.ToolBarButton()
        Me._btnSep3 = New System.Windows.Forms.ToolBarButton()
        Me._btnCut = New System.Windows.Forms.ToolBarButton()
        Me._btnCopy = New System.Windows.Forms.ToolBarButton()
        Me._btnPaste = New System.Windows.Forms.ToolBarButton()
        Me._btnSep4 = New System.Windows.Forms.ToolBarButton()
        Me._btnUndo = New System.Windows.Forms.ToolBarButton()
        Me._btnRedo = New System.Windows.Forms.ToolBarButton()
        Me.splitter1 = New System.Windows.Forms.Splitter()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me._ppg = New System.Windows.Forms.PropertyGrid()
        Me._c1rd = New C1.Win.C1ReportDesigner.C1ReportDesigner()
        Me._lblPropGrid = New System.Windows.Forms.Label()
        Me.splitter2 = New System.Windows.Forms.Splitter()
        Me._list = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me._c1ppv = New C1.Win.C1Preview.C1PrintPreviewControl()
        CType(Me._c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me._c1ppv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_c1r
        '
        Me._c1r.ReportName = "c1Report1"
        '
        '_imgList
        '
        Me._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me._imgList.ImageSize = New System.Drawing.Size(16, 15)
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        '
        '_btnSep
        '
        Me._btnSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        '_btnPreview
        '
        Me._btnPreview.ImageIndex = 6
        Me._btnPreview.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me._btnPreview.ToolTipText = "Preview Mode"
        '
        '_btnAddReport
        '
        Me._btnAddReport.ImageIndex = 12
        Me._btnAddReport.ToolTipText = "Add Report"
        '
        '_btnDelReport
        '
        Me._btnDelReport.ImageIndex = 13
        Me._btnDelReport.ToolTipText = "Delete Report"
        '
        '_btnSep2
        '
        Me._btnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        '_btnOpen
        '
        Me._btnOpen.ImageIndex = 1
        Me._btnOpen.ToolTipText = "Open File"
        '
        '_btnNew
        '
        Me._btnNew.ImageIndex = 0
        Me._btnNew.ToolTipText = "New File"
        '
        '_tb
        '
        Me._tb.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me._tb.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me._btnDesign, Me._btnPreview, Me._btnSep, Me._btnNew, Me._btnOpen, Me._btnSave, Me._btnSep2, Me._btnAddReport, Me._btnDelReport, Me._btnAddField, Me._btnAddLabel, Me._btnSep3, Me._btnCut, Me._btnCopy, Me._btnPaste, Me._btnSep4, Me._btnUndo, Me._btnRedo})
        Me._tb.DropDownArrows = True
        Me._tb.ImageList = Me._imgList
        Me._tb.Name = "_tb"
        Me._tb.ShowToolTips = True
        Me._tb.Size = New System.Drawing.Size(728, 24)
        Me._tb.TabIndex = 7
        '
        '_btnDesign
        '
        Me._btnDesign.ImageIndex = 5
        Me._btnDesign.Pushed = True
        Me._btnDesign.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        Me._btnDesign.ToolTipText = "Design Mode"
        '
        '_btnSave
        '
        Me._btnSave.ImageIndex = 2
        Me._btnSave.ToolTipText = "Save File"
        '
        '_btnAddField
        '
        Me._btnAddField.ImageIndex = 14
        Me._btnAddField.ToolTipText = "Add Calculated Field"
        '
        '_btnAddLabel
        '
        Me._btnAddLabel.ImageIndex = 15
        Me._btnAddLabel.ToolTipText = "Add Label Field"
        '
        '_btnSep3
        '
        Me._btnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        '_btnCut
        '
        Me._btnCut.ImageIndex = 11
        Me._btnCut.ToolTipText = "Cut"
        '
        '_btnCopy
        '
        Me._btnCopy.ImageIndex = 10
        Me._btnCopy.ToolTipText = "Copy"
        '
        '_btnPaste
        '
        Me._btnPaste.ImageIndex = 9
        Me._btnPaste.ToolTipText = "Paste"
        '
        '_btnSep4
        '
        Me._btnSep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        '_btnUndo
        '
        Me._btnUndo.ImageIndex = 7
        Me._btnUndo.ToolTipText = "Undo"
        '
        '_btnRedo
        '
        Me._btnRedo.ImageIndex = 8
        Me._btnRedo.ToolTipText = "Redo"
        '
        'splitter1
        '
        Me.splitter1.Location = New System.Drawing.Point(205, 24)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(7, 496)
        Me.splitter1.TabIndex = 5
        Me.splitter1.TabStop = False
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me._ppg, Me._lblPropGrid, Me.splitter2, Me._list, Me.label1})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 24)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(205, 496)
        Me.panel1.TabIndex = 4
        '
        '_ppg
        '
        Me._ppg.CommandsVisibleIfAvailable = True
        Me._ppg.Dock = System.Windows.Forms.DockStyle.Fill
        Me._ppg.HelpVisible = False
        Me._ppg.LargeButtons = False
        Me._ppg.LineColor = System.Drawing.SystemColors.ScrollBar
        Me._ppg.Location = New System.Drawing.Point(0, 190)
        Me._ppg.Name = "_ppg"
        Me._ppg.Size = New System.Drawing.Size(205, 306)
        Me._ppg.TabIndex = 3
        Me._ppg.Text = "propertyGrid1"
        Me._ppg.ToolbarVisible = False
        Me._ppg.ViewBackColor = System.Drawing.SystemColors.Window
        Me._ppg.ViewForeColor = System.Drawing.SystemColors.WindowText
        '
        '_c1rd
        '
        Me._c1rd.BorderStyleSection = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me._c1rd.Dock = System.Windows.Forms.DockStyle.Fill
        Me._c1rd.ForeColorGroup = System.Drawing.SystemColors.Highlight
        Me._c1rd.Name = "_c1rd"
        Me._c1rd.Size = New System.Drawing.Size(516, 496)
        Me._c1rd.TabIndex = 1
        Me._c1rd.Text = "c1ReportDesigner1"
        '
        '_lblPropGrid
        '
        Me._lblPropGrid.BackColor = System.Drawing.SystemColors.Control
        Me._lblPropGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._lblPropGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me._lblPropGrid.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblPropGrid.Location = New System.Drawing.Point(0, 168)
        Me._lblPropGrid.Name = "_lblPropGrid"
        Me._lblPropGrid.Size = New System.Drawing.Size(205, 22)
        Me._lblPropGrid.TabIndex = 2
        Me._lblPropGrid.Text = "Properties"
        Me._lblPropGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'splitter2
        '
        Me.splitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.splitter2.Location = New System.Drawing.Point(0, 160)
        Me.splitter2.Name = "splitter2"
        Me.splitter2.Size = New System.Drawing.Size(205, 8)
        Me.splitter2.TabIndex = 4
        Me.splitter2.TabStop = False
        '
        '_list
        '
        Me._list.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._list.Dock = System.Windows.Forms.DockStyle.Top
        Me._list.IntegralHeight = False
        Me._list.ItemHeight = 16
        Me._list.Location = New System.Drawing.Point(0, 22)
        Me._list.Name = "_list"
        Me._list.Size = New System.Drawing.Size(205, 138)
        Me._list.TabIndex = 1
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.SystemColors.Control
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(205, 22)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Reports"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel2
        '
        Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me._c1rd, Me._c1ppv})
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(212, 24)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(516, 496)
        Me.panel2.TabIndex = 6
        '
        '_c1ppv
        '
        Me._c1ppv.Dock = System.Windows.Forms.DockStyle.Fill
        Me._c1ppv.Name = "_c1ppv"
        Me._c1ppv.Size = New System.Drawing.Size(516, 496)
        Me._c1ppv.TabIndex = 2
        Me._c1ppv.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(728, 520)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2, Me.splitter1, Me.panel1, Me._tb})
        Me.Name = "Form1"
        Me.Text = "C1ReportDesigner Demo"
        CType(Me._c1r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me._c1ppv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' ** fields

    Private _fileName As String
    Private _dirty As Boolean

    'Private Const _appName = "C1ReportDesigner Demo"
    Dim _appName As String = "C1ReportDesigner Demo"

    ' ** event handlers

    ' update UI on startup to show form title and disable clipboard and
    ' undo/redo buttons
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateUI()
    End Sub

    ' handle clicks on toolbar buttons
    Private Sub _tb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles _tb.ButtonClick

        ' design/preview mode
        If e.Button.Equals(_btnDesign) Then SetDesignMode(True)
        If e.Button.Equals(_btnPreview) Then SetDesignMode(False)

        ' file commands
        If e.Button.Equals(_btnNew) Then NewFile()
        If e.Button.Equals(_btnOpen) Then OpenFile()
        If e.Button.Equals(_btnSave) Then SaveFile()

        ' allow user to undo clipboard operations			
        If e.Button.Equals(_btnCut) Or e.Button.Equals(_btnPaste) Then
            _c1rd.UndoStack.SaveState()
        End If

        ' clipboard
        If e.Button.Equals(_btnCut) Then _c1rd.ClipboardHandler.Cut()
        If e.Button.Equals(_btnCopy) Then _c1rd.ClipboardHandler.Copy()
        If e.Button.Equals(_btnPaste) Then _c1rd.ClipboardHandler.Paste()

        ' undo/redo
        If e.Button.Equals(_btnUndo) Then _c1rd.UndoStack.Undo()
        If e.Button.Equals(_btnRedo) Then _c1rd.UndoStack.Redo()

        ' add/remove reports
        If e.Button.Equals(_btnAddReport) Then NewReport()
        If e.Button.Equals(_btnDelReport) Then DeleteReport()

        ' add fields
        ' (just set create info and wait for CreateField event from designer)
        If e.Button.Equals(_btnAddField) Then _c1rd.CreateFieldInfo = e.Button
        If e.Button.Equals(_btnAddLabel) Then _c1rd.CreateFieldInfo = e.Button
    End Sub

    ' a new report was selected: switch to design mode and show it
    Private Sub _list_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _list.SelectedIndexChanged

        ' switch to design mode
        SetDesignMode(True)

        ' attach selected report to designer and preview controls
        _c1rd.Report = Nothing
        _c1ppv.Document = Nothing
        If _list.SelectedIndex > -1 Then
            _c1rd.Report = _list.SelectedItem.Report
        End If
    End Sub

    ' when a value changes in the property window, refresh the designer
    ' to show the changes
    Private Sub _ppg_PropertyValueChanged(ByVal s As Object, ByVal e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles _ppg.PropertyValueChanged
        _c1rd.Refresh()
        _dirty = True
        UpdateUI()
    End Sub

    ' when properties of the selected objects change in the designer,
    ' update the property window to show the changes
    Private Sub _c1rd_ValuesChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _c1rd.ValuesChanged
        _c1rd.Refresh()
        _dirty = True
        UpdateUI()
    End Sub

    ' the selection changed, need to update property grid and show the
    ' properties of the selected object 
    Private Sub _c1rd_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _c1rd.SelectionChanged
        Dim sel As Object() = _c1rd.SelectedFields
        If (sel.Length > 0) Then
            _lblPropGrid.Text = "Field Properties"
            _ppg.SelectedObjects = sel
        ElseIf Not IsNothing(_c1rd.SelectedSection) Then
            _lblPropGrid.Text = "Section Properties"
            _ppg.SelectedObject = _c1rd.SelectedSection
        ElseIf Not IsNothing(_c1rd.Report) Then
            _lblPropGrid.Text = "Report Properties"
            _ppg.SelectedObject = _c1rd.Report
        Else ' nothing selected
            _lblPropGrid.Text = "Properties"
            _ppg.SelectedObject = Nothing
        End If

        ' done
        UpdateUI()
    End Sub

    ' ** update UI to reflect current state

    Private Sub UpdateUI()

        ' update caption
        _fileName = _appName
        If _fileName.Length > 0 Then
            _fileName = String.Format("{0} - [{1}]", _appName, _fileName)
            If _dirty Then _fileName = _fileName + " *"
        End If


        ' push/release design/preview mode buttons
        Dim design As Boolean = _c1rd.Visible AndAlso (Not IsNothing(_c1rd.Report))
        _btnDesign.Pushed = design
        _btnPreview.Pushed = Not design

        ' enable/disable buttons
        _btnCut.Enabled = design AndAlso _c1rd.ClipboardHandler.CanCut
        _btnCopy.Enabled = design AndAlso _c1rd.ClipboardHandler.CanCut
        _btnPaste.Enabled = design AndAlso _c1rd.ClipboardHandler.CanPaste
        _btnUndo.Enabled = design AndAlso _c1rd.UndoStack.CanUndo
        _btnRedo.Enabled = design AndAlso _c1rd.UndoStack.CanRedo

        Dim reportSelected As Boolean = design AndAlso Not (IsNothing(_list.SelectedItem))
        _btnAddReport.Enabled = _c1rd.Visible
        _btnDelReport.Enabled = reportSelected
        _btnAddField.Enabled = reportSelected
        _btnAddLabel.Enabled = reportSelected
    End Sub

    ' ** switch between design/preview mode

    Private Sub SetDesignMode(ByVal design As Boolean)

        ' show/hide preview/design panes
        _c1rd.Visible = design
        _c1ppv.Visible = Not design

        ' no properties in preview mode
        If Not design Then
            _lblPropGrid.Text = "Properties"
            _ppg.SelectedObject = Nothing
        End If

        ' attach copy of the report to preview control
        ' (so changes caused by script aren't saved)
        If Not design Then
            _c1ppv.Document = Nothing
            _c1r.CopyFrom(_c1rd.Report)
            Cursor = Cursors.WaitCursor
            _c1r.Render()
            If _c1r.PageImages.Count > 0 Then
                _c1ppv.Document = _c1r.Document
            End If
            Cursor = Cursors.Default
        End If

        ' done, update UI
        UpdateUI()
    End Sub

    ' ** file commands

    Private Sub NewFile()
        _fileName = ""
        _dirty = False
        _list.Items.Clear()
        _c1ppv.Document = Nothing
        _c1rd.Report = Nothing
        UpdateUI()
    End Sub

    Public Sub OpenFile()

        ' get name of file to open
        Dim dlg As New OpenFileDialog()
        dlg.FileName = "*.xml"
        dlg.Title = "Open Report Definition File"
        If dlg.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Return
        End If

        
        Try
            reports = _c1r.GetReportInfo(dlg.FileName)
        Catch
            If IsNothing(reports) OrElse reports.Length = 0 Then
                MessageBox.Show("Invalid (or empty) report defintion file")
                Return
            End If
        End Try

        ' clear list
        NewFile()

        ' load new file
        Cursor = Cursors.WaitCursor
        _fileName = dlg.FileName
        Dim reportName As String
        For Each reportName In reports
            Try
                Dim rpt As New C1Report()
                rpt.Load(_fileName, reportName)
                _list.Items.Add(New ReportHolder(rpt))
            Catch ex As Exception
                MessageBox.Show(String.Format("Error loading report {0}: {1}", reportName, ex.Message))
            End Try
        Next
        Cursor = Cursors.Default

        ' select first report
        _list.SelectedIndex = 0
    End Sub

    Public Sub SaveFile()

        ' get name of file to save
        Dim dlg As New SaveFileDialog()
        dlg.FileName = _fileName
        dlg.Title = "Save Report Definition File"
        If dlg.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return

        ' save file
        Dim w As New XmlTextWriter(dlg.FileName, System.Text.Encoding.Default)
        w.Formatting = Formatting.Indented
        w.Indentation = 2
        w.WriteStartDocument()

        ' write all reports to it
        Cursor = Cursors.WaitCursor
        w.WriteStartElement("Reports")
        Dim rh As ReportHolder
        For Each rh In _list.Items
            rh.Report.Save(w) ' rh.Report.ReportName)
        Next
        w.WriteEndElement()
        Cursor = Cursors.Default

        ' close the file
        w.Close()

        ' and be done
        _fileName = dlg.FileName
        _dirty = False
        UpdateUI()
    End Sub

    ' create a new report and add it to the list
    Private Sub NewReport()

        ' select a data source (just mdb files in this sample)
        Dim dlg As New OpenFileDialog()
        dlg.FileName = "*.mdb"
        dlg.Title = "Select report data source"
        If dlg.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return

        ' select first table from data source
        Dim connString As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dlg.FileName)
        Dim tableName As String = GetFirstTable(connString)

        If tableName.Length = 0 Then
            MessageBox.Show("Failed to retrieve data from the selected source.")
            Return
        End If

        ' create new report
        Dim rpt As New C1Report()
        rpt.ReportName = tableName

        ' set data source
        rpt.DataSource.ConnectionString = connString
        rpt.DataSource.RecordSource = tableName

        ' add a title field
        Dim s As Section = rpt.Sections.header
        s.Visible = True
        s.Height = 600
        Dim f As Field = s.Fields.Add("TitleField", tableName, 0, 0, 4000, 600)
        f.Font.Bold = True
        f.Font.Size = 24
        f.ForeColor = Color.Navy

        ' add up to 5 calculated fields
        Dim fieldNames As String() = rpt.DataSource.GetDBFieldList(True)
        Dim cnt As Integer = Math.Min(5, fieldNames.Length)

        ' add a page header
        s = rpt.Sections.PageHeader
        s.Visible = True
        s.Height = 400
        Dim rc As New Rectangle(0, 0, 1000, s.Height)

        Dim i As Integer
        For i = 0 To cnt - 1
            f = s.Fields.Add("TitleField", fieldNames(i), rc)
            f.Font.Bold = True
            rc.Offset(rc.Width, 0)
        Next

        ' add detail section
        s = rpt.Sections.Detail
        s.Visible = True
        s.Height = 300
        rc = New Rectangle(0, 0, 1000, s.Height)
        For i = 0 To cnt - 1
            f = s.Fields.Add("TitleField", fieldNames(i), rc)
            f.Calculated = True
            rc.Offset(rc.Width, 0)
        Next

        ' add new report to the list and select it
        _list.Items.Add(New ReportHolder(rpt))
        _list.SelectedIndex = _list.Items.Count - 1

        ' done
        _dirty = True
        UpdateUI()
    End Sub

    ' get the name of the first table in the given connection
    Private Function GetFirstTable(ByVal connString As String) As String
        Dim conn As New OleDbConnection(connString)
        Try
            ' get schema
            conn.Open()
            Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim dr As DataRow
            For Each dr In dt.Rows
                ' check the table type
                Dim type As String = dr("TABLE_TYPE").ToString().ToUpper()
                If (type <> "TABLE" AndAlso type <> "VIEW" AndAlso type <> "LINK") Then
                    ' skip this one
                Else
                    ' get the table name
                    tableName = dr("TABLE_NAME").ToString()
                    Exit For
                End If
            Next

            ' done
            conn.Close()

        Catch
        End Try

        ' return the first table we found
        Return tableName
    End Function

    ' remove current report from the list
    Private Sub DeleteReport()

        ' a report must be selected
        Dim index As Integer = _list.SelectedIndex
        If (index < 0) Then Return

        ' remove report from the designer and from the list
        _c1rd.Report = Nothing
        _list.Items.RemoveAt(index)

        ' select another report if we can
        If (index > _list.Items.Count - 1) Then
            index = _list.Items.Count - 1
            If (index > -1) Then
                _list.SelectedIndex = index
            End If
        End If

        ' done
        _dirty = True
        UpdateUI()
    End Sub

    Dim _ctr As Integer
    Private Sub _c1rd_CreateField(ByVal sender As Object, ByVal e As C1.Win.C1ReportDesigner.CreateFieldEventArgs) Handles _c1rd.CreateField

        ' save undo info
        _c1rd.UndoStack.SaveState()

        ' add label field
        _ctr = _ctr + 1
        Dim fieldName As String = String.Format("NewField{0}", _ctr)
        Dim fieldText As String = fieldName
        Dim f As Field = e.Section.Fields.Add(fieldName, fieldText, e.FieldBounds)


        ' if this is a calculated field, 
        ' change the Text and Calculated properties
        If e.CreateFieldInfo.Equals(_btnAddField) Then

            Dim fieldNames As String() = _c1rd.Report.DataSource.GetDBFieldList(True)
            If (fieldNames.Length > 0) Then

                f.Text = fieldNames(0)
                f.Calculated = True
            End If
        End If
    End Sub
End Class

' ReportHolder
' Helper class used to store reports in listboxes. The main thing
' it does is override the ToString() method to render the report name.
Public Class ReportHolder

    Public Sub New(ByVal report As C1Report)
        Me.Report = report
    End Sub

    Public Overrides Function ToString() As String
        Dim text As String = Me.Report.ReportName
        If text.Length = 0 Then text = "Unnamed Report"
        Return text
    End Function

    Public ReadOnly Report As C1Report
End Class
