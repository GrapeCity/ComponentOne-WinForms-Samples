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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.c1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.c1DataFilter1 = New C1.Win.DataFilter.C1DataFilter()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1DataFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.c1DataFilter1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.c1FlexGrid1)
        Me.splitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.splitContainer1.SplitterDistance = 450
        Me.splitContainer1.TabIndex = 0
        '
        'c1FlexGrid1
        '
        Me.c1FlexGrid1.AllowEditing = False
        Me.c1FlexGrid1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.c1FlexGrid1.ColumnInfo = "10,0,0,0,0,95,Columns:"
        Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid1.ForeColor = System.Drawing.Color.White
        Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.Rows.DefaultSize = 27
        Me.c1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.c1FlexGrid1.Size = New System.Drawing.Size(346, 450)
        Me.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo")
        Me.c1FlexGrid1.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.c1FlexGrid1, "Office2016Black")
        Me.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(104, Byte), Integer))
        '
        'c1DataFilter1
        '
        Me.c1DataFilter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1DataFilter1.Location = New System.Drawing.Point(0, 0)
        Me.c1DataFilter1.Name = "c1DataFilter1"
        Me.c1DataFilter1.Size = New System.Drawing.Size(450, 450)
        Me.c1DataFilter1.TabIndex = 0
        Me.c1DataFilter1.Text = "c1DataFilter1"
        Me.C1ThemeController1.SetTheme(Me.c1DataFilter1, "Office2016Black")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "Form1"
        Me.Text = "Chart as DataFilter"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1DataFilter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private c1DataFilter1 As C1.Win.DataFilter.C1DataFilter
    Private c1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
End Class
