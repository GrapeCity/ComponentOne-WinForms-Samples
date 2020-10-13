Imports C1.Win.C1Input
Imports System.Globalization

'KeyPadButtons
<Flags()> _
Friend Enum KeyPadButtons
    None = &H0
    One = &H1
    Two = &H2
    Three = &H4
    Four = &H8
    Five = &H10
    Six = &H20
    Seven = &H40
    Eight = &H80
    Nine = &H100
    Zero = &H200
    Point = &H400
    ChangeSign = &H800
    Clear = &H1000
    Backspace = &H2000
    Digit = One Or Two Or Three Or Four Or Five Or Six Or Seven Or Eight Or Nine Or Zero
End Enum

'KeyPadState
Friend Enum KeyPadState
    Init
    EditN1
    Err
end enum

Public Class KeyPadDropDown
    Inherits C1.Win.C1Input.DropDownForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        AddHandler btn0.Click, AddressOf Me.btn_Click
        AddHandler btn1.Click, AddressOf Me.btn_Click
        AddHandler btn2.Click, AddressOf Me.btn_Click
        AddHandler btn3.Click, AddressOf Me.btn_Click
        AddHandler btn4.Click, AddressOf Me.btn_Click
        AddHandler btn5.Click, AddressOf Me.btn_Click
        AddHandler btn6.Click, AddressOf Me.btn_Click
        AddHandler btn7.Click, AddressOf Me.btn_Click
        AddHandler btn8.Click, AddressOf Me.btn_Click
        AddHandler btn9.Click, AddressOf Me.btn_Click
        AddHandler btnClear.Click, AddressOf Me.btn_Click
        AddHandler btnBackspace.Click, AddressOf Me.btn_Click
        AddHandler btnOk.Click, AddressOf Me.btn_Click
        AddHandler btnCancel.Click, AddressOf Me.btn_Click
        AddHandler btnPoint.Click, AddressOf Me.btn_Click
        AddHandler btnChangeSign.Click, AddressOf Me.btn_Click
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
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBackspace As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPoint As System.Windows.Forms.Button
    Friend WithEvents btnChangeSign As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBackspace = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.btnChangeSign = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(106, 64)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(48, 24)
        Me.btnClear.TabIndex = 26
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear"
        '
        'btnBackspace
        '
        Me.btnBackspace.BackColor = System.Drawing.SystemColors.Control
        Me.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackspace.Location = New System.Drawing.Point(106, 34)
        Me.btnBackspace.Name = "btnBackspace"
        Me.btnBackspace.Size = New System.Drawing.Size(48, 24)
        Me.btnBackspace.TabIndex = 22
        Me.btnBackspace.TabStop = False
        Me.btnBackspace.Text = "|<---"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.Control
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOk.Location = New System.Drawing.Point(106, 94)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(48, 24)
        Me.btnOk.TabIndex = 30
        Me.btnOk.TabStop = False
        Me.btnOk.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(106, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(48, 24)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        '
        'btnPoint
        '
        Me.btnPoint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPoint.Location = New System.Drawing.Point(72, 94)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(28, 24)
        Me.btnPoint.TabIndex = 29
        Me.btnPoint.TabStop = False
        Me.btnPoint.Text = "."
        '
        'btnChangeSign
        '
        Me.btnChangeSign.BackColor = System.Drawing.SystemColors.Control
        Me.btnChangeSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangeSign.Location = New System.Drawing.Point(38, 94)
        Me.btnChangeSign.Name = "btnChangeSign"
        Me.btnChangeSign.Size = New System.Drawing.Size(28, 24)
        Me.btnChangeSign.TabIndex = 28
        Me.btnChangeSign.TabStop = False
        Me.btnChangeSign.Text = "+/-"
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.Control
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn0.Location = New System.Drawing.Point(4, 94)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(28, 24)
        Me.btn0.TabIndex = 27
        Me.btn0.TabStop = False
        Me.btn0.Text = "0"
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.Control
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn3.Location = New System.Drawing.Point(72, 64)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(28, 24)
        Me.btn3.TabIndex = 25
        Me.btn3.TabStop = False
        Me.btn3.Text = "3"
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.Control
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn2.Location = New System.Drawing.Point(38, 64)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(28, 24)
        Me.btn2.TabIndex = 24
        Me.btn2.TabStop = False
        Me.btn2.Text = "2"
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.Control
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn1.Location = New System.Drawing.Point(4, 64)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(28, 24)
        Me.btn1.TabIndex = 23
        Me.btn1.TabStop = False
        Me.btn1.Text = "1"
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.Control
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn6.Location = New System.Drawing.Point(72, 34)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(28, 24)
        Me.btn6.TabIndex = 21
        Me.btn6.TabStop = False
        Me.btn6.Text = "6"
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.Control
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn5.Location = New System.Drawing.Point(38, 34)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(28, 24)
        Me.btn5.TabIndex = 20
        Me.btn5.TabStop = False
        Me.btn5.Text = "5"
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.Control
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn4.Location = New System.Drawing.Point(4, 34)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(28, 24)
        Me.btn4.TabIndex = 19
        Me.btn4.TabStop = False
        Me.btn4.Text = "4"
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.Control
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn9.Location = New System.Drawing.Point(72, 4)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(28, 24)
        Me.btn9.TabIndex = 18
        Me.btn9.TabStop = False
        Me.btn9.Text = "9"
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.Control
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn8.Location = New System.Drawing.Point(38, 4)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(28, 24)
        Me.btn8.TabIndex = 17
        Me.btn8.TabStop = False
        Me.btn8.Text = "8"
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.Control
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn7.Location = New System.Drawing.Point(4, 4)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(28, 24)
        Me.btn7.TabIndex = 16
        Me.btn7.TabStop = False
        Me.btn7.Text = "7"
        '
        'KeyPadDropDown
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(158, 122)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClear, Me.btnBackspace, Me.btnOk, Me.btnCancel, Me.btnPoint, Me.btnChangeSign, Me.btn0, Me.btn3, Me.btn2, Me.btn1, Me.btn6, Me.btn5, Me.btn4, Me.btn9, Me.btn8, Me.btn7})
        Me.Name = "KeyPadDropDown"
        Me.Options = (C1.Win.C1Input.DropDownFormOptionsFlags.FixedSize Or C1.Win.C1Input.DropDownFormOptionsFlags.AlwaysPostChanges)
        Me.Text = "KeyPadDropDown"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _inPostChanges As Boolean = False
    Private _culture As CultureInfo
    Private _owner As C1NumericEdit
    Private _decimalPointChar As Char
    Private _skipNextKeyPress As Boolean = False
    Private _button As KeyPadButtons
    Private _state As KeyPadState
    Private _dispText As String
    Private _num As Decimal
    Private _complete As Boolean
    Private _curValue As Decimal
    Private _valueIsNull As Boolean
    Private _pointPresent As Boolean
    Private _divider As Int32
    Private _changed As Boolean

    'Methods
    Protected Overrides Sub OnPostChanges(ByVal e As EventArgs)
        If _inPostChanges Then Exit Sub
        _inPostChanges = True
        Try
            MyBase.OnPostChanges(e)
            If _state = KeyPadState.Err Then
                DoCancelChanges()
            ElseIf OwnerControl.MaskInfo.IsMaskedMode() Then
                If (_valueIsNull) Then
                    CType(OwnerControl, C1NumericEdit).Text = ""
                Else
                    Try
                        OwnerControl.MaskInfo.EffectiveText = CType(OwnerControl, C1NumericEdit).Text
                    Catch
                        OwnerControl.UpdateValueWithCurrentText()
                        OwnerControl.ResetText()
                    End Try
                End If
            ElseIf OwnerControl.NumericInput Then
                NumericPost(False)
            End If
        Finally
            _inPostChanges = False
        End Try

    End Sub

    Protected Overrides Sub OnCancelChanges(ByVal e As EventArgs)
        MyBase.OnCancelChanges(e)
        DoCancelChanges()
    End Sub

    Private Sub DoCancelChanges()
        If OwnerControl.NumericInput And Not OwnerControl.MaskInfo.IsMaskedMode() Then
            NumericPost(True)
        Else
            OwnerControl.ResetText()
        End If
    End Sub

    Private Sub NumericPost(ByVal errorState As Boolean)
        If errorState Then
            OwnerControl.SuspendNumericInput(False, False)
        Else
            OwnerControl.UpdateValueWithCurrentText()
            OwnerControl.SuspendNumericInput(False, True)
        End If
        OwnerControl.Modified = True
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        If Not e.Handled Then
            e.Handled = CalcKeyDown(e)
        End If
        MyBase.OnKeyDown(e)
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        If Not e.Handled Then
            e.Handled = CalcKeyPress(e.KeyChar)
        End If
        MyBase.OnKeyPress(e)
    End Sub

    Protected Overrides Sub OnOpen(ByVal e As EventArgs)
        MyBase.OnOpen(e)
        _owner = CType(OwnerControl, C1NumericEdit)
        _culture = _owner.CultureInfo
        btnPoint.Text = _culture.NumberFormat.NumberDecimalSeparator
        _decimalPointChar = btnPoint.Text.Chars(0)
        Dim number As Decimal = Decimal.Zero
        Dim valueIsNull As Boolean = True
        Try
            Dim x As Object = _owner.Value
            If Not (TypeOf x Is DBNull) Then
                number = Convert.ToDecimal(x, _culture)
                valueIsNull = False
            End If
        Catch
        End Try
        If Not _owner.MaskInfo.IsMaskedMode() Then
            _owner.SuspendNumericInput(True, True)
        End If
        Clear()
        _state = KeyPadState.Init
        _curValue = number
        _valueIsNull = valueIsNull
        _num = number
        _complete = True
        If valueIsNull Then
            _dispText = _owner.EditFormat.NullText
        Else
            _dispText = _curValue.ToString(_culture)
            _state = KeyPadState.EditN1
        End If
        _changed = False
    End Sub

    Friend Function CalcKeyDown(ByVal e As KeyEventArgs) As Boolean
        _skipNextKeyPress = False
        Dim command As KeyPadButtons = KeyPadButtons.None
        If e.Modifiers = Keys.None Then
            Select Case e.KeyCode
                Case Keys.Decimal
                    command = KeyPadButtons.Point
                Case Keys.Back
                    command = KeyPadButtons.Backspace
                Case Keys.C
                    command = KeyPadButtons.Clear
            End Select
        End If
        If command <> KeyPadButtons.None Then
            ClickButton(command)
            _skipNextKeyPress = True
            Return True
        End If
        Return False
    End Function

    Friend Function CalcKeyPress(ByVal keyChar As Char) As Boolean
        If _skipNextKeyPress Then
            _skipNextKeyPress = False
            Return True
        End If
        Dim command As KeyPadButtons = KeyPadButtons.None
        Select Case keyChar
            Case "1"c
                command = KeyPadButtons.One
            Case "2"c
                command = KeyPadButtons.Two
            Case "3"c
                command = KeyPadButtons.Three
            Case "4"c
                command = KeyPadButtons.Four
            Case "5"c
                command = KeyPadButtons.Five
            Case "6"c
                command = KeyPadButtons.Six
            Case "7"c
                command = KeyPadButtons.Seven
            Case "8"c
                command = KeyPadButtons.Eight
            Case "9"c
                command = KeyPadButtons.Nine
            Case "0"c
                command = KeyPadButtons.Zero
            Case Else
                If keyChar = _decimalPointChar Then
                    command = KeyPadButtons.Point
                End If
        End Select
        If command <> KeyPadButtons.None Then
            ClickButton(command)
        End If
        Return Asc(keyChar) <> 13 And Asc(keyChar) <> 27
    End Function

    Private Sub Clear()
        _num = Decimal.Zero
        _complete = False
        _curValue = Decimal.Zero
        _pointPresent = False
        _dispText = "0"
        _divider = 0
    End Sub

    Private Function Test(ByVal subset As KeyPadButtons) As Boolean
        Return (_button And subset) = _button
    End Function

    Friend Sub ClickButton(ByVal button As KeyPadButtons)
        _button = button
        If button = KeyPadButtons.Clear Then
            Clear()
            _dispText = _owner.EditFormat.NullText
            _state = KeyPadState.Init
            _valueIsNull = True
            _changed = True
        ElseIf _state <> KeyPadState.Init Then
            _state = KeyPadState.EditN1
        ElseIf Test(KeyPadButtons.Digit Or KeyPadButtons.Point) Then
            _state = KeyPadState.EditN1
        End If
        If _state = KeyPadState.EditN1 Then
            Dim needParse As Boolean = False
            Dim needFormat As Boolean = False
            Dim prevText As String = _dispText
            Dim ignore As Boolean = False
            If Test(KeyPadButtons.Digit) Then
                If _valueIsNull Or _complete Then
                    _valueIsNull = False
                    Clear()
                End If
                Dim digit As String = Nothing
                Select Case _button
                    Case KeyPadButtons.Zero
                        digit = "0"
                    Case KeyPadButtons.One
                        digit = "1"
                    Case KeyPadButtons.Two
                        digit = "2"
                    Case KeyPadButtons.Three
                        digit = "3"
                    Case KeyPadButtons.Four
                        digit = "4"
                    Case KeyPadButtons.Five
                        digit = "5"
                    Case KeyPadButtons.Six
                        digit = "6"
                    Case KeyPadButtons.Seven
                        digit = "7"
                    Case KeyPadButtons.Eight
                        digit = "8"
                    Case KeyPadButtons.Nine
                        digit = "9"
                End Select
                If _pointPresent Then
                    If _divider = 0 Then
                        Dim len As Int32 = _dispText.Length
                        If len > 0 And _dispText.Chars(len - 1) <> _decimalPointChar Then
                            _dispText += _decimalPointChar
                        End If
                    End If
                    _divider += 1
                    _dispText += digit
                ElseIf _dispText = "0" Then
                    _dispText = digit
                Else
                    _dispText += digit
                End If
                needParse = True
            ElseIf Test(KeyPadButtons.Point) Then
                If _valueIsNull Or _complete Then
                    _valueIsNull = False
                    Clear()
                End If
                If Not _pointPresent Then
                    _pointPresent = True
                    _divider = 0
                Else
                    ignore = True
                End If
            ElseIf Test(KeyPadButtons.ChangeSign) Then
                If _num <> Decimal.Zero Or (Not _complete And _pointPresent) Then
                    _num = -_num
                    If _dispText.Chars(0) = "-"c Then
                        _dispText = _dispText.Substring(1)
                    Else
                        _dispText = "-" + _dispText
                    End If
                Else
                    ignore = True
                End If
            ElseIf Test(KeyPadButtons.Backspace) Then
                If _complete Then
                    ignore = True
                ElseIf _pointPresent Then
                    If _divider = 0 Then
                        _pointPresent = False
                        ignore = True
                    Else
                        _divider -= 1
                        If _divider = 0 Then
                            _dispText = _dispText.Substring(0, _dispText.Length - 2)
                        Else
                            _dispText = _dispText.Substring(0, _dispText.Length - 1)
                        End If
                        needParse = True
                    End If
                Else
                    Dim len As Int32 = _dispText.Length
                    If len = 1 Or (len = 2 And _dispText.Chars(0) = "-"c) Then
                        If _dispText = "0" Then
                            ignore = True
                        Else
                            _dispText = "0"
                        End If
                    Else
                        _dispText = _dispText.Substring(0, _dispText.Length - 1)
                    End If
                    needParse = True
                End If
            End If
            If Not ignore Then
                If needParse Then
                    Try
                        _num = Decimal.Parse(_dispText, _culture)
                    Catch
                        Try
                            _num = CType(Double.Parse(_dispText, _culture), Decimal)
                        Catch
                            _state = KeyPadState.Err
                            _dispText = prevText
                        End Try
                    End Try
                End If
                _curValue = _num
                If needFormat Then
                    _dispText = _curValue.ToString(_culture)
                End If
                _changed = True
            End If
        End If
        If _changed Then
            _owner.BaseText = _dispText
            _changed = False
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender Is Nothing Then
            Exit Sub
        End If
        Dim button As KeyPadButtons = KeyPadButtons.None
        If sender.Equals(btn0) Then
            button = KeyPadButtons.Zero
        ElseIf sender.Equals(btn1) Then
            button = KeyPadButtons.One
        ElseIf sender.Equals(btn2) Then
            button = KeyPadButtons.Two
        ElseIf sender.Equals(btn3) Then
            button = KeyPadButtons.Three
        ElseIf sender.Equals(btn4) Then
            button = KeyPadButtons.Four
        ElseIf sender.Equals(btn5) Then
            button = KeyPadButtons.Five
        ElseIf sender.Equals(btn6) Then
            button = KeyPadButtons.Six
        ElseIf sender.Equals(btn7) Then
            button = KeyPadButtons.Seven
        ElseIf sender.Equals(btn8) Then
            button = KeyPadButtons.Eight
        ElseIf sender.Equals(btn9) Then
            button = KeyPadButtons.Nine
        ElseIf sender.Equals(btnBackspace) Then
            button = KeyPadButtons.Backspace
        ElseIf sender.Equals(btnClear) Then
            button = KeyPadButtons.Clear
        ElseIf sender.Equals(btnPoint) Then
            button = KeyPadButtons.Point
        ElseIf sender.Equals(btnChangeSign) Then
            button = KeyPadButtons.ChangeSign
        ElseIf sender.Equals(btnOk) Then
            CloseDropDown(True)
        ElseIf sender.Equals(btnCancel) Then
            CloseDropDown(False)
        End If
        If button <> KeyPadButtons.None Then
            ClickButton(button)
        End If
    End Sub
End Class
