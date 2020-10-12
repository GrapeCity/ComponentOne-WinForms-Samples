Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports ClickOnceDemo.C1ZoomPages.Help_Forms
Imports C1.Win.TouchToolKit
Imports TouchToolKitDemo.C1ZoomPages.Help_Forms

Namespace C1ZoomPages
    Partial Public Class PanWindowDemo
        Inherits DemoBase
        Private _formStartPosition As FormStartPosition
        Private _size As Size
        Private _location As Point
        Private _selectedMethodName As String

        Public Sub New()
            InitializeComponent()
            InitializeDemo()
        End Sub

        Private Sub InitializeDemo()
            Me.Title = "Pan Window"
            Me.Description = "This page is used to show pan window. User can use pan window to see whole form, and scroll the owner form quickly by click/drag mouse or finger."

            noPRadioButton.Checked = True
            ManualRadioButton.Checked = True
            formStartPositionGroupBox.Visible = False
            sizePanel.Visible = False
            locationPanel.Visible = False
            locationErrorLabel.Visible = False
            sizeErrorLabel.Visible = False
            _formStartPosition = FormStartPosition.Manual
            _size = New System.Drawing.Size(200, 200)
            _location = New Point(200, 200)
            _selectedMethodName = noPRadioButton.Text

            AddHandler lsRadioButton.CheckedChanged, AddressOf MethodRadioButton_CheckedChanged
            AddHandler ssRadioButton.CheckedChanged, AddressOf MethodRadioButton_CheckedChanged
            AddHandler lRadioButton.CheckedChanged, AddressOf MethodRadioButton_CheckedChanged
            AddHandler sRadioButton.CheckedChanged, AddressOf MethodRadioButton_CheckedChanged
            AddHandler noPRadioButton.CheckedChanged, AddressOf MethodRadioButton_CheckedChanged

            AddHandler ManualRadioButton.CheckedChanged, AddressOf FormStartPositionRadioButton_CheckedChanged
            AddHandler CenterParentRadioButton.CheckedChanged, AddressOf FormStartPositionRadioButton_CheckedChanged
            AddHandler CenterScreenRadioButton.CheckedChanged, AddressOf FormStartPositionRadioButton_CheckedChanged
            AddHandler WindowsDefaultBoundsRadioButton.CheckedChanged, AddressOf FormStartPositionRadioButton_CheckedChanged
            AddHandler WindowsDefaultLocationRadioButton.CheckedChanged, AddressOf FormStartPositionRadioButton_CheckedChanged

            AddHandler wTextBox.Validated, AddressOf SizeTextBox_Validated
            AddHandler hTextBox.Validated, AddressOf SizeTextBox_Validated
            AddHandler xTextBox.Validated, AddressOf LocationTextBox_Validated
            AddHandler xTextBox.Validated, AddressOf LocationTextBox_Validated
        End Sub

        Private Sub MethodRadioButton_CheckedChanged(sender As Object, e As EventArgs)
            If ssRadioButton.Checked Then
                formStartPositionGroupBox.Visible = True
                sizePanel.Visible = True
                locationPanel.Visible = False
                _selectedMethodName = ssRadioButton.Text
            ElseIf lsRadioButton.Checked Then
                formStartPositionGroupBox.Visible = False
                sizePanel.Visible = True
                locationPanel.Visible = True
                _selectedMethodName = lsRadioButton.Text
            ElseIf lRadioButton.Checked Then
                formStartPositionGroupBox.Visible = False
                sizePanel.Visible = False
                locationPanel.Visible = True
                _selectedMethodName = lRadioButton.Text
            ElseIf sRadioButton.Checked Then
                formStartPositionGroupBox.Visible = True
                sizePanel.Visible = False
                locationPanel.Visible = False
                _selectedMethodName = sRadioButton.Text
            ElseIf noPRadioButton.Checked Then
                formStartPositionGroupBox.Visible = False
                sizePanel.Visible = False
                locationPanel.Visible = False
                _selectedMethodName = noPRadioButton.Text
            End If
        End Sub

        Private Sub FormStartPositionRadioButton_CheckedChanged(sender As Object, e As EventArgs)
            If ManualRadioButton.Checked Then
                _formStartPosition = FormStartPosition.Manual
            ElseIf CenterParentRadioButton.Checked Then
                _formStartPosition = FormStartPosition.CenterParent
            ElseIf CenterScreenRadioButton.Checked Then
                _formStartPosition = FormStartPosition.CenterScreen
            ElseIf WindowsDefaultBoundsRadioButton.Checked Then
                _formStartPosition = FormStartPosition.WindowsDefaultBounds
            ElseIf WindowsDefaultLocationRadioButton.Checked Then
                _formStartPosition = FormStartPosition.WindowsDefaultLocation
            End If
        End Sub

        Private Sub LocationTextBox_Validated(sender As Object, e As EventArgs)
            Try
                Dim x As Integer = Convert.ToInt32(xTextBox.Text)
                Dim y As Integer = Convert.ToInt32(yTextBox.Text)
                _location = New Point(x, y)
                locationErrorLabel.Visible = False
            Catch generatedExceptionName As Exception
                locationErrorLabel.Visible = True
            End Try
        End Sub

        Private Sub SizeTextBox_Validated(sender As Object, e As EventArgs)
            Try
                Dim w As Integer = Convert.ToInt32(wTextBox.Text)
                Dim h As Integer = Convert.ToInt32(hTextBox.Text)
                _size = New Size(w, h)
                sizeErrorLabel.Visible = False
            Catch generatedExceptionName As Exception
                sizeErrorLabel.Visible = True
            End Try
        End Sub

        Private Sub formButton_Click(sender As Object, e As EventArgs)
            If Not locationErrorLabel.Visible AndAlso Not sizeErrorLabel.Visible Then
                Using form As New PanWindowForm(_selectedMethodName, _size, _location, _formStartPosition)
                    form.StartPosition = FormStartPosition.CenterParent
                    ' The _gcZoom will auto detach when the Form dispose.
                    '_gcZoom.SetEnabled(form, false);
                    form.ShowDialog(Me)
                End Using
            End If
        End Sub
    End Class
End Namespace
