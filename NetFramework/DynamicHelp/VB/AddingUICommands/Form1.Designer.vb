Imports Microsoft.VisualBasic
Imports System
Namespace AddingUICommands
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim mapItem1 As New C1.Win.C1DynamicHelp.MapItem()
            Dim mapItem2 As New C1.Win.C1DynamicHelp.MapItem()
            Dim mapItem3 As New C1.Win.C1DynamicHelp.MapItem()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim mapItem4 As New C1.Win.C1DynamicHelp.MapItem()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.c1DynamicHelp1 = New C1.Win.C1DynamicHelp.C1DynamicHelp()
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
            Me.btnBack = New System.Windows.Forms.ToolStripButton()
            Me.btnForward = New System.Windows.Forms.ToolStripButton()
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnContents = New System.Windows.Forms.ToolStripButton()
            Me.btnIndex = New System.Windows.Forms.ToolStripButton()
            Me.btnSearch = New System.Windows.Forms.ToolStripButton()
            Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnPin = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.toolStrip1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' checkBox1
            ' 
            Me.checkBox1.AutoSize = True
            mapItem1.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.MouseEnter
            mapItem1.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static
            mapItem1.ShowDefaultTopicFirst = True
            mapItem1.UIElement = Me.checkBox1
            mapItem1.Url = "WordDocuments/designtimesupport.htm"
            mapItem1.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me.checkBox1, mapItem1)
            Me.checkBox1.Location = New System.Drawing.Point(72, 273)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(80, 17)
            Me.checkBox1.TabIndex = 7
            Me.checkBox1.Text = "checkBox1"
            Me.checkBox1.UseVisualStyleBackColor = True
            ' 
            ' textBox1
            ' 
            mapItem2.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.Enter
            mapItem2.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static
            mapItem2.ShowDefaultTopicFirst = True
            mapItem2.UIElement = Me.textBox1
            mapItem2.Url = "WordDocuments/howtousec1dynamichelp.htm"
            mapItem2.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me.textBox1, mapItem2)
            Me.textBox1.Location = New System.Drawing.Point(72, 246)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(211, 20)
            Me.textBox1.TabIndex = 5
            Me.textBox1.Text = "textBox1"
            ' 
            ' button1
            ' 
            mapItem3.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.MouseEnter
            mapItem3.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static
            mapItem3.ShowDefaultTopicFirst = True
            mapItem3.UIElement = Me.button1
            mapItem3.Url = "WordDocuments/runtimesupport.htm"
            mapItem3.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me.button1, mapItem3)
            Me.button1.Location = New System.Drawing.Point(208, 269)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 4
            Me.button1.Text = "button1"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' splitContainer1
            ' 
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer1.Name = "splitContainer1"
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.checkBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label4)
            Me.splitContainer1.Panel1.Controls.Add(Me.textBox1)
            Me.splitContainer1.Panel1.Controls.Add(Me.button1)
            Me.splitContainer1.Panel1.Controls.Add(Me.label3)
            Me.splitContainer1.Panel1.Controls.Add(Me.label2)
            Me.splitContainer1.Panel1.Controls.Add(Me.label1)
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.c1DynamicHelp1)
            Me.splitContainer1.Panel2.Controls.Add(Me.toolStrip1)
            Me.splitContainer1.Size = New System.Drawing.Size(850, 372)
            Me.splitContainer1.SplitterDistance = 378
            Me.splitContainer1.TabIndex = 0
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(12, 202)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(347, 13)
            Me.label4.TabIndex = 6
            Me.label4.Text = "Sample controls showing help topics when the mouse hovers over them:"
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(12, 103)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(254, 74)
            Me.label3.TabIndex = 3
            Me.label3.Text = "3. Use the Pin button to pin down the currently displayed topic. If the Pin butto" & "n is pressed, current topic won't change regardless of mouse movement and focus " & "changes."
            ' 
            ' label2
            ' 
            Me.label2.Location = New System.Drawing.Point(12, 56)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(271, 47)
            Me.label2.TabIndex = 2
            Me.label2.Text = "2. Use the Contents/Index/Search buttons to open help in an external window on a " & "specific tab."
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(12, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(287, 47)
            Me.label1.TabIndex = 1
            Me.label1.Text = "1. Use the Back/Forward buttons to navigate to the previous/next help topic in th" & "e navigation history."
            ' 
            ' c1DynamicHelp1
            ' 
            Me.c1DynamicHelp1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DynamicHelp1.HelpSource = "C1Sample.chm"
            Me.c1DynamicHelp1.Location = New System.Drawing.Point(0, 25)
            Me.c1DynamicHelp1.Name = "c1DynamicHelp1"
            Me.c1DynamicHelp1.Size = New System.Drawing.Size(468, 347)
            Me.c1DynamicHelp1.TabIndex = 0
            ' 
            ' toolStrip1
            ' 
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.btnBack, Me.btnForward, Me.toolStripSeparator3, Me.btnContents, Me.btnIndex, Me.btnSearch, Me.toolStripSeparator4, Me.btnPin})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(468, 25)
            Me.toolStrip1.TabIndex = 1
            Me.toolStrip1.Text = "toolStrip1"
            ' 
            ' btnBack
            ' 
            Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnBack.Enabled = False
            Me.btnBack.Image = My.Resources.prev
            Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New System.Drawing.Size(23, 22)
            Me.btnBack.Text = "Back"
            ' 
            ' btnForward
            ' 
            Me.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnForward.Enabled = False
            Me.btnForward.Image = My.Resources.forward
            Me.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnForward.Name = "btnForward"
            Me.btnForward.Size = New System.Drawing.Size(23, 22)
            Me.btnForward.Text = "Forward"
            ' 
            ' toolStripSeparator3
            ' 
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
            ' 
            ' btnContents
            ' 
            Me.btnContents.Image = My.Resources.contents
            Me.btnContents.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnContents.Name = "btnContents"
            Me.btnContents.Size = New System.Drawing.Size(71, 22)
            Me.btnContents.Text = "Contents"
            ' 
            ' btnIndex
            ' 
            Me.btnIndex.Image = My.Resources.index
            Me.btnIndex.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnIndex.Name = "btnIndex"
            Me.btnIndex.Size = New System.Drawing.Size(55, 22)
            Me.btnIndex.Text = "Index"
            ' 
            ' btnSearch
            ' 
            Me.btnSearch.Image = My.Resources.search
            Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(60, 22)
            Me.btnSearch.Text = "Search"
            ' 
            ' toolStripSeparator4
            ' 
            Me.toolStripSeparator4.Name = "toolStripSeparator4"
            Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
            ' 
            ' btnPin
            ' 
            Me.btnPin.CheckOnClick = True
            Me.btnPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.btnPin.Image = My.Resources.unpinned
            Me.btnPin.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnPin.Name = "btnPin"
            Me.btnPin.Size = New System.Drawing.Size(23, 22)
            Me.btnPin.Text = "Fix topic"
            ' 
            ' toolStripButton1
            ' 
            Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton1.Image = My.Resources.unpinned
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Size = New System.Drawing.Size(23, 22)
            Me.toolStripButton1.Text = "toolStripButton1"
            ' 
            ' toolStripButton2
            ' 
            Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
            Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton2.Name = "toolStripButton2"
            Me.toolStripButton2.Size = New System.Drawing.Size(23, 22)
            Me.toolStripButton2.Text = "toolStripButton2"
            ' 
            ' toolStripSeparator1
            ' 
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            ' 
            ' toolStripButton3
            ' 
            Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(23, 22)
            Me.toolStripButton3.Text = "toolStripButton3"
            ' 
            ' toolStripButton4
            ' 
            Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Size = New System.Drawing.Size(23, 22)
            Me.toolStripButton4.Text = "toolStripButton4"
            ' 
            ' toolStripButton5
            ' 
            Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image))
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(23, 22)
            Me.toolStripButton5.Text = "toolStripButton5"
            ' 
            ' toolStripSeparator2
            ' 
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
            ' 
            ' toolStripButton6
            ' 
            Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton6.Image = My.Resources.unpinned
            Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton6.Name = "toolStripButton6"
            Me.toolStripButton6.Size = New System.Drawing.Size(23, 22)
            Me.toolStripButton6.Text = "toolStripButton6"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(850, 372)
            Me.Controls.Add(Me.splitContainer1)
            mapItem4.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None
            mapItem4.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static
            mapItem4.ShowDefaultTopicFirst = True
            mapItem4.UIElement = Me
            mapItem4.Url = "WordDocuments/overview.htm"
            mapItem4.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me, mapItem4)
            Me.Name = "Form1"
            Me.Text = "Adding a toolbar to C1DynamicHelp"
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel1.PerformLayout()
            Me.splitContainer1.Panel2.ResumeLayout(False)
            Me.splitContainer1.Panel2.PerformLayout()
            Me.splitContainer1.ResumeLayout(False)
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private c1DynamicHelp1 As C1.Win.C1DynamicHelp.C1DynamicHelp
        Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
        Private toolStripButton1 As System.Windows.Forms.ToolStripButton
        Private toolStripButton2 As System.Windows.Forms.ToolStripButton
        Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Private toolStripButton3 As System.Windows.Forms.ToolStripButton
        Private toolStripButton4 As System.Windows.Forms.ToolStripButton
        Private toolStripButton5 As System.Windows.Forms.ToolStripButton
        Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Private toolStripButton6 As System.Windows.Forms.ToolStripButton
        Private btnBack As System.Windows.Forms.ToolStripButton
        Private btnForward As System.Windows.Forms.ToolStripButton
        Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Private btnContents As System.Windows.Forms.ToolStripButton
        Private btnIndex As System.Windows.Forms.ToolStripButton
        Private btnSearch As System.Windows.Forms.ToolStripButton
        Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents btnPin As System.Windows.Forms.ToolStripButton
        Private label1 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private checkBox1 As System.Windows.Forms.CheckBox
        Private label4 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private button1 As System.Windows.Forms.Button
    End Class
End Namespace

