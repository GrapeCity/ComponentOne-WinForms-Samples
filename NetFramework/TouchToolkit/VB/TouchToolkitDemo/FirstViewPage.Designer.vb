Partial Class FirstViewPage
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
        Me.product2 = New System.Windows.Forms.Label()
        Me.product3 = New System.Windows.Forms.Label()
        Me.mainvisual = New System.Windows.Forms.PictureBox()
        DirectCast(Me.mainvisual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' product2
        ' 
        Me.product2.AutoSize = True
        Me.product2.BackColor = System.Drawing.Color.Transparent
        Me.product2.Font = New System.Drawing.Font("Meiryo", 28.0F)
        Me.product2.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(42)), CInt(CByte(42)), CInt(CByte(42)))
        Me.product2.Location = New System.Drawing.Point(15, 385)
        Me.product2.Name = "product2"
        Me.product2.Size = New System.Drawing.Size(275, 71)
        Me.product2.TabIndex = 1
        Me.product2.Text = "MultiTouch"
        ' 
        ' product3
        ' 
        Me.product3.AutoSize = True
        Me.product3.BackColor = System.Drawing.Color.Transparent
        Me.product3.Font = New System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
        Me.product3.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(42)), CInt(CByte(42)), CInt(CByte(42)))
        Me.product3.Location = New System.Drawing.Point(174, 456)
        Me.product3.Name = "product3"
        Me.product3.Size = New System.Drawing.Size(242, 36)
        Me.product3.TabIndex = 1
        Me.product3.Text = "for Windows Forms"
        ' 
        ' mainvisual
        ' 
        Me.mainvisual.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(251)), CInt(CByte(251)), CInt(CByte(250)))
        Me.mainvisual.BackgroundImage = My.Resources.mainvisual
        Me.mainvisual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mainvisual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainvisual.Location = New System.Drawing.Point(0, 0)
        Me.mainvisual.Name = "mainvisual"
        Me.mainvisual.Size = New System.Drawing.Size(724, 500)
        Me.mainvisual.TabIndex = 0
        Me.mainvisual.TabStop = False
        ' 
        ' FirstViewPage
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 23.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.product3)
        Me.Controls.Add(Me.product2)
        Me.Controls.Add(Me.mainvisual)
        Me.Font = New System.Drawing.Font("Meiryo", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
        Me.Name = "FirstViewPage"
        Me.Size = New System.Drawing.Size(724, 500)
        DirectCast(Me.mainvisual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mainvisual As System.Windows.Forms.PictureBox
    Private product2 As System.Windows.Forms.Label
    Private product3 As System.Windows.Forms.Label

End Class
