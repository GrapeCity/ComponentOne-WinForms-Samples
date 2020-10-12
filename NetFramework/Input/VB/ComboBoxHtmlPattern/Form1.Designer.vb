<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cbxSelectSample = New C1.Win.C1Input.C1ComboBox()
        Me.cbxResult = New C1.Win.C1Input.C1ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxHtmlPattern = New System.Windows.Forms.TextBox()
        Me._imageList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.cbxSelectSample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxSelectSample
        '
        Me.cbxSelectSample.AllowSpinLoop = False
        Me.cbxSelectSample.GapHeight = 0
        Me.cbxSelectSample.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cbxSelectSample.ItemsDisplayMember = ""
        Me.cbxSelectSample.ItemsValueMember = ""
        Me.cbxSelectSample.Location = New System.Drawing.Point(13, 29)
        Me.cbxSelectSample.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxSelectSample.Name = "cbxSelectSample"
        Me.cbxSelectSample.Size = New System.Drawing.Size(286, 20)
        Me.cbxSelectSample.TabIndex = 0
        Me.cbxSelectSample.Tag = Nothing
        '
        'cbxResult
        '
        Me.cbxResult.AllowSpinLoop = False
        Me.cbxResult.GapHeight = 0
        Me.cbxResult.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cbxResult.ItemsDisplayMember = ""
        Me.cbxResult.ItemsValueMember = ""
        Me.cbxResult.Location = New System.Drawing.Point(13, 101)
        Me.cbxResult.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxResult.Name = "cbxResult"
        Me.cbxResult.Size = New System.Drawing.Size(286, 20)
        Me.cbxResult.TabIndex = 1
        Me.cbxResult.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Open drop-down list to see the result:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select a sample:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "HtmlPattern:"
        '
        'tbxHtmlPattern
        '
        Me.tbxHtmlPattern.Location = New System.Drawing.Point(313, 29)
        Me.tbxHtmlPattern.Multiline = True
        Me.tbxHtmlPattern.Name = "tbxHtmlPattern"
        Me.tbxHtmlPattern.ReadOnly = True
        Me.tbxHtmlPattern.Size = New System.Drawing.Size(556, 283)
        Me.tbxHtmlPattern.TabIndex = 5
        '
        '_imageList
        '
        Me._imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me._imageList.ImageSize = New System.Drawing.Size(16, 16)
        Me._imageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 315)
        Me.Controls.Add(Me.tbxHtmlPattern)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxResult)
        Me.Controls.Add(Me.cbxSelectSample)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1ComboBox HtmlPattern property sample"
        CType(Me.cbxSelectSample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxSelectSample As C1.Win.C1Input.C1ComboBox
    Friend WithEvents cbxResult As C1.Win.C1Input.C1ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxHtmlPattern As TextBox
    Friend WithEvents _imageList As ImageList
End Class
