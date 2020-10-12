Namespace C1ZoomPages
    Partial Class ZoomPolicyDemo
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
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.description1 = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.listBox1 = New System.Windows.Forms.ListBox()
            Me.splitter1 = New System.Windows.Forms.Splitter()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.panel1.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Controls.Add(Me.splitter1)
            Me.panel1.Controls.Add(Me.panel3)
            Me.panel1.Size = New System.Drawing.Size(691, 378)
            ' 
            ' formButton
            ' 
            Me.formButton.Location = New System.Drawing.Point(6, 24)
            Me.formButton.Name = "formButton"
            Me.formButton.Size = New System.Drawing.Size(220, 55)
            Me.formButton.TabIndex = 33
            Me.formButton.Text = "Show Form"
            Me.formButton.UseVisualStyleBackColor = True
            AddHandler Me.formButton.Click, New EventHandler(AddressOf Me.formButton_Click)
            ' 
            ' panel3
            ' 
            Me.panel3.Controls.Add(Me.formButton)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel3.Location = New System.Drawing.Point(0, 0)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(235, 378)
            Me.panel3.TabIndex = 3
            ' 
            ' description1
            ' 
            Me.description1.BackColor = System.Drawing.SystemColors.Info
            Me.description1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.tableLayoutPanel1.SetColumnSpan(Me.description1, 2)
            Me.description1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.description1.Location = New System.Drawing.Point(3, 299)
            Me.description1.Multiline = True
            Me.description1.Name = "description1"
            Me.description1.[ReadOnly] = True
            Me.description1.Size = New System.Drawing.Size(447, 76)
            Me.description1.TabIndex = 34
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label2.Location = New System.Drawing.Point(3, 0)
            Me.label2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(269, 18)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Select a ZoomPolicy:"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
            ' 
            ' listBox1
            ' 
            Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBox1.FormattingEnabled = True
            Me.listBox1.IntegralHeight = False
            Me.listBox1.ItemHeight = 18
            Me.listBox1.Location = New System.Drawing.Point(3, 24)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(269, 269)
            Me.listBox1.TabIndex = 0
            AddHandler Me.listBox1.SelectedIndexChanged, New EventHandler(AddressOf Me.listBox1_SelectedIndexChanged)
            ' 
            ' splitter1
            ' 
            Me.splitter1.BackColor = System.Drawing.Color.LightGray
            Me.splitter1.Enabled = False
            Me.splitter1.Location = New System.Drawing.Point(235, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 378)
            Me.splitter1.TabIndex = 4
            Me.splitter1.TabStop = False
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.tableLayoutPanel1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel2.Location = New System.Drawing.Point(238, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(453, 378)
            Me.panel2.TabIndex = 5
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.Controls.Add(Me.description1, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.label2, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.listBox1, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.groupBox1, 1, 0)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 3
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(453, 378)
            Me.tableLayoutPanel1.TabIndex = 2
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBox1.Location = New System.Drawing.Point(285, 6)
            Me.groupBox1.Margin = New System.Windows.Forms.Padding(10, 6, 3, 3)
            Me.groupBox1.Name = "groupBox1"
            Me.tableLayoutPanel1.SetRowSpan(Me.groupBox1, 2)
            Me.groupBox1.Size = New System.Drawing.Size(165, 287)
            Me.groupBox1.TabIndex = 2
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Product"
            Me.groupBox1.Visible = False
            ' 
            ' ZoomPolicyDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 18.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "ZoomPolicyDemo"
            Me.panel1.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private formButton As System.Windows.Forms.Button
        Private panel3 As System.Windows.Forms.Panel
        Private listBox1 As System.Windows.Forms.ListBox
        Private label2 As System.Windows.Forms.Label
        Private panel2 As System.Windows.Forms.Panel
        Private splitter1 As System.Windows.Forms.Splitter
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private description1 As System.Windows.Forms.TextBox
    End Class
End Namespace
