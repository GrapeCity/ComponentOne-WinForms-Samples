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
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.components = New System.ComponentModel.Container()
        Me.cbAction = New System.Windows.Forms.ComboBox()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbFile = New System.Windows.Forms.TextBox()
        Me.c1PdfDocumentSource1 = New C1.Win.C1Document.C1PdfDocumentSource(Me.components)
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.printDialog1 = New System.Windows.Forms.PrintDialog()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Location = New System.Drawing.Point(452, 169)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 12
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(19, 41)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Action:"
        '
        'cbAction
        '
        Me.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAction.FormattingEnabled = True
        Me.cbAction.Location = New System.Drawing.Point(65, 38)
        Me.cbAction.Name = "cbAction"
        Me.cbAction.Size = New System.Drawing.Size(208, 21)
        Me.cbAction.TabIndex = 11
        '
        'btnFile
        '
        Me.btnFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFile.Location = New System.Drawing.Point(501, 12)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(26, 20)
        Me.btnFile.TabIndex = 9
        Me.btnFile.Text = "..."
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "PDF file:"
        '
        'tbFile
        '
        Me.tbFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFile.Location = New System.Drawing.Point(65, 12)
        Me.tbFile.Name = "tbFile"
        Me.tbFile.Size = New System.Drawing.Size(430, 20)
        Me.tbFile.TabIndex = 8
        '
        'openFileDialog1
        '
        Me.openFileDialog1.DefaultExt = "pdf"
        Me.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        '
        'printDialog1
        '
        Me.printDialog1.AllowSomePages = True
        Me.printDialog1.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 204)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cbAction)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tbFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "PDF Print & Export"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnExecute As Button
    Private WithEvents label2 As Label
    Private WithEvents cbAction As ComboBox
    Private WithEvents btnFile As Button
    Private WithEvents label1 As Label
    Private WithEvents tbFile As TextBox
    Friend WithEvents c1PdfDocumentSource1 As C1.Win.C1Document.C1PdfDocumentSource
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents printDialog1 As PrintDialog
    Private WithEvents saveFileDialog1 As SaveFileDialog
End Class
