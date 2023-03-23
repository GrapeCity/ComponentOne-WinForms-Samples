Imports Microsoft.VisualBasic
Imports System
Namespace Tutorial2
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
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Overview")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Design time")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Runtime")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How to use", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.treeView1 = New System.Windows.Forms.TreeView
            Me.c1DynamicHelp1 = New C1.Win.C1DynamicHelp.C1DynamicHelp
            Me.SuspendLayout()
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(12, 12)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(142, 20)
            Me.textBox1.TabIndex = 1
            Me.textBox1.Text = "Show topic on focus"
            '
            'treeView1
            '
            Me.treeView1.Location = New System.Drawing.Point(12, 48)
            Me.treeView1.Name = "treeView1"
            TreeNode1.Name = "Node0"
            TreeNode1.Text = "Overview"
            TreeNode2.Name = "Node2"
            TreeNode2.Text = "Design time"
            TreeNode3.Name = "Node3"
            TreeNode3.Text = "Runtime"
            TreeNode4.Name = "Node1"
            TreeNode4.Text = "How to use"
            Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode4})
            Me.treeView1.Size = New System.Drawing.Size(142, 206)
            Me.treeView1.TabIndex = 2
            '
            'c1DynamicHelp1
            '
            Me.c1DynamicHelp1.HelpSource = "C1Sample.chm"
            Me.c1DynamicHelp1.Location = New System.Drawing.Point(160, 0)
            Me.c1DynamicHelp1.Name = "c1DynamicHelp1"
            Me.c1DynamicHelp1.Size = New System.Drawing.Size(245, 266)
            Me.c1DynamicHelp1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(405, 266)
            Me.Controls.Add(Me.treeView1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.c1DynamicHelp1)
            Me.KeyPreview = True
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private c1DynamicHelp1 As C1.Win.C1DynamicHelp.C1DynamicHelp
        Private textBox1 As System.Windows.Forms.TextBox
        Private treeView1 As System.Windows.Forms.TreeView
    End Class
End Namespace

