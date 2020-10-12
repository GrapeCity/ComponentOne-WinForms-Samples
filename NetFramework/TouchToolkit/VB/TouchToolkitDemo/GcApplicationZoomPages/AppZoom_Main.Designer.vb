Namespace C1ApplicationZoomPages
    Partial Class AppZoom_Main
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
            Dim listViewItem1 As New System.Windows.Forms.ListViewItem(New String() {"データ照会"}, "Red.bmp", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem2 As New System.Windows.Forms.ListViewItem(New String() {"口座情報"}, "Green.bmp", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem3 As New System.Windows.Forms.ListViewItem(New String() {"取引履歴"}, "Blue.bmp", System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem4 As New System.Windows.Forms.ListViewItem(New String() {"顧客情報"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold))
            Dim listViewItem5 As New System.Windows.Forms.ListViewItem(New String() {"合併"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem6 As New System.Windows.Forms.ListViewItem(New String() {"サービス"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem7 As New System.Windows.Forms.ListViewItem(New String() {"会社"}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem8 As New System.Windows.Forms.ListViewItem(New String() {"顧客"}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem9 As New System.Windows.Forms.ListViewItem(New String() {"社員"}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem10 As New System.Windows.Forms.ListViewItem(New String() {"レポート"}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Dim listViewItem11 As New System.Windows.Forms.ListViewItem(New String() {"販売元"}, 6, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("MS UI Gothic", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128)))
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.button4 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.listView2 = New System.Windows.Forms.ListView()
            Me.label2 = New System.Windows.Forms.Label()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.columnHeader1 = DirectCast(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.label1 = New System.Windows.Forms.Label()
            Me.panel6 = New System.Windows.Forms.Panel()
            Me.myImageButton8 = New MyImageButton()
            Me.myImageButton7 = New MyImageButton()
            Me.myImageButton6 = New MyImageButton()
            Me.myImageButton5 = New MyImageButton()
            Me.myImageButton4 = New MyImageButton()
            Me.myImageButton3 = New MyImageButton()
            Me.myImageButton2 = New MyImageButton()
            Me.myImageButton1 = New MyImageButton()
            Me.panel1.SuspendLayout()
            Me.panel5.SuspendLayout()
            DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel4.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.panel6.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel1.Controls.Add(Me.panel5)
            Me.panel1.Controls.Add(Me.panel4)
            Me.panel1.Controls.Add(Me.panel3)
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Location = New System.Drawing.Point(16, 81)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(915, 555)
            Me.panel1.TabIndex = 0
            ' 
            ' panel5
            ' 
            Me.panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel5.Controls.Add(Me.dataGridView1)
            Me.panel5.Location = New System.Drawing.Point(219, 68)
            Me.panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(696, 484)
            Me.panel5.TabIndex = 3
            ' 
            ' dataGridView1
            ' 
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, _
                Me.Column7})
            Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.RowTemplate.Height = 21
            Me.dataGridView1.Size = New System.Drawing.Size(696, 484)
            Me.dataGridView1.TabIndex = 10
            ' 
            ' Column1
            ' 
            Me.Column1.HeaderText = "日付"
            Me.Column1.Name = "Column1"
            ' 
            ' Column2
            ' 
            Me.Column2.HeaderText = "番号"
            Me.Column2.Name = "Column2"
            ' 
            ' Column3
            ' 
            Me.Column3.HeaderText = "受取人"
            Me.Column3.Name = "Column3"
            ' 
            ' Column4
            ' 
            Me.Column4.HeaderText = "口座"
            Me.Column4.Name = "Column4"
            ' 
            ' Column5
            ' 
            Me.Column5.HeaderText = "支払い"
            Me.Column5.Name = "Column5"
            ' 
            ' Column6
            ' 
            Me.Column6.HeaderText = "預金"
            Me.Column6.Name = "Column6"
            ' 
            ' Column7
            ' 
            Me.Column7.HeaderText = "残高"
            Me.Column7.Name = "Column7"
            ' 
            ' panel4
            ' 
            Me.panel4.Controls.Add(Me.button4)
            Me.panel4.Controls.Add(Me.textBox1)
            Me.panel4.Controls.Add(Me.comboBox1)
            Me.panel4.Controls.Add(Me.label4)
            Me.panel4.Location = New System.Drawing.Point(219, 4)
            Me.panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(692, 57)
            Me.panel4.TabIndex = 2
            ' 
            ' button4
            ' 
            Me.button4.BackColor = System.Drawing.SystemColors.ControlLight
            Me.button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
            Me.button4.Location = New System.Drawing.Point(503, 11)
            Me.button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(112, 33)
            Me.button4.TabIndex = 21
            Me.button4.Text = "検索"
            Me.button4.UseVisualStyleBackColor = False
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(288, 16)
            Me.textBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(185, 22)
            Me.textBox1.TabIndex = 20
            Me.textBox1.Text = "検索したいキーワード"
            ' 
            ' comboBox1
            ' 
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(101, 15)
            Me.comboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(160, 24)
            Me.comboBox1.TabIndex = 19
            Me.comboBox1.Text = "日付,分類,番号..."
            ' 
            ' label4
            ' 
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Location = New System.Drawing.Point(4, 7)
            Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(89, 37)
            Me.label4.TabIndex = 18
            Me.label4.Text = "並び順："
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ' 
            ' panel3
            ' 
            Me.panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.panel3.Controls.Add(Me.listView2)
            Me.panel3.Controls.Add(Me.label2)
            Me.panel3.Location = New System.Drawing.Point(4, 288)
            Me.panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(207, 263)
            Me.panel3.TabIndex = 1
            ' 
            ' listView2
            ' 
            Me.listView2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {listViewItem1, listViewItem2, listViewItem3, listViewItem4})
            Me.listView2.Location = New System.Drawing.Point(0, 19)
            Me.listView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.listView2.Name = "listView2"
            Me.listView2.Size = New System.Drawing.Size(207, 244)
            Me.listView2.TabIndex = 9
            Me.listView2.UseCompatibleStateImageBehavior = False
            Me.listView2.View = System.Windows.Forms.View.List
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.label2.Font = New System.Drawing.Font("MS PGothic", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128))
            Me.label2.Location = New System.Drawing.Point(0, 0)
            Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(89, 19)
            Me.label2.TabIndex = 8
            Me.label2.Text = "参照情報"
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.listView1)
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Location = New System.Drawing.Point(4, 4)
            Me.panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(207, 277)
            Me.panel2.TabIndex = 0
            ' 
            ' listView1
            ' 
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1})
            Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, _
                listViewItem11})
            Me.listView1.Location = New System.Drawing.Point(0, 19)
            Me.listView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(207, 258)
            Me.listView1.TabIndex = 11
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.List
            ' 
            ' columnHeader1
            ' 
            Me.columnHeader1.Width = 150
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Font = New System.Drawing.Font("MS PGothic", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(128))
            Me.label1.Location = New System.Drawing.Point(0, 0)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(76, 19)
            Me.label1.TabIndex = 10
            Me.label1.Text = "メニュー"
            ' 
            ' panel6
            ' 
            Me.panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel6.Controls.Add(Me.myImageButton8)
            Me.panel6.Controls.Add(Me.myImageButton7)
            Me.panel6.Controls.Add(Me.myImageButton6)
            Me.panel6.Controls.Add(Me.myImageButton5)
            Me.panel6.Controls.Add(Me.myImageButton4)
            Me.panel6.Controls.Add(Me.myImageButton3)
            Me.panel6.Controls.Add(Me.myImageButton2)
            Me.panel6.Controls.Add(Me.myImageButton1)
            Me.panel6.Location = New System.Drawing.Point(16, 0)
            Me.panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel6.Name = "panel6"
            Me.panel6.Size = New System.Drawing.Size(915, 81)
            Me.panel6.TabIndex = 1
            ' 
            ' myImageButton8
            ' 
            Me.myImageButton8.ImageFactor = 1.0F
            Me.myImageButton8.Location = New System.Drawing.Point(572, 5)
            Me.myImageButton8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.myImageButton8.Name = "myImageButton8"
            Me.myImageButton8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.myImageButton8.RenderImage = My.Resources.Find
            Me.myImageButton8.Size = New System.Drawing.Size(73, 69)
            Me.myImageButton8.TabIndex = 10
            Me.myImageButton8.Text = "検索"
            Me.myImageButton8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.myImageButton8.UseVisualStyleBackColor = True
            Me.myImageButton8.Visible = False
            AddHandler Me.myImageButton8.Click, New EventHandler(AddressOf Me.myImageButton_Click)
            ' 
            ' myImageButton7
            ' 
            Me.myImageButton7.ImageFactor = 1.0F
            Me.myImageButton7.Location = New System.Drawing.Point(497, 5)
            Me.myImageButton7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.myImageButton7.Name = "myImageButton7"
            Me.myImageButton7.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.myImageButton7.RenderImage = My.Resources.Accnt
            Me.myImageButton7.Size = New System.Drawing.Size(73, 69)
            Me.myImageButton7.TabIndex = 10
            Me.myImageButton7.Text = "口座"
            Me.myImageButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.myImageButton7.UseVisualStyleBackColor = True
            Me.myImageButton7.Visible = False
            AddHandler Me.myImageButton7.Click, New EventHandler(AddressOf Me.myImageButton_Click)
            ' 
            ' myImageButton6
            ' 
            Me.myImageButton6.ImageFactor = 1.0F
            Me.myImageButton6.Location = New System.Drawing.Point(156, 5)
            Me.myImageButton6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.myImageButton6.Name = "myImageButton6"
            Me.myImageButton6.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.myImageButton6.RenderImage = My.Resources.Reg
            Me.myImageButton6.Size = New System.Drawing.Size(73, 69)
            Me.myImageButton6.TabIndex = 10
            Me.myImageButton6.Text = "登録"
            Me.myImageButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.myImageButton6.UseVisualStyleBackColor = True
            AddHandler Me.myImageButton6.Click, New EventHandler(AddressOf Me.myImageButton_Click)
            ' 
            ' myImageButton5
            ' 
            Me.myImageButton5.ImageFactor = 1.0F
            Me.myImageButton5.Location = New System.Drawing.Point(416, 5)
            Me.myImageButton5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.myImageButton5.Name = "myImageButton5"
            Me.myImageButton5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.myImageButton5.RenderImage = My.Resources.Check
            Me.myImageButton5.Size = New System.Drawing.Size(73, 69)
            Me.myImageButton5.TabIndex = 10
            Me.myImageButton5.Text = "検品"
            Me.myImageButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.myImageButton5.UseVisualStyleBackColor = True
            Me.myImageButton5.Visible = False
            AddHandler Me.myImageButton5.Click, New EventHandler(AddressOf Me.myImageButton_Click)
            ' 
            ' myImageButton4
            ' 
            Me.myImageButton4.ImageFactor = 1.0F
            Me.myImageButton4.Location = New System.Drawing.Point(341, 5)
            Me.myImageButton4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.myImageButton4.Name = "myImageButton4"
            Me.myImageButton4.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.myImageButton4.RenderImage = My.Resources.Vend
            Me.myImageButton4.Size = New System.Drawing.Size(73, 69)
            Me.myImageButton4.TabIndex = 10
            Me.myImageButton4.Text = "販売元"
            Me.myImageButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.myImageButton4.UseVisualStyleBackColor = True
            Me.myImageButton4.Visible = False
            AddHandler Me.myImageButton4.Click, New EventHandler(AddressOf Me.myImageButton_Click)
            ' 
            ' myImageButton3
            ' 
            Me.myImageButton3.ImageFactor = 1.0F
            Me.myImageButton3.Location = New System.Drawing.Point(267, 5)
            Me.myImageButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.myImageButton3.Name = "myImageButton3"
            Me.myImageButton3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.myImageButton3.RenderImage = My.Resources.Cust
            Me.myImageButton3.Size = New System.Drawing.Size(73, 69)
            Me.myImageButton3.TabIndex = 10
            Me.myImageButton3.Text = "顧客"
            Me.myImageButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.myImageButton3.UseVisualStyleBackColor = True
            Me.myImageButton3.Visible = False
            AddHandler Me.myImageButton3.Click, New EventHandler(AddressOf Me.myImageButton_Click)
            ' 
            ' myImageButton2
            ' 
            Me.myImageButton2.ImageFactor = 1.0F
            Me.myImageButton2.Location = New System.Drawing.Point(75, 5)
            Me.myImageButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.myImageButton2.Name = "myImageButton2"
            Me.myImageButton2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.myImageButton2.RenderImage = My.Resources.Bill
            Me.myImageButton2.Size = New System.Drawing.Size(73, 69)
            Me.myImageButton2.TabIndex = 10
            Me.myImageButton2.Text = "請求書"
            Me.myImageButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.myImageButton2.UseVisualStyleBackColor = True
            AddHandler Me.myImageButton2.Click, New EventHandler(AddressOf Me.myImageButton_Click)
            ' 
            ' myImageButton1
            ' 
            Me.myImageButton1.ImageFactor = 1.0F
            Me.myImageButton1.Location = New System.Drawing.Point(0, 5)
            Me.myImageButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.myImageButton1.Name = "myImageButton1"
            Me.myImageButton1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.myImageButton1.RenderImage = My.Resources.Invoice
            Me.myImageButton1.Size = New System.Drawing.Size(73, 69)
            Me.myImageButton1.TabIndex = 10
            Me.myImageButton1.Text = "伝票"
            Me.myImageButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.myImageButton1.UseVisualStyleBackColor = True
            AddHandler Me.myImageButton1.Click, New EventHandler(AddressOf Me.myImageButton_Click)
            ' 
            ' AppZoom_Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 16.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(947, 651)
            Me.Controls.Add(Me.panel6)
            Me.Controls.Add(Me.panel1)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "AppZoom_Main"
            Me.Text = "AppZoom_Main"
            Me.panel1.ResumeLayout(False)
            Me.panel5.ResumeLayout(False)
            DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel6.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private panel1 As System.Windows.Forms.Panel
        Private panel2 As System.Windows.Forms.Panel
        Private panel3 As System.Windows.Forms.Panel
        Private listView1 As System.Windows.Forms.ListView
        Private columnHeader1 As System.Windows.Forms.ColumnHeader
        Private label1 As System.Windows.Forms.Label
        Private listView2 As System.Windows.Forms.ListView
        Private label2 As System.Windows.Forms.Label
        Private panel4 As System.Windows.Forms.Panel
        Private button4 As System.Windows.Forms.Button
        Private textBox1 As System.Windows.Forms.TextBox
        Private comboBox1 As System.Windows.Forms.ComboBox
        Private label4 As System.Windows.Forms.Label
        Private panel5 As System.Windows.Forms.Panel
        Private dataGridView1 As System.Windows.Forms.DataGridView
        Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
        Private panel6 As System.Windows.Forms.Panel
        Private myImageButton1 As MyImageButton
        Private myImageButton8 As MyImageButton
        Private myImageButton7 As MyImageButton
        Private myImageButton6 As MyImageButton
        Private myImageButton5 As MyImageButton
        Private myImageButton4 As MyImageButton
        Private myImageButton3 As MyImageButton
        Private myImageButton2 As MyImageButton
    End Class
End Namespace