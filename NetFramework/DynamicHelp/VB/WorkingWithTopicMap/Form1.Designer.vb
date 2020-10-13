Imports Microsoft.VisualBasic
Imports System
Namespace WorkingWithTopicMap
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
            Me.c1DynamicHelp1 = New C1.Win.C1DynamicHelp.C1DynamicHelp
            Me.btnLoad = New System.Windows.Forms.Button
            Me.btnLoadFrom = New System.Windows.Forms.Button
            Me.btnSave = New System.Windows.Forms.Button
            Me.btnSaveAs = New System.Windows.Forms.Button
            Me.btnLoadFromRes = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'c1DynamicHelp1
            '
            Me.c1DynamicHelp1.HelpSource = "C1Sample.chm"
            Me.c1DynamicHelp1.Location = New System.Drawing.Point(381, 0)
            Me.c1DynamicHelp1.Name = "c1DynamicHelp1"
            Me.c1DynamicHelp1.Size = New System.Drawing.Size(250, 382)
            Me.c1DynamicHelp1.TabIndex = 0
            '
            'btnLoad
            '
            Me.btnLoad.Location = New System.Drawing.Point(6, 64)
            Me.btnLoad.Name = "btnLoad"
            Me.btnLoad.Size = New System.Drawing.Size(244, 23)
            Me.btnLoad.TabIndex = 1
            Me.btnLoad.Text = "Load topic map from the default location"
            Me.btnLoad.UseVisualStyleBackColor = True
            '
            'btnLoadFrom
            '
            Me.btnLoadFrom.Location = New System.Drawing.Point(6, 93)
            Me.btnLoadFrom.Name = "btnLoadFrom"
            Me.btnLoadFrom.Size = New System.Drawing.Size(244, 23)
            Me.btnLoadFrom.TabIndex = 2
            Me.btnLoadFrom.Text = "Load topic map from file..."
            Me.btnLoadFrom.UseVisualStyleBackColor = True
            '
            'btnSave
            '
            Me.btnSave.Location = New System.Drawing.Point(6, 84)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(244, 23)
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "Save topic map to the default location"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnSaveAs
            '
            Me.btnSaveAs.Location = New System.Drawing.Point(6, 113)
            Me.btnSaveAs.Name = "btnSaveAs"
            Me.btnSaveAs.Size = New System.Drawing.Size(244, 23)
            Me.btnSaveAs.TabIndex = 3
            Me.btnSaveAs.Text = "Save topic map to a file..."
            Me.btnSaveAs.UseVisualStyleBackColor = True
            '
            'btnLoadFromRes
            '
            Me.btnLoadFromRes.Location = New System.Drawing.Point(6, 124)
            Me.btnLoadFromRes.Name = "btnLoadFromRes"
            Me.btnLoadFromRes.Size = New System.Drawing.Size(244, 23)
            Me.btnLoadFromRes.TabIndex = 5
            Me.btnLoadFromRes.Text = "Load topic map from resources"
            Me.btnLoadFromRes.UseVisualStyleBackColor = True
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(6, 16)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(235, 45)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Loading different topic maps, note that different topics will be displayed when y" & _
                "ou move the mouse over the form surface."
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(6, 20)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(244, 64)
            Me.label2.TabIndex = 7
            Me.label2.Text = "Activate authoring mode by pressing Ctrl+Shift+A, then you will be able to change" & _
                " the currently loaded topic map. Then you can save it to a file and load it back" & _
                "."
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.btnLoad)
            Me.groupBox1.Controls.Add(Me.btnLoadFrom)
            Me.groupBox1.Controls.Add(Me.btnLoadFromRes)
            Me.groupBox1.Location = New System.Drawing.Point(27, 12)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(280, 162)
            Me.groupBox1.TabIndex = 8
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Load topic map"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.label2)
            Me.groupBox2.Controls.Add(Me.btnSaveAs)
            Me.groupBox2.Controls.Add(Me.btnSave)
            Me.groupBox2.Location = New System.Drawing.Point(27, 190)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(280, 149)
            Me.groupBox2.TabIndex = 9
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Modify and save topic map"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(631, 382)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.c1DynamicHelp1)
            Me.KeyPreview = True
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private c1DynamicHelp1 As C1.Win.C1DynamicHelp.C1DynamicHelp
        Private WithEvents btnLoad As System.Windows.Forms.Button
        Private WithEvents btnLoadFrom As System.Windows.Forms.Button
        Private WithEvents btnSave As System.Windows.Forms.Button
        Private WithEvents btnSaveAs As System.Windows.Forms.Button
        Private WithEvents btnLoadFromRes As System.Windows.Forms.Button
        Private label1 As System.Windows.Forms.Label
        Private label2 As System.Windows.Forms.Label
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private groupBox2 As System.Windows.Forms.GroupBox
    End Class
End Namespace

