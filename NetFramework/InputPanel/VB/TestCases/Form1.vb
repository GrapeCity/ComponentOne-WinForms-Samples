Imports System.Collections.Generic
Imports System.Text
Imports System.Xml
Imports System.Reflection
Imports System.IO

Imports C1.Win.InputPanel

''' <summary>
''' This is the main form, it shows an input panel that can read several
''' layouts encoded in Xml and converts them into a functional dynamic panel.
''' </summary>
Public Class Form1

    Private _items As List(Of XmlNode) = New List(Of XmlNode)()
    Private _currentNode As XmlNode
    Private _inUpdateThemeCombo As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadXml()
    End Sub

    Private Sub reloadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reloadButton.Click
        LoadXml()
    End Sub

    Private Sub LoadXml()
        Dim doc As New XmlDocument()
        doc.Load("TestCases.xml")
        Dim rootNode As XmlNode = doc.SelectSingleNode("C1InputPanelTestCases")
        If rootNode Is Nothing Then
            MessageBox.Show("Missing root tag: C1InputPanelTestCases")
            Exit Sub
        End If
        _currentNode = Nothing
        _items.Clear()
        testCaseCombo.Items.Clear()
        For Each panelNode As XmlNode In rootNode.SelectNodes("C1InputPanel")
            testCaseCombo.Items.Add(XmlUtil.Read(panelNode, "id", "<no name>"))
            _items.Add(panelNode)
        Next
        If _items.Count > 0 Then
            testCaseCombo.SelectedIndex = -1
            testCaseCombo.SelectedIndex = 0
        End If
    End Sub

    Private Sub UpdateThemeCombo()
        _inUpdateThemeCombo = True
        Select Case C1InputPanel1.VisualStyle
            Case VisualStyle.System
                themeCombo.SelectedIndex = 0
            Case VisualStyle.Office2007Blue
                themeCombo.SelectedIndex = 1
            Case VisualStyle.Office2007Black
                themeCombo.SelectedIndex = 2
            Case VisualStyle.Office2007Silver
                themeCombo.SelectedIndex = 3
        End Select
        _inUpdateThemeCombo = False
    End Sub

    Private Sub UpdatePanel()
        xmlTextBox.Text = String.Empty
        C1InputPanel1.BeginUpdate()
        C1InputPanel1.Items.Clear(True)
        C1InputPanel1.VisualStyle = VisualStyle.System
        If _currentNode IsNot Nothing Then
            C1InputPanel1.VisualStyle = CType(System.Enum.Parse(GetType(VisualStyle), _
                    XmlUtil.Read(_currentNode, "visualStyle", "System"), True), VisualStyle)
            LoadNodes(_currentNode.ChildNodes)

            ' display XML in the memo control
            Dim sb As New StringBuilder()
            Dim sw As New StringWriter(sb)
            Dim writer As New XmlTextWriter(sw)
            writer.Formatting = Formatting.Indented
            writer.Indentation = 4
            _currentNode.WriteTo(writer)
            writer.Flush()
            sw.Dispose()
            xmlTextBox.Text = sb.ToString()
        End If
        C1InputPanel1.EndUpdate()
        UpdateThemeCombo()
    End Sub

    Private Sub LoadNodes(ByVal nodeList As XmlNodeList)
        For Each nc As XmlNode In nodeList
            AddInputComponent(nc)
            If nc.Name = "C1InputGroup" Then
                LoadNodes(nc.ChildNodes)
            End If
        Next
    End Sub

    Private Sub ReadCommonProperties(ByVal node As XmlNode, ByVal c As InputComponent, ByVal ignoreWidth As Boolean)
        c.Enabled = XmlUtil.Read(node, "enabled", True)
        c.Visibility = IIf(XmlUtil.Read(node, "visible", True), Visibility.Visible, Visibility.Collapsed)
        c.Height = XmlUtil.Read(node, "height", -1)
        If Not ignoreWidth Then
            c.Width = XmlUtil.Read(node, "width", -1)
        End If
        c.ToolTipText = XmlUtil.Read(node, "tooltip", String.Empty)
        c.Break = CType(System.Enum.Parse(GetType(BreakType), _
                XmlUtil.Read(node, "break", "row"), True), BreakType)
    End Sub

    Private Sub ReadCommonProperties(ByVal node As XmlNode, ByVal c As InputComponent)
        ReadCommonProperties(node, c, False)
    End Sub

    Private Sub AddInputComponent(ByVal node As XmlNode)
        Select Case node.Name
            Case "C1InputButton"
                Dim button As New InputButton()
                ReadCommonProperties(node, button)
                button.Text = XmlUtil.Read(node, "text", String.Empty)
                button.Image = XmlUtil.ReadImage(node, "image")
                button.CheckOnClick = XmlUtil.Read(node, "toggle", False)
                button.Pressed = XmlUtil.Read(node, "pressed", False)
                C1InputPanel1.Items.Add(button)

            Case "C1InputCheckBox"
                Dim checkBox As New InputCheckBox()
                ReadCommonProperties(node, checkBox)
                checkBox.Checked = XmlUtil.Read(node, "checked", False)
                checkBox.ThreeState = XmlUtil.Read(node, "threeState", False)
                checkBox.Text = XmlUtil.Read(node, "text", String.Empty)
                C1InputPanel1.Items.Add(checkBox)

            Case "C1InputComboBox"
                Dim comboBox As New InputComboBox()
                ReadCommonProperties(node, comboBox, True)
                comboBox.DropDownStyle = IIf(XmlUtil.Read(node, "dropDownList", False), _
                        InputComboBoxStyle.DropDownList, InputComboBoxStyle.DropDown)
                comboBox.MaxDropDownItems = XmlUtil.Read(node, "maxDropDownItems", 8)
                comboBox.GripHandleVisible = XmlUtil.Read(node, "gripHandle", False)
                comboBox.Text = XmlUtil.Read(node, "text", String.Empty)
                comboBox.Width = XmlUtil.Read(node, "width", 100)
                comboBox.MaxLength = XmlUtil.Read(node, "maxLength", 250)

                ' parse combobox options
                Dim options As String = XmlUtil.Read(node, "options", String.Empty)
                Dim optList() As String = options.Split(","c)
                Dim i As Int32
                For i = 0 To optList.Length - 1
                    Dim opt As New InputOption()
                    opt.Text = optList(i)
                    comboBox.Items.Add(opt)
                Next
                C1InputPanel1.Items.Add(comboBox)

            Case "C1InputDatePicker"
                Dim datePicker As New InputDatePicker()
                ReadCommonProperties(node, datePicker, True)
                datePicker.Format = XmlUtil.Read(node, "format", String.Empty)
                datePicker.ShowToday = XmlUtil.Read(node, "showToday", True)
                datePicker.Width = XmlUtil.Read(node, "width", 100)
                C1InputPanel1.Items.Add(datePicker)

            Case "C1InputGroup"
                Dim header As New InputGroupHeader()
                header.Text = XmlUtil.Read(node, "text", String.Empty)
                header.Collapsible = XmlUtil.Read(node, "collapsible", False)
                header.Collapsed = XmlUtil.Read(node, "collapsed", False)
                header.Height = XmlUtil.Read(node, "height", 24)
                C1InputPanel1.Items.Add(header)

            Case "C1InputImage"
                Dim image As New InputImage()
                ReadCommonProperties(node, image)
                image.Image = XmlUtil.ReadImage(node, "image")
                C1InputPanel1.Items.Add(image)

            Case "C1InputLabel"
                Dim label As New InputLabel()
                ReadCommonProperties(node, label)
                label.Text = XmlUtil.Read(node, "text", String.Empty)
                label.WordWrap = XmlUtil.Read(node, "wordwrap", False)
                C1InputPanel1.Items.Add(label)

            Case "C1InputRadioButton"
                Dim radioButton As New InputRadioButton()
                ReadCommonProperties(node, radioButton)
                radioButton.Checked = XmlUtil.Read(node, "checked", False)
                radioButton.GroupName = XmlUtil.Read(node, "groupName", String.Empty)
                radioButton.Text = XmlUtil.Read(node, "text", String.Empty)
                C1InputPanel1.Items.Add(radioButton)

            Case "C1InputSeparator"
                Dim separator As New InputSeparator()
                ReadCommonProperties(node, separator)
                C1InputPanel1.Items.Add(separator)

            Case "C1InputTextBox"
                Dim textBox As New InputTextBox()
                ReadCommonProperties(node, textBox, True)
                textBox.Text = XmlUtil.Read(node, "text", String.Empty)
                textBox.Width = XmlUtil.Read(node, "width", 100)
                textBox.MaxLength = XmlUtil.Read(node, "maxLength", 250)
                C1InputPanel1.Items.Add(textBox)

            Case "C1InputNumericBox"
                Dim numBox As New InputNumericBox()
                ReadCommonProperties(node, numBox, True)
                numBox.Format = XmlUtil.Read(node, "format", String.Empty)
                numBox.Text = XmlUtil.Read(node, "value", String.Empty)
                numBox.Increment = Decimal.Parse(XmlUtil.Read(node, "Step", "1"))
                numBox.Width = XmlUtil.Read(node, "width", 100)
                C1InputPanel1.Items.Add(numBox)

            Case "C1InputControlHost"
                Dim className As String = XmlUtil.Read(node, "control", String.Empty)
                If Not String.IsNullOrEmpty(className) Then
                    Dim qualifiedTypeName As String = GetType(Control).AssemblyQualifiedName
                    qualifiedTypeName = qualifiedTypeName.Replace(".Control", "." + className)
                    Dim controlType As Type = Type.GetType(qualifiedTypeName, True)
                    If controlType IsNot Nothing Then
                        Dim ci As ConstructorInfo = controlType.GetConstructor(New Type() {})
                        If ci IsNot Nothing Then
                            Dim obj As Object = ci.Invoke(New Object() {})
                            If TypeOf obj Is Control Then
                                Dim controlHost As New InputControlHost(CType(obj, Control))
                                ReadCommonProperties(node, controlHost)
                                C1InputPanel1.Items.Add(controlHost)
                            End If
                        End If
                    End If
                End If

            Case "C1InputLinkLabel"
                Dim linkText As String = XmlUtil.Read(node, "text", String.Empty)
                If Not String.IsNullOrEmpty(linkText) Then
                    Dim htmlLabel As New InputHtmlLabel()
                    ReadCommonProperties(node, htmlLabel)
                    Dim linkHRef As String = XmlUtil.Read(node, "href", String.Empty)
                    htmlLabel.Text = "<a href='" + linkHRef + "'>" + linkText + "</a>"
                    AddHandler htmlLabel.LinkClicked, AddressOf htmlLabel_LinkClicked
                    C1InputPanel1.Items.Add(htmlLabel)
                End If

            Case Else
                Dim unknown As New InputLabel()
                ReadCommonProperties(node, unknown)
                Dim text As String = XmlUtil.Read(node, "text", String.Empty)
                If text.Length > 0 Then
                    unknown.Text = "< " + node.Name + ", Text = \"" + text + " \ " >"
                Else
                    unknown.Text = "< " + node.Name + " >"
                End If
                C1InputPanel1.Items.Add(unknown)

        End Select
    End Sub

    Private Sub htmlLabel_LinkClicked(ByVal sender As Object, ByVal e As C1.Win.InputPanel.LinkClickedEventArgs)
        MessageBox.Show("Open URL: '" + e.HRef + "'", "Link Clicked")
    End Sub

    Private Sub testCaseCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles testCaseCombo.SelectedIndexChanged
        If _items.Count > 0 And testCaseCombo.SelectedIndex >= 0 Then
            _currentNode = _items(testCaseCombo.SelectedIndex)
            UpdatePanel()
        End If
    End Sub

    Private Sub themeCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles themeCombo.SelectedIndexChanged
        If _inUpdateThemeCombo Then Exit Sub
        Select Case themeCombo.SelectedIndex
            Case 0
                C1InputPanel1.VisualStyle = VisualStyle.System
            Case 1
                C1InputPanel1.VisualStyle = VisualStyle.Office2007Blue
            Case 2
                C1InputPanel1.VisualStyle = VisualStyle.Office2007Black
            Case 3
                C1InputPanel1.VisualStyle = VisualStyle.Office2007Silver
        End Select
    End Sub
End Class
