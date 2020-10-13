Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports System.Data.OleDb
Imports System.IO
Imports C1.C1Report
Imports C1.Win.C1Chart

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        CorrectConnectionString(c1r)
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents _imgList As System.Windows.Forms.ImageList
    Friend WithEvents c1r As C1.C1Report.C1Report
    Friend WithEvents tbPreview As System.Windows.Forms.ToolBar
    Private WithEvents btnRenderReport As System.Windows.Forms.ToolBarButton
    Private WithEvents btnSep1 As System.Windows.Forms.ToolBarButton
    Private WithEvents btnFirst As System.Windows.Forms.ToolBarButton
    Private WithEvents btnPrev As System.Windows.Forms.ToolBarButton
    Private WithEvents btnNext As System.Windows.Forms.ToolBarButton
    Private WithEvents btnLast As System.Windows.Forms.ToolBarButton
    Private WithEvents btnSep2 As System.Windows.Forms.ToolBarButton
    Private WithEvents btnActual As System.Windows.Forms.ToolBarButton
    Private WithEvents btnOnePage As System.Windows.Forms.ToolBarButton
    Friend WithEvents btnTwoPages As System.Windows.Forms.ToolBarButton
    Private WithEvents btnSep3 As System.Windows.Forms.ToolBarButton
    Private WithEvents chartType As System.Windows.Forms.ComboBox
    Private WithEvents ppv As C1.Win.C1Preview.C1PreviewPane
    Private WithEvents c1Chart As C1.Win.C1Chart.C1Chart
    Friend WithEvents btnPrintReport As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me._imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.c1r = New C1.C1Report.C1Report
        Me.tbPreview = New System.Windows.Forms.ToolBar
        Me.btnRenderReport = New System.Windows.Forms.ToolBarButton
        Me.btnPrintReport = New System.Windows.Forms.ToolBarButton
        Me.btnSep1 = New System.Windows.Forms.ToolBarButton
        Me.btnFirst = New System.Windows.Forms.ToolBarButton
        Me.btnPrev = New System.Windows.Forms.ToolBarButton
        Me.btnNext = New System.Windows.Forms.ToolBarButton
        Me.btnLast = New System.Windows.Forms.ToolBarButton
        Me.btnSep2 = New System.Windows.Forms.ToolBarButton
        Me.btnActual = New System.Windows.Forms.ToolBarButton
        Me.btnOnePage = New System.Windows.Forms.ToolBarButton
        Me.btnTwoPages = New System.Windows.Forms.ToolBarButton
        Me.btnSep3 = New System.Windows.Forms.ToolBarButton
        Me.chartType = New System.Windows.Forms.ComboBox
        Me.ppv = New C1.Win.C1Preview.C1PreviewPane
        Me.c1Chart = New C1.Win.C1Chart.C1Chart
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        '_imgList
        '
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        Me._imgList.Images.SetKeyName(0, "")
        Me._imgList.Images.SetKeyName(1, "")
        Me._imgList.Images.SetKeyName(2, "")
        Me._imgList.Images.SetKeyName(3, "")
        Me._imgList.Images.SetKeyName(4, "")
        Me._imgList.Images.SetKeyName(5, "")
        Me._imgList.Images.SetKeyName(6, "")
        Me._imgList.Images.SetKeyName(7, "")
        Me._imgList.Images.SetKeyName(8, "")
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        Me.c1r.ReportName = "Sales by Category"
        '
        'tbPreview
        '
        Me.tbPreview.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.tbPreview.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.btnRenderReport, Me.btnPrintReport, Me.btnSep1, Me.btnFirst, Me.btnPrev, Me.btnNext, Me.btnLast, Me.btnSep2, Me.btnActual, Me.btnOnePage, Me.btnTwoPages, Me.btnSep3})
        Me.tbPreview.DropDownArrows = True
        Me.tbPreview.ImageList = Me._imgList
        Me.tbPreview.Location = New System.Drawing.Point(0, 0)
        Me.tbPreview.Name = "tbPreview"
        Me.tbPreview.ShowToolTips = True
        Me.tbPreview.Size = New System.Drawing.Size(531, 27)
        Me.tbPreview.TabIndex = 0
        '
        'btnRenderReport
        '
        Me.btnRenderReport.ImageIndex = 0
        Me.btnRenderReport.Name = "btnRenderReport"
        Me.btnRenderReport.ToolTipText = "Render the Report"
        '
        'btnPrintReport
        '
        Me.btnPrintReport.ImageIndex = 1
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.ToolTipText = "Print the Report"
        '
        'btnSep1
        '
        Me.btnSep1.Name = "btnSep1"
        Me.btnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnFirst
        '
        Me.btnFirst.ImageIndex = 3
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.ToolTipText = "First Page"
        '
        'btnPrev
        '
        Me.btnPrev.ImageIndex = 7
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.ToolTipText = "Previous Page"
        '
        'btnNext
        '
        Me.btnNext.ImageIndex = 5
        Me.btnNext.Name = "btnNext"
        Me.btnNext.ToolTipText = "Next Page"
        '
        'btnLast
        '
        Me.btnLast.ImageIndex = 4
        Me.btnLast.Name = "btnLast"
        Me.btnLast.ToolTipText = "Last Page"
        '
        'btnSep2
        '
        Me.btnSep2.Name = "btnSep2"
        Me.btnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnActual
        '
        Me.btnActual.ImageIndex = 2
        Me.btnActual.Name = "btnActual"
        Me.btnActual.ToolTipText = "Actual Size"
        '
        'btnOnePage
        '
        Me.btnOnePage.ImageIndex = 6
        Me.btnOnePage.Name = "btnOnePage"
        Me.btnOnePage.ToolTipText = "One Page"
        '
        'btnTwoPages
        '
        Me.btnTwoPages.ImageIndex = 8
        Me.btnTwoPages.Name = "btnTwoPages"
        Me.btnTwoPages.ToolTipText = "Two Pages"
        '
        'btnSep3
        '
        Me.btnSep3.Name = "btnSep3"
        Me.btnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'chartType
        '
        Me.chartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chartType.Items.AddRange(New Object() {"Bar", "Line", "Area"})
        Me.chartType.Location = New System.Drawing.Point(264, 2)
        Me.chartType.Name = "chartType"
        Me.chartType.Size = New System.Drawing.Size(121, 21)
        Me.chartType.TabIndex = 1
        '
        'ppv
        '
        Me.ppv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ppv.Location = New System.Drawing.Point(0, 27)
        Me.ppv.Name = "ppv"
        Me.ppv.Size = New System.Drawing.Size(531, 380)
        Me.ppv.TabIndex = 2
        '
        'c1Chart
        '
        Me.c1Chart.BackColor = System.Drawing.Color.White
        Me.c1Chart.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.c1Chart.Location = New System.Drawing.Point(64, 40)
        Me.c1Chart.Name = "c1Chart"
        Me.c1Chart.PropBag = resources.GetString("c1Chart.PropBag")
        Me.c1Chart.Size = New System.Drawing.Size(408, 312)
        Me.c1Chart.TabIndex = 14
        Me.c1Chart.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(531, 407)
        Me.Controls.Add(Me.c1Chart)
        Me.Controls.Add(Me.ppv)
        Me.Controls.Add(Me.chartType)
        Me.Controls.Add(Me.tbPreview)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Report Sample: Report with embedded charts (c1Chart)"
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' data table containing the report data
    ' we load this only once, when the app starts
    Dim dataTable As New dataTable()

    Private Sub CorrectConnectionString(ByVal rep As C1.C1Report.C1Report)
        Dim cs As String = rep.DataSource.ConnectionString
        If (IsNothing(cs)) Then
            Return
        End If

        '
        Dim i As Integer = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase)
        If (i < 0) Then
            Return
        End If
        While (i < cs.Length And cs(i) <> "=")
            i = i + 1
        End While
        If (i >= cs.Length) Then
            Return
        End If

        Dim j As Integer = i
        While (i < cs.Length And cs(i) <> ";")
            i = i + 1
        End While

        '
        Dim mdbName As String = cs.Substring(j + 1, i - j - 1).Trim()
        If (mdbName.Length <= 0) Then
            Return
        End If
        mdbName = System.IO.Path.GetFileName(mdbName)
        If (String.Compare(mdbName, "nwind.mdb", True) = 0) Then
            mdbName = "c1nwind.mdb"
        End If

        '
        cs = cs.Substring(0, j + 1) + _
            Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
            "\ComponentOne Samples\Common\" + _
            mdbName + _
            cs.Substring(i)

        rep.DataSource.ConnectionString = cs

        '
        For i = 0 To rep.Fields.Count - 1 Step 1
            If (Not IsNothing(rep.Fields(i).Subreport)) Then
                CorrectConnectionString(rep.Fields(i).Subreport)
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' load data
        Dim rs As String = "select * from [" + _c1r.DataSource.RecordSource + "]"
        Dim conn As String = _c1r.DataSource.ConnectionString
        Dim da As New OleDbDataAdapter(rs, conn)
        Cursor = Cursors.WaitCursor
        da.Fill(dataTable)
        Cursor = Cursors.Default

        ' assign data source to report
        ' (this is not strictly necessary, but it makes the application 
        ' faster because the control doesn't have to re-fetch the data 
        ' each time it renders the report)
        c1r.DataSource.Recordset = dataTable

        ' select first chart type
        chartType.SelectedIndex = 0

    End Sub

    Private Sub chartType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chartType.SelectedIndexChanged
        RenderReport()
    End Sub

    Private Sub RenderReport()

        ' prevent reentrant calls
        If (Me.c1r.IsBusy) Then
            Return
        End If

        'render report with chart
        c1r.Render()
        ppv.Document = c1r

    End Sub

    Private Sub c1r_PrintSection(ByVal sender As Object, ByVal e As C1.C1Report.ReportEventArgs) Handles c1r.PrintSection

        ' get the field we want
        Dim theField As Field = c1r.Fields("SalesChart")

        ' make sure this is the section we want
        If e.Section <> theField.Section Then
            Return
        End If

        ' create chart image for this section
        Dim chartData As New DataView(dataTable)

        ' filter chart data for the current category
        chartData.RowFilter = "CategoryName = '" + c1r.Evaluate("CategoryName") + "'"

        ' create chart 
        Dim img As Image = BuildChart(chartData)

        ' add chart image to field
        theField.Picture = img
        theField.Text = String.Empty

        ' done with chart data view
        chartData.Dispose()

    End Sub

    Private Function BuildChart(ByVal data As DataView) As Image

        ' select chart type
        Select Case (chartType.Text)
            Case "Area"
                c1Chart.ChartGroups(0).ChartType = Chart2DTypeEnum.Area
                With c1Chart.ChartArea
                    .Inverted = False
                    .AxisX.AnnotationRotation = 45
                End With
            Case "Bar"
                c1Chart.ChartGroups(0).ChartType = Chart2DTypeEnum.Bar
                With c1Chart.ChartArea
                    .Inverted = True
                    .AxisX.AnnotationRotation = 0
                End With
            Case Else
                c1Chart.ChartGroups(0).ChartType = Chart2DTypeEnum.XYPlot
                With c1Chart.ChartArea
                    .Inverted = False
                    .AxisX.AnnotationRotation = 45
                End With
        End Select

        ' add data to the chart
        Dim points As PointF() = CType(Array.CreateInstance(GetType(PointF), data.Count), PointF())
        Dim i As Integer = 0
        For i = 0 To (data.Count - 1)
            points(i).X = i
            points(i).Y = Single.Parse(data(i)("ProductSales").ToString())
        Next
        c1Chart.ChartGroups(0).ChartData.SeriesList(0).PointData.CopyDataIn(points)

        ' add X labels to the chart
        With c1Chart.ChartArea.AxisX
            .ValueLabels.Clear()
            For i = 0 To (data.Count - 1)
                .ValueLabels.Add(i, data(i)("ProductName").ToString())
            Next
            .AnnoMethod = AnnotationMethodEnum.ValueLabels
        End With

        ' return chart image
        Return c1Chart.GetImage(ImageFormat.Emf)

    End Function

    Private Sub tbPreview_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbPreview.ButtonClick

        ' render report
        If e.Button Is btnRenderReport Then
            RenderReport()

            ' print report
        ElseIf e.Button Is btnPrintReport Then
            c1r.Document.Print()

            ' navigate
        ElseIf e.Button Is btnFirst Then
            Me.ppv.StartPageIdx = 0
        ElseIf e.Button Is btnLast Then
            Me.ppv.StartPageIdx = 100000
        ElseIf e.Button Is btnPrev Then
            Me.ppv.StartPageIdx += 1
        ElseIf e.Button Is btnNext Then
            Me.ppv.StartPageIdx -= 1

            ' zoom
        ElseIf e.Button Is btnActual Then
            With Me.ppv
                .ZoomFactor = 1
                .Cols = 1
            End With
        ElseIf e.Button Is btnOnePage Then
            With Me.ppv
                .ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
                .Cols = 1
            End With
        ElseIf e.Button Is btnTwoPages Then
            With Me.ppv
                .ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
                .Cols = 2
            End With
        End If
    End Sub
End Class
