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
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.c1Chart2 = New C1.Win.C1Chart.C1Chart
        Me.label4 = New System.Windows.Forms.Label
        Me.c1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.tabPage3 = New System.Windows.Forms.TabPage
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.c1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.panel1 = New System.Windows.Forms.Panel
        Me.listBox1 = New System.Windows.Forms.ListBox
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me.label5 = New System.Windows.Forms.Label
        Me.tabPage2 = New System.Windows.Forms.TabPage
        Me.c1Chart1 = New C1.Win.C1Chart.C1Chart
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        CType(Me.c1Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage3.SuspendLayout()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
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
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.copyToolStripButton.Text = "&Copy"
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
        'c1Chart2
        '
        Me.c1Chart2.BackColor = System.Drawing.Color.Transparent
        Me.c1Chart2.DataSource = Nothing
        Me.c1Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Chart2.Location = New System.Drawing.Point(0, 92)
        Me.c1Chart2.Name = "c1Chart2"
        Me.c1Chart2.PropBag = resources.GetString("c1Chart2.PropBag")
        Me.c1Chart2.Size = New System.Drawing.Size(611, 301)
        Me.c1Chart2.TabIndex = 0
        '
        'label4
        '
        Me.label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(0, 0)
        Me.label4.Name = "label4"
        Me.label4.Padding = New System.Windows.Forms.Padding(5)
        Me.label4.Size = New System.Drawing.Size(611, 92)
        Me.label4.TabIndex = 2
        Me.label4.Text = resources.GetString("label4.Text")
        '
        'c1SuperTooltip1
        '
        Me.c1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.c1SuperTooltip1.Images.Add(New C1.Win.C1SuperTooltip.ImageEntry("tabPage", CType(resources.GetObject("c1SuperTooltip1.Images"), System.Drawing.Image)))
        Me.c1SuperTooltip1.IsBalloon = True
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.c1Chart2)
        Me.tabPage3.Controls.Add(Me.label4)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(611, 393)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "C1Chart (3D line)"
        Me.tabPage3.UseVisualStyleBackColor = True
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
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.helpToolStripButton.Text = "He&lp"
        '
        'txtWidth
        '
        Me.txtWidth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWidth.Location = New System.Drawing.Point(89, 42)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(105, 20)
        Me.txtWidth.TabIndex = 7
        '
        'c1FlexGrid1
        '
        Me.c1FlexGrid1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.c1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,90,Columns:0{Width:28;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid1.Location = New System.Drawing.Point(3, 95)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.Rows.DefaultSize = 18
        Me.c1FlexGrid1.Size = New System.Drawing.Size(395, 295)
        Me.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo")
        Me.c1FlexGrid1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.txtWidth)
        Me.panel1.Controls.Add(Me.listBox1)
        Me.panel1.Controls.Add(Me.txtHeight)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel1.Location = New System.Drawing.Point(398, 95)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(210, 295)
        Me.panel1.TabIndex = 3
        '
        'listBox1
        '
        Me.listBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(15, 68)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(179, 199)
        Me.listBox1.TabIndex = 2
        Me.listBox1.Visible = False
        '
        'txtHeight
        '
        Me.txtHeight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHeight.Location = New System.Drawing.Point(89, 14)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(105, 20)
        Me.txtHeight.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Width"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 14)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(38, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Height"
        '
        'label3
        '
        Me.label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(3, 3)
        Me.label3.Name = "label3"
        Me.label3.Padding = New System.Windows.Forms.Padding(5)
        Me.label3.Size = New System.Drawing.Size(605, 92)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Below is a C1Chart control; it is showing a line" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "chart, but there are many other" & _
            " chart types " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "available, including bar, pie, scatter, and many" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "others." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.HotTrack = True
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(619, 419)
        Me.tabControl1.TabIndex = 1
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.c1FlexGrid1)
        Me.tabPage1.Controls.Add(Me.panel1)
        Me.tabPage1.Controls.Add(Me.label5)
        Me.tabPage1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Margin = New System.Windows.Forms.Padding(10)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(611, 393)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "C1FlexGrid"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(3, 3)
        Me.label5.Name = "label5"
        Me.label5.Padding = New System.Windows.Forms.Padding(5)
        Me.label5.Size = New System.Drawing.Size(605, 92)
        Me.label5.TabIndex = 2
        Me.label5.Text = "Below is a C1FlexGrid control; it is showing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "some data from the NorthWind databa" & _
            "se." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It can also show trees, rich styles, and completely" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "customized cell render" & _
            "ing." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.c1Chart1)
        Me.tabPage2.Controls.Add(Me.label3)
        Me.tabPage2.Controls.Add(Me.toolStrip1)
        Me.tabPage2.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(611, 393)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "C1Chart (line)"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'c1Chart1
        '
        Me.c1Chart1.BackColor = System.Drawing.Color.Transparent
        Me.c1Chart1.DataSource = Nothing
        Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Chart1.Location = New System.Drawing.Point(3, 95)
        Me.c1Chart1.Name = "c1Chart1"
        Me.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag")
        Me.c1Chart1.Size = New System.Drawing.Size(605, 295)
        Me.c1Chart1.TabIndex = 0
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator1, Me.helpToolStripButton})
        Me.toolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(605, 25)
        Me.toolStrip1.TabIndex = 2
        Me.toolStrip1.Text = "toolStrip1"
        Me.toolStrip1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 419)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1SuperTooltip: tips with dynamic thumbnails"
        CType(Me.c1Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage3.ResumeLayout(False)
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents c1Chart2 As C1.Win.C1Chart.C1Chart
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents c1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Private WithEvents tabPage3 As System.Windows.Forms.TabPage
    Private WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents txtWidth As System.Windows.Forms.TextBox
    Private WithEvents c1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents listBox1 As System.Windows.Forms.ListBox
    Private WithEvents txtHeight As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip

End Class
