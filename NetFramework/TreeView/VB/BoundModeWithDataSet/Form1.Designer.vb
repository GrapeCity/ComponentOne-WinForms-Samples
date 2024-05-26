<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim C1TreeColumn1 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.c1TreeView1 = New C1.Win.TreeView.C1TreeView()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.c1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.c1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.pgTreeView = New System.Windows.Forms.PropertyGrid()
        Me.btnResetData = New C1.Win.C1Input.C1Button()
        Me.c1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.pgColumn = New System.Windows.Forms.PropertyGrid()
        Me.cmbSelectedColumn = New C1.Win.C1Input.C1ComboBox()
        Me.c1Label1 = New C1.Win.C1Input.C1Label()
        Me.btnAddNewColumn = New C1.Win.C1Input.C1Button()
        Me.btnRemoveColumn = New C1.Win.C1Input.C1Button()
        Me.c1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.pgNode = New System.Windows.Forms.PropertyGrid()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.c1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.c1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTab1.SuspendLayout()
        Me.c1DockingTabPage1.SuspendLayout()
        CType(Me.btnResetData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTabPage2.SuspendLayout()
        CType(Me.cmbSelectedColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddNewColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemoveColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTabPage3.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "Office365White"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.panel2.Controls.Add(Me.c1TreeView1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.ForeColor = System.Drawing.Color.White
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(513, 486)
        Me.panel2.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.panel2, "(default)")
        '
        'c1TreeView1
        '
        Me.c1TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        C1TreeColumn1.DisplayFieldName = Nothing
        C1TreeColumn1.HeaderText = "Column1"
        C1TreeColumn1.Name = "Column1"
        Me.c1TreeView1.Columns.Add(C1TreeColumn1)
        Me.c1TreeView1.BindingInfo.DataMember = Nothing
        Me.c1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1TreeView1.BindingInfo.KeyField = Nothing
        Me.c1TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.c1TreeView1.Name = "c1TreeView1"
        Me.c1TreeView1.BindingInfo.ParentKeyField = Nothing
        Me.c1TreeView1.Size = New System.Drawing.Size(513, 486)
        Me.c1TreeView1.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.c1TreeView1, "(default)")
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.panel1.Controls.Add(Me.c1DockingTab1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.ForeColor = System.Drawing.Color.White
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(303, 486)
        Me.panel1.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.panel1, "(default)")
        '
        'c1DockingTab1
        '
        Me.c1DockingTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage1)
        Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage2)
        Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage3)
        Me.c1DockingTab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.c1DockingTab1.Name = "c1DockingTab1"
        Me.c1DockingTab1.SelectedIndex = 2
        Me.c1DockingTab1.Size = New System.Drawing.Size(303, 486)
        Me.c1DockingTab1.TabIndex = 0
        Me.c1DockingTab1.TabsSpacing = 5
        Me.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.C1ThemeController1.SetTheme(Me.c1DockingTab1, "(default)")
        '
        'c1DockingTabPage1
        '
        Me.c1DockingTabPage1.CaptionText = "TreeView"
        Me.c1DockingTabPage1.Controls.Add(Me.pgTreeView)
        Me.c1DockingTabPage1.Controls.Add(Me.btnResetData)
        Me.c1DockingTabPage1.Location = New System.Drawing.Point(1, 24)
        Me.c1DockingTabPage1.Name = "c1DockingTabPage1"
        Me.c1DockingTabPage1.Size = New System.Drawing.Size(301, 461)
        Me.c1DockingTabPage1.TabIndex = 0
        Me.c1DockingTabPage1.Text = "TreeView"
        '
        'pgTreeView
        '
        Me.pgTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgTreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgTreeView.CategoryForeColor = System.Drawing.Color.White
        Me.pgTreeView.CommandsActiveLinkColor = System.Drawing.Color.Red
        Me.pgTreeView.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgTreeView.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pgTreeView.CommandsForeColor = System.Drawing.Color.White
        Me.pgTreeView.CommandsLinkColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pgTreeView.HelpForeColor = System.Drawing.Color.White
        Me.pgTreeView.LineColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgTreeView.Location = New System.Drawing.Point(13, 78)
        Me.pgTreeView.Name = "pgTreeView"
        Me.pgTreeView.SelectedObject = Me.c1TreeView1
        Me.pgTreeView.Size = New System.Drawing.Size(277, 372)
        Me.pgTreeView.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.pgTreeView, "(default)")
        Me.pgTreeView.ViewBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pgTreeView.ViewForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        '
        'btnResetData
        '
        Me.btnResetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetData.Location = New System.Drawing.Point(13, 15)
        Me.btnResetData.Name = "btnResetData"
        Me.btnResetData.Size = New System.Drawing.Size(115, 46)
        Me.btnResetData.TabIndex = 0
        Me.btnResetData.Text = "Reset data"
        Me.C1ThemeController1.SetTheme(Me.btnResetData, "(default)")
        Me.btnResetData.UseVisualStyleBackColor = True
        Me.btnResetData.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1DockingTabPage2
        '
        Me.c1DockingTabPage2.Controls.Add(Me.pgColumn)
        Me.c1DockingTabPage2.Controls.Add(Me.cmbSelectedColumn)
        Me.c1DockingTabPage2.Controls.Add(Me.c1Label1)
        Me.c1DockingTabPage2.Controls.Add(Me.btnAddNewColumn)
        Me.c1DockingTabPage2.Controls.Add(Me.btnRemoveColumn)
        Me.c1DockingTabPage2.Location = New System.Drawing.Point(1, 24)
        Me.c1DockingTabPage2.Name = "c1DockingTabPage2"
        Me.c1DockingTabPage2.Size = New System.Drawing.Size(301, 461)
        Me.c1DockingTabPage2.TabIndex = 1
        Me.c1DockingTabPage2.Text = "Columns"
        '
        'pgColumn
        '
        Me.pgColumn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgColumn.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgColumn.CategoryForeColor = System.Drawing.Color.White
        Me.pgColumn.CommandsActiveLinkColor = System.Drawing.Color.Red
        Me.pgColumn.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgColumn.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pgColumn.CommandsForeColor = System.Drawing.Color.White
        Me.pgColumn.CommandsLinkColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pgColumn.HelpForeColor = System.Drawing.Color.White
        Me.pgColumn.LineColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgColumn.Location = New System.Drawing.Point(13, 99)
        Me.pgColumn.Name = "pgColumn"
        Me.pgColumn.Size = New System.Drawing.Size(276, 351)
        Me.pgColumn.TabIndex = 4
        Me.C1ThemeController1.SetTheme(Me.pgColumn, "(default)")
        Me.pgColumn.ViewBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pgColumn.ViewForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        '
        'cmbSelectedColumn
        '
        Me.cmbSelectedColumn.AllowSpinLoop = False
        Me.cmbSelectedColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmbSelectedColumn.DisabledForeColor = System.Drawing.Color.Silver
        Me.cmbSelectedColumn.GapHeight = 0
        Me.cmbSelectedColumn.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cmbSelectedColumn.ItemsDisplayMember = ""
        Me.cmbSelectedColumn.ItemsValueMember = ""
        Me.cmbSelectedColumn.Location = New System.Drawing.Point(150, 75)
        Me.cmbSelectedColumn.Name = "cmbSelectedColumn"
        Me.cmbSelectedColumn.Size = New System.Drawing.Size(136, 18)
        Me.cmbSelectedColumn.Style.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.cmbSelectedColumn.Style.DropDownBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cmbSelectedColumn.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSelectedColumn.TabIndex = 3
        Me.cmbSelectedColumn.Tag = Nothing
        Me.cmbSelectedColumn.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.cmbSelectedColumn, "(default)")
        Me.cmbSelectedColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label1
        '
        Me.c1Label1.AutoSize = True
        Me.c1Label1.BackColor = System.Drawing.Color.Transparent
        Me.c1Label1.BorderColor = System.Drawing.Color.Transparent
        Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label1.ForeColor = System.Drawing.Color.White
        Me.c1Label1.Location = New System.Drawing.Point(63, 77)
        Me.c1Label1.Name = "c1Label1"
        Me.c1Label1.Size = New System.Drawing.Size(81, 13)
        Me.c1Label1.TabIndex = 2
        Me.c1Label1.Tag = Nothing
        Me.c1Label1.Text = "Current column:"
        Me.c1Label1.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label1, "(default)")
        '
        'btnAddNewColumn
        '
        Me.btnAddNewColumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewColumn.Location = New System.Drawing.Point(13, 19)
        Me.btnAddNewColumn.Name = "btnAddNewColumn"
        Me.btnAddNewColumn.Size = New System.Drawing.Size(115, 46)
        Me.btnAddNewColumn.TabIndex = 1
        Me.btnAddNewColumn.Text = "Add column"
        Me.C1ThemeController1.SetTheme(Me.btnAddNewColumn, "(default)")
        Me.btnAddNewColumn.UseVisualStyleBackColor = True
        Me.btnAddNewColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnRemoveColumn
        '
        Me.btnRemoveColumn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveColumn.Location = New System.Drawing.Point(150, 19)
        Me.btnRemoveColumn.Name = "btnRemoveColumn"
        Me.btnRemoveColumn.Size = New System.Drawing.Size(115, 46)
        Me.btnRemoveColumn.TabIndex = 0
        Me.btnRemoveColumn.Text = "Remove column"
        Me.C1ThemeController1.SetTheme(Me.btnRemoveColumn, "(default)")
        Me.btnRemoveColumn.UseVisualStyleBackColor = True
        Me.btnRemoveColumn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1DockingTabPage3
        '
        Me.c1DockingTabPage3.Controls.Add(Me.pgNode)
        Me.c1DockingTabPage3.Location = New System.Drawing.Point(1, 24)
        Me.c1DockingTabPage3.Name = "c1DockingTabPage3"
        Me.c1DockingTabPage3.Size = New System.Drawing.Size(301, 461)
        Me.c1DockingTabPage3.TabIndex = 2
        Me.c1DockingTabPage3.Text = "Nodes"
        '
        'pgNode
        '
        Me.pgNode.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgNode.CategoryForeColor = System.Drawing.Color.White
        Me.pgNode.CommandsActiveLinkColor = System.Drawing.Color.Red
        Me.pgNode.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgNode.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.pgNode.CommandsForeColor = System.Drawing.Color.White
        Me.pgNode.CommandsLinkColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pgNode.HelpForeColor = System.Drawing.Color.White
        Me.pgNode.LineColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.pgNode.Location = New System.Drawing.Point(13, 13)
        Me.pgNode.Name = "pgNode"
        Me.pgNode.Size = New System.Drawing.Size(371, 408)
        Me.pgNode.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.pgNode, "(default)")
        Me.pgNode.ViewBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pgNode.ViewForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.ForeColor = System.Drawing.Color.White
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.panel2)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.panel1)
        Me.splitContainer1.Size = New System.Drawing.Size(820, 486)
        Me.splitContainer1.SplitterDistance = 513
        Me.splitContainer1.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.splitContainer1, "(default)")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 486)
        Me.Controls.Add(Me.splitContainer1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "BoundModeWithDataSet"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.c1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.c1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTab1.ResumeLayout(False)
        Me.c1DockingTabPage1.ResumeLayout(False)
        CType(Me.btnResetData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTabPage2.ResumeLayout(False)
        Me.c1DockingTabPage2.PerformLayout()
        CType(Me.cmbSelectedColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddNewColumn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemoveColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTabPage3.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Private WithEvents splitContainer1 As SplitContainer
    Private WithEvents panel2 As Panel
    Private WithEvents c1TreeView1 As C1.Win.TreeView.C1TreeView
    Private WithEvents panel1 As Panel
    Private WithEvents c1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Private WithEvents c1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents pgTreeView As PropertyGrid
    Private WithEvents btnResetData As C1.Win.C1Input.C1Button
    Private WithEvents c1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents pgColumn As PropertyGrid
    Private WithEvents cmbSelectedColumn As C1.Win.C1Input.C1ComboBox
    Private WithEvents c1Label1 As C1.Win.C1Input.C1Label
    Private WithEvents btnAddNewColumn As C1.Win.C1Input.C1Button
    Private WithEvents btnRemoveColumn As C1.Win.C1Input.C1Button
    Private WithEvents c1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Private WithEvents pgNode As PropertyGrid
End Class
