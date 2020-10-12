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
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        '_c1FlexPivotPage
        '
        Me._c1FlexPivotPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me._c1FlexPivotPage.Location = New System.Drawing.Point(0, 56)
        Me._c1FlexPivotPage.Margin = New System.Windows.Forms.Padding(2)
        Me._c1FlexPivotPage.Name = "_c1FlexPivotPage"
        Me._c1FlexPivotPage.Size = New System.Drawing.Size(928, 590)
        Me._c1FlexPivotPage.TabIndex = 1
        '
        'btnJoin
        '
        Me.btnJoin.Location = New System.Drawing.Point(13, 13)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(131, 23)
        Me.btnJoin.TabIndex = 0
        Me.btnJoin.Text = "Select Fields..."
        Me.btnJoin.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnJoin)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(928, 56)
        Me.panel1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 646)
        Me.Controls.Add(Me._c1FlexPivotPage)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NorthWind Data Analysis with Joins"
        CType(Me._c1FlexPivotPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents _c1FlexPivotPage As C1.Win.FlexPivot.C1FlexPivotPage
    Private WithEvents btnJoin As System.Windows.Forms.Button
    Private WithEvents panel1 As System.Windows.Forms.Panel

End Class
