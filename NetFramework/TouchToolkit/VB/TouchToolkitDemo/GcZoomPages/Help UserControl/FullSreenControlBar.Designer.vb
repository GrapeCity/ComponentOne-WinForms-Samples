Namespace C1ZoomPages.Help_Forms
    Partial Class ControlBarUserControl03
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
            Me.components = New System.ComponentModel.Container()
            Me.button4 = New System.Windows.Forms.Button()
            Me.button5 = New System.Windows.Forms.Button()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.gcZoomCommandProvider1 = New C1.Win.TouchToolKit.C1ZoomCommandProvider(Me.components)
            Me.SuspendLayout()
            ' 
            ' button4
            ' 
            Me.button4.Location = New System.Drawing.Point(143, 3)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(119, 33)
            Me.button4.TabIndex = 1
            Me.button4.Text = "Close Form"
            Me.toolTip1.SetToolTip(Me.button4, "SelectPreviousControl")
            Me.button4.UseVisualStyleBackColor = True
            AddHandler Me.button4.Click, New EventHandler(AddressOf Me.button4_Click)
            ' 
            ' button5
            ' 
            Me.button5.Location = New System.Drawing.Point(8, 3)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(119, 33)
            Me.button5.TabIndex = 2
            Me.button5.Text = "Full screen"
            Me.toolTip1.SetToolTip(Me.button5, "FullScreen")
            Me.button5.UseVisualStyleBackColor = True
            Me.gcZoomCommandProvider1.SetZoomCommands(Me.button5, C1.Win.TouchToolKit.ZoomCommands.SwitchFullScreen)
            AddHandler Me.button5.Click, New EventHandler(AddressOf Me.button5_Click)
            ' 
            ' gcZoomCommandProvider1
            ' 
            Me.gcZoomCommandProvider1.Target = Me
            ' 
            ' ControlBarUserControl03
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 12.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.ActiveBorder
            Me.Controls.Add(Me.button4)
            Me.Controls.Add(Me.button5)
            Me.Name = "ControlBarUserControl03"
            Me.Size = New System.Drawing.Size(272, 40)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private button4 As System.Windows.Forms.Button
        Private button5 As System.Windows.Forms.Button
        Private toolTip1 As System.Windows.Forms.ToolTip
        Private gcZoomCommandProvider1 As C1.Win.TouchToolKit.C1ZoomCommandProvider
    End Class
End Namespace
