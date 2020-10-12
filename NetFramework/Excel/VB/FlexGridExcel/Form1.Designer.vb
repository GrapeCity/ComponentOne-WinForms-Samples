<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me._book = New C1.C1Excel.C1XLBook
        Me._tab = New System.Windows.Forms.TabControl
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid
        Me._btnBatch = New System.Windows.Forms.Button
        Me._btnLoad = New System.Windows.Forms.Button
        Me._btnSave = New System.Windows.Forms.Button
        Me._tab.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_tab
        '
        Me._tab.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me._tab.Controls.Add(Me.tabPage1)
        Me._tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me._tab.Location = New System.Drawing.Point(0, 40)
        Me._tab.Multiline = True
        Me._tab.Name = "_tab"
        Me._tab.Padding = New System.Drawing.Point(0, 0)
        Me._tab.SelectedIndex = 0
        Me._tab.Size = New System.Drawing.Size(576, 357)
        Me._tab.TabIndex = 8
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me._flex)
        Me.tabPage1.Location = New System.Drawing.Point(4, 4)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(568, 331)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Sheet 1"
        '
        '_flex
        '
        Me._flex.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Spill
        Me._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 0)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(568, 331)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 0
        '
        '_btnBatch
        '
        Me._btnBatch.Location = New System.Drawing.Point(240, 8)
        Me._btnBatch.Name = "_btnBatch"
        Me._btnBatch.Size = New System.Drawing.Size(160, 24)
        Me._btnBatch.TabIndex = 7
        Me._btnBatch.Text = "Load/Save Batch..."
        '
        '_btnLoad
        '
        Me._btnLoad.Location = New System.Drawing.Point(8, 8)
        Me._btnLoad.Name = "_btnLoad"
        Me._btnLoad.Size = New System.Drawing.Size(96, 24)
        Me._btnLoad.TabIndex = 5
        Me._btnLoad.Text = "&Load File..."
        '
        '_btnSave
        '
        Me._btnSave.Location = New System.Drawing.Point(112, 8)
        Me._btnSave.Name = "_btnSave"
        Me._btnSave.Size = New System.Drawing.Size(96, 24)
        Me._btnSave.TabIndex = 6
        Me._btnSave.Text = "&Save File..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 397)
        Me.Controls.Add(Me._tab)
        Me.Controls.Add(Me._btnBatch)
        Me.Controls.Add(Me._btnLoad)
        Me.Controls.Add(Me._btnSave)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(0, 40, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Excel: load and save XLS files"
        Me._tab.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _book As C1.C1Excel.C1XLBook
    Private WithEvents _tab As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents _btnBatch As System.Windows.Forms.Button
    Private WithEvents _btnLoad As System.Windows.Forms.Button
    Private WithEvents _btnSave As System.Windows.Forms.Button

End Class
