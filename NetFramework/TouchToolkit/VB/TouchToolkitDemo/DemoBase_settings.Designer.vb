Partial Class DemoBase_settings
    ''' <summary> 
    ''' 必要なデザイナ変数です。
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' 使用中のリソースをすべてクリーンアップします。
    ''' </summary>
    ''' <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "コンポーネント デザイナで生成されたコード"

    ''' <summary> 
    ''' デザイナ サポートに必要なメソッドです。このメソッドの内容を 
    ''' コード エディタで変更しないでください。
    ''' </summary>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' lblTitle
        ' 
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("メイリオ", 14.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(29)), CInt(CByte(27)), CInt(CByte(27)))
        Me.lblTitle.Location = New System.Drawing.Point(17, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(253, 36)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "(サンプルのタイトル)"
        ' 
        ' lblDescription
        ' 
        Me.lblDescription.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.Font = New System.Drawing.Font("メイリオ", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(36)), CInt(CByte(34)), CInt(CByte(30)))
        Me.lblDescription.Location = New System.Drawing.Point(17, 44)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(543, 54)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "(サンプルの説明)"
        ' 
        ' label1
        ' 
        Me.label1.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Location = New System.Drawing.Point(16, 98)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(690, 1)
        Me.label1.TabIndex = 4
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Anchor = DirectCast((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContainer1.BackColor = System.Drawing.Color.Gainsboro
        Me.splitContainer1.Location = New System.Drawing.Point(16, 99)
        Me.splitContainer1.Name = "splitContainer1"
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.BackColor = System.Drawing.Color.White
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 5)
        Me.splitContainer1.Size = New System.Drawing.Size(708, 400)
        Me.splitContainer1.SplitterDistance = 349
        Me.splitContainer1.SplitterWidth = 3
        Me.splitContainer1.TabIndex = 5
        Me.splitContainer1.TabStop = False
        ' 
        ' DemoBase_settings
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 23.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
        Me.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(36)), CInt(CByte(34)), CInt(CByte(30)))
        Me.Name = "DemoBase_settings"
        Me.Padding = New System.Windows.Forms.Padding(14, 21, 14, 4)
        Me.Size = New System.Drawing.Size(724, 500)
        DirectCast(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private lblTitle As System.Windows.Forms.Label
    Private lblDescription As System.Windows.Forms.Label
    Private label1 As System.Windows.Forms.Label
    Public splitContainer1 As System.Windows.Forms.SplitContainer
End Class
