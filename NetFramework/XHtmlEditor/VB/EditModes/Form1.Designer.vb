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
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.panel1 = New System.Windows.Forms.Panel
        Me.button5 = New System.Windows.Forms.Button
        Me.button4 = New System.Windows.Forms.Button
        Me.button3 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.c1Editor1 = New C1.Win.C1Editor.C1Editor
        Me.panel1.SuspendLayout()
        CType(Me.c1Editor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.DefaultExt = "xhtml"
        Me.saveFileDialog1.FileName = "samplePage.xhtml"
        Me.saveFileDialog1.Filter = "xhtml files|*.xhtml|All files |*.*"
        '
        'openFileDialog1
        '
        Me.openFileDialog1.DefaultExt = "xhtml"
        Me.openFileDialog1.FileName = "samplePage.xhtml"
        Me.openFileDialog1.Filter = "xhtml files|*.xhtml|All files |*.*"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button5)
        Me.panel1.Controls.Add(Me.button4)
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 418)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(615, 51)
        Me.panel1.TabIndex = 2
        '
        'button5
        '
        Me.button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button5.Location = New System.Drawing.Point(416, 16)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(75, 23)
        Me.button5.TabIndex = 4
        Me.button5.Text = "Load"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button4.Location = New System.Drawing.Point(506, 16)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 23)
        Me.button4.TabIndex = 3
        Me.button4.Text = "Save"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(196, 16)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 2
        Me.button3.Text = "Preview"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(103, 16)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Source"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 16)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Design"
        Me.button1.UseVisualStyleBackColor = True
        '
        'c1Editor1
        '
        Me.c1Editor1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Editor1.Location = New System.Drawing.Point(0, 0)
        Me.c1Editor1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 50)
        Me.c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design
        Me.c1Editor1.Name = "c1Editor1"
        Me.c1Editor1.Size = New System.Drawing.Size(615, 418)
        Me.c1Editor1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 469)
        Me.Controls.Add(Me.c1Editor1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        CType(Me.c1Editor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents button5 As System.Windows.Forms.Button
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents c1Editor1 As C1.Win.C1Editor.C1Editor

End Class
