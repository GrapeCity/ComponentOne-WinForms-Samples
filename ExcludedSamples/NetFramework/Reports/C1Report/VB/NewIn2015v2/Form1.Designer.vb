<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits C1.Win.C1Ribbon.C1RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1RibbonPreview1 = New C1.Win.C1RibbonPreview.C1RibbonPreview()
        Me.C1Report1 = New C1.C1Report.C1Report()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.C1RibbonPreview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1RibbonPreview1
        '
        Me.C1RibbonPreview1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1RibbonPreview1.Location = New System.Drawing.Point(0, 0)
        Me.C1RibbonPreview1.Name = "C1RibbonPreview1"
        Me.C1RibbonPreview1.Size = New System.Drawing.Size(1115, 634)
        Me.C1RibbonPreview1.TabIndex = 0
        '
        'C1Report1
        '
        Me.C1Report1.DisposeC1Document = True
        Me.C1Report1.EditContext = Nothing
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "C1Report1"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 634)
        Me.Controls.Add(Me.C1RibbonPreview1)
        Me.Name = "Form1"
        Me.Text = "New features of the 2015v2 release"
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Custom
        CType(Me.C1RibbonPreview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1RibbonPreview1 As C1.Win.C1RibbonPreview.C1RibbonPreview
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
