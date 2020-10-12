<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.showMVVM = New System.Windows.Forms.Button()
        Me.showClientSideQuerying = New System.Windows.Forms.Button()
        Me.showDataSourcesInCode = New System.Windows.Forms.Button()
        Me.showCustomColumns = New System.Windows.Forms.Button()
        Me.showLargeDataset = New System.Windows.Forms.Button()
        Me.showPaging = New System.Windows.Forms.Button()
        Me.showServerSideFiltering = New System.Windows.Forms.Button()
        Me.showMasterDetailBinding = New System.Windows.Forms.Button()
        Me.showSimpleBinding = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.BackColor = System.Drawing.Color.Black
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(15, 362)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(266, 25)
        Me.label3.TabIndex = 23
        Me.label3.Text = "Using MVVM pattern"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label2
        '
        Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.BackColor = System.Drawing.Color.Black
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(15, 258)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(266, 25)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Programming in code"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.BackColor = System.Drawing.Color.Black
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(15, 18)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(266, 25)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Using C1DataSource control"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'showMVVM
        '
        Me.showMVVM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showMVVM.Location = New System.Drawing.Point(14, 392)
        Me.showMVVM.Name = "showMVVM"
        Me.showMVVM.Size = New System.Drawing.Size(269, 30)
        Me.showMVVM.TabIndex = 20
        Me.showMVVM.Text = "MVVM"
        Me.showMVVM.UseVisualStyleBackColor = True
        '
        'showClientSideQuerying
        '
        Me.showClientSideQuerying.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showClientSideQuerying.Location = New System.Drawing.Point(14, 322)
        Me.showClientSideQuerying.Name = "showClientSideQuerying"
        Me.showClientSideQuerying.Size = New System.Drawing.Size(269, 30)
        Me.showClientSideQuerying.TabIndex = 19
        Me.showClientSideQuerying.Text = "Client-side querying: Live views"
        Me.showClientSideQuerying.UseVisualStyleBackColor = True
        '
        'showDataSourcesInCode
        '
        Me.showDataSourcesInCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showDataSourcesInCode.Location = New System.Drawing.Point(14, 288)
        Me.showDataSourcesInCode.Name = "showDataSourcesInCode"
        Me.showDataSourcesInCode.Size = New System.Drawing.Size(269, 30)
        Me.showDataSourcesInCode.TabIndex = 18
        Me.showDataSourcesInCode.Text = "Data sources in code"
        Me.showDataSourcesInCode.UseVisualStyleBackColor = True
        '
        'showCustomColumns
        '
        Me.showCustomColumns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showCustomColumns.Location = New System.Drawing.Point(14, 218)
        Me.showCustomColumns.Name = "showCustomColumns"
        Me.showCustomColumns.Size = New System.Drawing.Size(269, 30)
        Me.showCustomColumns.TabIndex = 17
        Me.showCustomColumns.Text = "Custom Columns"
        Me.showCustomColumns.UseVisualStyleBackColor = True
        '
        'showLargeDataset
        '
        Me.showLargeDataset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showLargeDataset.Location = New System.Drawing.Point(14, 184)
        Me.showLargeDataset.Name = "showLargeDataset"
        Me.showLargeDataset.Size = New System.Drawing.Size(269, 30)
        Me.showLargeDataset.TabIndex = 16
        Me.showLargeDataset.Text = "Large datasets: Virtual Mode"
        Me.showLargeDataset.UseVisualStyleBackColor = True
        '
        'showPaging
        '
        Me.showPaging.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showPaging.Location = New System.Drawing.Point(14, 150)
        Me.showPaging.Name = "showPaging"
        Me.showPaging.Size = New System.Drawing.Size(269, 30)
        Me.showPaging.TabIndex = 15
        Me.showPaging.Text = "Paging"
        Me.showPaging.UseVisualStyleBackColor = True
        '
        'showServerSideFiltering
        '
        Me.showServerSideFiltering.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showServerSideFiltering.Location = New System.Drawing.Point(14, 82)
        Me.showServerSideFiltering.Name = "showServerSideFiltering"
        Me.showServerSideFiltering.Size = New System.Drawing.Size(269, 30)
        Me.showServerSideFiltering.TabIndex = 13
        Me.showServerSideFiltering.Text = "Server-side filtering"
        Me.showServerSideFiltering.UseVisualStyleBackColor = True
        '
        'showMasterDetailBinding
        '
        Me.showMasterDetailBinding.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showMasterDetailBinding.Location = New System.Drawing.Point(14, 116)
        Me.showMasterDetailBinding.Name = "showMasterDetailBinding"
        Me.showMasterDetailBinding.Size = New System.Drawing.Size(269, 30)
        Me.showMasterDetailBinding.TabIndex = 14
        Me.showMasterDetailBinding.Text = "Master-detail binding"
        Me.showMasterDetailBinding.UseVisualStyleBackColor = True
        '
        'showSimpleBinding
        '
        Me.showSimpleBinding.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.showSimpleBinding.Location = New System.Drawing.Point(14, 48)
        Me.showSimpleBinding.Name = "showSimpleBinding"
        Me.showSimpleBinding.Size = New System.Drawing.Size(269, 30)
        Me.showSimpleBinding.TabIndex = 12
        Me.showSimpleBinding.Text = "Simple binding"
        Me.showSimpleBinding.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 441)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.showMVVM)
        Me.Controls.Add(Me.showClientSideQuerying)
        Me.Controls.Add(Me.showDataSourcesInCode)
        Me.Controls.Add(Me.showCustomColumns)
        Me.Controls.Add(Me.showLargeDataset)
        Me.Controls.Add(Me.showPaging)
        Me.Controls.Add(Me.showServerSideFiltering)
        Me.Controls.Add(Me.showMasterDetailBinding)
        Me.Controls.Add(Me.showSimpleBinding)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Tutorials WinForms"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents showMVVM As System.Windows.Forms.Button
    Private WithEvents showClientSideQuerying As System.Windows.Forms.Button
    Private WithEvents showDataSourcesInCode As System.Windows.Forms.Button
    Private WithEvents showCustomColumns As System.Windows.Forms.Button
    Private WithEvents showLargeDataset As System.Windows.Forms.Button
    Private WithEvents showPaging As System.Windows.Forms.Button
    Private WithEvents showServerSideFiltering As System.Windows.Forms.Button
    Private WithEvents showMasterDetailBinding As System.Windows.Forms.Button
    Private WithEvents showSimpleBinding As System.Windows.Forms.Button

End Class
