Imports Microsoft.VisualBasic
Imports System
Namespace MultipleForms
    Partial Public Class Form2
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
            Dim treeNode1 As New System.Windows.Forms.TreeNode("Design time")
            Dim treeNode2 As New System.Windows.Forms.TreeNode("Runtime")
            Dim treeNode3 As New System.Windows.Forms.TreeNode("How to use C1DynamicHelp", New System.Windows.Forms.TreeNode() { treeNode1, treeNode2})
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.treeView1 = New System.Windows.Forms.TreeView()
            Me.SuspendLayout()
            ' 
            ' c1DynamicHelp1
            ' 
            Me.c1DynamicHelp1.Location = New System.Drawing.Point(341, 0)
            Me.c1DynamicHelp1.Size = New System.Drawing.Size(171, 391)
            ' 
            ' comboBox1
            ' 
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(15, 62)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(167, 21)
            Me.comboBox1.TabIndex = 1
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(12, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(287, 50)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Point the mouse to the sample controls below to see help topics associated with t" & "hem. Note that each tree node has an individual topic associated with it."
            ' 
            ' treeView1
            ' 
            Me.treeView1.Location = New System.Drawing.Point(15, 90)
            Me.treeView1.Name = "treeView1"
            treeNode1.Name = "Node1"
            treeNode1.Text = "Design time"
            treeNode2.Name = "Node2"
            treeNode2.Text = "Runtime"
            treeNode3.Name = "Node0"
            treeNode3.Text = "How to use C1DynamicHelp"
            Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode3})
            Me.treeView1.Size = New System.Drawing.Size(167, 164)
            Me.treeView1.TabIndex = 3
            ' 
            ' Form2
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(512, 391)
            Me.Controls.Add(Me.treeView1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.comboBox1)
            Me.Name = "Form2"
            Me.Text = "Form2"
            Me.Controls.SetChildIndex(Me.comboBox1, 0)
            Me.Controls.SetChildIndex(Me.label1, 0)
            Me.Controls.SetChildIndex(Me.treeView1, 0)
            Me.Controls.SetChildIndex(Me.c1DynamicHelp1, 0)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private comboBox1 As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private treeView1 As System.Windows.Forms.TreeView

    End Class
End Namespace