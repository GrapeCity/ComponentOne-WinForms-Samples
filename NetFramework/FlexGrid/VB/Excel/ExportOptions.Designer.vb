Imports C1.Win.Ribbon
Imports C1.Win.Input

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExportOptions
    Inherits C1RibbonForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

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

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.chkExcludeFooters = New C1.Win.Input.C1CheckBox()
        Me.chkVisibleOnly = New C1.Win.Input.C1CheckBox()
        Me.chkSelectedRowsOnly = New C1.Win.Input.C1CheckBox()
        Me.chkSaveMergedRanges = New C1.Win.Input.C1CheckBox()
        Me.chkOpenXml = New C1.Win.Input.C1CheckBox()
        Me.chkNoFreezing = New C1.Win.Input.C1CheckBox()
        Me.chkIncludeFixedCells = New C1.Win.Input.C1CheckBox()
        Me.chkAsDisplayed = New C1.Win.Input.C1CheckBox()
        Me.c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.button1 = New C1.Win.Input.C1Button()
        Me.btnOK = New C1.Win.Input.C1Button()
        CType(Me.chkExcludeFooters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVisibleOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelectedRowsOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSaveMergedRanges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOpenXml, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNoFreezing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncludeFixedCells, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAsDisplayed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkExcludeFooters
        '
        Me.chkExcludeFooters.AutoSize = True
        Me.chkExcludeFooters.Location = New System.Drawing.Point(204, 88)
        Me.chkExcludeFooters.Name = "chkExcludeFooters"
        Me.chkExcludeFooters.Size = New System.Drawing.Size(149, 26)
        Me.chkExcludeFooters.TabIndex = 18
        Me.chkExcludeFooters.Text = "Exclude Footers"
        Me.c1ThemeController1.SetTheme(Me.chkExcludeFooters, "(default)")
        '
        'chkVisibleOnly
        '
        Me.chkVisibleOnly.AutoSize = True
        Me.chkVisibleOnly.Location = New System.Drawing.Point(204, 126)
        Me.chkVisibleOnly.Name = "chkVisibleOnly"
        Me.chkVisibleOnly.Size = New System.Drawing.Size(124, 26)
        Me.chkVisibleOnly.TabIndex = 17
        Me.chkVisibleOnly.Text = "Visible Only"
        Me.c1ThemeController1.SetTheme(Me.chkVisibleOnly, "(default)")
        '
        'chkSelectedRowsOnly
        '
        Me.chkSelectedRowsOnly.AutoSize = True
        Me.chkSelectedRowsOnly.Location = New System.Drawing.Point(204, 50)
        Me.chkSelectedRowsOnly.Name = "chkSelectedRowsOnly"
        Me.chkSelectedRowsOnly.Size = New System.Drawing.Size(178, 26)
        Me.chkSelectedRowsOnly.TabIndex = 16
        Me.chkSelectedRowsOnly.Text = "Selected Rows Only"
        Me.c1ThemeController1.SetTheme(Me.chkSelectedRowsOnly, "(default)")
        '
        'chkSaveMergedRanges
        '
        Me.chkSaveMergedRanges.AutoSize = True
        Me.chkSaveMergedRanges.Location = New System.Drawing.Point(204, 12)
        Me.chkSaveMergedRanges.Name = "chkSaveMergedRanges"
        Me.chkSaveMergedRanges.Size = New System.Drawing.Size(187, 26)
        Me.chkSaveMergedRanges.TabIndex = 15
        Me.chkSaveMergedRanges.Text = "Save Merged Ranges"
        Me.c1ThemeController1.SetTheme(Me.chkSaveMergedRanges, "(default)")
        '
        'chkOpenXml
        '
        Me.chkOpenXml.AutoSize = True
        Me.chkOpenXml.Location = New System.Drawing.Point(12, 126)
        Me.chkOpenXml.Name = "chkOpenXml"
        Me.chkOpenXml.Size = New System.Drawing.Size(162, 26)
        Me.chkOpenXml.TabIndex = 14
        Me.chkOpenXml.Text = "Save as OpenXml"
        Me.c1ThemeController1.SetTheme(Me.chkOpenXml, "(default)")
        '
        'chkNoFreezing
        '
        Me.chkNoFreezing.AutoSize = True
        Me.chkNoFreezing.Location = New System.Drawing.Point(12, 88)
        Me.chkNoFreezing.Name = "chkNoFreezing"
        Me.chkNoFreezing.Size = New System.Drawing.Size(125, 26)
        Me.chkNoFreezing.TabIndex = 13
        Me.chkNoFreezing.Text = "No Freezing"
        Me.c1ThemeController1.SetTheme(Me.chkNoFreezing, "(default)")
        '
        'chkIncludeFixedCells
        '
        Me.chkIncludeFixedCells.AutoSize = True
        Me.chkIncludeFixedCells.Location = New System.Drawing.Point(12, 50)
        Me.chkIncludeFixedCells.Name = "chkIncludeFixedCells"
        Me.chkIncludeFixedCells.Size = New System.Drawing.Size(168, 26)
        Me.chkIncludeFixedCells.TabIndex = 12
        Me.chkIncludeFixedCells.Text = "Include Fixed Cells"
        Me.c1ThemeController1.SetTheme(Me.chkIncludeFixedCells, "(default)")
        '
        'chkAsDisplayed
        '
        Me.chkAsDisplayed.AutoSize = True
        Me.chkAsDisplayed.Location = New System.Drawing.Point(12, 12)
        Me.chkAsDisplayed.Name = "chkAsDisplayed"
        Me.chkAsDisplayed.Size = New System.Drawing.Size(130, 26)
        Me.chkAsDisplayed.TabIndex = 11
        Me.chkAsDisplayed.Text = "As Displayed"
        Me.c1ThemeController1.SetTheme(Me.chkAsDisplayed, "(default)")
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.btnOK)
        Me.panel1.Controls.Add(Me.chkExcludeFooters)
        Me.panel1.Controls.Add(Me.chkVisibleOnly)
        Me.panel1.Controls.Add(Me.chkSelectedRowsOnly)
        Me.panel1.Controls.Add(Me.chkSaveMergedRanges)
        Me.panel1.Controls.Add(Me.chkOpenXml)
        Me.panel1.Controls.Add(Me.chkNoFreezing)
        Me.panel1.Controls.Add(Me.chkIncludeFixedCells)
        Me.panel1.Controls.Add(Me.chkAsDisplayed)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(400, 221)
        Me.panel1.TabIndex = 11
        Me.c1ThemeController1.SetTheme(Me.panel1, "(default)")
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button1.Location = New System.Drawing.Point(288, 174)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 35)
        Me.button1.TabIndex = 20
        Me.button1.Text = "Cancel"
        Me.c1ThemeController1.SetTheme(Me.button1, "(default)")
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(173, 174)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 35)
        Me.btnOK.TabIndex = 19
        Me.btnOK.Text = "OK"
        Me.c1ThemeController1.SetTheme(Me.btnOK, "(default)")
        '
        'ExportOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 221)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExportOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export Options"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.chkExcludeFooters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVisibleOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelectedRowsOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSaveMergedRanges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOpenXml, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNoFreezing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncludeFixedCells, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAsDisplayed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend c1ThemeController1 As C1.Win.Themes.C1ThemeController
    Private panel1 As Windows.Forms.Panel
    Private button1 As C1Button
    Private btnOK As C1Button
    Private chkExcludeFooters As C1CheckBox
    Private chkVisibleOnly As C1CheckBox
    Private chkSelectedRowsOnly As C1CheckBox
    Private chkSaveMergedRanges As C1CheckBox
    Private chkOpenXml As C1CheckBox
    Private chkNoFreezing As C1CheckBox
    Private chkIncludeFixedCells As C1CheckBox
    Private chkAsDisplayed As C1CheckBox
End Class
