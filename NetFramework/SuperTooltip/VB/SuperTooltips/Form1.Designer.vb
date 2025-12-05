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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("New")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Open")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Save")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cut")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Copy")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Paste")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clipboard", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Left")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Right")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bottom")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Align", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28, TreeNode29, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Increase Vertical")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Even Vertical")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Decrease Horizontal")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Even Horizontal")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Spacing", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34, TreeNode35})
        Me.C1SuperTooltip1 = New C1.Win.SuperTooltip.C1SuperTooltip(Me.components)
        Me.button2 = New System.Windows.Forms.Button()
        Me.richTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.maskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.c1SuperLabel2 = New C1.Win.SuperTooltip.C1SuperLabel()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me._groupHtml = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me._groupToolBox = New System.Windows.Forms.GroupBox()
        Me.c1SuperLabel1 = New C1.Win.SuperTooltip.C1SuperLabel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.maskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.redoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.undoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.selectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.customizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.indexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me._groupHtml.SuspendLayout()
        Me._groupToolBox.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1SuperTooltip1.IsBalloon = True
        Me.C1SuperTooltip1.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(15, 20)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(97, 24)
        Me.button2.TabIndex = 0
        Me.button2.Text = "lists"
        Me.C1SuperTooltip1.SetToolTip(Me.button2, resources.GetString("button2.ToolTip"))
        Me.button2.UseVisualStyleBackColor = True
        '
        'richTextBox2
        '
        Me.richTextBox2.Location = New System.Drawing.Point(134, 126)
        Me.richTextBox2.Name = "richTextBox2"
        Me.richTextBox2.Size = New System.Drawing.Size(96, 24)
        Me.richTextBox2.TabIndex = 7
        Me.richTextBox2.Text = "preformatted"
        Me.C1SuperTooltip1.SetToolTip(Me.richTextBox2, resources.GetString("richTextBox2.ToolTip"))
        '
        'checkBox2
        '
        Me.checkBox2.Location = New System.Drawing.Point(15, 54)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(97, 24)
        Me.checkBox2.TabIndex = 2
        Me.checkBox2.Text = "images"
        Me.C1SuperTooltip1.SetToolTip(Me.checkBox2, resources.GetString("checkBox2.ToolTip"))
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'radioButton2
        '
        Me.radioButton2.Location = New System.Drawing.Point(134, 89)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(97, 24)
        Me.radioButton2.TabIndex = 5
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "textColor"
        Me.C1SuperTooltip1.SetToolTip(Me.radioButton2, resources.GetString("radioButton2.ToolTip"))
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'comboBox2
        '
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Location = New System.Drawing.Point(15, 92)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(96, 21)
        Me.comboBox2.TabIndex = 4
        Me.comboBox2.Text = "Borders"
        Me.C1SuperTooltip1.SetToolTip(Me.comboBox2, resources.GetString("comboBox2.ToolTip"))
        '
        'numericUpDown2
        '
        Me.numericUpDown2.Location = New System.Drawing.Point(134, 57)
        Me.numericUpDown2.Name = "numericUpDown2"
        Me.numericUpDown2.Size = New System.Drawing.Size(97, 20)
        Me.numericUpDown2.TabIndex = 3
        Me.C1SuperTooltip1.SetToolTip(Me.numericUpDown2, resources.GetString("numericUpDown2.ToolTip"))
        '
        'dateTimePicker2
        '
        Me.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePicker2.Location = New System.Drawing.Point(15, 130)
        Me.dateTimePicker2.Name = "dateTimePicker2"
        Me.dateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.dateTimePicker2.TabIndex = 6
        Me.C1SuperTooltip1.SetToolTip(Me.dateTimePicker2, resources.GetString("dateTimePicker2.ToolTip"))
        '
        'maskedTextBox2
        '
        Me.maskedTextBox2.Location = New System.Drawing.Point(134, 23)
        Me.maskedTextBox2.Name = "maskedTextBox2"
        Me.maskedTextBox2.Size = New System.Drawing.Size(96, 20)
        Me.maskedTextBox2.TabIndex = 1
        Me.maskedTextBox2.Text = "tables"
        Me.C1SuperTooltip1.SetToolTip(Me.maskedTextBox2, resources.GetString("maskedTextBox2.ToolTip"))
        '
        'c1SuperLabel2
        '
        Me.c1SuperLabel2.Location = New System.Drawing.Point(134, 172)
        Me.c1SuperLabel2.Name = "c1SuperLabel2"
        Me.c1SuperLabel2.Size = New System.Drawing.Size(97, 24)
        Me.c1SuperLabel2.TabIndex = 9
        Me.c1SuperLabel2.Text = "plain text"
        Me.C1SuperTooltip1.SetToolTip(Me.c1SuperLabel2, "You don't have to use Html, plain text works as well.")
        Me.c1SuperLabel2.UseMnemonic = True
        '
        'treeView1
        '
        Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeView1.ImageIndex = 0
        Me.treeView1.ImageList = Me.imageList1
        Me.treeView1.Location = New System.Drawing.Point(0, 0)
        Me.treeView1.Name = "treeView1"
        TreeNode19.ImageIndex = 4
        TreeNode19.Name = "Node0"
        TreeNode19.Text = "New"
        TreeNode20.ImageIndex = 5
        TreeNode20.Name = "Node1"
        TreeNode20.Text = "Open"
        TreeNode21.ImageIndex = 3
        TreeNode21.Name = "Node2"
        TreeNode21.Text = "Save"
        TreeNode22.ImageIndex = 3
        TreeNode22.Name = "Node1"
        TreeNode22.Text = "File"
        TreeNode22.ToolTipText = "bar"
        TreeNode23.ImageIndex = 2
        TreeNode23.Name = "Node3"
        TreeNode23.Text = "Cut"
        TreeNode24.ImageIndex = 1
        TreeNode24.Name = "Node4"
        TreeNode24.Text = "Copy"
        TreeNode25.ImageIndex = 0
        TreeNode25.Name = "Node5"
        TreeNode25.Text = "Paste"
        TreeNode26.ImageIndex = 0
        TreeNode26.Name = "Node0"
        TreeNode26.Text = "Clipboard"
        TreeNode27.ImageIndex = 15
        TreeNode27.Name = "Node6"
        TreeNode27.Text = "Left"
        TreeNode28.ImageIndex = 16
        TreeNode28.Name = "Node7"
        TreeNode28.Text = "Right"
        TreeNode29.ImageIndex = 17
        TreeNode29.Name = "Node8"
        TreeNode29.Text = "Top"
        TreeNode30.ImageIndex = 18
        TreeNode30.Name = "Node19"
        TreeNode30.Text = "Bottom"
        TreeNode31.ImageIndex = 15
        TreeNode31.Name = "Node2"
        TreeNode31.Text = "Align"
        TreeNode32.ImageIndex = 6
        TreeNode32.Name = "Node15"
        TreeNode32.Text = "Increase Vertical"
        TreeNode33.ImageIndex = 10
        TreeNode33.Name = "Node16"
        TreeNode33.Text = "Even Vertical"
        TreeNode34.ImageIndex = 8
        TreeNode34.Name = "Node17"
        TreeNode34.Text = "Decrease Horizontal"
        TreeNode35.ImageIndex = 7
        TreeNode35.Name = "Node18"
        TreeNode35.Text = "Even Horizontal"
        TreeNode36.ImageIndex = 6
        TreeNode36.Name = "Node14"
        TreeNode36.Text = "Spacing"
        Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode26, TreeNode31, TreeNode36})
        Me.treeView1.SelectedImageIndex = 0
        Me.treeView1.ShowNodeToolTips = True
        Me.treeView1.Size = New System.Drawing.Size(159, 217)
        Me.treeView1.TabIndex = 0
        Me.C1SuperTooltip1.SetToolTip(Me.treeView1, "This is a <b>TreeView</b> control. It is not used in this application.")        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Red
        Me.imageList1.Images.SetKeyName(0, "Paste.bmp")
        Me.imageList1.Images.SetKeyName(1, "Copy.bmp")
        Me.imageList1.Images.SetKeyName(2, "Cut.bmp")
        Me.imageList1.Images.SetKeyName(3, "Save.bmp")
        Me.imageList1.Images.SetKeyName(4, "New.bmp")
        Me.imageList1.Images.SetKeyName(5, "Open.bmp")
        Me.imageList1.Images.SetKeyName(6, "DistributeVertIncr.bmp")
        Me.imageList1.Images.SetKeyName(7, "DistributeHorz.bmp")
        Me.imageList1.Images.SetKeyName(8, "DistributeHorzDecr.bmp")
        Me.imageList1.Images.SetKeyName(9, "DistributeHorzIncr.bmp")
        Me.imageList1.Images.SetKeyName(10, "DistributeVert.bmp")
        Me.imageList1.Images.SetKeyName(11, "DistributeVertDecr.bmp")
        Me.imageList1.Images.SetKeyName(12, "AlignVCenter.bmp")
        Me.imageList1.Images.SetKeyName(13, "AlignBottom.bmp")
        Me.imageList1.Images.SetKeyName(14, "AlignCenter.bmp")
        Me.imageList1.Images.SetKeyName(15, "AlignLeft.bmp")
        Me.imageList1.Images.SetKeyName(16, "AlignRight.bmp")
        Me.imageList1.Images.SetKeyName(17, "AlignTop.bmp")
        Me.imageList1.Images.SetKeyName(18, "AlignBottom.bmp")
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.IsSplitterFixed = True
        Me.splitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.treeView1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me._groupHtml)
        Me.splitContainer1.Panel2.Controls.Add(Me._groupToolBox)
        Me.splitContainer1.Size = New System.Drawing.Size(689, 217)
        Me.splitContainer1.SplitterDistance = 159
        Me.splitContainer1.SplitterWidth = 5
        Me.splitContainer1.TabIndex = 7
        '
        '_groupHtml
        '
        Me._groupHtml.Controls.Add(Me.c1SuperLabel2)
        Me._groupHtml.Controls.Add(Me.button2)
        Me._groupHtml.Controls.Add(Me.richTextBox2)
        Me._groupHtml.Controls.Add(Me.checkBox2)
        Me._groupHtml.Controls.Add(Me.radioButton2)
        Me._groupHtml.Controls.Add(Me.comboBox2)
        Me._groupHtml.Controls.Add(Me.numericUpDown2)
        Me._groupHtml.Controls.Add(Me.dateTimePicker2)
        Me._groupHtml.Controls.Add(Me.maskedTextBox2)
        Me._groupHtml.Controls.Add(Me.label2)
        Me._groupHtml.Location = New System.Drawing.Point(261, 3)
        Me._groupHtml.Name = "_groupHtml"
        Me._groupHtml.Size = New System.Drawing.Size(251, 208)
        Me._groupHtml.TabIndex = 1
        Me._groupHtml.TabStop = False
        Me._groupHtml.Text = "Html features"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(15, 168)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(97, 24)
        Me.label2.TabIndex = 8
        Me.label2.Text = "nested divs"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.C1SuperTooltip1.SetToolTip(Me.label2, resources.GetString("label2.ToolTip"))
        '
        '_groupToolBox
        '
        Me._groupToolBox.Controls.Add(Me.c1SuperLabel1)
        Me._groupToolBox.Controls.Add(Me.button1)
        Me._groupToolBox.Controls.Add(Me.richTextBox1)
        Me._groupToolBox.Controls.Add(Me.checkBox1)
        Me._groupToolBox.Controls.Add(Me.radioButton1)
        Me._groupToolBox.Controls.Add(Me.comboBox1)
        Me._groupToolBox.Controls.Add(Me.numericUpDown1)
        Me._groupToolBox.Controls.Add(Me.dateTimePicker1)
        Me._groupToolBox.Controls.Add(Me.maskedTextBox1)
        Me._groupToolBox.Controls.Add(Me.label1)
        Me._groupToolBox.Location = New System.Drawing.Point(3, 3)
        Me._groupToolBox.Name = "_groupToolBox"
        Me._groupToolBox.Size = New System.Drawing.Size(251, 208)
        Me._groupToolBox.TabIndex = 0
        Me._groupToolBox.TabStop = False
        Me._groupToolBox.Text = "Toolbox-style tips"
        '
        'c1SuperLabel1
        '
        Me.c1SuperLabel1.Location = New System.Drawing.Point(134, 172)
        Me.c1SuperLabel1.Name = "c1SuperLabel1"
        Me.c1SuperLabel1.Size = New System.Drawing.Size(97, 24)
        Me.c1SuperLabel1.TabIndex = 9
        Me.c1SuperLabel1.Text = "c1HtmlLabel1"
        Me.c1SuperLabel1.UseMnemonic = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(15, 20)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(97, 24)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(134, 126)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(96, 24)
        Me.richTextBox1.TabIndex = 7
        Me.richTextBox1.Text = ""
        '
        'checkBox1
        '
        Me.checkBox1.Location = New System.Drawing.Point(15, 54)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(97, 24)
        Me.checkBox1.TabIndex = 2
        Me.checkBox1.Text = "checkBox1"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.Location = New System.Drawing.Point(134, 89)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(97, 24)
        Me.radioButton1.TabIndex = 5
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "radioButton1"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(15, 92)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(96, 21)
        Me.comboBox1.TabIndex = 4
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(134, 57)
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(97, 20)
        Me.numericUpDown1.TabIndex = 3
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePicker1.Location = New System.Drawing.Point(15, 130)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.dateTimePicker1.TabIndex = 6
        '
        'maskedTextBox1
        '
        Me.maskedTextBox1.Location = New System.Drawing.Point(134, 23)
        Me.maskedTextBox1.Name = "maskedTextBox1"
        Me.maskedTextBox1.Size = New System.Drawing.Size(96, 20)
        Me.maskedTextBox1.TabIndex = 1
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(15, 168)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(97, 24)
        Me.label1.TabIndex = 8
        Me.label1.Text = "label1"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.helpToolStripButton.Text = "He&lp"
        '
        'cutToolStripButton
        '
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.cutToolStripButton.Text = "C&ut"
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator1, Me.helpToolStripButton})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(689, 25)
        Me.toolStrip1.TabIndex = 5
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripButton1
        '
        Me.toolStripButton1.Checked = True
        Me.toolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton1.Text = "Show tip in a Baloon"
        '
        'newToolStripButton
        '
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.newToolStripButton.Text = "&New"
        '
        'openToolStripButton
        '
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.openToolStripButton.Text = "&Open"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.saveToolStripButton.Text = "&Save"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.printToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.copyToolStripButton.Text = "&Copy"
        '
        'pasteToolStripButton
        '
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.pasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'statusStrip1
        '
        Me.statusStrip1.Location = New System.Drawing.Point(0, 266)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.statusStrip1.Size = New System.Drawing.Size(689, 22)
        Me.statusStrip1.TabIndex = 6
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(143, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'printToolStripMenuItem
        '
        Me.printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
        Me.printToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.printToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.printToolStripMenuItem.Text = "&Print"
        '
        'printPreviewToolStripMenuItem
        '
        Me.printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.printPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'redoToolStripMenuItem
        '
        Me.redoToolStripMenuItem.Name = "redoToolStripMenuItem"
        Me.redoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.redoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.redoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(141, 6)
        '
        'editToolStripMenuItem
        '
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.undoToolStripMenuItem, Me.redoToolStripMenuItem, Me.toolStripSeparator5, Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.toolStripSeparator6, Me.selectAllToolStripMenuItem})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.editToolStripMenuItem.Text = "&Edit"
        '
        'undoToolStripMenuItem
        '
        Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
        Me.undoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.undoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.undoToolStripMenuItem.Text = "&Undo"
        '
        'cutToolStripMenuItem
        '
        Me.cutToolStripMenuItem.Image = CType(resources.GetObject("cutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
        Me.cutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.cutToolStripMenuItem.Text = "Cu&t"
        '
        'copyToolStripMenuItem
        '
        Me.copyToolStripMenuItem.Image = CType(resources.GetObject("copyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        Me.copyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.copyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.copyToolStripMenuItem.Text = "&Copy"
        '
        'pasteToolStripMenuItem
        '
        Me.pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
        Me.pasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.pasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(141, 6)
        '
        'selectAllToolStripMenuItem
        '
        Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
        Me.selectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.selectAllToolStripMenuItem.Text = "Select &All"
        '
        'newToolStripMenuItem
        '
        Me.newToolStripMenuItem.Image = CType(resources.GetObject("newToolStripMenuItem.Image"), System.Drawing.Image)
        Me.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.newToolStripMenuItem.Text = "&New"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Image = CType(resources.GetObject("openToolStripMenuItem.Image"), System.Drawing.Image)
        Me.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.openToolStripMenuItem.Text = "&Open"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.toolsToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.menuStrip1.Size = New System.Drawing.Size(689, 24)
        Me.menuStrip1.TabIndex = 4
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator2, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator3, Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.toolStripSeparator4, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'saveToolStripMenuItem
        '
        Me.saveToolStripMenuItem.Image = CType(resources.GetObject("saveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.saveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.saveToolStripMenuItem.Text = "&Save"
        '
        'saveAsToolStripMenuItem
        '
        Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
        Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.saveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(143, 6)
        '
        'toolsToolStripMenuItem
        '
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.customizeToolStripMenuItem, Me.optionsToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        '
        'customizeToolStripMenuItem
        '
        Me.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem"
        Me.customizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.customizeToolStripMenuItem.Text = "&Customize"
        '
        'optionsToolStripMenuItem
        '
        Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
        Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.optionsToolStripMenuItem.Text = "&Options"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contentsToolStripMenuItem, Me.indexToolStripMenuItem, Me.searchToolStripMenuItem, Me.toolStripSeparator7, Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.helpToolStripMenuItem.Text = "&Help"
        '
        'contentsToolStripMenuItem
        '
        Me.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem"
        Me.contentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.contentsToolStripMenuItem.Text = "&Contents"
        '
        'indexToolStripMenuItem
        '
        Me.indexToolStripMenuItem.Name = "indexToolStripMenuItem"
        Me.indexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.indexToolStripMenuItem.Text = "&Index"
        '
        'searchToolStripMenuItem
        '
        Me.searchToolStripMenuItem.Name = "searchToolStripMenuItem"
        Me.searchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.searchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(119, 6)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.aboutToolStripMenuItem.Text = "&About..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 288)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1SuperTooltips"
        CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me._groupHtml.ResumeLayout(False)
        Me._groupHtml.PerformLayout()
        Me._groupToolBox.ResumeLayout(False)
        Me._groupToolBox.PerformLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1SuperTooltip1 As C1.Win.SuperTooltip.C1SuperTooltip
    Private WithEvents c1SuperLabel2 As C1.Win.SuperTooltip.C1SuperLabel
    Private WithEvents treeView1 As System.Windows.Forms.TreeView
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents _groupHtml As System.Windows.Forms.GroupBox
    Private WithEvents richTextBox2 As System.Windows.Forms.RichTextBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
    Private WithEvents numericUpDown2 As System.Windows.Forms.NumericUpDown
    Private WithEvents dateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private WithEvents maskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents _groupToolBox As System.Windows.Forms.GroupBox
    Private WithEvents c1SuperLabel1 As C1.Win.SuperTooltip.C1SuperLabel
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents dateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private WithEvents maskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
    Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents printPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents redoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents undoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents selectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents saveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents customizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents contentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents indexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents searchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
