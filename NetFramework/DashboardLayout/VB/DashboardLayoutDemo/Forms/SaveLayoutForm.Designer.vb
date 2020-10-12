Namespace DashboardDemo
    Partial Public Class SaveLayoutForm
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.c1TextBox1 = New C1.Win.C1Input.C1TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.btnOK = New C1.Win.C1Input.C1Button()
            Me.btnCancel = New C1.Win.C1Input.C1Button()
            CType((Me.c1TextBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnOK), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.btnCancel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.c1TextBox1.Location = New System.Drawing.Point(25, 34)
            Me.c1TextBox1.Name = "c1TextBox1"
            Me.c1TextBox1.Size = New System.Drawing.Size(240, 18)
            Me.c1TextBox1.TabIndex = 0
            Me.c1TextBox1.Tag = Nothing
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(22, 18)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(71, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Layout name:"
            Me.btnOK.Location = New System.Drawing.Point(129, 74)
            Me.btnOK.Name = "btnOK"
            Me.btnOK.Size = New System.Drawing.Size(75, 23)
            Me.btnOK.TabIndex = 1
            Me.btnOK.Text = "OK"
            Me.btnOK.UseVisualStyleBackColor = True
            AddHandler Me.btnOK.Click, New System.EventHandler(AddressOf Me.btnOK_Click)
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Location = New System.Drawing.Point(210, 74)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(75, 23)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = True
            Me.AcceptButton = Me.btnOK
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(297, 103)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnOK)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.c1TextBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "SaveLayoutForm"
            Me.Text = "Save Layout"
            CType((Me.c1TextBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnOK), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.btnCancel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private c1TextBox1 As C1.Win.C1Input.C1TextBox
        Private label1 As System.Windows.Forms.Label
        Private btnOK As C1.Win.C1Input.C1Button
        Private btnCancel As C1.Win.C1Input.C1Button
    End Class
End Namespace
