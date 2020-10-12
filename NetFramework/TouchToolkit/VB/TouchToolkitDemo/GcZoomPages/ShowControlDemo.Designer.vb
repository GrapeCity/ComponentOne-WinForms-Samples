Namespace C1ZoomPages
    Partial Class ShowControlDemo
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.formButton = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label17 = New System.Windows.Forms.Label()
            Me.label16 = New System.Windows.Forms.Label()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.panel1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.formButton)
            ' 
            ' formButton
            ' 
            Me.formButton.Location = New System.Drawing.Point(16, 5)
            Me.formButton.Name = "formButton"
            Me.formButton.Size = New System.Drawing.Size(355, 30)
            Me.formButton.TabIndex = 0
            Me.formButton.Text = "Click Me To Show The Test Form For ShowControl"
            Me.formButton.UseVisualStyleBackColor = True
            AddHandler Me.formButton.Click, New EventHandler(AddressOf Me.formButton_Click)
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.label17)
            Me.groupBox1.Controls.Add(Me.label16)
            Me.groupBox1.Controls.Add(Me.pictureBox2)
            Me.groupBox1.Controls.Add(Me.pictureBox1)
            Me.groupBox1.Location = New System.Drawing.Point(16, 41)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(663, 328)
            Me.groupBox1.TabIndex = 22
            Me.groupBox1.TabStop = False
            ' 
            ' label17
            ' 
            Me.label17.AutoSize = True
            Me.label17.Location = New System.Drawing.Point(6, 14)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(300, 23)
            Me.label17.TabIndex = 22
            Me.label17.Text = "InputBox may hide by screen keyboard."
            ' 
            ' label16
            ' 
            Me.label16.AutoSize = True
            Me.label16.Location = New System.Drawing.Point(6, 168)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(624, 23)
            Me.label16.TabIndex = 23
            Me.label16.Text = "The input box will scroll out when screen keyboard open if AutoShowControl is tru" + "e."
            ' 
            ' pictureBox2
            ' 
            Me.pictureBox2.Image = My.Resources._with
            Me.pictureBox2.Location = New System.Drawing.Point(38, 198)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(558, 124)
            Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox2.TabIndex = 24
            Me.pictureBox2.TabStop = False
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Image = My.Resources.without
            Me.pictureBox1.Location = New System.Drawing.Point(38, 40)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(558, 121)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 24
            Me.pictureBox1.TabStop = False
            ' 
            ' ShowControlDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 23.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "ShowControlDemo"
            Me.panel1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private formButton As System.Windows.Forms.Button
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private label16 As System.Windows.Forms.Label
        Private label17 As System.Windows.Forms.Label
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private pictureBox2 As System.Windows.Forms.PictureBox
    End Class
End Namespace
