Imports Microsoft.VisualBasic
Imports System
Namespace UsingUIElementResolver
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
            Dim mapItem4 As New C1.Win.C1DynamicHelp.MapItem()
            Me.ribbonButton1 = New C1.Win.C1Ribbon.RibbonButton()
            Me.ribbonButton9 = New C1.Win.C1Ribbon.RibbonButton()
            Me.ribbonCheckBox1 = New C1.Win.C1Ribbon.RibbonCheckBox()
            Me.c1DynamicHelp1 = New C1.Win.C1DynamicHelp.C1DynamicHelp()
            Me.c1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
            Me.ribbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
            Me.ribbonButton6 = New C1.Win.C1Ribbon.RibbonButton()
            Me.ribbonButton7 = New C1.Win.C1Ribbon.RibbonButton()
            Me.ribbonButton8 = New C1.Win.C1Ribbon.RibbonButton()
            Me.ribbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
            Me.ribbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
            Me.ribbonTab1 = New C1.Win.C1Ribbon.RibbonTab()
            Me.ribbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
            CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonButton1
            ' 
            mapItem1.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None
            mapItem1.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static
            mapItem1.ShowDefaultTopicFirst = True
            mapItem1.UIElement = Me.ribbonButton1
            mapItem1.Url = "WordDocuments/howtousec1dynamichelp.htm"
            mapItem1.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me.ribbonButton1, mapItem1)
            Me.ribbonButton1.ID = "ribbonButton1"
            Me.ribbonButton1.Text = "How to use C1DynamicHelp"
            ' 
            ' ribbonButton9
            ' 
            mapItem2.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None
            mapItem2.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static
            mapItem2.ShowDefaultTopicFirst = True
            mapItem2.UIElement = Me.ribbonButton9
            mapItem2.Url = "WordDocuments/overview.htm"
            mapItem2.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me.ribbonButton9, mapItem2)
            Me.ribbonButton9.ID = "ribbonButton9"
            Me.ribbonButton9.Text = "Overview"
            ' 
            ' ribbonCheckBox1
            ' 
            mapItem3.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None
            mapItem3.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static
            mapItem3.ShowDefaultTopicFirst = True
            mapItem3.UIElement = Me.ribbonCheckBox1
            mapItem3.Url = "WordDocuments/glossaryofterms.htm"
            mapItem3.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me.ribbonCheckBox1, mapItem3)
            Me.ribbonCheckBox1.ID = "ribbonCheckBox1"
            Me.ribbonCheckBox1.Text = "Show the Glossary topic"
            ' 
            ' c1DynamicHelp1
            ' 
            Me.c1DynamicHelp1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1DynamicHelp1.HelpSource = "C1Sample.chm"
            Me.c1DynamicHelp1.Location = New System.Drawing.Point(0, 141)
            Me.c1DynamicHelp1.Name = "c1DynamicHelp1"
            Me.c1DynamicHelp1.Size = New System.Drawing.Size(495, 245)
            Me.c1DynamicHelp1.TabIndex = 0
            ' 
            ' c1Ribbon1
            ' 
            Me.c1Ribbon1.ApplicationMenuHolder = Me.ribbonApplicationMenu1
            Me.c1Ribbon1.ConfigToolBarHolder = Me.ribbonConfigToolBar1
            Me.c1Ribbon1.Location = New System.Drawing.Point(0, 0)
            Me.c1Ribbon1.MinimumHeight = 10
            Me.c1Ribbon1.Name = "c1Ribbon1"
            Me.c1Ribbon1.QatHolder = Me.ribbonQat1
            Me.c1Ribbon1.Size = New System.Drawing.Size(495, 141)
            Me.c1Ribbon1.TabIndex = 1
            Me.c1Ribbon1.Tabs.Add(Me.ribbonTab1)
            ' 
            ' ribbonApplicationMenu1
            ' 
            Me.ribbonApplicationMenu1.ID = "ribbonApplicationMenu1"
            Me.ribbonApplicationMenu1.LeftPaneItems.Add(Me.ribbonButton6)
            Me.ribbonApplicationMenu1.LeftPaneItems.Add(Me.ribbonButton7)
            Me.ribbonApplicationMenu1.LeftPaneItems.Add(Me.ribbonButton8)
            ' 
            ' ribbonButton6
            ' 
            Me.ribbonButton6.ID = "ribbonButton6"
            Me.ribbonButton6.LargeImage = My.Resources.btnSave            
            Me.ribbonButton6.Text = "Button"
            ' 
            ' ribbonButton7
            ' 
            Me.ribbonButton7.ID = "ribbonButton7"
            Me.ribbonButton7.LargeImage = My.Resources.redo
            Me.ribbonButton7.Text = "Button"
            ' 
            ' ribbonButton8
            ' 
            Me.ribbonButton8.ID = "ribbonButton8"
            Me.ribbonButton8.LargeImage = My.Resources.undo
            Me.ribbonButton8.Text = "Button"
            ' 
            ' ribbonConfigToolBar1
            ' 
            Me.ribbonConfigToolBar1.ID = "ribbonConfigToolBar1"
            ' 
            ' ribbonQat1
            ' 
            Me.ribbonQat1.ID = "ribbonQat1"
            Me.ribbonQat1.ItemLinks.Add(Me.ribbonButton6)
            Me.ribbonQat1.ItemLinks.Add(Me.ribbonButton7)
            Me.ribbonQat1.ItemLinks.Add(Me.ribbonButton8)
            ' 
            ' ribbonTab1
            ' 
            Me.ribbonTab1.Groups.Add(Me.ribbonGroup1)
            Me.ribbonTab1.ID = "ribbonTab1"
            ' 
            ' ribbonGroup1
            ' 
            Me.ribbonGroup1.ID = "ribbonGroup1"
            Me.ribbonGroup1.Items.Add(Me.ribbonButton9)
            Me.ribbonGroup1.Items.Add(Me.ribbonButton1)
            Me.ribbonGroup1.Items.Add(Me.ribbonCheckBox1)
            Me.ribbonGroup1.Text = "Point the mouse to the ribbon items above to see help topics"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(495, 386)
            Me.Controls.Add(Me.c1DynamicHelp1)
            Me.Controls.Add(Me.c1Ribbon1)
            mapItem4.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None
            mapItem4.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static
            mapItem4.ShowDefaultTopicFirst = True
            mapItem4.UIElement = Me
            mapItem4.Url = "WordDocuments/overview.htm"
            mapItem4.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me, mapItem4)
            Me.KeyPreview = True
            Me.Name = "Form1"
            Me.Text = "Using a custom UIElmentResolver"
            CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private c1DynamicHelp1 As C1.Win.C1DynamicHelp.C1DynamicHelp
        Private c1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
        Private ribbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
        Private ribbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
        Private ribbonQat1 As C1.Win.C1Ribbon.RibbonQat
        Private ribbonTab1 As C1.Win.C1Ribbon.RibbonTab
        Private ribbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
        Private ribbonButton6 As C1.Win.C1Ribbon.RibbonButton
        Private ribbonButton7 As C1.Win.C1Ribbon.RibbonButton
        Private ribbonButton8 As C1.Win.C1Ribbon.RibbonButton
        Private ribbonButton9 As C1.Win.C1Ribbon.RibbonButton
        Private ribbonButton1 As C1.Win.C1Ribbon.RibbonButton
        Private ribbonCheckBox1 As C1.Win.C1Ribbon.RibbonCheckBox
    End Class
End Namespace

