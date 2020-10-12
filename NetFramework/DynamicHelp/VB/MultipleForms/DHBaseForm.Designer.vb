Imports Microsoft.VisualBasic
Imports System
Namespace MultipleForms
    Partial Public Class DHBaseForm
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
            Me.SuspendLayout()
            '
            'c1DynamicHelp1
            '
            Me.c1DynamicHelp1.Location = New System.Drawing.Point(128, 0)
            Me.c1DynamicHelp1.Name = "c1DynamicHelp1"
            Me.c1DynamicHelp1.Size = New System.Drawing.Size(164, 266)
            Me.c1DynamicHelp1.TabIndex = 0
            '
            'DHBaseForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(292, 266)
            Me.Controls.Add(Me.c1DynamicHelp1)
            Me.KeyPreview = True
            Me.Name = "DHBaseForm"
            Me.Text = "DHBaseForm"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Protected c1DynamicHelp1 As C1.Win.C1DynamicHelp.C1DynamicHelp

    End Class
End Namespace