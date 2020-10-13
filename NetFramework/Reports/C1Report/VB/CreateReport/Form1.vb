Imports System.Xml
Imports System.IO
Imports C1.C1Report

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
    Friend WithEvents chkGroup As System.Windows.Forms.CheckBox
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnCustomers As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ppv As C1.Win.C1Preview.C1PreviewPane
    Friend WithEvents tbbtnFirst As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrev As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnNext As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnLast As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnZoom As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuZoom As System.Windows.Forms.ContextMenu
    Friend WithEvents mz100 As System.Windows.Forms.MenuItem
    Friend WithEvents mzPage As System.Windows.Forms.MenuItem
    Friend WithEvents mzTwoPages As System.Windows.Forms.MenuItem
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents mzThumbnails As System.Windows.Forms.MenuItem
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents c1r As C1.C1Report.C1Report

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnEmployees = New System.Windows.Forms.Button
        Me.btnCustomers = New System.Windows.Forms.Button
        Me.chkGroup = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ppv = New C1.Win.C1Preview.C1PreviewPane
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.tbbtnFirst = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrev = New System.Windows.Forms.ToolBarButton
        Me.tbbtnNext = New System.Windows.Forms.ToolBarButton
        Me.tbbtnLast = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep = New System.Windows.Forms.ToolBarButton
        Me.tbbtnZoom = New System.Windows.Forms.ToolBarButton
        Me.mnuZoom = New System.Windows.Forms.ContextMenu
        Me.mz100 = New System.Windows.Forms.MenuItem
        Me.mzPage = New System.Windows.Forms.MenuItem
        Me.mzTwoPages = New System.Windows.Forms.MenuItem
        Me.mzThumbnails = New System.Windows.Forms.MenuItem
        Me.status = New System.Windows.Forms.StatusBar
        Me.btnSave = New System.Windows.Forms.Button
        Me.c1r = New C1.C1Report.C1Report
        Me.Panel1.SuspendLayout()
        CType(Me.ppv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEmployees
        '
        Me.btnEmployees.Location = New System.Drawing.Point(8, 8)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(80, 24)
        Me.btnEmployees.TabIndex = 0
        Me.btnEmployees.Text = "Employees"
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(96, 8)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(80, 24)
        Me.btnCustomers.TabIndex = 1
        Me.btnCustomers.Text = "Customers"
        '
        'chkGroup
        '
        Me.chkGroup.Location = New System.Drawing.Point(200, 12)
        Me.chkGroup.Name = "chkGroup"
        Me.chkGroup.Size = New System.Drawing.Size(96, 16)
        Me.chkGroup.TabIndex = 2
        Me.chkGroup.Text = "Add Groups"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ppv)
        Me.Panel1.Controls.Add(Me.ToolBar1)
        Me.Panel1.Location = New System.Drawing.Point(8, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 375)
        Me.Panel1.TabIndex = 4
        '
        'ppv
        '
        Me.ppv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ppv.Location = New System.Drawing.Point(0, 36)
        Me.ppv.Name = "ppv"
        Me.ppv.Size = New System.Drawing.Size(434, 335)
        Me.ppv.TabIndex = 6
        Me.ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.ActualSize
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFirst, Me.tbbtnPrev, Me.tbbtnNext, Me.tbbtnLast, Me.tbbtnSep, Me.tbbtnZoom})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(0, 22)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(434, 36)
        Me.ToolBar1.TabIndex = 5
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        Me.ToolBar1.Wrappable = False
        '
        'tbbtnFirst
        '
        Me.tbbtnFirst.Name = "tbbtnFirst"
        Me.tbbtnFirst.Text = "<<"
        '
        'tbbtnPrev
        '
        Me.tbbtnPrev.Name = "tbbtnPrev"
        Me.tbbtnPrev.Text = "<"
        '
        'tbbtnNext
        '
        Me.tbbtnNext.Name = "tbbtnNext"
        Me.tbbtnNext.Text = ">"
        '
        'tbbtnLast
        '
        Me.tbbtnLast.Name = "tbbtnLast"
        Me.tbbtnLast.Text = ">>"
        '
        'tbbtnSep
        '
        Me.tbbtnSep.Name = "tbbtnSep"
        Me.tbbtnSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnZoom
        '
        Me.tbbtnZoom.DropDownMenu = Me.mnuZoom
        Me.tbbtnZoom.Name = "tbbtnZoom"
        Me.tbbtnZoom.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tbbtnZoom.Text = "Zoom"
        '
        'mnuZoom
        '
        Me.mnuZoom.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mz100, Me.mzPage, Me.mzTwoPages, Me.mzThumbnails})
        '
        'mz100
        '
        Me.mz100.Index = 0
        Me.mz100.Text = "100%"
        '
        'mzPage
        '
        Me.mzPage.Index = 1
        Me.mzPage.Text = "Full Page"
        '
        'mzTwoPages
        '
        Me.mzTwoPages.Index = 2
        Me.mzTwoPages.Text = "Two Pages"
        '
        'mzThumbnails
        '
        Me.mzThumbnails.Index = 3
        Me.mzThumbnails.Text = "Thumbnails"
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(0, 422)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(454, 22)
        Me.status.TabIndex = 5
        Me.status.Text = "Ready"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(304, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(454, 444)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkGroup)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Report: On-the-fly Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ppv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is tbbtnFirst Then
            ppv.StartPageIdx = 0
        ElseIf e.Button Is tbbtnLast Then
            ppv.StartPageIdx = 10000
        ElseIf e.Button Is tbbtnPrev Then
            ppv.StartPageIdx -= 1
        ElseIf e.Button Is tbbtnNext Then
            ppv.StartPageIdx += 1
        ElseIf e.Button Is tbbtnZoom Then
            ppv.Rows = 1
            ppv.Cols = 1
            If ppv.ZoomFactor = 1 Then
                ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
            Else
                ppv.ZoomFactor = 1
            End If
        End If

    End Sub

    Private Sub mz100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mz100.Click
        ppv.Rows = 1
        ppv.Cols = 1
        ppv.ZoomFactor = 1
    End Sub
    Private Sub mzPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mzPage.Click
        ppv.Rows = 1
        ppv.Cols = 1
        ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
    End Sub
    Private Sub mzTwoPages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mzTwoPages.Click
        ppv.Rows = 1
        ppv.Cols = 2
        ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
    End Sub
    Private Sub mzThumbnails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mzThumbnails.Click
        ppv.Rows = 3
        ppv.Cols = 4
        ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
    End Sub

    Private Sub btnEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployees.Click
        Try
            status.Text = "Rendering Employees"
            Cursor = Cursors.WaitCursor
            RenderEmployees()
        Finally
            Cursor = Cursors.Default
            status.Text = "Ready"
        End Try
    End Sub

    Private Sub btnCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomers.Click
        Try
            status.Text = "Rendering Customers"
            Cursor = Cursors.WaitCursor
            RenderCustomers()
        Finally
            Cursor = Cursors.Default
            status.Text = "Ready"
        End Try
    End Sub

    Private Sub RenderEmployees()
        Dim f As Field

        ' prevent reentrant calls
        If c1r.IsBusy Then Beep() : Exit Sub

        ' initialize control
        With c1r
            .Clear()                ' clear any existing fields
            .Font.Name = "Tahoma"   ' set default font for all controls
            .Font.Size = 9
            .ReportName = "Employees"
        End With

        ' initialize DataSource
        With c1r.DataSource
            .ConnectionString = _
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
                "\ComponentOne Samples\Common\c1nwind.mdb"
            .RecordSource = "Employees"
        End With

        ' initialize Layout
        With c1r.Layout
            .Orientation = OrientationEnum.Portrait
            .Width = 6.5 * 1440     ' 8.5 - margins
        End With

        ' create a report header
        With c1r.Sections(SectionTypeEnum.Header)
            .Height = 1440
            .Visible = True
            .BackColor = Color.FromArgb(200, 200, 200)
            f = .Fields.Add("FldTitle", "Employees Report", 0, 0, 8000, 1440)
            f.Font.Size = 24
            f.Font.Bold = True
            f.ForeColor = Color.FromArgb(0, 0, 100)
        End With

        ' create a page footer
        With c1r.Sections(SectionTypeEnum.PageFooter)
            .Height = 500
            .Visible = True
            f = .Fields.Add("FldFtrLeft", """Employees: Printed on "" & Now", 0, 0, 4000, 300)
            f.Calculated = True
            f = .Fields.Add("FldFtrRight", """Page "" & Page & "" of "" & Pages", 4000, 0, 4000, 300)
            f.Calculated = True
            f.Align = FieldAlignEnum.RightTop
            f.Width = c1r.Layout.Width - f.Left
            f = .Fields.Add("FldLine", "", 0, 0, c1r.Layout.Width, 20)
            f.LineSlant = LineSlantEnum.NoSlant
            f.BorderStyle = BorderStyleEnum.Solid
            f.BorderColor = Color.FromArgb(0, 0, 100)
        End With

        ' create a page header with field labels
        With c1r.Sections(SectionTypeEnum.PageHeader)
            .Height = 500
            .Visible = True
            c1r.Font.Bold = True
            f = .Fields.Add("LblID", "ID", 0, 50, 400, 300)
            f.Align = FieldAlignEnum.RightTop
            f = .Fields.Add("LblFirstName", "First", 500, 50, 900, 300)
            f = .Fields.Add("LblLastName", "Last", 1500, 50, 900, 300)
            f = .Fields.Add("LblTitle", "Title", 2500, 50, 2400, 300)
            f = .Fields.Add("LblTitle", "Notes", 5000, 50, 8000, 300)
            c1r.Font.Bold = False
            f = .Fields.Add("FldLine", "", 0, 400, c1r.Layout.Width, 20)
            f.LineSlant = LineSlantEnum.NoSlant
            f.LineWidth = 50
            f.BorderStyle = BorderStyleEnum.Solid
            f.BorderColor = Color.FromArgb(100, 100, 100)
        End With

        ' create the detail section
        With c1r.Sections(SectionTypeEnum.Detail)
            .Height = 330
            .Visible = True
            f = .Fields.Add("FldID", "EmployeeID", 0, 0, 400, 300)
            f.Calculated = True
            f = .Fields.Add("FldFirstName", "FirstName", 500, 0, 900, 300)
            f.Calculated = True
            f = .Fields.Add("FldLastName", "LastName", 1500, 0, 900, 300)
            f.Calculated = True
            f = .Fields.Add("FldTitle", "Title", 2500, 0, 2400, 300)
            f.Calculated = True
            f = .Fields.Add("FldNotes", "Notes", 5000, 0, 8000, 300)
            f.Width = c1r.Layout.Width - f.Left
            f.Calculated = True
            f.CanGrow = True
            f.Font.Size = 6
            f.Align = FieldAlignEnum.JustTop
            f = .Fields.Add("FldLine", "", 0, 310, c1r.Layout.Width, 20)
            f.LineSlant = LineSlantEnum.NoSlant
            f.BorderStyle = BorderStyleEnum.Solid
            f.BorderColor = Color.FromArgb(100, 100, 100)
        End With

        If chkGroup.Checked Then

            ' group employees by country, in ascending order
            Dim grp As Group
            grp = c1r.Groups.Add("GrpCountry", "Country", SortEnum.Ascending)
            With grp.SectionHeader
                .Height = 500
                .Visible = True
                f = .Fields.Add("CtlCountry", "Country", 0, 0, c1r.Layout.Width, 500)
                f.Calculated = True
                f.Align = FieldAlignEnum.LeftMiddle
                f.Font.Bold = True
                f.Font.Size = 12
                f.BorderStyle = BorderStyleEnum.Solid
                f.BorderColor = Color.FromArgb(0, 0, 150)
                f.BackStyle = BackStyleEnum.Opaque
                f.BackColor = Color.FromArgb(150, 150, 220)
                f.MarginLeft = 100
            End With

            ' sort employees by first name within each country
            c1r.Groups.Add("GrpName", "FirstName", SortEnum.Ascending)
        End If

        ' render the report into the PrintPreviewControl
        ppv.Document = c1r

    End Sub

    Private Sub RenderCustomers()
        Dim f As Field

        ' prevent reentrant calls
        If c1r.IsBusy Then Beep() : Exit Sub

        ' initialize control
        With c1r
            .Clear()                 ' clear any existing fields
            .Font.Name = "Tahoma"    ' set default font for all controls
            .Font.Size = 8
            .ReportName = "Customers"
        End With

        ' initialize DataSource
        With c1r.DataSource
            .ConnectionString = _
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
                "\ComponentOne Samples\Common\c1nwind.mdb"
            .RecordSource = "Customers"
        End With

        ' initialize Layout
        With c1r.Layout
            .Orientation = OrientationEnum.Portrait
            .Width = 6.5 * 1440     ' 8.5 - margins
        End With

        ' create a report header
        With c1r.Sections(SectionTypeEnum.Header)
            .Height = 1440
            .Visible = True
            .BackColor = Color.FromArgb(200, 200, 200)
            f = .Fields.Add("FldTitle", "Customer Report", 0, 0, 8000, 1440)
            f.Font.Size = 24
            f.Font.Bold = True
            f.ForeColor = Color.FromArgb(100, 0, 0)
        End With

        ' create a page footer
        With c1r.Sections(SectionTypeEnum.PageFooter)
            .Height = 500
            .Visible = True
            f = .Fields.Add("FldFtrLeft", """Customers: Printed on "" & Now", 0, 0, 4000, 300)
            f.Calculated = True
            f = .Fields.Add("FldFtrRight", """Page "" & Page & "" of "" & Pages", 4000, 0, 4000, 300)
            f.Calculated = True
            f.Align = FieldAlignEnum.RightTop
            f.Width = c1r.Layout.Width - f.Left
            f = .Fields.Add("FldLine", "", 0, 0, c1r.Layout.Width, 20)
            f.LineSlant = LineSlantEnum.NoSlant
            f.BorderStyle = BorderStyleEnum.Solid
            f.BorderColor = Color.FromArgb(0, 0, 100)
        End With

        ' create a page header with field labels
        With c1r.Sections(SectionTypeEnum.PageHeader)
            .Height = 500
            .Visible = True
            c1r.Font.Bold = True
            f = .Fields.Add("LblID", "Company", 0, 100, 3400, 300)
            f = .Fields.Add("LblFirstName", "Contact", 3500, 100, 1900, 300)
            f = .Fields.Add("LblFirstName", "Contact Title", 5500, 100, 1900, 300)
            f = .Fields.Add("LblLastName", "Phone", 7500, 100, 1200, 300)
            c1r.Font.Bold = False
            f = .Fields.Add("FldLine", "", 0, 400, c1r.Layout.Width, 20)
            f.LineSlant = LineSlantEnum.NoSlant
            f.LineWidth = 50
            f.BorderStyle = BorderStyleEnum.Solid
            f.BorderColor = Color.FromArgb(100, 100, 100)
        End With

        ' create the detail section
        With c1r.Sections(SectionTypeEnum.Detail)
            .Height = 250
            .Visible = True
            f = .Fields.Add("FldID", "CompanyName", 0, 0, 3400, 250)
            f.Calculated = True
            f = .Fields.Add("FldFirstName", "ContactName", 3500, 0, 1900, 250)
            f.Calculated = True
            f = .Fields.Add("FldFirstName", "ContactTitle", 5500, 0, 1900, 250)
            f.Calculated = True
            f = .Fields.Add("FldLastName", "Phone", 7500, 0, 1200, 250)
            f.Calculated = True
        End With

        If chkGroup.Checked Then

            ' group customers by country, in ascending order
            Dim grp As Group
            grp = c1r.Groups.Add("GrpCountry", "Country", SortEnum.Ascending)
            With grp.SectionHeader
                .Height = 500
                .Visible = True
                f = .Fields.Add("CtlCountry", "Country", 0, 0, c1r.Layout.Width, 500)
                f.Calculated = True
                f.Align = FieldAlignEnum.LeftMiddle
                f.Font.Bold = True
                f.Font.Size = 12
                f.BorderStyle = BorderStyleEnum.Solid
                f.BorderColor = Color.FromArgb(0, 0, 150)
                f.BackStyle = BackStyleEnum.Opaque
                f.BackColor = Color.FromArgb(150, 150, 220)
                f.MarginLeft = 100
            End With

            ' sort customers by name within each country
            c1r.Groups.Add("GrpName", "CompanyName", SortEnum.Ascending)
        End If

        ' render the report into the PrintPreviewControl
        ppv.Document = c1r

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        ' open xml file
        Dim fileName As String = _
            Path.GetDirectoryName(Application.ExecutablePath) + _
            "\MyReports.xml"
        Dim writer As XmlTextWriter = New XmlTextWriter(fileName, System.Text.Encoding.Default)

        ' initialize xml file
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartDocument()
        writer.WriteStartElement("Reports")

        ' save Customers report
        RenderCustomers()
        c1r.ReportName = "Customers"
        c1r.Save(writer)

        ' save Employees report
        RenderEmployees()
        c1r.ReportName = "Employees"
        c1r.Save(writer)

        ' close xml file
        writer.WriteEndElement()
        writer.Close()

    End Sub
End Class
