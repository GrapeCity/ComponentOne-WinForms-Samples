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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim C1ThumbButton1 As C1.Win.C1Win7Pack.C1ThumbButton = New C1.Win.C1Win7Pack.C1ThumbButton
        Dim C1ThumbButton2 As C1.Win.C1Win7Pack.C1ThumbButton = New C1.Win.C1Win7Pack.C1ThumbButton
        Dim C1ThumbButton3 As C1.Win.C1Win7Pack.C1ThumbButton = New C1.Win.C1Win7Pack.C1ThumbButton
        Dim C1ThumbButton4 As C1.Win.C1Win7Pack.C1ThumbButton = New C1.Win.C1Win7Pack.C1ThumbButton
        Dim C1ThumbButton5 As C1.Win.C1Win7Pack.C1ThumbButton = New C1.Win.C1Win7Pack.C1ThumbButton
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.progressCheckBox = New System.Windows.Forms.CheckBox
        Me.btnLastImage = New System.Windows.Forms.Button
        Me.btnFirstImage = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.btnNextImage = New System.Windows.Forms.Button
        Me.progressBar1 = New System.Windows.Forms.ProgressBar
        Me.clipCheckBox = New System.Windows.Forms.CheckBox
        Me.taskbarButton = New C1.Win.C1Win7Pack.C1TaskbarButton(Me.components)
        Me.imSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrevImage = New System.Windows.Forms.Button
        Me.imLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.radioButton7 = New System.Windows.Forms.RadioButton
        Me.radioButton4 = New System.Windows.Forms.RadioButton
        Me.radioButton3 = New System.Windows.Forms.RadioButton
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.radioButton8 = New System.Windows.Forms.RadioButton
        Me.radioButton6 = New System.Windows.Forms.RadioButton
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.radioButton5 = New System.Windows.Forms.RadioButton
        Me.labImageCaption = New System.Windows.Forms.Label
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'trackBar1
        '
        Me.trackBar1.Location = New System.Drawing.Point(103, 34)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(163, 45)
        Me.trackBar1.TabIndex = 2
        Me.trackBar1.TickFrequency = 10
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'progressCheckBox
        '
        Me.progressCheckBox.AutoSize = True
        Me.progressCheckBox.Location = New System.Drawing.Point(20, 22)
        Me.progressCheckBox.Name = "progressCheckBox"
        Me.progressCheckBox.Size = New System.Drawing.Size(60, 17)
        Me.progressCheckBox.TabIndex = 0
        Me.progressCheckBox.Text = "Visible"
        Me.progressCheckBox.UseVisualStyleBackColor = True
        '
        'btnLastImage
        '
        Me.btnLastImage.Image = CType(resources.GetObject("btnLastImage.Image"), System.Drawing.Image)
        Me.btnLastImage.Location = New System.Drawing.Point(223, 172)
        Me.btnLastImage.Name = "btnLastImage"
        Me.btnLastImage.Size = New System.Drawing.Size(46, 27)
        Me.btnLastImage.TabIndex = 12
        Me.toolTip1.SetToolTip(Me.btnLastImage, "Last Image")
        Me.btnLastImage.UseVisualStyleBackColor = True
        '
        'btnFirstImage
        '
        Me.btnFirstImage.Image = CType(resources.GetObject("btnFirstImage.Image"), System.Drawing.Image)
        Me.btnFirstImage.Location = New System.Drawing.Point(17, 172)
        Me.btnFirstImage.Name = "btnFirstImage"
        Me.btnFirstImage.Size = New System.Drawing.Size(46, 27)
        Me.btnFirstImage.TabIndex = 10
        Me.toolTip1.SetToolTip(Me.btnFirstImage, "First Image")
        Me.btnFirstImage.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 48)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Update Value:"
        '
        'btnNextImage
        '
        Me.btnNextImage.Image = CType(resources.GetObject("btnNextImage.Image"), System.Drawing.Image)
        Me.btnNextImage.Location = New System.Drawing.Point(223, 205)
        Me.btnNextImage.Name = "btnNextImage"
        Me.btnNextImage.Size = New System.Drawing.Size(46, 27)
        Me.btnNextImage.TabIndex = 14
        Me.toolTip1.SetToolTip(Me.btnNextImage, "Next Image")
        Me.btnNextImage.UseVisualStyleBackColor = True
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(20, 84)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(246, 23)
        Me.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.progressBar1.TabIndex = 7
        '
        'clipCheckBox
        '
        Me.clipCheckBox.AutoSize = True
        Me.clipCheckBox.Location = New System.Drawing.Point(236, 281)
        Me.clipCheckBox.Name = "clipCheckBox"
        Me.clipCheckBox.Size = New System.Drawing.Size(172, 17)
        Me.clipCheckBox.TabIndex = 16
        Me.clipCheckBox.Text = "Clip Thumbnail by the Image"
        Me.clipCheckBox.UseVisualStyleBackColor = True
        '
        'taskbarButton
        '
        Me.taskbarButton.ContainerForm = Me
        C1ThumbButton1.ImageIndex = 0
        C1ThumbButton1.Name = "FirstImage"
        C1ThumbButton1.Tooltip = "First Image"
        C1ThumbButton2.ImageIndex = 1
        C1ThumbButton2.Name = "PrevImage"
        C1ThumbButton2.Tooltip = "Previous Image"
        C1ThumbButton3.ImageIndex = 2
        C1ThumbButton3.Name = "NextImage"
        C1ThumbButton3.Tooltip = "Next Image"
        C1ThumbButton4.ImageIndex = 3
        C1ThumbButton4.Name = "LastImage"
        C1ThumbButton4.Tooltip = "Last Image"
        C1ThumbButton5.DismissOnClick = True
        C1ThumbButton5.ImageIndex = 4
        C1ThumbButton5.Name = "ToggleView"
        C1ThumbButton5.Tooltip = "Toggle View"
        Me.taskbarButton.Thumbnail.Buttons.AddRange(New C1.Win.C1Win7Pack.C1ThumbButton() {C1ThumbButton1, C1ThumbButton2, C1ThumbButton3, C1ThumbButton4, C1ThumbButton5})
        Me.taskbarButton.Thumbnail.ImageList = Me.imSmall
        Me.taskbarButton.WindowAppID = "TaskbarDemo"
        '
        'imSmall
        '
        Me.imSmall.ImageStream = CType(resources.GetObject("imSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imSmall.Images.SetKeyName(0, "MoveFirst.png")
        Me.imSmall.Images.SetKeyName(1, "MovePrevious_16x16.png")
        Me.imSmall.Images.SetKeyName(2, "MoveNext_16x16.png")
        Me.imSmall.Images.SetKeyName(3, "MoveLast.png")
        Me.imSmall.Images.SetKeyName(4, "Flag.png")
        '
        'btnPrevImage
        '
        Me.btnPrevImage.Image = CType(resources.GetObject("btnPrevImage.Image"), System.Drawing.Image)
        Me.btnPrevImage.Location = New System.Drawing.Point(17, 205)
        Me.btnPrevImage.Name = "btnPrevImage"
        Me.btnPrevImage.Size = New System.Drawing.Size(46, 27)
        Me.btnPrevImage.TabIndex = 13
        Me.toolTip1.SetToolTip(Me.btnPrevImage, "Previous Image")
        Me.btnPrevImage.UseVisualStyleBackColor = True
        '
        'imLarge
        '
        Me.imLarge.ImageStream = CType(resources.GetObject("imLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.imLarge.Images.SetKeyName(0, "PrintView.png")
        Me.imLarge.Images.SetKeyName(1, "Monitor.png")
        Me.imLarge.Images.SetKeyName(2, "GreenBook.png")
        Me.imLarge.Images.SetKeyName(3, "Wall.png")
        Me.imLarge.Images.SetKeyName(4, "Tip.png")
        Me.imLarge.Images.SetKeyName(5, "Reminder.png")
        Me.imLarge.Images.SetKeyName(6, "JournalBook.png")
        Me.imLarge.Images.SetKeyName(7, "Lightbulb.png")
        Me.imLarge.Images.SetKeyName(8, "PaintPalette.png")
        Me.imLarge.Images.SetKeyName(9, "PaperClip.png")
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(69, 150)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(148, 148)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 11
        Me.pictureBox1.TabStop = False
        '
        'radioButton7
        '
        Me.radioButton7.AutoSize = True
        Me.radioButton7.Location = New System.Drawing.Point(285, 67)
        Me.radioButton7.Name = "radioButton7"
        Me.radioButton7.Size = New System.Drawing.Size(62, 17)
        Me.radioButton7.TabIndex = 5
        Me.radioButton7.Text = "Paused"
        Me.radioButton7.UseVisualStyleBackColor = True
        '
        'radioButton4
        '
        Me.radioButton4.AutoSize = True
        Me.radioButton4.Location = New System.Drawing.Point(15, 90)
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.Size = New System.Drawing.Size(70, 17)
        Me.radioButton4.TabIndex = 3
        Me.radioButton4.Text = "Warning"
        Me.radioButton4.UseVisualStyleBackColor = True
        '
        'radioButton3
        '
        Me.radioButton3.AutoSize = True
        Me.radioButton3.Location = New System.Drawing.Point(15, 67)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(46, 17)
        Me.radioButton3.TabIndex = 2
        Me.radioButton3.Text = "Info"
        Me.radioButton3.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radioButton4)
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(97, 121)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Overlay Icon"
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Location = New System.Drawing.Point(15, 44)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(50, 17)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.Text = "Error"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Checked = True
        Me.radioButton1.Location = New System.Drawing.Point(15, 21)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(53, 17)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "None"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'radioButton8
        '
        Me.radioButton8.AutoSize = True
        Me.radioButton8.Location = New System.Drawing.Point(285, 90)
        Me.radioButton8.Name = "radioButton8"
        Me.radioButton8.Size = New System.Drawing.Size(71, 17)
        Me.radioButton8.TabIndex = 6
        Me.radioButton8.Text = "Marquee"
        Me.radioButton8.UseVisualStyleBackColor = True
        '
        'radioButton6
        '
        Me.radioButton6.AutoSize = True
        Me.radioButton6.Location = New System.Drawing.Point(285, 44)
        Me.radioButton6.Name = "radioButton6"
        Me.radioButton6.Size = New System.Drawing.Size(50, 17)
        Me.radioButton6.TabIndex = 4
        Me.radioButton6.Text = "Error"
        Me.radioButton6.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.progressBar1)
        Me.groupBox2.Controls.Add(Me.trackBar1)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.progressCheckBox)
        Me.groupBox2.Controls.Add(Me.radioButton8)
        Me.groupBox2.Controls.Add(Me.radioButton7)
        Me.groupBox2.Controls.Add(Me.radioButton6)
        Me.groupBox2.Controls.Add(Me.radioButton5)
        Me.groupBox2.Location = New System.Drawing.Point(133, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(367, 121)
        Me.groupBox2.TabIndex = 9
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Progress Indicator"
        '
        'radioButton5
        '
        Me.radioButton5.AutoSize = True
        Me.radioButton5.Checked = True
        Me.radioButton5.Location = New System.Drawing.Point(285, 21)
        Me.radioButton5.Name = "radioButton5"
        Me.radioButton5.Size = New System.Drawing.Size(62, 17)
        Me.radioButton5.TabIndex = 3
        Me.radioButton5.TabStop = True
        Me.radioButton5.Text = "Normal"
        Me.radioButton5.UseVisualStyleBackColor = True
        '
        'labImageCaption
        '
        Me.labImageCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labImageCaption.Location = New System.Drawing.Point(286, 169)
        Me.labImageCaption.Name = "labImageCaption"
        Me.labImageCaption.Size = New System.Drawing.Size(214, 30)
        Me.labImageCaption.TabIndex = 15
        Me.labImageCaption.Text = "Image Caption"
        Me.labImageCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 317)
        Me.Controls.Add(Me.btnLastImage)
        Me.Controls.Add(Me.btnFirstImage)
        Me.Controls.Add(Me.btnNextImage)
        Me.Controls.Add(Me.clipCheckBox)
        Me.Controls.Add(Me.btnPrevImage)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.labImageCaption)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "C1TaskbarButton Demo"
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private WithEvents progressCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents btnLastImage As System.Windows.Forms.Button
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents btnFirstImage As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnNextImage As System.Windows.Forms.Button
    Private WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents clipCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents taskbarButton As C1.Win.C1Win7Pack.C1TaskbarButton
    Private WithEvents btnPrevImage As System.Windows.Forms.Button
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents radioButton4 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents radioButton8 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton7 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton6 As System.Windows.Forms.RadioButton
    Private WithEvents radioButton5 As System.Windows.Forms.RadioButton
    Private WithEvents labImageCaption As System.Windows.Forms.Label
    Private WithEvents imSmall As System.Windows.Forms.ImageList
    Private WithEvents imLarge As System.Windows.Forms.ImageList

End Class
