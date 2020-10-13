Namespace TouchEvent
    Partial Class DrawingBoardDemo
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
            Me.paintPanel = New TouchEvent.PaintPanel()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.drawSizePanel1 = New TouchEvent.DrawSizePanel()
            Me.drawModePanel1 = New TouchEvent.DrawModePanel()
            Me.colorPanel1 = New TouchEvent.ColorPanel()
            Me.gcTouchEventProvider1 = New C1.Win.TouchToolKit.C1TouchEventProvider()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Controls.Add(Me.paintPanel)
            Me.gcTouchEventProvider1.SetEnableTouchEvents(Me.panel1, True)
            '
            'paintPanel
            '
            Me.paintPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.paintPanel.Location = New System.Drawing.Point(1, 73)
            Me.paintPanel.Name = "paintPanel"
            Me.paintPanel.Owner = Nothing
            Me.paintPanel.Size = New System.Drawing.Size(689, 296)
            Me.paintPanel.TabIndex = 0
            '
            'panel2
            '
            Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.drawSizePanel1)
            Me.panel2.Controls.Add(Me.drawModePanel1)
            Me.panel2.Controls.Add(Me.colorPanel1)
            Me.panel2.Location = New System.Drawing.Point(1, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(704, 72)
            Me.panel2.TabIndex = 0
            '
            'drawSizePanel1
            '
            Me.drawSizePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.drawSizePanel1.DrawSize = 0
            Me.drawSizePanel1.Location = New System.Drawing.Point(587, -1)
            Me.drawSizePanel1.Name = "drawSizePanel1"
            Me.drawSizePanel1.Owner = Nothing
            Me.drawSizePanel1.Size = New System.Drawing.Size(101, 72)
            Me.drawSizePanel1.TabIndex = 6
            '
            'drawModePanel1
            '
            Me.drawModePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.drawModePanel1.DrawMode = TouchEvent.DrawMode.Draw
            Me.drawModePanel1.Location = New System.Drawing.Point(-1, -1)
            Me.drawModePanel1.Name = "drawModePanel1"
            Me.drawModePanel1.Owner = Nothing
            Me.drawModePanel1.Size = New System.Drawing.Size(71, 72)
            Me.drawModePanel1.TabIndex = 5
            '
            'colorPanel1
            '
            Me.colorPanel1.BackgroundColor = System.Drawing.Color.White
            Me.colorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.colorPanel1.ForegroundColor = System.Drawing.Color.Black
            Me.colorPanel1.Location = New System.Drawing.Point(69, -1)
            Me.colorPanel1.Name = "colorPanel1"
            Me.colorPanel1.Size = New System.Drawing.Size(519, 72)
            Me.colorPanel1.TabIndex = 3
            '
            'gcTouchEventProvider1
            '
            '
            'DrawingBoardDemo
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 36.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "DrawingBoardDemo"
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private paintPanel As PaintPanel
        Private WithEvents gcTouchEventProvider1 As C1.Win.TouchToolKit.C1TouchEventProvider
        Private colorPanel1 As ColorPanel
        Private panel2 As System.Windows.Forms.Panel
        Private drawModePanel1 As DrawModePanel
        Private drawSizePanel1 As DrawSizePanel
    End Class
End Namespace
