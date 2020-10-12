
Namespace C1FlexReportExplorer
    Partial Class PreviewForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.BackColor = System.Drawing.Color.White
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureBox1.Location = New System.Drawing.Point(5, 5)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(384, 496)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            ' 
            ' FormImgPreview
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.SandyBrown
            Me.ClientSize = New System.Drawing.Size(394, 506)
            Me.Controls.Add(Me.pictureBox1)
            Me.ForeColor = System.Drawing.Color.Transparent
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "FormImgPreview"
            Me.Padding = New System.Windows.Forms.Padding(5)
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "ImagePreview"
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Public pictureBox1 As System.Windows.Forms.PictureBox
    End Class
End Namespace

