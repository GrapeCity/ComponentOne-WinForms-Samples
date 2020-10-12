Imports Microsoft.VisualBasic
Imports System
Namespace Tutorial1
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
            Dim MapItem1 As C1.Win.C1DynamicHelp.MapItem = New C1.Win.C1DynamicHelp.MapItem
            Dim MapItem2 As C1.Win.C1DynamicHelp.MapItem = New C1.Win.C1DynamicHelp.MapItem
            Dim MapItem3 As C1.Win.C1DynamicHelp.MapItem = New C1.Win.C1DynamicHelp.MapItem
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.button1 = New System.Windows.Forms.Button
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.c1DynamicHelp1 = New C1.Win.C1DynamicHelp.C1DynamicHelp
            Me.SuspendLayout()
            '
            'textBox1
            '
            MapItem1.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.Enter
            MapItem1.ItemType = C1.Win.C1DynamicHelp.MapItemType.[Static]
            MapItem1.ShowDefaultTopicFirst = True
            MapItem1.UIElement = Me.textBox1
            MapItem1.Url = "WordDocuments/designtimesupport.htm"
            MapItem1.UseDefaultTrigger = False
            Me.c1DynamicHelp1.SetHelpTopic(Me.textBox1, MapItem1)
            Me.textBox1.Location = New System.Drawing.Point(4, 12)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(150, 20)
            Me.textBox1.TabIndex = 5
            Me.textBox1.Text = "Show topic on focus"
            '
            'button1
            '
            MapItem2.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.MouseEnter
            MapItem2.ItemType = C1.Win.C1DynamicHelp.MapItemType.[Static]
            MapItem2.ShowDefaultTopicFirst = True
            MapItem2.UIElement = Me.button1
            MapItem2.Url = "WordDocuments/runtimesupport.htm"
            MapItem2.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me.button1, MapItem2)
            Me.button1.Location = New System.Drawing.Point(4, 49)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(150, 37)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Show topic on mouse hover"
            Me.button1.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(4, 105)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(160, 17)
            Me.checkBox1.TabIndex = 6
            Me.checkBox1.Text = "Show topic programmatically"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'c1DynamicHelp1
            '
            Me.c1DynamicHelp1.HelpSource = "..\\..\\Data\\C1Sample.chm"
            Me.c1DynamicHelp1.Location = New System.Drawing.Point(165, 0)
            Me.c1DynamicHelp1.Name = "c1DynamicHelp1"
            Me.c1DynamicHelp1.Size = New System.Drawing.Size(262, 268)
            Me.c1DynamicHelp1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(427, 268)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.c1DynamicHelp1)
            MapItem3.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.None
            MapItem3.ItemType = C1.Win.C1DynamicHelp.MapItemType.[Static]
            MapItem3.ShowDefaultTopicFirst = True
            MapItem3.UIElement = Me
            MapItem3.Url = "WordDocuments/overview.htm"
            MapItem3.UseDefaultTrigger = True
            Me.c1DynamicHelp1.SetHelpTopic(Me, MapItem3)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private c1DynamicHelp1 As C1.Win.C1DynamicHelp.C1DynamicHelp
        Private button1 As System.Windows.Forms.Button
        Private textBox1 As System.Windows.Forms.TextBox
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    End Class
End Namespace

