Namespace MultiScaleImagePages
    Partial Class MultiScaleImageDemo
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
            Dim imageItem1 As New C1.Win.TouchToolKit.ImageItem()
            Dim imageItem2 As New C1.Win.TouchToolKit.ImageItem()
            Dim imageItem3 As New C1.Win.TouchToolKit.ImageItem()
            Dim imageItem4 As New C1.Win.TouchToolKit.ImageItem()
            Dim imageItem5 As New C1.Win.TouchToolKit.ImageItem()
            Dim imageItem6 As New C1.Win.TouchToolKit.ImageItem()
            Me.zoomFactorLabel = New System.Windows.Forms.Label()
            Me.gcZoomPanel1 = New C1.Win.TouchToolKit.C1ZoomPanel()
            Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.label4 = New System.Windows.Forms.Label()
            Me.gcMultiScaleImage1 = New C1.Win.TouchToolKit.C1MultiScaleImage()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.panel1.SuspendLayout()
            Me.gcZoomPanel1.SuspendLayout()
            Me.tableLayoutPanel2.SuspendLayout()
            Me.panel2.SuspendLayout()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            DirectCast(Me.gcMultiScaleImage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.tableLayoutPanel1)
            ' 
            ' zoomFactorLabel
            ' 
            Me.zoomFactorLabel.Location = New System.Drawing.Point(3, 322)
            Me.zoomFactorLabel.Name = "zoomFactorLabel"
            Me.zoomFactorLabel.Size = New System.Drawing.Size(650, 50)
            Me.zoomFactorLabel.TabIndex = 1
            Me.zoomFactorLabel.Text = "ZoomFactor:"
            ' 
            ' gcZoomPanel1
            ' 
            Me.gcZoomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gcZoomPanel1.Controls.Add(Me.tableLayoutPanel2)
            Me.gcZoomPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gcZoomPanel1.Location = New System.Drawing.Point(0, 0)
            Me.gcZoomPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.gcZoomPanel1.Name = "gcZoomPanel1"
            Me.gcZoomPanel1.Size = New System.Drawing.Size(690, 322)
            Me.gcZoomPanel1.TabIndex = 6
            ' 
            ' tableLayoutPanel2
            ' 
            Me.tableLayoutPanel2.ColumnCount = 2
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel2.Controls.Add(Me.panel2, 0, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.panel3, 1, 0)
            Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
            Me.tableLayoutPanel2.RowCount = 1
            Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel2.Size = New System.Drawing.Size(688, 320)
            Me.tableLayoutPanel2.TabIndex = 6
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.pictureBox1)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(3, 3)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(338, 314)
            Me.panel2.TabIndex = 0
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Image = My.Resources.airplane1
            Me.pictureBox1.Location = New System.Drawing.Point(56, 70)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(236, 136)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
            Me.pictureBox1.TabIndex = 3
            Me.pictureBox1.TabStop = False
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(133, 272)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(88, 23)
            Me.label3.TabIndex = 4
            Me.label3.Text = "PictureBox"
            ' 
            ' panel3
            ' 
            Me.panel3.Controls.Add(Me.label4)
            Me.panel3.Controls.Add(Me.gcMultiScaleImage1)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(347, 3)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(338, 314)
            Me.panel3.TabIndex = 1
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(102, 272)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(151, 23)
            Me.label4.TabIndex = 5
            Me.label4.Text = "C1MultiScaleImage"
            ' 
            ' gcMultiScaleImage1
            ' 
            Me.gcMultiScaleImage1.Image = My.Resources.airplane1
            imageItem1.Image = My.Resources.airplane1_5
            imageItem1.ZoomFactor = 1.5F
            imageItem2.Image = My.Resources.airplane2
            imageItem3.Image = My.Resources.airplane2_5
            imageItem3.ZoomFactor = 2.5F
            imageItem4.Image = My.Resources.airplane3
            imageItem4.ZoomFactor = 3.0F
            imageItem5.Image = My.Resources.airplane3_5
            imageItem5.ZoomFactor = 3.5F
            imageItem6.Image = My.Resources.F22
            imageItem6.ZoomFactor = 4.0F
            Me.gcMultiScaleImage1.Images.Add(imageItem1)
            Me.gcMultiScaleImage1.Images.Add(imageItem2)
            Me.gcMultiScaleImage1.Images.Add(imageItem3)
            Me.gcMultiScaleImage1.Images.Add(imageItem4)
            Me.gcMultiScaleImage1.Images.Add(imageItem5)
            Me.gcMultiScaleImage1.Images.Add(imageItem6)
            Me.gcMultiScaleImage1.Location = New System.Drawing.Point(42, 70)
            Me.gcMultiScaleImage1.Name = "gcMultiScaleImage1"
            Me.gcMultiScaleImage1.Size = New System.Drawing.Size(236, 136)
            Me.gcMultiScaleImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.gcMultiScaleImage1.TabIndex = 2
            Me.gcMultiScaleImage1.TabStop = False
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.zoomFactorLabel, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.gcZoomPanel1, 0, 0)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 2
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(690, 372)
            Me.tableLayoutPanel1.TabIndex = 6
            ' 
            ' MultiScaleImageDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 23.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "MultiScaleImageDemo"
            Me.panel1.ResumeLayout(False)
            Me.gcZoomPanel1.ResumeLayout(False)
            Me.tableLayoutPanel2.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            DirectCast(Me.gcMultiScaleImage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private zoomFactorLabel As System.Windows.Forms.Label
        Private gcZoomPanel1 As C1.Win.TouchToolKit.C1ZoomPanel
        Private label3 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private gcMultiScaleImage1 As C1.Win.TouchToolKit.C1MultiScaleImage
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Private panel2 As System.Windows.Forms.Panel
        Private panel3 As System.Windows.Forms.Panel



    End Class
End Namespace