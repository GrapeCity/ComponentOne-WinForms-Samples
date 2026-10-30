Imports C1.Win.Ribbon
Imports C1.Win.Input

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImportOptions
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        chkLoadAsTransposed = New C1CheckBox()
        chkVisibleOnly = New C1CheckBox()
        chkLoadMergedRanges = New C1CheckBox()
        chkNoFreezing = New C1CheckBox()
        chkIncludeFixedCells = New C1CheckBox()
        c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        panel1 = New Windows.Forms.Panel()
        button1 = New C1Button()
        btnOK = New C1Button()
        CType(chkLoadAsTransposed, ComponentModel.ISupportInitialize).BeginInit()
        CType(chkVisibleOnly, ComponentModel.ISupportInitialize).BeginInit()
        CType(chkLoadMergedRanges, ComponentModel.ISupportInitialize).BeginInit()
        CType(chkNoFreezing, ComponentModel.ISupportInitialize).BeginInit()
        CType(chkIncludeFixedCells, ComponentModel.ISupportInitialize).BeginInit()
        CType(c1ThemeController1, ComponentModel.ISupportInitialize).BeginInit()
        panel1.SuspendLayout()
        CType(button1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnOK, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' chkLoadAsTransposed
        ' 
        chkLoadAsTransposed.AutoSize = True
        chkLoadAsTransposed.Location = New Drawing.Point(222, 56)
        chkLoadAsTransposed.Name = "chkLoadAsTransposed"
        chkLoadAsTransposed.Size = New Drawing.Size(179, 26)
        chkLoadAsTransposed.Styles.Button.Default.BackColor = Drawing.Color.Transparent
        chkLoadAsTransposed.TabIndex = 17
        chkLoadAsTransposed.Text = "Load As Transposed"
        c1ThemeController1.SetTheme(chkLoadAsTransposed, "(default)")
        ' 
        ' chkVisibleOnly
        ' 
        chkVisibleOnly.AutoSize = True
        chkVisibleOnly.Location = New Drawing.Point(15, 97)
        chkVisibleOnly.Name = "chkVisibleOnly"
        chkVisibleOnly.Size = New Drawing.Size(124, 26)
        chkVisibleOnly.Styles.Button.Default.BackColor = Drawing.Color.Transparent
        chkVisibleOnly.TabIndex = 14
        chkVisibleOnly.Text = "Visible Only"
        c1ThemeController1.SetTheme(chkVisibleOnly, "(default)")
        ' 
        ' chkLoadMergedRanges
        ' 
        chkLoadMergedRanges.AutoSize = True
        chkLoadMergedRanges.Location = New Drawing.Point(222, 15)
        chkLoadMergedRanges.Name = "chkLoadMergedRanges"
        chkLoadMergedRanges.Size = New Drawing.Size(188, 26)
        chkLoadMergedRanges.Styles.Button.Default.BackColor = Drawing.Color.Transparent
        chkLoadMergedRanges.TabIndex = 13
        chkLoadMergedRanges.Text = "Load Merged Ranges"
        c1ThemeController1.SetTheme(chkLoadMergedRanges, "(default)")
        ' 
        ' chkNoFreezing
        ' 
        chkNoFreezing.AutoSize = True
        chkNoFreezing.Location = New Drawing.Point(15, 56)
        chkNoFreezing.Name = "chkNoFreezing"
        chkNoFreezing.Size = New Drawing.Size(125, 26)
        chkNoFreezing.Styles.Button.Default.BackColor = Drawing.Color.Transparent
        chkNoFreezing.TabIndex = 12
        chkNoFreezing.Text = "No Freezing"
        c1ThemeController1.SetTheme(chkNoFreezing, "(default)")
        ' 
        ' chkIncludeFixedCells
        ' 
        chkIncludeFixedCells.AutoSize = True
        chkIncludeFixedCells.Location = New Drawing.Point(15, 15)
        chkIncludeFixedCells.Name = "chkIncludeFixedCells"
        chkIncludeFixedCells.Size = New Drawing.Size(168, 26)
        chkIncludeFixedCells.Styles.Button.Default.BackColor = Drawing.Color.Transparent
        chkIncludeFixedCells.TabIndex = 11
        chkIncludeFixedCells.Text = "Include Fixed Cells"
        c1ThemeController1.SetTheme(chkIncludeFixedCells, "(default)")
        ' 
        ' c1ThemeController1
        ' 
        c1ThemeController1.Theme = "Office365Colorful"
        ' 
        ' panel1
        ' 
        panel1.BackColor = Drawing.Color.FromArgb(240, 240, 240)
        panel1.Controls.Add(chkLoadAsTransposed)
        panel1.Controls.Add(button1)
        panel1.Controls.Add(btnOK)
        panel1.Controls.Add(chkVisibleOnly)
        panel1.Controls.Add(chkLoadMergedRanges)
        panel1.Controls.Add(chkNoFreezing)
        panel1.Controls.Add(chkIncludeFixedCells)
        panel1.Dock = Windows.Forms.DockStyle.Fill
        panel1.Font = New Drawing.Font("Segoe UI", 14.0F)
        panel1.ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        panel1.Location = New Drawing.Point(0, 0)
        panel1.Name = "panel1"
        panel1.Size = New Drawing.Size(436, 193)
        panel1.TabIndex = 11
        c1ThemeController1.SetTheme(panel1, "(default)")
        ' 
        ' button1
        ' 
        button1.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right
        button1.DialogResult = Windows.Forms.DialogResult.Cancel
        button1.Location = New Drawing.Point(321, 143)
        button1.Name = "button1"
        button1.Size = New Drawing.Size(100, 35)
        button1.TabIndex = 16
        button1.Text = "Cancel"
        c1ThemeController1.SetTheme(button1, "(default)")
        ' 
        ' btnOK
        ' 
        btnOK.Anchor = Windows.Forms.AnchorStyles.Bottom Or Windows.Forms.AnchorStyles.Right
        btnOK.DialogResult = Windows.Forms.DialogResult.OK
        btnOK.Location = New Drawing.Point(209, 143)
        btnOK.Name = "btnOK"
        btnOK.Size = New Drawing.Size(100, 35)
        btnOK.TabIndex = 15
        btnOK.Text = "OK"
        c1ThemeController1.SetTheme(btnOK, "(default)")
        AddHandler btnOK.Click, New EventHandler(AddressOf btnOK_Click)
        ' 
        ' ImportOptions
        ' 
        AutoScaleDimensions = New Drawing.SizeF(11.0F, 25.0F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        ClientSize = New Drawing.Size(436, 193)
        Controls.Add(panel1)
        Font = New Drawing.Font("Segoe UI", 14.0F)
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Margin = New Windows.Forms.Padding(6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ImportOptions"
        StartPosition = Windows.Forms.FormStartPosition.CenterParent
        Text = "Import Options"
        c1ThemeController1.SetTheme(Me, "(default)")
        CType(chkLoadAsTransposed, ComponentModel.ISupportInitialize).EndInit()
        CType(chkVisibleOnly, ComponentModel.ISupportInitialize).EndInit()
        CType(chkLoadMergedRanges, ComponentModel.ISupportInitialize).EndInit()
        CType(chkNoFreezing, ComponentModel.ISupportInitialize).EndInit()
        CType(chkIncludeFixedCells, ComponentModel.ISupportInitialize).EndInit()
        CType(c1ThemeController1, ComponentModel.ISupportInitialize).EndInit()
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(button1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnOK, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

#End Region

    Friend c1ThemeController1 As C1.Win.Themes.C1ThemeController
    Private panel1 As Windows.Forms.Panel
    Private chkLoadAsTransposed As C1CheckBox
    Private button1 As C1Button
    Private btnOK As C1Button
    Private chkVisibleOnly As C1CheckBox
    Private chkLoadMergedRanges As C1CheckBox
    Private chkNoFreezing As C1CheckBox
    Private chkIncludeFixedCells As C1CheckBox
End Class
