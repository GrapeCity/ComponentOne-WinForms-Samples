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
        Me._c1FlexPivotPage = New C1.Win.FlexPivot.C1FlexPivotPage()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.buttonGetData = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_c1FlexPivotPage
        '
        Me._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me._c1FlexPivotPage.Location = New System.Drawing.Point(0, 47)
        Me._c1FlexPivotPage.Margin = New System.Windows.Forms.Padding(2)
        Me._c1FlexPivotPage.Name = "_c1FlexPivotPage"
        Me._c1FlexPivotPage.Size = New System.Drawing.Size(925, 507)
        Me._c1FlexPivotPage.TabIndex = 3
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.buttonGetData)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(925, 47)
        Me.panel1.TabIndex = 2
        '
        'buttonGetData
        '
        Me.buttonGetData.Location = New System.Drawing.Point(12, 12)
        Me.buttonGetData.Name = "buttonGetData"
        Me.buttonGetData.Size = New System.Drawing.Size(242, 23)
        Me.buttonGetData.TabIndex = 0
        Me.buttonGetData.Text = "Get data from Excel worksheet"
        Me.buttonGetData.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(268, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(0, 13)
        Me.label1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 554)
        Me.Controls.Add(Me._c1FlexPivotPage)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From Excel"
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents _c1FlexPivotPage As C1.Win.FlexPivot.C1FlexPivotPage
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents buttonGetData As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
