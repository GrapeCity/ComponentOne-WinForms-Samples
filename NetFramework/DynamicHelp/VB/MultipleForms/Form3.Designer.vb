Imports Microsoft.VisualBasic
Imports System
Namespace MultipleForms
    Partial Public Class Form3
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
            Dim listViewItem1 As New System.Windows.Forms.ListViewItem("Overview")
            Dim listViewItem2 As New System.Windows.Forms.ListViewItem("How to use C1DynamicHelp")
            Dim listViewItem3 As New System.Windows.Forms.ListViewItem("Glossary")
            Me.label1 = New System.Windows.Forms.Label()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.SuspendLayout()
            ' 
            ' c1DynamicHelp1
            ' 
            Me.c1DynamicHelp1.Location = New System.Drawing.Point(226, 0)
            Me.c1DynamicHelp1.Size = New System.Drawing.Size(164, 314)
            ' 
            ' label1
            ' 
            Me.label1.Location = New System.Drawing.Point(12, 9)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(170, 47)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Point the mouse to list items below to see help topics associated with them:"
            ' 
            ' listView1
            ' 
            Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem1, listViewItem2, listViewItem3})
            Me.listView1.Location = New System.Drawing.Point(15, 59)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(167, 195)
            Me.listView1.TabIndex = 4
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.List
            ' 
            ' Form3
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(390, 314)
            Me.Controls.Add(Me.listView1)
            Me.Controls.Add(Me.label1)
            Me.Name = "Form3"
            Me.Text = "Form3"
            Me.Controls.SetChildIndex(Me.c1DynamicHelp1, 0)
            Me.Controls.SetChildIndex(Me.label1, 0)
            Me.Controls.SetChildIndex(Me.listView1, 0)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private label1 As System.Windows.Forms.Label
        Private listView1 As System.Windows.Forms.ListView

    End Class
End Namespace