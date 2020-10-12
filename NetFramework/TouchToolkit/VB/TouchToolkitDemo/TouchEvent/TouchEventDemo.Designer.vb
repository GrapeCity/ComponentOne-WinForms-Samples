Namespace TouchEvent
    Partial Class TouchEventDemo
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
            Me.gcTouchEventProvider1 = New C1.Win.TouchToolKit.C1TouchEventProvider()
            Me.paintPanel1 = New TouchEvent.ImagePanel()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.rotateRadioButton = New System.Windows.Forms.RadioButton()
            Me.defaultRadioButton = New System.Windows.Forms.RadioButton()
            Me.panel1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.paintPanel1)
            Me.panel1.Location = New System.Drawing.Point(16, 101)
            Me.panel1.Size = New System.Drawing.Size(690, 392)
            ' 
            ' gcTouchEventProvider1
            ' 
            'AddHandler Me.gcTouchEventProvider1.Tapped, New EventHandler(AddressOf Me.gcTouchEventProvider1_Tapped)
            'AddHandler Me.gcTouchEventProvider1.ManipulationStarting, New EventHandler(AddressOf Me.gcTouchEventProvider1_ManipulationStarting)
            'AddHandler Me.gcTouchEventProvider1.ManipulationStarted, New EventHandler(AddressOf Me.gcTouchEventProvider1_ManipulationStarted)
            'AddHandler Me.gcTouchEventProvider1.ManipulationDelta, New EventHandler(AddressOf Me.gcTouchEventProvider1_ManipulationDelta)
            'AddHandler Me.gcTouchEventProvider1.ManipulationInertiaStarting, New EventHandler(AddressOf Me.gcTouchEventProvider1_ManipulationInertiaStarting)
            'AddHandler Me.gcTouchEventProvider1.ManipulationCompleted, New EventHandler(AddressOf Me.gcTouchEventProvider1_ManipulationCompleted)
            ' 
            ' paintPanel1
            ' 
            Me.paintPanel1.ActiveImageIndex = -1
            Me.paintPanel1.Anchor = DirectCast((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.paintPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gcTouchEventProvider1.SetEnableTouchEvents(Me.paintPanel1, True)
            Me.paintPanel1.Location = New System.Drawing.Point(0, 56)
            Me.paintPanel1.ManipulationPosition = New System.Drawing.Point(0, 0)
            Me.paintPanel1.Name = "paintPanel1"
            Me.paintPanel1.Size = New System.Drawing.Size(690, 336)
            Me.paintPanel1.TabIndex = 0
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.rotateRadioButton)
            Me.groupBox1.Controls.Add(Me.defaultRadioButton)
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.groupBox1.Location = New System.Drawing.Point(0, 0)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(690, 50)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Gesture mode"
            ' 
            ' rotateRadioButton
            ' 
            Me.rotateRadioButton.AutoSize = True
            Me.rotateRadioButton.Location = New System.Drawing.Point(406, 19)
            Me.rotateRadioButton.Name = "rotateRadioButton"
            Me.rotateRadioButton.Size = New System.Drawing.Size(263, 27)
            Me.rotateRadioButton.TabIndex = 1
            Me.rotateRadioButton.Text = "Rotate the image by one finger."
            Me.rotateRadioButton.UseVisualStyleBackColor = True
            ' 
            ' defaultRadioButton
            ' 
            Me.defaultRadioButton.AutoSize = True
            Me.defaultRadioButton.Checked = True
            Me.defaultRadioButton.Location = New System.Drawing.Point(7, 19)
            Me.defaultRadioButton.Name = "defaultRadioButton"
            Me.defaultRadioButton.Size = New System.Drawing.Size(393, 27)
            Me.defaultRadioButton.TabIndex = 0
            Me.defaultRadioButton.TabStop = True
            Me.defaultRadioButton.Text = "Move, zoom and rotate the image by two fingers."
            Me.defaultRadioButton.UseVisualStyleBackColor = True
            AddHandler Me.defaultRadioButton.CheckedChanged, New EventHandler(AddressOf Me.ModeRadioButton_CheckedChanged)
            ' 
            ' TouchEventDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 23.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "TouchEventDemo"
            Me.panel1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private gcTouchEventProvider1 As C1.Win.TouchToolKit.C1TouchEventProvider
        Private paintPanel1 As ImagePanel
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private rotateRadioButton As System.Windows.Forms.RadioButton
        Private defaultRadioButton As System.Windows.Forms.RadioButton
    End Class
End Namespace
