Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles

Namespace TouchEvent
    Partial Public Class ContextualUIDemo
        Inherits DemoBase
#Region "Field"
        Private colorDropDown As New ToolStripDropDown()
        Private colorPicker As New ColorUserControl()
        Private fontFamilyDropDown As New ToolStripDropDown()
        Private fontSizeDropDown As New ToolStripDropDown()
        Private fontFamilyListobx As New ListBox()
        Private fontSizeListbox As New ListBox()
        Private bigFont As Font
        Private normalFont As Font
        Private fontSize As Integer = 9
        Private fontSizeList As String() = New String() {"8", "9", "10", "11", "12", "14", _
            "16", "18", "20", "22", "24", "26", _
            "28", "36", "48", "72"}
        Private _isTouch As Boolean = False
#End Region

#Region "Init"

        Public Sub New()
            InitializeComponent()
            InitializeControls()
        End Sub

        Private Sub InitializeControls()
            Me.Title = "Contextual UI"
            Me.Description = "Provide a normal contextual UI for Mouse click. For tap, user can show a larger UI by Touch event of C1TouchEventProvider. " & vbCr & vbLf & "  - Try to change preview string's font."

            bigFont = New System.Drawing.Font(Me.Font.FontFamily, 18)
            normalFont = New System.Drawing.Font(Me.Font.FontFamily, 9)

            fontSizeListbox.Font = normalFont
            fontSizeListbox.MaximumSize = New System.Drawing.Size(fontSizeButtonForTouch.Width, 200)
            fontSizeListbox.MinimumSize = New System.Drawing.Size(fontSizeButtonForTouch.Width, 200)
            fontSizeListbox.BorderStyle = System.Windows.Forms.BorderStyle.None
            AddHandler fontSizeListbox.SelectedIndexChanged, AddressOf fontSizeListbox_SelectedIndexChanged
            For i As Integer = 0 To fontSizeList.Length - 1
                fontSizeListbox.Items.Add(fontSizeList(i))
            Next
            fontSizeListbox.SelectedIndex = 1
            fontSizeDropDown.Items.Add(New ToolStripControlHost(fontSizeListbox))

            Dim fonts As New System.Drawing.Text.InstalledFontCollection()
            fontFamilyListobx.Font = normalFont
            fontFamilyListobx.MaximumSize = New System.Drawing.Size(500, 200)
            fontFamilyListobx.BorderStyle = System.Windows.Forms.BorderStyle.None
            AddHandler fontFamilyListobx.SelectedIndexChanged, AddressOf listobx_SelectedIndexChanged
            AddHandler fontFamilyTextBoxForTouch.Validated, AddressOf fontFamilyTextBox_Validated
            AddHandler fontFamilyTextBoxNormal.Validated, AddressOf fontFamilyTextBox_Validated
            For Each family As System.Drawing.FontFamily In fonts.Families
                fontFamilyListobx.Items.Add(family.Name)
            Next
            fontFamilyListobx.SelectedItem = preViewLabel.Font.FontFamily.Name.ToString()
            fontFamilyButtonForTouch.Tag = fontFamilyTextBoxForTouch
            fontFamilyButtonNormal.Tag = fontFamilyTextBoxNormal
            fontFamilyDropDown.Items.Add(New ToolStripControlHost(fontFamilyListobx))

            AddHandler colorPicker.ValueChanged, AddressOf colorPicker_ValueChanged
            colorDropDown.Items.Add(New ToolStripControlHost(colorPicker))

            AddHandler colorDropDown.Closing, AddressOf contextMenuStrip1_Closing
            AddHandler fontFamilyDropDown.Closing, AddressOf contextMenuStrip1_Closing
            AddHandler fontSizeDropDown.Closing, AddressOf contextMenuStrip1_Closing

            AddHandler colorButtonForTouch.Click, AddressOf colorButton_Click
            AddHandler fontSizeButtonForTouch.Click, AddressOf fontSizeButton_Click
            AddHandler fontFamilyButtonForTouch.Click, AddressOf fontFamilyButton_Click
            AddHandler fontFamilyButtonForTouch.Paint, AddressOf DropDownButton_Paint
            AddHandler fontSizeButtonForTouch.Paint, AddressOf DropDownButton_Paint

            AddHandler colorButtonNormal.Click, AddressOf colorButton_Click
            AddHandler fontSizeButtonNormal.Click, AddressOf fontSizeButton_Click
            AddHandler fontFamilyButtonNormal.Click, AddressOf fontFamilyButton_Click
            AddHandler fontFamilyButtonNormal.Paint, AddressOf DropDownButton_Paint
            AddHandler fontSizeButtonNormal.Paint, AddressOf DropDownButton_Paint
        End Sub

#End Region

#Region "forecolor"

        Private Sub colorPicker_ValueChanged(sender As Object, e As EventArgs)
            preViewLabel.ForeColor = colorPicker.Color
            colorButtonForTouch.BackColor = colorPicker.Color
            colorButtonNormal.BackColor = colorPicker.Color
            colorDropDown.Close()
        End Sub

        Private Sub colorButton_Click(sender As Object, e As EventArgs)
            colorPicker.IsNormalSize = Not _isTouch
            _isTouch = False

            If colorDropDown.Visible Then
                colorDropDown.Close()
            Else
                colorDropDown.Size = colorPicker.Size
                Dim control As Control = TryCast(sender, Control)
                colorDropDown.Tag = control
                colorDropDown.Show(control, New Point(0, control.Height))
            End If
        End Sub

#End Region

#Region "fontsize"

        Private Sub fontSizeButton_Click(sender As Object, e As EventArgs)
            If _isTouch Then
                fontSizeListbox.Font = bigFont
            Else
                fontSizeListbox.Font = normalFont
            End If
            _isTouch = False


            If fontSizeDropDown.Visible Then
                fontSizeDropDown.Close()
            Else
                Dim control = TryCast(sender, Control)
                fontSizeDropDown.Tag = control
                Dim selectedIndex As Integer = fontSizeListbox.SelectedIndex
                fontSizeListbox.SelectedIndex = -1
                fontSizeListbox.SelectedIndex = selectedIndex
                fontSizeDropDown.Show(control, New Point(0, control.Height))
            End If
        End Sub

        Private Sub fontSizeListbox_SelectedIndexChanged(sender As Object, e As EventArgs)
            If fontSizeListbox.SelectedItem IsNot Nothing Then
                fontSizeDropDown.Close()
                fontSize = Convert.ToInt32(fontSizeListbox.SelectedItem)
                fontSizeButtonNormal.Text = fontSize.ToString()
                fontSizeButtonForTouch.Text = fontSize.ToString()
                FreshPreviewFont()
            End If
        End Sub

#End Region

#Region "fontfamily"

        Private Sub fontFamilyButton_Click(sender As Object, e As EventArgs)
            If _isTouch Then
                fontFamilyListobx.Font = bigFont
            Else
                fontFamilyListobx.Font = normalFont
            End If
            _isTouch = False

            If fontFamilyDropDown.Visible Then
                fontFamilyDropDown.Close()
            Else
                Dim textControl As Control = TryCast(TryCast(sender, Control).Tag, Control)
                Dim control As Control = TryCast(sender, Control)
                fontFamilyDropDown.Tag = control
                fontFamilyDropDown.Show(textControl, New Point(0, textControl.Height))
            End If
        End Sub

        Private Sub listobx_SelectedIndexChanged(sender As Object, e As EventArgs)
            fontFamilyDropDown.Close()
            fontFamilyTextBoxForTouch.Text = fontFamilyListobx.SelectedItem.ToString()
            fontFamilyTextBoxNormal.Text = fontFamilyTextBoxForTouch.Text
            FreshPreviewFont()
        End Sub

        Private Sub fontFamilyTextBox_Validated(sender As Object, e As EventArgs)
            Dim textBox As TextBox = TryCast(sender, TextBox)
            If textBox IsNot Nothing Then
                fontFamilyListobx.SelectedItem = textBox.Text
                fontFamilyTextBoxForTouch.Text = fontFamilyListobx.SelectedItem.ToString()
                fontFamilyTextBoxNormal.Text = fontFamilyTextBoxForTouch.Text
                FreshPreviewFont()
            End If
        End Sub

#End Region

#Region "Other"

        Private Sub DropDownButton_Paint(sender As Object, e As PaintEventArgs)
            Dim start As Integer = TryCast(sender, Button).ClientSize.Width - 25
            e.Graphics.DrawLine(SystemPens.ControlText, New Point(start + 9, 11), New Point(start + 9, 13))
            e.Graphics.DrawLine(SystemPens.ControlText, New Point(start + 10, 12), New Point(start + 10, 14))
            e.Graphics.DrawLine(SystemPens.ControlText, New Point(start + 11, 13), New Point(start + 11, 15))
            e.Graphics.DrawLine(SystemPens.ControlText, New Point(start + 12, 14), New Point(start + 12, 16))
            e.Graphics.DrawLine(SystemPens.ControlText, New Point(start + 13, 13), New Point(start + 13, 15))
            e.Graphics.DrawLine(SystemPens.ControlText, New Point(start + 14, 12), New Point(start + 14, 14))
            e.Graphics.DrawLine(SystemPens.ControlText, New Point(start + 15, 11), New Point(start + 15, 13))
        End Sub

        Private Sub contextMenuStrip1_Closing(sender As Object, e As ToolStripDropDownClosingEventArgs)
            If e.CloseReason = ToolStripDropDownCloseReason.AppClicked Then
                Dim owner As Control = TryCast(TryCast(sender, ToolStripDropDown).Tag, Control)
                If owner IsNot Nothing Then
                    Dim point As Point = owner.PointToClient(Control.MousePosition)
                    If owner.ClientRectangle.Contains(owner.PointToClient(Control.MousePosition)) Then
                        e.Cancel = True
                    End If
                End If
            End If
        End Sub

        Private Sub FreshPreviewFont()
            If fontFamilyListobx.SelectedItem IsNot Nothing Then
                If preViewLabel.Font IsNot Nothing Then
                    preViewLabel.Font.Dispose()
                    preViewLabel.Font = Nothing
                End If
                preViewLabel.Font = New Font(fontFamilyListobx.SelectedItem.ToString(), fontSize)
            End If
        End Sub

        Private Sub gcTouchEventProvider1_Tapped(sender As Object, e As C1.Win.TouchToolKit.TappedEventArgs) Handles gcTouchEventProvider1.Tapped
            If e.PointerDeviceType = C1.Win.TouchToolKit.PointerDeviceType.Touch Then
                If Object.ReferenceEquals(e.TargetControl, colorButtonForTouch) OrElse Object.ReferenceEquals(e.TargetControl, fontSizeButtonForTouch) OrElse Object.ReferenceEquals(e.TargetControl, fontFamilyButtonForTouch) Then
                    _isTouch = True
                End If
            End If
        End Sub

#End Region
    End Class
End Namespace
