﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1Chart1 = New C1.Win.C1Chart.C1Chart()
        CType(Me.C1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Chart1
        '
        Me.C1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Chart1.Location = New System.Drawing.Point(0, 0)
        Me.C1Chart1.Name = "C1Chart1"
        Me.C1Chart1.PropBag = resources.GetString("C1Chart1.PropBag")
        Me.C1Chart1.Size = New System.Drawing.Size(592, 373)
        Me.C1Chart1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 373)
        Me.Controls.Add(Me.C1Chart1)
        Me.Name = "Form1"
        Me.Text = "Chart Dialogs Sample"
        CType(Me.C1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1Chart1 As C1.Win.C1Chart.C1Chart

End Class
