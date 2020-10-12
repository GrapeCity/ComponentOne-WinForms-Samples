Imports C1.Win.C1Ribbon
Imports C1.Win.C1Win7Pack
Imports System.Reflection

Public Class ImageOptions

    Private _filterCounter As Integer
    Private _filterString As String
    Private _filterFormat As String
    Private _checkList As String
    Private _AllCheckBoxesUnchecked As Boolean

    Public Sub New(ByVal vis As VisualStyle)
        InitializeComponent()

        VisualStyle = vis
        C1SuperTooltip1.Opacity = My.Settings.TootipOpacity
        C1SuperTooltip1.BackgroundGradient = Utils.GetSuperToolTipBackgroundGradient
        chk0.BackColor = BackgroundColor
        chk1.BackColor = BackgroundColor
        chk2.BackColor = BackgroundColor
        chk3.BackColor = BackgroundColor
        chk0.BackColor = BackgroundColor

        btnOK.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        btnFolderDialogShow.VisualStyle = C1.Win.C1Input.VisualStyle.Custom
        btnClearAllCheckBoxes.VisualStyle = C1.Win.C1Input.VisualStyle.Custom

        Dim mi As MethodInfo = btnOK.GetType().GetMethod("ResetVisualStyle", BindingFlags.NonPublic Or BindingFlags.Instance)
        mi.Invoke(btnOK, New Object() {})
        mi.Invoke(btnCancel, New Object() {})
        mi.Invoke(btnClearAllCheckBoxes, New Object() {})
        mi.Invoke(btnFolderDialogShow, New Object() {})

        If My.Settings.DefaultFolderPath <> String.Empty Then
            txtDefaultFolderLocation.Text = My.Settings.DefaultFolderPath
        End If
    End Sub

    Private Sub ImageOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetUpCheckBoxesOnLoad()
    End Sub

    Private Sub SetUpCheckBoxesOnLoad()
        Dim str As String = My.Settings.CheckTextList
        Dim strArray As String() = str.Split(",")
        For i As Integer = 0 To strArray.Count - 1
            ConfigureCheckAndTextBoxesOnLoad(strArray(i), i)
        Next i
    End Sub

    Private Shared Function GetCheckedValue(ByVal val As String) As Boolean
        If val = "t" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub ConfigureCheckAndTextBoxesOnLoad(ByVal arrayElement As String, ByVal loopCount As Integer)

        Dim numToSet As String = arrayElement.Chars(1)
        Dim bool As String = arrayElement.Chars(2)
        Select Case loopCount
            Case 0
                txt0.Text = numToSet
                chk0.Checked = GetCheckedValue(bool)
            Case 1
                txt1.Text = numToSet
                chk1.Checked = GetCheckedValue(bool)
            Case 2
                txt2.Text = numToSet
                chk2.Checked = GetCheckedValue(bool)
            Case 3
                txt3.Text = numToSet
                chk3.Checked = GetCheckedValue(bool)
            Case 4
                txt4.Text = numToSet
                chk4.Checked = GetCheckedValue(bool)
            Case Else
                Return
        End Select
    End Sub

    Private Sub BuildFilterString(ByVal nm As String)

        Select Case nm
            Case "chk0"
                If _filterCounter > 1 Then
                    _filterString = String.Format("{0}|Bitmap Image|*.bmp", _filterString)
                    _filterFormat = String.Format("{0},bmp", _filterFormat)
                Else
                    _filterString = _filterString & "Bitmap Image|*.bmp"
                    _filterFormat = _filterFormat & "bmp"
                End If
                txt0.Text = _filterCounter.ToString
            Case "chk1"
                If _filterCounter > 1 Then
                    _filterString = String.Format("{0}|Gif Image|*.gif", _filterString)
                    _filterFormat = String.Format("{0},gif", _filterFormat)
                Else
                    _filterString = _filterString & "Gif Image|*.gif"
                    _filterFormat = _filterFormat & "gif"
                End If
                txt1.Text = _filterCounter.ToString
            Case "chk2"
                If _filterCounter > 1 Then
                    _filterString = String.Format("{0}|JPeg Image|*.jpeg", _filterString)
                    _filterFormat = String.Format("{0},jpeg", _filterFormat)
                Else
                    _filterString = _filterString & "JPeg Image|*.jpeg"
                    _filterFormat = _filterFormat & "jpeg"
                End If
                txt2.Text = _filterCounter.ToString
            Case "chk3"
                If _filterCounter > 1 Then
                    _filterString = String.Format("{0}|Portable Network Graphic|*.png", _filterString)
                    _filterFormat = String.Format("{0},png", _filterFormat)
                Else
                    _filterString = _filterString & "Portable Network Graphic|*.png"
                    _filterFormat = _filterFormat & "png"
                End If
                txt3.Text = _filterCounter.ToString
            Case "chk4"
                If _filterCounter > 1 Then
                    _filterString = String.Format("{0}|Tagged Image File|*.tiff", _filterString)
                    _filterFormat = String.Format("{0},tiff", _filterFormat)
                Else
                    _filterString = _filterString & "Tagged Image File|*.tiff"
                    _filterFormat = _filterFormat & "tiff"
                End If
                txt4.Text = _filterCounter.ToString
            Case Else
                Return
        End Select
    End Sub
    Private Sub CheckedBoxCheckedChanged(sender As Object, e As EventArgs) Handles chk0.CheckedChanged, chk1.CheckedChanged, chk2.CheckedChanged, chk3.CheckedChanged, chk4.CheckedChanged
        If sender.checked = False Then
            _filterCounter = 0
            _filterString = String.Empty
            _filterFormat = String.Empty
            _AllCheckBoxesUnchecked = True
        Else
            _filterCounter += 1
            BuildFilterString(sender.name)
            _AllCheckBoxesUnchecked = False
        End If
    End Sub

    Private Sub ClearCheckAndTextBoxes(ByVal i As Integer)
        Select Case i
            Case 0
                txt0.Text = "0"
                chk0.Checked = False
            Case 1
                txt1.Text = "0"
                chk1.Checked = False
            Case 2
                txt2.Text = "0"
                chk2.Checked = False
            Case 3
                txt3.Text = "0"
                chk3.Checked = False
            Case 4
                txt4.Text = "0"
                chk4.Checked = False
            Case Else
                Return
        End Select
    End Sub
    


    Private Sub BuildCheckTextList()
        Dim checkVal As String
        For i As Integer = 0 To 4
            Select Case i
                Case 0
                    If chk0.Checked Then
                        checkVal = "t"
                    Else
                        checkVal = "f"
                    End If
                    _checkList = String.Format("{0}1{1}{2},", _checkList, txt0.Text, checkVal)
                Case 1
                    If chk1.Checked Then
                        checkVal = "t"
                    Else
                        checkVal = "f"
                    End If
                    _checkList = String.Format("{0}2{1}{2},", _checkList, txt1.Text, checkVal)
                Case 2
                    If chk2.Checked Then
                        checkVal = "t"
                    Else
                        checkVal = "f"
                    End If
                    _checkList = String.Format("{0}3{1}{2},", _checkList, txt2.Text, checkVal)
                Case 3
                    If chk3.Checked Then
                        checkVal = "t"
                    Else
                        checkVal = "f"
                    End If
                    _checkList = String.Format("{0}4{1}{2},", _checkList, txt3.Text, checkVal)
                Case 4
                    If chk4.Checked Then
                        checkVal = "t"
                    Else
                        checkVal = "f"
                    End If
                    _checkList = String.Format("{0}5{1}{2}", _checkList, txt4.Text, checkVal)
                Case Else
                    Return
            End Select
        Next i

    End Sub
    Private Shared Sub WarnNoFiltersSelected()

        Using dlg As New C1TaskDialog()
            If C1TaskDialog.IsPlatformSupported Then
                With dlg
                    .MainInstruction = "Select an Image Format"
                    .Content = "You must select at least one Image Format Type."
                    .WindowTitle = "No Image Format Selected"
                    .CommonButtons = TaskDialogCommonButtons.Ok
                    .MainCommonIcon = TaskDialogCommonIcon.Error
                    .Show()
                End With
            Else
                MessageBox.Show("You must select at least one Image Format Type.", "No Image Format Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using


    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If _AllCheckBoxesUnchecked Then
            WarnNoFiltersSelected()
            C1SplitterPanel1.Focus()
            DialogResult = Windows.Forms.DialogResult.None
        Else
            My.Settings.ImageFilterList = _filterString
            My.Settings.ImageFormats = _filterFormat
            BuildCheckTextList()
            My.Settings.CheckTextList = _checkList
        End If
        If Trim(txtDefaultFolderLocation.Text) <> String.Empty Then
            If Trim(txtDefaultFolderLocation.Text) <> My.Settings.DefaultFolderPath Then
                My.Settings.DefaultFolderPath = Trim(txtDefaultFolderLocation.Text)
            End If
        End If

    End Sub

    Private Sub btnClearAllCheckBoxes_Click(sender As Object, e As EventArgs) Handles btnClearAllCheckBoxes.Click
        For i As Integer = 0 To 4
            ClearCheckAndTextBoxes(i)
        Next i
    End Sub

    Private Sub btnFolderDialogShow_Click(sender As Object, e As EventArgs) Handles btnFolderDialogShow.Click
        Using dlg As New FolderBrowserDialog()
            With dlg
                .Description = "Select the directory where your images will be stored by default."
                .RootFolder = Environment.SpecialFolder.Desktop
                .SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    txtDefaultFolderLocation.Text = .SelectedPath
                Else
                    Return
                End If

            End With

        End Using
    End Sub
End Class
