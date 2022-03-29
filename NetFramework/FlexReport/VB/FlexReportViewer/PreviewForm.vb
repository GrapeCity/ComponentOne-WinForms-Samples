Imports System
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml

Imports C1.Win.Ribbon
Imports C1.Win.C1Win7Pack
Imports C1.Win.FlexReport
Imports C1.Win.FlexViewer

Public Class PreviewForm

#Region "shared members"

    Friend Const FormTitle As String = "FlexReport Viewer"
    Const DefaultThemeColor As ThemeColor = ThemeColor.Azure

    Const OpenFileDlgTitle As String = "Open Report Definition File"
    Const FileOpenFilter As String = "FlexReport Definition Files (*.flxr)|*.flxr|Legacy C1Report Definition Files (*.xml)|*.xml|All Files|*.*"
    Const FriendlyName As String = "FlexReport Definition File"
    Const DefaultIcon As String = "%systemroot%\system32\shell32.dll,284"
    Const OpenWithCommandFmt As String = """{0}"" ""%1"""
    Const SampleReportsDir As String = "\Reports"

    Shared _exePath As String
    Shared _startupFilePath As String

    Shared _isWindows10 As Boolean
    Shared _isWindows10240 As Boolean

    Shared Sub New()

        Dim ipStyle = CType(CType(DefaultThemeColor, Int32), C1.Win.C1InputPanel.ThemeColor)
        C1.Win.C1InputPanel.InputStyle.UpdateInstance(ipStyle, C1.Win.C1InputPanel.ThemeLightness.LightGray)

        Dim ov As New OSVERSIONINFO()
        ov.dwOSVersionInfoSize = Marshal.SizeOf(GetType(OSVERSIONINFO))
        RtlGetVersion(ov)
        _isWindows10 = ov.dwMajorVersion >= 10
        _isWindows10240 = ov.dwMajorVersion = 10 AndAlso ov.dwBuildNumber < 10586

        _exePath = Application.ExecutablePath

    End Sub

    Friend Shared Sub SetStartupFilePath(ByVal filePath As String)

        _startupFilePath = filePath

    End Sub

#End Region

#Region "fields"

    Private _themeColor As ThemeColor
    Private _shortcutInstalled As Boolean

    Private _recentItems As StringCollection

    Private _exportButton As RibbonButton
    Private _printButton As RibbonButton
    Private _pageSetupButton As RibbonButton
    Private _closeButton As RibbonButton
    Private _themeColorMenu As RibbonMenu

    Private _reportsCombo As RibbonComboBox
    Private _doc As XmlDocument
    Private _report As C1FlexReport

    Private _registerLabel As RibbonLabel
    Private _registered As Boolean

#End Region

#Region "New/Dispose"

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Text = FormTitle
        BuildAppMenu()

        ' A workaround for the bug with pinned items in Windows 10 build 10240.
        If _startupFilePath Is Nothing AndAlso _isWindows10240 Then
            atb.AddShortcutToStartMenu()
            _shortcutInstalled = True
        End If

        UpdateChildStyles(DefaultThemeColor, ThemeLightness.DarkGray)
        ' subscribe to color theme changes
        AddHandler RibbonStyle.StyleChanged, AddressOf RibbonStyle_StyleChanged
        RibbonStyle_StyleChanged(Me, EventArgs.Empty)

        Dim st = My.MySettings.Default

        ' A workaround for the bug with Recent Items in Windows 10 builds 10240 And 10586
        If _isWindows10 Then
            _recentItems = st.RecentItems
            If _recentItems Is Nothing Then
                _recentItems = New StringCollection()
            End If
        End If

        ' load theme color from settings
        Dim s = st.ThemeColor
        If String.IsNullOrEmpty(s) OrElse Not [Enum].TryParse(s, _themeColor) Then
            _themeColor = DefaultThemeColor
        Else
            Dim coll = _themeColorMenu.Items
            For i As Int32 = 0 To coll.Count - 1
                Dim tb = DirectCast(coll(i), RibbonToggleButton)
                If DirectCast(tb.Tag, ThemeColor) = _themeColor Then
                    tb.Pressed = True
                    Exit For
                End If
            Next
        End If

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If _shortcutInstalled Then
                atb.RemoveShortcutFromStartMenu()
                _shortcutInstalled = False
            End If
            If disposing Then
                CloseFile()
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

#End Region

#Region "build app menu"

    Private Sub BuildAppMenu()

        Dim appMenu = fv.Ribbon.ApplicationMenu
        appMenu.Visible = True
        appMenu.KeyTip = "Q"
        appMenu.SmallImage = My.Resources.Menu
        appMenu.DropDownWidth = 420
        AddHandler appMenu.DropDown, AddressOf AppMenu_DropDown

        Dim btn As New RibbonButton()
        btn.SmallImage = My.Resources.Open16x16
        btn.LargeImage = My.Resources.Open32x32
        btn.Text = "Open"
        AddHandler btn.Click, AddressOf OpenButton_Click
        appMenu.LeftPaneItems.Add(btn)

        _exportButton = New RibbonButton()
        _exportButton.Enabled = False
        _exportButton.SmallImage = My.Resources.Export16x16
        _exportButton.LargeImage = My.Resources.Export32x32
        _exportButton.Text = "Export"
        With New ButtonActionElement(fv, _exportButton, FlexViewerAction.Export)
        End With
        appMenu.LeftPaneItems.Add(_exportButton)

        appMenu.LeftPaneItems.Add(New RibbonSeparator())

        _printButton = New RibbonButton()
        _printButton.Enabled = False
        _printButton.SmallImage = My.Resources.Print16x16
        _printButton.LargeImage = My.Resources.Print32x32
        _printButton.Text = "Print"
        With New ButtonActionElement(fv, _printButton, FlexViewerAction.Print)
        End With
        appMenu.LeftPaneItems.Add(_printButton)

        _pageSetupButton = New RibbonButton()
        _pageSetupButton.Enabled = False
        _pageSetupButton.SmallImage = My.Resources.PageSetup16x16
        _pageSetupButton.LargeImage = My.Resources.PageSetup32x32
        _pageSetupButton.Text = "Page Setup"
        With New ButtonActionElement(fv, _pageSetupButton, FlexViewerAction.PageSetup)
        End With
        appMenu.LeftPaneItems.Add(_pageSetupButton)

        appMenu.LeftPaneItems.Add(New RibbonSeparator())

        _closeButton = New RibbonButton()
        _closeButton.Enabled = False
        _closeButton.SmallImage = My.Resources.Close16x16
        _closeButton.LargeImage = My.Resources.Close32x32
        _closeButton.Text = "Close"
        AddHandler _closeButton.Click, AddressOf CloseButton_Click

        appMenu.LeftPaneItems.Add(_closeButton)

        appMenu.LeftPaneItems.Add(New RibbonSeparator())

        btn = New RibbonButton()
        btn.SmallImage = My.Resources.Exit16x16
        btn.LargeImage = My.Resources.Exit32x32
        btn.Text = "Exit"
        AddHandler btn.Click, AddressOf ExitButton_Click
        appMenu.LeftPaneItems.Add(btn)

        Dim rli As New C1.Win.Ribbon.RibbonListItem()
        rli.AllowSelection = False
        rli.Items.Add(New RibbonLabel("Recent Documents"))
        appMenu.RightPaneItems.Add(rli)

        _registerLabel = New RibbonLabel()
        rli = New C1.Win.Ribbon.RibbonListItem()
        rli.Items.Add(_registerLabel)
        AddHandler rli.Click, AddressOf RegisterButton_Click
        appMenu.RightPaneItems.Add(rli)

        rli = New C1.Win.Ribbon.RibbonListItem()
        rli.AllowSelection = False
        rli.Items.Add(New RibbonSeparator())
        appMenu.RightPaneItems.Add(rli)

        _reportsCombo = New RibbonComboBox()
        _reportsCombo.Enabled = False
        _reportsCombo.GripHandleVisible = True
        _reportsCombo.KeyTip = "G"
        _reportsCombo.Label = " Select report: "
        _reportsCombo.TextAreaWidth = 170
        _reportsCombo.MaxDropDownItems = 12
        _reportsCombo.DropDownStyle = RibbonComboBoxStyle.DropDownList
        AddHandler _reportsCombo.ChangeCommitted, AddressOf ReportsCombo_SelectedIndexChanged

        Dim ti = fv.Ribbon.TopToolBar.Items
        ti.Insert(ti.Count - 2, _reportsCombo)
        fv.Ribbon.Qat.Visible = False

        _themeColorMenu = New RibbonMenu()
        _themeColorMenu.Text = "&Colors"
        fv.StatusBar.RightPaneItems.Insert(0, New RibbonSeparator())
        fv.StatusBar.RightPaneItems.Insert(0, _themeColorMenu)

        Dim coll = _themeColorMenu.Items
        AddThemeColor(coll, ThemeColor.Azure)
        AddThemeColor(coll, ThemeColor.Blue)
        AddThemeColor(coll, ThemeColor.Green)
        AddThemeColor(coll, ThemeColor.Orange)
        AddThemeColor(coll, ThemeColor.Orchid)
        AddThemeColor(coll, ThemeColor.Red)
        AddThemeColor(coll, ThemeColor.Teal)
        AddThemeColor(coll, ThemeColor.Violet)
        Dim tb = DirectCast(coll(0), RibbonToggleButton)
        tb.Pressed = True
        AddHandler tb.PressedButtonChanged, AddressOf PreviewForm_PressedButtonChanged

        fv.ZoomMode = FlexViewerZoomMode.PageWidth
        fv.ShowParameters = True

    End Sub

    Private Sub AddThemeColor(ByVal items As RibbonItemCollection, ByVal tc As ThemeColor)

        Dim tb As New RibbonToggleButton()
        tb.Text = tc.ToString()
        tb.Tag = tc
        tb.ToggleGroupName = "Theme"
        tb.CanDepress = False
        items.Add(tb)

    End Sub


#End Region

#Region "methods"

    Private Function OpenFile(ByVal filePath As String, Optional ByVal addToJumpList As Boolean = True) As Boolean

        If String.IsNullOrEmpty(filePath) OrElse Not File.Exists(filePath) Then
            Using dlg As New OpenFileDialog()
                dlg.DereferenceLinks = True
                dlg.Title = OpenFileDlgTitle
                If Not String.IsNullOrEmpty(filePath) Then
                    If Not Directory.Exists(filePath) Then
                        filePath = Path.GetDirectoryName(filePath)
                    End If
                    If Directory.Exists(filePath) Then
                        dlg.InitialDirectory = filePath
                    End If
                End If
                dlg.Filter = FileOpenFilter
                dlg.FilterIndex = 0
                If dlg.ShowDialog() <> DialogResult.OK Then
                    Return False
                End If
                filePath = dlg.FileName
            End Using
            addToJumpList = True
        End If

        Dim doc As XmlDocument = Nothing
        Dim ext As String = Path.GetExtension(filePath).ToLowerInvariant()
        Try
            If ext = ".flxr" OrElse ext = ".xml" Then
                doc = New XmlDocument()
                doc.PreserveWhitespace = True
                doc.Load(filePath)
            Else
                MessageBox.Show("Can't open file with """ + ext + """ extension.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If doc IsNot Nothing Then
            Text = Path.GetFileNameWithoutExtension(filePath)

            If addToJumpList Then
                If CheckFileRegistration() Then
                    atb.JumpList.AddToRecentCategory(filePath)
                End If
                If _isWindows10 Then
                    Dim found As Boolean = False
                    For i As Int32 = 0 To _recentItems.Count - 1
                        If String.Compare(_recentItems(i), filePath, StringComparison.OrdinalIgnoreCase) = 0 Then
                            found = True
                            Exit For
                        End If
                    Next
                    If Not found Then
                        _recentItems.Add(filePath)
                    End If
                End If
            End If

            Dim reportList As String() = C1FlexReport.GetReportList(doc)
            If reportList Is Nothing OrElse reportList.Length = 0 Then
                MessageBox.Show("The opened file does not contain any reports.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            _doc = doc

            Dim coll = _reportsCombo.Items
            _reportsCombo.Items.ClearAndDisposeItems()
            For i As Int32 = 0 To reportList.Length - 1
                coll.Add(New RibbonButton(reportList(i)))
            Next

            UpdateEnabled()
            _reportsCombo.DroppedDown = True
            Return True
        End If
        Return False

    End Function

    Private Sub CloseFile()

        _doc = Nothing
        If _report IsNot Nothing Then
            Me.Text = FormTitle
            fv.DocumentSource = Nothing
            _report.Dispose()
            _report = Nothing
            _reportsCombo.Items.ClearAndDisposeItems()
            _reportsCombo.SelectedIndex = -1
        End If
        UpdateEnabled()

    End Sub

    Private Sub UpdateEnabled()

        Dim hasDoc As Boolean = _doc IsNot Nothing
        Dim hasReport As Boolean = _report IsNot Nothing
        _closeButton.Enabled = hasDoc
        _reportsCombo.Enabled = hasDoc
        _exportButton.Enabled = hasReport
        _printButton.Enabled = hasReport
        _pageSetupButton.Enabled = hasReport

    End Sub

    Private Sub LoadReport(ByVal reportName As String)

        Dim report = New C1FlexReport()
        report.Load(_doc, reportName)

        Dim oldReport = _report
        _report = report

        ' assign report to the flex viewer control
        fv.DocumentSource = report

        If oldReport IsNot Nothing Then
            oldReport.Dispose()
        End If
        UpdateEnabled()

    End Sub

    Private Function CheckFileRegistration() As Boolean

        If CheckAssociations() Then
            Return True
        End If
        If extRegDlg.CheckBoxChecked Then
            Return False
        End If

        extRegDlg.Show()

        Dim result As Boolean = False
        If extRegDlg.DialogResult = TaskDialogResult.Custom AndAlso
                extRegDlg.ClickedCustomButton.Name = "registerButton" Then
            Try
                RegisterAssociations()
                result = True
            Catch ex As Win32Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Return result

    End Function

    Private Function CheckAssociations() As Boolean

        Return atb.CheckFileAssociations(".flxr")

    End Function

    Private Sub RegisterAssociations()

        atb.RegisterFileAssociations(True, FriendlyName, DefaultIcon, String.Format(OpenWithCommandFmt, _exePath), ".flxr")

    End Sub

    Private Sub UnregisterAssociations()

        atb.UnregisterFileAssociations(True, ".flxr")

    End Sub

#End Region

#Region "event handlers"

    Private Sub PreviewForm_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        AddHandler Application.Idle, AddressOf Application_Idle

    End Sub

    Private Sub Application_Idle(ByVal sender As System.Object, ByVal e As System.EventArgs)

        RemoveHandler Application.Idle, AddressOf Application_Idle

        If _startupFilePath IsNot Nothing Then
            OpenFile(_startupFilePath, False)
            _startupFilePath = Nothing
            Return
        End If

        Dim hasRecentItems As Boolean = False
        If _isWindows10 Then
            hasRecentItems = _recentItems.Count > 0
        Else
            Dim items = atb.JumpList.GetKnownCategoryItems(JumpListKnownCategory.Recent)
            hasRecentItems = items.Count > 0
        End If
        If hasRecentItems Then
            fv.Ribbon.ApplicationMenu.DroppedDown = True
            Return
        End If

        Dim exeDir = Path.GetDirectoryName(_exePath)
        Dim dirPath = exeDir + SampleReportsDir
        If Not Directory.Exists(dirPath) Then
            Dim di As New DirectoryInfo(exeDir)
            If di.Parent IsNot Nothing AndAlso di.Parent.Parent IsNot Nothing Then
                dirPath = di.Parent.Parent.FullName + SampleReportsDir
            End If
        End If
        OpenFile(If(Directory.Exists(dirPath), dirPath, Nothing))

    End Sub

    Private Sub ReportsCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If _doc IsNot Nothing Then
            Dim item As RibbonButton = _reportsCombo.SelectedItem
            If item IsNot Nothing Then
                LoadReport(item.Text)
            End If
        End If

    End Sub

    Private Sub OpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        OpenFile(Nothing)

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CloseFile()

    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Close()

    End Sub

    Private Sub RegisterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If _registered Then
            UnregisterAssociations()
        Else
            RegisterAssociations()
        End If

    End Sub

    Private Sub AppMenu_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ribbonItems = fv.Ribbon.ApplicationMenu.RightPaneItems
        While ribbonItems.Count > 3
            Dim Index As Int32 = ribbonItems.Count - 1
            Dim ri = ribbonItems(Index)
            ribbonItems.RemoveAt(Index)
            ri.Dispose()
        End While

        If CheckAssociations() Then
            _registerLabel.Text = "{ unregister .flxr files from this application }"
            _registered = True
        Else
            _registerLabel.Text = "{ register .flxr files with this application }"
            _registered = False
        End If

        If _isWindows10 Then
            For i As Int32 = 1 To _recentItems.Count
                Dim path As String = _recentItems(i - 1)
                If path IsNot Nothing Then
                    AppendListItem(ribbonItems, i, path).Tag = path
                End If
            Next
        Else
            Dim items = atb.JumpList.GetKnownCategoryItems(JumpListKnownCategory.Recent)
            For i As Int32 = 1 To items.Count
                Dim jumpPath As C1JumpPath = TryCast(items(i - 1), C1JumpPath)
                If jumpPath IsNot Nothing Then
                    AppendListItem(ribbonItems, i, jumpPath.Path).Tag = jumpPath
                End If
            Next
        End If

    End Sub

    Private Function AppendListItem(ByVal ribbonItems As RibbonItemCollection, ByVal num As Int32, ByVal path As String) As RibbonListItem

        Dim rli As New C1.Win.Ribbon.RibbonListItem()

        Dim sb As New StringBuilder()
        If num < 10 Then
            sb.Append("&"c).Append(num).Append("  ")
        Else
            sb.Append(num).Append(" "c)
        End If
        sb.Append(System.IO.Path.GetFileNameWithoutExtension(path))
        rli.Items.Add(New RibbonLabel(sb.ToString()))

        Dim delButton As New C1.Win.Ribbon.RibbonButton()
        If num < 10 Then
            delButton.KeyTip = "Y" + num.ToString()
        End If
        delButton.SelectableInListItem = True
        delButton.SmallImage = My.Resources.Delete16x16
        delButton.ToolTip = "Remove from list"
        AddHandler delButton.Click, AddressOf DelButton_Click
        rli.Items.Add(delButton)

        ribbonItems.Add(rli)

        rli.ToolTip = path
        AddHandler rli.Click, AddressOf RibbonListItem_Click
        Return rli

    End Function

    Private Sub RibbonListItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim rli = DirectCast(sender, RibbonListItem)
        If _isWindows10 Then
            OpenFile(DirectCast(rli.Tag, String), False)
        Else
            Dim jumpPath = DirectCast(rli.Tag, C1JumpPath)
            OpenFile(jumpPath.Path, False)
        End If

    End Sub

    Private Sub DelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim rli = TryCast(DirectCast(sender, RibbonButton).Parent, RibbonListItem)
        If rli IsNot Nothing Then
            If Not _isWindows10 Then
                atb.JumpList.RemoveFromKnownCategories(DirectCast(rli.Tag, C1JumpPath))
            Else
                Dim s As String = DirectCast(rli.Tag, String)
                For i As Int32 = 0 To _recentItems.Count - 1
                    If _recentItems(i) = s Then
                        _recentItems.RemoveAt(i)
                        Exit For
                    End If
                Next
            End If
            fv.Ribbon.ApplicationMenu.RightPaneItems.Remove(rli)
            rli.Dispose()
        End If

    End Sub

    Private Sub PreviewForm_FormClosing(ByVal sender As System.Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        Dim st = My.MySettings.Default
        st.ThemeColor = _themeColor.ToString()
        If _isWindows10 Then
            st.RecentItems = _recentItems
        End If
        st.Save()

    End Sub

    Private Sub RibbonStyle_StyleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim s = RibbonStyle
        Dim p = fv.Pane

        p.SplitterColor = s.BrushSet.GetColor(StyleBrush.Toggled)

        p.OutlineForeColorNormal = s.ColorSet(StyleColor.TabText)
        p.OutlineBackColorHot = s.BrushSet.GetColor(StyleBrush.Hot)
        p.OutlineForeColorHot = s.ColorSet(StyleColor.HotText)
        p.OutlineBackColorSelected = s.BrushSet.GetColor(StyleBrush.Pressed)
        p.OutlineForeColorSelected = s.ColorSet(StyleColor.PressedText)
        p.OutlineBackColorHotSelected = s.BrushSet.GetColor(StyleBrush.Toggled)
        p.OutlineForeColorHotSelected = s.ColorSet(StyleColor.ToggledText)
        p.OutlineAreaBackColor = s.ColorSet(StyleColor.FormBackground)
        p.OutlineBackColorNormal = s.ColorSet(StyleColor.FormBackground)

        p.ThumbPageNumBackColor = s.BrushSet.GetColor(StyleBrush.AppButton)
        p.ThumbPageNumForeColor = s.ColorSet(StyleColor.AppButtonText)

        p.ThumbBackColorHot = s.BrushSet.GetColor(StyleBrush.Hot)
        p.ThumbBackColorPressed = s.BrushSet.GetColor(StyleBrush.Pressed)
        p.ThumbBackColorSelected = s.BrushSet.GetColor(StyleBrush.Toggled)

        p.ParamHeaderBackColor = s.BrushSet.GetColor(StyleBrush.Pressed)
        p.ParamHeaderForeColor = s.ColorSet(StyleColor.PressedText)

    End Sub

    Private Sub PreviewForm_PressedButtonChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim tb = DirectCast(sender, RibbonToggleButton)
        _themeColor = DirectCast(tb.PressedButton.Tag, ThemeColor)
        UpdateChildStyles(_themeColor, ThemeLightness.DarkGray)

        Dim ipStyle = CType(CType(_themeColor, Int32), C1.Win.C1InputPanel.ThemeColor)
        C1.Win.C1InputPanel.InputStyle.UpdateInstance(ipStyle, C1.Win.C1InputPanel.ThemeLightness.LightGray)

    End Sub

#End Region

#Region "interop code"

    <System.Security.SuppressUnmanagedCodeSecurity()>
    <DllImport("ntdll.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function RtlGetVersion(ByRef osVersion As OSVERSIONINFO) As System.Int32
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Private Structure OSVERSIONINFO

        Public dwOSVersionInfoSize As Int32
        Public dwMajorVersion As Int32
        Public dwMinorVersion As Int32
        Public dwBuildNumber As Int32
        Public dwPlatformId As Int32
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=128)>
        Public szCSDVersion As String

    End Structure

#End Region

End Class
