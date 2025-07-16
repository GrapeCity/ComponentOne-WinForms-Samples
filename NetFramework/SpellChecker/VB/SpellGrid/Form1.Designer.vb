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
        Me._spell = New C1.Win.SpellChecker.C1SpellChecker(Me.components)
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me._spell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._flex.Location = New System.Drawing.Point(0, 41)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(457, 250)
        Me._flex.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Spell Check Grid"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FlexGridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 291)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me._flex)
        Me.Name = "FlexGridForm"
        Me.Text = "Spell-Checking a FlexGrid"
        CType(Me._spell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _spell As C1.Win.SpellChecker.C1SpellChecker
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
