Partial Class BaseEditorForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
    ''' </summary>
    ''' <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me._btnOK = New System.Windows.Forms.Button()
        Me._btnCancel = New System.Windows.Forms.Button()
        Me._btnAplly = New System.Windows.Forms.Button()
        Me._containerMain = New System.Windows.Forms.GroupBox()
        Me._containerMain.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' _btnOK
        ' 
        Me._btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me._btnOK.Location = New System.Drawing.Point(280, 286)
        Me._btnOK.Name = "_btnOK"
        Me._btnOK.Size = New System.Drawing.Size(91, 25)
        Me._btnOK.TabIndex = 1
        Me._btnOK.Text = "OK"
        Me._btnOK.UseVisualStyleBackColor = True
        ' 
        ' _btnCancel
        ' 
        Me._btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.Location = New System.Drawing.Point(377, 286)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(91, 25)
        Me._btnCancel.TabIndex = 2
        Me._btnCancel.Text = "Cancel"
        Me._btnCancel.UseVisualStyleBackColor = True
        ' 
        ' _btnAplly
        ' 
        Me._btnAplly.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._btnAplly.Location = New System.Drawing.Point(474, 286)
        Me._btnAplly.Name = "_btnAplly"
        Me._btnAplly.Size = New System.Drawing.Size(91, 25)
        Me._btnAplly.TabIndex = 3
        Me._btnAplly.Text = "Apply"
        Me._btnAplly.UseVisualStyleBackColor = True
        AddHandler Me._btnAplly.Click, New System.EventHandler(AddressOf Me.ApllyClick)
        ' 
        ' _splitContainerMain
        ' 
        Me._containerMain.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me._containerMain.Cursor = System.Windows.Forms.Cursors.[Default]
        Me._containerMain.Location = New System.Drawing.Point(12, 12)
        Me._containerMain.Name = "_containerMain"
        Me._containerMain.Size = New System.Drawing.Size(553, 268)
        Me._containerMain.TabIndex = 0
        ' 
        ' BaseEditorForm
        ' 
        Me.AcceptButton = Me._btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me._btnCancel
        Me.ClientSize = New System.Drawing.Size(577, 323)
        Me.Controls.Add(Me._btnAplly)
        Me.Controls.Add(Me._btnOK)
        Me.Controls.Add(Me._btnCancel)
        Me.Controls.Add(Me._containerMain)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(415, 174)
        Me.Name = "BaseEditorForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BaseEditorForm"
        Me._containerMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Protected _btnOK As System.Windows.Forms.Button
    Protected _btnCancel As System.Windows.Forms.Button
    Protected _btnAplly As System.Windows.Forms.Button
    Protected _containerMain As System.Windows.Forms.GroupBox



End Class
