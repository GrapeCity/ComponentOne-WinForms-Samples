Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace CustomDataMap
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

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
            CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            '_flex
            '
            Me._flex.BackColor = System.Drawing.SystemColors.Window
            Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
            Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
            Me._flex.Name = "_flex"
            Me._flex.Size = New System.Drawing.Size(292, 273)
            Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
            "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
            ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
            "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
            "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
            ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
            ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
            "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
            "or:White;}" & Microsoft.VisualBasic.ChrW(9))
            Me._flex.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(292, 273)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex})
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "C1FlexGrid: Custom DataMap"
            CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region
        Public Enum RegionEnum As Integer
            North
            South
            East
            West
        End Enum
        Public Enum JobEnum As Integer
            Director
            Manager
            Accountant
            Engineer
            Sales
            Clerical
        End Enum

        Dim _jobsPerRegion As Hashtable
        Dim _mapJobs As ListDictionary
        Dim _mapRegions As ListDictionary


        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'create table to select which jobs exist in each region
            _jobsPerRegion = New Hashtable()
            _jobsPerRegion.Add(RegionEnum.North, New JobEnum() {JobEnum.Director, JobEnum.Manager, JobEnum.Accountant, JobEnum.Engineer, JobEnum.Sales, JobEnum.Clerical})
            _jobsPerRegion.Add(RegionEnum.South, New JobEnum() {JobEnum.Manager, JobEnum.Accountant, JobEnum.Sales})
            _jobsPerRegion.Add(RegionEnum.East, New JobEnum() {JobEnum.Manager, JobEnum.Engineer, JobEnum.Clerical})
            _jobsPerRegion.Add(RegionEnum.West, New JobEnum() {JobEnum.Accountant, JobEnum.Sales, JobEnum.Clerical})

            'create DataMaps (not needed for enums, but this is a sample...=)
            _mapRegions = New ListDictionary()
            Dim region As RegionEnum
            For Each region In System.Enum.GetValues(region.GetType())
                _mapRegions.Add(region, System.Enum.GetName(region.GetType(), region))
            Next

            _mapJobs = New ListDictionary()
            Dim job As JobEnum = 0
            For Each job In System.Enum.GetValues(job.GetType())
                _mapJobs.Add(job, System.Enum.GetName(job.GetType(), job))
            Next

            'assign data maps to grid columns
            _flex.Cols(1).DataMap = _mapRegions
            _flex.Cols(1).Name = "Region"
            _flex.Cols(1).Caption = "Region"

            _flex.Cols(2).DataMap = _mapJobs
            _flex.Cols(2).Name = "Job"
            _flex.Cols(2).Caption = "Job"

        End Sub

        Private Sub _flex_BeforeEdit(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RowColEventArgs) Handles _flex.BeforeEdit
            'can't edit job if there's no region
            If _flex.Cols(e.Col).Name = "Job" Then
                If _flex(e.Row, "Region") Is Nothing Then
                    e.Cancel = True
                End If
            End If
        End Sub

        Private Sub _flex_SetupEditor(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.RowColEventArgs) Handles _flex.SetupEditor
            'before editing the job, remove items that don't apply to the current region
            If _flex.Cols(e.Col).Name = "Job" Then
                Dim cb As ComboBox = CType(_flex.Editor, ComboBox)
                If Not cb Is Nothing Then
                    'get current region
                    Dim region As RegionEnum = CType(_flex(e.Row, "Region"), RegionEnum)

                    'get jobs that exist for this region
                    Dim jobs As JobEnum() = CType(_jobsPerRegion(region), JobEnum())

                    'populate list with jobs that apply to the current region
                    cb.Items.Clear()
                    Dim job As JobEnum
                    For Each job In jobs
                        cb.Items.Add(System.Enum.GetName(job.GetType(), job))
                    Next
                End If
            End If
        End Sub
    End Class
    


End Namespace

