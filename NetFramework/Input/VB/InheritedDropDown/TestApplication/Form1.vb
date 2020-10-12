Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents fontEdit4 As C1.Win.C1Input.FontEdit
    Friend WithEvents fontEdit3 As C1.Win.C1Input.FontEdit
    Friend WithEvents fontEdit2 As C1.Win.C1Input.FontEdit
    Friend WithEvents fontEdit1 As C1.Win.C1Input.FontEdit
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.fontEdit4 = New C1.Win.C1Input.FontEdit()
        Me.fontEdit3 = New C1.Win.C1Input.FontEdit()
        Me.fontEdit2 = New C1.Win.C1Input.FontEdit()
        Me.fontEdit1 = New C1.Win.C1Input.FontEdit()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.fontEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fontEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fontEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(400, 164)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        '
        'fontEdit4
        '
        Me.fontEdit4.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Center
        Me.fontEdit4.GapHeight = -105
        Me.fontEdit4.Location = New System.Drawing.Point(232, 132)
        Me.fontEdit4.Name = "fontEdit4"
        Me.fontEdit4.Size = New System.Drawing.Size(244, 20)
        Me.fontEdit4.TabIndex = 16
        Me.fontEdit4.Tag = Nothing
        Me.fontEdit4.Value = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontEdit4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'fontEdit3
        '
        Me.fontEdit3.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.fontEdit3.Location = New System.Drawing.Point(232, 92)
        Me.fontEdit3.Name = "fontEdit3"
        Me.fontEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.fontEdit3.Size = New System.Drawing.Size(244, 20)
        Me.fontEdit3.TabIndex = 14
        Me.fontEdit3.Tag = Nothing
        Me.fontEdit3.Value = New System.Drawing.Font("Arial", 9.75!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontEdit3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'fontEdit2
        '
        Me.fontEdit2.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Center
        Me.fontEdit2.Location = New System.Drawing.Point(232, 52)
        Me.fontEdit2.Name = "fontEdit2"
        Me.fontEdit2.Size = New System.Drawing.Size(244, 20)
        Me.fontEdit2.TabIndex = 12
        Me.fontEdit2.Tag = Nothing
        Me.fontEdit2.Value = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'fontEdit1
        '
        Me.fontEdit1.Location = New System.Drawing.Point(232, 12)
        Me.fontEdit1.Name = "fontEdit1"
        Me.fontEdit1.Size = New System.Drawing.Size(244, 20)
        Me.fontEdit1.TabIndex = 10
        Me.fontEdit1.Tag = Nothing
        Me.fontEdit1.Value = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(16, 132)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(212, 40)
        Me.label4.TabIndex = 15
        Me.label4.Text = "1234567890"
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Arial", 9.75!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(16, 92)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(212, 40)
        Me.label3.TabIndex = 13
        Me.label3.Text = "the lazy dog."
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(16, 52)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(212, 40)
        Me.label2.TabIndex = 11
        Me.label2.Text = "fox jumps over"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(16, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(212, 40)
        Me.label1.TabIndex = 9
        Me.label1.Text = "The quick brown"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(488, 197)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.fontEdit4, Me.fontEdit3, Me.fontEdit2, Me.fontEdit1, Me.label4, Me.label3, Me.label2, Me.label1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Control Inherited From C1DropDownControl"
        CType(Me.fontEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fontEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fontEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub fontEdit1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontEdit1.ValueChanged
        Try
            Dim v As Object = fontEdit1.Value
            If Not v Is Nothing And TypeOf v Is Font Then
                label1.Font = DirectCast(v, Font)
            End If
        Catch
        End Try
    End Sub

    Private Sub fontEdit2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontEdit2.ValueChanged
        Try
            Dim v As Object = fontEdit2.Value
            If Not v Is Nothing And TypeOf v Is Font Then
                label2.Font = DirectCast(v, Font)
            End If
        Catch
        End Try
    End Sub

    Private Sub fontEdit3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontEdit3.ValueChanged
        Try
            Dim v As Object = fontEdit3.Value
            If Not v Is Nothing And TypeOf v Is Font Then
                label3.Font = DirectCast(v, Font)
            End If
        Catch
        End Try
    End Sub

    Private Sub fontEdit4_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontEdit4.ValueChanged
        Try
            Dim v As Object = fontEdit4.Value
            If Not v Is Nothing And TypeOf v Is Font Then
                label4.Font = DirectCast(v, Font)
            End If
        Catch
        End Try
    End Sub
End Class
