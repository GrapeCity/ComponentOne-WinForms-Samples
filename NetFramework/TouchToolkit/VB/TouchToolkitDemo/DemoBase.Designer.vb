Partial Class DemoBase
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        ' 
        ' lblTitle
        ' 
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Meiryo", 14.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
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
        Me.lblDescription.Font = New System.Drawing.Font("Meiryo", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(36)), CInt(CByte(34)), CInt(CByte(30)))
        Me.lblDescription.Location = New System.Drawing.Point(17, 44)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(690, 76)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "(Add description)"
        ' 
        ' label1
        ' 
        Me.label1.Anchor = DirectCast(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Location = New System.Drawing.Point(16, 120)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(690, 1)
        Me.label1.TabIndex = 4
        ' 
        ' panel1
        ' 
        Me.panel1.Anchor = DirectCast((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.Location = New System.Drawing.Point(16, 122)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(690, 372)
        Me.panel1.TabIndex = 5
        ' 
        ' DemoBase
        ' 
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Meiryo", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
        Me.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(36)), CInt(CByte(34)), CInt(CByte(30)))
        Me.Name = "DemoBase"
        Me.Padding = New System.Windows.Forms.Padding(14, 21, 14, 4)
        Me.Size = New System.Drawing.Size(724, 500)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private lblTitle As System.Windows.Forms.Label
    Private lblDescription As System.Windows.Forms.Label
    Private label1 As System.Windows.Forms.Label
    Public panel1 As System.Windows.Forms.Panel
End Class
