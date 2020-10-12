Namespace C1ZoomPages.Help_Forms
    Partial Class ControlBarUserControl01
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
            Me.button5 = New System.Windows.Forms.Button()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.button1 = New System.Windows.Forms.Button()
            Me.gcZoomCommandProvider1 = New C1.Win.TouchToolKit.C1ZoomCommandProvider(Me.components)
            Me.SuspendLayout()
            ' 
            ' button5
            ' 
            Me.button5.BackColor = System.Drawing.Color.White
            Me.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.button5.FlatAppearance.BorderSize = 3
            Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button5.Font = New System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(2))
            Me.button5.Location = New System.Drawing.Point(155, 35)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(40, 37)
            Me.button5.TabIndex = 1
            Me.button5.Text = ""
            Me.toolTip1.SetToolTip(Me.button5, "ShowOrHidePreviewWindow")
            Me.button5.UseVisualStyleBackColor = False
            Me.gcZoomCommandProvider1.SetZoomCommands(Me.button5, C1.Win.TouchToolKit.ZoomCommands.ShowOrHidePreviewWindow)
            ' 
            ' toolTip1
            ' 
            Me.toolTip1.ShowAlways = True
            ' 
            ' button1
            ' 
            Me.button1.BackColor = System.Drawing.Color.White
            Me.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.button1.FlatAppearance.BorderSize = 3
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Webdings", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(2))
            Me.button1.Location = New System.Drawing.Point(201, 35)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(40, 37)
            Me.button1.TabIndex = 1
            Me.button1.Text = ""
            Me.button1.UseVisualStyleBackColor = False
            AddHandler Me.button1.Click, New EventHandler(AddressOf Me.button1_Click)
            ' 
            ' gcZoomCommandProvider1
            ' 
            Me.gcZoomCommandProvider1.Target = Me
            ' 
            ' ControlBarUserControl01
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 12.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.button5)
            Me.Name = "ControlBarUserControl01"
            Me.Size = New System.Drawing.Size(291, 112)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private toolTip1 As System.Windows.Forms.ToolTip
        Private button5 As System.Windows.Forms.Button
        Private button1 As System.Windows.Forms.Button
        Private gcZoomCommandProvider1 As C1.Win.TouchToolKit.C1ZoomCommandProvider
    End Class
End Namespace
