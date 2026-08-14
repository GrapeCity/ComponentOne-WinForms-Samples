Imports System.Windows.Input
Imports C1.Win.InputPanel

Public Class Form1

    Private _command As ShowControlStateCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _command = New ShowControlStateCommand(Me)
        AddCommandBindings()
    End Sub

    ''' <summary>
    ''' Assigns the shared command and corresponding command parameters
    ''' to all supported input controls and hooks menu/split button item click events.
    ''' </summary>
    Private Sub AddCommandBindings()

        inputButton1.Command = _command
        inputButton1.CommandParameter = "ButtonParam"

        inputCheckBox1.Command = _command
        inputCheckBox1.CommandParameter = "CheckBoxParam"

        inputComboBox1.Command = _command
        inputComboBox1.CommandParameter = "ComboBoxParam"

        inputDatePicker1.Command = _command
        inputDatePicker1.CommandParameter = "DatePickerParam"

        inputMaskedTextBox1.Command = _command
        inputMaskedTextBox1.CommandParameter = "MaskedTextBoxParam"

        inputMenu1.Command = _command
        inputMenu1.CommandParameter = "MenuParam"

        AddHandler inputButton6.Click, AddressOf OnMenuItemClick
        AddHandler inputButton7.Click, AddressOf OnMenuItemClick
        AddHandler inputButton8.Click, AddressOf OnMenuItemClick

        inputNumericBox1.Command = _command
        inputNumericBox1.CommandParameter = "NumericEditParam"

        inputRadioButton1.Command = _command
        inputRadioButton1.CommandParameter = "RadioButtonParam1"

        inputRadioButton2.Command = _command
        inputRadioButton2.CommandParameter = "RadioButtonParam2"

        inputSplitButton1.Command = _command
        inputSplitButton1.CommandParameter = "SplitButtonParam"

        AddHandler inputButton2.Click, AddressOf OnSplitItemClick
        AddHandler inputButton3.Click, AddressOf OnSplitItemClick
        AddHandler inputSplitButton2.Click, AddressOf OnSplitItemClick
        AddHandler inputButton4.Click, AddressOf OnSplitItemClick
        AddHandler inputButton5.Click, AddressOf OnSplitItemClick

        inputTextBox1.Command = _command
        inputTextBox1.CommandParameter = "TextBoxParam"

        inputTimePicker1.Command = _command
        inputTimePicker1.CommandParameter = "TimePickerParam"

    End Sub

    Private Sub OnMenuItemClick(sender As Object, e As EventArgs)
        _command.Execute("MenuItem:" & DirectCast(sender, InputComponent).Text)
    End Sub

    Private Sub OnSplitItemClick(sender As Object, e As EventArgs)
        _command.Execute("SplitItem:" & DirectCast(sender, InputComponent).Text)
    End Sub

    ''' <summary>
    ''' Enables or disables command execution for all bound controls.
    ''' </summary>
    Private Sub enableCommandsCheckBox_CheckedChanged(sender As Object, e As EventArgs) _
        Handles enableCommandsCheckBox.CheckedChanged

        _command.CanExecuteValue = enableCommandsCheckBox.Checked
        _command.RaiseCanExecuteChanged()

    End Sub

    ''' <summary>
    ''' Represents a command that displays the current state or value
    ''' of the control that invoked it.
    ''' </summary>
    Private Class ShowControlStateCommand
        Implements ICommand

        Private ReadOnly _form As Form1

        ''' <summary>
        ''' Initializes a new instance of the <see cref="ShowControlStateCommand"/> class.
        ''' </summary>
        Public Sub New(form As Form1)
            _form = form
        End Sub

        ''' <summary>
        ''' Gets or sets a value indicating whether the command can execute.
        ''' </summary>
        Public Property CanExecuteValue As Boolean = True

        ''' <summary>
        ''' Determines whether the command can execute.
        ''' </summary>
        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            Return CanExecuteValue
        End Function

        ''' <summary>
        ''' Executes the command and updates the output label with the
        ''' current state or value of the invoking control.
        ''' </summary>
        Public Sub Execute(parameter As Object) Implements ICommand.Execute

            If Object.Equals(parameter, "ComboBoxParam") Then
                _form.BeginInvoke(New Action(
                    Sub()
                        _form.commandOutputlb.Text =
                            "InputComboBox1 Selected: " & _form.inputComboBox1.Text
                    End Sub))
                Return
            End If

            Dim text As String
            Dim value As String = TryCast(parameter, String)

            Select Case value

                Case "ButtonParam"
                    text = "InputButton Clicked"

                Case "CheckBoxParam"
                    text = "InputCheckBox: " &
                           If(_form.inputCheckBox1.Checked, "Checked", "Unchecked")

                Case "DatePickerParam"
                    text = "InputDatePicker Value: " &
                           _form.inputDatePicker1.Value.ToString()

                Case "MaskedTextBoxParam"
                    text = "InputMaskedTextBox Text: " &
                           _form.inputMaskedTextBox1.Text

                Case "NumericEditParam"
                    text = "InputNumericEdit Value: " &
                           _form.inputNumericBox1.Value.ToString()

                Case "RadioButtonParam1"
                    text = "InputRadioButton1 Selected"

                Case "RadioButtonParam2"
                    text = "InputRadioButton2 Selected"

                Case "SplitButtonParam"
                    text = "InputSplitButton Clicked"

                Case "MenuParam"
                    text = "InputMenu Clicked"

                Case "TextBoxParam"
                    text = "InputTextBox Text: " &
                           _form.inputTextBox1.Text

                Case "TimePickerParam"
                    text = "InputTimePicker Value: " &
                           _form.inputTimePicker1.Value.ToString()

                Case Else

                    If value IsNot Nothing AndAlso value.StartsWith("SplitItem:") Then
                        text = "InputSplitButton Item: " &
                               value.Substring("SplitItem:".Length)

                    ElseIf value IsNot Nothing AndAlso value.StartsWith("MenuItem:") Then
                        text = "InputMenu Item: " &
                               value.Substring("MenuItem:".Length)

                    Else
                        text = "Unknown: " & Convert.ToString(parameter)
                    End If

            End Select

            _form.commandOutputlb.Text = text

        End Sub

        ''' <summary>
        ''' Occurs when changes affecting the result of CanExecute occur.
        ''' </summary>
        Public Event CanExecuteChanged As EventHandler _
            Implements ICommand.CanExecuteChanged

        ''' <summary>
        ''' Raises the CanExecuteChanged event.
        ''' </summary>
        Public Sub RaiseCanExecuteChanged()
            RaiseEvent CanExecuteChanged(Me, EventArgs.Empty)
        End Sub

    End Class

End Class
