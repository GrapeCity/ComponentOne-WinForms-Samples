Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.TouchToolKit
Imports System.ComponentModel.Design

Imports TouchToolKitDemoVB.C1ZoomPages.Help_Forms

Namespace C1ZoomPages
    Partial Public Class ZoomPolicyDemo
        Inherits DemoBase
        Private _provider As ZoomPolicyProvider
        Public Sub New()
            InitializeComponent()

            Me.Title = "Zoom Policy"
            Me.Description = "ZoomPolicy class is used to customize the zoom policy for specific controls." & vbCr & vbLf & "  - Please select a zoom policy in the listbox, then click the Show Form Button to show a test form."
            _provider = New ZoomPolicyProvider()

            Dim groups As String() = _provider.PolicyGroups
            If groups.Length > 1 Then
                Me.groupBox1.Visible = True
                For Each group As String In groups
                    CreateRadioButton(group)
                Next
                Dim y As Integer = 23 + groupBox1.ClientRectangle.Y
                For Each button As RadioButton In Me.groupBox1.Controls
                    button.Location = New Point(6, y)
                    y += button.Height + 3
                Next
                TryCast(Me.groupBox1.Controls(0), RadioButton).Checked = True
            Else
                Me.tableLayoutPanel1.SetColumnSpan(listBox1, 2)
                listBox1.Tag = groups(0)
                listBox1.DataSource = _provider.GetZoomPolicies(groups(0))
                listBox1.SelectedIndex = 0
            End If
        End Sub

        Private Sub CreateRadioButton(group As String)
            Dim radioButton As New RadioButton()
            radioButton.AutoSize = True
            radioButton.Text = group
            AddHandler radioButton.CheckedChanged, AddressOf radioButton_CheckedChanged
            Me.groupBox1.Controls.Add(radioButton)

        End Sub

        Private Sub radioButton_CheckedChanged(sender As Object, e As EventArgs)
            Dim radioButton As RadioButton = TryCast(sender, RadioButton)
            If radioButton IsNot Nothing AndAlso radioButton.Checked Then
                listBox1.DataSource = _provider.GetZoomPolicies(radioButton.Text)
                listBox1.Tag = radioButton.Text
                If listBox1.Items.Count > 0 Then
                    listBox1.SelectedIndex = 0
                End If
            End If
            listBox1_SelectedIndexChanged(Me, EventArgs.Empty)
        End Sub

        Private Sub formButton_Click(sender As Object, e As EventArgs)
            Dim form As New ZoomPolicyForm(Me._provider, TryCast(listBox1.Tag, String), listBox1.SelectedItem.ToString())
            form.ShowDialog(Me)
        End Sub

        Private Sub listBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
            If listBox1.SelectedIndex < 0 Then
                Me.description1.Text = ""
            Else
                Me.description1.Text = _provider.GetDescription(TryCast(listBox1.Tag, String), listBox1.SelectedItem.ToString())
            End If
        End Sub
    End Class

    Public Interface IZoomPolicyProvider
        ReadOnly Property PolicyGroups() As String()
        Function GetZoomPolicies(policyGroup As String) As String()
        Function GetControl(policyGroup As String, zoomPolicy As String, font As Font, layoutSize As Size) As Control
        Function GetZoomPolicy(policyGroup As String, zoomPolicy As String) As ZoomPolicy
        Function GetDemoSize(policyGroup As String, zoomPolicy As String) As System.Nullable(Of Size)
    End Interface

    Public MustInherit Class ZoomPolicyProviderBase
        Implements IZoomPolicyProvider
        Friend Const Standard As String = "Standard"
        Private builtInZoomPolicy As String() = New String() {"ComboBoxZoomPolicy", "DataGridViewZoomPolicy", "FlowLayoutPanelZoomPolicy", "ListBoxZoomPolicy", "ListViewZoomPolicy", "MonthCalendarZoomPolicy",
            "PictureBoxZoomPolicy", "PropertyGridZoomPolicy", "SplitContainerZoomPolicy", "TableLayoutPanelZoomPolicy", "ToolStripZoomPolicy", "TreeViewZoomPolicy"}

        Public MustOverride ReadOnly Property PolicyGroups() As String() Implements IZoomPolicyProvider.PolicyGroups

        Public Overridable Function GetZoomPolicies(policyGroup As String) As String() Implements IZoomPolicyProvider.GetZoomPolicies
            Return builtInZoomPolicy
        End Function

        Public Overridable Function GetZoomPolicy(policyGroup As String, zoomPolicy As String) As ZoomPolicy Implements IZoomPolicyProvider.GetZoomPolicy
            Return Nothing
        End Function

        Public Overridable Function GetDescription(policyGroup As String, zoomPolicy As String) As String
            Select Case zoomPolicy
                Case "ComboBoxZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_ComboBox
                Case "DataGridViewZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_DataGridView
                Case "FlowLayoutPanelZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_FlowLayoutPanel
                Case "ListBoxZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_ListBox
                Case "ListViewZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_ListView
                Case "MonthCalendarZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_MonthCalendar
                Case "PictureBoxZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_PictureBox
                Case "PropertyGridZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_PropertyGrid
                Case "SplitContainerZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_SplitContainer
                Case "TableLayoutPanelZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_TableLayoutPanel
                Case "ToolStripZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_ToolStrip
                Case "TreeViewZoomPolicy"
                    Return My.Resources.ZoomPolicy_Strd_TreeView
                Case Else
                    Exit Select
            End Select
            Return ""
        End Function

        Public Overridable Function GetDemoSize(policyGroup As String, zoomPolicy As String) As System.Nullable(Of Size) Implements IZoomPolicyProvider.GetDemoSize
            Return Nothing
        End Function

        Protected _font As Font
        Protected _layoutSize As Size
        Public Overridable Function GetControl(policyGroup As String, zoomPolicy As String, font As Font, layoutSize As Size) As Control Implements IZoomPolicyProvider.GetControl
            _font = font
            _layoutSize = layoutSize
            Select Case zoomPolicy
                Case "ComboBoxZoomPolicy"
                    Return CreateComboBox()
                Case "DataGridViewZoomPolicy"
                    Return CreateDataGridView()
                Case "ListBoxZoomPolicy"
                    Return CreateListBox()
                Case "TreeViewZoomPolicy"
                    Return CreateTreeView()
                Case "ListViewZoomPolicy"
                    Return CreateListView()
                Case "MonthCalendarZoomPolicy"
                    Return CreateMonthCalendar()
                Case "TableLayoutPanelZoomPolicy"
                    Return CreateTableLayoutPanel()
                Case "SplitContainerZoomPolicy"
                    Return CreateSplitContainer()
                Case "PictureBoxZoomPolicy"
                    Return CreatePictureBox()
                Case "ToolStripZoomPolicy"
                    Return CreateToolStrip()
                Case "PropertyGridZoomPolicy"
                    Return CreatePropertyGrid()
                Case "FlowLayoutPanelZoomPolicy"
                    Return CreateFlowLayoutPanel()
            End Select
            Return Nothing
        End Function

        Friend Shared Sub PutControlInCenter(c As Control, layoutSize As Size)
            c.Location = New Point(layoutSize.Width / 2 - c.Size.Width / 2, layoutSize.Height / 2 - c.Size.Height / 2)
        End Sub


        Friend Shared Function AddComments(control As Control, comments As String) As Control
            Dim panel As New Panel()
            panel.Dock = DockStyle.Fill
            Dim label As New Label()
            label.Text = comments
            label.AutoSize = False
            label.Location = New Point(10, 10)
            label.Size = New Size(panel.ClientSize.Width - 15, 50)
            label.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Right
            panel.Controls.Add(label)
            panel.Controls.Add(control)
            Return panel

        End Function

        Private Function CreateComboBox() As Control
            Dim panel As New Panel()
            panel.Dock = DockStyle.Fill
            Dim label As New Label() With { _
                .Text = "Please select a part of text in combobox, then do zoom." _
            }
            label.AutoSize = True
            label.Location = New Point(10, 10)
            Dim comboBox As New ComboBox()
            PutControlInCenter(comboBox, _layoutSize)
            comboBox.DataSource = [Enum].GetValues(GetType(DockStyle))
            panel.Controls.Add(label)
            panel.Controls.Add(comboBox)
            Return panel
        End Function

        Private Function CreateDataGridView() As DataGridView
            Dim dataGridView As New DataGridView()
            dataGridView.Dock = DockStyle.Fill
            dataGridView.RowCount = 10
            dataGridView.ColumnCount = 5
            For i As Integer = 0 To dataGridView.RowCount - 1
                For j As Integer = 0 To dataGridView.ColumnCount - 1
                    dataGridView(j, i).Value = i.ToString() + j
                Next
            Next
            Return dataGridView
        End Function

        Private Function CreateListBox() As ListBox
            Dim listBox As New ListBox()
            listBox.FormattingEnabled = True
            listBox.HorizontalScrollbar = True
            listBox.Items.AddRange(New Object() {" column 1", " column 1", " column 1", " column 1", " column 1", " column 1", _
                " column 1", " column 1", " column 1", " column 1", " column 1", " column 1", _
                " column 1", " column 1", " column 1", " column 1", " column 1", " column 1", _
                " column 1", " column 1", " column 1", " column 1", " column 1", " column 1", _
                " column 2", " column 2", " column 2", " column 2", " column 2", " column 2", _
                " column 2", " column 2", " column 2", " column 2", " column 2"})
            listBox.ColumnWidth = 50
            listBox.MultiColumn = True
            listBox.Dock = DockStyle.Fill
            Return listBox
        End Function

        Private Function CreateTreeView() As TreeView
            Dim treeView As New TreeView()
            treeView.Size = New System.Drawing.Size(200, 150)
            PutControlInCenter(treeView, _layoutSize)
            treeView.ItemHeight = 20
            treeView.Nodes.Add("Node1")
            treeView.Nodes.Add("Node2")
            treeView.Nodes.Add("Node3")
            treeView.Nodes.Add("Node4")
            treeView.Nodes.Add("Node5")
            Return treeView
        End Function

        Private Function CreateListView() As ListView
            Dim listView As New ListView()
            listView.Dock = DockStyle.Fill
            listView.View = View.Details
            listView.GridLines = True
            Dim item1 As New ListViewItem("item1", 0)
            item1.Checked = True
            item1.SubItems.Add("1")
            item1.SubItems.Add("2")
            item1.SubItems.Add("3")
            Dim item2 As New ListViewItem("item2", 1)
            item2.SubItems.Add("4")
            item2.SubItems.Add("5")
            item2.SubItems.Add("6")
            Dim item3 As New ListViewItem("item3", 0)
            item3.Font = _font
            item3.Checked = True
            item3.SubItems.Add("7")
            item3.SubItems.Add("8")
            item3.SubItems.Add("9")
            listView.Columns.Add("Item Column", -2, HorizontalAlignment.Left)
            listView.Columns.Add("Column 2", -2, HorizontalAlignment.Left)
            listView.Columns.Add("Column 3", -2, HorizontalAlignment.Left)
            listView.Columns.Add("Column 4", -2, HorizontalAlignment.Center)
            listView.Items.AddRange(New ListViewItem() {item1, item2, item3})
            Return listView
        End Function

        Private Function CreateMonthCalendar() As Control
            Dim panel As New Panel()
            panel.Location = New Point(43, 48)
            panel.BackColor = SystemColors.GradientActiveCaption
            panel.Size = New System.Drawing.Size(245, 200)
            Dim monthCalendar As New MonthCalendar()
            monthCalendar.Location = New Point(13, 19)
            panel.Controls.Add(monthCalendar)
            Return panel
        End Function

        Private Function CreateTableLayoutPanel() As TableLayoutPanel
            Dim tableLayoutPanel As New TableLayoutPanel()
            tableLayoutPanel.Size = New System.Drawing.Size(200, 150)
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.[Single]
            tableLayoutPanel.RowCount = 2
            tableLayoutPanel.ColumnCount = 2
            tableLayoutPanel.ColumnStyles.Add(New ColumnStyle() With {
                .SizeType = SizeType.Absolute,
                .Width = 100
            })
            tableLayoutPanel.RowStyles.Add(New RowStyle() With {
                .SizeType = SizeType.Absolute,
                .Height = 100
            })
            tableLayoutPanel.Controls.Add(New Label() With {
                .Text = "If SizeType is Absolute, Styles' width and height will not change after disable default zoom policy.",
                .AutoSize = True
            })
            PutControlInCenter(tableLayoutPanel, _layoutSize)
            Return tableLayoutPanel
        End Function

        Private Function CreateFlowLayoutPanel() As FlowLayoutPanel
            Dim flowLayoutPanel As New FlowLayoutPanel()
            flowLayoutPanel.Size = New System.Drawing.Size(253, 267)
            flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle
            flowLayoutPanel.AutoScroll = True
            flowLayoutPanel.Controls.Add(New Button() With {
                .Size = New System.Drawing.Size(224, 93),
                .Text = "Please zoom in then zoom out."
            })
            flowLayoutPanel.Controls.Add(New Button() With {
                .Size = New System.Drawing.Size(109, 93),
                .Text = "Button2"
            })
            flowLayoutPanel.Controls.Add(New Button() With {
                .Size = New System.Drawing.Size(109, 93),
                .Text = "Button3"
            })
            flowLayoutPanel.Controls.Add(New Button() With {
                .Size = New System.Drawing.Size(109, 93),
                .Text = "Button4"
            })
            PutControlInCenter(flowLayoutPanel, _layoutSize)
            Return flowLayoutPanel
        End Function

        Private Function CreateSplitContainer() As SplitContainer
            Dim splitContainer As New SplitContainer()
            splitContainer.Orientation = Orientation.Horizontal
            splitContainer.Size = New System.Drawing.Size(200, 150)
            PutControlInCenter(splitContainer, _layoutSize)
            splitContainer.SplitterDistance = 60
            splitContainer.SplitterWidth = 5
            splitContainer.BorderStyle = BorderStyle.FixedSingle
            splitContainer.FixedPanel = FixedPanel.Panel1
            Dim label As New Label() With {
                .Text = "FixedPanel"
            }
            label.Location = New Point(3, 3)
            splitContainer.Panel1.Controls.Add(label)
            splitContainer.Panel1.BackColor = SystemColors.GradientActiveCaption
            splitContainer.Panel2.BackColor = SystemColors.GradientInactiveCaption
            Return splitContainer
        End Function

        Private Function CreatePictureBox() As Control
            Dim panel As New Panel()
            panel.Dock = DockStyle.Fill
            Dim label As New Label() With { _
                .Text = "PictureBox.SizeMode is Normal." _
            }
            label.AutoSize = True
            label.Location = New Point(10, 10)
            Dim pictureBox As New PictureBox()
            pictureBox.SizeMode = PictureBoxSizeMode.Normal
            pictureBox.Size = New Size(245, 147)
            PutControlInCenter(pictureBox, _layoutSize)
            pictureBox.Image = My.Resources.airplane1
            panel.Controls.Add(label)
            panel.Controls.Add(pictureBox)
            Return panel
        End Function

        Private Function CreateToolStrip() As ToolStrip
            Dim toolStrip As New ToolStrip()

            Dim fileToolStripDropDownButton As New ToolStripDropDownButton()
            fileToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text
            fileToolStripDropDownButton.Text = "File"
            fileToolStripDropDownButton.Font = _font
            fileToolStripDropDownButton.DropDownItems.Add("New")
            fileToolStripDropDownButton.DropDownItems.Add("Open")
            fileToolStripDropDownButton.DropDownItems.Add("Save")
            toolStrip.Items.Add(fileToolStripDropDownButton)
            toolStrip.Items.Add(New ToolStripLabel("Edit") With { _
                .Font = _font _
            })
            toolStrip.Items.Add(New ToolStripLabel("View") With { _
                .Font = _font _
            })
            toolStrip.Items.Add(New ToolStripLabel("Format") With { _
                .Font = _font _
            })
            toolStrip.Items.Add(New ToolStripLabel("Help") With { _
                .Font = _font _
            })
            toolStrip.Items.Add(New ToolStripLabel("Exit") With { _
                .Font = _font _
            })
            Return toolStrip
        End Function

        Private Function CreatePropertyGrid() As Control
            Dim panel As New Panel()
            panel.Dock = DockStyle.Fill
            Dim label As New Label() With { _
                .Text = "After zoom, you can try to click toolstrip's buttons in propertyGrid." _
            }
            label.AutoSize = False
            label.Height = 50
            label.Width = 300
            label.Location = New Point(10, 10)
            Dim propertyGrid As New PropertyGrid()
            propertyGrid.Size = New Size(150, 200)
            PutControlInCenter(propertyGrid, _layoutSize)
            'propertyGrid.SelectedObject = label1;
            panel.Controls.Add(label)
            panel.Controls.Add(propertyGrid)
            Return panel
        End Function
    End Class
End Namespace
