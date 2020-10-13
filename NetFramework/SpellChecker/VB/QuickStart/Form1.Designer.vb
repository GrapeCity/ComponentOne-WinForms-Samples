<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnAsYouTypeRich = New System.Windows.Forms.CheckBox
        Me.btnSpellDialogRich = New System.Windows.Forms.Button
        Me.btnShowErrorsRich = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.cmbZoom = New System.Windows.Forms.ComboBox
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.btnAsYouType = New System.Windows.Forms.CheckBox
        Me.btnSpellDialog = New System.Windows.Forms.Button
        Me.btnShowErrors = New System.Windows.Forms.Button
        Me.btnFont = New System.Windows.Forms.Button
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnSpellDialogGrid = New System.Windows.Forms.Button
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid
        Me._spell = New C1.Win.C1SpellChecker.C1SpellChecker(Me.components)
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._spell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(738, 544)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.richTextBox1)
        Me.TabPage1.Controls.Add(Me.cmbZoom)
        Me.TabPage1.Controls.Add(Me.label1)
        Me.TabPage1.Controls.Add(Me.btnShowErrorsRich)
        Me.TabPage1.Controls.Add(Me.btnSpellDialogRich)
        Me.TabPage1.Controls.Add(Me.btnAsYouTypeRich)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(730, 518)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "RichTextBox"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.textBox1)
        Me.TabPage2.Controls.Add(Me.btnFont)
        Me.TabPage2.Controls.Add(Me.btnShowErrors)
        Me.TabPage2.Controls.Add(Me.btnSpellDialog)
        Me.TabPage2.Controls.Add(Me.btnAsYouType)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(730, 518)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TextBox"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAsYouTypeRich
        '
        Me.btnAsYouTypeRich.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnAsYouTypeRich.Location = New System.Drawing.Point(8, 6)
        Me.btnAsYouTypeRich.Name = "btnAsYouTypeRich"
        Me.btnAsYouTypeRich.Size = New System.Drawing.Size(154, 30)
        Me.btnAsYouTypeRich.TabIndex = 1
        Me.btnAsYouTypeRich.Text = "Check As You Type"
        Me.btnAsYouTypeRich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAsYouTypeRich.UseVisualStyleBackColor = True
        '
        'btnSpellDialogRich
        '
        Me.btnSpellDialogRich.Location = New System.Drawing.Point(168, 6)
        Me.btnSpellDialogRich.Name = "btnSpellDialogRich"
        Me.btnSpellDialogRich.Size = New System.Drawing.Size(154, 30)
        Me.btnSpellDialogRich.TabIndex = 2
        Me.btnSpellDialogRich.Text = "Check with Dialog"
        Me.btnSpellDialogRich.UseVisualStyleBackColor = True
        '
        'btnShowErrorsRich
        '
        Me.btnShowErrorsRich.Location = New System.Drawing.Point(328, 6)
        Me.btnShowErrorsRich.Name = "btnShowErrorsRich"
        Me.btnShowErrorsRich.Size = New System.Drawing.Size(154, 30)
        Me.btnShowErrorsRich.TabIndex = 3
        Me.btnShowErrorsRich.Text = "Show Error List"
        Me.btnShowErrorsRich.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(513, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(34, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "&Zoom"
        '
        'cmbZoom
        '
        Me.cmbZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbZoom.FormattingEnabled = True
        Me.cmbZoom.Items.AddRange(New Object() {"50%", "75%", "100%", "150%", "200%"})
        Me.cmbZoom.Location = New System.Drawing.Point(553, 12)
        Me.cmbZoom.Name = "cmbZoom"
        Me.cmbZoom.Size = New System.Drawing.Size(108, 21)
        Me.cmbZoom.TabIndex = 5
        '
        'richTextBox1
        '
        Me.richTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.richTextBox1.Location = New System.Drawing.Point(8, 45)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(715, 465)
        Me.richTextBox1.TabIndex = 6
        Me.richTextBox1.Text = ""
        '
        'btnAsYouType
        '
        Me.btnAsYouType.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnAsYouType.Location = New System.Drawing.Point(6, 6)
        Me.btnAsYouType.Name = "btnAsYouType"
        Me.btnAsYouType.Size = New System.Drawing.Size(154, 30)
        Me.btnAsYouType.TabIndex = 1
        Me.btnAsYouType.Text = "Check As You Type"
        Me.btnAsYouType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAsYouType.UseVisualStyleBackColor = True
        '
        'btnSpellDialog
        '
        Me.btnSpellDialog.Location = New System.Drawing.Point(166, 6)
        Me.btnSpellDialog.Name = "btnSpellDialog"
        Me.btnSpellDialog.Size = New System.Drawing.Size(154, 30)
        Me.btnSpellDialog.TabIndex = 2
        Me.btnSpellDialog.Text = "Check with Dialog"
        Me.btnSpellDialog.UseVisualStyleBackColor = True
        '
        'btnShowErrors
        '
        Me.btnShowErrors.Location = New System.Drawing.Point(326, 6)
        Me.btnShowErrors.Name = "btnShowErrors"
        Me.btnShowErrors.Size = New System.Drawing.Size(154, 30)
        Me.btnShowErrors.TabIndex = 3
        Me.btnShowErrors.Text = "Show Error List"
        Me.btnShowErrors.UseVisualStyleBackColor = True
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(507, 6)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(104, 30)
        Me.btnFont.TabIndex = 4
        Me.btnFont.Text = "Font..."
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(6, 47)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(720, 465)
        Me.textBox1.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me._flex)
        Me.TabPage3.Controls.Add(Me.btnSpellDialogGrid)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(730, 518)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "C1FlexGrid"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnSpellDialogGrid
        '
        Me.btnSpellDialogGrid.Location = New System.Drawing.Point(6, 6)
        Me.btnSpellDialogGrid.Name = "btnSpellDialogGrid"
        Me.btnSpellDialogGrid.Size = New System.Drawing.Size(154, 30)
        Me.btnSpellDialogGrid.TabIndex = 3
        Me.btnSpellDialogGrid.Text = "Check with Dialog"
        Me.btnSpellDialogGrid.UseVisualStyleBackColor = True
        '
        '_flex
        '
        Me._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:30;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex.Location = New System.Drawing.Point(6, 42)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(716, 468)
        Me._flex.TabIndex = 4
        Me._flex.UseCompatibleTextRendering = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 544)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._spell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents cmbZoom As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnShowErrorsRich As System.Windows.Forms.Button
    Private WithEvents btnSpellDialogRich As System.Windows.Forms.Button
    Private WithEvents btnAsYouTypeRich As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents btnFont As System.Windows.Forms.Button
    Private WithEvents btnShowErrors As System.Windows.Forms.Button
    Private WithEvents btnSpellDialog As System.Windows.Forms.Button
    Private WithEvents btnAsYouType As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents btnSpellDialogGrid As System.Windows.Forms.Button
    Friend WithEvents _spell As C1.Win.C1SpellChecker.C1SpellChecker
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip

End Class
