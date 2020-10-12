<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PageBulletGraph
    Inherits BaseGaugePage

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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.C1BulletGraph1 = New C1.Win.C1Gauge.C1BulletGraph()
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.C1BulletGraph1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.TableLayoutPanel1)
        Me.gaugePanel.Size = New System.Drawing.Size(576, 425)
        '
        'captionLabel
        '
        Me.captionLabel.Size = New System.Drawing.Size(576, 25)
        '
        'splitter1
        '
        Me.splitter1.Location = New System.Drawing.Point(576, 0)
        Me.splitter1.Size = New System.Drawing.Size(4, 450)
        '
        'gridPanel
        '
        Me.gridPanel.Location = New System.Drawing.Point(580, 0)
        Me.gridPanel.Size = New System.Drawing.Size(220, 450)
        '
        'gaugeGrid
        '
        Me.gaugeGrid.SelectedObject = Me.C1BulletGraph1
        Me.gaugeGrid.Size = New System.Drawing.Size(216, 430)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.C1BulletGraph1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(576, 425)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'C1BulletGraph1
        '
        Me.C1BulletGraph1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1BulletGraph1.Location = New System.Drawing.Point(3, 130)
        Me.C1BulletGraph1.Name = "C1BulletGraph1"
        Me.C1BulletGraph1.Origin = Double.NaN
        Me.C1BulletGraph1.Size = New System.Drawing.Size(570, 164)
        Me.C1BulletGraph1.TabIndex = 0
        Me.C1BulletGraph1.Text = "C1BulletGraph1"
        Me.C1BulletGraph1.Value = 50.0R
        '
        'PageBulletGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "PageBulletGraph"
        Me.Size = New System.Drawing.Size(800, 450)
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.C1BulletGraph1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents C1BulletGraph1 As C1.Win.C1Gauge.C1BulletGraph
End Class
