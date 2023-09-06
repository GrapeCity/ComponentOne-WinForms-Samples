Partial Class MainForm
    ''' <summary>
    ''' 必要なデザイナ変数です。
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' 使用中のリソースをすべてクリーンアップします。
    ''' </summary>
    ''' <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows フォーム デザイナで生成されたコード"

    ''' <summary>
    ''' デザイナ サポートに必要なメソッドです。このメソッドの内容を
    ''' コード エディタで変更しないでください。
    ''' </summary>
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Basic (Zoom and Scroll)")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ControlBar")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Show Control")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pan Window")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Zoom Policy")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Misc")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C1Zoom", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Basic (Zoom and Scroll)")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C1ZoomPanel", New System.Windows.Forms.TreeNode() {TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Multiple window Business app example with the Component")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C1ApplicationZoom", New System.Windows.Forms.TreeNode() {TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C1Magnify")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Compare PictureBox and C1MultiScaleImage")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C1MultiScaleImage", New System.Windows.Forms.TreeNode() {TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Touch Events Listener")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ContextualUI")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AutoRepeat")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ImageViewer")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drawing Board for Pen")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C1TouchEventProvider", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17, TreeNode18, TreeNode19})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.cube = New System.Windows.Forms.PictureBox()
        Me.firstView = New System.Windows.Forms.LinkLabel()
        Me.product_title = New System.Windows.Forms.Label()
        Me.product_logo = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.splitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.myTabControl1 = New TouchToolKitDemoVB.MyTabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.treemenu = New TouchToolKitDemoVB.MyTreeView()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.label1 = New System.Windows.Forms.Label()
        Me.searchlist = New System.Windows.Forms.ListBox()
        Me.searchtext = New System.Windows.Forms.TextBox()
        Me.menuheader = New System.Windows.Forms.PictureBox()
        Me.product_info = New System.Windows.Forms.LinkLabel()
        Me.copyright = New System.Windows.Forms.Label()
        Me.mescius_logo = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        CType(Me.cube, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.product_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer3.Panel1.SuspendLayout()
        Me.splitContainer3.Panel2.SuspendLayout()
        Me.splitContainer3.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.myTabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        CType(Me.menuheader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mescius_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainer2
        '
        Me.splitContainer2.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer2.IsSplitterFixed = True
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.BackgroundImage = Global.TouchToolKitDemoVB.My.Resources.Resources.header_b
        Me.splitContainer2.Panel1.Controls.Add(Me.cube)
        Me.splitContainer2.Panel1.Controls.Add(Me.firstView)
        Me.splitContainer2.Panel1.Controls.Add(Me.product_title)
        Me.splitContainer2.Panel1.Controls.Add(Me.product_logo)
        Me.splitContainer2.Panel1.Controls.Add(Me.pictureBox1)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.splitContainer3)
        Me.splitContainer2.Size = New System.Drawing.Size(1008, 690)
        Me.splitContainer2.SplitterDistance = 80
        Me.splitContainer2.SplitterWidth = 6
        Me.splitContainer2.TabIndex = 0
        '
        'cube
        '
        Me.cube.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cube.BackgroundImage = Global.TouchToolKitDemoVB.My.Resources.Resources.cube
        Me.cube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cube.Location = New System.Drawing.Point(12, 4)
        Me.cube.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cube.Name = "cube"
        Me.cube.Size = New System.Drawing.Size(72, 74)
        Me.cube.TabIndex = 8
        Me.cube.TabStop = False
        '
        'firstView
        '
        Me.firstView.ActiveLinkColor = System.Drawing.Color.White
        Me.firstView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.firstView.AutoSize = True
        Me.firstView.DisabledLinkColor = System.Drawing.Color.White
        Me.firstView.Font = New System.Drawing.Font("Meiryo", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.firstView.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.firstView.LinkColor = System.Drawing.Color.White
        Me.firstView.Location = New System.Drawing.Point(659, 48)
        Me.firstView.Name = "firstView"
        Me.firstView.Size = New System.Drawing.Size(71, 20)
        Me.firstView.TabIndex = 1
        Me.firstView.TabStop = True
        Me.firstView.Text = "Introduce"
        Me.firstView.VisitedLinkColor = System.Drawing.Color.White
        '
        'product_title
        '
        Me.product_title.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.product_title.AutoSize = True
        Me.product_title.Font = New System.Drawing.Font("Meiryo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product_title.ForeColor = System.Drawing.Color.White
        Me.product_title.Location = New System.Drawing.Point(277, 45)
        Me.product_title.Name = "product_title"
        Me.product_title.Size = New System.Drawing.Size(174, 24)
        Me.product_title.TabIndex = 0
        Me.product_title.Text = "for Windows Forms"
        '
        'product_logo
        '
        Me.product_logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.product_logo.BackgroundImage = Global.TouchToolKitDemoVB.My.Resources.Resources.product_logo
        Me.product_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.product_logo.Location = New System.Drawing.Point(90, 20)
        Me.product_logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.product_logo.Name = "product_logo"
        Me.product_logo.Size = New System.Drawing.Size(181, 49)
        Me.product_logo.TabIndex = 1
        Me.product_logo.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = Global.TouchToolKitDemoVB.My.Resources.Resources.header_g
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(1008, 80)
        Me.pictureBox1.TabIndex = 9
        Me.pictureBox1.TabStop = False
        '
        'splitContainer3
        '
        Me.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer3.IsSplitterFixed = True
        Me.splitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer3.Name = "splitContainer3"
        Me.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer3.Panel1
        '
        Me.splitContainer3.Panel1.Controls.Add(Me.splitContainer1)
        Me.splitContainer3.Panel1.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        '
        'splitContainer3.Panel2
        '
        Me.splitContainer3.Panel2.BackgroundImage = Global.TouchToolKitDemoVB.My.Resources.Resources.fotter
        Me.splitContainer3.Panel2.Controls.Add(Me.product_info)
        Me.splitContainer3.Panel2.Controls.Add(Me.copyright)
        Me.splitContainer3.Panel2.Controls.Add(Me.mescius_logo)
        Me.splitContainer3.Panel2.Controls.Add(Me.pictureBox2)
        Me.splitContainer3.Size = New System.Drawing.Size(1008, 604)
        Me.splitContainer3.SplitterDistance = 519
        Me.splitContainer3.SplitterWidth = 6
        Me.splitContainer3.TabIndex = 0
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(7, 0)
        Me.splitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.splitContainer1.Panel1.Controls.Add(Me.panel1)
        Me.splitContainer1.Panel1.Controls.Add(Me.menuheader)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.splitContainer1.Size = New System.Drawing.Size(1001, 519)
        Me.splitContainer1.SplitterDistance = 253
        Me.splitContainer1.SplitterWidth = 1
        Me.splitContainer1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.panel1.Controls.Add(Me.myTabControl1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 38)
        Me.panel1.Name = "panel1"
        Me.panel1.Padding = New System.Windows.Forms.Padding(7, 7, 7, 5)
        Me.panel1.Size = New System.Drawing.Size(253, 481)
        Me.panel1.TabIndex = 0
        '
        'myTabControl1
        '
        Me.myTabControl1.Controls.Add(Me.tabPage1)
        Me.myTabControl1.Controls.Add(Me.tabPage2)
        Me.myTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myTabControl1.Location = New System.Drawing.Point(7, 7)
        Me.myTabControl1.Name = "myTabControl1"
        Me.myTabControl1.SelectedIndex = 0
        Me.myTabControl1.Size = New System.Drawing.Size(239, 469)
        Me.myTabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.treemenu)
        Me.tabPage1.Location = New System.Drawing.Point(4, 27)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(231, 438)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Features"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'treemenu
        '
        Me.treemenu.BackColor = System.Drawing.Color.White
        Me.treemenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treemenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treemenu.Font = New System.Drawing.Font("Meiryo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.treemenu.ForeColor = System.Drawing.Color.Black
        Me.treemenu.HideSelection = False
        Me.treemenu.Indent = 15
        Me.treemenu.ItemHeight = 25
        Me.treemenu.Location = New System.Drawing.Point(3, 3)
        Me.treemenu.Name = "treemenu"
        TreeNode1.Name = "Node4"
        TreeNode1.Tag = "C1Zoom"
        TreeNode1.Text = "Basic (Zoom and Scroll)"
        TreeNode2.Name = "Node7"
        TreeNode2.Text = "ControlBar"
        TreeNode3.Name = "Node8"
        TreeNode3.Text = "Show Control"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "Pan Window"
        TreeNode5.Name = "Node2"
        TreeNode5.Text = "Zoom Policy"
        TreeNode6.Name = "Node0"
        TreeNode6.Text = "Misc"
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "C1Zoom"
        TreeNode8.Name = "Node3"
        TreeNode8.Tag = "C1ZoomPanel"
        TreeNode8.Text = "Basic (Zoom and Scroll)"
        TreeNode9.Name = "Node1"
        TreeNode9.Text = "C1ZoomPanel"
        TreeNode10.Name = "Node4"
        TreeNode10.Text = "Multiple window Business app example with the Component"
        TreeNode11.Name = "Node2"
        TreeNode11.Text = "C1ApplicationZoom"
        TreeNode12.Name = "Node1"
        TreeNode12.Text = "C1Magnify"
        TreeNode13.Name = "Node0"
        TreeNode13.Text = "Compare PictureBox and C1MultiScaleImage"
        TreeNode14.Name = "Node2"
        TreeNode14.Text = "C1MultiScaleImage"
        TreeNode15.Name = "Node9"
        TreeNode15.Text = "Touch Events Listener"
        TreeNode16.Name = "Node10"
        TreeNode16.Text = "ContextualUI"
        TreeNode17.Name = "Node12"
        TreeNode17.Text = "AutoRepeat"
        TreeNode18.Name = "Node11"
        TreeNode18.Text = "ImageViewer"
        TreeNode19.Name = "Node2"
        TreeNode19.Text = "Drawing Board for Pen"
        TreeNode20.Name = "Node3"
        TreeNode20.Text = "C1TouchEventProvider"
        Me.treemenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode9, TreeNode11, TreeNode12, TreeNode14, TreeNode20})
        Me.treemenu.Size = New System.Drawing.Size(225, 432)
        Me.treemenu.TabIndex = 1
        '
        'tabPage2
        '
        Me.tabPage2.BackColor = System.Drawing.Color.White
        Me.tabPage2.Controls.Add(Me.label1)
        Me.tabPage2.Controls.Add(Me.searchlist)
        Me.tabPage2.Controls.Add(Me.searchtext)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(231, 443)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Indexes"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 18)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Search:"
        '
        'searchlist
        '
        Me.searchlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchlist.BackColor = System.Drawing.Color.White
        Me.searchlist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchlist.ForeColor = System.Drawing.Color.Black
        Me.searchlist.FormattingEnabled = True
        Me.searchlist.ItemHeight = 18
        Me.searchlist.Location = New System.Drawing.Point(9, 38)
        Me.searchlist.Name = "searchlist"
        Me.searchlist.Size = New System.Drawing.Size(216, 252)
        Me.searchlist.TabIndex = 5
        '
        'searchtext
        '
        Me.searchtext.Location = New System.Drawing.Point(79, 7)
        Me.searchtext.Name = "searchtext"
        Me.searchtext.Size = New System.Drawing.Size(146, 25)
        Me.searchtext.TabIndex = 4
        '
        'menuheader
        '
        Me.menuheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.menuheader.Image = Global.TouchToolKitDemoVB.My.Resources.Resources.menuheader
        Me.menuheader.Location = New System.Drawing.Point(0, 0)
        Me.menuheader.Name = "menuheader"
        Me.menuheader.Size = New System.Drawing.Size(253, 38)
        Me.menuheader.TabIndex = 1
        Me.menuheader.TabStop = False
        '
        'product_info
        '
        Me.product_info.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.product_info.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.product_info.Dock = System.Windows.Forms.DockStyle.Right
        Me.product_info.Font = New System.Drawing.Font("Meiryo", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product_info.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.product_info.LinkColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.product_info.Location = New System.Drawing.Point(903, 0)
        Me.product_info.Name = "product_info"
        Me.product_info.Size = New System.Drawing.Size(105, 79)
        Me.product_info.TabIndex = 1
        Me.product_info.TabStop = True
        Me.product_info.Text = "Product Info."
        Me.product_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.product_info.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        '
        'copyright
        '
        Me.copyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.copyright.AutoSize = True
        Me.copyright.Font = New System.Drawing.Font("Meiryo", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.copyright.Location = New System.Drawing.Point(173, -94)
        Me.copyright.Name = "copyright"
        Me.copyright.Size = New System.Drawing.Size(213, 17)
        Me.copyright.TabIndex = 0
        Me.copyright.Text = "© Mescius, Inc. All rights reserved."
        '
        'mescius_logo
        '
        Me.mescius_logo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mescius_logo.BackgroundImage = Global.TouchToolKitDemoVB.My.Resources.Resources.mescius_logo
        Me.mescius_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mescius_logo.Location = New System.Drawing.Point(12, -102)
        Me.mescius_logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mescius_logo.Name = "mescius_logo"
        Me.mescius_logo.Size = New System.Drawing.Size(155, 29)
        Me.mescius_logo.TabIndex = 6
        Me.mescius_logo.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(1008, 79)
        Me.pictureBox2.TabIndex = 9
        Me.pictureBox2.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1008, 690)
        Me.Controls.Add(Me.splitContainer2)
        Me.Font = New System.Drawing.Font("Meiryo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1024, 729)
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MultiTouch for Windows Forms 1.0J Demonstration"
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel1.PerformLayout()
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        CType(Me.cube, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.product_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer3.Panel1.ResumeLayout(False)
        Me.splitContainer3.Panel2.ResumeLayout(False)
        Me.splitContainer3.Panel2.PerformLayout()
        CType(Me.splitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer3.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.myTabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        CType(Me.menuheader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mescius_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents splitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents splitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents product_logo As System.Windows.Forms.PictureBox
    Friend WithEvents product_title As System.Windows.Forms.Label
    Friend WithEvents firstView As System.Windows.Forms.LinkLabel
    Friend WithEvents cube As System.Windows.Forms.PictureBox
    Friend WithEvents copyright As System.Windows.Forms.Label
    Friend WithEvents mescius_logo As System.Windows.Forms.PictureBox
    Friend WithEvents product_info As System.Windows.Forms.LinkLabel
    Friend WithEvents menuheader As System.Windows.Forms.PictureBox
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents myTabControl1 As MyTabControl
    Friend WithEvents tabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents treemenu As MyTreeView
    Friend WithEvents tabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents searchlist As System.Windows.Forms.ListBox
    Friend WithEvents searchtext As System.Windows.Forms.TextBox
End Class