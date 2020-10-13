Option Explicit On
Option Strict On

Imports System
Imports System.ComponentModel
Imports C1.C1Preview
Imports C1.C1Report
Imports C1.Win.C1Preview
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Command

Partial Public Class C1dViewForm
    Inherits C1.Win.C1Ribbon.C1RibbonForm

    ''' <summary>
    ''' Window caption when no file is loaded.
    ''' </summary>
    Protected Shared Property WindowTitle As String

    ''' <summary>
    ''' Window caption format showing file/report name.
    ''' </summary>
    Protected Shared Property WindowTitleFormat As String

    ''' <summary>
    ''' Static list of the currently open C1dViewForm forms.
    ''' </summary>
    Protected Shared s_openWindows As List(Of C1dViewForm) = New List(Of C1dViewForm)

#If C1DVIEW_APP Then
#Region "Main procedure"
    Public Shared Sub Main(ByVal args As String())

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        '' method to make first form:
        Dim MakeFirstForm As Func(Of C1dViewForm) = _
            Function()
                Dim viewer = New C1dViewForm()
                C1dViewSettings.Load(viewer)
                viewer.Show()
                Return viewer
            End Function
        '' show all needed forms:
        If (args IsNot Nothing AndAlso args.Length > 0) Then
            Dim viewer As C1dViewForm = Nothing
            For i As Integer = 0 To args.Length - 1
                If (i = 0) Then
                    viewer = MakeFirstForm()
                    viewer.FileOpen(args(i))
                Else
                    '' open next file off last viewer to "cascade" windows:
                    viewer = If(viewer.FileNew(args(i)), viewer)
                End If
            Next
        Else
            MakeFirstForm()
        End If
        '' no "main" form - the last one alive will be the main:
        Application.Run()
    End Sub

#End Region
#End If

    Shared Sub New()
        '' we want to show 32/64 bit environment as many data providers depend on it:
        If (IntPtr.Size = 4) Then
            WindowTitle = "C1dView32"
            WindowTitleFormat = "{0} - C1dView32"
        ElseIf (IntPtr.Size = 8) Then
            WindowTitle = "C1dView64"
            WindowTitleFormat = "{0} - C1dView64"
        Else
            System.Diagnostics.Debug.Assert(False, "We are not in Kansas anymore, Toto")
        End If
    End Sub

    Public Sub New()
        ' me call is required by the designer.
        InitializeComponent()

        ''
        '' Set up window title:
        Me.Text = WindowTitle
        ''
        '' Most of preview commands are wired up here:
        InitPreviewCommands()
        '' 
        '' Initialize text find bar and related commands:
        InitFind()
        '' 
        '' Initialize recent files list:
        InitRecentDocuments()
        '' 
        '' Keep track of open C1dViewForm's:
        s_openWindows.Add(Me)
    End Sub

    Protected Overrides Sub OnLoad(e As System.EventArgs)
        MyBase.OnLoad(e)
        '' Show thumbnails panel initially, focus in preview pane, and ensure consistent UI state:
        dtpPages.Show()
        PreviewPane.Focus()
        RefreshUI()
    End Sub

    Protected Overrides Sub OnFormClosed(e As System.Windows.Forms.FormClosedEventArgs)
        MyBase.OnFormClosed(e)
        s_openWindows.Remove(Me)
#If C1DVIEW_APP Then
        If (s_openWindows.Count = 0) Then
            C1dViewSettings.Save(Me)
            Application.Exit()
        End If
#End If
    End Sub

#Region "Public properties"
    ''' <summary>
    ''' Gets or sets the document shown by the preview.
    ''' me is just a shortcut to PreviewPane.Document.
    ''' </summary>
    <System.ComponentModel.Browsable(False)>
    Public Property Document As Object
        Get
            Return _pview.Document
        End Get
        Set(value As Object)
            _pview.Document = value
        End Set
    End Property

    ''' <summary>
    ''' Gets the C1PreviewPane control.
    ''' </summary>
    Public ReadOnly Property PreviewPane As C1PreviewPane
        Get
            Return _pview
        End Get
    End Property

    ''' <summary>
    ''' Gets the name of the currently loaded file, or null.
    ''' </summary>
    Public Property FileName As String ''qq - private set

    ''' <summary>
    ''' Gets the name of the currently loaded report, or null.
    ''' </summary>
    Public Property ReportName As String ''qq - private set
#End Region

End Class
