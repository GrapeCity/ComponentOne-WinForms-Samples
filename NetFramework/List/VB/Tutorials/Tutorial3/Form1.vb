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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents C1List1 As C1.Win.List.C1List
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.C1List1 = New C1.Win.List.C1List()
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Record"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(168, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Delete Selected"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(312, 288)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 32)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Clear All"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 240)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "TextBox1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(168, 240)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(96, 20)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "TextBox2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(168, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(312, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Phone Number:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(312, 240)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(96, 20)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "TextBox3"
        '
        'C1List1
        '
        Me.C1List1.AddItemCols = 0
        Me.C1List1.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.C1List1.AllowSort = True
        Me.C1List1.AlternatingRows = False
        Me.C1List1.Caption = "C1List .Net"
        Me.C1List1.CaptionHeight = 17
        Me.C1List1.ColumnCaptionHeight = 17
        Me.C1List1.ColumnFooterHeight = 17
        Me.C1List1.DataMode = C1.Win.List.DataModeEnum.AddItem
        Me.C1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark
        Me.C1List1.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1List1.ItemHeight = 15
        Me.C1List1.Location = New System.Drawing.Point(32, 16)
        Me.C1List1.MatchCol = C1.Win.List.MatchColEnum.DisplayMember
        Me.C1List1.MatchCompare = C1.Win.List.MatchCompareEnum.PartiallyEqual
        Me.C1List1.MatchEntry = C1.Win.List.MatchEntryEnum.None
        Me.C1List1.MatchEntryTimeout = CType(2000, Long)
        Me.C1List1.Name = "C1List1"
        Me.C1List1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.None
        Me.C1List1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1List1.ScrollTips = False
        Me.C1List1.Size = New System.Drawing.Size(368, 184)
        Me.C1List1.TabIndex = 12
        Me.C1List1.Text = "C1List1"
        Me.C1List1.PropBag = CType(resources.GetObject("C1List1.PropBag"), String)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 341)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.C1List1, Me.TextBox3, Me.Label3, Me.Label2, Me.Label1, Me.TextBox2, Me.TextBox1, Me.Button3, Me.Button2, Me.Button1})
        Me.Name = "Form1"
        Me.Text = "C1List .Net Tutorial3"
        CType(Me.C1List1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.C1List1.RemoveItem(Me.C1List1.SelectedIndex)
        Catch
            MessageBox.Show("Select an item from the list first.", "TDBList")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.C1List1.ClearItems()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me.C1List1
            .AddItemTitles("First Name; LastName; Phone Number")
            .AddItem("Greg;Daryll;412-657-3412")
            .AddItem("Jane;Lambert;567-123-6785")
            .AddItem("Allen;Clark;675-345-9087")
            .AddItem("David;Elkins;564-345-2635")
            .AddItem("Carl;Ziegler;412-678-2351")
            .AddItem("William;Yahner;412-980-6754")
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.C1List1.AddItem(Me.TextBox1.Text + ";" + Me.TextBox2.Text + ";" + Me.TextBox3.Text)
    End Sub

End Class
