Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1Ribbon
Imports ControlHostLib

Public Class DemoForm

    Private _internalFontChange As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim f As Font = label1.Font
        _internalFontChange = True
        fontEditor.SelectedFont = f
        numericUpDownHost1.Value = Convert.ToDecimal(f.SizeInPoints)
        _internalFontChange = False

        backColorEditor.SelectedColor = label1.BackColor
        foreColorEditor.SelectedColor = label1.ForeColor

        axWebBrowserHost1.Navigate(Application.StartupPath + "\..\..\Html\A plea for C++.htm")

    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click, RibbonApplicationMenu1.DoubleClick
        Close()
    End Sub

    Private Sub pictureBoxHost1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBoxHost1.Click
        MessageBox.Show("You clicked the Earth.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub numericUpDownHost1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numericUpDownHost1.ValueChanged
        If Not _internalFontChange Then
            Dim f As Font = label1.Font
            f = New Font(f.Name, Convert.ToSingle(numericUpDownHost1.Value), f.Style, f.Unit)
            _internalFontChange = True
            label1.Font = f
            fontEditor.SelectedFont = f
            _internalFontChange = False
        End If
        statusLabel.Text = String.Format("Number is {0}", numericUpDownHost1.Value)
    End Sub

    Private Sub checkedListBoxHost1_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles checkedListBoxHost1.ItemCheck
        Dim coll As CheckedListBox.ObjectCollection = checkedListBoxHost1.Items
        Dim sb As StringBuilder = New StringBuilder()
        For i As Int32 = 0 To coll.Count - 1
            Dim isChecked As Boolean = False
            If i = e.Index Then
                If e.NewValue = CheckState.Checked Then
                    isChecked = True
                Else
                    isChecked = False
                End If
            Else
                isChecked = checkedListBoxHost1.GetItemChecked(i)
            End If
            If isChecked Then
                sb.Append(coll(i)).Append(", ")
            End If
        Next
        Dim res As String
        If sb.Length > 0 Then
            res = sb.ToString(0, sb.Length - 2)
            label1.Text = res
        Else
            res = "<none>"
            label1.Text = "Demo"
        End If
        checkStatusLabel.Text = "Checked: " + res
    End Sub

    Private Sub backColorEditor_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backColorEditor.SelectedColorChanged
        label1.BackColor = backColorEditor.SelectedColor
    End Sub

    Private Sub foreColorEditor_SelectedColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles foreColorEditor.SelectedColorChanged
        label1.ForeColor = foreColorEditor.SelectedColor
    End Sub

    Private Sub fontEditor_SelectedFontChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fontEditor.SelectedFontChanged
        If Not _internalFontChange Then
            _internalFontChange = True
            label1.Font = fontEditor.SelectedFont
            numericUpDownHost1.Value = Convert.ToDecimal(fontEditor.SelectedFont.SizeInPoints)
            _internalFontChange = False
        End If
    End Sub

    Private Sub DemoForm_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        axWebBrowserHost1.Width = Width - 40
    End Sub

    Private Sub rbLoad_Click(sender As Object, e As EventArgs) Handles rbLoad.Click
        Using dlg As OpenFileDialog = New OpenFileDialog()
            dlg.DefaultExt = ".xml"
            dlg.Filter = "XML files|*.xml|All files|*.*"
            dlg.Title = "Load From XML File"
            If dlg.ShowDialog() = DialogResult.OK Then
                Try
                    C1Ribbon1.Load(dlg.FileName)
                Catch
                    MessageBox.Show("Bad Ribbon XML.", dlg.Title)
                End Try
            End If
        End Using
    End Sub

    Private Sub rbSave_Click(sender As Object, e As EventArgs) Handles rbSave.Click
        Using dlg As SaveFileDialog = New SaveFileDialog()
            dlg.DefaultExt = ".xml"
            dlg.FileName = "ribbon"
            dlg.Filter = "XML files|*.xml|All files|*.*"
            dlg.Title = "Save As XML File"
            If dlg.ShowDialog() = DialogResult.OK Then
                C1Ribbon1.Save(dlg.FileName)
            End If
        End Using
    End Sub

    Private Sub rbClear_Click(sender As Object, e As EventArgs) Handles rbClear.Click
        C1Ribbon1.Tabs.ClearAndDisposeTabs()
    End Sub

    Private Sub C1Ribbon1_ControlHostFromXmlNode(sender As Object, e As ControlHostFromXmlNodeEventArgs) Handles C1Ribbon1.ControlHostFromXmlNode
        Select Case e.NodeName
            Case PictureBoxHost.XmlNodeName
                e.ControlHost = New PictureBoxHost()
            Case NumericUpDownHost.XmlNodeName
                e.ControlHost = New NumericUpDownHost()
            Case FontEditorHost.XmlNodeName
                e.ControlHost = New FontEditorHost()
            Case ColorEditorHost.XmlNodeName
                e.ControlHost = New ColorEditorHost()
            Case CheckedListBoxHost.XmlNodeName
                e.ControlHost = New CheckedListBoxHost()
            Case AxWebBrowserHost.XmlNodeName
                e.ControlHost = New AxWebBrowserHost()
        End Select
    End Sub

    Private Sub C1Ribbon1_ItemDeserialized(sender As Object, e As ItemDeserializedEventArgs) Handles C1Ribbon1.ItemDeserialized
        Select Case e.Item.Name
            Case "exitButton"
                exitButton = CType(e.Item, RibbonButton)
                AddHandler exitButton.Click, AddressOf exitButton_Click
            Case "ribbonApplicationMenu1"
                RibbonApplicationMenu1 = CType(e.Item, RibbonApplicationMenu)
                AddHandler RibbonApplicationMenu1.DoubleClick, AddressOf exitButton_Click
            Case "pictureBoxHost1"
                pictureBoxHost1 = CType(e.Item, PictureBoxHost)
                AddHandler pictureBoxHost1.Click, AddressOf pictureBoxHost1_Click
            Case "numericUpDownHost1"
                numericUpDownHost1 = CType(e.Item, NumericUpDownHost)
                AddHandler numericUpDownHost1.ValueChanged, AddressOf numericUpDownHost1_ValueChanged
            Case "checkedListBoxHost1"
                checkedListBoxHost1 = CType(e.Item, CheckedListBoxHost)
                AddHandler checkedListBoxHost1.ItemCheck, AddressOf checkedListBoxHost1_ItemCheck
            Case "backColorEditor"
                backColorEditor = CType(e.Item, ColorEditorHost)
                AddHandler backColorEditor.SelectedColorChanged, AddressOf backColorEditor_SelectedColorChanged
            Case "foreColorEditor"
                foreColorEditor = CType(e.Item, ColorEditorHost)
                AddHandler foreColorEditor.SelectedColorChanged, AddressOf foreColorEditor_SelectedColorChanged
            Case "fontEditor"
                fontEditor = CType(e.Item, FontEditorHost)
                AddHandler fontEditor.SelectedFontChanged, AddressOf fontEditor_SelectedFontChanged
            Case "axWebBrowserHost1"
                axWebBrowserHost1 = CType(e.Item, AxWebBrowserHost)
                AddHandler exitButton.Click, AddressOf exitButton_Click
                axWebBrowserHost1.Navigate(Application.StartupPath & "\..\..\Html\A plea for C++.htm")
        End Select
    End Sub

    Private Sub C1Ribbon1_RibbonDeserialized(sender As Object, e As EventArgs) Handles C1Ribbon1.RibbonDeserialized
        numericUpDownHost1_ValueChanged(Me, EventArgs.Empty)
        backColorEditor_SelectedColorChanged(Me, EventArgs.Empty)
        foreColorEditor_SelectedColorChanged(Me, EventArgs.Empty)
        fontEditor_SelectedFontChanged(Me, EventArgs.Empty)
        checkedListBoxHost1_ItemCheck(Me, New ItemCheckEventArgs(-1, CheckState.Indeterminate, CheckState.Indeterminate))
    End Sub
End Class
