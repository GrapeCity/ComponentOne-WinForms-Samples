Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TouchEvent
    Partial Public Class AutoRepeatDemo
        Inherits DemoBase
        Private number1 As Integer = 99
        Private number2 As Integer = 99
        Private timer As Timer
        Private timerInterval As Integer
        Private _targetButton As Control = Nothing

        Public Sub New()
            InitializeComponent()
            InitializeDemo()
        End Sub

        Private Sub InitializeDemo()
            Me.Title = "AutoRepeat"
            Me.Description = "Provide your own spin buttons by using Buttons with EnablePressAndHold of C1TouchEventProvider." & vbLf & "    -Try to press and hold on the spin button to increase and decrease the number."

            textBox1.Text = number1.ToString()
            textBox2.Text = number2.ToString()
        End Sub

        Private Sub InputTextBox_Validated(sender As Object, e As EventArgs)
            Dim textboxTmp As TextBox = TryCast(sender, TextBox)
            If textboxTmp IsNot Nothing Then
                Try
                    If Object.ReferenceEquals(textboxTmp, textBox1) Then
                        number1 = Convert.ToInt32(textboxTmp.Text)
                    ElseIf Object.ReferenceEquals(textboxTmp, textBox2) Then
                        number2 = Convert.ToInt32(textboxTmp.Text)
                    End If
                Catch generatedExceptionName As FormatException
                    If Object.ReferenceEquals(textboxTmp, textBox1) Then
                        textboxTmp.Text = number1.ToString()
                    ElseIf Object.ReferenceEquals(textboxTmp, textBox2) Then
                        textboxTmp.Text = number2.ToString()
                    End If
                End Try
            End If
        End Sub

        Private Sub upButton2_Click(sender As Object, e As EventArgs)
            number2 += 1
            textBox2.Text = number2.ToString()
        End Sub

        Private Sub downButton2_Click(sender As Object, e As EventArgs)
            number2 -= 1
            textBox2.Text = number2.ToString()
        End Sub

        Private Sub gcTouchEventProvider1_Tapped(sender As Object, e As C1.Win.TouchToolKit.TappedEventArgs) Handles gcTouchEventProvider1.Tapped
            _targetButton = e.TargetControl
            UpdateValueBySpinButon()
        End Sub

        Private Sub UpdateValueBySpinButon()
            If Object.ReferenceEquals(_targetButton, upButton1) Then
                number1 += 1
                textBox1.Text = number1.ToString()
            ElseIf Object.ReferenceEquals(_targetButton, downButton1) Then
                number1 -= 1
                textBox1.Text = number1.ToString()
            End If
        End Sub

        Private Sub gcTouchEventProvider1_PointerPressed(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs) Handles gcTouchEventProvider1.PointerPressed
            _targetButton = e.TargetControl
            StartTimer()
        End Sub

        Private Sub gcTouchEventProvider1_PointerReleased(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs) Handles gcTouchEventProvider1.PointerReleased
            _targetButton = Nothing
            StopTimer()
        End Sub

        Private Sub StartTimer()
            If timer Is Nothing Then
                timer = New Timer()
                AddHandler timer.Tick, AddressOf timer_Tick
            End If
            timerInterval = 500
            timer.Interval = timerInterval
            timer.Start()
        End Sub

        Private Sub StopTimer()
            If timer IsNot Nothing Then
                timer.[Stop]()
                timer.Dispose()
                timer = Nothing
            End If
        End Sub

        Private Sub timer_Tick(sender As Object, e As EventArgs)
            UpdateValueBySpinButon()

            timerInterval *= 7
            timerInterval /= 10
            If timerInterval < 1 Then
                timerInterval = 1
            End If
            timer.Interval = timerInterval
        End Sub
    End Class
End Namespace
